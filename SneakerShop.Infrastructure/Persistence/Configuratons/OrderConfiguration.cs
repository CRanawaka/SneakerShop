using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SneakerShop.Domain.Entities;

namespace SneakerShop.Infrastructure.Persistence.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(ci => ci.Id);

        // Fix for decimal precision warning
        builder.Property(o => o.TotalAmount)
               .HasPrecision(18, 2);
    }
}
