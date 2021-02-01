using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace network2
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba arabatanimi1 = new Araba();
            arabatanimi1.marka = "Opel";
            arabatanimi1.model = "Corsa";
            arabatanimi1.renk = "Kirmizi";

            Araba arabatanimi2 = arabatanimi1;
            arabatanimi2.marka = "peguot";
            arabatanimi1.renk = "pembe";
        }

    }
    class Araba
    {
        public string marka;
        public string model;
        public string renk;

    }
}

