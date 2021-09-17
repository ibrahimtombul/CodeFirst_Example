using CodeFirst_Example.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst_Example.Model
{
    public class EntityContext:DbContext
    {
        // Kullanılacak tablolar - Tables to Use
        public DbSet<Products> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Sunucu bağlantı ayarları - SQL Server connection settings
            optionsBuilder.UseSqlServer(@"Server=[SERVER_NAME] ;Database=[DATABASE_NAME]; Trusted_Connection =True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMap()); // ProductMap ayarlarını kullan. - Use ProductMap mapping settings.
        }
    }
}
