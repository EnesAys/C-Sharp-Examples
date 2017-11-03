using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gun2_11_17_MVCCodeFirst.Models;
using System.Net;
using System.Data.Entity;

namespace Gun2_11_17_MVCCodeFirst.Controllers
{
    public class AdminDersController : Controller
    {
       private DataContext db = new DataContext();       
        // GET: AdminDers
        public ActionResult Index()
        {
            return View(db.Dersler.ToList());
        }

        //Get Edebilmek İçin
        public ActionResult Edit(int? id)
        {
            if (id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ders ders = db.Dersler.Find(id);
            if (ders==null)
            {
                return HttpNotFound();
            }

            return View(ders);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,DersAdi,Aciklama")]Ders ders)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ders).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ders);
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ders ders = db.Dersler.Find(id);
            if (ders == null)
            {
                return HttpNotFound();
            }

            return View(ders);
        }
        

       
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ders ders = db.Dersler.Find(id);
            if (ders == null)
            {
                return HttpNotFound();
            }

            return View(ders);
        }

        //Post
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
          
                Ders ders = db.Dersler.Find(id);
                db.Dersler.Remove(ders);
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
        public ActionResult Create([Bind(Include="ID,DersAdi,Aciklama")]Ders ders)
        {
            if (ModelState.IsValid)
            {
                db.Dersler.Add(ders);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ders);
        }
    }
}