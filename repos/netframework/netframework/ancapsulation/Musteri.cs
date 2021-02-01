using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ancapsulation
{
    class Musteri
    {
        public Musteri()
        {
            this.id = iduret();
        }
        private int id;
        public int ID
        {
            get {
                return this.id;
            }
            private set {
                this.id = value;
            }

        }
        public string isim;
        private string soyisim;
        public string _soyisim
        {
            get { return this.soyisim; }
            set { this.soyisim = value;
                this.email =string.Format("{0}.{1}@hotmail.com",isim,soyisim);
            }
}
        private string tckimlikno;
        public string _tckimlikno
        {
            get { return this.tckimlikno.Substring(0,3);//ilk 3 hanesini gostermek icin framework substring metodunu kullandik
            }
            set { 
                if (value.Length==11)// 11 haneli olma zorunlulugu yaptik
                {
                    bool bayrak = false;// bayrak adinda bir kontrol eden bool dongusu actik
                    for (int i = 0; i < value.Length; i++)//value degerinin uzunlugu kadar i dondurduk for ile
                    {
                        bool karakterkontrol = char.IsNumber(value[i]);// char.isnumber ile gelen degerin numara olup olmadigina baktik
                        if (karakterkontrol)//karakterkontrol true degerini alirsa executed;
                        {

                        }
                        else //karakterkontrol false degerini alirsa executed;
                        {
                            bayrak = true;//bayraga false degerini atadik
                            break;//bool bayrak dongusunu durdurduk
                        }
                           
                       
                    }
                    if (bayrak)//bayrak dongusu true aldi ise 
                    {
                        Console.WriteLine("e mail icindeki numaralar sayisal olmalidir");
                    }
                    else// bayrak degeri false aldi ise
                    {
                        this.tckimlikno=value;
                    }
                }
                else
                {
                    Console.WriteLine("email 11 haneli olmalidir");// for disinda ve ilk ifimizin icinde else actik ki sayi 11 haneli degilse uyari verelim
                }

            }
        }


        private string email;
        public string _email {
           get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }

        }
        private int iduret()
        {
            Random rnd = new Random();
             return rnd.Next(1000, 9000);
        }
    }
}
