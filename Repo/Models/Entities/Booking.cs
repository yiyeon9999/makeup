using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repo.Models.Entities
{
    public class Booking
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string Id { set; get; }
        public string Name { set; get; }
        public string UserId { set; get; }
        public User User { set; get; }
        public string TypeId { set; get; }
        public Type Type { set; get; }  
        public string CategoryId { set; get; }
        public Category Category { set; get; }
        public string HistoryId { set; get; }
        //public History History { set; get; }
        public decimal Discount { set; get; }
        public decimal Price { set; get; }
        public string AppointmentSchedule { set; get; }
        public DateTime CreatedOn { set; get; }
        public DateTime CreatedBy { set; get; }
        public DateTime UpdatedOn { set; get; }
        public DateTime UpdatedBy { set; get; }

    }
}
