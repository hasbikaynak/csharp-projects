using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial_class
{
    class Program
    {
        static void Main(string[] args)
        {
            musteri m1 = new musteri();
            m1.id = 1;
            m1.isim = "mehmet";
            m1.soyisim = "kaynak";
            m1.email = "mehmet@kaynak.com";
            int sonuc = m1.yenikayit(m1);
            if (sonuc>0)
            {
                Console.WriteLine("database yeni kayit eklendi ");
            }
            m1.kayitsil(sonuc);
            Console.WriteLine(m1);
            Console.ReadKey();
        }
    }
}
