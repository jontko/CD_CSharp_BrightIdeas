using System.ComponentModel.DataAnnotations.Schema; // <- add this to allow mapping features. 
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BrightIdeas.Models
    {
        public class User
        {
            [Key]
            public int UserId { get; set; }
            // MySQL VARCHAR and TEXT types can be represented by a string
            [Required]
            [MinLength(3)]
            public string Name { get; set; }

            [Required]
            [MinLength(3)]
            public string Alias { get; set; }

            [Required]
            [MinLength(3)]
            public string Email { get; set; }

            [Required]
            [MinLength(8)]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [NotMapped] //<- this is placed above the field you do not want to map.
            [DataType(DataType.Password)]
            public string ConfPass { get; set; }

            // The MySQL DATETIME type can be represented by a DateTime
            public DateTime CreatedAt {get;set;} = DateTime.Now;
            public DateTime UpdatedAt {get;set;} = DateTime.Now;

            //navigation properties below - these connect models to each other. 
            public List<Idea> UserIdeas {get; set; } //Connects Users to weddings they created
            public List<Like> UserLikes{ get; set; } //Connects Users to RSVP they created
            
        }

        public class Login
        {
            public string EmailLogin { get; set; }

            [DataType(DataType.Password)]
            public string PasswordLogin { get; set; }

        }
    }