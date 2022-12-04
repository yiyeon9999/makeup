using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repo.Models.Entities
{
    public class History
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string Id { set; get; }
        public string BookingId { set; get; }
        public Booking Booking { set; get; }
        public string UserId { set; get; }
        public User User { set; get; }

    }
}
