namespace PlakDukkanıProje.Forms
{
    partial class AdminEkrani
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
            linkLabelKayit = new LinkLabel();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            lvAnaListe = new ListView();
            albumAdi = new ColumnHeader();
            SanatciAdi = new ColumnHeader();
            AlbümTarihi = new ColumnHeader();
            fiyat = new ColumnHeader();
            indirimoranı = new ColumnHeader();
            Durum = new ColumnHeader();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtAlbumAdi = new TextBox();
            cbSanatci = new ComboBox();
            btnSanatciEkle = new Button();
            dtpCikisTarihi = new DateTimePicker();
            cbSatisDurumu = new ComboBox();
            nudIndirimOrani = new NumericUpDown();
            nudFiyat = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudIndirimOrani).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFiyat).BeginInit();
            SuspendLayout();
            // 
            // linkLabelKayit
            // 
            linkLabelKayit.AutoSize = true;
            linkLabelKayit.Location = new Point(810, 346);
            linkLabelKayit.Name = "linkLabelKayit";
            linkLabelKayit.Size = new Size(67, 15);
            linkLabelKayit.TabIndex = 34;
            linkLabelKayit.TabStop = true;
            linkLabelKayit.Text = "Admin Ekle";
            linkLabelKayit.LinkClicked += linkLabelKayit_LinkClicked;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.ActiveBorder;
            btnSil.Location = new Point(370, 301);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(140, 60);
            btnSil.TabIndex = 33;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = SystemColors.ActiveBorder;
            btnGuncelle.Location = new Point(198, 301);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(140, 60);
            btnGuncelle.TabIndex = 32;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.ActiveBorder;
            btnEkle.Location = new Point(31, 301);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(140, 60);
            btnEkle.TabIndex = 31;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // lvAnaListe
            // 
            lvAnaListe.Columns.AddRange(new ColumnHeader[] { albumAdi, SanatciAdi, AlbümTarihi, fiyat, indirimoranı, Durum });
            lvAnaListe.FullRowSelect = true;
            lvAnaListe.GridLines = true;
            lvAnaListe.Location = new Point(266, 23);
            lvAnaListe.Name = "lvAnaListe";
            lvAnaListe.Size = new Size(611, 251);
            lvAnaListe.TabIndex = 30;
            lvAnaListe.UseCompatibleStateImageBehavior = false;
            lvAnaListe.View = View.Details;
            lvAnaListe.SelectedIndexChanged += lvAnaListe_SelectedIndexChanged;
            // 
            // albumAdi
            // 
            albumAdi.Text = "Albüm Adı";
            albumAdi.Width = 100;
            // 
            // SanatciAdi
            // 
            SanatciAdi.Text = "Sanatçı Adı";
            SanatciAdi.Width = 100;
            // 
            // AlbümTarihi
            // 
            AlbümTarihi.Text = "Albüm Çıkış Tarihi";
            AlbümTarihi.Width = 120;
            // 
            // fiyat
            // 
            fiyat.Text = "Fiyat";
            // 
            // indirimoranı
            // 
            indirimoranı.Text = "İndirim Oranı";
            indirimoranı.Width = 100;
            // 
            // Durum
            // 
            Durum.Text = "Satış Durumu";
            Durum.Width = 100;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 254);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 29;
            label6.Text = "Satış durumu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 203);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 27;
            label5.Text = "İndirim Oranı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 155);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 25;
            label4.Text = "Fiyat :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 106);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 23;
            label3.Text = "Çıkış Tarihi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 63);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 21;
            label2.Text = "Sanatçı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 23);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 19;
            label1.Text = "Albüm Adı :";
            // 
            // txtAlbumAdi
            // 
            txtAlbumAdi.Location = new Point(120, 20);
            txtAlbumAdi.Name = "txtAlbumAdi";
            txtAlbumAdi.Size = new Size(121, 23);
            txtAlbumAdi.TabIndex = 18;
            // 
            // cbSanatci
            // 
            cbSanatci.FormattingEnabled = true;
            cbSanatci.Location = new Point(120, 63);
            cbSanatci.Name = "cbSanatci";
            cbSanatci.Size = new Size(121, 23);
            cbSanatci.TabIndex = 35;
            // 
            // btnSanatciEkle
            // 
            btnSanatciEkle.BackColor = SystemColors.ActiveBorder;
            btnSanatciEkle.Location = new Point(675, 301);
            btnSanatciEkle.Name = "btnSanatciEkle";
            btnSanatciEkle.Size = new Size(113, 60);
            btnSanatciEkle.TabIndex = 36;
            btnSanatciEkle.Text = "Sanatci Ekle";
            btnSanatciEkle.UseVisualStyleBackColor = false;
            btnSanatciEkle.Click += btnSanatciEkle_Click;
            // 
            // dtpCikisTarihi
            // 
            dtpCikisTarihi.Location = new Point(120, 100);
            dtpCikisTarihi.Name = "dtpCikisTarihi";
            dtpCikisTarihi.Size = new Size(121, 23);
            dtpCikisTarihi.TabIndex = 37;
            // 
            // cbSatisDurumu
            // 
            cbSatisDurumu.FormattingEnabled = true;
            cbSatisDurumu.Location = new Point(123, 251);
            cbSatisDurumu.Name = "cbSatisDurumu";
            cbSatisDurumu.Size = new Size(118, 23);
            cbSatisDurumu.TabIndex = 38;
            // 
            // nudIndirimOrani
            // 
            nudIndirimOrani.Location = new Point(121, 201);
            nudIndirimOrani.Name = "nudIndirimOrani";
            nudIndirimOrani.Size = new Size(120, 23);
            nudIndirimOrani.TabIndex = 39;
            // 
            // nudFiyat
            // 
            nudFiyat.Location = new Point(120, 147);
            nudFiyat.Name = "nudFiyat";
            nudFiyat.Size = new Size(120, 23);
            nudFiyat.TabIndex = 40;
            // 
            // AdminEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 394);
            Controls.Add(nudFiyat);
            Controls.Add(nudIndirimOrani);
            Controls.Add(cbSatisDurumu);
            Controls.Add(dtpCikisTarihi);
            Controls.Add(btnSanatciEkle);
            Controls.Add(cbSanatci);
            Controls.Add(linkLabelKayit);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(lvAnaListe);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAlbumAdi);
            Name = "AdminEkrani";
            Text = "AdminEkrani";
            Load += AdminEkrani_Load;
            ((System.ComponentModel.ISupportInitialize)nudIndirimOrani).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFiyat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabelKayit;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnEkle;
        private ListView lvAnaListe;
        private ColumnHeader albumAdi;
        private ColumnHeader SanatciAdi;
        private ColumnHeader AlbümTarihi;
        private ColumnHeader fiyat;
        private ColumnHeader indirimoranı;
        private ColumnHeader Durum;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtAlbumAdi;
        private ComboBox cbSanatci;
        private Button btnSanatciEkle;
        private DateTimePicker dtpCikisTarihi;
        private ComboBox cbSatisDurumu;
        private NumericUpDown nudIndirimOrani;
        private NumericUpDown nudFiyat;
    }
}