using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelismisPizzaSiparis_Class
{
    class SosyalPizza : Pizza
    {

        public int fiyat { get { return 10; } }
        public string ad { get { return PizzaAd.Sosyal.ToString(); } }

    }
   
}
