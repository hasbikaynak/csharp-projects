using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace LateBindingIslemleri
{
    class Program
    {
        static void Main(string[] args)
            // runtime da deger yakalamak istiyoruz 
        {
            Assembly Exec = Assembly.GetExecutingAssembly();
            Type  T = Exec.GetType("LateBindingIslemleri.Musteri"); //bu sekilde uygulamamizin 
                                                            //kendi icinde kendi degerlerini yakalatiyoruz

            object musterInst = Activator.CreateInstance(T);
          MethodInfo MI =   T.GetMethod("MusterIsimGetir");


            string[] parametrelerim = new string[2];
            parametrelerim[0] = "Hasbi";
            parametrelerim[1] = "Kaynak";

           string gelendeger  =(string)MI.Invoke(musterInst, parametrelerim);
            Console.WriteLine(gelendeger);
            Console.ReadLine();
        }
    }
}
