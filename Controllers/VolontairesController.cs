using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Boutissante_Issam_TDI201_B_TR2_V2.Controllers
{
    public class VolontairesController : Controller
    {
        private EntitiesContext db = new EntitiesContext();
        // GET: Volontaires
        public ActionResult Index()
        {
            if (Session["volontaire"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            var volontaires = db.Volontaires.Include(v => v.Ville);
            return View(volontaires.ToList());
        }

        // GET: Volontaires/Create
        public ActionResult Create()
        {
            if (Session["volontaire"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            ViewBag.Id_Ville = new SelectList(db.Villes, "Id_ville", "Nom_Ville");
            return View();
        }

        // POST: Volontaires/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_Vlt,Nom_Vlt,Prenom_Vlt,Mail,Mot_Passe,Actif,Id_Ville")] Volontaire volontaire)
        {
            if (ModelState.IsValid)
            {
                db.Volontaires.Add(volontaire);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id_Ville = new SelectList(db.Villes, "Id_ville", "Nom_Ville", volontaire.Id_Ville);
            return View(volontaire);
        }

        // GET: Volontaires/Edit/5
        public ActionResult Edit(int? id)
        {
            if (Session["volontaire"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Volontaire volontaire = db.Volontaires.Find(id);
            if (volontaire == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id_Ville = new SelectList(db.Villes, "Id_ville", "Nom_Ville", volontaire.Id_Ville);
            return View(volontaire);
        }

        // POST: Volontaires/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_Vlt,Nom_Vlt,Prenom_Vlt,Mail,Mot_Passe,Actif,Id_Ville")] Volontaire volontaire)
        {
            if (ModelState.IsValid)
            {
                db.Entry(volontaire).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id_Ville = new SelectList(db.Villes, "Id_ville", "Nom_Ville", volontaire.Id_Ville);
            return View(volontaire);
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
