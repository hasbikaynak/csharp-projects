using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ortaya_karisik_odev
{
    class Program
    {
        static void Main(string[] args)
        {
            musteri m1 = new musteri();
            m1.id = 1;
            m1.isim = "meraba";
            m1.soyisim = "televole";
            m1.email = "meraba@televole.com";
            m1.kullaniciadi = "meraba.televole";
            m1.sifre= 1;
            musteri.musteriekle(m1);
            musteri m2 = new musteri()
            {
                id = 2,
                isim = "salak",
                soyisim = "geruzukalu",
                email = "salak@geruzukalu.com",
                kullaniciadi = "salak.geruzukalu",
                sifre = 2,

            };
            musteri.musteriekle(m2);
            musteri m3 = new musteri();
            m3.id = 1;
            m3.isim = "meraba";
            m3.soyisim = "televole";
            m3.email = "meraba@televole.com";
            m3.kullaniciadi = "meraba.televole";
            m3.sifre = 1;
            musteri.musteriekle(m3);


        }
    }
}
