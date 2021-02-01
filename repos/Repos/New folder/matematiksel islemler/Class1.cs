using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematiksel_islemler
{
    public class Class1
    {
        public int toplama(int sayi1, int sayi2)
        {
            int sonuc =sayi1 + sayi2;
            return sonuc;
        }
        
        public int cikarma(int sayi1, int sayi2)
        {
            int sonuc =sayi1 - sayi2;
            return sonuc;
        }

        public int carpma(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            return sonuc;
        }
        public int bolme(int sayi1, int sayi2)
        {
            int sonuc = sayi1 / sayi2;
            return sonuc;
        }
    }
}
