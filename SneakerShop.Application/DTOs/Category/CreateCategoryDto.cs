using System.ComponentModel.DataAnnotations;

namespace SneakerShop.Application.DTOs.Category;

public class CreateCategoryDto
{
    [Required(ErrorMessage = "Name is required.")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be 2–100 characters long.")]
    public string Name { get; set; } = string.Empty;
}
