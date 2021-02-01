using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox_detayli_inceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // comboboxdoldurv1();
            CmbBoxUrunListesi.DataSource = sanaldatabase.uruntablo; 
        }
        void comboboxdoldurv1()
        {
            foreach (var item in sanaldatabase.uruntablo) // sanaldatabaseimizdeki uruntablo icerisindeki degerleri item nesnesi obje
                //oldugu icin item uzerine aliyoruz ve items.add metodu ile comboboxumuza yazdiriyoruz. boylelikle comboboxumuzda 
                //urunlerin namespaceindeki isimleri gozukuyor 
                //simdi urunlistesine gidip override ile ezecegiz ve urunadi gostertecegiz
            {
                CmbBoxUrunListesi.Items.Add(item);
            }
            
        }

        private void CmbBoxUrunListesi_SelectedIndexChanged(object sender, EventArgs e) 
        {
            object o1 =CmbBoxUrunListesi.SelectedItem; // oncelikle comboboxun selected item ile obje uzerine aldik
            Urun u1 = (Urun)o1; // daha sonra onu urun nesnesi olarak aldik 
            //ComboBox secilencombobox = sender as ComboBox; coklu islemlerde kullanilir mesela mayin tarlasinda oldugu gibi
            urunresim.Image = Image.FromFile(u1.urunresim); // ve de burada kullandik
            urunresim.SizeMode = PictureBoxSizeMode.StretchImage;
            TxtUrunAdi.Text = u1.urunadi;
            TxtKategori.Text = u1.kategori;
            TxtStok.Text = u1.stokadet.ToString();
            TxtYazar.Text = u1.yazar;
            RtxtAciklama.Text = u1.aciklama;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GrpBoxUrunListesi_Enter(object sender, EventArgs e)
        {

        }
    }
}
