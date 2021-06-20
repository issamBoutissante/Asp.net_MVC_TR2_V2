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
    public class ListeStagesController : Controller
    {
        private EntitiesContext db = new EntitiesContext();

        // GET: ListeStages
        public ActionResult Index()
        {
            var stages = db.Stages.Include(s => s.Association);
            return View(stages.ToList());
        }
        [HttpPost]
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stage stage = db.Stages.Find(id);
            ViewBag.Stage = stage;
            return View();
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
