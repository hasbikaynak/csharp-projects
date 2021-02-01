using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LateBindingIslemleri
{
    public class Musteri
    {

        public string MusterIsimGetir(string Isim, string SoyIsim)
        {
            return $"{Isim} {SoyIsim}";
        }
    }
}
