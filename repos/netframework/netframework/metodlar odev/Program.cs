using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodlar_odev
{
    class Program
    {
        static void Main(string[] args)
        {
        mytittle:

            //matematik klasimizi tanimlayalim
            matematik m = new matematik();

            //menumuzu olusturalim
            Console.Clear();
            Console.WriteLine("*******Aritmatik ortalama hesaplayan uygulama********");
            Console.Write("adinizi soyadinizi giriniz : ");
            string isimsoyisim = Console.ReadLine();
            Console.WriteLine("hosgeldin {0}",isimsoyisim);

            Console.WriteLine("Lutfen ilk notunuzu giriniz");
            decimal kullanicidangelenilksayi = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Lutfen ikinci notunuzu giriniz");
            decimal kullanicidangelenikincisayi = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Lutfen ucuncu notunuzu giriniz");
            decimal kullanicidangelenucuncusayi = decimal.Parse(Console.ReadLine());

            decimal sonuc = 0;

            sonuc = m.aritmatikortalama(kullanicidangelenilksayi, kullanicidangelenikincisayi, kullanicidangelenucuncusayi);

            //sonuclari yazdiralim
            m.sonucuyazdiralim(kullanicidangelenilksayi, kullanicidangelenikincisayi, kullanicidangelenucuncusayi, sonuc);
            System.Threading.Thread.Sleep(2000);

            //sunucunun notuna gore 45 ustu ise "iyisin" , 45 alti ise de "kotusun" yazisi gosterelim
            if (sonuc>=45)

            {
                Console.WriteLine("iyisin");
            }
            else
            {
                Console.WriteLine("kotusun");
            }
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("baska bir not hesaplamak icin 'x' e basiniz ");
            string x = Console.ReadLine();
            if (x.ToLower()=="x")
            {
                goto mytittle;
            }
            
        }
    }
}
