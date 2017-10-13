using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gun13_10_17_KatmanliCodeFirst
{
  public  class Urun:Entity
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public int Fiyat { get; set; }
        public int KategoriID { get; set; }
        public virtual Kategori Kategoris { get; set; }
    }
}
