using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknik.Entity.ViewModels
{
   public class LoginViewModel
    {

        [Required]
        [Display(Name="Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }
        [Display(Name = "Şifre")]
        [StringLength (100,MinimumLength =5,ErrorMessage ="Şifreniz en az 5 karakter olmalıdır")]
        [DataType(DataType.Password)]
        public string Sifre { get; set; }
        [Display(Name = "Beni Hatırla")]
        public bool  HatirlansinMi { get; set; }

    }

    
}
