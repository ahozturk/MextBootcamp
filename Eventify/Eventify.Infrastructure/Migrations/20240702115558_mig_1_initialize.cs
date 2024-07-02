using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eventify.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mig_1_initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Location_City = table.Column<string>(type: "text", nullable: false),
                    Location_District = table.Column<string>(type: "text", nullable: false),
                    Location_Street = table.Column<string>(type: "text", nullable: false),
                    Location_No = table.Column<string>(type: "text", nullable: false),
                    Location_PostalCode = table.Column<string>(type: "text", nullable: false),
                    Location_Note = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Location_City", "Location_District", "Location_No", "Location_Note", "Location_PostalCode", "Location_Street", "CreatedAt", "Date", "Description", "Title", "Type", "UpdatedAt" },
                values: new object[] { new Guid("8e90c53b-bf21-4f3f-88ad-dc23c99c5137"), "City 1", "District 1", "12", "Near by Stadium", "12345", "Street 1", new DateTime(2024, 7, 2, 11, 55, 58, 9, DateTimeKind.Utc).AddTicks(4440), new DateTimeOffset(new DateTime(2024, 7, 3, 11, 55, 58, 9, DateTimeKind.Unspecified).AddTicks(4440), new TimeSpan(0, 0, 0, 0, 0)), "Event 1 Description", "Event 1", 2, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
