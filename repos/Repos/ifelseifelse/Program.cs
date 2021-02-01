using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelseifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            int sinav1, sinav2, sinav3, ortalama;
            string isim_soyisim;


            Console.WriteLine("Hosgeldiniz , lutfen adinizi ve soyadinizi giriniz  ");
            isim_soyisim = Console.ReadLine();


            Console.WriteLine("Lutfen ilk sinav notunuzu giriniz ");
            sinav1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lutfen ikinci sinav notunuzu giriniz ");
            sinav2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lutfen ucuncu sinav notunuzu giriniz ");
            sinav3 = Convert.ToInt32(Console.ReadLine());

            ortalama = (sinav1 + sinav2 + sinav3) / 3;

            if (ortalama > 0 && ortalama < 45)
            {
                Console.WriteLine("Hosgeldin {0}", isim_soyisim);
                Console.WriteLine("You suck ");
            }
            else if (ortalama >= 45 && ortalama < 60)
            {
                Console.WriteLine("Hosgeldin {0}", isim_soyisim);
                Console.WriteLine("You little suck ");
            }
            else if (ortalama >= 60 && ortalama < 80)
            {
                Console.WriteLine("Hosgeldin {0}", isim_soyisim);
                Console.WriteLine("You are good ");
            }
            else if (ortalama >= 80 && ortalama <= 100)
            {
                Console.WriteLine("Hosgeldin {0}", isim_soyisim);
                Console.WriteLine("Verry good ");
            }
            else
            {
                Console.WriteLine("Do not be ridiculous");
            }
            Console.ReadKey();
        }
    }
}
