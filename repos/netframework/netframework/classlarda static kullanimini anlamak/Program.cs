using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classlarda_static_kullanimini_anlamak
{
    class Program
    {
        static void Main(string[] args)
        {
            personel p1 = new personel();
            p1.isim = "meraba";
            p1.soyisim = "televole";
            p1.cinsiyet = 1;
            p1._email = "meraba.televole";

            helper.emailgonder("salak@mal.com", "yeni personel bilgilendirme", p1.isim + p1.soyisim);
                
            
        }
    }
}
