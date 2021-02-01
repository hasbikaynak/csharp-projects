using System;

namespace Mehmet_Hasbi_Kaynak_48723_projekt3
{
    class Program
    {
        const short BrakDrogi = short.MaxValue;
        static int[,] MacierzWag;
        static int[,] MacierzOdległosci;
        static int[,] MacierzWęzłówPośrednich;
        static void Main(string[] args)
        {
            ushort n;
            int i, j, k;
            string Input;

            Console.WriteLine("\n\tProgram: Algorytm_Floyda_Warshalla_2020" +
                "scieżki(trasy , drogi) między wszystkimi wierzchołakmi grafu");
            do
            {
                Console.WriteLine("\n\tPodaj liczbę węzłów (weirzchołków) grafiku");
                while (!ushort.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("\n\tERROR: w podanej liczbie węzłó" +
                        "niedozwolony znak");
                    Console.Write("\n\tpodaj ponownie liczbę węłów (wierzchołków) grafu:");
                }
                if (n == 0)
                    Console.WriteLine("\n\tERROR: liczba wierzchołków grafu powinna spełniać " +
                        "warunek wejsciowy: n > 0");
            } while (n == 0);
            MacierzWag = new int[n, n];
            MacierzOdległosci = new int[n, n];
            MacierzWęzłówPośrednich = new int[n, n];
            //MacierzOdległosci = MacierzWag;
            for (j = 0; j < MacierzWag.GetLength(0); j++)
                for (i = 0; i < MacierzWag.GetLength(1); i++)
                    if (j == i)
                        MacierzOdległosci[j, i] = BrakDrogi;
                    else
                        MacierzOdległosci[j, i] = MacierzWag[j, i];
            for (j = 0; j < MacierzWęzłówPośrednich.GetLength(0); j++)
                for (i = 0; i < MacierzWęzłówPośrednich.GetLength(1); i++)
                    MacierzWęzłówPośrednich[j, i] = 0;
            //zapis algorytmu floryda warshalla 
            for (k = 0; k < MacierzOdległosci.GetLength(0); k++)
            {
                for (j = 0; j < MacierzOdległosci.GetLength(0); j++)
                    for (i = 0; i < MacierzOdległosci.GetLength(1); i++)
                        if (MacierzOdległosci[j, i] >
                            (MacierzOdległosci[j, k] + MacierzOdległosci[k, i]))
                        {
                            MacierzOdległosci[j, i] = MacierzOdległosci[j, k] + MacierzOdległosci[k, i];
                            MacierzWęzłówPośrednich[j, i] = k;
                        }
            }
            Console.WriteLine("\n\n\tMacierzy najkrótszych tras  w naszym grafie \n\t");
            for (j = 0; j < MacierzWęzłówPośrednich.GetLength(0); j++)
            {
                Console.WriteLine("\t");
                for (i = 0; i < MacierzWęzłówPośrednich.GetLength(1); i++)
                    if (MacierzOdległosci[j, i] == BrakDrogi)

                        Console.Write(" {0,3}", "*");
                    else
                        Console.Write(" {0,3}", MacierzOdległosci[j, i]);


            }
            Console.WriteLine("\n\n\tMacierzy węzłów pośrednich  w naszym grafie \n\t    ");
            for(j = 0; j < MacierzWęzłówPośrednich.GetLength(0); j++)
            {
                Console.Write("\n\t");
                for (i = 0; i < MacierzWęzłówPośrednich.GetLength(1); i++)
                    if(MacierzWęzłówPośrednich[j,i]==0)
                        Console.Write(" {0,3}", "*");
                    else
                        Console.Write(" {0,3}", MacierzOdległosci[j, i]);

            }
            Console.WriteLine("\n\n\tPełne tras połączeń z każdego węzła  w grafie: \n\t ");
            for (j = 0; j < MacierzWęzłówPośrednich.GetLength(0); j++)
            for (i = 0; i < MacierzWęzłówPośrednich.GetLength(1); i++)
                {
                    if(MacierzOdległosci[j,i]==BrakDrogi )
                        Console.WriteLine("Między węzłem , {0,3} a węzłem {1,3} ,  " +
                            "nie ma drogi  przejcia ! " , j , i );
                    else 
                        if(j!= i )
                    {
                        //.        .          .    kontynuujemy stąd (12/4/2020)
                    }
                }
                    


        }
    }
}
