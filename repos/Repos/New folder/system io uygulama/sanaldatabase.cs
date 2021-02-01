using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system_io_uygulama
{
    public class sanaldatabase
    {
        public sanaldatabase()
        {

        }
        public List<Personel> personelgetir(int adet)
        {
            int id = 0;
            List<Personel> personeliste = new List<Personel>();
            for (int i = 0; i <=  adet; i++)
            {
                Personel p1 = new Personel();
                p1.id = id++;
                p1.isim = FakeData.NameData.GetFirstName();
                p1.soyisim = FakeData.NameData.GetSurname();
                p1.firmaadi = FakeData.NetworkData.GetDomain();
                p1.ulke = FakeData.PlaceData.GetCountry();
                p1.emailadres = p1.isim + "." + p1.soyisim + "@" + p1.firmaadi;
                personeliste.Add(p1);


            }
            return personeliste;
        }
       public void personelkaydet(string path, List<Personel> personelistesi)
        {
            for (int i = 0; i <= personelistesi.Count; i++)
            {
                if (Directory.Exists(path + " \\ " + personelistesi[i].ulke ))
                {

                }
                else
                {
                    Directory.CreateDirectory(path + " \\ " + personelistesi[i].ulke);
                }
            }
        }
    }
}
