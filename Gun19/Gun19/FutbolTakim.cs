using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun19
{
  public  class FutbolTakim
    {
        public string ad { get; set; }
        public int taraftarSayisi { get; set; }
        public string Simge { get; set; }

        public virtual string Tezahurat()
        {
            return "Marşlar";
        }
    }
}
