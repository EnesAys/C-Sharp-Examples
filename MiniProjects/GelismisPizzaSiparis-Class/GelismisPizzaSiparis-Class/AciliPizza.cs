using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelismisPizzaSiparis_Class
{
    class AciliPizza : Pizza
    {

        public int fiyat { get { return 30; } }
        public string ad { get { return PizzaAd.Acili.ToString(); } }

    }

}
