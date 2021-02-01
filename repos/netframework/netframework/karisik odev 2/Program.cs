using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karisik_odev_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bilgisayar b1 = new bilgisayar();
            //b1.id = 1; // burayi biz girmeyecegiz , sanal bir sayacla otomatik atanacak ve set 
            // edilebilir olmasin.
            b1.model = "lenovo";
            b1.islemci = "z50";
            b1.satisfiyat = 1600M;
            b1.alisfiyat = 1500M;
            b1.kampanyafiyat = 1000M;
            b1.barkod = "1234567890";
            sanaldata.yeniurunekle(b1);
            bilgisayar b2 = new bilgisayar();
            //b1.id = 1; // burayi biz girmeyecegiz , sanal bir sayacla otomatik atanacak ve set 
            // edilebilir olmasin.
            b2.model = "lenovo";
            b2.islemci = "z50";
            b2.satisfiyat = 1600M;
            b2.alisfiyat = 1500M;
            b2.kampanyafiyat = 1000M;
            b2.barkod = "1234567890";

            sanaldata.yeniurunekle(b2);


            Console.ReadKey();
        }
    }
}
