using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknik.Entity.ViewModels
{
   public class ArizaBilgilendirmeViewModel
    {
        public int ID { get; set; }
        [Display(Name = "Açıklama")]
        public string Aciklama { get; set; }
        [Display(Name = "Açıklama Zamanı")]
        public DateTime AciklamaZamani { get; set; } = DateTime.Now;
        [Display(Name = "Olumlu mu")]
        public bool OlumluMu { get; set; }

        public string YoneticiID { get; set; }

        public int ArizaID { get; set; }
    }
}
