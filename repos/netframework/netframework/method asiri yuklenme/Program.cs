using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_asiri_yuklenme
{
    class Program
    {
        static void Main(string[] args)
        {
            ekrandagoster(topla(10, 20));// ic ice yazimlarda decimal,int,string gibi deger kullanmak gerekmez 
            //cunku ekrandagoster metodumuz  returndan gelen degeri yakalar ve islemi yapmaya devam eder.
            //uzun yoldan yapilimini gorelim.
           decimal toplam= topla(10, 20);// burda ise returnden gelen decimal degeri decimal toplam icerisine alindi.
            ekrandagoster(toplam);//daha sonra islemimizi ekrandagoster metoduyla ekranda gosterebildik.
        }
        static void ekrandagoster(object o)
        {
            Console.WriteLine(o.ToString());
            System.Threading.Thread.Sleep(2000);
        }
        static int topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
              }
        static decimal topla(decimal sayi1, decimal sayi2 )
        {
            decimal toplam = sayi1 + sayi2;
            return toplam;
        }
        static string topla(string metin1 , string metin2)
        {
            string toplam = metin1 + "" + metin2;
            return toplam;
        }

    }
}
