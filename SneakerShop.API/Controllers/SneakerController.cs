using Microsoft.AspNetCore.Mvc;
using SneakerShop.Domain.Entities;
using SneakerShop.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;


[Route("api/[controller]")]
[ApiController]
public class SneakersController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public SneakersController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Sneaker>>> GetSneakers()
    {
        return await _context.Sneakers.ToListAsync();
    }
}
