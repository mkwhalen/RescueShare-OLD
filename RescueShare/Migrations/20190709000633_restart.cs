using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RescueShare.Migrations
{
    public partial class restart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    IsShelterWorker = table.Column<bool>(nullable: false),
                    IsRescueWorker = table.Column<bool>(nullable: false),
                    IsVolunteer = table.Column<bool>(nullable: false),
                    IsDriver = table.Column<bool>(nullable: false),
                    TransportDayAvailability = table.Column<string>(nullable: true),
                    TransportTimeAvailability = table.Column<string>(nullable: true),
                    TransportSpace = table.Column<int>(nullable: false),
                    TransportTemperment = table.Column<string>(nullable: true),
                    TransportWeights = table.Column<string>(nullable: true),
                    IsFoster = table.Column<bool>(nullable: false),
                    FosterAvailability = table.Column<string>(nullable: true),
                    FosterSpace = table.Column<int>(nullable: false),
                    FosterBreeds = table.Column<string>(nullable: true),
                    FosterAges = table.Column<string>(nullable: true),
                    FosterWeights = table.Column<string>(nullable: true),
                    FosterTemperment = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "OpportunityTypes",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpportunityTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rescue",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Address1 = table.Column<string>(nullable: false),
                    Address2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(maxLength: 2, nullable: false),
                    Zip = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rescue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shelters",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Address1 = table.Column<string>(nullable: false),
                    Address2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(maxLength: 2, nullable: false),
                    Zip = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shelters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "Opportunities",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    TypeId = table.Column<string>(nullable: true),
                    LocationId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opportunities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Opportunities_Shelters_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Shelters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Opportunities_OpportunityTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "OpportunityTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShelterMembers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    ShelterId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShelterMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShelterMembers_Shelters_ShelterId",
                        column: x => x.ShelterId,
                        principalTable: "Shelters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShelterMembers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Spaces",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Capacity = table.Column<int>(nullable: false),
                    SpaceType = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    ShelterId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spaces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spaces_Shelters_ShelterId",
                        column: x => x.ShelterId,
                        principalTable: "Shelters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transports",
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
                    table.PrimaryKey("PK_Transports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transports_Foster_FosterReceiverId",
                        column: x => x.FosterReceiverId,
                        principalTable: "Foster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transports_Foster_FosterSenderId",
                        column: x => x.FosterSenderId,
                        principalTable: "Foster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transports_Rescue_OrganizingRescueId",
                        column: x => x.OrganizingRescueId,
                        principalTable: "Rescue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transports_Rescue_RescueReceiverId",
                        column: x => x.RescueReceiverId,
                        principalTable: "Rescue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transports_Rescue_RescueSenderId",
                        column: x => x.RescueSenderId,
                        principalTable: "Rescue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transports_Shelters_ShelterReceiverId",
                        column: x => x.ShelterReceiverId,
                        principalTable: "Shelters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transports_Shelters_ShelterSenderId",
                        column: x => x.ShelterSenderId,
                        principalTable: "Shelters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transports_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dogs",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    Age = table.Column<double>(nullable: false),
                    InDate = table.Column<DateTime>(nullable: false),
                    OutDate = table.Column<DateTime>(nullable: false),
                    BreedId = table.Column<string>(nullable: true),
                    CurrentMedications = table.Column<string>(nullable: true),
                    CurrentInjuries = table.Column<string>(nullable: true),
                    Food = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    Flag = table.Column<int>(nullable: false),
                    IsSaved = table.Column<bool>(nullable: false),
                    SpaceId = table.Column<string>(nullable: true),
                    ShelterId = table.Column<string>(nullable: true),
                    ImageId = table.Column<string>(nullable: true),
                    RescueId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dogs_DogBreeds_BreedId",
                        column: x => x.BreedId,
                        principalTable: "DogBreeds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dogs_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dogs_Rescue_RescueId",
                        column: x => x.RescueId,
                        principalTable: "Rescue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dogs_Shelters_ShelterId",
                        column: x => x.ShelterId,
                        principalTable: "Shelters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dogs_Spaces_SpaceId",
                        column: x => x.SpaceId,
                        principalTable: "Spaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TransportMember",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    TransportId = table.Column<string>(nullable: true)
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
                        name: "FK_TransportMember_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_BreedId",
                table: "Dogs",
                column: "BreedId");

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_ImageId",
                table: "Dogs",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_RescueId",
                table: "Dogs",
                column: "RescueId");

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_ShelterId",
                table: "Dogs",
                column: "ShelterId");

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_SpaceId",
                table: "Dogs",
                column: "SpaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Foster_UserId",
                table: "Foster",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunities_LocationId",
                table: "Opportunities",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunities_TypeId",
                table: "Opportunities",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RescueMember_RescueId",
                table: "RescueMember",
                column: "RescueId");

            migrationBuilder.CreateIndex(
                name: "IX_RescueMember_UserId",
                table: "RescueMember",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShelterMembers_ShelterId",
                table: "ShelterMembers",
                column: "ShelterId");

            migrationBuilder.CreateIndex(
                name: "IX_ShelterMembers_UserId",
                table: "ShelterMembers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Spaces_ShelterId",
                table: "Spaces",
                column: "ShelterId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportMember_TransportId",
                table: "TransportMember",
                column: "TransportId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportMember_UserId",
                table: "TransportMember",
                column: "UserId");

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
                name: "IX_Transports_ShelterReceiverId",
                table: "Transports",
                column: "ShelterReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Transports_ShelterSenderId",
                table: "Transports",
                column: "ShelterSenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Transports_UserId",
                table: "Transports",
                column: "UserId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Dogs");

            migrationBuilder.DropTable(
                name: "Opportunities");

            migrationBuilder.DropTable(
                name: "RescueMember");

            migrationBuilder.DropTable(
                name: "ShelterMembers");

            migrationBuilder.DropTable(
                name: "TransportMember");

            migrationBuilder.DropTable(
                name: "UserDeniedAges");

            migrationBuilder.DropTable(
                name: "UserDeniedDogBreeds");

            migrationBuilder.DropTable(
                name: "UserDeniedDogWeights");

            migrationBuilder.DropTable(
                name: "UserDeniedTemperments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Spaces");

            migrationBuilder.DropTable(
                name: "OpportunityTypes");

            migrationBuilder.DropTable(
                name: "Transports");

            migrationBuilder.DropTable(
                name: "DogBreeds");

            migrationBuilder.DropTable(
                name: "Foster");

            migrationBuilder.DropTable(
                name: "Rescue");

            migrationBuilder.DropTable(
                name: "Shelters");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
