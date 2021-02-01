using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkbox_inceleme
{
    public class urun
    {
        public int id { get; set; }
        public string urunadi { get; set; }
        public string kategori { get; set; }
        public int stokadet { get; set; }
        public string yazar { get; set; }
        public string aciklama { get; set; }
        public string urunresim { get; set; }

        public override string ToString()
        {
            return urunadi;
        }
    }
}
