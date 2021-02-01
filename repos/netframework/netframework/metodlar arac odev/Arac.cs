using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodlar_arac_odev
{
    public class Arac
    {//listemizi olusturalim
        public string marka;
        public string model;
        public string yakittipi;
        public int modelyil;
        public int km;
        
        public int vitestipi;
        public int alisfiyat;
        public int satisfiyat;
        public int maxindirimtutar;
        public decimal fiyat;

        public Arac()
        {
        }

        public Arac(string marka1 , string model1)
        {
            marka1 = marka;
            model1 = model;
        }
        public Arac(string marka1, string model1, int modelyil1 )
        {
            marka1 = marka;
            model1 = model;
            modelyil1 = modelyil;
        }
        public Arac(string marka1, string model1, int modelyil1, int km1)
        {
            marka1 = marka;
            model1 = model;
            modelyil1 = modelyil;
            km1 = km; 
        }

        public void ekrandagoster(string marka1, string model1, string yakittipi1, int modelyil1, int km1, int vitestipi1, int alisfiyat1, int satisfiyat1, int maxindirimtutar1, decimal fiyat1)
        {
            Console.WriteLine("Aracinizin markasi : {0} , modeli {1} , yakittipi {2} , model yili {3} , kmsi {4}, vitestipi {5} , alisfiyati {6}, satis fiyati {7} , max indirim tutari  {8} , fiyati {9} ", marka1, model1, yakittipi1, modelyil1, km1,  vitestipi1, alisfiyat1, satisfiyat1, maxindirimtutar1, fiyat1);
        }
        //fiyat atama icin uygulamamizi yapalim
        public void fiyatatama(decimal _fiyat)
        {
            decimal fiyatatamaicin = satisfiyat - maxindirimtutar;
            if (_fiyat < fiyatatamaicin)
            {
                Console.WriteLine("salak geruzukali maaal");
            }
            else
            {
                this.fiyat = _fiyat;
                Console.WriteLine(fiyat);
            }
        }
    }

}
