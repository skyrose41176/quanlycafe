using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class BillConfiguration : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.Property(m => m.Id);

            builder.Property(m => m.UsernameStaff)
                    .IsRequired();
            builder.Property(m => m.Total)
                        .IsRequired();
            builder.HasMany(p => p.InfoBill).WithOne(i => i.Bill)
           .HasForeignKey(s => s.IdBill);
        }
    }
}