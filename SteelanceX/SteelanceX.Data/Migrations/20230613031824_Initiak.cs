using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SteelanceX.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initiak : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPremium = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "BusinessProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessProfiles_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FreelancerProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResumeUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreelancerProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FreelancerProfiles_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Offer = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplyExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BusinessProfileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Job_BusinessProfiles_BusinessProfileId",
                        column: x => x.BusinessProfileId,
                        principalTable: "BusinessProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FreelancerCategories",
                columns: table => new
                {
                    FreelancerProfileId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreelancerCategories", x => new { x.FreelancerProfileId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_FreelancerCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FreelancerCategories_FreelancerProfiles_FreelancerProfileId",
                        column: x => x.FreelancerProfileId,
                        principalTable: "FreelancerProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JobId = table.Column<int>(type: "int", nullable: false),
                    FreelancerProfileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Applications_FreelancerProfiles_FreelancerProfileId",
                        column: x => x.FreelancerProfileId,
                        principalTable: "FreelancerProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Applications_Job_JobId",
                        column: x => x.JobId,
                        principalTable: "Job",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobCategories",
                columns: table => new
                {
                    JobId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobCategories", x => new { x.JobId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_JobCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobCategories_Job_JobId",
                        column: x => x.JobId,
                        principalTable: "Job",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobProgress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsFinish = table.Column<bool>(type: "bit", nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedFinishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JobId = table.Column<int>(type: "int", nullable: false),
                    FreelancerProfileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobProgress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobProgress_FreelancerProfiles_FreelancerProfileId",
                        column: x => x.FreelancerProfileId,
                        principalTable: "FreelancerProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JobProgress_Job_JobId",
                        column: x => x.JobId,
                        principalTable: "Job",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "Business", "business" },
                    { 2, null, "Freelancer", "freelancer" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "IsPremium", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "HCM", "255359a8-289d-4c0b-88c8-9f078ff727c5", "normaluser1@gmail.com", true, "1", true, "Nguyen Van", false, null, "normaluser1@gmail.com", "normalUser1", "AQAAAAIAAYagAAAAECOsf+RrYndzQvb3JtD9FCnNTOQ4GayxpCwCRUk8YXAKO29S0kDgSshl2aTEdHio4g==", null, false, "", false, "normalUser1" },
                    { 2, 0, "HCM", "b2428c70-7ec1-48ac-af60-0c6e1a6c5f9c", "normaluser2@gmail.com", true, "2", true, "Nguyen Van", false, null, "normaluser2@gmail.com", "normalUser2", "AQAAAAIAAYagAAAAEEiWpx3FsaCLQ+JmOsGLtQA7OFzrDSQvskfNppi9t8ArkpB31n14B4Vp4ABKEYHDWA==", null, false, "", false, "normalUser2" },
                    { 3, 0, "HCM", "3323be41-8a31-4032-b893-c89d4c76c7c9", "normaluser3@gmail.com", true, "3", true, "Nguyen Van", false, null, "normaluser3@gmail.com", "normalUser3", "AQAAAAIAAYagAAAAELImpSoh3jDhP2OpB5VHNjCWMTeR1gHo5rbg3AfbVjqwHONvS4vJpE1/HpAy72ayHA==", null, false, "", false, "normalUser3" },
                    { 4, 0, "HCM", "30c6d975-03cd-48bb-9b9d-1a93491a82c9", "normaluser4@gmail.com", true, "4", true, "Nguyen Van", false, null, "normaluser4@gmail.com", "normalUser4", "AQAAAAIAAYagAAAAENZ2gddiLqz+IVGBdppNWY3jBOi/ac8rgLUHoWwBQm2CJjZ9Qx+I3kOOXtOr6hf7WA==", null, false, "", false, "normalUser4" },
                    { 5, 0, "HCM", "041d4b14-f441-45be-8714-e15e6f3148d6", "normaluser5@gmail.com", true, "5", true, "Nguyen Van", false, null, "normaluser5@gmail.com", "normalUser5", "AQAAAAIAAYagAAAAEETIvLGhikRmFHYWAXviGr+CVPv6XgWobuW2YRG+x29eeCPTPVjbVVVvEH2u0spq4A==", null, false, "", false, "normalUser5" },
                    { 6, 0, "HCM", "b7fdf7b4-4a33-4f58-9344-b2825842bd97", "normaluser6@gmail.com", true, "6", true, "Nguyen Van", false, null, "normaluser6@gmail.com", "normalUser6", "AQAAAAIAAYagAAAAEEatbU98BFPvfrcRzRubKi11i/VcooQAPIvqmcuFM+8obWWIq+UdPYFDq3R9ARPKXQ==", null, false, "", false, "normalUser6" },
                    { 7, 0, "HCM", "92a807e3-3296-4963-8a23-7f8003550a87", "normaluser7@gmail.com", true, "7", true, "Nguyen Van", false, null, "normaluser7@gmail.com", "normalUser7", "AQAAAAIAAYagAAAAEGQHg1g9D/SrV4QzMg4GXlsnHFnUnJetC0gGVwmrgrGD3Z4+/TRJYvv/nMFJpctqgQ==", null, false, "", false, "normalUser7" },
                    { 8, 0, "HCM", "b5d2e9f4-1587-4667-a0b7-aa649ac9d62c", "normaluser8@gmail.com", true, "8", true, "Nguyen Van", false, null, "normaluser8@gmail.com", "normalUser8", "AQAAAAIAAYagAAAAENeh1beEMkJfvEUK1+9dvKyaii1dJoGXkTheZqY3CwIl9swnEHXBa1TTbNxBDTiTNA==", null, false, "", false, "normalUser8" },
                    { 9, 0, "HCM", "80ce38f8-42ff-4f2e-b7fb-395740f683e3", "normaluser9@gmail.com", true, "9", true, "Nguyen Van", false, null, "normaluser9@gmail.com", "normalUser9", "AQAAAAIAAYagAAAAEF46wda+Web0XRwnvmUZ32SVwNKIg+zq/8iTNQ1NJ8Kzwr2+wx+Bjci4MzLSl4jdGA==", null, false, "", false, "normalUser9" },
                    { 10, 0, "HCM", "7ba7e437-8fd6-4523-8683-66b6fdf22148", "normaluser10@gmail.com", true, "10", true, "Nguyen Van", false, null, "normaluser10@gmail.com", "normalUser10", "AQAAAAIAAYagAAAAEHHZJjjhW673CvQPkp5NmxtrBi8KA3p/cFxYG+iI9N9TPNOfLAeQjvOs7+0uoCVMIg==", null, false, "", false, "normalUser10" },
                    { 11, 0, "HCM", "3ae7ebc7-2772-4dd0-b690-c391e5eae5ab", "normaluser11@gmail.com", true, "11", true, "Nguyen Van", false, null, "normaluser11@gmail.com", "normalUser11", "AQAAAAIAAYagAAAAELNRBswOIApnUS0iE2ROaHJu5LZ25Dw6cnvbaVCjC7NSHWV4LNBfz4h0gU0WQtAH8Q==", null, false, "", false, "normalUser11" },
                    { 12, 0, "HCM", "43c0f740-edd2-4b28-996d-69a7ac2324a3", "normaluser12@gmail.com", true, "12", true, "Nguyen Van", false, null, "normaluser12@gmail.com", "normalUser12", "AQAAAAIAAYagAAAAEDxzx63tmYp1pkJEmfwG63MXRTmsma40OGF1Ymtfq7IDOFfu13PYK+XMCIP76nCrOA==", null, false, "", false, "normalUser12" },
                    { 13, 0, "HCM", "d4ee6a79-7abf-40a5-b0b1-3ed8672c3e36", "normaluser13@gmail.com", true, "13", true, "Nguyen Van", false, null, "normaluser13@gmail.com", "normalUser13", "AQAAAAIAAYagAAAAEM7uD9X2iVZEEasnMTD66qHYIA8RFP3mBoXVickzmqYwFio4M32o6UCQ4iic/PnZiA==", null, false, "", false, "normalUser13" },
                    { 14, 0, "HCM", "18c2180d-533e-4edf-80cb-c901f342bad8", "normaluser14@gmail.com", true, "14", true, "Nguyen Van", false, null, "normaluser14@gmail.com", "normalUser14", "AQAAAAIAAYagAAAAEIIZ+Frb/BOazTtO89x+g16HZFcOG07ZV1SiQt2xhMGveSP8bw6TRZennZQRb10F6A==", null, false, "", false, "normalUser14" },
                    { 15, 0, "HCM", "a17ceb1a-1a28-49b3-a552-f520f73be16e", "normaluser15@gmail.com", true, "15", true, "Nguyen Van", false, null, "normaluser15@gmail.com", "normalUser15", "AQAAAAIAAYagAAAAEBH49WbivCMqvdRICpYkg38rGBvMuuZYyi0bSnLvLvfMdfFAUv43PyGRAEiyl7Q9qg==", null, false, "", false, "normalUser15" },
                    { 16, 0, "HCM", "2763361a-3b4d-45e1-9f38-35acd2add990", "normaluser16@gmail.com", true, "16", true, "Nguyen Van", false, null, "normaluser16@gmail.com", "normalUser16", "AQAAAAIAAYagAAAAEP3INxDaPVx00Dndns/rnf7C+9mtwX1vrqklatAO6CRTe5yVgCpmSDKZYg/Tgg8cAg==", null, false, "", false, "normalUser16" },
                    { 17, 0, "HCM", "18196bfe-3a1c-4f62-94f4-3a0be4dee327", "normaluser17@gmail.com", true, "17", true, "Nguyen Van", false, null, "normaluser17@gmail.com", "normalUser17", "AQAAAAIAAYagAAAAEAz9D6TnIaeKxusDwjp6D9hqqlrGX4/MBedwkRPVqB/x0yA3AZc5EE0fPRmg914Uog==", null, false, "", false, "normalUser17" },
                    { 18, 0, "HCM", "28519348-2a6a-4eb8-a228-27a727dec949", "normaluser18@gmail.com", true, "18", true, "Nguyen Van", false, null, "normaluser18@gmail.com", "normalUser18", "AQAAAAIAAYagAAAAEDsPrB6ZVNl1pR/O4MfxmvqLBU1hw3AUu9M26GaXFrlI5gNGsF4OlfqcU2PcJcIHBg==", null, false, "", false, "normalUser18" },
                    { 19, 0, "HCM", "6b574487-eab0-4a0b-9b02-f71ad191ae89", "normaluser19@gmail.com", true, "19", true, "Nguyen Van", false, null, "normaluser19@gmail.com", "normalUser19", "AQAAAAIAAYagAAAAEBh7/Ao5wwM9TE1qqDJNZmX83o2H52LcqY6+lGOkGARfRcglOHJ8UMYSMlSdw50QJA==", null, false, "", false, "normalUser19" },
                    { 20, 0, "HCM", "97c1bf5c-72eb-47b5-8364-581dc1eb96fb", "normaluser20@gmail.com", true, "20", true, "Nguyen Van", false, null, "normaluser20@gmail.com", "normalUser20", "AQAAAAIAAYagAAAAEISiQ8CFprhDh8kRp27d0sikSPbhxUdfoKmfSfDjYaIkaUsm7HC6ZxjfgmF8DUx/YQ==", null, false, "", false, "normalUser20" },
                    { 21, 0, "HCM", "8c48840c-f63c-463e-8e02-3cd2a12c95bb", "normaluser21@gmail.com", true, "21", true, "Nguyen Van", false, null, "normaluser21@gmail.com", "normalUser21", "AQAAAAIAAYagAAAAEI6pHvO7cCzXuN7WaWwvfwdjVXbt3ktTC+AYYSEePJqqtWsVtA/2efkXv2TQmUbBHQ==", null, false, "", false, "normalUser21" },
                    { 22, 0, "HCM", "ccde15d4-cb14-4de5-8b65-36f3f24bf2fd", "normaluser22@gmail.com", true, "22", true, "Nguyen Van", false, null, "normaluser22@gmail.com", "normalUser22", "AQAAAAIAAYagAAAAEPOJkjQdQS6kM/260GGQ4/V59uzIeLpO5PaCT7HR4nN5k7pcTQM9dFh4LF1pxa/D9w==", null, false, "", false, "normalUser22" },
                    { 23, 0, "HCM", "4c7984b5-fa35-41f3-bdb5-97815f7eaf7f", "normaluser23@gmail.com", true, "23", true, "Nguyen Van", false, null, "normaluser23@gmail.com", "normalUser23", "AQAAAAIAAYagAAAAEJqsQYZDAHrSW2Nfd8E+s7ujJyljOxaGDoqjWCX3lvur0tzGt8LQSTjEcTofv4eH1Q==", null, false, "", false, "normalUser23" },
                    { 24, 0, "HCM", "faaa5e79-179b-4957-be56-2e9f65e406c2", "normaluser24@gmail.com", true, "24", true, "Nguyen Van", false, null, "normaluser24@gmail.com", "normalUser24", "AQAAAAIAAYagAAAAECoPPxXIugMePUCiDbDqii3mhQ1kHLtYM4fvO78N2RZXAEYS7BUEjnjoIEWlx+639w==", null, false, "", false, "normalUser24" },
                    { 25, 0, "HCM", "388b007f-fec2-4397-9977-8f98f78017f8", "normaluser25@gmail.com", true, "25", true, "Nguyen Van", false, null, "normaluser25@gmail.com", "normalUser25", "AQAAAAIAAYagAAAAEFEPmGKLlqd1CnGyqNB91PaGElfGfqCGCgV9KYDtn/L9ETJdsWSu7zJ8S5J/LVGc2Q==", null, false, "", false, "normalUser25" },
                    { 26, 0, "HCM", "f2a1cef0-c5a6-48a6-af7e-15fae549c267", "normaluser26@gmail.com", true, "26", true, "Nguyen Van", false, null, "normaluser26@gmail.com", "normalUser26", "AQAAAAIAAYagAAAAEJRmovvNyWyt1P0dxMhSQ1JNd9ZJtbLCfoTQBmzCgwxolDgCmfFAOspQHgQKPByiaA==", null, false, "", false, "normalUser26" },
                    { 27, 0, "HCM", "92f714fe-19df-4920-8788-f6df94d3db7e", "normaluser27@gmail.com", true, "27", true, "Nguyen Van", false, null, "normaluser27@gmail.com", "normalUser27", "AQAAAAIAAYagAAAAEEydQIdnAd1w51SXjgXb1sac8NjGBGNp6u+ZYlN1hxBpO4vgsxWUerlm4wL/koi0Jw==", null, false, "", false, "normalUser27" },
                    { 28, 0, "HCM", "ef8c89e7-7076-4cac-9c1a-3d8ee4a4883e", "normaluser28@gmail.com", true, "28", true, "Nguyen Van", false, null, "normaluser28@gmail.com", "normalUser28", "AQAAAAIAAYagAAAAED/15LgFTxfq0zuk3rzg/rfpDxchZ7l7XJUaIZQMDoCJS2yTGvCQgB4gRgjyWyp5Iw==", null, false, "", false, "normalUser28" },
                    { 29, 0, "HCM", "6216e1bb-d181-4e98-9e80-3bbf8d3f9848", "normaluser29@gmail.com", true, "29", true, "Nguyen Van", false, null, "normaluser29@gmail.com", "normalUser29", "AQAAAAIAAYagAAAAEOiunNJwmyNFYQVVVYzWVbeScHFA60wfSBJ0AR6SMDW6xKaqlhBSO8AzT10o5vZeng==", null, false, "", false, "normalUser29" },
                    { 30, 0, "HCM", "53ab2b62-6704-49b8-8603-bd228f8c495b", "normaluser30@gmail.com", true, "30", true, "Nguyen Van", false, null, "normaluser30@gmail.com", "normalUser30", "AQAAAAIAAYagAAAAEHRieHsSeqcComawGqw0L2jOu2zyWT3ZKo8ycm17suCdxYG58I64/0TAHfZdYerT8A==", null, false, "", false, "normalUser30" },
                    { 31, 0, "HCM", "36fe087d-571d-4aa0-bd7e-274765b3b8ec", "normaluser31@gmail.com", true, "31", true, "Nguyen Van", false, null, "normaluser31@gmail.com", "normalUser31", "AQAAAAIAAYagAAAAEA4701C7wG9JzKAEy5f+RO9YmhiHDXYc+pdk+4DiZUAXVeJxGvCddOwfwTHMPdaF1g==", null, false, "", false, "normalUser31" },
                    { 32, 0, "HCM", "806f74fd-e940-479c-ab4f-c5bcc5eb9bb7", "normaluser32@gmail.com", true, "32", true, "Nguyen Van", false, null, "normaluser32@gmail.com", "normalUser32", "AQAAAAIAAYagAAAAEBF215d9Wid++i52GdZxjunQzIZ94BH0ED6Q6NghoTOm+b8tcBq5wGLHcLC8ppeWUw==", null, false, "", false, "normalUser32" },
                    { 33, 0, "HCM", "902e8029-7187-4f92-a537-a60769d5ada6", "normaluser33@gmail.com", true, "33", true, "Nguyen Van", false, null, "normaluser33@gmail.com", "normalUser33", "AQAAAAIAAYagAAAAEIFQHeZ/nm9kslWNr++flRT6ahDEToTg/M5WPMEC+ph1WzWNa6PYInYRihnCTH8iMA==", null, false, "", false, "normalUser33" },
                    { 34, 0, "HCM", "ffec9e39-b5e1-4f46-9ab2-1cb3a2af403a", "normaluser34@gmail.com", true, "34", true, "Nguyen Van", false, null, "normaluser34@gmail.com", "normalUser34", "AQAAAAIAAYagAAAAEKMlaw9ndjRqywEc+QNTgJmgw6iVXd4unMtq66MMazjEulLsGyarw3dBx7W1xgLCpw==", null, false, "", false, "normalUser34" },
                    { 35, 0, "HCM", "4bc2eff7-bd82-441b-8f2b-8efea151e70a", "normaluser35@gmail.com", true, "35", true, "Nguyen Van", false, null, "normaluser35@gmail.com", "normalUser35", "AQAAAAIAAYagAAAAECuKnxOMeevnyI3ylypuvZOVvGlp2xtiDGfXWbMiyzwJxPNMHw2f4lipMuHgAO1hWQ==", null, false, "", false, "normalUser35" },
                    { 36, 0, "HCM", "e4822ae1-e0ab-4e70-9886-e4b1794fc4ef", "normaluser36@gmail.com", true, "36", true, "Nguyen Van", false, null, "normaluser36@gmail.com", "normalUser36", "AQAAAAIAAYagAAAAEMkyPGiJURYjto1jsr+iphi1OWy120a0qOG7Dwf1BvQlCp5eNDRW+AStW6eaidkC3w==", null, false, "", false, "normalUser36" },
                    { 37, 0, "HCM", "22e4fdf6-a3dd-46e2-898c-dfa85d5c76cb", "normaluser37@gmail.com", true, "37", true, "Nguyen Van", false, null, "normaluser37@gmail.com", "normalUser37", "AQAAAAIAAYagAAAAECGO5geTq80G6vfCjHtAqM5galkj7kmonlSwzHkngBEscMRm2cBFo5USZmFM5ffG/w==", null, false, "", false, "normalUser37" },
                    { 38, 0, "HCM", "d40a49b6-0a88-458e-aa69-461bb98b32d7", "normaluser38@gmail.com", true, "38", true, "Nguyen Van", false, null, "normaluser38@gmail.com", "normalUser38", "AQAAAAIAAYagAAAAEIfV99HmDP7ABG4F5It7+DdP7/ayspuRr7Vc2AZ3E8S1C7mroB1mvGc0ww9wWvv4qg==", null, false, "", false, "normalUser38" },
                    { 39, 0, "HCM", "f2b62439-995f-41c1-b924-068937245019", "normaluser39@gmail.com", true, "39", true, "Nguyen Van", false, null, "normaluser39@gmail.com", "normalUser39", "AQAAAAIAAYagAAAAEH5nMF7GgAd+p9zOfziZMnApNQIBma+11KsqbYYktaXlqaeHIgYoM1w2+aZdyRz8+g==", null, false, "", false, "normalUser39" },
                    { 40, 0, "HCM", "50d70491-6ba9-4fd6-ac95-092345029bfe", "normaluser40@gmail.com", true, "40", true, "Nguyen Van", false, null, "normaluser40@gmail.com", "normalUser40", "AQAAAAIAAYagAAAAEMLOtnLCYLHAQwybewZoQRt7ab76luDd2Xjt+FfXmvgirFG8A09aH6XlVUAWIeLgNA==", null, false, "", false, "normalUser40" },
                    { 41, 0, "HCM", "299cd7d7-2ce5-46a0-900e-35d025d36346", "normaluser41@gmail.com", true, "41", true, "Nguyen Van", false, null, "normaluser41@gmail.com", "normalUser41", "AQAAAAIAAYagAAAAEA1KcxWK8KzkDJWVs/ka9SbF0+uWn3pbG5zzeSSCGkR0kj/RGAKMRiqlGa1KQh84cw==", null, false, "", false, "normalUser41" },
                    { 42, 0, "HCM", "0c3d9b7c-7e5e-4ba6-9439-2c9935fed0ac", "normaluser42@gmail.com", true, "42", true, "Nguyen Van", false, null, "normaluser42@gmail.com", "normalUser42", "AQAAAAIAAYagAAAAEEeL5b0gnakaXz+Iiad1t2/MeU/C4hG2NRBm/tMUaUP6YIRfQwgYmHTv0HMPj97HPA==", null, false, "", false, "normalUser42" },
                    { 43, 0, "HCM", "36556e09-0a05-40ca-9a01-4f1f0a542204", "normaluser43@gmail.com", true, "43", true, "Nguyen Van", false, null, "normaluser43@gmail.com", "normalUser43", "AQAAAAIAAYagAAAAELyf6AOza5oDvaA2g1bO0fuIcI3gj4y2H2w8pjqu8yt3IWFp6OAYU7Ms3x2yQh1qCg==", null, false, "", false, "normalUser43" },
                    { 44, 0, "HCM", "78d09b96-e28d-413c-ad4b-65149aa3ae28", "normaluser44@gmail.com", true, "44", true, "Nguyen Van", false, null, "normaluser44@gmail.com", "normalUser44", "AQAAAAIAAYagAAAAEOu4slQ1d4XObecri07Xt6QJIQKn/qoia05vFfQv7zKrn3+ZN2Rv9JZhMDnT5i51hw==", null, false, "", false, "normalUser44" },
                    { 45, 0, "HCM", "3bf19c17-0928-428b-bcec-99c137f76a7a", "normaluser45@gmail.com", true, "45", true, "Nguyen Van", false, null, "normaluser45@gmail.com", "normalUser45", "AQAAAAIAAYagAAAAEPL+KYxI5eWb+qHWcnGfxKzGRQ3jRzKzqS2yUgD9LgwD5xOLwm73tZtFs/ysExExdQ==", null, false, "", false, "normalUser45" },
                    { 46, 0, "HCM", "67b09de0-93f2-4bf5-a7b6-e252f2e5ed52", "normaluser46@gmail.com", true, "46", true, "Nguyen Van", false, null, "normaluser46@gmail.com", "normalUser46", "AQAAAAIAAYagAAAAEEWfmOZM51H2IcVEXpZNjLJh/jjixK6z0KkNb5Pez/x2oM2JrjiMFGIjsFI5Ebxswg==", null, false, "", false, "normalUser46" },
                    { 47, 0, "HCM", "f10b7d56-b93d-4105-9e58-1619fdd92352", "normaluser47@gmail.com", true, "47", true, "Nguyen Van", false, null, "normaluser47@gmail.com", "normalUser47", "AQAAAAIAAYagAAAAEMiR1OpatONM3rw4mgIN7ppErLP11f5XehrabQcACe0P9bJitTJHxll2/yjSJWcg0w==", null, false, "", false, "normalUser47" },
                    { 48, 0, "HCM", "ccab6323-2d56-4b7b-92d0-bea63cdbce7a", "normaluser48@gmail.com", true, "48", true, "Nguyen Van", false, null, "normaluser48@gmail.com", "normalUser48", "AQAAAAIAAYagAAAAENa4Nxckh6clAmhDfl/wq9EHNA0p2OeDMYYqcAKF9BlVb235VPKbuJkNoda8SIyFDg==", null, false, "", false, "normalUser48" },
                    { 49, 0, "HCM", "f5be93cf-3ec2-4da1-a911-2cd13a4bb3a7", "normaluser49@gmail.com", true, "49", true, "Nguyen Van", false, null, "normaluser49@gmail.com", "normalUser49", "AQAAAAIAAYagAAAAEKfMzRt3EeAHvnFqe0Yi4TQqGcx2exx18vl2i6+dTBhMRSJsQPfhADrFKz1nCh3Eqg==", null, false, "", false, "normalUser49" },
                    { 50, 0, "HCM", "8e806999-7547-45bf-bb13-cbaa24fe8dc8", "normaluser50@gmail.com", true, "50", true, "Nguyen Van", false, null, "normaluser50@gmail.com", "normalUser50", "AQAAAAIAAYagAAAAELUu4ESy1BG9oElj7CxC9QfAsDRKuQSM2J2tDN/K77rDgG8Y8fynoTc9TgVql4ODRQ==", null, false, "", false, "normalUser50" },
                    { 51, 0, "HCM", "d30f1a62-2c28-44e1-b895-93a70004fb31", "normaluser51@gmail.com", true, "51", true, "Nguyen Van", false, null, "normaluser51@gmail.com", "normalUser51", "AQAAAAIAAYagAAAAEJp86JaJ5Gz1hm2rMX7LOq2i1XQc22vwpD2G/9UkFn0YUyVX0A+BMGVmtKDEm8haUw==", null, false, "", false, "normalUser51" },
                    { 52, 0, "HCM", "38556886-2b53-4487-b88f-e3ea99764360", "normaluser52@gmail.com", true, "52", true, "Nguyen Van", false, null, "normaluser52@gmail.com", "normalUser52", "AQAAAAIAAYagAAAAEPi2Sg7ZEw5afp8z+iLIdoAK4jHYuKqTaxqkNuwNyNgtJ/k0Gq2HfSGG85H6NKEAkg==", null, false, "", false, "normalUser52" },
                    { 53, 0, "HCM", "8425d173-eb4f-4952-8225-880d59b7e535", "normaluser53@gmail.com", true, "53", true, "Nguyen Van", false, null, "normaluser53@gmail.com", "normalUser53", "AQAAAAIAAYagAAAAEEYBKxZeI9sPZlY3hNXHVkRhYhnWb7GkSPv0EMKms8JFu8FeQxhB2qq6RPvYcIO2bQ==", null, false, "", false, "normalUser53" },
                    { 54, 0, "HCM", "f891d48b-b43c-452e-af09-c7d9367bd36c", "normaluser54@gmail.com", true, "54", true, "Nguyen Van", false, null, "normaluser54@gmail.com", "normalUser54", "AQAAAAIAAYagAAAAEKLxmpk9jx9H98+cxvNzzXeMpUmCBKpMWAorIoR4PwZ9JVMk01WaKUrSC78ZeLu2fA==", null, false, "", false, "normalUser54" },
                    { 55, 0, "HCM", "1b4d4042-10a6-4e6a-8758-b92855fce204", "normaluser55@gmail.com", true, "55", true, "Nguyen Van", false, null, "normaluser55@gmail.com", "normalUser55", "AQAAAAIAAYagAAAAEEGdhgIFpwSlVoxp6oLns4jhrcVjvvtCj9yGd7qybDogMR0a+QZAhdnSv1sYnuu6jA==", null, false, "", false, "normalUser55" },
                    { 56, 0, "HCM", "0eada0f0-d0f2-4215-9536-abda15f47145", "normaluser56@gmail.com", true, "56", true, "Nguyen Van", false, null, "normaluser56@gmail.com", "normalUser56", "AQAAAAIAAYagAAAAEJJK3TvIoi/6vA+zpn/UeNARGOfXTkx3xrqdp4c8J1TOkRPkD3wer+Ts0/6UtOc1dQ==", null, false, "", false, "normalUser56" },
                    { 57, 0, "HCM", "63221955-d67e-4956-bcea-fe9c94023b01", "normaluser57@gmail.com", true, "57", true, "Nguyen Van", false, null, "normaluser57@gmail.com", "normalUser57", "AQAAAAIAAYagAAAAEPokYL6PxXBx6GRLFTUzkHbgeBpSZt3VNbdvP8EVCTnZffU4cGF7uVRAPtg54XaMrQ==", null, false, "", false, "normalUser57" },
                    { 58, 0, "HCM", "3d2cfd39-00d9-40ad-8520-cca02d40f4b9", "normaluser58@gmail.com", true, "58", true, "Nguyen Van", false, null, "normaluser58@gmail.com", "normalUser58", "AQAAAAIAAYagAAAAELtFLPodudBrhv2gVU6WuZF9W2tFCjVz9cbXp5ixEaHYD5L+2a6JkZ0k7Oc5S3owxw==", null, false, "", false, "normalUser58" },
                    { 59, 0, "HCM", "0af2b20e-3470-41c5-a631-7bd3e4deedea", "normaluser59@gmail.com", true, "59", true, "Nguyen Van", false, null, "normaluser59@gmail.com", "normalUser59", "AQAAAAIAAYagAAAAEGxDFoZJCzwa7DI4AaLfZFWt2HvWFHZFJInp7jZfzPGtyUutx2IiguAkGRXZ37Xqqw==", null, false, "", false, "normalUser59" },
                    { 60, 0, "HCM", "99aedfed-7780-4803-aa49-28516d0f7d57", "normaluser60@gmail.com", true, "60", true, "Nguyen Van", false, null, "normaluser60@gmail.com", "normalUser60", "AQAAAAIAAYagAAAAEAfIR3ZZa6xAsZDB06mT+wQuhejgsKyUlTBzyPcLKwwWldLk31XFmxZcwWFkjwg/jg==", null, false, "", false, "normalUser60" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Web developer" },
                    { 2, "Data scientist" },
                    { 3, "Software engineer" },
                    { 4, "Cloud system engineer" },
                    { 5, "User experience designer" },
                    { 6, "Network engineer" },
                    { 7, "Systems analyst" },
                    { 8, "IT security specialist" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 1, 12 },
                    { 1, 13 },
                    { 1, 14 },
                    { 1, 15 },
                    { 1, 16 },
                    { 1, 17 },
                    { 1, 18 },
                    { 1, 19 },
                    { 1, 20 },
                    { 1, 21 },
                    { 1, 22 },
                    { 1, 23 },
                    { 1, 24 },
                    { 1, 25 },
                    { 1, 26 },
                    { 1, 27 },
                    { 1, 28 },
                    { 1, 29 },
                    { 1, 30 },
                    { 2, 31 },
                    { 2, 32 },
                    { 2, 33 },
                    { 2, 34 },
                    { 2, 35 },
                    { 2, 36 },
                    { 2, 37 },
                    { 2, 38 },
                    { 2, 39 },
                    { 2, 40 },
                    { 2, 41 },
                    { 2, 42 },
                    { 2, 43 },
                    { 2, 44 },
                    { 2, 45 },
                    { 2, 46 },
                    { 2, 47 },
                    { 2, 48 },
                    { 2, 49 },
                    { 2, 50 },
                    { 2, 51 },
                    { 2, 52 },
                    { 2, 53 },
                    { 2, 54 },
                    { 2, 55 },
                    { 2, 56 },
                    { 2, 57 },
                    { 2, 58 },
                    { 2, 59 },
                    { 2, 60 }
                });

            migrationBuilder.InsertData(
                table: "BusinessProfiles",
                columns: new[] { "Id", "AppUserId", "BusinessName" },
                values: new object[,]
                {
                    { 1, 1, "Business 1" },
                    { 2, 2, "Business 2" },
                    { 3, 3, "Business 3" },
                    { 4, 4, "Business 4" },
                    { 5, 5, "Business 5" },
                    { 6, 6, "Business 6" },
                    { 7, 7, "Business 7" },
                    { 8, 8, "Business 8" },
                    { 9, 9, "Business 9" },
                    { 10, 10, "Business 10" },
                    { 11, 11, "Business 11" },
                    { 12, 12, "Business 12" },
                    { 13, 13, "Business 13" },
                    { 14, 14, "Business 14" },
                    { 15, 15, "Business 15" },
                    { 16, 16, "Business 16" },
                    { 17, 17, "Business 17" },
                    { 18, 18, "Business 18" },
                    { 19, 19, "Business 19" },
                    { 20, 20, "Business 20" },
                    { 21, 21, "Business 21" },
                    { 22, 22, "Business 22" },
                    { 23, 23, "Business 23" },
                    { 24, 24, "Business 24" },
                    { 25, 25, "Business 25" },
                    { 26, 26, "Business 26" },
                    { 27, 27, "Business 27" },
                    { 28, 28, "Business 28" },
                    { 29, 29, "Business 29" },
                    { 30, 30, "Business 30" }
                });

            migrationBuilder.InsertData(
                table: "FreelancerProfiles",
                columns: new[] { "Id", "AppUserId", "Description", "ImageUrl", "Price", "ResumeUrl", "Title" },
                values: new object[,]
                {
                    { 31, 31, "I am 31, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/31/500/500", 3100.0, "This is my resume", "Title 31" },
                    { 32, 32, "I am 32, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/32/500/500", 3200.0, "This is my resume", "Title 32" },
                    { 33, 33, "I am 33, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/33/500/500", 3300.0, "This is my resume", "Title 33" },
                    { 34, 34, "I am 34, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/34/500/500", 3400.0, "This is my resume", "Title 34" },
                    { 35, 35, "I am 35, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/35/500/500", 3500.0, "This is my resume", "Title 35" },
                    { 36, 36, "I am 36, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/36/500/500", 3600.0, "This is my resume", "Title 36" },
                    { 37, 37, "I am 37, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/37/500/500", 3700.0, "This is my resume", "Title 37" },
                    { 38, 38, "I am 38, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/38/500/500", 3800.0, "This is my resume", "Title 38" },
                    { 39, 39, "I am 39, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/39/500/500", 3900.0, "This is my resume", "Title 39" },
                    { 40, 40, "I am 40, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/40/500/500", 4000.0, "This is my resume", "Title 40" },
                    { 41, 41, "I am 41, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/41/500/500", 4100.0, "This is my resume", "Title 41" },
                    { 42, 42, "I am 42, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/42/500/500", 4200.0, "This is my resume", "Title 42" },
                    { 43, 43, "I am 43, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/43/500/500", 4300.0, "This is my resume", "Title 43" },
                    { 44, 44, "I am 44, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/44/500/500", 4400.0, "This is my resume", "Title 44" },
                    { 45, 45, "I am 45, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/45/500/500", 4500.0, "This is my resume", "Title 45" },
                    { 46, 46, "I am 46, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/46/500/500", 4600.0, "This is my resume", "Title 46" },
                    { 47, 47, "I am 47, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/47/500/500", 4700.0, "This is my resume", "Title 47" },
                    { 48, 48, "I am 48, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/48/500/500", 4800.0, "This is my resume", "Title 48" },
                    { 49, 49, "I am 49, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/49/500/500", 4900.0, "This is my resume", "Title 49" },
                    { 50, 50, "I am 50, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/50/500/500", 5000.0, "This is my resume", "Title 50" },
                    { 51, 51, "I am 51, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/51/500/500", 5100.0, "This is my resume", "Title 51" },
                    { 52, 52, "I am 52, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/52/500/500", 5200.0, "This is my resume", "Title 52" },
                    { 53, 53, "I am 53, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/53/500/500", 5300.0, "This is my resume", "Title 53" },
                    { 54, 54, "I am 54, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/54/500/500", 5400.0, "This is my resume", "Title 54" },
                    { 55, 55, "I am 55, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/55/500/500", 5500.0, "This is my resume", "Title 55" },
                    { 56, 56, "I am 56, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/56/500/500", 5600.0, "This is my resume", "Title 56" },
                    { 57, 57, "I am 57, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/57/500/500", 5700.0, "This is my resume", "Title 57" },
                    { 58, 58, "I am 58, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/58/500/500", 5800.0, "This is my resume", "Title 58" },
                    { 59, 59, "I am 59, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/59/500/500", 5900.0, "This is my resume", "Title 59" },
                    { 60, 60, "I am 60, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/60/500/500", 6000.0, "This is my resume", "Title 60" }
                });

            migrationBuilder.InsertData(
                table: "FreelancerCategories",
                columns: new[] { "CategoryId", "FreelancerProfileId" },
                values: new object[,]
                {
                    { 1, 31 },
                    { 1, 32 },
                    { 8, 33 },
                    { 1, 34 },
                    { 4, 35 },
                    { 1, 36 },
                    { 4, 37 },
                    { 7, 38 },
                    { 5, 39 },
                    { 4, 40 },
                    { 2, 41 },
                    { 1, 42 },
                    { 4, 43 },
                    { 5, 44 },
                    { 5, 45 },
                    { 1, 46 },
                    { 6, 47 },
                    { 5, 48 },
                    { 7, 49 },
                    { 6, 50 },
                    { 4, 51 },
                    { 2, 52 },
                    { 8, 53 },
                    { 2, 54 },
                    { 5, 55 },
                    { 1, 56 },
                    { 7, 57 },
                    { 2, 58 },
                    { 4, 59 },
                    { 2, 60 }
                });

            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "Id", "ApplyExpireDate", "BusinessProfileId", "CreatedDate", "Description", "IsActive", "Name", "Offer" },
                values: new object[,]
                {
                    { 1, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9460), "This a simple description for project 1 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 1", 99.0 },
                    { 2, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9503), "This a simple description for project 2 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 2", 198.0 },
                    { 3, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9510), "This a simple description for project 3 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 3", 297.0 },
                    { 4, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9517), "This a simple description for project 4 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 4", 396.0 },
                    { 5, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9559), "This a simple description for project 5 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 5", 495.0 },
                    { 6, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9568), "This a simple description for project 6 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 6", 594.0 },
                    { 7, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9575), "This a simple description for project 7 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 7", 693.0 },
                    { 8, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9582), "This a simple description for project 8 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 8", 792.0 },
                    { 9, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9590), "This a simple description for project 9 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 9", 891.0 },
                    { 10, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 3, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9629), "This a simple description for project 10 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 10", 990.0 },
                    { 11, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 2, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9638), "This a simple description for project 11 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 11", 1089.0 },
                    { 12, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9645), "This a simple description for project 12 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 12", 1188.0 },
                    { 13, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9652), "This a simple description for project 13 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 13", 1287.0 },
                    { 14, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9660), "This a simple description for project 14 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 14", 1386.0 },
                    { 15, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9667), "This a simple description for project 15 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 15", 1485.0 },
                    { 16, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9706), "This a simple description for project 16 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 16", 1584.0 },
                    { 17, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9714), "This a simple description for project 17 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 17", 1683.0 },
                    { 18, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 2, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9722), "This a simple description for project 18 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 18", 1782.0 },
                    { 19, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9729), "This a simple description for project 19 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 19", 1881.0 },
                    { 20, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9736), "This a simple description for project 20 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 20", 1980.0 },
                    { 21, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 3, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9743), "This a simple description for project 21 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 21", 2079.0 },
                    { 22, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9833), "This a simple description for project 22 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 22", 2178.0 },
                    { 23, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 2, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9842), "This a simple description for project 23 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 23", 2277.0 },
                    { 24, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9848), "This a simple description for project 24 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 24", 2376.0 },
                    { 25, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9856), "This a simple description for project 25 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 25", 2475.0 },
                    { 26, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9862), "This a simple description for project 26 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 26", 2574.0 },
                    { 27, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 30, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9870), "This a simple description for project 27 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 27", 2673.0 },
                    { 28, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 2, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9911), "This a simple description for project 28 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 28", 2772.0 },
                    { 29, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9919), "This a simple description for project 29 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 29", 2871.0 },
                    { 30, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 3, new DateTime(2023, 6, 13, 10, 18, 24, 562, DateTimeKind.Local).AddTicks(9984), "This a simple description for project 30 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 30", 2970.0 },
                    { 31, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(4), "This a simple description for project 31 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 31", 3069.0 },
                    { 32, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(12), "This a simple description for project 32 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 32", 3168.0 },
                    { 33, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 5, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(50), "This a simple description for project 33 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 33", 3267.0 },
                    { 34, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(60), "This a simple description for project 34 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 34", 3366.0 },
                    { 35, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(67), "This a simple description for project 35 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 35", 3465.0 },
                    { 36, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 3, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(74), "This a simple description for project 36 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 36", 3564.0 },
                    { 37, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 3, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(80), "This a simple description for project 37 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 37", 3663.0 },
                    { 38, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 3, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(87), "This a simple description for project 38 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 38", 3762.0 },
                    { 39, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(126), "This a simple description for project 39 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 39", 3861.0 },
                    { 40, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(133), "This a simple description for project 40 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 40", 3960.0 },
                    { 41, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(140), "This a simple description for project 41 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 41", 4059.0 },
                    { 42, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(147), "This a simple description for project 42 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 42", 4158.0 },
                    { 43, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(154), "This a simple description for project 43 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 43", 4257.0 },
                    { 44, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(191), "This a simple description for project 44 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 44", 4356.0 },
                    { 45, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(199), "This a simple description for project 45 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 45", 4455.0 },
                    { 46, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 2, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(206), "This a simple description for project 46 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 46", 4554.0 },
                    { 47, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(213), "This a simple description for project 47 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 47", 4653.0 },
                    { 48, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(219), "This a simple description for project 48 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 48", 4752.0 },
                    { 49, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(226), "This a simple description for project 49 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 49", 4851.0 },
                    { 50, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(263), "This a simple description for project 50 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 50", 4950.0 },
                    { 51, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(272), "This a simple description for project 51 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 51", 5049.0 },
                    { 52, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(279), "This a simple description for project 52 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 52", 5148.0 },
                    { 53, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(286), "This a simple description for project 53 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 53", 5247.0 },
                    { 54, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(292), "This a simple description for project 54 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 54", 5346.0 },
                    { 55, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(299), "This a simple description for project 55 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 55", 5445.0 },
                    { 56, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 3, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(336), "This a simple description for project 56 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 56", 5544.0 },
                    { 57, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(344), "This a simple description for project 57 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 57", 5643.0 },
                    { 58, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(351), "This a simple description for project 58 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 58", 5742.0 },
                    { 59, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 1, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(358), "This a simple description for project 59 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 59", 5841.0 },
                    { 60, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(364), "This a simple description for project 60 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 60", 5940.0 },
                    { 61, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(371), "This a simple description for project 61 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 61", 6039.0 },
                    { 62, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(409), "This a simple description for project 62 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 62", 6138.0 },
                    { 63, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(417), "This a simple description for project 63 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 63", 6237.0 },
                    { 64, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(423), "This a simple description for project 64 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 64", 6336.0 },
                    { 65, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(431), "This a simple description for project 65 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 65", 6435.0 },
                    { 66, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(489), "This a simple description for project 66 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 66", 6534.0 },
                    { 67, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(498), "This a simple description for project 67 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 67", 6633.0 },
                    { 68, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(505), "This a simple description for project 68 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 68", 6732.0 },
                    { 69, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(512), "This a simple description for project 69 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 69", 6831.0 },
                    { 70, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(519), "This a simple description for project 70 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 70", 6930.0 },
                    { 71, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(526), "This a simple description for project 71 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 71", 7029.0 },
                    { 72, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(564), "This a simple description for project 72 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 72", 7128.0 },
                    { 73, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(572), "This a simple description for project 73 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 73", 7227.0 },
                    { 74, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(579), "This a simple description for project 74 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 74", 7326.0 },
                    { 75, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 1, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(586), "This a simple description for project 75 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 75", 7425.0 },
                    { 76, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 30, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(593), "This a simple description for project 76 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 76", 7524.0 },
                    { 77, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 3, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(612), "This a simple description for project 77 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 77", 7623.0 },
                    { 78, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(650), "This a simple description for project 78 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 78", 7722.0 },
                    { 79, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(659), "This a simple description for project 79 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 79", 7821.0 },
                    { 80, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(665), "This a simple description for project 80 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 80", 7920.0 },
                    { 81, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(672), "This a simple description for project 81 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 81", 8019.0 },
                    { 82, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(679), "This a simple description for project 82 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 82", 8118.0 },
                    { 83, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 2, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(686), "This a simple description for project 83 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 83", 8217.0 },
                    { 84, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(722), "This a simple description for project 84 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 84", 8316.0 },
                    { 85, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(730), "This a simple description for project 85 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 85", 8415.0 },
                    { 86, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(737), "This a simple description for project 86 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 86", 8514.0 },
                    { 87, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(744), "This a simple description for project 87 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 87", 8613.0 },
                    { 88, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(750), "This a simple description for project 88 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 88", 8712.0 },
                    { 89, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 3, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(757), "This a simple description for project 89 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 89", 8811.0 },
                    { 90, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(805), "This a simple description for project 90 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 90", 8910.0 },
                    { 91, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(814), "This a simple description for project 91 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 91", 9009.0 },
                    { 92, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 3, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(821), "This a simple description for project 92 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 92", 9108.0 },
                    { 93, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 5, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(827), "This a simple description for project 93 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 93", 9207.0 },
                    { 94, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(834), "This a simple description for project 94 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 94", 9306.0 },
                    { 95, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(841), "This a simple description for project 95 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 95", 9405.0 },
                    { 96, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(878), "This a simple description for project 96 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 96", 9504.0 },
                    { 97, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 1, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(885), "This a simple description for project 97 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 97", 9603.0 },
                    { 98, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(892), "This a simple description for project 98 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 98", 9702.0 },
                    { 99, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(899), "This a simple description for project 99 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 99", 9801.0 },
                    { 100, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 13, 10, 18, 24, 563, DateTimeKind.Local).AddTicks(906), "This a simple description for project 100 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 100", 9900.0 }
                });

            migrationBuilder.InsertData(
                table: "JobCategories",
                columns: new[] { "CategoryId", "JobId" },
                values: new object[,]
                {
                    { 5, 1 },
                    { 3, 2 },
                    { 8, 3 },
                    { 6, 4 },
                    { 4, 5 },
                    { 2, 6 },
                    { 4, 7 },
                    { 1, 8 },
                    { 6, 9 },
                    { 4, 10 },
                    { 1, 11 },
                    { 7, 12 },
                    { 1, 13 },
                    { 2, 14 },
                    { 1, 15 },
                    { 7, 16 },
                    { 8, 17 },
                    { 5, 18 },
                    { 5, 19 },
                    { 1, 20 },
                    { 4, 21 },
                    { 7, 22 },
                    { 1, 23 },
                    { 4, 24 },
                    { 3, 25 },
                    { 6, 26 },
                    { 1, 27 },
                    { 7, 28 },
                    { 6, 29 },
                    { 3, 30 },
                    { 7, 31 },
                    { 7, 32 },
                    { 3, 33 },
                    { 3, 34 },
                    { 5, 35 },
                    { 4, 36 },
                    { 7, 37 },
                    { 8, 38 },
                    { 7, 39 },
                    { 3, 40 },
                    { 5, 41 },
                    { 4, 42 },
                    { 1, 43 },
                    { 7, 44 },
                    { 8, 45 },
                    { 2, 46 },
                    { 3, 47 },
                    { 7, 48 },
                    { 6, 49 },
                    { 5, 50 },
                    { 3, 51 },
                    { 1, 52 },
                    { 8, 53 },
                    { 8, 54 },
                    { 4, 55 },
                    { 8, 56 },
                    { 3, 57 },
                    { 6, 58 },
                    { 3, 59 },
                    { 4, 60 },
                    { 4, 61 },
                    { 1, 62 },
                    { 2, 63 },
                    { 1, 64 },
                    { 6, 65 },
                    { 7, 66 },
                    { 2, 67 },
                    { 7, 68 },
                    { 2, 69 },
                    { 6, 70 },
                    { 5, 71 },
                    { 6, 72 },
                    { 1, 73 },
                    { 4, 74 },
                    { 6, 75 },
                    { 6, 76 },
                    { 3, 77 },
                    { 6, 78 },
                    { 8, 79 },
                    { 2, 80 },
                    { 3, 81 },
                    { 6, 82 },
                    { 4, 83 },
                    { 8, 84 },
                    { 8, 85 },
                    { 1, 86 },
                    { 7, 87 },
                    { 4, 88 },
                    { 8, 89 },
                    { 4, 90 },
                    { 5, 91 },
                    { 4, 92 },
                    { 5, 93 },
                    { 4, 94 },
                    { 1, 95 },
                    { 3, 96 },
                    { 4, 97 },
                    { 2, 98 },
                    { 1, 99 },
                    { 7, 100 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_FreelancerProfileId",
                table: "Applications",
                column: "FreelancerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_JobId",
                table: "Applications",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProfiles_AppUserId",
                table: "BusinessProfiles",
                column: "AppUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FreelancerCategories_CategoryId",
                table: "FreelancerCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FreelancerProfiles_AppUserId",
                table: "FreelancerProfiles",
                column: "AppUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Job_BusinessProfileId",
                table: "Job",
                column: "BusinessProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_JobCategories_CategoryId",
                table: "JobCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_JobProgress_FreelancerProfileId",
                table: "JobProgress",
                column: "FreelancerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_JobProgress_JobId",
                table: "JobProgress",
                column: "JobId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");

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
                name: "FreelancerCategories");

            migrationBuilder.DropTable(
                name: "JobCategories");

            migrationBuilder.DropTable(
                name: "JobProgress");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "FreelancerProfiles");

            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.DropTable(
                name: "BusinessProfiles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
