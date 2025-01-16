using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blazor_MicroStore.Migrations
{
    /// <inheritdoc />
    public partial class Namechange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Items",
                newName: "Src");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Src",
                table: "Items",
                newName: "ImageUrl");
        }
    }
}
