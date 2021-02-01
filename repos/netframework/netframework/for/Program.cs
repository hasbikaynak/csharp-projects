using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @for
{
    class Program
    {
        static void Main(string[] args)
        {
            #region for basit
            for(int i=0; i<=10; i++)

            {
                Console.WriteLine("Ben bir for dongusuyum"); 
            }

            #endregion
             Console.Clear();

            #region Ekranda 1-10 arasi sayilarin yazdirimi
            for (int i = 1; i<=10; i++)
            {
                Console.WriteLine(i + ". tekrar !");
            }
           
            #endregion
            Console.Clear();

            #region ekranda 1-100 arasindaki  cift sayilari yazdiralim 
            for (int i=1; i<=100; i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i + "- cift sayidir");
                }
            }
            Console.ReadKey();
           
            #endregion
            Console.Clear();
            #region 1-100 arasindaki cift sayilarin toplami nedir?
            int cifsayilarintoplami = 0;
            
            for (int i=1; i<=100; i++)
                
            {
                if(i%2==0)
                {
                    cifsayilarintoplami += i;
                }
            }
            Console.WriteLine("1 ile 100 arasindaki sayilarin toplami : {0}", cifsayilarintoplami);
            Console.ReadKey();
            #endregion
            Console.Clear();

            string kullanicidangelendeger = string.Empty;
            int kullanicidangelendegerint = 0;
            int faktoriyel = 1;

            Console.WriteLine("Kullanicidan alinan degerin faktoriyel hesaplamasini yapan uygulama");
            Console.Write("Lutfen degerinizi giriniz : ");
            kullanicidangelendeger = Console.ReadLine();
            kullanicidangelendegerint = int.Parse(kullanicidangelendeger);

            for(int i=kullanicidangelendegerint; i>1;i--)
            {
                faktoriyel *= i;
            }

            Console.WriteLine("{0} dongusunun faktoriyeli : {1} " , kullanicidangelendeger,faktoriyel);

            Console.ReadKey();



        }
    }
}
