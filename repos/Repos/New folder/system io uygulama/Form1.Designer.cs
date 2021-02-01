namespace system_io_uygulama
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpboxmusterilistesi = new System.Windows.Forms.GroupBox();
            this.lstPersonel = new System.Windows.Forms.ListBox();
            this.btnpersonelgetir = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.txtemailadres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtulke = new System.Windows.Forms.TextBox();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfirmaadi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpboxmusterilistesi.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxmusterilistesi
            // 
            this.grpboxmusterilistesi.Controls.Add(this.lstPersonel);
            this.grpboxmusterilistesi.Location = new System.Drawing.Point(13, 13);
            this.grpboxmusterilistesi.Name = "grpboxmusterilistesi";
            this.grpboxmusterilistesi.Size = new System.Drawing.Size(200, 236);
            this.grpboxmusterilistesi.TabIndex = 0;
            this.grpboxmusterilistesi.TabStop = false;
            this.grpboxmusterilistesi.Text = "Musteri Listesi";
            // 
            // lstPersonel
            // 
            this.lstPersonel.FormattingEnabled = true;
            this.lstPersonel.Location = new System.Drawing.Point(7, 20);
            this.lstPersonel.Name = "lstPersonel";
            this.lstPersonel.Size = new System.Drawing.Size(187, 212);
            this.lstPersonel.TabIndex = 0;
            this.lstPersonel.DoubleClick += new System.EventHandler(this.lstPersonel_DoubleClick);
            // 
            // btnpersonelgetir
            // 
            this.btnpersonelgetir.Location = new System.Drawing.Point(15, 250);
            this.btnpersonelgetir.Name = "btnpersonelgetir";
            this.btnpersonelgetir.Size = new System.Drawing.Size(201, 33);
            this.btnpersonelgetir.TabIndex = 1;
            this.btnpersonelgetir.Text = "Personel Getir";
            this.btnpersonelgetir.UseVisualStyleBackColor = true;
            this.btnpersonelgetir.Click += new System.EventHandler(this.btnpersonelgetir_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(15, 289);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(201, 31);
            this.btnkaydet.TabIndex = 1;
            this.btnkaydet.Text = "Personel Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // txtemailadres
            // 
            this.txtemailadres.Location = new System.Drawing.Point(286, 82);
            this.txtemailadres.Name = "txtemailadres";
            this.txtemailadres.Size = new System.Drawing.Size(100, 20);
            this.txtemailadres.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email Adres";
            // 
            // txtulke
            // 
            this.txtulke.Location = new System.Drawing.Point(287, 134);
            this.txtulke.Name = "txtulke";
            this.txtulke.Size = new System.Drawing.Size(100, 20);
            this.txtulke.TabIndex = 9;
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Location = new System.Drawing.Point(286, 56);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(100, 20);
            this.txtsoyisim.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ulke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyisim";
            // 
            // txtfirmaadi
            // 
            this.txtfirmaadi.Location = new System.Drawing.Point(287, 108);
            this.txtfirmaadi.Name = "txtfirmaadi";
            this.txtfirmaadi.Size = new System.Drawing.Size(100, 20);
            this.txtfirmaadi.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Firma Adi";
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(286, 30);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(100, 20);
            this.txtisim.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Isim";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 332);
            this.Controls.Add(this.txtemailadres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtulke);
            this.Controls.Add(this.txtsoyisim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtfirmaadi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnpersonelgetir);
            this.Controls.Add(this.grpboxmusterilistesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System IO uygulamasi";
            this.grpboxmusterilistesi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxmusterilistesi;
        private System.Windows.Forms.ListBox lstPersonel;
        private System.Windows.Forms.Button btnpersonelgetir;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.TextBox txtemailadres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtulke;
        private System.Windows.Forms.TextBox txtsoyisim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfirmaadi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.Label label1;
    }
}

