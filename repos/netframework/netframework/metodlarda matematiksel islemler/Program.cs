using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodlarda_matematiksel_islemler
{
    class Program
    {
        static void Main(string[] args)
        {mytittle:
            Matematik m = new Matematik();
            m.menu();
            int kullanicinsecimi = int.Parse(Console.ReadLine());

            Console.WriteLine("Birinci sayiyi giriniz ");
            decimal kullanicidangelensayi1 =decimal.Parse( Console.ReadLine());

            Console.WriteLine("Ikinci sayiyi giriniz ");
            decimal kullanicidangelensayi2 = decimal.Parse(Console.ReadLine());

            decimal sonuc = 0;
            switch (kullanicinsecimi)
            {
                case 1:
                  sonuc = m.toplamaislemi(kullanicidangelensayi1, kullanicidangelensayi2);
                    m.sonucuekranayazdir(kullanicidangelensayi1, kullanicidangelensayi2, sonuc, "+");
                    break;
                case 2:
                    sonuc = m.cikartmaislemi(kullanicidangelensayi1, kullanicidangelensayi2);
                    m.sonucuekranayazdir(kullanicidangelensayi1, kullanicidangelensayi2, sonuc, "-");
                    break;
                case 3:sonuc = m.bolmeislemi(kullanicidangelensayi1, kullanicidangelensayi2);
                    m.sonucuekranayazdir(kullanicidangelensayi1, kullanicidangelensayi2, sonuc, "/");
                    break;
                case 4:
                    sonuc = m.carpmaislemi(kullanicidangelensayi1, kullanicidangelensayi2);
                    m.sonucuekranayazdir(kullanicidangelensayi1, kullanicidangelensayi2, sonuc, "*");
                    break;

                default:
                    Console.WriteLine("Boyle bir islem bulunmamaktadir");
                    Console.WriteLine("Lutfen yeniden deneyiniz");
                    System.Threading.Thread.Sleep(2000);
                    goto mytittle;
                    
            }
            Console.WriteLine("Baska bir islem yapmak istiyor musunuz ? [E/H]");
            string kullanicibaskaislem = Console.ReadLine();
            if (kullanicibaskaislem.ToUpper() == "E")
            {
                goto mytittle;
            }
        }
    }
}
