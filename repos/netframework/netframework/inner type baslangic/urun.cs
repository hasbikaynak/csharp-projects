using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inner_type_baslangic
{
  public  class urun
    {
        public int urunid { get; set; }
        public string tanim { get; set; }
        public decimal fiyat { get; set; }

        public urun()
        {
            Console.WriteLine("urun yapici metod calisti");
        }

        public void urunmetodu()
        {
            Console.WriteLine("urunmetodu");
        }
    }
}
