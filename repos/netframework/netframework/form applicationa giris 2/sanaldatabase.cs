using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form_applicationa_giris_2
{
    public class sanaldatabase
    {
        public static List<kullanici> kullanicitablo = new List<kullanici>();
        static sanaldatabase()
        {
            kullanicitablo.Add(new kullanici()
            {
                id = 1,
                 isim = "Mehmet Hasbi ",
                  soyisim = "Kaynak",
                   kullaniciadi="mehmethasbi.kaynak",
                    sifre = "1",
                     aciklama = "Tum haklari saklidir."
                    

            });
            kullanicitablo.Add(new kullanici()
            {
                id = 2,
                isim = "Olaf ",
                soyisim = "Kaynak",
                kullaniciadi = "olaf.kaynak",
                sifre = "2",
                aciklama = "Tum haklari saklidir."


            });
        }

        


    }
}
