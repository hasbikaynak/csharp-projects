using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 25;
            int sayi2 = 15;

            if (sayi1 < sayi2)
            {

                Console.WriteLine("SAYI 1 SAYI 2 DEN KUCUKTUR");

            }
            else
            {
                Console.WriteLine("SAYI 1 SAYI 2 DEN KUCUK DEGILDIR");
            }
            Console.ReadKey();
        }
    }
}
