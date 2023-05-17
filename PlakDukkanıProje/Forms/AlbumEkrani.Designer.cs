namespace PlakDukkanıProje.Forms
{
    partial class AlbumEkrani
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
            btnİndirimdekiAlbümler = new Button();
            lblListeAdi = new Label();
            label1 = new Label();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            btnSonEklenen10 = new Button();
            btnSatisiDevamEden = new Button();
            btnSatisiDurmus = new Button();
            lvAnaListe = new ListView();
            albumAdi = new ColumnHeader();
            SanatciAdi = new ColumnHeader();
            AlbümTarihi = new ColumnHeader();
            fiyat = new ColumnHeader();
            indirimoranı = new ColumnHeader();
            Durum = new ColumnHeader();
            SuspendLayout();
            // 
            // btnİndirimdekiAlbümler
            // 
            btnİndirimdekiAlbümler.BackColor = SystemColors.ActiveBorder;
            btnİndirimdekiAlbümler.Location = new Point(447, 370);
            btnİndirimdekiAlbümler.Name = "btnİndirimdekiAlbümler";
            btnİndirimdekiAlbümler.Size = new Size(194, 39);
            btnİndirimdekiAlbümler.TabIndex = 15;
            btnİndirimdekiAlbümler.Text = "İndirimdeki Albümler";
            btnİndirimdekiAlbümler.UseVisualStyleBackColor = false;
            btnİndirimdekiAlbümler.Click += btnİndirimdekiAlbümler_Click;
            // 
            // lblListeAdi
            // 
            lblListeAdi.AutoSize = true;
            lblListeAdi.Location = new Point(30, 206);
            lblListeAdi.Name = "lblListeAdi";
            lblListeAdi.Size = new Size(46, 15);
            lblListeAdi.TabIndex = 14;
            lblListeAdi.Text = "listeAdi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 25);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 13;
            label1.Text = "Tüm Albümler";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Location = new Point(30, 245);
            listView2.Name = "listView2";
            listView2.Size = new Size(402, 155);
            listView2.TabIndex = 12;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Album Adi";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Sanatci Adi";
            columnHeader2.Width = 200;
            // 
            // btnSonEklenen10
            // 
            btnSonEklenen10.BackColor = SystemColors.ActiveBorder;
            btnSonEklenen10.Location = new Point(447, 325);
            btnSonEklenen10.Name = "btnSonEklenen10";
            btnSonEklenen10.Size = new Size(194, 39);
            btnSonEklenen10.TabIndex = 11;
            btnSonEklenen10.Text = "Son Eklenen 10 Albüm";
            btnSonEklenen10.UseVisualStyleBackColor = false;
            btnSonEklenen10.Click += btnSonEklenen10_Click;
            // 
            // btnSatisiDevamEden
            // 
            btnSatisiDevamEden.BackColor = SystemColors.ActiveBorder;
            btnSatisiDevamEden.Location = new Point(447, 279);
            btnSatisiDevamEden.Name = "btnSatisiDevamEden";
            btnSatisiDevamEden.Size = new Size(194, 40);
            btnSatisiDevamEden.TabIndex = 10;
            btnSatisiDevamEden.Text = "Satışı Süren Albümler";
            btnSatisiDevamEden.UseVisualStyleBackColor = false;
            btnSatisiDevamEden.Click += btnSatisiDevamEden_Click;
            // 
            // btnSatisiDurmus
            // 
            btnSatisiDurmus.BackColor = SystemColors.ActiveBorder;
            btnSatisiDurmus.Location = new Point(447, 233);
            btnSatisiDurmus.Name = "btnSatisiDurmus";
            btnSatisiDurmus.Size = new Size(194, 40);
            btnSatisiDurmus.TabIndex = 9;
            btnSatisiDurmus.Text = "Satışı Durmuş Albümler";
            btnSatisiDurmus.UseVisualStyleBackColor = false;
            btnSatisiDurmus.Click += btnSatisiDurmus_Click;
            // 
            // lvAnaListe
            // 
            lvAnaListe.Columns.AddRange(new ColumnHeader[] { albumAdi, SanatciAdi, AlbümTarihi, fiyat, indirimoranı, Durum });
            lvAnaListe.FullRowSelect = true;
            lvAnaListe.GridLines = true;
            lvAnaListe.Location = new Point(30, 59);
            lvAnaListe.Name = "lvAnaListe";
            lvAnaListe.Size = new Size(602, 144);
            lvAnaListe.TabIndex = 8;
            lvAnaListe.UseCompatibleStateImageBehavior = false;
            lvAnaListe.View = View.Details;
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
            // AlbumEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 435);
            Controls.Add(btnİndirimdekiAlbümler);
            Controls.Add(lblListeAdi);
            Controls.Add(label1);
            Controls.Add(listView2);
            Controls.Add(btnSonEklenen10);
            Controls.Add(btnSatisiDevamEden);
            Controls.Add(btnSatisiDurmus);
            Controls.Add(lvAnaListe);
            Name = "AlbumEkrani";
            Text = "AlbumEkrani";
            Load += AlbumEkrani_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnİndirimdekiAlbümler;
        private Label lblListeAdi;
        private Label label1;
        private ListView listView2;
        private Button btnSonEklenen10;
        private Button btnSatisiDevamEden;
        private Button btnSatisiDurmus;
        private ListView lvAnaListe;
        private ColumnHeader albumAdi;
        private ColumnHeader SanatciAdi;
        private ColumnHeader AlbümTarihi;
        private ColumnHeader fiyat;
        private ColumnHeader indirimoranı;
        private ColumnHeader Durum;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}