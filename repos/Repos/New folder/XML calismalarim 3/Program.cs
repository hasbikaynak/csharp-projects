using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML_calismalarim_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ogrenci> o1 = new List<Ogrenci>(); // listem olustu ve 100 tane deger olusturum
            for (int i = 0; i < 100; i++)
            {
                Ogrenci temp = new Ogrenci(); // her olusturulan deger icin yeni bir deger aliyorum
                temp.ID = Guid.NewGuid();
                temp.isim = FakeData.NameData.GetFirstName();
                temp.soyisim = FakeData.NameData.GetSurname();
                temp.numara = FakeData.NumberData.GetNumber(100, 500);
                o1.Add(temp); // ve o1 listeme temp ile bastiriyorum
            }
            XDocument xdoc = new XDocument(new XDeclaration("1.1", "UTF-8", "Yes"),// simdi de xml 
                //bilgilerimi olustuyorum.
               new XElement("Ogrencilerim",
               o1.Select(I => new XElement("Ogrenci",
               new XElement
               ("ID", I.ID),
               new XElement("Isim", I.isim),
               new XElement("Soyisim", I.soyisim),
               new XElement("Numara", I.numara)
               )
               )
               )
               );
            xdoc.Save(@"C:\XML\Ogrencilerim.xml"); // bilgilerimi kaydettim

            // bilgilerimi kaydettikten sonra bunlari okutmam lazim
            XDocument docoku = XDocument.Load(@"C:\XML\Ogrencilerim.xml");
            List<XElement> okunanxelement = docoku.Descendants("Ogrenci").ToList();//ogrenci 
            //degerindeki verilerimi xelement listesi haline cevirdim ve okunanxelement uzerine aldim
            List<Ogrenci> okunandata = new List<Ogrenci>();
            foreach (XElement item in okunanxelement)
            {
                Ogrenci temp = new Ogrenci();
                temp.ID =Guid.Parse(item.Element("ID").Value);
                temp.isim = item.Element("Isim").Value;
                temp.soyisim = item.Element("Soyisim").Value;
                temp.numara = int.Parse(item.Element("Numara").Value);
                okunandata.Add(temp);

            }
            Console.ReadKey();
        }
    }
}
