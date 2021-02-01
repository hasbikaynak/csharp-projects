using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflectionWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_getir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_object.Text))
            {
                txt_object.BackColor = Color.White;
                Type T = Type.GetType(txt_object.Text);
                if (T != null)
                {
                    ctors(T);
                    props(T);
                    methods(T);
                }
                else
                {
                    MessageBox.Show($"{txt_object.Text} Aramis oldugunuz sinif bulunamadi ",
                    "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lutfen bilgi almak istediginiz sinifin tam adini giriniz",
                    "Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txt_object.BackColor = Color.Yellow;
            }

            
        }

        private void methods(Type T)
        {
           MethodInfo[] RV =  T.GetMethods();
            foreach (var item in RV)
            {
                lst_methods.Items.Clear();
                lst_methods.Items.Add($"{item.ReturnType.Name} {item.Name}");
            }
        }

        private void props(Type T)
        {
           PropertyInfo[] RV= T.GetProperties();
            foreach (var item in RV)
            {
                lst_props.Items.Clear();
                lst_props.Items.Add(item.Name);
            }
        }

        private void ctors(Type T)
        {
            ConstructorInfo[] RV = T.GetConstructors();
            foreach (var item in RV)
            {
                lst_ctors.Items.Clear();
                lst_ctors.Items.Add(item.ToString());
            }
        }
    }
}
