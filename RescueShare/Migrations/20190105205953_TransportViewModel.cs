using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RescueShare.Migrations
{
    public partial class TransportViewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transports_Shelters_ReceivingShelterId",
                table: "Transports");

            migrationBuilder.DropForeignKey(
                name: "FK_Transports_Shelters_SendingShelterId",
                table: "Transports");

            migrationBuilder.RenameColumn(
                name: "SendingShelterId",
                table: "Transports",
                newName: "ShelterSenderId");

            migrationBuilder.RenameColumn(
                name: "ReceivingShelterId",
                table: "Transports",
                newName: "ShelterReceiverId");

            migrationBuilder.RenameIndex(
                name: "IX_Transports_SendingShelterId",
                table: "Transports",
                newName: "IX_Transports_ShelterSenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Transports_ReceivingShelterId",
                table: "Transports",
                newName: "IX_Transports_ShelterReceiverId");

            migrationBuilder.AddColumn<string>(
                name: "FosterReceiverId",
                table: "Transports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FosterSenderId",
                table: "Transports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrganizingRescueId",
                table: "Transports",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReceiverType",
                table: "Transports",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RescueReceiverId",
                table: "Transports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RescueSenderId",
                table: "Transports",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SenderType",
                table: "Transports",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RescueId",
                table: "Dogs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

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

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Foster",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foster", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foster_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rescue",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address1 = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(maxLength: 2, nullable: true),
                    Zip = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rescue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RescueMember",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    RescueId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RescueMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RescueMember_Rescue_RescueId",
                        column: x => x.RescueId,
                        principalTable: "Rescue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RescueMember_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TransportViewModel",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    PickupTime = table.Column<DateTime>(nullable: false),
                    DropoffTime = table.Column<DateTime>(nullable: false),
                    TransportTime = table.Column<DateTime>(nullable: false),
                    ShelterSenderId = table.Column<string>(nullable: true),
                    ShelterReceiverId = table.Column<string>(nullable: true),
                    FosterSenderId = table.Column<string>(nullable: true),
                    FosterReceiverId = table.Column<string>(nullable: true),
                    RescueSenderId = table.Column<string>(nullable: true),
                    RescueReceiverId = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    ReceiverType = table.Column<int>(nullable: false),
                    SenderType = table.Column<int>(nullable: false),
                    OrganizingRescueId = table.Column<string>(nullable: true)
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

            migrationBuilder.CreateTable(
                name: "TransportMember",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    TransportId = table.Column<string>(nullable: true),
                    TransportViewModelId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransportMember_Transports_TransportId",
                        column: x => x.TransportId,
                        principalTable: "Transports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransportMember_TransportViewModel_TransportViewModelId",
                        column: x => x.TransportViewModelId,
                        principalTable: "TransportViewModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransportMember_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transports_FosterReceiverId",
                table: "Transports",
                column: "FosterReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Transports_FosterSenderId",
                table: "Transports",
                column: "FosterSenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Transports_OrganizingRescueId",
                table: "Transports",
                column: "OrganizingRescueId");

            migrationBuilder.CreateIndex(
                name: "IX_Transports_RescueReceiverId",
                table: "Transports",
                column: "RescueReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Transports_RescueSenderId",
                table: "Transports",
                column: "RescueSenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_RescueId",
                table: "Dogs",
                column: "RescueId");

            migrationBuilder.CreateIndex(
                name: "IX_Foster_UserId",
                table: "Foster",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RescueMember_RescueId",
                table: "RescueMember",
                column: "RescueId");

            migrationBuilder.CreateIndex(
                name: "IX_RescueMember_UserId",
                table: "RescueMember",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportMember_TransportId",
                table: "TransportMember",
                column: "TransportId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportMember_TransportViewModelId",
                table: "TransportMember",
                column: "TransportViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportMember_UserId",
                table: "TransportMember",
                column: "UserId");

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
                name: "FK_Dogs_Rescue_RescueId",
                table: "Dogs",
                column: "RescueId",
                principalTable: "Rescue",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transports_Foster_FosterReceiverId",
                table: "Transports",
                column: "FosterReceiverId",
                principalTable: "Foster",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transports_Foster_FosterSenderId",
                table: "Transports",
                column: "FosterSenderId",
                principalTable: "Foster",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transports_Rescue_OrganizingRescueId",
                table: "Transports",
                column: "OrganizingRescueId",
                principalTable: "Rescue",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transports_Rescue_RescueReceiverId",
                table: "Transports",
                column: "RescueReceiverId",
                principalTable: "Rescue",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transports_Rescue_RescueSenderId",
                table: "Transports",
                column: "RescueSenderId",
                principalTable: "Rescue",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transports_Shelters_ShelterReceiverId",
                table: "Transports",
                column: "ShelterReceiverId",
                principalTable: "Shelters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transports_Shelters_ShelterSenderId",
                table: "Transports",
                column: "ShelterSenderId",
                principalTable: "Shelters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_Rescue_RescueId",
                table: "Dogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Transports_Foster_FosterReceiverId",
                table: "Transports");

            migrationBuilder.DropForeignKey(
                name: "FK_Transports_Foster_FosterSenderId",
                table: "Transports");

            migrationBuilder.DropForeignKey(
                name: "FK_Transports_Rescue_OrganizingRescueId",
                table: "Transports");

            migrationBuilder.DropForeignKey(
                name: "FK_Transports_Rescue_RescueReceiverId",
                table: "Transports");

            migrationBuilder.DropForeignKey(
                name: "FK_Transports_Rescue_RescueSenderId",
                table: "Transports");

            migrationBuilder.DropForeignKey(
                name: "FK_Transports_Shelters_ShelterReceiverId",
                table: "Transports");

            migrationBuilder.DropForeignKey(
                name: "FK_Transports_Shelters_ShelterSenderId",
                table: "Transports");

            migrationBuilder.DropTable(
                name: "RescueMember");

            migrationBuilder.DropTable(
                name: "TransportMember");

            migrationBuilder.DropTable(
                name: "TransportViewModel");

            migrationBuilder.DropTable(
                name: "Foster");

            migrationBuilder.DropTable(
                name: "Rescue");

            migrationBuilder.DropIndex(
                name: "IX_Transports_FosterReceiverId",
                table: "Transports");

            migrationBuilder.DropIndex(
                name: "IX_Transports_FosterSenderId",
                table: "Transports");

            migrationBuilder.DropIndex(
                name: "IX_Transports_OrganizingRescueId",
                table: "Transports");

            migrationBuilder.DropIndex(
                name: "IX_Transports_RescueReceiverId",
                table: "Transports");

            migrationBuilder.DropIndex(
                name: "IX_Transports_RescueSenderId",
                table: "Transports");

            migrationBuilder.DropIndex(
                name: "IX_Dogs_RescueId",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "FosterReceiverId",
                table: "Transports");

            migrationBuilder.DropColumn(
                name: "FosterSenderId",
                table: "Transports");

            migrationBuilder.DropColumn(
                name: "OrganizingRescueId",
                table: "Transports");

            migrationBuilder.DropColumn(
                name: "ReceiverType",
                table: "Transports");

            migrationBuilder.DropColumn(
                name: "RescueReceiverId",
                table: "Transports");

            migrationBuilder.DropColumn(
                name: "RescueSenderId",
                table: "Transports");

            migrationBuilder.DropColumn(
                name: "SenderType",
                table: "Transports");

            migrationBuilder.DropColumn(
                name: "RescueId",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsRescueWorker",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsShelterWorker",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "ShelterSenderId",
                table: "Transports",
                newName: "SendingShelterId");

            migrationBuilder.RenameColumn(
                name: "ShelterReceiverId",
                table: "Transports",
                newName: "ReceivingShelterId");

            migrationBuilder.RenameIndex(
                name: "IX_Transports_ShelterSenderId",
                table: "Transports",
                newName: "IX_Transports_SendingShelterId");

            migrationBuilder.RenameIndex(
                name: "IX_Transports_ShelterReceiverId",
                table: "Transports",
                newName: "IX_Transports_ReceivingShelterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transports_Shelters_ReceivingShelterId",
                table: "Transports",
                column: "ReceivingShelterId",
                principalTable: "Shelters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transports_Shelters_SendingShelterId",
                table: "Transports",
                column: "SendingShelterId",
                principalTable: "Shelters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
