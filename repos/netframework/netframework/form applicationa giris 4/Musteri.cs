using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form_applicationa_giris_4
{
    public class Musteri
    {
        public string isim { get; set; }
        public Guid id { get; set; }
        public string soyisim { get; set; }
        public string email { get; set; }
        public string telefon { get; set; }

        public override string ToString()
        {
            return isim + "" + soyisim;
        }
    }
}
