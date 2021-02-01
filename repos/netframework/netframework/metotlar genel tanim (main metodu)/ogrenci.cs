using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar_genel_tanim__main_metodu_
{
    public class ogrenci // basina bir public ekledik cunku ancak o zaman main metodundan cagirdigimizda gelir.
    {
        public void ogrenciselamla() // yine public diyoruz ki baska metodlarda da kullanabilelim
        {
            Console.WriteLine(  " meraba televole ogrencisi");
        }

        private void ogrencimetod(string ogrenciismi, string ogrencisoyadi)// private ile sadece ilgili class icerisinde cagirabildigimi gordum.

        {
            
            Console.WriteLine("Ogrencinin adi ve soyadi  : {0} {1}", ogrenciismi , ogrencisoyadi);
        }

        public void ogrencimetod2()
        {
            ogrencimetod("hasan huseyin ","killibacak ");
        }

    }
}
