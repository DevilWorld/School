using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SchoolPortal.Models
{
    public class LoginViewModel
    {
        [Display(Name = "User Id")]
        [Required(ErrorMessage = "This field is required")]
        [Remote("")]
        public string UserId { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "This field is required")]
        public string Password { get; set; }
    }
}