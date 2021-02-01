
namespace RSS_Okuma_Uygulamasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txturl = new System.Windows.Forms.TextBox();
            this.gboxhaberdetay = new System.Windows.Forms.GroupBox();
            this.wbrowser1 = new System.Windows.Forms.WebBrowser();
            this.gboxhaberbasliklari = new System.Windows.Forms.GroupBox();
            this.lst_baslik = new System.Windows.Forms.ListBox();
            this.gboxurl = new System.Windows.Forms.GroupBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.gboxhaberdetay.SuspendLayout();
            this.gboxhaberbasliklari.SuspendLayout();
            this.gboxurl.SuspendLayout();
            this.SuspendLayout();
            // 
            // txturl
            // 
            resources.ApplyResources(this.txturl, "txturl");
            this.txturl.Name = "txturl";
            // 
            // gboxhaberdetay
            // 
            this.gboxhaberdetay.Controls.Add(this.wbrowser1);
            resources.ApplyResources(this.gboxhaberdetay, "gboxhaberdetay");
            this.gboxhaberdetay.Name = "gboxhaberdetay";
            this.gboxhaberdetay.TabStop = false;
            // 
            // wbrowser1
            // 
            resources.ApplyResources(this.wbrowser1, "wbrowser1");
            this.wbrowser1.Name = "wbrowser1";
            // 
            // gboxhaberbasliklari
            // 
            this.gboxhaberbasliklari.Controls.Add(this.lst_baslik);
            resources.ApplyResources(this.gboxhaberbasliklari, "gboxhaberbasliklari");
            this.gboxhaberbasliklari.Name = "gboxhaberbasliklari";
            this.gboxhaberbasliklari.TabStop = false;
            // 
            // lst_baslik
            // 
            this.lst_baslik.FormattingEnabled = true;
            resources.ApplyResources(this.lst_baslik, "lst_baslik");
            this.lst_baslik.Name = "lst_baslik";
            this.lst_baslik.SelectedIndexChanged += new System.EventHandler(this.lst_baslik_SelectedIndexChanged);
            // 
            // gboxurl
            // 
            this.gboxurl.Controls.Add(this.txturl);
            resources.ApplyResources(this.gboxurl, "gboxurl");
            this.gboxurl.Name = "gboxurl";
            this.gboxurl.TabStop = false;
            // 
            // btn1
            // 
            resources.ApplyResources(this.btn1, "btn1");
            this.btn1.Name = "btn1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.gboxurl);
            this.Controls.Add(this.gboxhaberbasliklari);
            this.Controls.Add(this.gboxhaberdetay);
            this.Name = "Form1";
            this.gboxhaberdetay.ResumeLayout(false);
            this.gboxhaberbasliklari.ResumeLayout(false);
            this.gboxurl.ResumeLayout(false);
            this.gboxurl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.GroupBox gboxhaberdetay;
        private System.Windows.Forms.GroupBox gboxhaberbasliklari;
        private System.Windows.Forms.GroupBox gboxurl;
        private System.Windows.Forms.ListBox lst_baslik;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.WebBrowser wbrowser1;
    }
}

