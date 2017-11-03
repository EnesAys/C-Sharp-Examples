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
    public class AdminOgrenciController : Controller
    {
        // GET: AdminOgrenci
        private DataContext db = new DataContext();

        public ActionResult Index()
        {
            return View(db.Ogrenciler.ToList());
        }

        //Get Edebilmek İçin
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ogrenci ogr = db.Ogrenciler.Find(id);
            if (ogr == null)
            {
                return HttpNotFound();
            }

            return View(ogr);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,AdSoyad,DogumTariihi,MezunMu,Ortalama")]Ogrenci ogr)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ogr).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ogr);
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ogrenci ogr = db.Ogrenciler.Find(id);
            if (ogr == null)
            {
                return HttpNotFound();
            }

            return View(ogr);
        }



        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ogrenci ogr = db.Ogrenciler.Find(id);
            if (ogr == null)
            {
                return HttpNotFound();
            }

            return View(ogr);
        }

        //Post
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            Ogrenci ogr = db.Ogrenciler.Find(id);
            db.Ogrenciler.Remove(ogr);
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
        public ActionResult Create([Bind(Include = "ID,AdSoyad,DogumTariihi,MezunMu,Ortalama")]Ogrenci ogr)
        {
            if (ModelState.IsValid)
            {
                db.Ogrenciler.Add(ogr);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ogr);
        }
    }
}