using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelismisPizzaSiparis_Class
{
   public class KarisikPizza : Pizza
    {

        public int fiyat { get { return 20; } }
        public string ad { get { return PizzaAd.Karisik.ToString();}}
        
    }
}
