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
    public class TabelaFretesController : Controller
    {
        private TmsContext db = new TmsContext();

        // GET: TabelaFretes
        public ActionResult Index()
        {
            return View(db.TabelaFretes.ToList());
        }

        // GET: TabelaFretes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TabelaFrete tabelaFrete = db.TabelaFretes.Find(id);
            if (tabelaFrete == null)
            {
                return HttpNotFound();
            }
            return View(tabelaFrete);
        }

        // GET: TabelaFretes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TabelaFretes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,TaxaDespacho,PercentualRestricaoTrafego,TaxaPedagioFracao,TaxaServicoAdicional,DistanciaDe,DistancaiAte,ValorTonelada,PesoDe,PesoAte,PercentualGris,Observacao,Ativo")] TabelaFrete tabelaFrete)
        {
            if (ModelState.IsValid)
            {
                db.TabelaFretes.Add(tabelaFrete);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tabelaFrete);
        }

        // GET: TabelaFretes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TabelaFrete tabelaFrete = db.TabelaFretes.Find(id);
            if (tabelaFrete == null)
            {
                return HttpNotFound();
            }
            return View(tabelaFrete);
        }

        // POST: TabelaFretes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,TaxaDespacho,PercentualRestricaoTrafego,TaxaPedagioFracao,TaxaServicoAdicional,DistanciaDe,DistancaiAte,ValorTonelada,PesoDe,PesoAte,PercentualGris,Observacao,Ativo")] TabelaFrete tabelaFrete)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tabelaFrete).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tabelaFrete);
        }

        // GET: TabelaFretes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TabelaFrete tabelaFrete = db.TabelaFretes.Find(id);
            if (tabelaFrete == null)
            {
                return HttpNotFound();
            }
            return View(tabelaFrete);
        }

        // POST: TabelaFretes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TabelaFrete tabelaFrete = db.TabelaFretes.Find(id);
            db.TabelaFretes.Remove(tabelaFrete);
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
