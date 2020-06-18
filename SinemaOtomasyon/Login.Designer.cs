namespace SinemaOtomasyon
{
    partial class Login
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
            this.txtMAdi = new System.Windows.Forms.TextBox();
            this.txtMSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMGiris = new System.Windows.Forms.Button();
            this.btnMUyeOl = new System.Windows.Forms.Button();
            this.grpGiris = new System.Windows.Forms.GroupBox();
            this.rbtnMusteri = new System.Windows.Forms.RadioButton();
            this.rbtnYonetici = new System.Windows.Forms.RadioButton();
            this.grpGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMAdi
            // 
            this.txtMAdi.Location = new System.Drawing.Point(84, 16);
            this.txtMAdi.Name = "txtMAdi";
            this.txtMAdi.Size = new System.Drawing.Size(194, 20);
            this.txtMAdi.TabIndex = 2;
            // 
            // txtMSifre
            // 
            this.txtMSifre.Location = new System.Drawing.Point(84, 42);
            this.txtMSifre.Name = "txtMSifre";
            this.txtMSifre.PasswordChar = '●';
            this.txtMSifre.Size = new System.Drawing.Size(194, 20);
            this.txtMSifre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre:";
            // 
            // btnMGiris
            // 
            this.btnMGiris.Location = new System.Drawing.Point(213, 68);
            this.btnMGiris.Name = "btnMGiris";
            this.btnMGiris.Size = new System.Drawing.Size(75, 23);
            this.btnMGiris.TabIndex = 6;
            this.btnMGiris.Text = "GİRİŞ";
            this.btnMGiris.UseVisualStyleBackColor = true;
            // 
            // btnMUyeOl
            // 
            this.btnMUyeOl.Location = new System.Drawing.Point(132, 68);
            this.btnMUyeOl.Name = "btnMUyeOl";
            this.btnMUyeOl.Size = new System.Drawing.Size(75, 23);
            this.btnMUyeOl.TabIndex = 7;
            this.btnMUyeOl.Text = "ÜYE OL";
            this.btnMUyeOl.UseVisualStyleBackColor = true;
            this.btnMUyeOl.Click += new System.EventHandler(this.btnMUyeOl_Click);
            // 
            // grpGiris
            // 
            this.grpGiris.Controls.Add(this.txtMSifre);
            this.grpGiris.Controls.Add(this.btnMUyeOl);
            this.grpGiris.Controls.Add(this.txtMAdi);
            this.grpGiris.Controls.Add(this.btnMGiris);
            this.grpGiris.Controls.Add(this.label1);
            this.grpGiris.Controls.Add(this.label2);
            this.grpGiris.Location = new System.Drawing.Point(43, 66);
            this.grpGiris.Name = "grpGiris";
            this.grpGiris.Size = new System.Drawing.Size(294, 109);
            this.grpGiris.TabIndex = 8;
            this.grpGiris.TabStop = false;
            // 
            // rbtnMusteri
            // 
            this.rbtnMusteri.AutoSize = true;
            this.rbtnMusteri.Location = new System.Drawing.Point(43, 27);
            this.rbtnMusteri.Name = "rbtnMusteri";
            this.rbtnMusteri.Size = new System.Drawing.Size(84, 17);
            this.rbtnMusteri.TabIndex = 10;
            this.rbtnMusteri.TabStop = true;
            this.rbtnMusteri.Text = "Müsteri Girişi";
            this.rbtnMusteri.UseVisualStyleBackColor = true;
            this.rbtnMusteri.CheckedChanged += new System.EventHandler(this.Giris);
            // 
            // rbtnYonetici
            // 
            this.rbtnYonetici.AutoSize = true;
            this.rbtnYonetici.Location = new System.Drawing.Point(133, 27);
            this.rbtnYonetici.Name = "rbtnYonetici";
            this.rbtnYonetici.Size = new System.Drawing.Size(88, 17);
            this.rbtnYonetici.TabIndex = 11;
            this.rbtnYonetici.TabStop = true;
            this.rbtnYonetici.Text = "Yönetici Girişi";
            this.rbtnYonetici.UseVisualStyleBackColor = true;
            this.rbtnYonetici.CheckedChanged += new System.EventHandler(this.Giris);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 196);
            this.Controls.Add(this.rbtnYonetici);
            this.Controls.Add(this.rbtnMusteri);
            this.Controls.Add(this.grpGiris);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.grpGiris.ResumeLayout(false);
            this.grpGiris.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMAdi;
        private System.Windows.Forms.TextBox txtMSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMGiris;
        private System.Windows.Forms.Button btnMUyeOl;
        private System.Windows.Forms.GroupBox grpGiris;
        private System.Windows.Forms.RadioButton rbtnMusteri;
        private System.Windows.Forms.RadioButton rbtnYonetici;
    }
}