using Microsoft.EntityFrameworkCore.Migrations;

namespace RescueShare.Migrations
{
    public partial class changespacetypetospacetype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Spaces");

            migrationBuilder.AddColumn<int>(
                name: "SpaceType",
                table: "Spaces",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpaceType",
                table: "Spaces");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Spaces",
                nullable: false,
                defaultValue: 0);
        }
    }
}
