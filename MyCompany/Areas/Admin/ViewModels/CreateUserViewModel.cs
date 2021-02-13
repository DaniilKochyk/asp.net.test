using Microsoft.AspNetCore.Identity;
using MyCompany.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Areas.Admin.ViewModels
{
    public class CreateUserViewModel 
    {   [Required(ErrorMessage = "wypelnij pole Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "wypelnij pole Hasło")]
        public string Password { get; set; }
        [Required(ErrorMessage = "wypelnij pole Login")]
        public string UserName { get; set; }
    }
}
