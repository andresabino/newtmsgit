using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NewTms.Models;

namespace NewTms.Controllers
{
    public class TransportadorasController : Controller
    {
        private TmsContext db = new TmsContext();

        // GET: Transportadoras
        public ActionResult Index()
        {
            return View(db.Transportadoras.ToList());
        }

        // GET: Transportadoras/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transportadora transportadora = db.Transportadoras.Find(id);
            if (transportadora == null)
            {
                return HttpNotFound();
            }
            return View(transportadora);
        }

        // GET: Transportadoras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Transportadoras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,CNPJ,Endereco,Bairro,Cidade,Cep,UF,Observacao,Ativo")] Transportadora transportadora)
        {
            if (ModelState.IsValid)
            {
                db.Transportadoras.Add(transportadora);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(transportadora);
        }

        // GET: Transportadoras/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transportadora transportadora = db.Transportadoras.Find(id);
            if (transportadora == null)
            {
                return HttpNotFound();
            }
            return View(transportadora);
        }

        // POST: Transportadoras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,CNPJ,Endereco,Bairro,Cidade,Cep,UF,Observacao,Ativo")] Transportadora transportadora)
        {
            if (ModelState.IsValid)
            {
                db.Entry(transportadora).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(transportadora);
        }

        // GET: Transportadoras/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transportadora transportadora = db.Transportadoras.Find(id);
            if (transportadora == null)
            {
                return HttpNotFound();
            }
            return View(transportadora);
        }

        // POST: Transportadoras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Transportadora transportadora = db.Transportadoras.Find(id);
            db.Transportadoras.Remove(transportadora);
            db.SaveChanges();
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
