using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class InfoBillConfiguration : IEntityTypeConfiguration<InfoBill>
    {
        public void Configure(EntityTypeBuilder<InfoBill> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Id);

            builder.Property(m => m.IdProduct);

            builder.Property(m => m.IdBill);   

            builder.Property(m => m.SL);

            builder.Property(m => m.Price);
            

        }
    }
}