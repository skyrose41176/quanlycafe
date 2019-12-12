using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            //builder.HasKey(m => m.Username);
            builder.Property(m => m.Username)
                    .HasMaxLength(100)
                    .HasAnnotation("MinLength", 3)
                    .IsRequired();
            builder.Property(m => m.Fullname)
                    .HasMaxLength(100)
                    .HasAnnotation("MinLength", 3)
                    .IsRequired();
            builder.Property(m => m.Phone)
                    .HasMaxLength(20)
                    .HasAnnotation("MinLength", 10)
                    .IsRequired();

            builder.Property(m => m.Dateofbirth);

            builder.Property(m => m.UserRole)
                    .IsRequired();

            builder.Property(m => m.Status)
                    .IsRequired();
        }
    }
}