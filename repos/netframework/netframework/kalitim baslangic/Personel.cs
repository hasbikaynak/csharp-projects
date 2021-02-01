using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitim_baslangic
{
    public class Personel:TemelTip
    {
        public DateTime isbaslangictarihi { get; set; }
        public DateTime isbitistarihi { get; set; }
        public int izingunsayisi { get; set; }

        public Personel()
        {
            Console.WriteLine("personel klasini yazdiralim");
        }

    }
}
