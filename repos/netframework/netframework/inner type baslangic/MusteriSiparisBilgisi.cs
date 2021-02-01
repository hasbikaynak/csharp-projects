using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inner_type_baslangic
{
    public class MusteriSiparisBilgisi
    {
        public string siparisnumarasi { get; set; }

        public urun[] urunler;

        public MusteriSiparisBilgisi()
        {
            urunler = new urun[2];
        }

        public void musterisiparisbilgisimetodu()
        {
            Console.WriteLine("musterisiparisbilgisimetodu");
        }

        
    }
}
