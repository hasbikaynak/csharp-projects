using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitim_baslangic
{
   public  class Egitmen:TemelTip  // iki nokta alt alta yazarak egitmen klasimizi temel tip klasina bagladik
    {
        public string brans { get; set; }
        public int seviye { get; set; }
        public DateTime isbaslangictarihi { get; set; }
        public DateTime isbitistarihi { get; set; }
        public int izingunsayisi { get; set; }

        public Egitmen() // yapici metot (ctor) ile eger kullanicidan bilgi almadan once islem yapsin istiyorsak, bu metodla mudahale ediyoruz
        {
            Console.WriteLine("egitmen klasi yazdiralim");
            
        }


    }
}
