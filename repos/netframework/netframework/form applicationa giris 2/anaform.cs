using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_applicationa_giris_2
{
    public partial class anaform : Form
    {
        public anaform(kullanici bulunankullanici)
        {
            InitializeComponent();
            txtisim.Text = bulunankullanici.isim;
           txtaciklama.Text = bulunankullanici.aciklama;
            txtkullaniciadi.Text = bulunankullanici.kullaniciadi;
            txtkullaniciadi.Enabled = false; // allows us to fix(stabilise) the usarname  value. Thus it can not be changed.
            txtsifre.Text = bulunankullanici.sifre;
            txtsoyisim.Text = bulunankullanici.soyisim;
            btnguncelle.Tag = bulunankullanici.id;

           
        }

        private void anaform_Load(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            //Button btnyakalaveguncelle = (Button)sender;
            int id = (int)btnguncelle.Tag;
            int index = sanaldatabase.kullanicitablo.FindIndex(i => i.id == id);
            sanaldatabase.kullanicitablo[index].isim = txtisim.Text;
            sanaldatabase.kullanicitablo[index].soyisim = txtsoyisim.Text;
            sanaldatabase.kullanicitablo[index].sifre = txtsifre.Text;
            sanaldatabase.kullanicitablo[index].aciklama = txtaciklama.Text;
    
          

        }
    }
}
