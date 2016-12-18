using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormBasedAuth.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [AllowAnonymous] //This is for Un-Authorize User
        public ActionResult Index()
        {
            return View();
        }

        [Authorize] // This is for Authorize user
        public ActionResult MyProfile()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public ActionResult AdminIndex()
        {
            return View();
        }

        [Authorize(Roles = "User")]
        public ActionResult UserIndex()
        {
            return View();
        }
    }
}