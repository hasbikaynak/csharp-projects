using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            
            m1.tckimlik = "35650948426";
            m1.isim = "Mehmet Hasbi";
            m1.soyisim = "Kaynak ";
            m1.cinsiyet = "1";

            bool musterikontrol = m1.musterikontrol();

        }
        
        
    }
}
