using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_ve_override_metodlari
{
   public  class baseClass
    {
        public virtual void ekranayaz(string data)// virtual ile metodumuzu sanal bi hale getirdik
        {
            Console.WriteLine(data);
        }

    }
}
