using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SneakerShop.Domain.Entities;

namespace SneakerShop.Infrastructure.Persistence.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(c => c.Id);

        // Seeding data
        builder.HasData(
            new Category { Id = Guid.Parse("11111111-1111-1111-1111-111111111111"), Name = "Running Shoes" },
            new Category { Id = Guid.Parse("22222222-2222-2222-2222-222222222222"), Name = "Basketball Shoes" },
            new Category { Id = Guid.Parse("33333333-3333-3333-3333-333333333333"), Name = "Casual Sneakers" }
        );
    }
}
