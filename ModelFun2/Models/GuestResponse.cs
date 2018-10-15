using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelFun2.Models
{
    public class GuestResponse
    {
        // Data annotation
        // Allows you to control inputs from users. This one below sets field as required and displays error message if left blank!
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
    }
}