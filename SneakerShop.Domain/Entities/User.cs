using SneakerShop.Domain.Common;

namespace SneakerShop.Domain.Entities;

public class User : BaseEntity
{
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string Role { get; set; } = "Customer";

    public ICollection<Order> Orders { get; set; } = new List<Order>();
}
