using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Recipes.Models.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please enter Username")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter Password")]
        [UIHint("password")]
        public string Password { get; set; }


        public string ReturnUrl { get; set; }

    }
}
