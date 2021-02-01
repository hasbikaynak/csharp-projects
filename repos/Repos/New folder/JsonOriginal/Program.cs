using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonOriginal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personel> personellerim = new List<Personel>();
            for (int i = 0; i < 1000; i++)
            {
                Personel p1 = new Personel();
                p1.ID = Guid.NewGuid();
                p1.Isim = FakeData.NameData.GetFemaleFirstName();
                p1.Soyisim = FakeData.NameData.GetSurname();
                p1.Email = $"{p1.Isim}.{p1.Soyisim}@{FakeData.NetworkData.GetDomain()}";
                p1.TelefoNumarasi = FakeData.PhoneNumberData.GetPhoneNumber();
                personellerim.Add(p1);
            }
            
            Console.ReadLine();
            Console.WriteLine("Bilgilerinizi Json formatinda C:\\JsonIslemlerim\\Personellerim.json olarak kaydedilecektir.");
            if (Directory.Exists("C:\\JsonIslemlerim\\"))
            {

            }
            else
            {
                Directory.CreateDirectory("C:\\JsonIslemlerim\\");
            }
            string jsonpersonellerim = Newtonsoft.Json.JsonConvert.SerializeObject(personellerim);
            File.WriteAllText("C:\\JsonIslemlerim\\Personellerim.json", jsonpersonellerim);
            Console.WriteLine("Json export islemleri tamamlandi");
        }
    }
}
