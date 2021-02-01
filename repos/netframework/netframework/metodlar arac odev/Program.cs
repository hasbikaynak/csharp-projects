using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodlar_arac_odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Arac a1 = new Arac();
            a1.marka = "mazda";
            a1.model = "namazda";
            a1.km = 20000;
            a1.modelyil = 2019;
            a1.yakittipi = "diesel";
            a1.vitestipi = 5;
            a1.alisfiyat = 40000;
            a1.satisfiyat = 20000;
            a1.maxindirimtutar =150;
            a1.fiyat = 40000;
            // urunlerin icindekileri listele
            a1.ekrandagoster(a1.marka,a1.model,a1.yakittipi,a1.modelyil,a1.km,a1.vitestipi,a1.alisfiyat,a1.satisfiyat,a1.maxindirimtutar,a1.fiyat);
            
            //fiyat atama
            a1.fiyatatama(30000);

            Console.WriteLine("devam etmek icin herhangi bir tusa basin");
            Console.ReadKey();

        }
    }
}
