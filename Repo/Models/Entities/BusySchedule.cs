using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repo.Models.Entities
{
    public class BusySchedule
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { set; get; }
        public string Appointment { set; get; }
    }
}
