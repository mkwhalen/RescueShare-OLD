using Microsoft.EntityFrameworkCore.Migrations;

namespace RescueShare.Migrations
{
    public partial class NewTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Breed",
                table: "Dogs",
                newName: "ImageId");

            migrationBuilder.RenameColumn(
                name: "Spaces",
                table: "AspNetUsers",
                newName: "TransportSpace");

            migrationBuilder.AddColumn<string>(
                name: "BreedId",
                table: "Dogs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FosterAges",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FosterAvailability",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FosterBreeds",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FosterSpace",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FosterTemperment",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FosterWeights",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDriver",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsFoster",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVolunteer",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "TransportDayAvailability",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TransportTemperment",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TransportTimeAvailability",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TransportWeights",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DogBreeds",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogBreeds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Data = table.Column<string>(nullable: true),
                    Height = table.Column<int>(nullable: false),
                    Length = table.Column<int>(nullable: false),
                    Width = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserDeniedAges",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AgePuppy = table.Column<bool>(nullable: false),
                    AgeMid = table.Column<bool>(nullable: false),
                    AgeSenior = table.Column<bool>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDeniedAges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDeniedAges_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserDeniedDogWeights",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    WeightClassMini = table.Column<bool>(nullable: false),
                    WeightClassSmall = table.Column<bool>(nullable: false),
                    WeightClassMedium = table.Column<bool>(nullable: false),
                    WeightClassLarge = table.Column<bool>(nullable: false),
                    WieghtClassExtraLarge = table.Column<bool>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDeniedDogWeights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDeniedDogWeights_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserDeniedTemperments",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    GoodWithKids = table.Column<bool>(nullable: false),
                    GoodWithDogs = table.Column<bool>(nullable: false),
                    GoodWithCats = table.Column<bool>(nullable: false),
                    Biter = table.Column<bool>(nullable: false),
                    SpecialNeeds = table.Column<bool>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDeniedTemperments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDeniedTemperments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserDeniedDogBreeds",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    DogBreedId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDeniedDogBreeds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDeniedDogBreeds_DogBreeds_DogBreedId",
                        column: x => x.DogBreedId,
                        principalTable: "DogBreeds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserDeniedDogBreeds_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_BreedId",
                table: "Dogs",
                column: "BreedId");

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_ImageId",
                table: "Dogs",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDeniedAges_UserId",
                table: "UserDeniedAges",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDeniedDogBreeds_DogBreedId",
                table: "UserDeniedDogBreeds",
                column: "DogBreedId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDeniedDogBreeds_UserId",
                table: "UserDeniedDogBreeds",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDeniedDogWeights_UserId",
                table: "UserDeniedDogWeights",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDeniedTemperments_UserId",
                table: "UserDeniedTemperments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_DogBreeds_BreedId",
                table: "Dogs",
                column: "BreedId",
                principalTable: "DogBreeds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_Images_ImageId",
                table: "Dogs",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_DogBreeds_BreedId",
                table: "Dogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_Images_ImageId",
                table: "Dogs");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "UserDeniedAges");

            migrationBuilder.DropTable(
                name: "UserDeniedDogBreeds");

            migrationBuilder.DropTable(
                name: "UserDeniedDogWeights");

            migrationBuilder.DropTable(
                name: "UserDeniedTemperments");

            migrationBuilder.DropTable(
                name: "DogBreeds");

            migrationBuilder.DropIndex(
                name: "IX_Dogs_BreedId",
                table: "Dogs");

            migrationBuilder.DropIndex(
                name: "IX_Dogs_ImageId",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "BreedId",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "FosterAges",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FosterAvailability",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FosterBreeds",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FosterSpace",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FosterTemperment",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FosterWeights",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsDriver",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsFoster",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsVolunteer",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TransportDayAvailability",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TransportTemperment",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TransportTimeAvailability",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TransportWeights",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "ImageId",
                table: "Dogs",
                newName: "Breed");

            migrationBuilder.RenameColumn(
                name: "TransportSpace",
                table: "AspNetUsers",
                newName: "Spaces");
        }
    }
}
