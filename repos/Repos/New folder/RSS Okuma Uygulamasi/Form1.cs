using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RSS_Okuma_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // List<Haber> Kayitlar =  HaberGetir();
            //lst_baslik.DataSource = Kayitlar;
            lst_baslik.DataSource = HaberGetir();

        }
        private List<Haber> HaberGetir()
        {
            List<Haber> haberkayitlari = new List<Haber>(); // haber listesi generic listli bir haberkayitlari degeri olustrdum

            XDocument xmlkaynak = XDocument.Load(txturl.Text);  //textimin icinde hali hazirda olan url mi xdocument bicimindeki xmlkaynak uzerine aldim
            List<XElement> rows = xmlkaynak.Descendants("item").ToList(); //xmlim icindeki item isimli degerleri listeleyecegimi soyledim ve rows uzerine aldim
            foreach (XElement item in rows)// her bir elementi getiriyorum
            {
                Haber temp = new Haber(); //her eement yeni bir haber tipli temp olacak diyorum
                temp.Baslik = item.Element("title").Value; 
                temp.Link = item.Element("link").Value;
                temp.Aciklama = item.Element("description").Value;
                haberkayitlari.Add(temp); // haberkayitlarima tempi basiyorum
            }
            return haberkayitlari; 
        }

        private void lst_baslik_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox secilendeger = (ListBox)sender;
            Haber secilenhaber = (Haber)secilendeger.SelectedItem;
            wbrowser1.DocumentText = secilenhaber.Aciklama;
 
        }
    }
}
