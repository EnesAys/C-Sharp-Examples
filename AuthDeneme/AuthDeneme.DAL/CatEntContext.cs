using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using System.Text;
using System.Threading.Tasks;


namespace AuthDeneme.DAL
{
   public class CatEntContext:DbContext
    {
        public CatEntContext():base("CatEntryCon")
        {

        }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
