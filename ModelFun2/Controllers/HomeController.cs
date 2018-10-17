using ModelFun2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelFun2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // variable hour is the date and time right now
            int hour = DateTime.Now.Hour;

            // ViewBag.Greeting will store the variable hour and give a greeting depending on the time of day
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            ViewBag.Output = "<p>Hello</p>";

            // Returns the view that is associated with HomeController
            return View();
        }

        [HttpGet]
        public ActionResult RsvpForm()
        {
            return View();
        }

        // Taken directly from Learning Suite
        // This method is called when you hit the "submit" button on RsvpForm.cshtml
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            return View("Thanks", guestResponse);
        }
    }
}