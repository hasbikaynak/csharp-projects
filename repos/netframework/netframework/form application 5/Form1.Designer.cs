namespace form_application_5
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
            this.btngoster = new System.Windows.Forms.Button();
            this.btngosterpopup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btngoster
            // 
            this.btngoster.Location = new System.Drawing.Point(12, 99);
            this.btngoster.Name = "btngoster";
            this.btngoster.Size = new System.Drawing.Size(149, 117);
            this.btngoster.TabIndex = 0;
            this.btngoster.Text = "Goster";
            this.btngoster.UseVisualStyleBackColor = true;
            this.btngoster.Click += new System.EventHandler(this.btngoster_Click);
            // 
            // btngosterpopup
            // 
            this.btngosterpopup.Location = new System.Drawing.Point(356, 99);
            this.btngosterpopup.Name = "btngosterpopup";
            this.btngosterpopup.Size = new System.Drawing.Size(154, 117);
            this.btngosterpopup.TabIndex = 1;
            this.btngosterpopup.Text = "Goster PopUp";
            this.btngosterpopup.UseVisualStyleBackColor = true;
            this.btngosterpopup.Click += new System.EventHandler(this.btngosterpopup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 298);
            this.Controls.Add(this.btngosterpopup);
            this.Controls.Add(this.btngoster);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btngoster;
        private System.Windows.Forms.Button btngosterpopup;
    }
}

