using KitapListelemee.Models;
using Microsoft.EntityFrameworkCore;

namespace KitapListelemee.Repostory
{
    public class RepostoryBaglantisi : DbContext
    {
        public RepostoryBaglantisi(DbContextOptions options) : base(options) 
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(Localdb)\\MSSQLLocalDB;Database=KitapListelemee_db;Trusted_Connection=true");
        }
        public DbSet<Kitap> Kitaps { get; set; }
        public object Kitap { get; set; }
    }
}
