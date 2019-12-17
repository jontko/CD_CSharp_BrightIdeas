using System.ComponentModel.DataAnnotations;
    using System;
    namespace BrightIdeas.Models
    {
        public class Like
        {
            [Key]
            public int LikeId { get; set; } 
            public int IdeaId { get; set; }
            public int UserId { get; set; }
            public Idea Idea { get; set;}
            public User User { get; set; }
            public DateTime CreatedAt {get;set;} = DateTime.Now;
            public DateTime UpdatedAt {get;set;} = DateTime.Now;
        }
    }