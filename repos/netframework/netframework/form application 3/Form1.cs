using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_application_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmesaj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kullaniciya gostermek istedigimiz mesaj burada ", "Baslik bilgisi burada ", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            //burada show metodu ile kullaniciya bir panel yardimi ile mesaj gonderdik, baslik , ok tusu ve resim ekledik

        }

        private void btnsorusor_Click(object sender, EventArgs e)
        {
           DialogResult res=  MessageBox.Show("Kullaniciya sormak istedigimiz soru burada belirecek", "Baslik bilgisi burada olacak",
               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {

            }
            else if (res == DialogResult.No)
            {

            }
            else if (res == DialogResult.Cancel)
            { 

            }
        }
    }
}
