using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_siniflar_ne_degildir_detayli_inceleme
{
   public  class musteri
    {
        public int id { get; set; }
        public Guid musterinumara { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime dogumtarihi { get; set; }
    }
}
