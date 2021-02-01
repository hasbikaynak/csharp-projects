
namespace ReflectionWinForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_object = new System.Windows.Forms.TextBox();
            this.btn_getir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lst_props = new System.Windows.Forms.ListBox();
            this.lst_methods = new System.Windows.Forms.ListBox();
            this.lst_ctors = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_getir);
            this.groupBox1.Controls.Add(this.txt_object);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1260, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lutfen bilgi almak istediginiz class`in tam adini giriniz";
            // 
            // txt_object
            // 
            this.txt_object.Location = new System.Drawing.Point(6, 46);
            this.txt_object.Name = "txt_object";
            this.txt_object.Size = new System.Drawing.Size(1133, 22);
            this.txt_object.TabIndex = 1;
            // 
            // btn_getir
            // 
            this.btn_getir.Location = new System.Drawing.Point(1162, 33);
            this.btn_getir.Name = "btn_getir";
            this.btn_getir.Size = new System.Drawing.Size(75, 48);
            this.btn_getir.TabIndex = 1;
            this.btn_getir.Text = "Getir";
            this.btn_getir.UseVisualStyleBackColor = true;
            this.btn_getir.Click += new System.EventHandler(this.btn_getir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_ctors);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 543);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CTOR";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lst_props);
            this.groupBox3.Location = new System.Drawing.Point(408, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 543);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Properties";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lst_methods);
            this.groupBox4.Location = new System.Drawing.Point(850, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(422, 543);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Methods";
            // 
            // lst_props
            // 
            this.lst_props.FormattingEnabled = true;
            this.lst_props.ItemHeight = 16;
            this.lst_props.Location = new System.Drawing.Point(6, 21);
            this.lst_props.Name = "lst_props";
            this.lst_props.Size = new System.Drawing.Size(405, 516);
            this.lst_props.TabIndex = 0;
            // 
            // lst_methods
            // 
            this.lst_methods.FormattingEnabled = true;
            this.lst_methods.ItemHeight = 16;
            this.lst_methods.Location = new System.Drawing.Point(6, 22);
            this.lst_methods.Name = "lst_methods";
            this.lst_methods.Size = new System.Drawing.Size(410, 516);
            this.lst_methods.TabIndex = 0;
            // 
            // lst_ctors
            // 
            this.lst_ctors.FormattingEnabled = true;
            this.lst_ctors.ItemHeight = 16;
            this.lst_ctors.Location = new System.Drawing.Point(6, 21);
            this.lst_ctors.Name = "lst_ctors";
            this.lst_ctors.Size = new System.Drawing.Size(363, 516);
            this.lst_ctors.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 673);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reflection Win Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_getir;
        private System.Windows.Forms.TextBox txt_object;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst_ctors;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lst_props;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lst_methods;
    }
}

