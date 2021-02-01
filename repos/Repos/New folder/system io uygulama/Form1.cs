using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace system_io_uygulama
{
    public partial class Form1 : Form
    {
        sanaldatabase db;
        List<Personel> p1;
        private List<Personel> personelistesi;

        public Form1()
        {
            InitializeComponent();
            db = new sanaldatabase();
        }

        private void btnpersonelgetir_Click(object sender, EventArgs e)
        {
            p1 = db.personelgetir(150);
            lstPersonel.DataSource = p1;
            
        }

        private void lstPersonel_DoubleClick(object sender, EventArgs e)
        {
            Personel secilenpersonel = (Personel)lstPersonel.SelectedItem;
            txtisim.Text = secilenpersonel.isim;
            txtsoyisim.Text = secilenpersonel.soyisim;
            txtemailadres.Text = secilenpersonel.emailadres;
            txtfirmaadi.Text = secilenpersonel.firmaadi;
            txtulke.Text = secilenpersonel.ulke;
            
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            db.personelkaydet("C:\\Udemy",
                              personelistesi);
            
        }
       
    }
}
