using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkanıProje.Models
{
    internal class Album
    {
     

        public int AlbumID { get; set; }
        public string AlbumAdi { get; set; }
        public int SanatciID { get; set; }
        public DateTime CikisTarihi { get; set; }
        public decimal Fiyat { get; set; }
        public byte IndirimOrani { get; set; }
        public bool SatisDurum { get; set; }

        public Sanatci Sanatci { get; set; }

    }
}
