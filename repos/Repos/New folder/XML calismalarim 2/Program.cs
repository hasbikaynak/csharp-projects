using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML_calismalarim_2
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xdoc = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                new XElement("VeriTabanim",
                new XComment("Yorum Eklendi"),
                new XElement("Personellerim", new XAttribute("ID","1"),
                new XElement("Isim", "Mehmet"),
                new XElement("Soyisim", "Kaynak"),
                new XElement("EmailAdres", "m.kaynak@gmail.com")
                )
                )
                ); 
            xdoc.Save(@"C:\XML\Ornek2.xml");
        }
    }
}
