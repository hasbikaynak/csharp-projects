using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_kullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Musteri> musterilerim = new List<Musteri>();
            for (int i = 0; i < 50; i++)
            {
                Musteri m1 = new Musteri();
                m1.ID = Guid.NewGuid();
                m1.Isim = FakeData.NameData.GetFirstName();
                m1.Soyisim = FakeData.NameData.GetSurname();
                m1.Telefonnumarasi = FakeData.PhoneNumberData.GetPhoneNumber();
                m1.Emailadres = $"{m1.Isim}.{m1.Soyisim}@{FakeData.NetworkData.GetDomain()}";
                musterilerim.Add(m1);
            }

            if (Directory.Exists("C:\\CSV\\"))
            {

            }
            else
            {
                Directory.CreateDirectory("C:\\CSV\\");
            }

            StreamReader SR = new StreamReader("C:\\CSV\\Musteriler.csv");
            CsvHelper.CsvReader reader = new CsvHelper.CsvReader(SR);
            List<Musteri> okunandata = reader.GetRecords<Musteri>().ToList();


            StreamWriter SW = new StreamWriter("C:\\CSV\\Musteriler.csv");
            CsvHelper.CsvWriter write = new CsvHelper.CsvWriter(SW);
            write.WriteHeader(typeof(Musteri));
            foreach (Musteri item in musterilerim)
            {
                write.WriteRecord(item);
            }
            SW.Close();

            Console.WriteLine("CSV olarak kayit islemi tamamlanmistir.");
            Console.WriteLine($"Toplam Adet: {musterilerim.Count}");
            Console.ReadKey();
        }
    }
}
