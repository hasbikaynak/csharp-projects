using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sanalmetodnedir
{
    class Program
    {
        static void Main(string[] args)
        {
            musteri m1 = new musteri();
            m1.isim = "Salak";
            m1.soyisim = "Geruzukali";
            m1.ToString();//bu metodla musteri klasindaki namespaceyi ve .musteri yazdirmis oluruz.
            string yazdiralim = m1.ToString();
            Console.WriteLine(yazdiralim);// sanalmetodnedir.musteri
            //simdide override ile koda el atigimiz yeni sonucu gorelim
            
            Console.WriteLine(yazdiralim);
            Console.ReadKey();
        }
    }
}
