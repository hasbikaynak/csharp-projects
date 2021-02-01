using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelseodev
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, islem1, islem2, islem3, islem4, kullanicininislemi;

            Console.WriteLine("4 islem yapan uygulama");



            Console.WriteLine("Lutfen ilk sayiyi giriniz ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lutfen ikinci sayiyi giriniz ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lutfen yapmak istediginiz islemi seciniz: ");
            Console.WriteLine("Toplama islemi icin '1' i secin ");
            Console.WriteLine("Cikarma islemi icin '2' i secin  ");
            Console.WriteLine("Carpma islemi icin '3' i secin  ");
            Console.WriteLine("Bolme islemi icin '4' i secin ");
            kullanicininislemi = Convert.ToInt32(Console.ReadLine());


            islem1 = sayi1 + sayi2;
            islem2 = sayi1 - sayi2;
            islem3 = sayi1 * sayi2;
            islem4 = sayi1 / sayi2;

            if(kullanicininislemi==1)
            {
                Console.WriteLine("isleminizin sonucu : {0}", islem1);
            }
            else if (kullanicininislemi == 2)
            {
                Console.WriteLine("isleminizin sonucu : {0}", islem2);
            }
            else if (kullanicininislemi == 3)
            {
                Console.WriteLine("isleminizin sonucu : {0}", islem3);
            }
            else if (kullanicininislemi == 4)
            {
                Console.WriteLine("isleminizin sonucu : {0}", islem4);
            }
            else
            {
                Console.WriteLine("Hata");

            }
            Console.ReadKey();
            
            

            
        }

    }
}
