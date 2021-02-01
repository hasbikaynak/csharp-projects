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
    public partial class urunsecimkullanici : Form
    {
        urun[] liste; 
            public urunsecimkullanici(urun [] secilenurunler )
        {
            InitializeComponent();
            liste = secilenurunler;
        }

        private void urunsecimkullanici_Load(object sender, EventArgs e)
        {
            foreach (var item in liste)
            {
                Button btn = new Button();
                btn.Text = item.urunadi;
                btn.Name = "btn" + item.id.ToString();
                btn.Size = new System.Drawing.Size(122, 37);
                btn.Tag = item;
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }
            
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            urun u1 = btn.Tag as urun;
           Form1 f1 = (Form1)Application.OpenForms["Form1"];
           GroupBox f1gbox= (GroupBox)f1.Controls["GrpBoxUrunListesi"];
            ((PictureBox)f1gbox.Controls["pboxurunresim"]).Image = Image.FromFile(u1.urunresim);
            ((TextBox)f1gbox.Controls["TxtUrunAdi"]).Text = u1.urunadi;
            ((TextBox)f1gbox.Controls["TxtKategori"]).Text = u1.kategori;
            ((TextBox)f1gbox.Controls["TxtStok"]).Text = u1.stokadet.ToString();
            ((TextBox)f1gbox.Controls["TxtYazar"]).Text = u1.yazar;
            ((RichTextBox)f1gbox.Controls["RtxtAciklama"]).Text = u1.aciklama;
            this.Close();


        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
