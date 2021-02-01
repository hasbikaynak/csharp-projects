using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_nedir
{
    public class DataSource
    {
        List<Musteri> Musteris;

        public DataSource()
        {
           Musteris = new List<Musteri>();
        }

        public List<Musteri> musterilist()
        {
            for (int i = 1; i <= 1000; i++)
            {
                Musteri m1 = new Musteri();
                m1.id = i;
                m1.name = FakeData.NameData.GetFirstName();
                m1.surname = FakeData.NameData.GetSurname();

                m1.email = $"{ m1.name.ToLower()}.{m1.surname.ToLower()}@{FakeData.NetworkData.GetDomain()}";
                m1.birthday = FakeData.DateTimeData.GetDatetime(new DateTime(1984,01,01),new DateTime(1997,01,01));
                m1.country = FakeData.PlaceData.GetCountry();
                m1.city = FakeData.PlaceData.GetCity();
                m1.district = FakeData.PlaceData.GetState();
                m1.phonenumber =FakeData.PhoneNumberData.GetPhoneNumber();

                Musteris.Add(m1);
            }
            return Musteris;

        }
    }
}
