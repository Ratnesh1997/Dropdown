using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dropdown.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }
        [Required]

        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
     
        [Display(Name = "Password")]
        public string Password { get; set; }
      
     
    }
}
