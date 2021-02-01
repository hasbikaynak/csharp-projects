using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML_calismalarim
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextWriter xmlText = new XmlTextWriter(@"C:\XML\Personellerim.xml", System.Text.UTF8Encoding.UTF8);// ilk once using systeme xml kullanmak
            // istedigimizi belirttik ve xmlwriter new ile klosurumuzu olusturacagimiz yeri belirledik. Sonrasinda ise utf8encoding harf
            //sistemini kullanmak istedigimizi bildirdik.
            xmlText.WriteComment("Xml islemleri");//xml islemleri yorum satirimiz 
            xmlText.WriteStartElement("Personellerim");//personellerim isimli bir element olusturduk

            xmlText.WriteStartElement("Personel");
            xmlText.WriteAttributeString("ID", "1");
            xmlText.WriteElementString("Isim", "Olaf");
            xmlText.WriteElementString("Soyisim", "Kaynak");
            xmlText.WriteElementString("Email", "olaf.kaynak@gmail.com");
            xmlText.WriteEndElement();

            xmlText.WriteStartElement("Personel");
            xmlText.WriteAttributeString("ID", "2");
            xmlText.WriteElementString("Isim", "Mehmet Hasbi");
            xmlText.WriteElementString("Soyisim", "Kaynak");
            xmlText.WriteElementString("Email", "mhasbi.kaynak@gmail.com");
            xmlText.WriteEndElement();

            xmlText.WriteEndElement();
            xmlText.Close();

            XmlReader Xread = XmlReader.Create(@"C:\XML\Personellerim.xml");
            while (Xread.Read())
            {
                Console.WriteLine($"{Xread.Name.ToString()} - {Xread.Value.ToString()}");

            }
            Console.ReadKey();

        }
    }
}
