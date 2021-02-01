namespace form_application_7
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
            this.btnuret = new System.Windows.Forms.Button();
            this.layoutpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblskor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblmayin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnuret
            // 
            this.btnuret.Location = new System.Drawing.Point(387, 219);
            this.btnuret.Name = "btnuret";
            this.btnuret.Size = new System.Drawing.Size(75, 23);
            this.btnuret.TabIndex = 0;
            this.btnuret.Text = "uret";
            this.btnuret.UseVisualStyleBackColor = true;
            this.btnuret.Click += new System.EventHandler(this.btnuret_Click);
            // 
            // layoutpanel
            // 
            this.layoutpanel.Location = new System.Drawing.Point(13, 12);
            this.layoutpanel.Name = "layoutpanel";
            this.layoutpanel.Size = new System.Drawing.Size(449, 201);
            this.layoutpanel.TabIndex = 1;
            // 
            // lblskor
            // 
            this.lblskor.AutoSize = true;
            this.lblskor.Location = new System.Drawing.Point(12, 224);
            this.lblskor.Name = "lblskor";
            this.lblskor.Size = new System.Drawing.Size(37, 13);
            this.lblskor.TabIndex = 2;
            this.lblskor.Text = "SKOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "0";
            // 
            // lblmayin
            // 
            this.lblmayin.AutoSize = true;
            this.lblmayin.Location = new System.Drawing.Point(12, 252);
            this.lblmayin.Name = "lblmayin";
            this.lblmayin.Size = new System.Drawing.Size(41, 13);
            this.lblmayin.TabIndex = 2;
            this.lblmayin.Text = "MAYIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 288);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblmayin);
            this.Controls.Add(this.lblskor);
            this.Controls.Add(this.layoutpanel);
            this.Controls.Add(this.btnuret);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnuret;
        private System.Windows.Forms.FlowLayoutPanel layoutpanel;
        private System.Windows.Forms.Label lblskor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblmayin;
        private System.Windows.Forms.Label label4;
    }
}

