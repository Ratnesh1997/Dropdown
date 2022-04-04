using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dropdown.Models
{
    public class Registration
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Text)]
        [DisplayName("Enter First Name")]
        [Required(ErrorMessage = "First Name Can't be Null")]
        public string FirstName { get; set; }
        [DataType(DataType.Text)]
        [DisplayName("Enter First Name")]
        [Required(ErrorMessage = "First Name Can't be Null")]
        public string LastName { get; set; }
        [DataType(DataType.Text)]
        [DisplayName("Enter First Name")]
        [Required(ErrorMessage = "First Name Can't be Null")]
        public string Gender { get; set; }
        [DisplayName("Enter Email")]
        [Required(ErrorMessage = "Email Can't be Null")]
        [DataType(DataType.Text)]
        
        public string Email { get; set; }
        [DisplayName("Password")]
        [Required(ErrorMessage = "Password Can't be Null")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = " Can't be Null")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password Mismached")]

        public string ConfirmPassword { get; set; }
       }


    }

