using SneakerShop.Domain.Common;

namespace SneakerShop.Domain.Entities;

public class CartItem : BaseEntity
{
    public Guid SneakerId { get; set; }
    public Sneaker? Sneaker { get; set; }

    public Guid OrderId { get; set; }
    public Order? Order { get; set; }

    public int Quantity { get; set; }
    public decimal Price { get; set; }
}
