using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_DataAnnotation.Models
{
    public class RegisterAnn
    {
        [Display(Name ="User Name")]
        [Required(ErrorMessage ="UserName is required")]
        public string UserName { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$",ErrorMessage = "Please Enter Correct Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(1,100,ErrorMessage ="Please enter Age between 1 and 100")]
        public int Age { get; set; }
        
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "ConfirmPassword is required")]
        public string ConfirmPassword { get; set; }
    }
}