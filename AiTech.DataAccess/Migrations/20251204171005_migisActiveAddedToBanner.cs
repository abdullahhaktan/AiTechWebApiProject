using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AiTech.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class migisActiveAddedToBanner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Banners",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Banners",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Banners");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Banners");
        }
    }
}
