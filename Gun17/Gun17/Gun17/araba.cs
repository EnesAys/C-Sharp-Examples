using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun17
{
   public class araba
    {
        
        public enum tip { taksi,otobus,otomobil}
        public enum yakitTuru { benzin,dizel,lpg}
        public int arabaYasi { get; set; }
        public tip ArabaninSinifi { get; set; }
        public yakitTuru YakitTuru { get; set; }


    }
}
