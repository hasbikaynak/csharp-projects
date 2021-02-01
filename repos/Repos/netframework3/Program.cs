using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netframework3
{
    class Program
    {
        static void Main(string[] args)
        {
            string KullanicidanGelenDeger = string.Empty;

            Console.Write("Mesaj 1: "); // METNI EKRANA YAZAR IMLEC YANINDA DURUR
            Console.WriteLine("Mesaj 2: "); // METNI EKRANA YAZAR IMLEC ASAGI SATIRA GECER

            Console.Clear(); // BUTUN DATALARI SILER

            Console.Write("Lutfen adinizi giriniz: ");
            KullanicidanGelenDeger = Console.ReadLine();

            string Mesaj = "Girmis oldugunuz isim " + KullanicidanGelenDeger;
            Console.WriteLine(Mesaj);

            Console.Clear();

            Console.WriteLine("Girmis oldugunuz isim {0}", KullanicidanGelenDeger);

            Console.Clear();

            Console.WriteLine("Lutfen 1 ile 15 arasinda bir deger giriniz : ");
            string gelendeger = Console.ReadLine();

            int sayi1 = int.Parse(gelendeger);
            int toplam = sayi1 + 15;
            Console.WriteLine("Toplam deger = {0} ", toplam);


            Console.ReadLine();
        }
    }
}
