using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cartotree.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (TempData["isAuth"] != null && (bool) TempData["isAuth"])
                return View();
            else
                return RedirectToAction("Index", "Auth");
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
    }
}