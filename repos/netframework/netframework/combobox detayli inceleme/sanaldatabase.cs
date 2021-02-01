using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combobox_detayli_inceleme
{
   public static class sanaldatabase
    {
        public static List<Urun> uruntablo = new List<Urun>()
        {
           new Urun(){id= 1, urunadi = "Bir Omur Nasil Yasanir", stokadet = 10 ,  kategori = "roman" ,  aciklama = "işisel gelişim; mesleki ve sosyal anlamda farklı konumlarda yer alan her insanın tabii olarak fikir sahibi olduğu," +
               " ancak bir o kadar da fikre ihtiyaç duyulan bir alan. Bu nedenle söz konusu alanın, modern dünyada geniş bir yer edindiğini söylemek mümkün. Hayatı hakkınca ve nitelikli yaşamaya dair tavsiye alınabilecek kişilere gelindiğinde" +
               " ise Türkiye’de herkesin aklına gelecek isimlerden birini tahmin etmek zor değil." , yazar = "Ilber Ortayli" , urunresim = @"C:\Users\mhasb\Desktop\0001796150001-1.jpg"},
           new Urun(){id= 2 ,urunadi = "Metastas",stokadet = 10, kategori = "roman ", yazar="Baris Pehlivan", aciklama=@"- Menzilci polisler ilk kez göreceğiniz fotoğraflarında ne yapıyordu?
- AKP'li Bakan'ın tarikat şeyhinden özel ricası neydi?
- Devlette FETÖ'den boşalan koltuklara hangi tarikat nasıl yerleşti?
- Nedir bu hüsn-ü şehadet ve FETÖ borsası?
- Hangi cemaat kim için Cumhurbaşkanı'na mektup yazarak kefil oldu?
- Genelkurmay Başkanı'nın sahip çıkın dediği isimler neden tutuklandı?
- Kurda kuşa yem etmeyin denilen işadamı nasıl hapisten çıktı?", urunresim=@"C:\Users\mhasb\Desktop\412nyaG6BGL._SX296_BO1,204,203,200_.jpg",  },
           new Urun(){ id = 3, urunadi = "seker portakali ",stokadet = 10, kategori = "roman ",aciklama= @"Acı dolu bir hayat sürdürmek ve bunu yaşamın olağan seyri gibi kabul etmek, ta ki hayattaki en gerçek
ve karşı konulamaz acının ne olduğunu öğrenene kadar… Şeker Portakalı; yoksulluk ve sevgisizlik içinde 
yaşayan küçük Zeze’nin dünyasını, okuyucusuna yalnızca minik bir çocuğun gözünden değil, evrensel bir hakikat penceresinden sunuyor. " , urunresim = @"C:\Users\mhasb\Desktop\0000000064031-1.jpg",yazar = " Jose Mauro De Vasconcelos"},
           
           
           

        };
    }
}
