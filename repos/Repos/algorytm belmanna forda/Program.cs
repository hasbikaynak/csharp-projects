using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorytm_belmanna_forda
{
    class Program
    {//ograniczenia na parametry krawedzi grafu
        const int maxliczbawezlowgrafu = 50;

        const int maxliczbakrawedzigrafu = 100;

        const int maxwagakrawedzigrafu = 700;
        // deklracja struktury oposujacej krawedz
        struct krawedz {
            public int poczkraw;
            public int konkraw;
            public int wagakraw;
        }
        //deklracja klasy grawkrawedziowy
        public class grafkrawedziowy
        {
            int liczbawezlow;
            int liczbakrawedzi;
            krawedz[] listakrawedzi;
            public grafkrawedziowy(int Liczbawezlow, int Liczbakrawedzi)
            {
                liczbawezlow = Liczbawezlow;
                liczbakrawedzi = Liczbakrawedzi;
                //utworzenie egzemplarza krawedzi
                listakrawedzi = new krawedz[Liczbakrawedzi];
            }
            //deklaracja metod publicznych
            public void dodajkrawedz(int nrkrawedzi, int nrwezlapoczatkukrawedzi, int nrwezlakoncakrawedzi, int wagakrewedzi)
            {
                listakrawedzi[nrkrawedzi].poczkraw = nrwezlapoczatkukrawedzi;
                listakrawedzi[nrkrawedzi].konkraw = nrwezlakoncakrawedzi;
                listakrawedzi[nrkrawedzi].wagakraw = nrkrawedzi;
            }
            //deklaracja metody algorytmu belmanna forda
            public bool bellmanford(int nrwezlastartowego, ref int[] wektorodleglosci, ref string[] wezlyposrednie)
            {
                //ustalenie stanu poczatkowego dla wektora odleglosci
                for (int i = 0; i < wektorodleglosci.Length; i++)
                    wektorodleglosci[i] = int.MaxValue;
                //ustalenie stanu poczatkowego dla wektora wezlyposrednie
                for (int i = 0; i < wezlyposrednie.Length; i++)
                    wezlyposrednie[i] = "";
                //ustalenie stanu poczatkowego dla algorytmubellmannaford
                wektorodleglosci[nrwezlastartowego] = 0;
                //zapis algorytmubelmannaforda
                for (int i = 0; i < wektorodleglosci.Length; i++)
                    for (int j = 0; j <liczbakrawedzi; j++)

                    {//deklaracja zmiennych pomocniczych
                        int Poczkraw = listakrawedzi[j].poczkraw;
                        int Konkraw = listakrawedzi[j].konkraw;     
                        int Wagakraw = listakrawedzi[j].wagakraw;
                        //relaksacja !!!
                        if ((wektorodleglosci[Poczkraw]!= int.MaxValue)&& wektorodleglosci[Poczkraw]+Wagakraw < wektorodleglosci[Konkraw]   )
                        {
                            //jest spelniony warunek relaksacji, a to oznacza ze mamy krotsza droge do wezla konkraw
                            wektorodleglosci[Konkraw] = wektorodleglosci[Poczkraw] + Wagakraw;
                            // dodanie dla wezla konkraw wezla posredniego 
                            wezlyposrednie[Konkraw] = wezlyposrednie[Konkraw] + " " + Poczkraw;                  
                        }

                    }
                //sprawdzenie, czy w grafie wystepuje cykl ujemny
                bool cykl_ujemny = false;
                for (int j = 0; j < liczbakrawedzi && (!cykl_ujemny); j++)

                {//deklaracja zmiennych pomocniczych
                    int Poczkraw = listakrawedzi[j].poczkraw;
                    int Konkraw = listakrawedzi[j].konkraw;
                    int Wagakraw = listakrawedzi[j].wagakraw;
                    //relaksacja !!!
                    if ((wektorodleglosci[Poczkraw] != int.MaxValue) && wektorodleglosci[Poczkraw] + Wagakraw < wektorodleglosci[Konkraw])
                    {
                        cykl_ujemny = true;
                        //break;
                    }

                }
                //zwrotne przekazenie wyniku algorytmu bellmanaford
                if (cykl_ujemny)
                    return false;
                else
                    return true;
                

                



            }
        }
        static void Main(string[] args)
        {
            // wpisanie metryki programu 
            Console.WriteLine("\n\tProgram wyznacza (weglug algorytmu belmannaforda) najkrotsze drugi (trasy) w grfie (bez ujemnych cykli) od wezla startowego ");
            int liczbawezlow, liczbakrawedzi;
            //wczytanie liczby wezlow grafu
            do
            {
                Console.WriteLine("\n\tPodaj liczbe wezlow grafu: ");
                while (!int.TryParse(Console.ReadLine(), out liczbawezlow))
                {
                    Console.WriteLine("\n\tError: podanej liczbie wezlow wystapil niedozwolony znak ");
                    Console.WriteLine("\n\tPodaj ponowne liczbe wezlow grafu: ");
                }
                if ((liczbawezlow <= 0) || (liczbawezlow > maxliczbawezlowgrafu))
                {
                    Console.WriteLine("\n\tError: podana liczba wezlow wykracza poza dopuszczalny zakres: 0 < liczba wezlow grafu < maxliczbawezlowgraf");
                }
                //sprawdzenie warunku wejsciowego nakladanego na liczbe wezlow           
            } while ((liczbawezlow <= 0) || (liczbawezlow > maxliczbawezlowgrafu));
            do
            {
                Console.WriteLine("\n\tPodaj liczbe krawedzi grafu: ");
                while (!int.TryParse(Console.ReadLine(), out liczbakrawedzi))
                {
                    Console.WriteLine("\n\tError: podanej liczbie krawedzi wystapil niedozwolony znak ");
                    Console.WriteLine("\n\tPodaj ponowne liczbe krawedzi grafu: ");
                }
                if ((liczbakrawedzi <= 0) || (liczbakrawedzi > maxwagakrawedzigrafu))
                {
                    Console.WriteLine("\n\tError: podana liczba krawedzi wykracza poza dopuszczalny zakres: 0 < liczba krawedzi grafu < maxliczbawezlowgraf");
                }
                //sprawdzenie warunku wejsciowego nakladanego na liczbe wezlow           
            } while ((liczbakrawedzi<= 0) || (liczbakrawedzi > maxwagakrawedzigrafu));
            //utworzenie egzemplarza obiektu gardu krawedzi
            grafkrawedziowy egzgrafu = new grafkrawedziowy(liczbawezlow, liczbakrawedzi);
            //wpisanie do egzamplarza egzgrafu opisu krawedzi grafu
            //pomocniczenie deklaracja
            int u, v, w;
            for (int i = 0; i < liczbakrawedzi; i++)
            {  //wczytanie numeru wezla dla i- yej krawedzi 
                do
                {
                    Console.WriteLine("\n\tPodaj numer wezla grafu z ktorego wychodzi  {0} - ta krawedz  " , i  );
                    while (!int.TryParse(Console.ReadLine(), out u))
                    {
                        Console.WriteLine("\n\tError: w podanym  numerze wezla wystapil niedozwolony znak ");
                        Console.WriteLine("\n\tPodaj ponowne nummer wezla grafu: ");
                    }
                    if ((u < 0) || (u > maxliczbawezlowgrafu))
                    {
                        Console.WriteLine("\n\tError: podany numer wezla  wykracza poza dopuszczalny zakres: 0 < u < maxliczbawezlowgraf");
                    }
                    //sprawdzenie warunku wejsciowego nakladanego na liczbe wezlow           
                } while ((u < 0) || (u > maxliczbawezlowgrafu));
                do
                {
                    Console.WriteLine("\n\tPodaj numer wezla grafu do ktorego dochodzi  {0} - ta krawedz  " , i  );
                    while (!int.TryParse(Console.ReadLine(), out v  ))
                    {
                        Console.WriteLine("\n\tError: w podanym  numerze wezla wystapil niedozwolony znak ");
                        Console.WriteLine("\n\tPodaj ponowne nummer wezla grafu: ");
                    }
                    if ((v < 0) || (v > maxliczbawezlowgrafu))
                    {
                        Console.WriteLine("\n\tError: podany numer wezla  wykracza poza dopuszczalny zakres: 0 < v < maxliczbawezlowgraf");
                    }
                    //sprawdzenie warunku wejsciowego nakladanego na liczbe wezlow           
                } while ((v < 0) || (v > maxliczbawezlowgrafu));
                //wagi krawedzi i tej krawedzi 
                do
                {
                    Console.WriteLine("\n\tPodaj wage   {0} - ta krawedz  : ", i);
                    while (!int.TryParse(Console.ReadLine(), out w))
                    {
                        Console.WriteLine("\n\tError: w podanej wadze krawedzi   wystapil niedozwolony znak ");
                        Console.WriteLine("\n\tPodaj ponowne wage {0}- o tej grafu: ", i);
                    }
                    if ((w < -maxwagakrawedzigrafu) || (w > maxwagakrawedzigrafu))
                    {
                        Console.WriteLine("\n\tError: podany numer wezla  wykracza poza dopuszczalny zakres: -maxwagakrawedzi < w < maxwagakrawedzi");
                    }
                    //sprawdzenie warunku wejsciowego nakladanego na liczbe wezlow           
                } while ((w < maxwagakrawedzigrafu) || (w > maxwagakrawedzigrafu));
                egzgrafu.dodajkrawedz(i, u, w, v);
            }
            //czytanie numeru wezla  startowego
            int start;
            do
            {
                Console.WriteLine("\n\tPodaj numer startowego   {0} - ta krawedz  : ");
                while (!int.TryParse(Console.ReadLine(), out start))
                {
                    Console.WriteLine("\n\tError: w podanej wadze krawedzi   wystapil niedozwolony znak ");
                    Console.WriteLine("\n\tPodaj ponowne startowego ");
                }
                if ((start < 0) || (start> maxliczbawezlowgrafu))
                {
                    Console.WriteLine("\n\tError: podany numer wezla  wykracza poza dopuszczalny zakres: 0 < start < maxliczbawezlowgrafu");
                }
                //sprawdzenie warunku wejsciowego nakladanego na liczbe wezlow           
            } while ((start < 0) || (start > maxliczbawezlowgrafu));

        }
    }
}