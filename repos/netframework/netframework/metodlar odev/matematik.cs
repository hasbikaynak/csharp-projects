using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodlar_odev
{
    public class matematik
    {//hesaplamamizi yapan kodlari yazalim
        public decimal aritmatikortalama(decimal sayi1, decimal sayi2, decimal sayi3)
        {
            decimal sonuc = ortalama(sayi1, sayi2, sayi3);
            return sonuc;
        }
        // ekranda sonucumuzu gosterelim
        public void sonucuyazdiralim(decimal sayi1, decimal sayi2, decimal sayi3, decimal sonuc)
        {
            Console.WriteLine("ilk notunuz {0} , ikinci  notunuz {1} , ucuncu notunuz {2}, ortalamaniz {3}", sayi1, sayi2, sayi3, sonuc);


        }
        private decimal ortalama(decimal sayi1, decimal sayi2, decimal sayi3)
        {
            decimal sonuc= (sayi1 + sayi2 + sayi3) / 3;
            return sonuc;
        }
    }
}
