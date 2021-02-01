using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_cagiralim
{
    class Program
    {
        static void Main(string[] args)
        {
            matematiksel_islemler.Class1 matematiksel = new matematiksel_islemler.Class1();
            int sonuc =matematiksel.toplama(10, 20);
            Console.WriteLine(sonuc);
            Console.ReadKey();
           
        }
    }
}
