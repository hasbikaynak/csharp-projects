using System;

namespace UdemyLib
{
    public class Musteri
    {
        public Guid ID { get; set; }
        public int CariNumarasi { get; set; }
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public string EmailAdres { get; set; }

        public Musteri()
        {

        }

        public Musteri(Guid ID, int CariNumarasi)
        {
            this.ID = ID;
            this.CariNumarasi = CariNumarasi;
        }

        public Musteri(Guid ID, int CariNumarasi,string Isim,string SoyIsim)
        {
            this.ID = ID;
            this.CariNumarasi = CariNumarasi;
            this.Isim = Isim;
            this.SoyIsim = SoyIsim;

        }

        public void ekranayaz()
        {
            Console.WriteLine($"ID : {ID.ToString()} - Cari Numarasi {CariNumarasi.ToString()} " +
                $"Isim Soyisim : {Isim} {SoyIsim}");
        }

        public void carinoguncelle(int yenicarinumarasi)
        {
            this.CariNumarasi = yenicarinumarasi;
        }
    }
}
