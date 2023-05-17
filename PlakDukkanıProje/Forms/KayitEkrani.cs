using PlakDukkanıProje.Models;
using PlakDukkanıProje.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlakDukkanıProje.Forms
{
    public partial class KayitEkrani : Form
    {
        public KayitEkrani()
        {
            InitializeComponent();
        }
        public KayitEkrani(bool Kullanici)
        {
            InitializeComponent();
            kontrol = Kullanici;
        }
        bool kontrol;
        KullaniciRepository rep = new KullaniciRepository();
        private void btnKayit_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            if (Helper.Helper.AreTextBoxesEmpty(this))
            {
                MessageBox.Show("Bilgiler Bos olamaz.");
                return;
            }
            if (kontrol)
            {
                kullanici.Tip = KullaniciTipi.Standart;
                kullanici.Ad = txtAd.Text;
                kullanici.Soyad = txtSoyad.Text;
                kullanici.Sifre = Helper.Helper.sha256_hash(txtSifre.Text);
                kullanici.KullaniciAdi = txtKullanıcıAdı.Text;
                Kullanici kullanici1 = rep.GetKullaniciByKullaniciAdi(txtKullanıcıAdı.Text);
                if (txtSifre.Text == txtSifreTekrar.Text)
                {
                    if (kullanici1 == null)
                    {
                        bool eklendiMi = rep.Add(kullanici);
                        if (eklendiMi)
                        {
                            MessageBox.Show("Kayit Basarili");
                            Helper.Helper.ClearTextBoxes(this);
                        }
                    }
                    else MessageBox.Show("Kullanici Adi Kullaniliyor.");
                }
                else MessageBox.Show("Sifreler Uyusmuyor.");
            }
            else
            {
                kullanici.Tip = KullaniciTipi.Admin;
                kullanici.Ad = txtAd.Text;
                kullanici.Soyad = txtSoyad.Text;
                kullanici.Sifre = Helper.Helper.sha256_hash(txtSifre.Text);
                kullanici.KullaniciAdi = txtKullanıcıAdı.Text;
                Kullanici kullanici1 = rep.GetKullaniciByKullaniciAdi(txtKullanıcıAdı.Text);
                if (txtSifre.Text == txtSifreTekrar.Text)
                {
                    if (kullanici1 == null)
                    {
                        bool eklendiMi = rep.Add(kullanici);
                        if (eklendiMi)
                        {
                            MessageBox.Show("Admin Eklendi");
                            Helper.Helper.ClearTextBoxes(this);
                        }
                    }
                    else MessageBox.Show("Kullanici Adi Kullaniliyor.");
                }
                else MessageBox.Show("Sifreler Uyusmuyor.");
            }
        }


    }
}
