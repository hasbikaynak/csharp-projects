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
    public partial class onizleme_ekrani : Form
    {
        public onizleme_ekrani()
        {
            InitializeComponent();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms) // application.openforms ile var olan formlarimiza baktik ve foreachle icinde donduk
            {
                if (item.Name == "Form1") //daha sonra formlarin icersinde form1 ismine sahip itemin namesini aldik
                {




                    foreach (Control formitem in item.Controls) // eger o isim form1 ise, form1in controller icinde donduk
                    {


                        if (formitem is TextBox)// daha sonra eger buldugumuz deger textbox ise
                        {
                            ((TextBox)formitem).Text = string.Empty; // bulunan textboxu sil dedik.

                        }
                    }
                }
            }
            this.Close();
        }
    }
}
