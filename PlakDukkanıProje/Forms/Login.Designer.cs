namespace PlakDukkanıProje.Forms
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
            linkLabelKayit = new LinkLabel();
            btnGiris = new Button();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // linkLabelKayit
            // 
            linkLabelKayit.AutoSize = true;
            linkLabelKayit.Location = new Point(267, 216);
            linkLabelKayit.Name = "linkLabelKayit";
            linkLabelKayit.Size = new Size(48, 15);
            linkLabelKayit.TabIndex = 11;
            linkLabelKayit.TabStop = true;
            linkLabelKayit.Text = "Kayıt Ol";
            linkLabelKayit.LinkClicked += linkLabelKayit_LinkClicked;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(26, 145);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(282, 43);
            btnGiris.TabIndex = 10;
            btnGiris.Text = "GİRİŞ";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(111, 94);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(197, 23);
            txtSifre.TabIndex = 9;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(111, 34);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(197, 23);
            txtKullaniciAdi.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 97);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 7;
            label2.Text = "Şifre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 37);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 6;
            label1.Text = "Kullanıcı Adı :";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 275);
            Controls.Add(linkLabelKayit);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabelKayit;
        private Button btnGiris;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Label label2;
        private Label label1;
    }
}