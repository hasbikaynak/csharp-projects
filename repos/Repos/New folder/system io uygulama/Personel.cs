using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system_io_uygulama
{
    public class Personel
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string emailadres { get; set; }
        public string firmaadi { get; set; }
        public string ulke { get; set; }
        public override string ToString()
        {
            return isim + " " + soyisim;
        }

    }
}
