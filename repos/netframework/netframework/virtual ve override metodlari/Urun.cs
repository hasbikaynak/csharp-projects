using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_ve_override_metodlari
{
   public class Urun:baseClass
    {
        public override void ekranayaz(string data) // override ile urun classi icindeki baseclasstan gelen ekranayaz metodunu degistirdik. ancak baseclass icerisindeki ayni sekilde kaldi.
        {
            Console.WriteLine("urun => " + data);
        }
    }
}
