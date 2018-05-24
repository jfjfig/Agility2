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
    public class CaesController : Controller
    {
        private AgilityDb db = new AgilityDb();

        // GET: Caes
        public async Task<ActionResult> Index()
        {
            return View(await db.Caes.ToListAsync());
        }

        // GET: Caes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Caes caes = await db.Caes.FindAsync(id);
            if (caes == null)
            {
                return HttpNotFound();
            }
            return View(caes);
        }

        // GET: Caes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Caes/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,Nome,NomeOficial,Raca,Sexo,DataNascimento,Grau,Size,NumeroCaderneta,DataLicenca,NumeroRegisto")] Caes caes)
        {
            if (ModelState.IsValid)
            {
                db.Caes.Add(caes);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(caes);
        }

        // GET: Caes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Caes caes = await db.Caes.FindAsync(id);
            if (caes == null)
            {
                return HttpNotFound();
            }
            return View(caes);
        }

        // POST: Caes/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,Nome,NomeOficial,Raca,Sexo,DataNascimento,Grau,Size,NumeroCaderneta,DataLicenca,NumeroRegisto")] Caes caes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(caes).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(caes);
        }

        // GET: Caes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Caes caes = await db.Caes.FindAsync(id);
            if (caes == null)
            {
                return HttpNotFound();
            }
            return View(caes);
        }

        // POST: Caes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Caes caes = await db.Caes.FindAsync(id);
            db.Caes.Remove(caes);
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
