using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_applicationa_giris
{
    public partial class merabatelevoleformu : Form
    {
        public merabatelevoleformu(string metin )
        {
            InitializeComponent();
            label1.Text = metin;
        }

        private void merabatelevoleformu_Load(object sender, EventArgs e)
        {

        }

       
    }
}
