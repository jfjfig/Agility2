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
    public class EscolasController : Controller
    {
        private AgilityDb db = new AgilityDb();

        // GET: Escolas
        public async Task<ActionResult> Index()
        {
            return View(await db.Escolas.ToListAsync());
        }

        // GET: Escolas/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Escolas escolas = await db.Escolas.FindAsync(id);
            if (escolas == null)
            {
                return HttpNotFound();
            }
            return View(escolas);
        }

        // GET: Escolas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Escolas/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,Nome,Morada,Localidade")] Escolas escolas)
        {
            if (ModelState.IsValid)
            {
                db.Escolas.Add(escolas);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(escolas);
        }

        // GET: Escolas/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Escolas escolas = await db.Escolas.FindAsync(id);
            if (escolas == null)
            {
                return HttpNotFound();
            }
            return View(escolas);
        }

        // POST: Escolas/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,Nome,Morada,Localidade")] Escolas escolas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(escolas).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(escolas);
        }

        // GET: Escolas/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Escolas escolas = await db.Escolas.FindAsync(id);
            if (escolas == null)
            {
                return HttpNotFound();
            }
            return View(escolas);
        }

        // POST: Escolas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Escolas escolas = await db.Escolas.FindAsync(id);
            db.Escolas.Remove(escolas);
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
