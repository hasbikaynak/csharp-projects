using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList a1 = new ArrayList();
            //a1.Add("hasbi");
            //a1.Add(23);

            //ArrayList a2 = new ArrayList();
            //a2.Add("ibraaam");
            //a2.Add("Hasan2salakosman4");
            //a1.AddRange(a2);

            //object o1 = a1[2];
            //string s1 = a1[0].ToString();
            //int i1 = (int)a1[1];

            //a1[3] = "yarraaaa";


            //a1.Remove("ibraaam");
            //a1.RemoveRange(2, 2);
            //a1.RemoveAt(3);

            //a1.Reverse();
            //a1.Sort();

            ArrayList a1 = new ArrayList();

            a1.Add("mehmet");
            a1.Add("hasbi");
            a1.Add("kaynak");
            a1.Add("olaf");
            a1.Add("lee");
            a1.Add("pyke");
            a1.Add("aatrox");
            a1.Add("shywana");
            a1.Add("nidalee");
            a1.Add("teemo");

            a1.Sort();
            a1.Reverse();

            bool kontrol1 = a1.Contains("hasbi");//true gelecek
            bool kontrol2 = a1.Contains("yaprak");//false gelecek

            int indexdegeri = a1.IndexOf("hasbi");// indexi ogrenmek icin

            a1.Clear(); // arraylistin icindeki her seyi siler
            a1.TrimToSize();//capasitesini 4 e ceker

            object[] d1 = a1.ToArray();// arraylistesini bir diziye atar . d1 artik a1 icindeki bilgilere sahip.
             


           



        }
    }
}
