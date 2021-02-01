using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form_applicationa_giris_4
{
   public static class sanaldatabase
    {
        public static  List<Musteri> musteriler     { get; set; }


        static sanaldatabase()
        {
            musteriler = new List<Musteri>();
        }
    }
}
