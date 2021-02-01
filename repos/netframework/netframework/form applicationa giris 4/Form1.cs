using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_applicationa_giris_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnmusteriekle_Click(object sender, EventArgs e)
        {
            int islemsonuc = yenimusteriekle (new Musteri()
            {
                id = Guid.NewGuid(),
                 isim = txtisim.Text,
                  soyisim = txtsoyisim.Text,
                   email = txtemail.Text,
                    telefon = txttelefon.Text,
            }
                );
            if (islemsonuc > 0)
            {
              DialogResult res =  MessageBox.Show("Kayit islemi basarili, baska islem yapmak istiyor musunuz ? ", "Kayit islemi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res== DialogResult.Yes)
                {
                    bildirimcubugu = new NotifyIcon();
                    bildirimcubugu.Visible = true;
                    bildirimcubugu.BalloonTipText = "Toplam musteri adedi " + sanaldatabase.musteriler.Count.ToString();
                    bildirimcubugu.BalloonTipTitle = "Musteri adet bilgisi";
                    bildirimcubugu.Icon = SystemIcons.Information;
                    bildirimcubugu.ShowBalloonTip(2000);

                }
                else if (res==DialogResult.No)
                {

                }
                ekrantemizle();
                musterilistele();
            }

        }

        private void musterilistele()
        {
            lstmusteriler.DataSource = sanaldatabase.musteriler;
        }

        private void ekrantemizle()
        {
            txtisim.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtsoyisim.Text = string.Empty;
            txttelefon.Text = string.Empty;
            
        }
        private int yenimusteriekle(Musteri data)
        {
            sanaldatabase.musteriler.Add(data);
            return 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
