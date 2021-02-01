using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groupbox_inceleme_form_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { // fakedata manage packagedan install et ve projene ekle , referenceesa gelir.
          //fakedata. yazdiginda classlar gelicektir
          //string isim = FakeData.NameData.GetFirstName();
          //string soyisim = FakeData.NameData.GetSurname();
          //MessageBox.Show(isim + "" + soyisim, "Bilgilendirme", MessageBoxButtons.OK);


            sanaldatabase db = new sanaldatabase();//sanaldatabaseimi formum icinde tanimladim
             List<Musteri> musteriLISTELE = db.musterilistele(); //databasimdeki bilgileri liste<musteri> haline
            //cevirdim
            dgwmusteriliste.DataSource = musteriLISTELE;
            dgwmusteriliste.Columns["id"].Visible = true; //dgwmusterilistemizin id kismini visible yaptik
            dgwmusteriliste.Columns[0].HeaderText = "Musteri ID"; // 0. indexinin basligini degistirdik.

            // dgwmusteriliste.DataSource = musteriLISTELE; // ve datagriewlistimin datasourcena bu listeyi atadim. 


//            var dgwliste = from I in musteriLISTELE
//                           select new// isimsiz bir datagriewlistesi olusturdum
////ve bu listenin icine columlarda goruntulemek istedigim fieldlari aliyorum, geri kalanlar gosterilmiycek.

//            {
//                isim = I.isim,
//             soyisim = I.soyisim,
//            tamadi = I.tamadi,

//            };
//            dgwmusteriliste.DataSource = dgwliste.ToList(); // isimsiz olusturdugum datagriewlistesini
//            //goruntuleme icin 

        }

        private void dgwmusteriliste_DoubleClick(object sender, EventArgs e)
        {
           int musteriID=(int)dgwmusteriliste[0,dgwmusteriliste.CurrentCell.RowIndex].Value; // cift tiklanan satirin id 
            //numarasini bize verir.
            MessageBox.Show(musteriID.ToString());  //show metodu ile messageboxumuzda musteri id imizi gosterdik.
            sanaldatabase db = new sanaldatabase();
            Musteri bulunanmusteri = db.musterilistele().FindAll(i => i.id == musteriID).FirstOrDefault();
            popupmesaj popupmesaj = new popupmesaj(bulunanmusteri);
            popupmesaj.Show();  
            

        }
    }
}
