using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gun6
{
    class Program
    {
        static void Main(string[] args)
        {
            // değişken tanımlama,alma,for,if ile ilgili tekrarlar     
            //int a;
            //Console.WriteLine("Bir sayı giriniz");
            ////a = Convert.ToInt32(Console.ReadLine());
            //string a = Console.ReadLine();
            //for (int i = a.Length-1; i >= 0; i--)
            //{
            //    Console.Write(a[i]);
            //}

            /* Basamaklara ayırma*/

            //int sayi,birler,onlar,yuzler;
            //Console.WriteLine("Bir sayı giriniz ");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //yuzler = sayi / 100;
            //sayi = sayi - (yuzler * 100);
            //onlar = sayi / 10;
            //sayi = sayi - (onlar * 10);
            //birler = sayi / 1;
            //Console.WriteLine("sayının basamakları " +yuzler+ " "+onlar +" "+birler);

            //int a = 11;
            //do
            //{
            //    Console.WriteLine(a);
            //    a++;
            //} while (a<20);

            // Dizilier tekrar

            //-----------------------------------------------------------

            // Diziler aynı tipteki veriler ile tutulur.İndexlere göre kontrol sağlanabilir.

            //string[] dizi = {"bir","iki","üç","dört" };
            //int[] dizi2 = {1,2,3,4,5 };

            //int[] diziler = new int[5];
            //diziler[0]= 1;
            //diziler[4]= 10;

            //for (int i = 1; i < dizi.Length; i++)
            //{
            //    işlemler
            //}

            //foreach (int i in diziler)
            //{
            //    işlemler
            //}

            //********** Array.Reverse => Dizideki elemanları ters çevirir
            //********** Array.Sort => Dizideki elemanları küçükten büyüğe sırala

            // Dizinin elemanlarını büyükten küçüğe sıralama

            //int[] sayilar = {1,5,3,9,8 };
            //Array.Sort(sayilar);
            //Array.Reverse(sayilar);
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.Write(sayilar[i]+" ");
            //}

            //Kullanıcı dizi saysıını ve dizi elemanlarını belirlesin

            //int a,b;
            //Console.WriteLine("Kaç adet sayı gireceksiniz");
            //a = Convert.ToInt32(Console.ReadLine());
            //int[] dizi = new int[a];
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine("Lütfen sayı giriniz");
            //    b = Convert.ToInt32(Console.ReadLine());
            //    dizi[i] = b;


            //}
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.Write(dizi[i] + " ");
            //}
            int sayac = 0;
            int [] sayim = { 1,5,6,7,9,1}; 
            Console.WriteLine("Dizide aranacak sayı giriniz");
            int a = Convert.ToInt32(Console.ReadLine());
            foreach (int i in sayim)
            {
                if(sayim[i]==a)
                {
                    sayac ++;
                }                   
            }
             Console.WriteLine("Aradığınız sayı " + sayac + " adet bulunmaktadır");
            //if(sayac==0)
            //{

            //    Console.WriteLine("Sayı bulunmamaktadır");
            //}
            


            Console.ReadKey();
        }
    }
}
