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
    public partial class SanatciEkle : Form
    {
        public SanatciEkle()
        {
            InitializeComponent();
        }
        SanatciRepository rep = new SanatciRepository();    
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Sanatci sanatci = new Sanatci();
            sanatci.SanatciAdi = txtSanatciAdi.Text;
            rep.Add(sanatci);
        }
    }
}
