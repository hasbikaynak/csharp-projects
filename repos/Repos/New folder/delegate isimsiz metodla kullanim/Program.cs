using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_isimsiz_metodla_kullanim
{
    class Program
    {
        delegate void ekranayaz(string isim, string soyisim);
        static void Main(string[] args)
        {

            ekranayaz test1 = new ekranayaz(test1metod);
            ekranayaz test2 = new ekranayaz(delegate (string isim, string soyisim) 
            {
                Console.WriteLine(isim + " " + soyisim);
            });
            ekranayaz test3 = (isim, soyisim) =>
            {
                Console.WriteLine(isim + " " + soyisim);
            };

            test1("mehmet", "hasbi");
            test2("mehmet", "kaynak");
            test3("hasbi", "kaynak");
            Console.ReadKey();
            

           
        }

        static void test1metod(string isim, string soyisim)
        {
            Console.WriteLine(isim + " " + soyisim);
        }
    }
}
