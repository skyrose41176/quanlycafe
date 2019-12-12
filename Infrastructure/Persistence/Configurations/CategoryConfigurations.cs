using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {

            builder.HasKey(m => m.CategoryId);
            builder.Property(m => m.CategoryId);
            builder.Property(m => m.CategoryName);
            builder.HasMany(p => p.Product).WithOne(i => i.Category)
           .HasForeignKey(s => s.CategoryId);
        }
    }
}