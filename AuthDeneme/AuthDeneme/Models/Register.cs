using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthDeneme.Models
{
    public class Register
    {
        [Required(ErrorMessage ="Boş Geçilemez")]
        [Display(Name ="Ad")]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Soyad")]
        public string Soyad { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Kullanıcı Adı")]
        [StringLength(30,ErrorMessage ="30 karakterden fazla giriş yapmayınız")]
        public string UserName { get; set; }
        [Display(Name = "E-Mail")]
        [Required(ErrorMessage = "Boş Geçilemez")]
        [EmailAddress(ErrorMessage ="Email doğru formatta değil")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Boş Geçilemez")]
        public string Password { get; set; }
        [Display(Name = "Şifre Tekrar")]
        [Required(ErrorMessage = "Boş Geçilemez")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Şifreler Uymuyor")]
        public string ConfirmPassword { get; set; }
    }
}