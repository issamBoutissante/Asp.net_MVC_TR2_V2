using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Boutissante_Issam_TDI201_B_TR2_V2.Controllers
{
    public class AdministrateurController : Controller
    {
        // GET: Administrateur
        public ActionResult Index()
        {
            if (Session["volontaire"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            return View();
        }
    }
}