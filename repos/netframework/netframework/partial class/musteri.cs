using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial_class
{
   public class musteri
    {
        public int id    { get; set; }
        public  string isim { get; set; }
        public  string soyisim { get; set; }
        public  string email { get; set; }

        public int yenikayit(musteri m)
        {
            Console.WriteLine("database kaydi guncellendi");
            return 1;

        }
        public int kayitguncelle(musteri m)
        {
            Console.WriteLine("musteri kaydi guncellendi ");
            return 1;

        }
        public int kayitsil(int id)
        {
            Console.WriteLine("musteri kaydi silindi");
            return 1;
        }
    }
}
