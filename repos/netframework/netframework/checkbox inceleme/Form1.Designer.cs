namespace checkbox_inceleme
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
            this.chklistbox = new System.Windows.Forms.CheckedListBox();
            this.GrpBoxUrunListesi = new System.Windows.Forms.GroupBox();
            this.RtxtAciklama = new System.Windows.Forms.RichTextBox();
            this.pboxurunresim = new System.Windows.Forms.PictureBox();
            this.TxtYazar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtStok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtKategori = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUrunAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GrpBoxUrunListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxurunresim)).BeginInit();
            this.SuspendLayout();
            // 
            // chklistbox
            // 
            this.chklistbox.FormattingEnabled = true;
            this.chklistbox.Location = new System.Drawing.Point(13, 13);
            this.chklistbox.Name = "chklistbox";
            this.chklistbox.Size = new System.Drawing.Size(139, 244);
            this.chklistbox.TabIndex = 0;
            this.chklistbox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklistbox_ItemCheck);
            // 
            // GrpBoxUrunListesi
            // 
            this.GrpBoxUrunListesi.Controls.Add(this.RtxtAciklama);
            this.GrpBoxUrunListesi.Controls.Add(this.pboxurunresim);
            this.GrpBoxUrunListesi.Controls.Add(this.TxtYazar);
            this.GrpBoxUrunListesi.Controls.Add(this.label5);
            this.GrpBoxUrunListesi.Controls.Add(this.TxtStok);
            this.GrpBoxUrunListesi.Controls.Add(this.label4);
            this.GrpBoxUrunListesi.Controls.Add(this.TxtKategori);
            this.GrpBoxUrunListesi.Controls.Add(this.label3);
            this.GrpBoxUrunListesi.Controls.Add(this.TxtUrunAdi);
            this.GrpBoxUrunListesi.Controls.Add(this.label2);
            this.GrpBoxUrunListesi.Location = new System.Drawing.Point(158, 13);
            this.GrpBoxUrunListesi.Name = "GrpBoxUrunListesi";
            this.GrpBoxUrunListesi.Size = new System.Drawing.Size(433, 238);
            this.GrpBoxUrunListesi.TabIndex = 8;
            this.GrpBoxUrunListesi.TabStop = false;
            this.GrpBoxUrunListesi.Text = "Secilen Urun Listesi";
            // 
            // RtxtAciklama
            // 
            this.RtxtAciklama.Location = new System.Drawing.Point(7, 126);
            this.RtxtAciklama.Name = "RtxtAciklama";
            this.RtxtAciklama.Size = new System.Drawing.Size(420, 96);
            this.RtxtAciklama.TabIndex = 4;
            this.RtxtAciklama.Text = "";
            // 
            // pboxurunresim
            // 
            this.pboxurunresim.Location = new System.Drawing.Point(6, 22);
            this.pboxurunresim.Name = "pboxurunresim";
            this.pboxurunresim.Size = new System.Drawing.Size(177, 98);
            this.pboxurunresim.TabIndex = 5;
            this.pboxurunresim.TabStop = false;
            // 
            // TxtYazar
            // 
            this.TxtYazar.Location = new System.Drawing.Point(327, 97);
            this.TxtYazar.Name = "TxtYazar";
            this.TxtYazar.Size = new System.Drawing.Size(100, 20);
            this.TxtYazar.TabIndex = 3;
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
            // TxtStok
            // 
            this.TxtStok.Location = new System.Drawing.Point(327, 71);
            this.TxtStok.Name = "TxtStok";
            this.TxtStok.Size = new System.Drawing.Size(100, 20);
            this.TxtStok.TabIndex = 2;
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
            // TxtKategori
            // 
            this.TxtKategori.Location = new System.Drawing.Point(327, 45);
            this.TxtKategori.Name = "TxtKategori";
            this.TxtKategori.Size = new System.Drawing.Size(100, 20);
            this.TxtKategori.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 265);
            this.Controls.Add(this.GrpBoxUrunListesi);
            this.Controls.Add(this.chklistbox);
            this.Name = "Form1";
            this.Text = "CheckListBox inceleme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrpBoxUrunListesi.ResumeLayout(false);
            this.GrpBoxUrunListesi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxurunresim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklistbox;
        private System.Windows.Forms.GroupBox GrpBoxUrunListesi;
        private System.Windows.Forms.RichTextBox RtxtAciklama;
        private System.Windows.Forms.PictureBox pboxurunresim;
        private System.Windows.Forms.TextBox TxtYazar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtStok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtKategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUrunAdi;
        private System.Windows.Forms.Label label2;
    }
}

