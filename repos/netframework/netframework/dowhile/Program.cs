using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kullaniciadi = string.Empty;
            //string sifre = string.Empty;
            //int sayac = 0;

            //do
            //{if(sayac>0)
            //    {
            //        Console.WriteLine("hatali sifre veya kullanici adi");
            //    }
            //    Console.WriteLine("Lutfen kullanici adinizi ve sifrenizi giriniz ");
            //    Console.Write("Kullanici adiniz : ");
            //    kullaniciadi = Console.ReadLine();
            //    Console.Write("sifreniz :");
            //    sifre = Console.ReadLine();
            //    sayac++;
            //} while (kullaniciadi != "demo" || sifre != "demo");
            // Console.WriteLine(" hosgeldiniz ");

            //Console.ReadKey();
            
            int randomsayi = 0;
            int tahmin = 0;
            int sayac = 0;

            Console.WriteLine("lutfen max valuyu belirleyiniz");
            int maxvalue = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            randomsayi = rnd.Next(1, maxvalue);

            do
            {
                sayac++;
                Console.Write("{0} . deneme  -  Lutfen tuttugum sayiyi tahmin ediniz : ", sayac);
                 tahmin = Convert.ToInt32(Console.ReadLine());

            } while (tahmin != randomsayi);
            Console.WriteLine("{0} kere denidiniz ve sonucu buldunuz ",sayac);

            Console.ReadKey();


        }
    }
}
