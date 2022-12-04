using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repo.Models.Entities
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string Id { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public decimal Price { set; get; }
        public string CategoryId { set; get; }
        public string UserId { set; get; }
        public string Schedule { set; get; }

        public DateTime CreatedOn { set; get; }
        public DateTime CreatedBy { set; get; }
        public DateTime UpdatedOn { set; get; }
        public DateTime UpdatedBy { set; get; }
    }
}
