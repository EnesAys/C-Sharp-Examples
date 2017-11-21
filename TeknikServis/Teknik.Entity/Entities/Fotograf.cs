using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknik.Entity.Entities
{
   public  class Fotograf
    {  [Key]
        public int ID { get; set; }

        public string Yol { get; set; }

        public int ArizaID { get; set; }


        [ForeignKey("ArizaID")]
        public virtual Ariza Arizasi { get; set; }
    }
}
