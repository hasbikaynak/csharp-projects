namespace form_application_3
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
            this.btnmesaj = new System.Windows.Forms.Button();
            this.btnsorusor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmesaj
            // 
            this.btnmesaj.Location = new System.Drawing.Point(13, 13);
            this.btnmesaj.Name = "btnmesaj";
            this.btnmesaj.Size = new System.Drawing.Size(92, 29);
            this.btnmesaj.TabIndex = 0;
            this.btnmesaj.Text = "Mesaj Goster";
            this.btnmesaj.UseVisualStyleBackColor = true;
            this.btnmesaj.Click += new System.EventHandler(this.btnmesaj_Click);
            // 
            // btnsorusor
            // 
            this.btnsorusor.Location = new System.Drawing.Point(111, 13);
            this.btnsorusor.Name = "btnsorusor";
            this.btnsorusor.Size = new System.Drawing.Size(75, 29);
            this.btnsorusor.TabIndex = 0;
            this.btnsorusor.Text = "Soru Sor";
            this.btnsorusor.UseVisualStyleBackColor = true;
            this.btnsorusor.Click += new System.EventHandler(this.btnsorusor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsorusor);
            this.Controls.Add(this.btnmesaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmesaj;
        private System.Windows.Forms.Button btnsorusor;
    }
}

