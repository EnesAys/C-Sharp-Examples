using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOdevLIB
{
  public  class oyuncu:Futbolcu,Ielletutabilir
    {
        public string elleTut()
        {
            return " Oyuncular hiç bir zaman topa elle dokunamaz";
        }
    }
}
