using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netframework2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte sayi1 = byte.MaxValue;
            sayi1 = byte.MinValue;

            int sayi2 = 125;

            sayi1 = (byte)sayi2;

            Console.WriteLine(sayi1);


            object temeltip = sayi2; // boxing islemi   
            sayi2 = (int)temeltip; // unboxing islemi

            
            
            
            
            Console.ReadLine();
        }
    }
}
