using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Hashtable h1 = new Hashtable(); // cnt + . ile hashtable kolleksiyonunu cagirdik ve olusturduk
        //    h1.Add("car", "reno");
        //    h1.Add("colour", "red");// ilk deger key ikincisi ise degerdir . keyler unique olmalidir.
        //    bool kontrol = h1.Contains("car");
        //    bool kontrol1 = h1.Contains("colour");// keyi kontrol eder

        //    bool kontrol2 = h1.ContainsValue("red"); // degeri kontrol eder
        //    h1.Clear();// butun koleksiyonu siler
        //    h1.Remove("car");// girilen keyi siler degeri ile beraber
        //    int koleksiyontoplamdeger = h1.Count; // listemiz icindeki degerleri int bir deger ustune aldik
        //    h1["car"] = "araba";// key degistirme

            Hashtable h1 = new Hashtable();
            do
            {
                Console.Clear();
                Console.WriteLine("Eklemek istediginiz veri degerini giriniz");
                Console.WriteLine("ENG: ");
                string eng = Console.ReadLine();
                if (h1.ContainsKey(eng))
                {
                    Console.WriteLine("Eklemek istediginiz deger {0} sozluk icerisinde zaten var " +
                        "karsiligi {1} dir " , eng , h1[eng].ToString());
                }
                else
                {
                    Console.WriteLine("{0} degerin turkce karsiligini yaziniz", eng);
                    string tr = Console.ReadLine();
                    h1.Add(eng, tr);
                    Console.WriteLine("degeriniz eklenmistir");

                }

                Console.WriteLine("yeni deger eklemek ister misiniz? (E/H)");



            } while (Console.ReadLine().ToUpper()!="H");
            foreach (var item in h1.Keys)
            {
                Console.WriteLine("ENG : {0}  -   TR:  {1}  ", item , h1[item]);
                Console.ReadKey();
            }
        }
    }
}
