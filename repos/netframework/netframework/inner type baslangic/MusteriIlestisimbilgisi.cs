using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inner_type_baslangic
{
 public    class MusteriIlestisimbilgisi
    {
        public int iletisimtip { get; set; } // 717770001 : mobil - 717770002 : sabit hat
        public string alankodu { get; set; }
        public string numara  { get; set; }
        public bool pasifaktif { get; set; }

        public void musteriiletisimbilgisimetodu()
        {
            Console.WriteLine("musteriiletisimbilgisimetodu");
        }

    }
}
