using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AiTech.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class migAboutTableIconProprtyNameChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoneyCases");

            migrationBuilder.RenameColumn(
                name: "Icon",
                table: "Abouts",
                newName: "ImageUrl");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Abouts",
                newName: "Icon");

            migrationBuilder.CreateTable(
                name: "MoneyCases",
                columns: table => new
                {
                    MoneyCaseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalAmount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoneyCases", x => x.MoneyCaseID);
                });
        }
    }
}
