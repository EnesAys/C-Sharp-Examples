using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Teknik.Entity.Entities;
using Teknik.Entity.IdentityModels;

namespace Teknik.Entity.ViewModels
{
   public  class ArizaViewModel
    {

        public int ID { get; set; }
        [Display(Name = "Başlık")]
        public string Baslik { get; set; }

        [Display(Name = "Açıklama")]
        public string Aciklama { get; set; }

        public string Enlem { get; set; }

        public string Boylam { get; set; }
        public string Adres { get; set; }
        [Display(Name = "Arıza Tarihi")]
        public DateTime? OnaylanmaTarihi { get; set; }

        [Display(Name = "Gönderme Tarihi")]
        public DateTime EklemeTarihi { get; set; }

        public List<string> FotografYollari { get; set; }
        public List<HttpPostedFileBase>  Dosyalar  { get; set; }
        [Display(Name = "Bilgilendirme Açıklaması")]
        public string BilgilendirmeAciklamasi { get; set; }
        [Display(Name = "Sorumlu Tekniker")]
        public string TeknikerID { get; set; }
        [Display(Name = "Arızayı Gönderen ")]
        public string KullaniciID { get; set; }
        [Display(Name = "Arıza Yapıldı Mı?")]
        public bool ArizaYapildiMi { get; set; }
        [Display(Name = "Onaylandı Mı?")]
        public bool OnaylandiMi { get; set; }
        [Display(Name = "Modeli")]
        public int ModelID { get; set; }

        [Display(Name = "Markası")]
        public int MarkaID { get; set; }



        public virtual ApplicationUser Gondereni { get; set; }

        public virtual PcMarka Markasi { get; set; }

        public  virtual PcModel Modeli { get; set; }

        public virtual List<ArizaBilgilendirmeViewModel> Bilgilendirmeleri { get; set; } = new List<ArizaBilgilendirmeViewModel>();
    }

}
