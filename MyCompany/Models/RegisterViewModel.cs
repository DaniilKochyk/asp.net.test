using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Models
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Login")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "jedno z haseł jest napisane błędnie")]
        [DataType(DataType.Password)]
        [Display(Name = "Wpisz jeszcze raz hasło")]
        public string PasswordConfirm { get; set; }
    }
}
