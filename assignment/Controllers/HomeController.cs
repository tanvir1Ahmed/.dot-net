using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace assignment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult education()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult projects()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult reference()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult personal_skill()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}