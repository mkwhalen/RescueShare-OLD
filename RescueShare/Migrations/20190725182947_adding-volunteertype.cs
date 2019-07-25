using Microsoft.EntityFrameworkCore.Migrations;

namespace RescueShare.Migrations
{
    public partial class addingvolunteertype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDriver",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsRescueWorker",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsShelterWorker",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsVolunteer",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "VolunteerType",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VolunteerType",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<bool>(
                name: "IsDriver",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsRescueWorker",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsShelterWorker",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVolunteer",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);
        }
    }
}
