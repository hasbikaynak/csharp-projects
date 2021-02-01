using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_ve_override_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            baseClass b1 = new baseClass();
            b1.ekranayaz("merhaba ");
            Urun u1 = new Urun();
            u1.ekranayaz("merhaba");
            televizyon t1 = new televizyon();
            t1.ekranayaz("merhaba");
        }
    }
}
