using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gun13_10_17_KatmanliCodeFirst
{
    public class MyStrategy : DropCreateDatabaseIfModelChanges<KatUrunContext>
    {
        protected override void Seed(KatUrunContext context)// Özel bir metod olduğu için kullanmak zorundayız 
        {
            Kategori k = new Kategori()
            {
                KategoriAdi = "Kategori 1"
            };
            Urun u = new Urun()
            {
                UrunAdi = "Urun1",
                Fiyat = 5,
                Kategoris = k// seed metodu içerisinde kullanmazsak hata verirdi. Bu ürün k kategprisinn altındadır.
            };
            context.Kategoris.Add(k);
            context.Uruns.Add(u);
        }

    }
}
