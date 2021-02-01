using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitim_baslangic
{
    public class TemelTip // temel tip icine yazacagimiz her sey diger klaslarda da olacagi icin bir sey yapacaksak burdan yapmak daha mantikli olurdu
    {
        public int id { get; set; }
        public string referanskod { get; set; }
        public int tckimliknumarasi { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int cinsiyet  { get; set; }
        public DateTime kayittarihi { get; set; }
        public int kayitkullanici { get; set; }
        public DateTime guncellemetarihi { get; set; }
        public int guncellemekullanici { get; set; }
        public bool silindi  { get; set; }

        public TemelTip()
        {
            Console.WriteLine("temel tip klasini yazdiralim");
        }
        private void idicinrandomdegeratayalim() // random id atamak icin random next metodunu kullandik however metod private oldugu icin sadece temel tip klasi icerisinde kullanilabilir.
        {
            Random rnd = new Random();
            this.id=rnd.Next(1000,9000);
        }

        public void temeltipmetod1() // public sayesinde artik bu metodu diger klaslarda da kullanabilirim.
        {
            Console.WriteLine("temelmetod1  calisti ");
        }
        protected void metod2() //protected klas icinde private gibi davranir yani kullanilabilir . kendisine bagli olan nesnelere publictir. ancak main
            //icine cagirdigimizda privatedir yani cagirilamaz.
        {
            Console.WriteLine("metod2");
        }
        
    }
}
