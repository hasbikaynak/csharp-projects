using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace system_io_uygulama
{
    public partial class PersonelDetaylari : Form
    {
        Personel personeldata;
        public PersonelDetaylari(Personel data)
        {
            InitializeComponent();
            personeldata = data; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PersonelDetaylari_Load(object sender, EventArgs e)
        {
            txtisim.Text = personeldata.isim;
            txtsoyisim.Text = personeldata.soyisim;
            txtfirmaadi.Text = personeldata.firmaadi;
            txtulke.Text = personeldata.ulke;
            txtemailadres.Text = personeldata.emailadres;
            
            
            
        }
    }
}
