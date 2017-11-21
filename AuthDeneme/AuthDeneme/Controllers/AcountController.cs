using AuthDeneme.Identity;
using AuthDeneme.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security.Claims;

namespace AuthDeneme.Controllers
{
    public class AcountController : Controller
    {
        private UserManager<ApplicationUser> userManager;
        private RoleManager<ApplicationRole> roleManager;
        public AcountController()
        {
            CatEntryContext db = new CatEntryContext();
            UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(db);
            userManager = new UserManager<ApplicationUser>(userStore);

            RoleStore<ApplicationRole> roleStore = new RoleStore<ApplicationRole>(db);
            roleManager = new RoleManager<ApplicationRole>(roleStore);
        }

        #region Register Part
        // GET: Acount
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Register model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser();
                user.Name = model.Ad;
                user.Surname = model.Soyad;
                user.Email = model.Email;
                user.UserName = model.UserName;

                IdentityResult iResult = userManager.Create(user, model.Password);
                if (iResult.Succeeded)
                {
                    // User isminde bir Role ataması yapacağız.
                    userManager.AddToRole(user.Id, "User");
                    return RedirectToAction("Login", "Acount");
                }
                else
                {
                    ModelState.AddModelError("RegisterUser", "Kullanıcı ekleme işleminde hata! ");
                }
            }
            return View(model);
        }
        #endregion

        #region Login Part

        public ActionResult Login() {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = userManager.Find(model.UserName, model.Password);
                if (user != null)
                {
                    IAuthenticationManager authManager = HttpContext.GetOwinContext().Authentication;
                    ClaimsIdentity identity = userManager.CreateIdentity(user, "ApplicationCookie");
                    AuthenticationProperties authProps = new AuthenticationProperties();
                    authProps.IsPersistent = model.RememberMe;
                    authManager.SignIn(authProps,identity);

                    return RedirectToAction("Index","Home");
                }
                else
                {
                    ModelState.AddModelError("LoginUser","Böyle Bir Kullanıcı Bulunamadı");
                }
            }
            return View(model);
        }
        #endregion

        [Authorize]
        public ActionResult LogOut() {
            IAuthenticationManager authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();
            return RedirectToAction("Login","Acount");
        }
    }
}