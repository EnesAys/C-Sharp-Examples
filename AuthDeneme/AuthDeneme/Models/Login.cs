using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthDeneme.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Boş Geçilemez")]
        [Display(Name ="Kullanıcı Adı")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }
        [Display(Name ="Beni Hatırla")]
        public bool RememberMe { get; set; }
    }
}