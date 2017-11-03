using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Gun2_11_17_MVCCodeFirst.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("dataCon")
        {

        }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Egitmen> Egitmenler { get; set; }
    
    }
}