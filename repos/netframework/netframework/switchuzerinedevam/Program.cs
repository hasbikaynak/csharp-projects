using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchodev
{
    class Program
    {
        static void Main(string[] args)
        {
        mytittle:

            int kullanicininislemi;

            Console.WriteLine("Kullanicidan aldigi veri ile aylari soyleyen program ");
            Console.WriteLine("Listeden istediginiz ayi secininiz ve projenin hangi fazda oldugunu ogreniniz :");
            Console.WriteLine("Ocak ayi icin 1 i seciniz ");
            Console.WriteLine("Subat ayi icin 2 yi seciniz");
            Console.WriteLine("Mart ayi icin 3 u seciniz");
            Console.WriteLine("Nisan ayi icin 4 u seciniz");
            Console.WriteLine("Mayis ayi icin 5 i seciniz");
            Console.WriteLine("Haziran ayi icin 6 yi seciniz");
            Console.WriteLine("Temmuz ayi icin 7 yi seciniz");
            Console.WriteLine("Agustos ayi icin 8 i seciniz");
            Console.WriteLine("Eylul ayi icin 9 u seciniz");
            Console.WriteLine("Ekim ayi icin 10 u seciniz");
            Console.WriteLine("Kasim ayi icin 11 i seciniz");
            Console.WriteLine("Aralik ayi icin 12 yi seciniz");

            kullanicininislemi = Convert.ToInt32(Console.ReadLine());

            switch (kullanicininislemi)
            {
                case 1:
                case 2:
                case 3:   
                case 4:
                    Console.WriteLine("1.Faz");
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("2.Faz  ");
                    break;
                case 9:
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("3.Faz  ");
                    break; ;
                default:
                    Console.WriteLine("HATA");
                    goto mytittle;

            }

            Console.ReadKey();

        }
    }
}
