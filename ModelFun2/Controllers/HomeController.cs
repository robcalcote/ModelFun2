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

        public ActionResult RsvpForm()
        {
            return View();
        }
    }
}