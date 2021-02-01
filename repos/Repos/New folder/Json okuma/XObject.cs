using System;
using System.Collections.Generic;
using System.Text;

namespace Json_okuma
{
    public class XObject
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string TelefoNumarasi { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return Isim +" "+ Soyisim;
        }
    }
}
