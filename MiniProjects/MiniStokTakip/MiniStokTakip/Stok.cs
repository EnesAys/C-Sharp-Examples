using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStokTakip
{
    class Stok
    {
        public int UrunKodu { get; set; }
        public string UrunAdi { get; set; }
        public int Fiyat { get; set; }
        public int StokMiktar { get; set; }
        public int GarantiSure { get; set; }
        public DateTime UretimTarih { get; set; }
    }
}
