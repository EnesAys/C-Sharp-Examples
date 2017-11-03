using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gun2_11_17_MVCCodeFirst.Models
{
    public class Lst
    {
      
  
        public int Sayi { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }
    }
}