using Microsoft.EntityFrameworkCore;
using OkulOtomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OkulOtomasyonu.Context
{
	public class MyDbContext : DbContext
	{
		public DbSet<KullaniciTipi> KullaniciTipleri { get; set; }
		public DbSet<Kullanici> Kullanicilar { get; set; }
		public DbSet<Sinif> Siniflar { get; set; }
		public DbSet<Ders> Dersler { get; set; }
		public DbSet<Sinav> Sinavlar { get; set; }
		public DbSet<Ogrenci> Ogrenciler { get; set; }
		public DbSet<Veli> Veliler { get; set; }
		public DbSet<Ogretmen> Ogretmenler { get; set; }
		public DbSet<Mudur> Mudurler { get; set; }
		public DbSet<SinavSonucu> SinavSonuclari { get; set; }
		public DbSet<OgrenciDers> OgrenciDersleri { get; set; }



		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source=OZGUVEN;Initial Catalog=EgitimOtomasyonu;Integrated Security=True");
		}

		
	}
}
