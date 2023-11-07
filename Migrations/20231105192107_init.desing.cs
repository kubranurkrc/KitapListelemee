using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KitapListelemee.Migrations
{
    /// <inheritdoc />
    public partial class initdesing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Kitaps",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Kitaps",
                newName: "id");
        }
    }
}
