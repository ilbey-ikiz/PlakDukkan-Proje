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
    public partial class AdminEkrani : Form
    {
        public AdminEkrani()
        {
            InitializeComponent();
        }
        AlbumRepository rep = new AlbumRepository();
        SanatciRepository sanatciRep = new SanatciRepository();
        Album album;
        private void AdminEkrani_Load(object sender, EventArgs e)
        {
            lvAnaListe.Items.Clear();
            cbSanatci.DisplayMember = "SanatciAdi";
            cbSanatci.ValueMember = "SanatciID";
            cbSanatci.DataSource = sanatciRep.GetAll();

            string a = "Satista";
            string b = "Satista Degil";
            cbSatisDurumu.Items.Add(a);
            cbSatisDurumu.Items.Add(b);

            Doldur();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            rep = new AlbumRepository();
            sanatciRep = new SanatciRepository();
            album = new();
            if (!Helper.Helper.AreTextBoxesEmpty(this))
            {
                album.SanatciID = (int)cbSanatci.SelectedValue;
                album.AlbumAdi = txtAlbumAdi.Text;
                if (cbSatisDurumu.SelectedIndex == 0)
                    album.SatisDurum = true;
                else album.SatisDurum = false;
                album.IndirimOrani = (byte)nudIndirimOrani.Value;
                album.CikisTarihi = dtpCikisTarihi.Value;
                album.Fiyat = nudFiyat.Value;
                rep.Add(album);
            }
            Doldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!Helper.Helper.AreTextBoxesEmpty(this))
            {
                album.SanatciID = (int)cbSanatci.SelectedValue;
                album.AlbumAdi = txtAlbumAdi.Text;
                if (cbSatisDurumu.SelectedIndex == 0)
                    album.SatisDurum = true;
                else album.SatisDurum = false;
                album.IndirimOrani = (byte)nudIndirimOrani.Value;
                album.CikisTarihi = dtpCikisTarihi.Value;
                album.Fiyat = nudFiyat.Value;
                rep.Update(album);
            }
            Doldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            rep.Remove(album);
            Doldur();
        }

        private void linkLabelKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitEkrani kayitEkrani = new KayitEkrani(false);
            kayitEkrani.ShowDialog();
        }

        private void lvAnaListe_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvAnaListe.SelectedItems.Count > 0)
            {
                cbSatisDurumu.SelectedIndex=-1;
                album = rep.AlbumGetir((int)lvAnaListe.SelectedItems[0].Tag);
                if (album != null)
                {
                    txtAlbumAdi.Text = album.AlbumAdi;
                    nudFiyat.Value = album.Fiyat;
                    nudIndirimOrani.Value = album.IndirimOrani;
                    cbSanatci.SelectedValue = album.SanatciID;
                    cbSatisDurumu.SelectedIndex = album.SatisDurum ? 0 : 1;
                }

            }
        }

        private void btnSanatciEkle_Click(object sender, EventArgs e)
        {
            SanatciEkle sanatciEkle = new SanatciEkle();
            sanatciEkle.ShowDialog();
        }


        public void Doldur()
        {
            lvAnaListe.Items.Clear();
            List<Album> albums = rep.AlbumleriGetir();
            foreach (Album album in albums)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = album.AlbumAdi.ToString();
                lvi.Tag = album.AlbumID;
                lvi.SubItems.Add(album.Sanatci.SanatciAdi);
                lvi.SubItems.Add(album.CikisTarihi.ToString());
                lvi.SubItems.Add(album.Fiyat.ToString());
                lvi.SubItems.Add(album.IndirimOrani.ToString());
                lvi.SubItems.Add(album.SatisDurum ? "Satista" : "Tukendi");
                lvAnaListe.Items.Add(lvi);
            }
        }
    }
}
