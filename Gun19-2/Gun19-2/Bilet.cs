using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun19_2
{
    public enum BiletTipi {Normal,İndirimli,Ogrenci }
    public class Bilet
    {
        public BiletTipi BiletTuru { get; set; }
        public virtual int Fiyat()
        {
            return 50;
        }
    }
}
