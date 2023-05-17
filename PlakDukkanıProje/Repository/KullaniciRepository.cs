using PlakDukkanıProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkanıProje.Repository
{
    internal class KullaniciRepository : BaseRepository<Kullanici>
    {
        public Kullanici GetKullaniciByKullaniciAdi(string kullaniciAdi)
        {
            return db.Kullanilar.FirstOrDefault(k => k.KullaniciAdi == kullaniciAdi);
        }
    }
}
