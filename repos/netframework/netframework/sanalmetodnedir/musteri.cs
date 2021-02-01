using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sanalmetodnedir
{
   public class musteri
    {
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int id { get; set; }

        public override string ToString() // override ile namespaceyi yazmasi gerekirken ona icinde olmayan baska  bir islem yaptiriyoruz
        {
            return isim + " " + soyisim;
        }
    }
}
