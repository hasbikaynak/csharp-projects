using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groupbox_inceleme_form_application
{
    public partial class popupmesaj : Form
    {
        Musteri musteridata;
        public popupmesaj(Musteri data)
        {
            
            InitializeComponent();
            musteridata = data;
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void popupmesaj_Load(object sender, EventArgs e)
        {
            txtisim.Text = musteridata.isim;
            txtsoyisim.Text = musteridata.soyisim;
            txttamadi.Text = musteridata.tamadi;
            txttelefon.Text = musteridata.telefonnumara;
            txtililce.Text = $"{musteridata.il} / {musteridata.ilce}";
            txtemailadres.Text = musteridata.emailadres;
            rtxtadres.Text = musteridata.adres;
           
        }
    }
}
