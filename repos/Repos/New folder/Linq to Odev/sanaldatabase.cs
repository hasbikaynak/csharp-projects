using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_to_Odev
{
    public class sanaldatabase
    {
        List<musteri> musteriler;
        public sanaldatabase()
        {
            musteriler = new List<musteri>();
        }

        public List<musteri> musterilistesi()
        {
            for (int i = 1; i <= 1000; i++)
            {

                musteri m1 = new musteri();
                m1.id = i;
                m1.isim = FakeData.NameData.GetFirstName();
                m1.soyisim = FakeData.NameData.GetSurname();
                m1.il = FakeData.PlaceData.GetCounty();
                m1.ilce = FakeData.PlaceData.GetCounty();
                m1.email = $"{m1.isim}.{m1.soyisim}@{FakeData.NetworkData.GetDomain()}";
                m1.dogumtarihi = FakeData.DateTimeData.GetDatetime(new DateTime(2000,01,01),new DateTime(1880,01,01));
                musteriler.Add(m1);
                
                
            }
            return musteriler;
        }
       
       

         
    }
    
}

