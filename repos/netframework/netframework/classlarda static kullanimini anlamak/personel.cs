using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classlarda_static_kullanimini_anlamak
{
    class personel
    {
        public static string domainadres = "geruzukali.com";// static public oldugu icin her yerde kullanilabilir
        public string isim { get; set; }
        public string soyisim { get; set; }
        private string email;
        public string _email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value.ToLower() + "@" + personel.domainadres;
            }
        }
        public int cinsiyet { get; set; }

          
        
            
            

            
        
    }
}
