using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupbox_inceleme_form_application
{
   public class sanaldatabase
    {
        public List<Musteri> musteriler = new List<Musteri>();
        public sanaldatabase()
        {

        }
        public List<Musteri> musterilistele()
        {
            for (int i = 1; i < 1001; i++)
            {
                Musteri temp = new Musteri();
                temp.id = 1000 + i;
                temp.isim = FakeData.NameData.GetFirstName();
                temp.soyisim = FakeData.NameData.GetSurname();
                temp.tamadi = $"{temp.isim} { temp.soyisim}";
                temp.emailadres = FakeData.NetworkData.GetEmail(temp.isim,temp.soyisim);
                temp.telefonnumara = FakeData.PhoneNumberData.GetPhoneNumber();
                temp.il = FakeData.PlaceData.GetCity();
                temp.ilce = FakeData.PlaceData.GetState();
                temp.adres = FakeData.PlaceData.GetAddress();
                musteriler.Add(temp);

            }
            return musteriler;
        }


    }
}
