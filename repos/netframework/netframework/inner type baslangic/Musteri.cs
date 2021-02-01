using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inner_type_baslangic
{
    public class Musteri
    {
        #region tekil olarak kullanilan fieldlar

        
        public int  musteriID{ get; set; }
        public string tckimliknumarasi { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime olusturulmatarihi { get; set; }
        public int kullaniciID { get; set; }
        #endregion

        #region inner type icin gerekli fieldlar
        public MusteriAdres[] musteriadreslistesi;
        public MusteriIlestisimbilgisi[] musteriiletisimlistesi;
        public MusteriSiparisBilgisi[] musterisiparislistesi;

        #endregion

        public Musteri()
        {
            musteriadreslistesi = new MusteriAdres[5];
            musteriiletisimlistesi = new MusteriIlestisimbilgisi[5];
            musterisiparislistesi = new MusteriSiparisBilgisi[5];
        }
    }
}
