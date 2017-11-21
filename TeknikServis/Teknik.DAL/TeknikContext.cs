using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teknik.Entity.Entities;
using Teknik.Entity.IdentityModels;

namespace Teknik.DAL
{
    public class TeknikContext : IdentityDbContext<ApplicationUser>
    {
        public TeknikContext() : base("name=TeknikCon")
        {

        }

        public virtual DbSet<Ariza> Arizalar { get; set; }

        public virtual DbSet<ArizaBilgilendirme> ArizaBilgilendirmeler { get; set; }

        public virtual DbSet<Fotograf> Fotograflar { get; set; }

        public virtual DbSet<PcMarka> Markalar { get; set; }

        public virtual DbSet<PcModel> Modeller { get; set; }
        public virtual DbSet<Anket> Anketler { get; set; }


        public static TeknikContext Create()
        {
            return new TeknikContext();
        }
    }

}
