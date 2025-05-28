using SneakerShop.Domain.Common;

namespace SneakerShop.Domain.Entities;

public class Sneaker : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Brand { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string ImageUrl { get; set; } = string.Empty;

    // Relationships
    public Guid CategoryId { get; set; }
    public Category? Category { get; set; }
}
