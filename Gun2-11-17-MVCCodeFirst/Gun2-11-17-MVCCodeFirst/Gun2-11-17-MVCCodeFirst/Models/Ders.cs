using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Gun2_11_17_MVCCodeFirst.Models
{
    public class Ders
    {
        [Key]
        public int ID { get; set; }

        [DisplayName("Ders Adı")]
        [Required(ErrorMessage ="Ders Adı girilmeli")]
        public string DersAdi { get; set; }

        [DisplayName("Açıklama")]
        [Column(TypeName ="text")]
        public string Aciklama { get; set; }




    }
}