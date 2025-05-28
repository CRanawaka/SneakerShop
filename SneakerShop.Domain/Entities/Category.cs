using SneakerShop.Domain.Common;

namespace SneakerShop.Domain.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public ICollection<Sneaker> Sneakers { get; set; } = new List<Sneaker>();
}
