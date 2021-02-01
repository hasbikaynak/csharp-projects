using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial_class
{
   public partial class ogrenci //public ile class arasina partial koyarsan, ayni classin bir partialli oldugunu sistemimiz anlar ve ona gore davranir.
    {
        public int yenikayit(ogrenci o)
        {
            Console.WriteLine("database kaydi guncellendi");
            return 1;

        }
        public int kayitguncelle(ogrenci o)
        {
            Console.WriteLine("musteri kaydi guncellendi ");
            return 1;

        }
        public int kayitsil(int id)
        {
            Console.WriteLine("ogrenci kaydi kaydi silindi");
            return 1;
        }
    }
}
