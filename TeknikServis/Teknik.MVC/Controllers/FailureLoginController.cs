using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Teknik.BLL.Repository;
using Teknik.DAL;
using Teknik.Entity.Entities;
using Teknik.Entity.IdentityModels;
using Teknik.MVC.Models;

namespace Teknik.MVC.Controllers
{
    public class FailureLoginController : Controller
    {
        //Arıza kayıt işlemlerini tutacağımız controller

        private ApplicationUserManager _userManager;


        public FailureLoginController()
        {
            UserStore<Teknik.Entity.IdentityModels.ApplicationUser> userStore = new UserStore<Teknik.Entity.IdentityModels.ApplicationUser>(TeknikContext.Create());
            _userManager = new ApplicationUserManager(userStore);
        }

        List<SelectListItem> ModelDrp()
        {
            PcModelRepo repo = new PcModelRepo();

            var drp =  repo.GetAll().Select(a => new SelectListItem
            {
                Text = a.ModelAdi,
                Value = a.ID.ToString()

            }).ToList();

            return drp;
        }

        public ActionResult AddFailureLogin()
        {

            ViewBag.ModelDrp = ModelDrp();

            return View();
        }

        [HttpPost][ValidateAntiForgeryToken]
        public async Task<ActionResult> AddFailureLogin([Bind(Include = "Adres,Aciklama,Baslik,ModelID")] Ariza model)
        {

            ViewBag.ModelDrp = ModelDrp();

            string email = HttpContext.GetOwinContext().Request.User.Identity.Name;

            var user = await _userManager.FindByEmailAsync(email);

            model.KullaniciID = null;
            model.TeknikerID = null;

            ArizaRepo repo = new ArizaRepo();
            repo.Insert(model);
           

            return View();
        }
    }
}