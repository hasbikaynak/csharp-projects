using System.Collections;

namespace ortaya_karisik_odev
{


    public class musteri
    {
        static ArrayList musteridatabase;
        static musteri()
        {
            musteridatabase = new ArrayList();

        }

        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string email { get; set; }
        static string _kullaniciadi;
        public string kullaniciadi
        {
            get
            {
                return _kullaniciadi;
            }
            set
            {
                bool kullaniciadikontrol = musterikullaniciadikontrol(value);
                if (kullaniciadikontrol)
                {
                    System.Console.WriteLine("eklemek istediginiz kullanici adi sistem icerisinde kayitli");
                    this.kullaniciadi = string.Empty;  
                }
                else
                {
                    this.kullaniciadi = value; // buralara bi daha bak
                }

            }

        }

        public int sifre { get; set; }

        static bool musterikullaniciadikontrol(string kullaniciadi1)
        {
            bool kontrol = false;

            for (int i = 0; i < musteridatabase.Count ; i++)
            {
                musteri temp = (musteri)musteridatabase[i];
                if (temp.kullaniciadi==kullaniciadi1)
                {
                    kontrol = true;
                    break;
                }
            }


            return kontrol;
        }
        public static void musteriekle(musteri m)
        {
            if (m != null &&  !string.IsNullOrEmpty(m.kullaniciadi) && !string.IsNullOrEmpty(m.email))
                
            {
                bool emailadreskontrol = musteriemailadreskontrol(m.email);
                
                if (emailadreskontrol)
                {
                    System.Console.WriteLine("eklemek istediginiz kullanici sisteminde kayitli");
                }
                else
                {
                    musteridatabase.Add(m);
                    System.Console.WriteLine("yeni kayit islemi basarili ");
                }
            }
        }
            static bool musteriemailadreskontrol(string _emailadres)
            {
            bool kontrol = false;
            for (int i = 0; i < musteridatabase.Count; i++)
            {
                musteri temp = (musteri)musteridatabase[i];
                if (temp.email==_emailadres)

                {
                    kontrol = true;
                    break;
                }

            }
            return kontrol;
            }
        }
    }  

