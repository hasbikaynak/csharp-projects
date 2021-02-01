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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txtkullaniciadi.Text;
            string sifre = txtsifre.Text;

           kullanici bulunankullanici =  sanaldatabase.kullanicitablo.Find(i => i.kullaniciadi == kullaniciadi && i.sifre == sifre);
            //kullaniciadi == "Admin" && sifre == "123456"
            if (bulunankullanici != null )
            {
                anaform a1 = new anaform(bulunankullanici);
               a1.Show();
            }
            else
            {
                MessageBox.Show("Hatali kullanici bilgileri ","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);  // this allows us to create
                // error box details such as icon and caption.
            }
        }

        private void txtkullaniciadi_Enter(object sender, EventArgs e)
        {
            TextBox t1 = (TextBox)sender;
            t1.BackColor = Color.Yellow;
        }

        private void txtkullaniciadi_Leave(object sender, EventArgs e)
        {
            TextBox t1 = (TextBox)sender;
            t1.BackColor = Color.White;
        }

        private void txtsifre_Enter(object sender, EventArgs e)
        {
            TextBox t1 = (TextBox)sender;
            t1.BackColor = Color.Yellow;
        }

        private void txtsifre_Leave(object sender, EventArgs e)
        {
            TextBox t1 = (TextBox)sender;
            t1.BackColor = Color.White;
        }
    }
}
