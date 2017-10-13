using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gun13_10_17_KatmanliCodeFirst
{
   public class KatUrunContext : DbContext
    {
        public KatUrunContext() : base
            ("name=KatUrunContext")
        {

        }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Urun> Uruns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<KatUrunContext>(new MyStrategy());

            modelBuilder.Entity<Urun>().Property(p => p.UrunAdi).HasMaxLength(100).IsRequired();

            modelBuilder.Entity<Urun>().Property(p => p.Fiyat).HasColumnType("money");
                

        }
    }
}
