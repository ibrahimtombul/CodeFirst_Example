using CodeFirst_Example.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirst_Example.Model
{
    public class ProductMap:IEntityTypeConfiguration<Products>
    {
        // Mapping Settings
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasKey(x => x.Id); //PrimaryKey
            builder.Property(x => x.Id).ValueGeneratedOnAdd(); // Otomatik Artan - Identity Increment
            builder.Property(x => x.Name).HasMaxLength(50); // nvarchar(50)
            builder.Property(x => x.Description).HasMaxLength(150); // nvarchar(150)
            builder.Property(x => x.Price).HasColumnType("money"); // Convert Decimal to money for SQL table
            builder.ToTable("Products"); // Tablo Adı - Table Name
        }
    }
}
