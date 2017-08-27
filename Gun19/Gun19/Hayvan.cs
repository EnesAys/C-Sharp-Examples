using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun19
{
    public class Hayvan
    {
       
        //public Hayvan(string s) { }
        public string ad { get; set; }
        public string renk { get; set; }
        public double kilo { get; set; }
        public int Yas { get; set; }
        public double Boy { get; set; }

        public virtual string SesCikar() { return "swssss"; }

    }
}
