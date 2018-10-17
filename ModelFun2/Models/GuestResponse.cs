using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelFun2.Models
{
    public class GuestResponse
    {
        // Data annotation
        // Allows you to control inputs from users. This one below sets field as required and displays error message if left blank!

        // Name : String
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        // Email : String
        [Required(ErrorMessage = "Please enter your email")]
        public string Email { get; set; }

        // Phone Number : String
        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }

        // Attendance (null, yes, no) : bool
        public bool? WillAttend { get; set; }
    }
}