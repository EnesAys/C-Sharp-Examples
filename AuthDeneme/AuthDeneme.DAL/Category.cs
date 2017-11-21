using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthDeneme.DAL
{
   public class Category
    {
        public int ID { get; set; }
        public string CatName { get; set; }

        //Mapping
        public virtual List<Entry> Entries { get; set; }
    }
}
