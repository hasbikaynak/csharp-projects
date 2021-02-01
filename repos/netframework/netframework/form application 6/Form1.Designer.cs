namespace form_application_6
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.btntemizle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemailadres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttelefonnumarasi = new System.Windows.Forms.TextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnonizlemeekrani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Isim";
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(133, 39);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(172, 20);
            this.txtisim.TabIndex = 0;
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(133, 143);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(79, 23);
            this.btntemizle.TabIndex = 5;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyisim";
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Location = new System.Drawing.Point(133, 65);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(172, 20);
            this.txtsoyisim.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email Adres";
            // 
            // txtemailadres
            // 
            this.txtemailadres.Location = new System.Drawing.Point(133, 91);
            this.txtemailadres.Name = "txtemailadres";
            this.txtemailadres.Size = new System.Drawing.Size(172, 20);
            this.txtemailadres.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon Numarasi";
            // 
            // txttelefonnumarasi
            // 
            this.txttelefonnumarasi.Location = new System.Drawing.Point(133, 117);
            this.txttelefonnumarasi.Name = "txttelefonnumarasi";
            this.txttelefonnumarasi.Size = new System.Drawing.Size(172, 20);
            this.txttelefonnumarasi.TabIndex = 3;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(218, 143);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(87, 23);
            this.btnkaydet.TabIndex = 4;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnonizlemeekrani
            // 
            this.btnonizlemeekrani.Location = new System.Drawing.Point(133, 172);
            this.btnonizlemeekrani.Name = "btnonizlemeekrani";
            this.btnonizlemeekrani.Size = new System.Drawing.Size(172, 23);
            this.btnonizlemeekrani.TabIndex = 4;
            this.btnonizlemeekrani.Text = "onizleme ekrani";
            this.btnonizlemeekrani.UseVisualStyleBackColor = true;
            this.btnonizlemeekrani.Click += new System.EventHandler(this.btnonizlemeekrani_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 210);
            this.Controls.Add(this.btnonizlemeekrani);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.txttelefonnumarasi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtemailadres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsoyisim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsoyisim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemailadres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttelefonnumarasi;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnonizlemeekrani;
    }
}

