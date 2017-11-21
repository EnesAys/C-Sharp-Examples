using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teknik.Entity.IdentityModels;

namespace Teknik.Entity.Entities
{
    public  class ArizaBilgilendirme
    {   [Key]
        public int ID { get; set; }

        public string Aciklama { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime AciklamaZamani { get; set; } = DateTime.Now;


        public bool OlumluMu { get; set; }

        public string YoneticiID { get; set; }

        public int ArizaID { get; set; }


        [ForeignKey("ArizaID")]
        public virtual Ariza Arizasi { get; set; }

        [ForeignKey("YoneticiID")]
        public virtual ApplicationUser Yoneticisi { get; set; }

    }
}
