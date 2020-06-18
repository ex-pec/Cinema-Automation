namespace SinemaOtomasyon
{
    partial class UyeOl
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYKAdi = new System.Windows.Forms.TextBox();
            this.txtYKSifre = new System.Windows.Forms.TextBox();
            this.txtYKSOnay = new System.Windows.Forms.TextBox();
            this.btnKaydol = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifreyi Onayla:";
            // 
            // txtYKAdi
            // 
            this.txtYKAdi.Location = new System.Drawing.Point(85, 17);
            this.txtYKAdi.Name = "txtYKAdi";
            this.txtYKAdi.Size = new System.Drawing.Size(174, 20);
            this.txtYKAdi.TabIndex = 3;
            // 
            // txtYKSifre
            // 
            this.txtYKSifre.Location = new System.Drawing.Point(85, 43);
            this.txtYKSifre.Name = "txtYKSifre";
            this.txtYKSifre.PasswordChar = '●';
            this.txtYKSifre.Size = new System.Drawing.Size(174, 20);
            this.txtYKSifre.TabIndex = 4;
            // 
            // txtYKSOnay
            // 
            this.txtYKSOnay.Location = new System.Drawing.Point(85, 69);
            this.txtYKSOnay.Name = "txtYKSOnay";
            this.txtYKSOnay.PasswordChar = '●';
            this.txtYKSOnay.Size = new System.Drawing.Size(174, 20);
            this.txtYKSOnay.TabIndex = 5;
            // 
            // btnKaydol
            // 
            this.btnKaydol.Location = new System.Drawing.Point(184, 147);
            this.btnKaydol.Name = "btnKaydol";
            this.btnKaydol.Size = new System.Drawing.Size(75, 23);
            this.btnKaydol.TabIndex = 6;
            this.btnKaydol.Text = "KAYDOL";
            this.btnKaydol.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtYKSifre);
            this.groupBox1.Controls.Add(this.btnKaydol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtYKSOnay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtYKAdi);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 181);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '●';
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '●';
            this.textBox2.Size = new System.Drawing.Size(174, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Soyadı:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Adı:";
            // 
            // UyeOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 202);
            this.Controls.Add(this.groupBox1);
            this.Name = "UyeOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UyeOl";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYKAdi;
        private System.Windows.Forms.TextBox txtYKSifre;
        private System.Windows.Forms.TextBox txtYKSOnay;
        private System.Windows.Forms.Button btnKaydol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}