using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkanıProje.Models
{
    internal class Sanatci
    {
        public Sanatci()
        {
            Albumler = new List<Album>();
        }

        public int SanatciID { get; set; }
        public string SanatciAdi { get; set; }

        public ICollection<Album> Albumler { get; set; }
    }
}
