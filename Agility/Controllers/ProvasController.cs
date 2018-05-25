using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Agility.Models;

namespace Agility.Controllers
{
    public class ProvasController : Controller
    {
        private AgilityDb db = new AgilityDb();

        // GET: Provas
        public async Task<ActionResult> Index()
        {
            var provas = db.Provas.Include(p => p.Escola);
            return View(await provas.ToListAsync());
        }

        // GET: Provas/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provas provas = await db.Provas.FindAsync(id);
            if (provas == null)
            {
                return HttpNotFound();
            }
            return View(provas);
        }

        // GET: Provas/Create
        public ActionResult Create()
        {
            ViewBag.EscolaFK = new SelectList(db.Escolas, "ID", "Nome");
            return View();
        }

        // POST: Provas/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,DataProva,Tipo,Local,EscolaFK")] Provas provas)
        {
            if (ModelState.IsValid)
            {
                db.Provas.Add(provas);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.EscolaFK = new SelectList(db.Escolas, "ID", "Nome", provas.EscolaFK);
            return View(provas);
        }

        // GET: Provas/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provas provas = await db.Provas.FindAsync(id);
            if (provas == null)
            {
                return HttpNotFound();
            }
            ViewBag.EscolaFK = new SelectList(db.Escolas, "ID", "Nome", provas.EscolaFK);
            return View(provas);
        }

        // POST: Provas/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,DataProva,Tipo,Local,EscolaFK")] Provas provas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(provas).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.EscolaFK = new SelectList(db.Escolas, "ID", "Nome", provas.EscolaFK);
            return View(provas);
        }

        // GET: Provas/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provas provas = await db.Provas.FindAsync(id);
            if (provas == null)
            {
                return HttpNotFound();
            }
            return View(provas);
        }

        // POST: Provas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Provas provas = await db.Provas.FindAsync(id);
            db.Provas.Remove(provas);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
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
