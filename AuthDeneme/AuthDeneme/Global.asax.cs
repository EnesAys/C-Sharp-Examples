using AuthDeneme.Identity;
using AuthDeneme.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AuthDeneme
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            #region Rol Tanımlama
            //Rol Tanımlama
            CatEntryContext db = new CatEntryContext();
            RoleStore<ApplicationRole> roleStore = new RoleStore<ApplicationRole>(db);
            RoleManager<ApplicationRole> roleManager = new RoleManager<ApplicationRole>(roleStore);
            if (!roleManager.RoleExists("Admin"))
            {
                ApplicationRole adminRole = new ApplicationRole("Admin", "Sistem Yöneticisi");
                roleManager.Create(adminRole);

            }
            if (!roleManager.RoleExists("User"))
            {
                ApplicationRole userRole = new ApplicationRole("User", "Sistem kullanıcısı, yorum eklemek için gereklidir");
                roleManager.Create(userRole);
            }
            #endregion 
        }
    }
}
