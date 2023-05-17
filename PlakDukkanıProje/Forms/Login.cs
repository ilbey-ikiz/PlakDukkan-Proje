using PlakDukkanıProje.Helper;
using PlakDukkanıProje.Models;
using PlakDukkanıProje.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlakDukkanıProje.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Kullanici Kullanici;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            KullaniciRepository rep = new KullaniciRepository();

            if (!Helper.Helper.AreTextBoxesEmpty(this))
            {
                Kullanici = rep.GetKullaniciByKullaniciAdi(txtKullaniciAdi.Text);
                if (Kullanici == null)
                    MessageBox.Show("Kullanici Bulunamadi\n Kayitli Degilseniz Asagidaki Linke Tiklayiniz.");
                else if (Kullanici.Tip == KullaniciTipi.Standart && Kullanici.Sifre == Helper.Helper.sha256_hash(txtSifre.Text))
                {
                    this.Hide();
                    AlbumEkrani albumEkrani = new AlbumEkrani();
                    albumEkrani.ShowDialog();
                    this.Show();

                }
                else if (Kullanici.Tip == KullaniciTipi.Admin && Kullanici.Sifre == Helper.Helper.sha256_hash(txtSifre.Text))
                {
                    this.Hide();
                    AdminEkrani adminEkrani = new AdminEkrani();
                    adminEkrani.ShowDialog();
                    this.Show();
                }
                else
                    MessageBox.Show("Sifre Yanlis.");

            }
            else
                MessageBox.Show("Bilgiler Bos birakilamaz.");

        }

        private void linkLabelKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            KayitEkrani kayitEkrani = new KayitEkrani(true);
            kayitEkrani.ShowDialog();
            this.Show();
        }

        //public void FormlariAc(Form form)
        //{
        //    this.Hide();
        //    KayitEkrani kayitEkrani = new KayitEkrani();
        //    kayitEkrani.ShowDialog();
        //    this.Show();


        //}

       


    }
}
