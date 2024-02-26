using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicStore.Migrations
{
    public partial class discountAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Discount",
                table: "Items",
                type: "real",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Items");
        }
    }
}
