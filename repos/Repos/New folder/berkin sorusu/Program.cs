using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace berkin_sorusu
{
    class Program
    {
        static void Main(string[] args)
        {

            //int n = 0;
            //int toplama = 0;

            //string[] dizim = new string[]{"5","2","3","a","b","2"};
            //foreach (var item in dizim)
            //{

            //    if (int.TryParse(item,out n)==true)
            //    {
            //       toplama += Convert.ToInt32(item);

            //    }


            //}


            //Console.WriteLine(toplama);
            //System.Threading.Thread.Sleep(2000);

            //yarinki task girilen int degerlerini toplayan uygulamayi yap 
            //int toplamaislemi = 0;


            //Console.WriteLine("Kac sayi ile toplama islemi yapmak istediginizi giriniz");
            // int kullanicidangelendeger = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= kullanicidangelendeger ; i++)
            //{

            //    Console.WriteLine("toplami islemi yapmak icin {0}. degeri giriniz " , i);
            //    int kullanicidangelendegerfor = Convert.ToInt32(Console.ReadLine());
            //    bool kullanicidangelenforbool =  Convert.ToBoolean(kullanicidangelendegerfor);
            //    if (kullanicidangelenforbool)
            //    {
            //        toplamaislemi += kullanicidangelendegerfor;
            //    }


            //}

            //Console.WriteLine(toplamaislemi);
            //Console.ReadKey();
            // System.Threading.Thread.Sleep(2000);

            // do fibonacci series app
            //int n0 = 0, n1 = 1, n2; 
            //Console.WriteLine("fibonacci hesaplamasi icin 'n' degerini giriniz : NOT: diyelim ki n=5 " +
            //    "o zaman output , 0 1 1 2 3 idir ");
            //int kullanicidangelendeger = int.Parse(Console.ReadLine());
            //Console.Write(n0  +" "+ n1 +" ");
            //for (int i = 2; i < kullanicidangelendeger; i++)
            //{
            //    n2 = n0 + n1;
            //    Console.Write(n2+" ");
            //    n0 = n1;
            //    n1 = n2;
            //}

            //Console.ReadKey();

            //do app which check if the given numbers are  palindrome numbers 

            /*  
              Console.WriteLine("sayilariniz palindrome sayilarimi diye kontrol etmek istediginiz sayilarinizi yaziniz ");
              int kullanicidangelenendeger = int.Parse(Console.ReadLine());

              int n = 0;
                  int reverse = 0, rem;
              kullanicidangelenendeger = n;

              while (kullanicidangelenendeger != 0)
              {
                  rem = kullanicidangelenendeger % 10;
                  reverse = reverse * 10 + rem;
                  kullanicidangelenendeger /= 10;
              }
              // reverse sayimin tersi kullanicidangelendegerle ikisini karsilastiracagiz
              if (reverse==n)
              {
                  Console.WriteLine(
                  "Palindrome sayidir");
              }
              else
              {
                  Console.WriteLine(" Palindrome sayi degildir");
              }
              Console.ReadKey(); */


            //kullanicidan gelen 1-1000 sayiyi tahmin eden uygulama 
            //uygulama evet hayirlarla ilerleyecek ve kullanici hicbir zaman sayiyi yazmayacak. sadece evet hayirlarla
            //ilerleyecez.

            Console.WriteLine("Aklindan 1 ile 1000 arasi bir sayi tut");
            Random rnd = new Random();
            int sayac = 0;
           

            int kullanicidangelendeger = int.Parse(Console.ReadLine());
            for (int i = 0; i < 100; i++)
            {
                int randomsonuc =(rnd.Next(1, 100));

                if (kullanicidangelendeger == randomsonuc)
                {
                    Console.WriteLine("Sayiniz 1 ile 100 arasindadir ve {0}", kullanicidangelendeger);
                    break; 
                }
                sayac++;
            }
            

            Console.WriteLine("Program  {0}. denemede sayinizi tahmin etti ve buldu",sayac);
            Console.ReadKey();
        }
    }
}
