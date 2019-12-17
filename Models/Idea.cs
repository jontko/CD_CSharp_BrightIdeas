using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BrightIdeas.Models
    {
        public class Idea
        {
            // auto-implemented properties need to match the columns in your table
            // the [Key] attribute is used to mark the Model property being used for your table's Primary Key
            [Key]
            public int IdeaId { get; set; }
            // MySQL VARCHAR and TEXT types can be represented by a string
            [Required]
            public string Concept { get; set; } 
            // The MySQL DATETIME type can be represented by a DateTime
            public int UserId { get; set; }
            public DateTime CreatedAt {get;set;} = DateTime.Now;
            public DateTime UpdatedAt {get;set;} = DateTime.Now;
            public User IdeaOwner { get; set; }
            public List<Like> Likes { get; set; }
        }
    }