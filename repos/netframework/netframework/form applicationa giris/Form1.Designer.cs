namespace form_applicationa_giris
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
            this.btnac = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmesaj = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnac
            // 
            this.btnac.Location = new System.Drawing.Point(51, 178);
            this.btnac.Name = "btnac";
            this.btnac.Size = new System.Drawing.Size(138, 76);
            this.btnac.TabIndex = 0;
            this.btnac.Text = "Formumuzu cagirma";
            this.btnac.UseVisualStyleBackColor = true;
            this.btnac.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ikinci form uzerinden yazmasini\r\n istediginiz metni giriniz";
            // 
            // txtmesaj
            // 
            this.txtmesaj.Location = new System.Drawing.Point(51, 120);
            this.txtmesaj.Name = "txtmesaj";
            this.txtmesaj.Size = new System.Drawing.Size(138, 20);
            this.txtmesaj.TabIndex = 2;
            this.txtmesaj.Text = "Bir metin giriniz";
            this.txtmesaj.Enter += new System.EventHandler(this.txtmesaj_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 282);
            this.Controls.Add(this.txtmesaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meraba Televole Formu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmesaj;
    }
}

