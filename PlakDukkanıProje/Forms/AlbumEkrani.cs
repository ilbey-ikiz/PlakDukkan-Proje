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
    public partial class AlbumEkrani : Form
    {
        public AlbumEkrani()
        {
            InitializeComponent();
        }

        AlbumRepository rep = new AlbumRepository();
        SanatciRepository sanatciRep = new SanatciRepository();
        private void AlbumEkrani_Load(object sender, EventArgs e)
        {
            List<Album> albums = rep.GetAll();
            List<Sanatci> sanatcilar = sanatciRep.GetAll();
            foreach (Album album in albums)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = album.AlbumAdi.ToString();
                lvi.SubItems.Add(album.SanatciID.ToString());
                lvi.SubItems.Add(album.CikisTarihi.ToString());
                lvi.SubItems.Add(album.Fiyat.ToString());
                lvi.SubItems.Add(album.IndirimOrani.ToString());
                lvi.SubItems.Add(album.SatisDurum ? "Satista" : "Tukendi");
                lvAnaListe.Items.Add(lvi);
            }
        }

        private void btnSatisiDurmus_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            var liste = rep.SatisiDurmusAlbumleriGetir().Select(s => new { s.AlbumAdi, s.Sanatci.SanatciAdi });
            foreach (var item in liste)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.AlbumAdi.ToString();
                lvi.SubItems.Add(item.SanatciAdi);
                listView2.Items.Add(lvi);
            }
        }

        private void btnSatisiDevamEden_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            var liste = rep.SatisiDevamEdenleriGetir().Select(s => new { s.AlbumAdi, s.Sanatci.SanatciAdi });
            foreach (var item in liste)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.AlbumAdi.ToString();
                lvi.SubItems.Add(item.SanatciAdi);
                listView2.Items.Add(lvi);
            }
        }

        private void btnSonEklenen10_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            var liste = rep.SistemeEklenenSonAlbumleriGetir().Select(s => new { s.AlbumAdi, s.Sanatci.SanatciAdi });
            foreach (var item in liste)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.AlbumAdi.ToString();
                lvi.SubItems.Add(item.SanatciAdi);
                listView2.Items.Add(lvi);
            }
        }

        private void btnİndirimdekiAlbümler_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            var liste = rep.IndirimdekiAlbumleriGetir().Select(s => new { s.AlbumAdi, s.Sanatci.SanatciAdi });
            foreach (var item in liste)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.AlbumAdi.ToString();
                lvi.SubItems.Add(item.SanatciAdi);
                listView2.Items.Add(lvi);
            }
        }


    }
}
