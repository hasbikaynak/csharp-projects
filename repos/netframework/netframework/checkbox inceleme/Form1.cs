using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkbox_inceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            checkedboxlistdoldurV1();

        }

        private void checkedboxlistdoldurV1()
        {
            foreach (var item in sanaldatabase.uruntablo)
            {
                chklistbox.Items.Add(item);
            }
        }

        private void chklistbox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkedlistbox = (CheckedListBox)sender;
            if (e.NewValue == CheckState.Checked)
            {
                urun secilenurun = checkedlistbox.Items[e.Index] as urun;
                pboxurunresim.Image = Image.FromFile(secilenurun.urunresim);
                TxtUrunAdi.Text = secilenurun.urunadi;
                TxtStok.Text = secilenurun.stokadet.ToString();
                TxtKategori.Text = secilenurun.kategori;
                TxtYazar.Text = secilenurun.yazar;
                RtxtAciklama.Text = secilenurun.aciklama;
                
            }
            for (int i = 0; i < chklistbox.Items.Count; i++) 
            {
                if (i == e.Index)
                {
                    // burada zaten uzerinde oldugumuz kayit. 
                }
                else
                {
                    chklistbox.SetItemChecked(i, false); // cikan tik sadece secili olan urun 
                    //icin calisir 
                }
            }

        }
    }
}
