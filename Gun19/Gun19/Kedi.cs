using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun19
{
   public class Kedi : Hayvan
    {
        public string ses;
        ////public Kedi(string s) {
        ////    ses = s;
        ////}
        public override string SesCikar()
        {
            return "miyav";
        }
        public bool sokakKedisimi { get; set; }

    }
}
