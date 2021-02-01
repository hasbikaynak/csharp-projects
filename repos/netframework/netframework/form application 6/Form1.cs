using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_application_6
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

        private void btntemizle_Click(object sender, EventArgs e)
        {
           DialogResult res = MessageBox.Show("Icerideki bilgileri silmek ister misiniz ?","Silme Islemi", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                formtemizle();
                // these are method of  piece of junk. We could also use it instead of formtemizle.
                //txtisim.Text = string.Empty;
                //txtsoyisim.Text = string.Empty;
                //txttelefonnumarasi.Text = string.Empty;
                //txtemailadres.Text = string.Empty;

            }
            else if (res==DialogResult.No)
            {

                


            }

            
            
        }
        private void formtemizle()
        {
            foreach (Control item in this.Controls) // with the method of foreach we could keep turning in controls for items  
            {
                if (item is TextBox) //here we requested from controls to give us just if the item is textbox.
                {
                    TextBox t = (TextBox)item; // if item is textbox then change it`s value from controls to textbox
                    t.Text = string.Empty;//then make it`s inside empty.
                }
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            //let us create a virtual database to save what we have in our list.
            int sum = addclient(new Clients()
            {
                id = Guid.NewGuid(),
                 name = txtisim.Text,
                surname = txtsoyisim.Text,
                 emailadres = txtemailadres.Text,
                  phonenumber = txttelefonnumarasi.Text,

            });

        }
        private int addclient(Clients data)
        {
            Virtual_Database.clients.Add(data);
            return 1;
        }

        private void btnonizlemeekrani_Click(object sender, EventArgs e)
        {
            onizleme_ekrani o1 = new onizleme_ekrani();
            ((TextBox) o1.Controls["txtisim"]).Text = txtisim.Text; // controls icindeki txtisimli texti textbox nesnesi olarak convert
            // ettik ve bunu kullanicidan gelen txtisimli textboxa atadik. Yani ozetle form1 de girilen isim degeri onizleme ekranina 
            //tasindi.
            ((TextBox) o1.Controls["txtsoyisim"]).Text = txtsoyisim.Text; 
            ((TextBox) o1.Controls["txtemail"]).Text = txtemailadres.Text; 
            ((TextBox) o1.Controls["txttelefon"]).Text = txttelefonnumarasi.Text; 
            
            o1.ShowDialog();
        }
    }
}
