using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace cartotree.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // POST: Login from form
        [HttpPost]
        public ActionResult Login(Models.User user)
        {
            // On vérifie si le modèle passé en POST est valide.
            // La validation se fait grâce aux annotations qu'on 
            // a défini sur les modèles (cf. Models/User.cs)
            if(ModelState.IsValid)
            {
                TempData["isAuth"] = true;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // On indique qu'il y a eu une erreur et 
                // on renvoie la même page.
                ViewBag.Error = true;
                return View();
            }
        }
    }
}