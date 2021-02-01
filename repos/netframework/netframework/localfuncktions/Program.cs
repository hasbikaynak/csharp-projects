using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace localfuncktions
{
    class Program
    {
        static void Main(string[] args)
        {
            localfuncktions(12, 24);
        }
        static void localfuncktions(int sayi1 ,int sayi2)//anlamadiysan debug yap
        {
            int topla(int gelensayi1, int gelensayi2)
            {
                return gelensayi1 + gelensayi2;
            }
            int toplamdeger = topla(sayi1, sayi2);
            Console.WriteLine(toplamdeger);
            Console.ReadKey();
        }
    }
}
