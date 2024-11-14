using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuctionService.Data.Migrations
{
    /// <inheritdoc />
    public partial class renameColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Modell",
                table: "Items",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "Milage",
                table: "Items",
                newName: "Mileage");

            migrationBuilder.RenameColumn(
                name: "AuctinEnd",
                table: "Auctions",
                newName: "AuctionEnd");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Model",
                table: "Items",
                newName: "Modell");

            migrationBuilder.RenameColumn(
                name: "Mileage",
                table: "Items",
                newName: "Milage");

            migrationBuilder.RenameColumn(
                name: "AuctionEnd",
                table: "Auctions",
                newName: "AuctinEnd");
        }
    }
}
