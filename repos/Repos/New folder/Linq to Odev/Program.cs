using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_to_Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            sanaldatabase sd = new sanaldatabase();
          List<musteri> m1  = sd.musterilistesi();
          var bulunanmusteriler =   from I in m1 where I.isim.StartsWith("A") && I.soyisim.Contains("b") && I.dogumtarihi.Year > 1928 select I;
            Console.WriteLine(bulunanmusteriler.Count());





            // var ismiailebaslayanve1985yilindanoncedogankisilerlistesi = m1.Where(I => I.isim.StartsWith("A") && I.soyisim.Contains("e") && I.dogumtarihi.Year > 1985);
            // Console.WriteLine(ismiailebaslayanve1985yilindanoncedogankisilerlistesi.Count());


            Console.ReadKey();
        }
    }
}
