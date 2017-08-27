using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gun22LİB;


namespace Gun22LİB
{
   public class SuperMan:Kahraman,IUcabilir
    {
        public bool ucarmi { get; set; }
        public string Ucur() {
            return AD + " Ucabilir ";
        }
    }
}
