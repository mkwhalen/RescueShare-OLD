using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RescueShare.Migrations
{
    public partial class addingdefaultconfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransportMember_TransportViewModel_TransportViewModelId",
                table: "TransportMember");

            migrationBuilder.DropTable(
                name: "TransportViewModel");

            migrationBuilder.DropIndex(
                name: "IX_TransportMember_TransportViewModelId",
                table: "TransportMember");

            migrationBuilder.DropColumn(
                name: "TransportViewModelId",
                table: "TransportMember");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TransportViewModelId",
                table: "TransportMember",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TransportViewModel",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    DropoffTime = table.Column<DateTime>(nullable: false),
                    FosterReceiverId = table.Column<string>(nullable: true),
                    FosterSenderId = table.Column<string>(nullable: true),
                    OrganizingRescueId = table.Column<string>(nullable: true),
                    PickupTime = table.Column<DateTime>(nullable: false),
                    ReceiverType = table.Column<int>(nullable: false),
                    RescueReceiverId = table.Column<string>(nullable: true),
                    RescueSenderId = table.Column<string>(nullable: true),
                    SenderType = table.Column<int>(nullable: false),
                    ShelterReceiverId = table.Column<string>(nullable: true),
                    ShelterSenderId = table.Column<string>(nullable: true),
                    TransportTime = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportViewModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransportViewModel_Foster_FosterReceiverId",
                        column: x => x.FosterReceiverId,
                        principalTable: "Foster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransportViewModel_Foster_FosterSenderId",
                        column: x => x.FosterSenderId,
                        principalTable: "Foster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransportViewModel_Rescue_OrganizingRescueId",
                        column: x => x.OrganizingRescueId,
                        principalTable: "Rescue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransportViewModel_Rescue_RescueReceiverId",
                        column: x => x.RescueReceiverId,
                        principalTable: "Rescue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransportViewModel_Rescue_RescueSenderId",
                        column: x => x.RescueSenderId,
                        principalTable: "Rescue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransportViewModel_Shelters_ShelterReceiverId",
                        column: x => x.ShelterReceiverId,
                        principalTable: "Shelters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransportViewModel_Shelters_ShelterSenderId",
                        column: x => x.ShelterSenderId,
                        principalTable: "Shelters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransportViewModel_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TransportMember_TransportViewModelId",
                table: "TransportMember",
                column: "TransportViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportViewModel_FosterReceiverId",
                table: "TransportViewModel",
                column: "FosterReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportViewModel_FosterSenderId",
                table: "TransportViewModel",
                column: "FosterSenderId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportViewModel_OrganizingRescueId",
                table: "TransportViewModel",
                column: "OrganizingRescueId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportViewModel_RescueReceiverId",
                table: "TransportViewModel",
                column: "RescueReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportViewModel_RescueSenderId",
                table: "TransportViewModel",
                column: "RescueSenderId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportViewModel_ShelterReceiverId",
                table: "TransportViewModel",
                column: "ShelterReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportViewModel_ShelterSenderId",
                table: "TransportViewModel",
                column: "ShelterSenderId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportViewModel_UserId",
                table: "TransportViewModel",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TransportMember_TransportViewModel_TransportViewModelId",
                table: "TransportMember",
                column: "TransportViewModelId",
                principalTable: "TransportViewModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
