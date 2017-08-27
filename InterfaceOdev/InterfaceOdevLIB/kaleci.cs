using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOdevLIB
{
    public class kaleci:Futbolcu,Ielletutabilir
    {
        public bool elizin { get; set; }
        public string elleTut()
        {
            if (elizin==true)
            {
                return ad+" "+soyad+" , "+mevki+", el ile topa dokunabilir ";
            }
            else
            {
                return ad + " " + soyad + " , " + mevki + ", cezasahası dışında veya geripas da el ile topa dokunamaz ";
            }
        }
    }
}
