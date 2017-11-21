using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknik.Entity.Entities
{
  public  class PcModel
    {   [Key]
        public int ID { get; set; }
        public string ModelAdi { get; set; }

        public int MarkaID { get; set; }

        [ForeignKey("MarkaID")]
        public virtual PcMarka Markasi { get; set; }
    }
}
