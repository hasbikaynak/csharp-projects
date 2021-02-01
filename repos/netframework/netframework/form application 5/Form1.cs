using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_application_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngoster_Click(object sender, EventArgs e)
        {
            MusteriKayit m1 = new MusteriKayit();
            m1.Show();
            // method of Show() helps us to bring what we want to show to the users , users can go back to the main or can make 
            //different tasks while methhod of shows working
        }

        private void btngosterpopup_Click(object sender, EventArgs e)
        {
            MusteriKayit m1 = new MusteriKayit();
            m1.ShowDialog(); // method of showdialog helps us to show users what we want to show them however users can not do 
            //any other task rather then what is inside of showdialog. First must be done this task, than you can go to another task.  
        }
    }
}
