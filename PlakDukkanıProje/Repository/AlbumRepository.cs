using Microsoft.EntityFrameworkCore;
using PlakDukkanıProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkanıProje.Repository
{
    internal class AlbumRepository : BaseRepository<Album>
    {
        public List<Album> AlbumleriGetir()
        { 
         return db.Albumler.Include(c => c.Sanatci).ToList();
        }

        public Album? AlbumGetir(int id)
        {
            return db.Albumler.Find(id);
        }
    
        public List<Album> SatisiDurmusAlbumleriGetir()
        { 
        return db.Albumler.Include(s => s.Sanatci).Where(s => s.SatisDurum == false).ToList();
        }

        public List<Album> SatisiDevamEdenleriGetir()
        {
            return db.Albumler.Include(s => s.Sanatci).Where(s => s.SatisDurum == true).ToList();
        }

        public List<Album> SistemeEklenenSonAlbumleriGetir()
        {
            return db.Albumler.Include(s => s.Sanatci).OrderBy(s => s.CikisTarihi).Take(10).ToList();
        }

        public List<Album> IndirimdekiAlbumleriGetir()
        {
            return db.Albumler.Include(s => s.Sanatci).Where(s => s.IndirimOrani !=0).ToList();
        }
    }
}
