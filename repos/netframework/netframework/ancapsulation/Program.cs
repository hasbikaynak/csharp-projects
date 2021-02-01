using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ancapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            Console.WriteLine(" atanan id degeri:" + m1.ID );  //m1.id = "saaalak";
            m1.isim = "geruzukaaalu";
            m1._soyisim = "saaalak";
            //m1.soyisim = "maaal";
            //m1._email = "35650948426";//private metodu olmasina ragmen disarki dunyadan myproperty ile 
            //private tckimliknosunun icine bilgi aldik. set value ile
            //Console.WriteLine(m1._email);//get return ile yazdigimiz koda gitmek icin request yaptik
            
            m1._tckimlikno = "12312312311";
            Console.WriteLine(m1._tckimlikno);
            string mail = m1._tckimlikno;
            Console.WriteLine(m1._email);
            
            Console.ReadKey();
        }
    }
}
