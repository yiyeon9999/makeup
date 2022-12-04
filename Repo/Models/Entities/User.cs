using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repo.Models.Entities
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string Id { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public string IdInfoDetail { set; get; }
        public string HistoryId { set; get; }
        public string Email { set; get; }

    }
}
