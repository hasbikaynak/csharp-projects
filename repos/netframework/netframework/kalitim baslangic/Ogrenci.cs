using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitim_baslangic
{
    public /* sealed ile metodumu hicbir sekilde nesne haline, kalitim yapilamaz hale getiriyoruz */ class Ogrenci:TemelTip
    {
        public string bolum { get; set; }
        public int seviye { get; set; }

        public Ogrenci()
        {
            Console.WriteLine("ogrenci klasini yazdiralim");
        }
    }
}
