using SneakerShop.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configure DB (using LocalDB here)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        b => b.MigrationsAssembly("SneakerShop.Infrastructure")
    ));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp",
        builder => builder.WithOrigins("http://localhost:5173")
                          .AllowAnyHeader()
                          .AllowAnyMethod());
});

// ✅ Add this line to support controllers
builder.Services.AddControllers();

var app = builder.Build();

app.UseCors("AllowReactApp");

// ✅ Map controller routes
app.MapControllers();

// Optional: health check on root URL
app.MapGet("/", () => "SneakerShop API Running 🚀");

app.Run();
