using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Boutissante_Issam_TDI201_B_TR2_V2;

namespace Boutissante_Issam_TDI201_B_TR2_V2.Controllers
{
    public class AssociationsController : Controller
    {
        private EntitiesContext db = new EntitiesContext();

        // GET: Associations
        public ActionResult Index()
        {
            if (Session["volontaire"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            var associations = db.Associations.Include(a => a.Ville);
            return View(associations.ToList());
        }

        // GET: Associations/Details/5
        public ActionResult Details(int? id)
        {
            if (Session["volontaire"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Association association = db.Associations.Find(id);
            if (association == null)
            {
                return HttpNotFound();
            }
            return View(association);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
