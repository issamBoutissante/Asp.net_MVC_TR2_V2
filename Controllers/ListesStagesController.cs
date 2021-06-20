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
    public class ListesStagesController : Controller
    {
        private EntitiesContext db = new EntitiesContext();

        // GET: ListesStages
        public ActionResult Index()
        {
            if (Session["volontaire"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            var stages = db.Stages.Include(s => s.Association);
            return View(stages.ToList());
        }

        // GET: ListesStages/Details/5
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
            Stage stage = db.Stages.Find(id);
            if (stage == null)
            {
                return HttpNotFound();
            }
            return View(stage);
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
