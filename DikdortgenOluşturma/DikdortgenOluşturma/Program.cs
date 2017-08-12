using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikdortgenOluşturma
{
    class Program
    {
        static void Main(string[] args)
        {
            int yuk, gen;
            Console.Write("Lütfen dikdörtgen için yükseklik giriniz. ");
            yuk = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen dikdörtgen için genişlik giriniz. ");
            gen = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= yuk; i++)
            {
                for (int k = 1; k <= gen; k++)
                {
                   
                    if (k == 1 || k == gen)
                        Console.Write("*");
                    else if(i == 1 || i == yuk)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("------------------------------------");

            for (int i = 1; i <= yuk; i++)
            {
                for (int k = 1; k <= gen; k++)
                {

                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
