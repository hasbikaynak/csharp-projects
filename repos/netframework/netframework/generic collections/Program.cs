using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList listem = new ArrayList();// normalde benim arraylistim "obje degeri aliyordu"
            //eger ben icine obje degeri degilde int veya string degeri atamak istiyorsam yeni bir class
            //icerisinde metodlarimla bunu gerceklestirebiliyordum.
            // listem.Add(1);
            //listem.Add("olaf");
            //yukaridaki kodlarimi yorum satiri haline getiriyorum.
            sanaldatabase db = new sanaldatabase();
            db.yenikayit(1);
            //sanaldatabase isimli classim icerisinde olusturmus oldugum metod sayesinde listeme int 
            // degeri atayabildim.
            //................................................
            //Boyle ugrasmak yerine generic collections kullaniyoruz.
            //.....................................................

            List<int> genericlistem = new List<int>();
            genericlistem.Add(1);
            genericlistem.Add(2);
            for (int i = 0; i < genericlistem.Count; i++)
            {
                Console.WriteLine(genericlistem[i]);
            }
            //genericlistem.Add("olaf"); // goruldugu uzere generic listem bana hata veriyor cunku int 
            //degeri girilmedi.

            List<string> isimler = new List<string>();
            isimler.Add("olaf");
            isimler.Add("kaynak");
            for (int i = 0; i < isimler.Count; i++)
            {
                Console.WriteLine(isimler[i]);

                //genericlistemstring.Add(2);// genericlistem string ile acildigi icin bana string degerinde hata 
                //veriyor
            }

            List<musteri> musteriliste = new List<musteri>();
            musteriliste.Add(new musteri()
            {
                id = 1,
                isim = "olaf",
                soyisim = "kaynak"

            });

            foreach (musteri item in musteriliste)
            {
                Console.WriteLine(item.soyisim);
            }

        }
    }
    public class sanaldatabase
    {
        ArrayList listem = new ArrayList();

        public void yenikayit(int data)
        {
            listem.Add(data);
        }
    }
    public class musteri
    {
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int id { get; set; }
    }
}
