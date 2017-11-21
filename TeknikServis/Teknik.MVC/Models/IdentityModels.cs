using System;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Teknik.DAL;
using Teknik.Entity.IdentityModels;

namespace Teknik.MVC.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUserHelper
    {
        public static async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, ApplicationUser user)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    //public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    //{
    //    public ApplicationDbContext()
    //        : base("TeknikCon", throwIfV1Schema: false)
    //    {
    //    }

    //    public static TeknikContext Create()
    //    {
    //        return new TeknikContext();
    //    }
    //}
}