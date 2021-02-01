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

            Console.WriteLine("Kullanicidan aldigi veri ile aylari soyleyen program : ");
            Console.WriteLine("Listeden secmek istediginiz aylari secininiz Aylar :");
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
            
            kullanicininislemi = Convert.ToInt32 (Console.ReadLine());

            switch (kullanicininislemi)
            {
                case 1:
                    Console.WriteLine("Sectiginiz ay Ocaktir  ");

                    break;

                case 2:
                    Console.WriteLine("Sectiginiz ay Subattir  ");
                    break;

                case 3:
                    Console.WriteLine("Sectiginiz ay Marttir  ");
                    break;
                case 4:
                    Console.WriteLine("Sectiginiz ay Nisandir  ");
                    break;
                case 5:
                    Console.WriteLine("Sectiginiz ay Mayistir  ");
                    break;
                case 6:
                    Console.WriteLine("Sectiginiz ay Hazirandir  ");
                    break;
                case 7:
                    Console.WriteLine("Sectiginiz ay Temmuzdur  ");
                    break;
                case 8:
                    Console.WriteLine("Sectiginiz ay Agustostur  ");
                    break;
                case 9:
                    Console.WriteLine("Sectiginiz ay Eyluldur  ");
                    break;
                case 10:
                    Console.WriteLine("Sectiginiz ay Ekimdir  ");
                    break;
                case 11:
                    Console.WriteLine("Sectiginiz ay Kasimdir  ");
                    break;

                case 12:
                    Console.WriteLine("Sectiginiz ay Araliktir  ");
                    break;
                default:
                    Console.WriteLine("HATA");
                    goto  mytittle;
                    
            }

            Console.ReadKey();

        }
    }
}
