
using Microsoft.EntityFrameworkCore;
using PlakDukkanıProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkanıProje.Context
{
    internal class PlakDukkaniDB : DbContext
    {
        public DbSet<Kullanici> Kullanilar { get; set; }
        public DbSet<Sanatci> Sanatcilar { get; set; }
        public DbSet<Album> Albumler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=PlakDukkaniDB ; Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Kullanici>().HasData(new Kullanici{ KullaniciID=1 , KullaniciAdi="admin" , Ad="Enes" , Soyad="Baba" , Sifre=Helper.Helper.sha256_hash("123") , Tip = KullaniciTipi.Admin });
        }
    }
}
