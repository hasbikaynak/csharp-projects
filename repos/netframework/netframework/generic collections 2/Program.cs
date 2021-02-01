using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_collections_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<int> sayilarim = new List<int>();
            sayilarim.Add(1);
            int[] ekleneceksayilarim = new int[5];
            ekleneceksayilarim[0] = 2;
            ekleneceksayilarim[1] = 3;
            ekleneceksayilarim[2] = 4;
            ekleneceksayilarim[3] = 5;
            //for (int i = 0; i < ekleneceksayilarim.Length; i++)// foreach ile sayilarim isimli generic
            //    //classima eklenecek sayilar isimli int arrayini ekleyebildim
            //{
                
            //    sayilarim.Add(ekleneceksayilarim[i]);
            //}
            sayilarim.AddRange(ekleneceksayilarim);//aslinda yukardaki foreach metodunun addrange metodu
            //ile direk yapabilirdik. 
            //*************************************************************************************

            int capacity = sayilarim.Capacity; // capacity ile sayilarim generik listemin aslinda 8 capacityli
            //bir liste olmus oldugunu gorduk
            int count = sayilarim.Count;// count ise listemin icerisndeki elemanlari saydi

           sayilarim.TrimExcess();// trim ile sayilarim isimli listemin count ve capacity sayisini count sayisi
            //kadar esitledik (6)

            sayilarim.ForEach(i => Console.WriteLine(i)); // foreach metodunun kisa yazimi ****** burasi onemli
            //sayilarim generic listesi icin bir foreach metodu actik, i degeri arama yap demek. Yani liste icerisinde
            //deger var mi varsa cw ile i degerini yazdir ve bunu liste icerisindeki butun degerler icin yap.
            //*******************************************************************************************
            int bulunandeger = sayilarim[3];
            Console.WriteLine("sayilarim isimli  generic listesinin  3. indexli elemani {0}: ", bulunandeger);

            sayilarim.Insert(3, 100);// yukaridaki 3. degeri bulma islemi ve sonrasinda belkide onu degistirme 
            //metodunun kisaltilmisi insert(int,insert) ile yapilir

            bool kontrol1 = sayilarim.Any();// any metodu ile sayilarim isimli generic listemde hic deger var mi
            //yok mu aramasi yaptiriyoruz, eger varsa true, yoksa false donecek
            bool kontrol2 = sayilarim.Any(i => i > 5); // bool ile bir true veya  false degeri alacagiz, any metodu
            // burada i => ile sayilarim generic listesinin icine girip arama yapiyor oyleki eger bir deger 5 ten 
            //buyukse true olarak don => kontrol1 e , eger yoksa false gelsin

            int enyuksekdeger = sayilarim.Max();
            int endusukdeger = sayilarim.Min();
            int toplamdeger = sayilarim.Sum();

            sayilarim.Sort();//icerisindeki degerleri A dan Z ye siralar veya buyukten kucuge
            sayilarim.Reverse();//icerisindeki degerileri Z den A  ya siralar veya kucukten buyuge
            sayilarim.Remove(100); // listem  icersindeki 100 degerini siler
            sayilarim.RemoveAll(i => i > 3);//listem icerisindeki 3 ten buyuk degerleri silmeye yarar
            sayilarim.RemoveAt(2);//sayilarim icerisindeki 2. indexli degeri siler
            sayilarim.Clear();// icerisindeki butun degerleri siler 
        }
    }
}
