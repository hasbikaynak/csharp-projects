using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_application_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnuret_Click(object sender, EventArgs e)
        {
            int mayin1 = 0;
            int mayin2 = 0;
            int mayin3 = 0;

            Random rnd = new Random();
           mayin1 = rnd.Next(1, 20);
            mayin2 = rnd.Next(21, 40);
            mayin3 = rnd.Next(41, 50);

            for (int i = 1; i <= 50; i++)
            {
                Button b1 = new Button();
                
                b1.Name = "btn"+i.ToString();
                b1.Size = new System.Drawing.Size(33, 23);
                b1.UseVisualStyleBackColor = true;
                b1.Text = i.ToString();
                if (mayin1 == i  || mayin2 == i || mayin3 == i)
                {
                    b1.Tag = true;

                }
                else
                {
                    b1.Tag = false;
                }
                
                b1.Click += B1_Click;

               
                layoutpanel.Controls.Add(b1);

            }

        }

        private void B1_Click(object sender, EventArgs e)
        {
             Button basilanbutton =   ((Button)sender);
            bool mayinbulundumu = (bool)basilanbutton.Tag;
            if (mayinbulundumu)
            {
                MessageBox.Show("Mayini buldunuz");
                basilanbutton.BackColor = Color.Red;
                int skor1 = int.Parse(label4.Text);
                skor1++;
                label4.Text = skor1.ToString();
                if (skor1 == 3)
                {
                    MessageBox.Show("GAME OVER !!!");
                    this.Close();
                    

                }
            }
            else
            {
                basilanbutton.BackColor = Color.Green;
                int skor = int.Parse(label2.Text);
                skor++;
                label2.Text = skor.ToString();
                if (skor == 47)
                {
                    MessageBox.Show("TEBRIKLER");
                     this.Close();
                }
            }
        }
    }
}
// this.btntemp.Location = new System.Drawing.Point(3, 3);
//this.btntemp.Name = "btntemp";
//this.btntemp.Size = new System.Drawing.Size(33, 23);
//this.btntemp.TabIndex = 0;
//this.btntemp.Text = "1";
//this.btntemp.UseVisualStyleBackColor = true;
