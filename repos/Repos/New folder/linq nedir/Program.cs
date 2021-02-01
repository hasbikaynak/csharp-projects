using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_nedir
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSource ds = new DataSource();
            List<Musteri> m1 = ds.musterilist();



            //Linq sorgulama 

           //int toplambulunanmusterisayisi =  m1.Where(I => I.name.StartsWith("A")).Count();
           // //bir I degeri atadim, nereye? Musterilisteminicine yani m1e, sonra I ile A ile baslayan nameleri aradim ve daha 
           // //sonra bunlarin toplam sayisini aldim.

           //var toplambulunanmusteri2 = (from I in m1 where I.name.StartsWith("A") select I).Count();
            // buda linq sorgusunun ikinci metodu

            #region Linq to ile alistirmalar

            //1. musterilistesi icerisindeki (m1) A ile baslayan sehirleri bulalim

            int bulunansehirsayisi = m1.Where(I => I.city.StartsWith("A")).Count();
            Console.WriteLine("A ile baslayan sehir sayisi : "+ bulunansehirsayisi);

            //2. m1 icerisinde namesinde B harfi bulunan ve coutrysinde A harfi gecen degerleri listeleyin.

            var  bulunansehirveisimler  = m1.Where(I => I.name.Contains("b") && I.country.Contains("a")).ToList();
            
            Console.WriteLine(bulunansehirveisimler.Count());

            //3. m1 icerisindeki listeden dogum tarihi 1990dan buyuk olan ve isminin icerisinde a gecen degerler listesini
            //bulunuz. Linq to Query den yap

            var bulunandogumtarihiveisimler = (from I in m1 where I.birthday.Year > 1990 && I.name.Contains("a") select I);
            Console.WriteLine(bulunandogumtarihiveisimler.Count());









            #endregion










            //int bulunandeger = 0;
            //for (int i = 0; i < m1.Count; i++)
            //{
            //    if (m1[i].name[0] == 'A')
            //    {
            //        bulunandeger++;
            //    }
            //}

            //Console.WriteLine(bulunandeger);
            //bulunandeger = 0;

            //bulunandeger = m1.Where(i => i.name.StartsWith("A")).Count(); // yukaridaki metodun aynisinin Linq kullanimi 
            //Console.WriteLine("Liste icinde A ile baslayan degerler toplami :" + bulunandeger );
            Console.ReadKey();
        }
    }
}
