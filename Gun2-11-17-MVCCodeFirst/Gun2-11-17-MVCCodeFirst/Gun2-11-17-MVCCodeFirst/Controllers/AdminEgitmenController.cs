using Gun2_11_17_MVCCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Gun2_11_17_MVCCodeFirst.Controllers
{
    public class AdminEgitmenController : Controller
    {
        // GET: AdminEgitmen
        private DataContext db = new DataContext();
       
        public ActionResult Index()
        {
            return View(db.Egitmenler.ToList());
        }

        //Get Edebilmek İçin
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Egitmen egt = db.Egitmenler.Find(id);
            if (egt == null)
            {
                return HttpNotFound();
            }

            return View(egt);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,AdSoyad,DogumTarihi")]Egitmen egt)
        {
            if (ModelState.IsValid)
            {
                db.Entry(egt).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(egt);
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Egitmen egt = db.Egitmenler.Find(id);
            if (egt == null)
            {
                return HttpNotFound();
            }

            return View(egt);
        }



        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Egitmen egt = db.Egitmenler.Find(id);
            if (egt == null)
            {
                return HttpNotFound();
            }

            return View(egt);
        }

        //Post
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            Egitmen egt = db.Egitmenler.Find(id);
            db.Egitmenler.Remove(egt);
            db.SaveChanges();
            return RedirectToAction("Index");


        }




        //Get işlemi İçin

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,AdSoyad,DogumTarihi")]Egitmen egt)
        {
            if (ModelState.IsValid)
            {
                db.Egitmenler.Add(egt);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(egt);
        }
    }
}