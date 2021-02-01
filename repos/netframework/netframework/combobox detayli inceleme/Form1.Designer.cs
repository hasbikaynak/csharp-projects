namespace combobox_detayli_inceleme
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
            this.CmbBoxUrunListesi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUrunAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GrpBoxUrunListesi = new System.Windows.Forms.GroupBox();
            this.urunresim = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtKategori = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtStok = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtYazar = new System.Windows.Forms.TextBox();
            this.RtxtAciklama = new System.Windows.Forms.RichTextBox();
            this.GrpBoxUrunListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunresim)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbBoxUrunListesi
            // 
            this.CmbBoxUrunListesi.FormattingEnabled = true;
            this.CmbBoxUrunListesi.Location = new System.Drawing.Point(95, 9);
            this.CmbBoxUrunListesi.Name = "CmbBoxUrunListesi";
            this.CmbBoxUrunListesi.Size = new System.Drawing.Size(353, 21);
            this.CmbBoxUrunListesi.TabIndex = 0;
            this.CmbBoxUrunListesi.SelectedIndexChanged += new System.EventHandler(this.CmbBoxUrunListesi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Urun Listesi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtUrunAdi
            // 
            this.TxtUrunAdi.Location = new System.Drawing.Point(327, 19);
            this.TxtUrunAdi.Name = "TxtUrunAdi";
            this.TxtUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.TxtUrunAdi.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Urun Adi";
            // 
            // GrpBoxUrunListesi
            // 
            this.GrpBoxUrunListesi.Controls.Add(this.RtxtAciklama);
            this.GrpBoxUrunListesi.Controls.Add(this.urunresim);
            this.GrpBoxUrunListesi.Controls.Add(this.TxtYazar);
            this.GrpBoxUrunListesi.Controls.Add(this.label5);
            this.GrpBoxUrunListesi.Controls.Add(this.TxtStok);
            this.GrpBoxUrunListesi.Controls.Add(this.label4);
            this.GrpBoxUrunListesi.Controls.Add(this.TxtKategori);
            this.GrpBoxUrunListesi.Controls.Add(this.label3);
            this.GrpBoxUrunListesi.Controls.Add(this.TxtUrunAdi);
            this.GrpBoxUrunListesi.Controls.Add(this.label2);
            this.GrpBoxUrunListesi.Location = new System.Drawing.Point(15, 48);
            this.GrpBoxUrunListesi.Name = "GrpBoxUrunListesi";
            this.GrpBoxUrunListesi.Size = new System.Drawing.Size(433, 240);
            this.GrpBoxUrunListesi.TabIndex = 4;
            this.GrpBoxUrunListesi.TabStop = false;
            this.GrpBoxUrunListesi.Text = "Secilen Urun Listesi";
            this.GrpBoxUrunListesi.Enter += new System.EventHandler(this.GrpBoxUrunListesi_Enter);
            // 
            // urunresim
            // 
            this.urunresim.Location = new System.Drawing.Point(6, 22);
            this.urunresim.Name = "urunresim";
            this.urunresim.Size = new System.Drawing.Size(177, 98);
            this.urunresim.TabIndex = 5;
            this.urunresim.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kategori";
            // 
            // TxtKategori
            // 
            this.TxtKategori.Location = new System.Drawing.Point(327, 45);
            this.TxtKategori.Name = "TxtKategori";
            this.TxtKategori.Size = new System.Drawing.Size(100, 20);
            this.TxtKategori.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stok Adet";
            // 
            // TxtStok
            // 
            this.TxtStok.Location = new System.Drawing.Point(327, 71);
            this.TxtStok.Name = "TxtStok";
            this.TxtStok.Size = new System.Drawing.Size(100, 20);
            this.TxtStok.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Yazar";
            // 
            // TxtYazar
            // 
            this.TxtYazar.Location = new System.Drawing.Point(327, 97);
            this.TxtYazar.Name = "TxtYazar";
            this.TxtYazar.Size = new System.Drawing.Size(100, 20);
            this.TxtYazar.TabIndex = 3;
            // 
            // RtxtAciklama
            // 
            this.RtxtAciklama.Location = new System.Drawing.Point(7, 126);
            this.RtxtAciklama.Name = "RtxtAciklama";
            this.RtxtAciklama.Size = new System.Drawing.Size(420, 96);
            this.RtxtAciklama.TabIndex = 4;
            this.RtxtAciklama.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 298);
            this.Controls.Add(this.GrpBoxUrunListesi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbBoxUrunListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBox inceleme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrpBoxUrunListesi.ResumeLayout(false);
            this.GrpBoxUrunListesi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunresim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbBoxUrunListesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUrunAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GrpBoxUrunListesi;
        private System.Windows.Forms.RichTextBox RtxtAciklama;
        private System.Windows.Forms.PictureBox urunresim;
        private System.Windows.Forms.TextBox TxtYazar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtStok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtKategori;
        private System.Windows.Forms.Label label3;
    }
}

