using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesli_Sessiz_Harf_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] sharf = { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };//ingilizce metin oalrak kabul ettiğimiz için ö,,ü yü katmadım I harfini ise büyüklük durumundan dolayı dahil ettim.
            string metin;
            int sayac = 0;    
            Console.WriteLine("Metin giriniz : ");
            metin = Console.ReadLine();
            int uzunluk = metin.Length;
            for (int i = 0; i < sharf.Length; i++)
            {
                for (int k = 0; k < metin.Length; k++)
                {
                    if (metin[k] == sharf[i])
                    {
                        sayac++;
                    }
                }
            }
            Console.WriteLine("Metin içerisindeki sesli harf sayısı= "+sayac);
            Console.WriteLine("Metin içerisindeki sessiz harf sayısı= "+(uzunluk-sayac));//cümleden belirlenen sesli harfleri çıkararak sessiz harfleri bulmaya çalıştım.Fakat boşluklarıda sayacak.Yeni bir sessiz harf dizisi yerine böyle yapmak daha mantıklı geldi.İlerisi için split metodu da kullanılarak yapılabilir diye düşünüyorum.
            Console.ReadLine();
        }
    }
    
}
