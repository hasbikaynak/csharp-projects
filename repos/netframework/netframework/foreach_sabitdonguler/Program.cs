using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_sabitdonguler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region while dongusu
             string[] isimler = new[] { "hasbi", "ibraaam", "boris", };
             foreach (string  item in isimler)
             {
                 Console.WriteLine(item);
             }
             Console.ReadKey();
            int islem = 1;
            while(islem<=10)
            {
                Console.WriteLine(islem);
                islem++;
            }
            Console.WriteLine("dongunun sonu ");
        Console.ReadKey(); 

            //    #endregion
            //    #region kullanicidan gelen sayiyi 0 a kadar azaltan kod
            //    /*  Console.WriteLine("lutfen bir sayi yaziniz");
            //      int kullanicidangelendeger=Convert.ToInt32(Console.ReadLine());
            //      while (kullanicidangelendeger > 0)
            //      {
            //          Console.WriteLine(kullanicidangelendeger);
            //          kullanicidangelendeger--;
            //      }
            //      Console.ReadKey();

            //      Console.Clear();*/
            //    #endregion
            //    int toplam = 0;
            //    Console.WriteLine("Toplamak istediginiz sayilari yaziniz");
            //    Console.WriteLine("not eger -1 yazarsaniz toplama isleminizin sonucunu alirsiniz");


            //    while (true)
            //    {
            //        int kullanicidangelendeger = Convert.ToInt32(Console.ReadLine());

            //        if(kullanicidangelendeger < 0)

            //            break;
            //            else toplam += kullanicidangelendeger;



            //    }
            //    Console.WriteLine("toplama isleminizin sonucu = {0} ", toplam);
            //    Console.ReadKey();

            int tahminadeti = 1;
            int randomsayi = 0;


           
            Random rnd = new Random();
            randomsayi = rnd.Next(1, 10);

            while (true)
            {
                Console.Write("{0} . deneme  -  Lutfen tuttugum sayiyi tahmin ediniz : ",tahminadeti);
                string kullanicinintahimini = Console.ReadLine();

                if (int.Parse(kullanicinintahimini) == randomsayi)
                {
                    tahminadeti++;
                    Console.WriteLine("{0}. denemede buldunuz -  Tahmininiz dogru",tahminadeti);
                    Console.ReadKey();
                    break;
                    
                }
                else
                {
                    Console.WriteLine("{0}. deneme -  Bilemediniz , Lutfen tekrar deneyiniz ",tahminadeti);
                    tahminadeti++;
                }

                
            }






        }




    }
}
