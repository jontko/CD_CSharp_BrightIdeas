using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using BrightIdeas.Models;

namespace BrightIdeas.Controllers
{
    public class HomeController : Controller
    {
        private int? usersession{
            get{
                return HttpContext.Session.GetInt32("UserID");
            }
            set{
                HttpContext.Session.SetInt32("UserID", (int)value);
            }
        }

        private MyContext DbContext;

        public HomeController (MyContext context)
        {
        DbContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost("Register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                DbContext.Add(newUser);
                DbContext.SaveChanges();
                usersession = DbContext.Users.FirstOrDefault(u => u.Email==newUser.Email).UserId;
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpPost("Login")]
        public IActionResult Login(Login person)
        {
            if(ModelState.IsValid)
            {
                User oneUser = DbContext.Users.FirstOrDefault(user => user.Email == person.EmailLogin);
                if (oneUser == null)
                {
                    ModelState.AddModelError("EmailLogin", "Email not found.");
                    return View("Index");
                }
                var hasher = new PasswordHasher<Login>();
                var result = hasher.VerifyHashedPassword(person, oneUser.Password, person.PasswordLogin);
                if(result == 0)
                {
                    ModelState.AddModelError("PasswordLogin", "Password was not recognized.");
                    return View("Index");
                }
                usersession = oneUser.UserId;
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("Dashboard")]
        public IActionResult Dashboard()
        {
            List<Idea> AllIdeas = DbContext.Ideas
            .Include(idea => idea.Likes)
            .Include(idea => idea.IdeaOwner)
            .ToList();
            ViewBag.Id=usersession;
            return View("Dashboard", AllIdeas);

            // Looks like this is passing a List of Ideas to the dashboard. I need this passed to PartialIdeaScroll.cshtml
            // I need the Logged in user info passed to dashboard. This is in Viewbag.Id it apears. 
        }

        [HttpGet("LogOut")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }

        [HttpPost("Create")]
        public IActionResult Create(Idea idea) // (Type variable_being_passed)
        {
            if(ModelState.IsValid){
            idea.UserId=(int)HttpContext.Session.GetInt32("UserID");
            DbContext.Add(idea);
            DbContext.SaveChanges();
            return RedirectToAction("Dashboard");
            }
            return View("Dashboard", idea);
        }
        [HttpGet("New")]
        public IActionResult New()
        {
            return View("Dashboard");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
