using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_kullanimi
{
    public class Musteri
    {
        public Guid ID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Emailadres { get; set; }
        public string Telefonnumarasi { get; set; }
    }
}
