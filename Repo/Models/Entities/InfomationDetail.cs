using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repo.Models.Entities
{
    public class InfomationDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string Id { set; get; }
        public string UserId { set; get; }
        public User User { set; get; }
        public string FullName { set; get; }
        public int Age { set; get; }
        public string Address { set; get; }
        public string PhoneNumber { set; get; }
        public bool Gender { set; get; }
    }
}
