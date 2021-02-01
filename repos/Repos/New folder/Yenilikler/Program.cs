using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yenilikler
{
    class Program
    {
        delegate void matematikselislemler(int sayi1 , int sayi2); // 3 tane matematiksel islemimiz var idi, onlari delagate 
        //metodumuz ile cagirtacagiz
        static void topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplama islemi sonucu {0}", sonuc);
        }
        static void cikar(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            Console.WriteLine("Cikarma islemi sonucu {0}", sonuc);
        } 
        static void carp(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            Console.WriteLine("Toplama islemi sonucu {0}", sonuc);
        }

        static void Main(string[] args)
        {
            matematikselislemler m1 = new matematikselislemler(topla); // delegateimizin icine calistirmak istedigimiz metodu 
            //belirtiyoruz
            m1 += carp; // += ile metod ekledik
            m1 += cikar;
            m1.Invoke(10, 10); // invoke ile ilesmi yaptirip yazdiriyoruz

           Delegate[] delegatelistem = m1.GetInvocationList();
            foreach (var item in delegatelistem)
            {
                Console.WriteLine(item.Method.Name);
            }

            m1 -= carp;
            foreach (var item in m1.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }


            Console.ReadKey();


            #region string interpolition 




            string isim = "Hasbi";
            string soyisim = "Kaynak";
            Console.WriteLine(string.Format("Merhaba {0} {1}", isim, soyisim)); // this is the method of string.format 
            //it allows us to make our task a much more way easier than as it is.  
            Console.WriteLine($"Merhaba {isim} - {soyisim}" ); // we will be using this method. 
            Console.ReadKey();
            #endregion

            #region Var anahtar kelimesi 
            var meslek = "PC Muhendisligi"; // var is the key word, it is not an object as an integer or string
            //when we use the value of "=" var is automatically changes to integer or string
            meslek.ToString();
            #endregion


            #region      isimsiz tip kullanimi  
            var Ogrenci = new // ogrenci isimli yeni bir nesne yaptik, ayni yeni bir klas  yapiyormusuz ve icini dolduruyor gibi.
            {
                isim = "Mehmet",
                soyisim = "Kaynak",
                numara = 1,
            };
            Console.WriteLine(Ogrenci.isim);
            #endregion

           #region kisaltilmis method 
            int carpmaislemi(int sayi1 , int sayi2=1 ) // kisaca yeni bir carpma islemi icin method olusturduk ve bunu hatasiz sekilde
            // kullanabildik 
            {
                
                {
                    return sayi1 * sayi2;
                }
                
                
            }
            Console.WriteLine(carpmaislemi(12));

            Console.ReadKey();
            

            #endregion
        }
    }
}
