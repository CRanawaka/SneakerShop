using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SneakerShop.Domain.Entities;

namespace SneakerShop.Infrastructure.Persistence.Configurations;

public class SneakerConfiguration : IEntityTypeConfiguration<Sneaker>
{
    public void Configure(EntityTypeBuilder<Sneaker> builder)
    {
        builder.Property(s => s.Name).IsRequired().HasMaxLength(100);
        builder.Property(s => s.Price).HasColumnType("decimal(18,2)");
    }
}
