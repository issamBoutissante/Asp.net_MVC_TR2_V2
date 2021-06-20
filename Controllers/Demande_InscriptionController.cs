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
    public class Demande_InscriptionController : Controller
    {
        private EntitiesContext db = new EntitiesContext();

       
        // GET: Demande_Inscription/Create
        public ActionResult Create()
        {
            if (Session["volontaire"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            ViewBag.Id_Stage = new SelectList(db.Stages, "Id_Stage", "Id_Stage");
            ViewBag.Id_Vlt = new SelectList(db.Volontaires, "Id_Vlt", "Nom_Vlt");
            return View();
        }

        // POST: Demande_Inscription/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_Inscription,Date_Demande,Etat,Id_Vlt,Id_Stage")] Demande_Inscription demande_Inscription)
        {
            if (ModelState.IsValid)
            {
                db.Demande_Inscription.Add(demande_Inscription);
                db.SaveChanges();
                return RedirectToAction("Create");
            }

            ViewBag.Id_Stage = new SelectList(db.Stages, "Id_Stage", "Id_Stage", demande_Inscription.Id_Stage);
            ViewBag.Id_Vlt = new SelectList(db.Volontaires, "Id_Vlt", "Nom_Vlt", demande_Inscription.Id_Vlt);
            return View(demande_Inscription);
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
