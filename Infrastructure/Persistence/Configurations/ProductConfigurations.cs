using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.ProductName)
                    .HasMaxLength(100)
                    .HasAnnotation("MinLength", 3)
                    .IsRequired();
            builder.Property(m => m.Price);
            // builder.HasOne(m => m.InfoBill)
            // .WithOne(n => n.Product)
            // .HasForeignKey<InfoBill>(i => i.IdProduct);
        }
    }
}