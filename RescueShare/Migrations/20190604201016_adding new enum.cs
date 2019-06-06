using Microsoft.EntityFrameworkCore.Migrations;

namespace RescueShare.Migrations
{
    public partial class addingnewenum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Spaces",
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Spaces",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
