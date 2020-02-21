using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProyectoLlaves.Models;

namespace ProyectoLlaves.Controllers
{
    public class LlavesController : Controller
    {
        private ProyectoLlavesContext db = new ProyectoLlavesContext();

        // GET: Llaves
        public ActionResult Index()
        {
            return View(db.Llaves.ToList());
        }

        // GET: Llaves/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Llaves llaves = db.Llaves.Find(id);
            if (llaves == null)
            {
                return HttpNotFound();
            }
            return View(llaves);
        }

        // GET: Llaves/Create
        public ActionResult Create()
        {
            ///var list = db.Empresas.ToList();
            ///list.Add
            return View();
        }

        // POST: Llaves/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,IdSitio,NombreSitio,OTFG,QuienRetira,Empresa,Celular,Fecha,Hora,OperadorEntrega,LlaveMecanica,LlaveAcsys,FechaRetorno,HoraRetorno,OperadorRecibe,Comentarios")] Llaves llaves)
        {
            if (ModelState.IsValid)
            {
                db.Llaves.Add(llaves);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(llaves);
        }

        // GET: Llaves/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Llaves llaves = db.Llaves.Find(id);
            if (llaves == null)
            {
                return HttpNotFound();
            }
            return View(llaves);
        }

        // POST: Llaves/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,IdSitio,NombreSitio,OTFG,QuienRetira,Empresa,Celular,Fecha,Hora,OperadorEntrega,LlaveMecanica,LlaveAcsys,FechaRetorno,HoraRetorno,OperadorRecibe,Comentarios")] Llaves llaves)
        {
            if (ModelState.IsValid)
            {
                db.Entry(llaves).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(llaves);
        }

        // GET: Llaves/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Llaves llaves = db.Llaves.Find(id);
            if (llaves == null)
            {
                return HttpNotFound();
            }
            return View(llaves);
        }

        // POST: Llaves/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Llaves llaves = db.Llaves.Find(id);
            db.Llaves.Remove(llaves);
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
