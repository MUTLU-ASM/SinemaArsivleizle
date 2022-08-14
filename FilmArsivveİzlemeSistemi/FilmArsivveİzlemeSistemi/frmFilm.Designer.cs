
namespace FilmArsivveİzlemeSistemi
{
    partial class frmFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridFilmListesi = new System.Windows.Forms.DataGridView();
            this.grpEkran = new System.Windows.Forms.GroupBox();
            this.webFilmEkrani = new System.Windows.Forms.WebBrowser();
            this.grpYeniFilm = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.txtFilmAdi = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpİslemler = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnRenkDegistir = new System.Windows.Forms.Button();
            this.btnTamEkran = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFilmListesi)).BeginInit();
            this.grpEkran.SuspendLayout();
            this.grpYeniFilm.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpİslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 126);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(62, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 96);
            this.label1.TabIndex = 1;
            this.label1.Text = "MUTLU FİLM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1013, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridFilmListesi);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(326, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 417);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Listesi";
            // 
            // gridFilmListesi
            // 
            this.gridFilmListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFilmListesi.BackgroundColor = System.Drawing.Color.Maroon;
            this.gridFilmListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFilmListesi.GridColor = System.Drawing.Color.Maroon;
            this.gridFilmListesi.Location = new System.Drawing.Point(7, 28);
            this.gridFilmListesi.Name = "gridFilmListesi";
            this.gridFilmListesi.RowHeadersWidth = 51;
            this.gridFilmListesi.RowTemplate.Height = 24;
            this.gridFilmListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFilmListesi.Size = new System.Drawing.Size(299, 383);
            this.gridFilmListesi.TabIndex = 0;
            this.gridFilmListesi.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFilmListesi_CellContentDoubleClick);
            // 
            // grpEkran
            // 
            this.grpEkran.Controls.Add(this.webFilmEkrani);
            this.grpEkran.ForeColor = System.Drawing.Color.White;
            this.grpEkran.Location = new System.Drawing.Point(644, 155);
            this.grpEkran.Name = "grpEkran";
            this.grpEkran.Size = new System.Drawing.Size(611, 417);
            this.grpEkran.TabIndex = 2;
            this.grpEkran.TabStop = false;
            this.grpEkran.Text = "Ekran";
            // 
            // webFilmEkrani
            // 
            this.webFilmEkrani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webFilmEkrani.Location = new System.Drawing.Point(3, 28);
            this.webFilmEkrani.MinimumSize = new System.Drawing.Size(20, 20);
            this.webFilmEkrani.Name = "webFilmEkrani";
            this.webFilmEkrani.Size = new System.Drawing.Size(605, 386);
            this.webFilmEkrani.TabIndex = 0;
            // 
            // grpYeniFilm
            // 
            this.grpYeniFilm.Controls.Add(this.btnKaydet);
            this.grpYeniFilm.Controls.Add(this.txtLink);
            this.grpYeniFilm.Controls.Add(this.txtKategori);
            this.grpYeniFilm.Controls.Add(this.txtFilmAdi);
            this.grpYeniFilm.Controls.Add(this.groupBox4);
            this.grpYeniFilm.Controls.Add(this.label4);
            this.grpYeniFilm.Controls.Add(this.label3);
            this.grpYeniFilm.Controls.Add(this.label2);
            this.grpYeniFilm.ForeColor = System.Drawing.Color.White;
            this.grpYeniFilm.Location = new System.Drawing.Point(1, 155);
            this.grpYeniFilm.Name = "grpYeniFilm";
            this.grpYeniFilm.Size = new System.Drawing.Size(319, 208);
            this.grpYeniFilm.TabIndex = 2;
            this.grpYeniFilm.TabStop = false;
            this.grpYeniFilm.Text = "Yeni Film";
            // 
            // btnKaydet
            // 
            this.btnKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnKaydet.Location = new System.Drawing.Point(74, 162);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(208, 34);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(130, 119);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(165, 32);
            this.txtLink.TabIndex = 6;
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(130, 74);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(165, 32);
            this.txtKategori.TabIndex = 5;
            // 
            // txtFilmAdi
            // 
            this.txtFilmAdi.Location = new System.Drawing.Point(130, 31);
            this.txtFilmAdi.Name = "txtFilmAdi";
            this.txtFilmAdi.Size = new System.Drawing.Size(165, 32);
            this.txtFilmAdi.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(6, 223);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(319, 217);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Yeni Film";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "label7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Link :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kategori :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Film Adı :";
            // 
            // grpİslemler
            // 
            this.grpİslemler.Controls.Add(this.btnCikis);
            this.grpİslemler.Controls.Add(this.btnRenkDegistir);
            this.grpİslemler.Controls.Add(this.btnTamEkran);
            this.grpİslemler.ForeColor = System.Drawing.Color.White;
            this.grpİslemler.Location = new System.Drawing.Point(1, 364);
            this.grpİslemler.Name = "grpİslemler";
            this.grpİslemler.Size = new System.Drawing.Size(319, 208);
            this.grpİslemler.TabIndex = 4;
            this.grpİslemler.TabStop = false;
            this.grpİslemler.Text = "İşlemler";
            // 
            // btnCikis
            // 
            this.btnCikis.ForeColor = System.Drawing.Color.Black;
            this.btnCikis.Location = new System.Drawing.Point(55, 154);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(208, 34);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnRenkDegistir
            // 
            this.btnRenkDegistir.ForeColor = System.Drawing.Color.Black;
            this.btnRenkDegistir.Location = new System.Drawing.Point(55, 105);
            this.btnRenkDegistir.Name = "btnRenkDegistir";
            this.btnRenkDegistir.Size = new System.Drawing.Size(208, 34);
            this.btnRenkDegistir.TabIndex = 2;
            this.btnRenkDegistir.Text = "Renk Değiştir";
            this.btnRenkDegistir.UseVisualStyleBackColor = true;
            this.btnRenkDegistir.Click += new System.EventHandler(this.btnRenkDegistir_Click);
            // 
            // btnTamEkran
            // 
            this.btnTamEkran.ForeColor = System.Drawing.Color.Black;
            this.btnTamEkran.Location = new System.Drawing.Point(55, 56);
            this.btnTamEkran.Name = "btnTamEkran";
            this.btnTamEkran.Size = new System.Drawing.Size(208, 34);
            this.btnTamEkran.TabIndex = 0;
            this.btnTamEkran.Text = "Tam Ekran";
            this.btnTamEkran.UseVisualStyleBackColor = true;
            this.btnTamEkran.Click += new System.EventHandler(this.btnTamEkran_Click);
            // 
            // frmFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1267, 584);
            this.Controls.Add(this.grpİslemler);
            this.Controls.Add(this.grpYeniFilm);
            this.Controls.Add(this.grpEkran);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmFilm";
            this.Text = "frmFilm";
            this.Load += new System.EventHandler(this.frmFilm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFilmListesi)).EndInit();
            this.grpEkran.ResumeLayout(false);
            this.grpYeniFilm.ResumeLayout(false);
            this.grpYeniFilm.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpİslemler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridFilmListesi;
        private System.Windows.Forms.GroupBox grpEkran;
        private System.Windows.Forms.WebBrowser webFilmEkrani;
        private System.Windows.Forms.GroupBox grpYeniFilm;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.TextBox txtFilmAdi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpİslemler;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnRenkDegistir;
        private System.Windows.Forms.Button btnTamEkran;
    }
}