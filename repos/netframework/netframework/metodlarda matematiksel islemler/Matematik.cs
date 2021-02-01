using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodlarda_matematiksel_islemler
{
    public class Matematik
    {
        public decimal toplamaislemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 + sayi2;
            return sonuc;
        }
        public decimal cikartmaislemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 - sayi2;
            return sonuc;
        }

        public decimal bolmeislemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 / sayi2;
            return sonuc;
        }

        public decimal carpmaislemi(decimal sayi1 , decimal sayi2)
        {
            decimal sonuc = sayi1 * sayi2;
            return sonuc;

            
        }
        public void menu()
        {
            Console.Clear();
            Console.WriteLine("*****Menu****");
            Console.WriteLine("1-Toplama islemi");
            Console.WriteLine("2-Cikarma islemi");
            Console.WriteLine("3-Bolme islemi");
            Console.WriteLine("4-Carpma islemi");
            Console.Write("Lutfen bir islem seciniz : ");
        }

        public void sonucuekranayazdir(decimal kullanicisayi1, decimal kullanicisayi2, decimal sonuc, string operatorum)
        {
            Console.WriteLine("{0} {1} {2} = {3}", kullanicisayi1, operatorum, kullanicisayi2, sonuc);
        }
    }   



}
