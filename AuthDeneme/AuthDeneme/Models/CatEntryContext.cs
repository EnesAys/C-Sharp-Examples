using AuthDeneme.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AuthDeneme.Models
{
    public class CatEntryContext: IdentityDbContext<ApplicationUser>
    {
        public CatEntryContext():base("CatEntryCon")
        {

        }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}