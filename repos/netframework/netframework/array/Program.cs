using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] ogrenciisimlistesi = new string[5];
            //ogrenciisimlistesi[0] = "hasbi";
            //ogrenciisimlistesi[1] = "ibraam";
            //ogrenciisimlistesi[2] = "boris";
            //ogrenciisimlistesi[3] = "hasan";
            //ogrenciisimlistesi[4] = "2salakosman4";
            //foreach (string item in ogrenciisimlistesi)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i <ogrenciisimlistesi.Length; i++)
            //{
            //    string gelenisim = ogrenciisimlistesi[i];
            //    Console.WriteLine(gelenisim);
            //}
            //Console.ReadKey();

            //Console.WriteLine("lutfen dizimizin uzunlugunu giriniz ");
            //int diziuzunlugu = Convert.ToInt32(Console.ReadLine());

            //int[] myarrey = new int[diziuzunlugu];

            //for (int i = 0; i < myarrey.Length; i++)
            //{
            //    Console.WriteLine("{0}. indexteki elemani giriniz  ", i);
            //    myarrey[i] = Convert.ToInt32(Console.ReadLine());
            //}


            //Console.WriteLine("Diziniz hazir");
            //Console.WriteLine("Dizi icerisindeki degerlerin toplami ve ortalamalari asagidaki gibidir :");


            //int toplam = 0, ortalama = 0;

            //foreach (int item in myarrey)
            //{
            //    Console.WriteLine(item);
            //    toplam += item;

            //}
            //Console.WriteLine("+---------------------");
            //Console.WriteLine(toplam);

            //Console.WriteLine("Dizi icerisindeki eleman sayisi {0}", myarrey.Length);
            //ortalama = toplam / myarrey.Length;
            //Console.WriteLine("Ortalama {0}",ortalama);

            Random rnd = new Random();

            int[] arrey = new int[20];

            for (int i = 0; i < arrey.Length ; i++)
            {

                arrey[i] = rnd.Next(1, 10);
                
                

               
            }
            int sayac = 0;

            foreach (int item in arrey)
            {
                Console.WriteLine(item);
                if (item==4)
                {
                    sayac++;
                }
                  
            }
            Console.WriteLine("dizi icinde {0} defa 4 degerini bulduk ", sayac);
            Console.ReadKey();
        }
       
    }
}
