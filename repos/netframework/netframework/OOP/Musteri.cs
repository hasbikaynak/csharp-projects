using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    
    public class Musteri
    {
        public string tckimlik;
        public string isim;
        public string soyisim;
        public string cinsiyet;
        public Musteri()
        {
            tckimlik = "912398";
        }
       
        public bool musterikontrol()
        {
            bool kontrol = musterikontroldatabase(tckimlik);
            return kontrol;
        }
       private bool musterikontroldatabase(string tckimlik)
        {
            return true;
        }
            
        
    }
    
}

