namespace PlakDukkanıProje.Forms
{
    partial class KayitEkrani
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
            btnKayit = new Button();
            txtSifreTekrar = new TextBox();
            label5 = new Label();
            txtSifre = new TextBox();
            label4 = new Label();
            txtKullanıcıAdı = new TextBox();
            label3 = new Label();
            txtSoyad = new TextBox();
            label2 = new Label();
            txtAd = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnKayit
            // 
            btnKayit.BackColor = SystemColors.ActiveBorder;
            btnKayit.Location = new Point(73, 257);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(211, 44);
            btnKayit.TabIndex = 21;
            btnKayit.Text = "KAYIT OL";
            btnKayit.UseVisualStyleBackColor = false;
            btnKayit.Click += btnKayit_Click;
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(133, 210);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(170, 23);
            txtSifreTekrar.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 210);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 19;
            label5.Text = "Şifre Tekrar";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(133, 165);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(170, 23);
            txtSifre.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 165);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 17;
            label4.Text = "Şifre";
            // 
            // txtKullanıcıAdı
            // 
            txtKullanıcıAdı.Location = new Point(133, 116);
            txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            txtKullanıcıAdı.Size = new Size(170, 23);
            txtKullanıcıAdı.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 116);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 15;
            label3.Text = "Kullanıcı Adı ";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(133, 74);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(170, 23);
            txtSoyad.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 74);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 13;
            label2.Text = "Soyad";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(133, 34);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(170, 23);
            txtAd.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 34);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 11;
            label1.Text = "Ad";
            // 
            // KayitEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 340);
            Controls.Add(btnKayit);
            Controls.Add(txtSifreTekrar);
            Controls.Add(label5);
            Controls.Add(txtSifre);
            Controls.Add(label4);
            Controls.Add(txtKullanıcıAdı);
            Controls.Add(label3);
            Controls.Add(txtSoyad);
            Controls.Add(label2);
            Controls.Add(txtAd);
            Controls.Add(label1);
            Name = "KayitEkrani";
            Text = "KayitEkrani";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKayit;
        private TextBox txtSifreTekrar;
        private Label label5;
        private TextBox txtSifre;
        private Label label4;
        private TextBox txtKullanıcıAdı;
        private Label label3;
        private TextBox txtSoyad;
        private Label label2;
        private TextBox txtAd;
        private Label label1;
    }
}