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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // form1 in yapici metodudur eger  designa baslamadan
            //once bir sey degistireceksem initializecomponent altinda islem yapabilirim.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txtmesajdegeri = txtmesaj.Text; // txtmesaj boxumuza gelen texti .text ile aldik ve string oldugu icin txtmesajdegeri
            // string degeri ile yakaladik 
            merabatelevoleformu merabaform = new merabatelevoleformu(txtmesajdegeri); // yakalanan txtmesajdegerini ikinci formumuza aktarmis olduk
            // merabatelevoleformu 
            //aslinda bir class ayni musteri klasi yaptigimiz gibi bu yuzden  klasimizi
            // main metodumuzda tanimladik 
            merabaform.Show(); // show metodu ile t1 ismine atadigimiz merabatelevole klasimizi
            //cagirdik.
        }

        private void txtmesaj_Enter(object sender, EventArgs e)
        {
            TextBox t1 = (TextBox)sender; // sender onjesini ilk once textboxumuzdaki degerlere atiyoruz  
            t1.Text = string.Empty; // yakalanan veriler  string.empty metodu ile temizlenir
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
