using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitim_baslangic
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel p1 = new Personel();
            Egitmen e1 = new Egitmen();
            Ogrenci o1 = new Ogrenci();
            e1.temeltipmetod1(); // temeltipmetod1 egitmen klasinda tanimlanmis olmasa bile 
            //e1. yazdigimda metodu cagirabildim. 

            //boxing-unboxing 
            object b1 = e1; //boxing
            e1 = (Egitmen)b1; // unboxing 

            TemelTip t2;

            t2 = e1;
            e1 = (Egitmen)t2;

            t2 = p1;
            p1 = (Personel)t2;

            t2 = o1;
            o1 = (Ogrenci)t2;

            // object o2 = t2;  // object butun nesnelerin temeli oldugu icin butun nesnelerin kalitimini barindirabilir. 


            
        }
    }
}
