using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forsonsuzdongu
{
    class Program
    {
        static void Main(string[] args)
        {/*
            #region for break;
            int sayac = 0;

            for (; ; )
            {
                sayac++;

                if (sayac == 2)
                    break;
                    Console.WriteLine(sayac);
                    Console.WriteLine("merhaba sonsuz dongu televolesi");
                Console.ReadKey();
                
            }
            #endregion
            Console.Clear();
            */

            /* for(int i =1; i<=20;i++)
             {
                 for(int j=1; j<=i;j++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();
             }
             Console.ReadKey();
            */
            

           for (int i= 1; i < 10;i++)
            {
                for(int x=1; x < 10; x++)                                                                     
                {
                    int sonuc = x * i;
                    Console.WriteLine("{0} x {1} = {2}\t",x,i,sonuc);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
