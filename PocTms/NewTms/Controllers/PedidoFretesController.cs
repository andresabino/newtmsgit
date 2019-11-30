using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NewTms.Models;
using NewTms.Views.TabelaFretes;

namespace NewTms.Controllers
{
    public class PedidoFretesController : Controller
    {
        private TmsContext db = new TmsContext();

        // GET: PedidoFretes
        public ActionResult Index()
        {
            return View(db.PedidoFretes.ToList());
        }

        // GET: PedidoFretes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PedidoFrete pedidoFrete = db.PedidoFretes.Find(id);
            if (pedidoFrete == null)
            {
                return HttpNotFound();
            }
            return View(pedidoFrete);
        }

        // GET: PedidoFretes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PedidoFretes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CepColeta,CepDestino,Distancia,DataRetiradaAgendada,Altura,Largura,Profundidade,Peso,CargaEspecial,ValorFrete,DataVencimentoCNH,CategoriaCNH,DataAprovacaoFrete,AprovadoFrete,Status,Observacao")] PedidoFrete pedidoFrete)
        {
            if (ModelState.IsValid)
            {
                db.PedidoFretes.Add(pedidoFrete);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pedidoFrete);
        }

        // POST: PedidoFretes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CalcularFrete([Bind(Include = "Id,CepColeta,CepDestino,Distancia,DataRetiradaAgendada,Altura,Largura,Profundidade,Peso,CargaEspecial,ValorFrete,DataVencimentoCNH,CategoriaCNH,DataAprovacaoFrete,AprovadoFrete,Status,Observacao")] PedidoFrete pedidoFrete)
        {
            if (ModelState.IsValid)
            {
                //db.PedidoFretes.Add(pedidoFrete);
                //db.SaveChanges();
                //return RedirectToAction("Index");
                return View(pedidoFrete);
            }

            return View(pedidoFrete);
        }

        // GET: PedidoFretes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PedidoFrete pedidoFrete = db.PedidoFretes.Find(id);
            if (pedidoFrete == null)
            {
                return HttpNotFound();
            }
            return View(pedidoFrete);
        }

        // POST: PedidoFretes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CepColeta,CepDestino,Distancia,DataRetiradaAgendada,Altura,Largura,Profundidade,Peso,CargaEspecial,ValorFrete,DataVencimentoCNH,CategoriaCNH,DataAprovacaoFrete,AprovadoFrete,Status,Observacao")] PedidoFrete pedidoFrete)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pedidoFrete).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pedidoFrete);
        }

        // GET: PedidoFretes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PedidoFrete pedidoFrete = db.PedidoFretes.Find(id);
            if (pedidoFrete == null)
            {
                return HttpNotFound();
            }
            return View(pedidoFrete);
        }

        // POST: PedidoFretes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PedidoFrete pedidoFrete = db.PedidoFretes.Find(id);
            db.PedidoFretes.Remove(pedidoFrete);
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
