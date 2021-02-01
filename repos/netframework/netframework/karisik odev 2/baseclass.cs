using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karisik_odev_2
{
    public class baseclass
    {
       public static int sayac = 1;
        public baseclass()
        {
            _id = sayac;
            sayac = sayac + 1; 
        }
        private int _id;
        public int id
        {
            get { return _id; }
            private set
            {//bir sayac icindeki degerden yararlanmak istiyoruz ancak private olarak set edildi
                //gi icin sayac degeri disardan giremeyecektir.
                //sayac = _id;
                //sayac = sayac + 1;
            }
        }
        private string _barkod;
        public string barkod { get { return _barkod; }
            set
            {
                bool kontrolislemi = sanaldata.dbbarkodkontrol(value);
                if (!kontrolislemi) // eger deger sanaldatabase de bulunamadiysa
                {
                    _barkod = value;
                }
                else
                {
                    Console.WriteLine("sanal database icerisinde bu deger bulunmaktadir");
                }

            } } // girilen barkod sistemde varsa eklemesin, yoksa eklesin
        public DateTime olusturmatarih { get; set; }
        public int olusturulankullanici { get; set; }
        public DateTime guncellemetarih { get; set; }
        public int guncelleyenkullanici { get; set; }
        public bool silindi { get; set; }
    }
}
