using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repo.Models.Entities
{
    public class Post
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string Id { set; get; }

        // User
        public string UserId { set; get; }
        public User User { set; get; }

        // Course
        public string CourseId { set; get; }
        public Course Course { set; get; }  
        public string Title { set; get; }
        public int Status { set; get; }
        public DateTime CreatedOn { set; get; }
        public DateTime CreatedBy { set; get; }
        public DateTime UpdatedOn { set; get; }
        public DateTime UpdatedBy { set; get; }
    }
}
