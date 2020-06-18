namespace SinemaOtomasyon
{
    partial class Musteri
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
            this.lbsSinSalon = new System.Windows.Forms.ListBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.nudTamBil = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudOgrBil = new System.Windows.Forms.NumericUpDown();
            this.cbSeans = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFilmAra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbFilm = new System.Windows.Forms.ListBox();
            this.txtSinAra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBiletAl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamBil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOgrBil)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbsSinSalon
            // 
            this.lbsSinSalon.FormattingEnabled = true;
            this.lbsSinSalon.Items.AddRange(new object[] {
            "Şehir-SinemaAdı",
            "Şehir-SinemaAdı",
            "Şehir-SinemaAdı",
            "Şehir-SinemaAdı",
            "Şehir-SinemaAdı"});
            this.lbsSinSalon.Location = new System.Drawing.Point(12, 51);
            this.lbsSinSalon.Name = "lbsSinSalon";
            this.lbsSinSalon.Size = new System.Drawing.Size(182, 342);
            this.lbsSinSalon.TabIndex = 0;
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(6, 19);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(200, 20);
            this.dtTarih.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tam Bilet Adet";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nudTamBil
            // 
            this.nudTamBil.Location = new System.Drawing.Point(165, 94);
            this.nudTamBil.Name = "nudTamBil";
            this.nudTamBil.Size = new System.Drawing.Size(39, 20);
            this.nudTamBil.TabIndex = 4;
            this.nudTamBil.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(701, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 62);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fiyat";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Enabled = false;
            this.txtFiyat.Location = new System.Drawing.Point(41, 172);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtFiyat.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Öğrenci Bilet Adet";
            // 
            // nudOgrBil
            // 
            this.nudOgrBil.Location = new System.Drawing.Point(165, 123);
            this.nudOgrBil.Name = "nudOgrBil";
            this.nudOgrBil.Size = new System.Drawing.Size(39, 20);
            this.nudOgrBil.TabIndex = 10;
            // 
            // cbSeans
            // 
            this.cbSeans.FormattingEnabled = true;
            this.cbSeans.Location = new System.Drawing.Point(85, 57);
            this.cbSeans.Name = "cbSeans";
            this.cbSeans.Size = new System.Drawing.Size(121, 21);
            this.cbSeans.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Seanslar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtTarih);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudTamBil);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudOgrBil);
            this.groupBox1.Controls.Add(this.cbSeans);
            this.groupBox1.Controls.Add(this.txtFiyat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(478, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 202);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // txtFilmAra
            // 
            this.txtFilmAra.Location = new System.Drawing.Point(288, 5);
            this.txtFilmAra.Name = "txtFilmAra";
            this.txtFilmAra.Size = new System.Drawing.Size(184, 20);
            this.txtFilmAra.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Film Ara";
            // 
            // lbFilm
            // 
            this.lbFilm.FormattingEnabled = true;
            this.lbFilm.Items.AddRange(new object[] {
            "SalonNo-SesSistemi-Film-(DilSeçeneği)",
            "SalonNo-SesSistemi-Film-(DilSeçeneği)",
            "SalonNo-SesSistemi-Film-(DilSeçeneği)",
            "SalonNo-SesSistemi-Film-(DilSeçeneği)",
            "SalonNo-SesSistemi-Film-(DilSeçeneği)",
            "SalonNo-SesSistemi-Film-(DilSeçeneği)",
            "SalonNo-SesSistemi-Film-(DilSeçeneği)"});
            this.lbFilm.Location = new System.Drawing.Point(241, 50);
            this.lbFilm.Name = "lbFilm";
            this.lbFilm.Size = new System.Drawing.Size(231, 342);
            this.lbFilm.TabIndex = 18;
            // 
            // txtSinAra
            // 
            this.txtSinAra.Location = new System.Drawing.Point(93, 5);
            this.txtSinAra.Name = "txtSinAra";
            this.txtSinAra.Size = new System.Drawing.Size(101, 20);
            this.txtSinAra.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Sinema Salonu";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnBiletAl
            // 
            this.btnBiletAl.Location = new System.Drawing.Point(519, 220);
            this.btnBiletAl.Name = "btnBiletAl";
            this.btnBiletAl.Size = new System.Drawing.Size(127, 31);
            this.btnBiletAl.TabIndex = 21;
            this.btnBiletAl.Text = "Satın Al";
            this.btnBiletAl.UseVisualStyleBackColor = true;
            // 
            // Musteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 405);
            this.Controls.Add(this.btnBiletAl);
            this.Controls.Add(this.txtSinAra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbFilm);
            this.Controls.Add(this.txtFilmAra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbsSinSalon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Musteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musteri";
            this.Load += new System.EventHandler(this.Musteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTamBil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOgrBil)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbsSinSalon;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudTamBil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudOgrBil;
        private System.Windows.Forms.ComboBox cbSeans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFilmAra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbFilm;
        private System.Windows.Forms.TextBox txtSinAra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBiletAl;
    }
}