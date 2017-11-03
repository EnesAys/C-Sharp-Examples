using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gun2_11_17_MVCCodeFirst.Models
{
    public class Egitmen
    {
        [Key]
        public int ID { get; set; }

        [DisplayName("İsim Soyisim")]
        public string AdSoyad { get; set; }

        [DataType(DataType.Date,ErrorMessage ="Lütfen bir tarih giriniz")]
        [DisplayName("Doğum Tarihi")]
        public DateTime? DogumTarihi { get; set; }
        // Null olduğunda hata vermesin diye? kullanıyorum.

    }
}