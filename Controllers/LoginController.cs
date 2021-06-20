using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Boutissante_Issam_TDI201_B_TR2_V2.Controllers
{
    public class LoginController : Controller
    {

        EntitiesContext context = new EntitiesContext();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Volontaire volontaire)
        {
            try
            {
                bool isExist = context.Volontaires.Any(V => V.Mail == volontaire.Mail && V.Mot_Passe == volontaire.Mot_Passe);
                if (isExist)
                {
                    Session["volontaire"] = context.Volontaires.Single(V => V.Mail == volontaire.Mail && V.Mot_Passe == volontaire.Mot_Passe);
                    if (volontaire.Mail == "Admin@gmail.com")
                    {
                        return RedirectToAction("Index", "Administrateur");
                    }
                    else
                    {
                        return RedirectToAction("Index", "Volontaires");
                    }
                }
                else
                {
                    this.ViewBag.ErrorMessage = "l'email ou mot de pass est incorrect";
                }
            }
            catch (Exception e)
            {
                this.ViewBag.ErrorMessage = e.Message;
            }
            return View();
        }
    }
}