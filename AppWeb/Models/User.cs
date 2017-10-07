using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace cartotree.Models
{
    public class User
    {
        [Required(ErrorMessage = "The email address is required.")]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$",
            ErrorMessage = "Invalid email address.")]
        [DisplayName("Email address")]
        public string Email { get; set; }

        [DisplayName("Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Your password is required.")]
        [DisplayName("Password")]
        public string Password { get; set; }
    }
}