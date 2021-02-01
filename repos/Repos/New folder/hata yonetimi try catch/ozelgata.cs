using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hata_yonetimi_try_catch
{
    class ozelgata:Exception
    {
        public ozelgata()
        {
            Console.WriteLine("ozel hata");
        }
    }
}
