using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SneakerShop.Infrastructure.Persistence;
using SneakerShop.Domain.Entities;

namespace SneakerShop.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoryController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public CategoryController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetCategories()
    {
        var categories = await _context.Categories.ToListAsync();
        return Ok(categories);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCategory([FromBody] Category category)
    {
        _context.Categories.Add(category);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetCategories), new { id = category.Id }, category);
    }
}
