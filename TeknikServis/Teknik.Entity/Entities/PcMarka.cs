using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknik.Entity.Entities
{
   public class PcMarka
    {
        public int ID { get; set; }
        public string MarkaAdi { get; set; }

        public virtual List<PcModel> Modelleri { get; set; } = new List<PcModel>();

    }
}
