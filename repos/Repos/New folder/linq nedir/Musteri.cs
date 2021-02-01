using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_nedir
{
    public class Musteri
    {
        public  int id { get; set; }
        public  string name { get; set; }
        public  string surname { get; set; }
        public  string email { get; set; }
        public  string country { get; set; }
        public  string city { get; set; }
        public string district { get; set; } 
        public string phonenumber { get; set; } 
        
        public  DateTime birthday { get; set; }


        public override string ToString()// override kullanimi icin, form app  groupbox veya datagriedviewe bak
        {
            return name;
        }
    }
}
