using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BrightIdeas.Models
    {
        public class Idea
        {
            
            [Key]
            public int IdeaId { get; set; }

            [Required]
            public string Concept { get; set; } 
            public int UserId { get; set; }
            public DateTime CreatedAt {get;set;} = DateTime.Now;
            public DateTime UpdatedAt {get;set;} = DateTime.Now;
            public User IdeaOwner { get; set; }
            public List<Like> Likes { get; set; }
        }
    }