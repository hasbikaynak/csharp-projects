using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karisik_odev_2
{
   public class urun:baseclass
    {
        public string marka { get; set; }//* belirtmis oldugumuz markalar icerisinde urunler eklenebilsin
        public string model { get; set; }
        private decimal _alisfiyat;
    
        public decimal alisfiyat { 
            get 
            {
                return this._alisfiyat;
            }
            
            set {
                if (value<=0)
                {
                    Console.WriteLine("alis fiyati 0 dan kucuk olamaz!");
                    
                }
                else
                {
                    Console.WriteLine("fiyat basarili bir sekilde sisteme kaydedilmistir!");
                    this._alisfiyat = value;

                }

            } }//* 0 dan kucuk olamaz 
        private decimal _satisfiyat;
        public decimal satisfiyat { get 
            {
                return _satisfiyat;
            }
            set
            {
                if (value<_alisfiyat)
                {
                    Console.WriteLine("satis fiyati alis fiyatindan kucuk olamaz");
                }
                else
                {

                    Console.WriteLine("degeriniz basarili bir sekilde sisteme kaydedilmistir!");
                    this._satisfiyat = value;
                }
            } } //* alisfiyaitindan kucuk olamaz
        private decimal _kampanyafiyat;
        public decimal kampanyafiyat
        {
            get { return _kampanyafiyat; }
            set
            {
                if (value<=0)
                {
                    Console.WriteLine("kampanya fiyati 0 dan kucuk olamaz!");
                }
                else
                {
                    Console.WriteLine("degeriniz basarili bir sekilde sisteme kaydedilmistir");
                    this._kampanyafiyat = value;
                }
            } }//* kampanya fiyat degeri sifirdan kucuk olamaz.
    }
}
