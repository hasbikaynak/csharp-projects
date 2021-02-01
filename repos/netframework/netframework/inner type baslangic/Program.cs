using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inner_type_baslangic
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();

            m1.isim = "meraba";
            m1.soyisim = "televole";
            m1.tckimliknumarasi = "35650948426";
            m1.kullaniciID = 1;
            m1.olusturulmatarihi = DateTime.Now;

            // inner type metodlari icin musteri klasi icinde yapici metodla listelerimizi tanimlayalim

            m1.musteriadreslistesi[0] = new MusteriAdres()
            {
                il = "manisa",
                ilce = "sarigol",
                adres = "siteler mah alasehir cad ",
                adrestip = "homeoffice"
                       
                
            };

            //innertyplerimizdaki metotlari cagiralim
            m1.musteriadreslistesi[0].musteriadresmetodu();

            // odevi yapmadan once bi daha debug et...

            m1.musterisiparislistesi[0] = new MusteriSiparisBilgisi()
            {
                siparisnumarasi = "sip001",


            };




            m1.musterisiparislistesi[0].urunler[0] = new urun {

                urunid = 1,
                tanim = "telefon",
                 fiyat = 123123,
            };
            Console.ReadKey();

        }
    }
}
