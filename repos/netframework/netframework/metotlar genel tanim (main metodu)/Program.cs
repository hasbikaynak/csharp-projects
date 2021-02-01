using System; // bu bir kutuphanenin dosyasidir.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar_genel_tanim__main_metodu_
{
    class Program
    {
        static void Main(string[] args)
        {
            // eger yukaridaki listeden using system kaldirilsaydi. static void main icerisinde yazacagim
            //Console.WriteLine(); gibi komutlari visual studio tanimayacakti. 
            // uzun yazimi 
            //System.Console.WriteLine();
            //selamla();
            //ogrenci o1 = new ogrenci();// yeni bir nesne olusturduk (ogrenci klasimiz ile)
            //o1.ogrenciselamla();
            //o1.ogrencimetod("hasbi", "kaynak");
            
        }

        static void selamla()//  kendim bir kutuphane actim ve kod ameleliginden kurtuldum. artik asagida 
            // yazacagim kodlar ile baska classlar icinde metodumu cagirabilirim.
        { 
            Console.WriteLine("Meraba televole");
            Console.ReadKey();
               
        }
    }
}
