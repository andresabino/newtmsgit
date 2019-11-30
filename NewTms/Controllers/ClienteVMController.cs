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
    public class ClienteVMController : Controller
    {
        private TmsContext db = new TmsContext();

        // GET: ClienteVM
        public ActionResult Index()
        {
            return View(db.ClienteVMs.ToList());
        }

        // GET: ClienteVM/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClienteVM clienteVM = db.ClienteVMs.Find(id);
            if (clienteVM == null)
            {
                return HttpNotFound();
            }
            return View(clienteVM);
        }

        // GET: ClienteVM/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClienteVM/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,CPF_CNPJ,Endereco,Bairro,Cidade,UF,Obs")] ClienteVM clienteVM)
        {
            if (ModelState.IsValid)
            {
                db.ClienteVMs.Add(clienteVM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clienteVM);
        }

        // GET: ClienteVM/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClienteVM clienteVM = db.ClienteVMs.Find(id);
            if (clienteVM == null)
            {
                return HttpNotFound();
            }
            return View(clienteVM);
        }

        // POST: ClienteVM/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,CPF_CNPJ,Endereco,Bairro,Cidade,UF,Obs")] ClienteVM clienteVM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clienteVM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clienteVM);
        }

        // GET: ClienteVM/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClienteVM clienteVM = db.ClienteVMs.Find(id);
            if (clienteVM == null)
            {
                return HttpNotFound();
            }
            return View(clienteVM);
        }

        // POST: ClienteVM/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClienteVM clienteVM = db.ClienteVMs.Find(id);
            db.ClienteVMs.Remove(clienteVM);
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
