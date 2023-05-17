namespace PlakDukkanıProje.Forms
{
    partial class SanatciEkle
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
            txtSanatciAdi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnEkle = new Button();
            SuspendLayout();
            // 
            // txtSanatciAdi
            // 
            txtSanatciAdi.Location = new Point(126, 86);
            txtSanatciAdi.Name = "txtSanatciAdi";
            txtSanatciAdi.Size = new Size(207, 23);
            txtSanatciAdi.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 94);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 1;
            label1.Text = "Sanatci Adi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(146, 31);
            label2.Name = "label2";
            label2.Size = new Size(155, 30);
            label2.TabIndex = 2;
            label2.Text = "SANATCI EKLE";
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.ActiveBorder;
            btnEkle.Location = new Point(157, 133);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(124, 39);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // SanatciEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 226);
            Controls.Add(btnEkle);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSanatciAdi);
            Name = "SanatciEkle";
            Text = "SanatciEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSanatciAdi;
        private Label label1;
        private Label label2;
        private Button btnEkle;
    }
}