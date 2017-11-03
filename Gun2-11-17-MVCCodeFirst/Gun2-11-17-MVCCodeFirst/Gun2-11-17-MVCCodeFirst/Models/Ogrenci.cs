using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gun2_11_17_MVCCodeFirst.Models
{
    public class Ogrenci
    {
        [Key]
        [DisplayName("Öğrenci No")]
        public int ID { get; set; }

        [MaxLength(100)]
        [MinLength(3, ErrorMessage = "3 den az girmeyiniz")]/* [StringLength(100)] VS tarafında kısıtlamak için */
        [Required(ErrorMessage ="Ad Soyad zorunludur")]
        public string AdSoyad { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Lütfen bir tarih giriniz")]
        [DisplayName("Doğum Tarihi")]
        public DateTime? DogumTariihi { get; set; }
        [DisplayName("Mezun mu?")]
        public bool MezunMu { get; set; }
        public double Ortalama { get; set; }

    }
}