using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertileparsearasindakifark
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Operatorler-toplama
            Console.WriteLine("Konsol uzerinde verilen degerlerle toplama islemi yapan uygulama");


            Console.Write("Lutfen ilk degeri giriniz : ");
            string gelendeger1 = Console.ReadLine();
            Console.Write("Lutfen ikinci degeri giriniz : ");
           string  gelendeger2 = Console.ReadLine();

            int sayi1 = Convert.ToInt32(gelendeger1);
            int sayi2 = Convert.ToInt32(gelendeger2);
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Isleminizin sonucu : {0}", toplam); 

            Console.ReadKey();

            #endregion





        }


    }
}
