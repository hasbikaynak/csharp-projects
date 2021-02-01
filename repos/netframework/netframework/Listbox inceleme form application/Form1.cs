using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listbox_inceleme_form_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //doldurV1();
            doldurV2();
        }

        private void doldurV2()
        {
            lsturunler.DisplayMember = "urunadi"; // urun klasimizda override ile urunadi yazdirma yaptigimiz yerin , baska bir yapilma 
            //yontemi
            lsturunler.DataSource = sanaldatabase.uruntablo; // varolan tablomuzu listboxa aktarma islemi yontem 2

            
        }

        void doldurV1()
        {
            foreach (var item in sanaldatabase.uruntablo) // varolan tablomuzu listboxa aktarma islemi yontem 1
            {
                lsturunler.Items.Add(item);
            }
            
        }

        private void lsturunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int urunsecimadet = lsturunler.SelectedItems.Count;
            if (urunsecimadet == 1)
            {




                ListBox lbox = (ListBox)sender;
                urun u1 = (urun)lbox.SelectedItem;
                pboxurunresim.Image = Image.FromFile(u1.urunresim);
                pboxurunresim.SizeMode = PictureBoxSizeMode.StretchImage;
                TxtUrunAdi.Text = u1.urunadi;
                TxtKategori.Text = u1.kategori;
                TxtStok.Text = u1.stokadet.ToString();
                TxtYazar.Text = u1.yazar;
                RtxtAciklama.Text = u1.aciklama;
            }
            else if (urunsecimadet > 1)
            {
                List<urun> secilenurunliste = new List<urun>();
                foreach (var item in lsturunler.SelectedItems)
                {
                    secilenurunliste.Add(item as urun);
                }
                urunsecimkullanici secimkullanici = new urunsecimkullanici(secilenurunliste.ToArray());
                secimkullanici.ShowDialog();
            }
            else
            {
                MessageBox.Show("lutfen detayini gormek istediginiz urunu seciniz ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        
	

       
    }

}
