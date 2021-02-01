using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_out_kullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            topla(10, 20, 30, 40, 50, 60, 70, 80, 90, 100);
        }
        static void topla(params int[] sayilar)
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            Console.WriteLine("toplam: { 0}", toplam);
        }
    }
}
