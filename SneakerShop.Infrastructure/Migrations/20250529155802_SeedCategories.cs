using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SneakerShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2025, 5, 29, 15, 58, 1, 467, DateTimeKind.Utc).AddTicks(3934), "Running Shoes" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2025, 5, 29, 15, 58, 1, 467, DateTimeKind.Utc).AddTicks(4613), "Basketball Shoes" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2025, 5, 29, 15, 58, 1, 467, DateTimeKind.Utc).AddTicks(4621), "Casual Sneakers" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));
        }
    }
}
