using SneakerShop.Domain.Common;

namespace SneakerShop.Domain.Entities;

public class Order : BaseEntity
{
    public Guid UserId { get; set; }
    public User? User { get; set; }

    public DateTime OrderDate { get; set; } = DateTime.UtcNow;
    public decimal TotalAmount { get; set; }

    public ICollection<CartItem> Items { get; set; } = new List<CartItem>();
}
