using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gun13_10_17_KatmanliCodeFirst
{
  public  class Kategori:Entity
    {
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public virtual List<Urun> Uruns { get; set; }
    }
}
