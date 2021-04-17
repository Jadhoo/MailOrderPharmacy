using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginPortal.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        [Required(ErrorMessage ="This is a required field")]     
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "This is a required field")]
        public string Password { get; set; }
    }
}
