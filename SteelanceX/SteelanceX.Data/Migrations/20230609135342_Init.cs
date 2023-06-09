using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SteelanceX.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
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
                    JobExpiredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobDescriptionFileUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "HCM", "c0e1ec41-4bc7-4920-9f09-bd1a7d59230d", "adminhcm@gmail.com", true, "Toan", "Bach", false, null, "adminhcm@gmail.com", "adminhcm", "AQAAAAIAAYagAAAAEJPEeKFewu4IujTwpRZYNSuweyKqaY3k7KGzBGIxt6pFq+XdGn6YBNiNyk575LhmyA==", null, false, "", false, "adminhcm" },
                    { 2, 0, "HCM", "65b6f271-643c-43f7-9f53-1630d179abe6", "adminhn@gmail.com", true, "Toan", "Bach", false, null, "adminhn@gmail.com", "adminhn", "AQAAAAIAAYagAAAAEPjDTIFZLwEtE6KMlb/Y+bLSowvrBGmmFfHQrNfzaqh8BN7Jn5lQauyzfexra9DRfA==", null, false, "", false, "adminhn" },
                    { 3, 0, "HCM", "6ad1fd06-1bbd-4a4f-a1fe-4e217d730580", "staff@gmail.com", true, "Toan", "Bach", false, null, "staff@gmail.com", "staff1", "AQAAAAIAAYagAAAAEGZHeOAV2whRFw1HoObmNqQdt+KBnONk3idlLn5AKAKr+nTfMsLo9NvGcpKRl7SK9w==", null, false, "", false, "staff1" },
                    { 4, 0, "HCM", "f32b432c-3066-42ef-82e6-ff0bf15614ef", "staff@gmail.com", true, "Toan", "Bach", false, null, "staff@gmail.com", "staff2", "AQAAAAIAAYagAAAAEGyva5JH7qL5DtgGaSok7RtyMDJyISVfm90+PmUc1PJOIbD7n4iD+MLnO1yHM/TbbQ==", null, false, "", false, "staff2" },
                    { 5, 0, "HCM", "8031a7ce-e9ec-4234-8dd8-e2b9974a61ea", "staffdis@gmail.com", true, "Toan", "Bach", false, null, "staffdis@gmail.com", "staffdis", "AQAAAAIAAYagAAAAEOHIiR3zdAHH7O4bLK3cY465qv/Xh15mOtPXpqSIByll0L+HQluxtLpS79FC2PHnSQ==", null, false, "", false, "staffDis" },
                    { 6, 0, "HCM", "92df0bc5-4f28-4ca9-814d-24f3e6675ad5", "normaluser6@gmail.com", true, "6", "Nguyen Van", false, null, "normaluser6@gmail.com", "normalUser6", "AQAAAAIAAYagAAAAENCtwl6Iq6B52fgigMlwyyKXWiwtCWe2IjyEqXOtgs2G/fZH8ySKK2ois5zgbEDldw==", null, false, "", false, "normalUser6" },
                    { 7, 0, "HCM", "a8d18676-841e-4b50-87ec-cf942ca54b22", "normaluser7@gmail.com", true, "7", "Nguyen Van", false, null, "normaluser7@gmail.com", "normalUser7", "AQAAAAIAAYagAAAAEIrKGLm2vuIMVtXkQaCKc4GQ02czeSnyBxS++oOmVjI3AGzoODoOIr0wqUwZ9X4XVg==", null, false, "", false, "normalUser7" },
                    { 8, 0, "HCM", "fb497bd2-4f87-4bca-b643-e73729fa788a", "normaluser8@gmail.com", true, "8", "Nguyen Van", false, null, "normaluser8@gmail.com", "normalUser8", "AQAAAAIAAYagAAAAEHXvJISNqxdM7fu73PDCMdPC7KtuM/BdflkVc/VbZTSsp1VRAZQ2lI9DLN+xLpum3Q==", null, false, "", false, "normalUser8" },
                    { 9, 0, "HCM", "596458b4-b6ad-48b3-928b-42aaf5145777", "normaluser9@gmail.com", true, "9", "Nguyen Van", false, null, "normaluser9@gmail.com", "normalUser9", "AQAAAAIAAYagAAAAECUuuVq2XYT//rcYVE6jE3b2cTnSjFXSJJl2sVVldT0YZXQUNBNTBvm/ffK/EdhTxw==", null, false, "", false, "normalUser9" },
                    { 10, 0, "HCM", "8cda847a-a200-428f-85ad-67ffcd6aed63", "normaluser10@gmail.com", true, "10", "Nguyen Van", false, null, "normaluser10@gmail.com", "normalUser10", "AQAAAAIAAYagAAAAELcQ1pNB2510G+OQsVhAHBKFSyEzo0RKpSS/wI2Esn3lYVWW2fI/DIOgkVFiZ2bgDQ==", null, false, "", false, "normalUser10" },
                    { 11, 0, "HCM", "8b983515-962f-4da5-b1b2-0f47c2183969", "normaluser11@gmail.com", true, "11", "Nguyen Van", false, null, "normaluser11@gmail.com", "normalUser11", "AQAAAAIAAYagAAAAEFxq6o2uMzHN1oV1s+ZuQKQm0uxA2XlyfkrcjuFOi1LhAMJT90bJsxcdA6EijX3YbA==", null, false, "", false, "normalUser11" },
                    { 12, 0, "HCM", "207a9de8-7469-4e45-9dee-b720ebbddf51", "normaluser12@gmail.com", true, "12", "Nguyen Van", false, null, "normaluser12@gmail.com", "normalUser12", "AQAAAAIAAYagAAAAEDEFH6MVi5EG7ezaRKUNyxKY941YkwlBhEJ4rvmzPQZgEVfsiv1tXnc4SxayRiPdjA==", null, false, "", false, "normalUser12" },
                    { 13, 0, "HCM", "2b8ccde4-9fe2-4038-a8aa-49c6f0099f58", "normaluser13@gmail.com", true, "13", "Nguyen Van", false, null, "normaluser13@gmail.com", "normalUser13", "AQAAAAIAAYagAAAAEHyXbWX0qlm/ReyEw0JZhFeKQiEWmC9fRXmA0HNab7fziwv+PFjDdbz/z14D5cIWXw==", null, false, "", false, "normalUser13" },
                    { 14, 0, "HCM", "e23e0712-3780-46ac-a6bd-de44ccb0cc4d", "normaluser14@gmail.com", true, "14", "Nguyen Van", false, null, "normaluser14@gmail.com", "normalUser14", "AQAAAAIAAYagAAAAEPxHGHwd6uDZ5rCxx4AxG1mp4OPrT9cPUzisvF8N78BvjDpD2MXT32XDrZPIKzJ5iA==", null, false, "", false, "normalUser14" },
                    { 15, 0, "HCM", "ddd71f9d-6211-47b3-b047-9de784afdd14", "normaluser15@gmail.com", true, "15", "Nguyen Van", false, null, "normaluser15@gmail.com", "normalUser15", "AQAAAAIAAYagAAAAEAeAHyDQwVk6wXzDOrvU5sYrmqByu7lzltGT0SKHPNQVPq9Sf4ns7A4Ry/cIXIxq2A==", null, false, "", false, "normalUser15" },
                    { 16, 0, "HCM", "c6f90957-a29f-4114-bcdd-1235e0fb8bb8", "normaluser16@gmail.com", true, "16", "Nguyen Van", false, null, "normaluser16@gmail.com", "normalUser16", "AQAAAAIAAYagAAAAEBc/8Drzqg3poJOhk6elucJbDgxAUwjPAZRaxSs6zQFXh+naOxDspayBtzHWi3ohAQ==", null, false, "", false, "normalUser16" },
                    { 17, 0, "HCM", "fda66527-1925-4019-803e-8c369d505b1e", "normaluser17@gmail.com", true, "17", "Nguyen Van", false, null, "normaluser17@gmail.com", "normalUser17", "AQAAAAIAAYagAAAAEE/sreL1cHDEiyhoBBH8e9j4oNhpmGOZh7iSOxhit8bD1P8Pqea83cuxAhsSQhfzpQ==", null, false, "", false, "normalUser17" },
                    { 18, 0, "HCM", "74fd5700-ebd2-4745-82cf-94e46c22e02c", "normaluser18@gmail.com", true, "18", "Nguyen Van", false, null, "normaluser18@gmail.com", "normalUser18", "AQAAAAIAAYagAAAAEAHgiVSFdtG0tQI9+l8lDz54oc7/NF/Uf+wS3tqlSI1YheOid/eUt+zo/hqzQACw+Q==", null, false, "", false, "normalUser18" },
                    { 19, 0, "HCM", "372d7630-3c2f-4595-9494-53f4f7948b16", "normaluser19@gmail.com", true, "19", "Nguyen Van", false, null, "normaluser19@gmail.com", "normalUser19", "AQAAAAIAAYagAAAAEJjXrY1SFK0/tdVe2PbgtusESodJ10NbVoj1TrLMrZCvzE47O9Re0ngDKoCMWdS2xQ==", null, false, "", false, "normalUser19" },
                    { 20, 0, "HCM", "12de69db-5276-48d3-a73b-3352492e4a52", "normaluser20@gmail.com", true, "20", "Nguyen Van", false, null, "normaluser20@gmail.com", "normalUser20", "AQAAAAIAAYagAAAAEPx9AQR1qE9eflnwNAt2dFt9T1FQJU2cazZ0I++RTIql+u+6BEXlRdBqPcuu6r/nRw==", null, false, "", false, "normalUser20" },
                    { 21, 0, "HCM", "202d5d70-be7c-4ca1-83b6-573c954390fc", "normaluser21@gmail.com", true, "21", "Nguyen Van", false, null, "normaluser21@gmail.com", "normalUser21", "AQAAAAIAAYagAAAAEA96hbfnvuSAcU8VYZPfxeFBn5aG0YkAtoUzh/S1hFs9Ru9dFDVQaz8bhm3Uy6Q/wA==", null, false, "", false, "normalUser21" },
                    { 22, 0, "HCM", "0fe564ce-dae9-485c-8ad8-1fa1229d3b34", "normaluser22@gmail.com", true, "22", "Nguyen Van", false, null, "normaluser22@gmail.com", "normalUser22", "AQAAAAIAAYagAAAAEN0YRot85rf3S/WNp6uoQm5W//w97BQqoSt6oK6+nlWdDFuGvH6THAaDQBN1zsQrdA==", null, false, "", false, "normalUser22" },
                    { 23, 0, "HCM", "ace2ad22-5914-487e-a232-8a8033f5e24b", "normaluser23@gmail.com", true, "23", "Nguyen Van", false, null, "normaluser23@gmail.com", "normalUser23", "AQAAAAIAAYagAAAAEC/LvGBUJCsw/Za37QWI2Ou0bu9mR1USdmu6RaV5GeldT2Q2y8rS/dXX9TwxiQsHFA==", null, false, "", false, "normalUser23" },
                    { 24, 0, "HCM", "29661b93-734b-4d5c-9594-2d3b884f6582", "normaluser24@gmail.com", true, "24", "Nguyen Van", false, null, "normaluser24@gmail.com", "normalUser24", "AQAAAAIAAYagAAAAECRoYLOhna4YOS3O77Wj3Tzb79I55woGQYa5jQPU0Ateo7QNZ+YKdg2LY3Ss4oTHxQ==", null, false, "", false, "normalUser24" },
                    { 25, 0, "HCM", "33f4a498-362e-4d8c-bfd3-474814f20b36", "normaluser25@gmail.com", true, "25", "Nguyen Van", false, null, "normaluser25@gmail.com", "normalUser25", "AQAAAAIAAYagAAAAENlBWYx+ufqz9ehcMZ4mHSSy4GaTPUNKeGOlM1SmQPekDjM9o4dDBosMJxI2kBOCYA==", null, false, "", false, "normalUser25" },
                    { 26, 0, "HCM", "96e34c1e-db79-45a7-9bb2-f1b15e269288", "normaluser26@gmail.com", true, "26", "Nguyen Van", false, null, "normaluser26@gmail.com", "normalUser26", "AQAAAAIAAYagAAAAEMXPhY2aDylijV8iTI0TDHdTa+2yRqDwKyqTagcg+7dCaIhIvtS279wq6u5YUI17hw==", null, false, "", false, "normalUser26" },
                    { 27, 0, "HCM", "de9032ec-a32e-4bc1-abd7-99b2a6dce562", "normaluser27@gmail.com", true, "27", "Nguyen Van", false, null, "normaluser27@gmail.com", "normalUser27", "AQAAAAIAAYagAAAAEJXKP7NlP8ImDgcbRPOVXsA+gWLf08p4gZxaJvaieoXaLBSnvqXpHSZv8pXmZGZ3EA==", null, false, "", false, "normalUser27" },
                    { 28, 0, "HCM", "2ab1a7aa-2b25-4e06-b148-aaff3f51ae63", "normaluser28@gmail.com", true, "28", "Nguyen Van", false, null, "normaluser28@gmail.com", "normalUser28", "AQAAAAIAAYagAAAAEE+w2VXMTzCf+CeAstJv8RIOrhDy1hqJj8GiK/UGWYCt0RCQav/jhBHnyPpZ8sB6Ag==", null, false, "", false, "normalUser28" },
                    { 29, 0, "HCM", "8b1697f1-817d-4c04-8084-1d0913f9deac", "normaluser29@gmail.com", true, "29", "Nguyen Van", false, null, "normaluser29@gmail.com", "normalUser29", "AQAAAAIAAYagAAAAEB+cPqdYRLRWbE7QpOkTQKdalQLJudrjM1tYFJB86MmWGFes5Shyiq0VLasPRskcaA==", null, false, "", false, "normalUser29" },
                    { 30, 0, "HCM", "1930cb47-8db2-478f-ae7f-5aa69786d278", "normaluser30@gmail.com", true, "30", "Nguyen Van", false, null, "normaluser30@gmail.com", "normalUser30", "AQAAAAIAAYagAAAAENTapubm3kQPdY6vfPWsSUhVCy5xAdi2M4ggxR99z0REsOZbHI30Uas0GS3OrE8M9Q==", null, false, "", false, "normalUser30" },
                    { 31, 0, "HCM", "866b62e9-0e68-4635-87f5-c93b2a1505eb", "normaluser31@gmail.com", true, "31", "Nguyen Van", false, null, "normaluser31@gmail.com", "normalUser31", "AQAAAAIAAYagAAAAEPVZasNR9tDSj84fZEBHz+/N6I7PV3euAyw4qoO72B+VY26flE/TquMkevDj+VlDFQ==", null, false, "", false, "normalUser31" },
                    { 32, 0, "HCM", "3c7921f3-fc07-4b8a-a3ee-0b44ebd3e624", "normaluser32@gmail.com", true, "32", "Nguyen Van", false, null, "normaluser32@gmail.com", "normalUser32", "AQAAAAIAAYagAAAAEGwAkdu/KLvE7dcG9R0fMHLM1MblFX6Q6J+C2ZqOg1irfZ0Z8xy0TZP2v5w+cropcA==", null, false, "", false, "normalUser32" },
                    { 33, 0, "HCM", "7b8cfdec-abc1-4cfc-9921-09d870df3dc3", "normaluser33@gmail.com", true, "33", "Nguyen Van", false, null, "normaluser33@gmail.com", "normalUser33", "AQAAAAIAAYagAAAAEHEjtUSBfBuMt/lb6XPJWZUiJJoKkTpRMlpw+VsscdBvKgs7xhcmlRC9mqn+57QlLw==", null, false, "", false, "normalUser33" },
                    { 34, 0, "HCM", "e699f6a3-c47b-4960-bf8c-d884a72c33be", "normaluser34@gmail.com", true, "34", "Nguyen Van", false, null, "normaluser34@gmail.com", "normalUser34", "AQAAAAIAAYagAAAAEJDZq2cm1EDimdd4czvYzT/y/zxHU99h6QfKBPVScahC6OeG16MF/0PqrP4jr34KvQ==", null, false, "", false, "normalUser34" },
                    { 35, 0, "HCM", "a2f3a474-6032-4ff1-aa7d-eed01f04b485", "normaluser35@gmail.com", true, "35", "Nguyen Van", false, null, "normaluser35@gmail.com", "normalUser35", "AQAAAAIAAYagAAAAEGwegVAIzhydCt6CUxq9EhMbszdzpjq2QRPCceLxstP92J0mncRW1EqfOVa0rYYftA==", null, false, "", false, "normalUser35" },
                    { 36, 0, "HCM", "7bb08506-a3b4-4d0b-acbc-40750653f8f8", "normaluser36@gmail.com", true, "36", "Nguyen Van", false, null, "normaluser36@gmail.com", "normalUser36", "AQAAAAIAAYagAAAAEPFiPXBt5yfGmHN1G8oqfLqp3kpQhhdMq1/dsQ1pRlhIY/9AyD50kuD+65gfZG3hNQ==", null, false, "", false, "normalUser36" },
                    { 37, 0, "HCM", "5a1fbbfc-6254-4a2f-a8e2-d52570664896", "normaluser37@gmail.com", true, "37", "Nguyen Van", false, null, "normaluser37@gmail.com", "normalUser37", "AQAAAAIAAYagAAAAEHgoy/PhrogkU6wmNdpcdUQeZI5AHipb3X2WUabYMvHxYqPGvlQqKhyf9Z8VflDcVQ==", null, false, "", false, "normalUser37" },
                    { 38, 0, "HCM", "9e114bdc-fe97-4f0e-8746-d0183f30fa90", "normaluser38@gmail.com", true, "38", "Nguyen Van", false, null, "normaluser38@gmail.com", "normalUser38", "AQAAAAIAAYagAAAAEDFG3Ewn83fUGIvZ4OHEojWMLFWhclR+gCari/lPcap8nLk7zf1nzP+4ONHF0hEgwQ==", null, false, "", false, "normalUser38" },
                    { 39, 0, "HCM", "d66a55ec-4a6c-4f72-820c-2143ca0f6a61", "normaluser39@gmail.com", true, "39", "Nguyen Van", false, null, "normaluser39@gmail.com", "normalUser39", "AQAAAAIAAYagAAAAEGS7/sAtLgTwnNGEf6T84mAYJhq2q8WUQFOWxLrlPzhsRkpuu8Q76FlrX/5EapQe7A==", null, false, "", false, "normalUser39" },
                    { 40, 0, "HCM", "c868b708-0a3d-415c-943f-ff97ad230f49", "normaluser40@gmail.com", true, "40", "Nguyen Van", false, null, "normaluser40@gmail.com", "normalUser40", "AQAAAAIAAYagAAAAEGNdARIT2BioAutBAEpO5fBDwpfJkLi/OE5yOAp6v2RwMn8paRHd+CM2SQMtmVzVAQ==", null, false, "", false, "normalUser40" },
                    { 41, 0, "HCM", "b0fa1fab-bc25-46f0-a9cf-fd1328f10f97", "normaluser41@gmail.com", true, "41", "Nguyen Van", false, null, "normaluser41@gmail.com", "normalUser41", "AQAAAAIAAYagAAAAELD+SVZ4DrYxjWP+f5bcGtQK5FwNBjl1NAeqWLX/eRHaiatUtgbPyZVDzAd/vs6Nng==", null, false, "", false, "normalUser41" },
                    { 42, 0, "HCM", "c98f5ac2-9032-4c0a-8f59-70d3a312df88", "normaluser42@gmail.com", true, "42", "Nguyen Van", false, null, "normaluser42@gmail.com", "normalUser42", "AQAAAAIAAYagAAAAECjlqwb/D73NuiXYKNuJZOZDk5tG/XX6y35pB7ycwvNzAo9nb7OLHbTUq6urqCLUmw==", null, false, "", false, "normalUser42" },
                    { 43, 0, "HCM", "90194dbf-9b4b-4ede-b61b-60615d69886d", "normaluser43@gmail.com", true, "43", "Nguyen Van", false, null, "normaluser43@gmail.com", "normalUser43", "AQAAAAIAAYagAAAAENYArvwMOFrnnEpf02Ahci1sZR0zMgZ3adWObBdtLMfoenJqgYxW5NpGqEQWJSibAQ==", null, false, "", false, "normalUser43" },
                    { 44, 0, "HCM", "2002b482-2580-4fc7-8cbc-8944edb71745", "normaluser44@gmail.com", true, "44", "Nguyen Van", false, null, "normaluser44@gmail.com", "normalUser44", "AQAAAAIAAYagAAAAEAdP/g1bWYyNQjGf8062stTMgjvRR3pT9hjTYHWAb7uqCg86A+JFwU07pcogVYClwg==", null, false, "", false, "normalUser44" },
                    { 45, 0, "HCM", "49ff0fe6-3ac9-4edc-ba30-5afb06ec7823", "normaluser45@gmail.com", true, "45", "Nguyen Van", false, null, "normaluser45@gmail.com", "normalUser45", "AQAAAAIAAYagAAAAELh9WPJOoMrnKYouFAp2GfepMkGXzB+anNVvGW2zNqjw8fqBk97MxANN/dodhPsmxA==", null, false, "", false, "normalUser45" },
                    { 46, 0, "HCM", "e3104168-e726-403d-bc41-83133a9f7f21", "normaluser46@gmail.com", true, "46", "Nguyen Van", false, null, "normaluser46@gmail.com", "normalUser46", "AQAAAAIAAYagAAAAEAY790Km/nvTcEpCnJrTF/H4MzuXLqC8ccyj5Lcqv8u7leR995AzzNdrloswgPiEDg==", null, false, "", false, "normalUser46" },
                    { 47, 0, "HCM", "e78434ae-f364-437c-b6fa-4d067ffa70ef", "normaluser47@gmail.com", true, "47", "Nguyen Van", false, null, "normaluser47@gmail.com", "normalUser47", "AQAAAAIAAYagAAAAEAozDUiK6GUmSIuIY9shZrLZrZD76+/fS4x3Gi4nL3Zsc3dZNKzQe/0Zu6keAUzeQg==", null, false, "", false, "normalUser47" },
                    { 48, 0, "HCM", "48c3349b-ab1f-4e87-b3e6-863a0e0c0f0a", "normaluser48@gmail.com", true, "48", "Nguyen Van", false, null, "normaluser48@gmail.com", "normalUser48", "AQAAAAIAAYagAAAAEHoXTm+RKBYgZs2r4GTsIPzW5iyr/oCifLfXPmSoaBk3+UQ4DSYYjQvUaS5pUHJS5A==", null, false, "", false, "normalUser48" },
                    { 49, 0, "HCM", "7c754596-368b-4485-8d10-b9eda5302f98", "normaluser49@gmail.com", true, "49", "Nguyen Van", false, null, "normaluser49@gmail.com", "normalUser49", "AQAAAAIAAYagAAAAEDjEPXToHAunWKScJYMm3dXHWxaC9d7/HyploxLhcZZEVraeujt2gvqkbmPSYmMZ2w==", null, false, "", false, "normalUser49" },
                    { 50, 0, "HCM", "7fb1efb9-9971-4977-9086-aceb07df28fd", "normaluser50@gmail.com", true, "50", "Nguyen Van", false, null, "normaluser50@gmail.com", "normalUser50", "AQAAAAIAAYagAAAAEFOvAY2uSc3E32o23iVxE/No+l+D/AIcBvYjMCUIol7agVXmz0Wnu1znULTGy3o9bw==", null, false, "", false, "normalUser50" },
                    { 51, 0, "HCM", "c40e63b2-ec6c-4c90-8418-6d2241e2d8e2", "normaluser51@gmail.com", true, "51", "Nguyen Van", false, null, "normaluser51@gmail.com", "normalUser51", "AQAAAAIAAYagAAAAEG0O90F8B5YiGdP8T+nSi9OFTDNZ5/Ye784nMY1/M9bujyY0ZbuH0NJ6xA/3Q4OYgA==", null, false, "", false, "normalUser51" },
                    { 52, 0, "HCM", "16d2d130-3250-445e-b2c1-cfa39b4101f9", "normaluser52@gmail.com", true, "52", "Nguyen Van", false, null, "normaluser52@gmail.com", "normalUser52", "AQAAAAIAAYagAAAAEDEcP2qvOV67H/9mAS4dCLM7Uki9Pr3RW0to6Ube8zXx65jAgqAoAZPrKxFeYZKJnA==", null, false, "", false, "normalUser52" },
                    { 53, 0, "HCM", "18910163-2b6b-4708-89a3-c923b3abc9f9", "normaluser53@gmail.com", true, "53", "Nguyen Van", false, null, "normaluser53@gmail.com", "normalUser53", "AQAAAAIAAYagAAAAECdLvWf+ED8h0Qw0tckDdgtZqvVvDhWB42V+Z+7uvOpIJPbl5L235YWwHyDJbQwDNQ==", null, false, "", false, "normalUser53" },
                    { 54, 0, "HCM", "45097551-fa5e-4db0-8630-0732a83410e1", "normaluser54@gmail.com", true, "54", "Nguyen Van", false, null, "normaluser54@gmail.com", "normalUser54", "AQAAAAIAAYagAAAAEK0IGKxYafKbfoCGNX74gyH23YwERVnFH//HzQt98wkPkcU+uvZewkVdGJvtnvZVVw==", null, false, "", false, "normalUser54" },
                    { 55, 0, "HCM", "0b3f36aa-ecce-4bc3-843c-5b2b2882b92b", "normaluser55@gmail.com", true, "55", "Nguyen Van", false, null, "normaluser55@gmail.com", "normalUser55", "AQAAAAIAAYagAAAAEO7VebFWGRT2K7Xegurr5xY90RXOt4WeN/6z1ljTb+b6aqXmKwg5zLlxeMmlWKa8bA==", null, false, "", false, "normalUser55" },
                    { 56, 0, "HCM", "d45e1e12-c8f1-4027-8ffc-fa372141f318", "normaluser56@gmail.com", true, "56", "Nguyen Van", false, null, "normaluser56@gmail.com", "normalUser56", "AQAAAAIAAYagAAAAECu7IM/tB2sUZ5re3g74+vvaeTWcpL2P5pF+dehSLARqsErlxNcPgWjTmn7l9ujjYg==", null, false, "", false, "normalUser56" },
                    { 57, 0, "HCM", "8d1f485b-6b37-41da-8a05-226707d83e04", "normaluser57@gmail.com", true, "57", "Nguyen Van", false, null, "normaluser57@gmail.com", "normalUser57", "AQAAAAIAAYagAAAAEH61ubcMFYw2DR/Jb2hNIoYONh1RY6QtNsNAcJqZYhSBCGxgJc+mGYvMXJJf/lFRcg==", null, false, "", false, "normalUser57" },
                    { 58, 0, "HCM", "4b6ad07e-bc34-40a3-868b-9a047d907dbb", "normaluser58@gmail.com", true, "58", "Nguyen Van", false, null, "normaluser58@gmail.com", "normalUser58", "AQAAAAIAAYagAAAAEFHraN13U9yVldLQnn1x9zodY02mtCg/5Ck55MikW2SDn2t63srHW7mpUQygAHeIJw==", null, false, "", false, "normalUser58" },
                    { 59, 0, "HCM", "104c8bf3-9fc2-4e99-859f-fe299f35bbb6", "normaluser59@gmail.com", true, "59", "Nguyen Van", false, null, "normaluser59@gmail.com", "normalUser59", "AQAAAAIAAYagAAAAEIOybo9jtm3Zs8vafRIWCGjPaiCY8BOjHVhwp1n4jHuL01d/ru1uPi87LXoJpAw6ug==", null, false, "", false, "normalUser59" },
                    { 60, 0, "HCM", "ba47d603-7b31-44a5-94fc-c16084c01491", "normaluser60@gmail.com", true, "60", "Nguyen Van", false, null, "normaluser60@gmail.com", "normalUser60", "AQAAAAIAAYagAAAAEK+crEffRWFjr55DOkDcIcfybIZM2BnAgemnmTSO6cAf32liEdaLQkRsDR9djvmxmQ==", null, false, "", false, "normalUser60" },
                    { 61, 0, "HCM", "a51fe06e-42b8-48c1-803c-91ad88c5c5c2", "normaluser61@gmail.com", true, "61", "Nguyen Van", false, null, "normaluser61@gmail.com", "normalUser61", "AQAAAAIAAYagAAAAEFNyNJwbrtsYY/3wWKFgy3Rrv06lfpJuXdo21XuEl7th7+duYdUHPw8bDfnYmtjf3w==", null, false, "", false, "normalUser61" },
                    { 62, 0, "HCM", "86107f21-186d-461c-888e-54d2794e6872", "normaluser62@gmail.com", true, "62", "Nguyen Van", false, null, "normaluser62@gmail.com", "normalUser62", "AQAAAAIAAYagAAAAEHxDNhn29w8WrOIR4n6+F/6y0aHCWB/oXoerivoOVjpfK05Iina9orTZq7WvjKiDbQ==", null, false, "", false, "normalUser62" },
                    { 63, 0, "HCM", "89f33c33-c85e-4343-bbdc-468ff005292e", "normaluser63@gmail.com", true, "63", "Nguyen Van", false, null, "normaluser63@gmail.com", "normalUser63", "AQAAAAIAAYagAAAAEDtlQ+3ayioFAMIu3pHaxiObi+D8psuMOne4Nt4Czqx0fV2CcHHI+KFQ5BghqTNjpw==", null, false, "", false, "normalUser63" },
                    { 64, 0, "HCM", "3a35a023-57e7-47c5-97d9-ee3ced1a36bf", "normaluser64@gmail.com", true, "64", "Nguyen Van", false, null, "normaluser64@gmail.com", "normalUser64", "AQAAAAIAAYagAAAAEEhY4fJZCfwA6oOOKVEMP+noMmAg4Qv0ypqaHGDlMmCjNBw4Xj3q9xBiJOSfJaRFRA==", null, false, "", false, "normalUser64" },
                    { 65, 0, "HCM", "f9c4af46-36bd-403a-84c6-230d38531fe7", "normaluser65@gmail.com", true, "65", "Nguyen Van", false, null, "normaluser65@gmail.com", "normalUser65", "AQAAAAIAAYagAAAAEH25hXoK7GiejGDbQBPoDrwHsXGJyhSmUj6G1ZM469hVC7d1yI0llCyopsJSF3hBZg==", null, false, "", false, "normalUser65" }
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
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
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
                    { 1, 31 },
                    { 1, 32 },
                    { 1, 33 },
                    { 1, 34 },
                    { 1, 35 },
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
                    { 2, 60 },
                    { 2, 61 },
                    { 2, 62 },
                    { 2, 63 },
                    { 2, 64 },
                    { 2, 65 }
                });

            migrationBuilder.InsertData(
                table: "BusinessProfiles",
                columns: new[] { "Id", "AppUserId", "BusinessName" },
                values: new object[,]
                {
                    { 6, 6, "Business 1" },
                    { 7, 7, "Business 2" },
                    { 8, 8, "Business 3" },
                    { 9, 9, "Business 4" },
                    { 10, 10, "Business 5" },
                    { 11, 11, "Business 6" },
                    { 12, 12, "Business 7" },
                    { 13, 13, "Business 8" },
                    { 14, 14, "Business 9" },
                    { 15, 15, "Business 10" },
                    { 16, 16, "Business 11" },
                    { 17, 17, "Business 12" },
                    { 18, 18, "Business 13" },
                    { 19, 19, "Business 14" },
                    { 20, 20, "Business 15" },
                    { 21, 21, "Business 16" },
                    { 22, 22, "Business 17" },
                    { 23, 23, "Business 18" },
                    { 24, 24, "Business 19" },
                    { 25, 25, "Business 20" },
                    { 26, 26, "Business 21" },
                    { 27, 27, "Business 22" },
                    { 28, 28, "Business 23" },
                    { 29, 29, "Business 24" },
                    { 30, 30, "Business 25" },
                    { 31, 31, "Business 26" },
                    { 32, 32, "Business 27" },
                    { 33, 33, "Business 28" },
                    { 34, 34, "Business 29" },
                    { 35, 35, "Business 30" }
                });

            migrationBuilder.InsertData(
                table: "FreelancerProfiles",
                columns: new[] { "Id", "AppUserId", "Description", "Price", "ResumeUrl", "Title" },
                values: new object[,]
                {
                    { 36, 36, "I am 36", 3600.0, "This is my resume", "Title 36" },
                    { 37, 37, "I am 37", 3700.0, "This is my resume", "Title 37" },
                    { 38, 38, "I am 38", 3800.0, "This is my resume", "Title 38" },
                    { 39, 39, "I am 39", 3900.0, "This is my resume", "Title 39" },
                    { 40, 40, "I am 40", 4000.0, "This is my resume", "Title 40" },
                    { 41, 41, "I am 41", 4100.0, "This is my resume", "Title 41" },
                    { 42, 42, "I am 42", 4200.0, "This is my resume", "Title 42" },
                    { 43, 43, "I am 43", 4300.0, "This is my resume", "Title 43" },
                    { 44, 44, "I am 44", 4400.0, "This is my resume", "Title 44" },
                    { 45, 45, "I am 45", 4500.0, "This is my resume", "Title 45" },
                    { 46, 46, "I am 46", 4600.0, "This is my resume", "Title 46" },
                    { 47, 47, "I am 47", 4700.0, "This is my resume", "Title 47" },
                    { 48, 48, "I am 48", 4800.0, "This is my resume", "Title 48" },
                    { 49, 49, "I am 49", 4900.0, "This is my resume", "Title 49" },
                    { 50, 50, "I am 50", 5000.0, "This is my resume", "Title 50" },
                    { 51, 51, "I am 51", 5100.0, "This is my resume", "Title 51" },
                    { 52, 52, "I am 52", 5200.0, "This is my resume", "Title 52" },
                    { 53, 53, "I am 53", 5300.0, "This is my resume", "Title 53" },
                    { 54, 54, "I am 54", 5400.0, "This is my resume", "Title 54" },
                    { 55, 55, "I am 55", 5500.0, "This is my resume", "Title 55" },
                    { 56, 56, "I am 56", 5600.0, "This is my resume", "Title 56" },
                    { 57, 57, "I am 57", 5700.0, "This is my resume", "Title 57" },
                    { 58, 58, "I am 58", 5800.0, "This is my resume", "Title 58" },
                    { 59, 59, "I am 59", 5900.0, "This is my resume", "Title 59" },
                    { 60, 60, "I am 60", 6000.0, "This is my resume", "Title 60" },
                    { 61, 61, "I am 61", 6100.0, "This is my resume", "Title 61" },
                    { 62, 62, "I am 62", 6200.0, "This is my resume", "Title 62" },
                    { 63, 63, "I am 63", 6300.0, "This is my resume", "Title 63" },
                    { 64, 64, "I am 64", 6400.0, "This is my resume", "Title 64" },
                    { 65, 65, "I am 65", 6500.0, "This is my resume", "Title 65" }
                });

            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "Id", "ApplyExpireDate", "BusinessProfileId", "CreatedDate", "Description", "ImageUrl", "IsActive", "JobDescriptionFileUrl", "JobExpiredDate", "Name", "Offer" },
                values: new object[,]
                {
                    { 1, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(4892), "This a simple description for project 1", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 1", 99.0 },
                    { 2, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(4973), "This a simple description for project 2", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 2", 198.0 },
                    { 3, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(4987), "This a simple description for project 3", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 3", 297.0 },
                    { 4, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(5000), "This a simple description for project 4", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 4", 396.0 },
                    { 5, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(5073), "This a simple description for project 5", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 5", 495.0 },
                    { 6, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(5088), "This a simple description for project 6", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 6", 594.0 },
                    { 7, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(5100), "This a simple description for project 7", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 7", 693.0 },
                    { 8, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(5112), "This a simple description for project 8", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 8", 792.0 },
                    { 9, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(5124), "This a simple description for project 9", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 9", 891.0 },
                    { 10, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 33, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(5140), "This a simple description for project 10", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 10", 990.0 },
                    { 11, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(5152), "This a simple description for project 11", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 11", 1089.0 },
                    { 12, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(5164), "This a simple description for project 12", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 12", 1188.0 },
                    { 13, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(5176), "This a simple description for project 13", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 13", 1287.0 },
                    { 14, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(5239), "This a simple description for project 14", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 14", 1386.0 },
                    { 15, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(5254), "This a simple description for project 15", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 15", 1485.0 },
                    { 16, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6290), "This a simple description for project 16", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 16", 1584.0 },
                    { 17, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6310), "This a simple description for project 17", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 17", 1683.0 },
                    { 18, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6328), "This a simple description for project 18", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 18", 1782.0 },
                    { 19, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6340), "This a simple description for project 19", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 19", 1881.0 },
                    { 20, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6352), "This a simple description for project 20", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 20", 1980.0 },
                    { 21, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6364), "This a simple description for project 21", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 21", 2079.0 },
                    { 22, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6376), "This a simple description for project 22", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 22", 2178.0 },
                    { 23, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6451), "This a simple description for project 23", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 23", 2277.0 },
                    { 24, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6466), "This a simple description for project 24", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 24", 2376.0 },
                    { 25, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6478), "This a simple description for project 25", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 25", 2475.0 },
                    { 26, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6490), "This a simple description for project 26", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 26", 2574.0 },
                    { 27, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6502), "This a simple description for project 27", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 27", 2673.0 },
                    { 28, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6514), "This a simple description for project 28", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 28", 2772.0 },
                    { 29, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6526), "This a simple description for project 29", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 29", 2871.0 },
                    { 30, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6554), "This a simple description for project 30", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 30", 2970.0 },
                    { 31, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 32, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6584), "This a simple description for project 31", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 31", 3069.0 },
                    { 32, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6596), "This a simple description for project 32", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 32", 3168.0 },
                    { 33, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6683), "This a simple description for project 33", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 33", 3267.0 },
                    { 34, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6701), "This a simple description for project 34", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 34", 3366.0 },
                    { 35, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6713), "This a simple description for project 35", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 35", 3465.0 },
                    { 36, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6725), "This a simple description for project 36", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 36", 3564.0 },
                    { 37, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 32, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6737), "This a simple description for project 37", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 37", 3663.0 },
                    { 38, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6749), "This a simple description for project 38", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 38", 3762.0 },
                    { 39, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6761), "This a simple description for project 39", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 39", 3861.0 },
                    { 40, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6773), "This a simple description for project 40", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 40", 3960.0 },
                    { 41, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6785), "This a simple description for project 41", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 41", 4059.0 },
                    { 42, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6844), "This a simple description for project 42", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 42", 4158.0 },
                    { 43, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6857), "This a simple description for project 43", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 43", 4257.0 },
                    { 44, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6869), "This a simple description for project 44", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 44", 4356.0 },
                    { 45, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6881), "This a simple description for project 45", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 45", 4455.0 },
                    { 46, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6893), "This a simple description for project 46", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 46", 4554.0 },
                    { 47, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6905), "This a simple description for project 47", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 47", 4653.0 },
                    { 48, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6917), "This a simple description for project 48", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 48", 4752.0 },
                    { 49, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6929), "This a simple description for project 49", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 49", 4851.0 },
                    { 50, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6941), "This a simple description for project 50", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 50", 4950.0 },
                    { 51, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(6953), "This a simple description for project 51", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 51", 5049.0 },
                    { 52, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7015), "This a simple description for project 52", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 52", 5148.0 },
                    { 53, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7027), "This a simple description for project 53", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 53", 5247.0 },
                    { 54, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7039), "This a simple description for project 54", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 54", 5346.0 },
                    { 55, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7051), "This a simple description for project 55", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 55", 5445.0 },
                    { 56, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7063), "This a simple description for project 56", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 56", 5544.0 },
                    { 57, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7074), "This a simple description for project 57", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 57", 5643.0 },
                    { 58, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7086), "This a simple description for project 58", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 58", 5742.0 },
                    { 59, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7099), "This a simple description for project 59", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 59", 5841.0 },
                    { 60, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7110), "This a simple description for project 60", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 60", 5940.0 },
                    { 61, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7174), "This a simple description for project 61", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 61", 6039.0 },
                    { 62, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7188), "This a simple description for project 62", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 62", 6138.0 },
                    { 63, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7200), "This a simple description for project 63", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 63", 6237.0 },
                    { 64, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7212), "This a simple description for project 64", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 64", 6336.0 },
                    { 65, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7224), "This a simple description for project 65", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 65", 6435.0 },
                    { 66, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7239), "This a simple description for project 66", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 66", 6534.0 },
                    { 67, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7252), "This a simple description for project 67", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 67", 6633.0 },
                    { 68, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7264), "This a simple description for project 68", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 68", 6732.0 },
                    { 69, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7326), "This a simple description for project 69", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 69", 6831.0 },
                    { 70, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7338), "This a simple description for project 70", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 70", 6930.0 },
                    { 71, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7350), "This a simple description for project 71", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 71", 7029.0 },
                    { 72, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 32, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7361), "This a simple description for project 72", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 72", 7128.0 },
                    { 73, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 32, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7373), "This a simple description for project 73", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 73", 7227.0 },
                    { 74, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7385), "This a simple description for project 74", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 74", 7326.0 },
                    { 75, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7397), "This a simple description for project 75", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 75", 7425.0 },
                    { 76, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7409), "This a simple description for project 76", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 76", 7524.0 },
                    { 77, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7421), "This a simple description for project 77", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 77", 7623.0 },
                    { 78, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7432), "This a simple description for project 78", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 78", 7722.0 },
                    { 79, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7493), "This a simple description for project 79", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 79", 7821.0 },
                    { 80, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7505), "This a simple description for project 80", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 80", 7920.0 },
                    { 81, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7516), "This a simple description for project 81", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 81", 8019.0 },
                    { 82, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7529), "This a simple description for project 82", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 82", 8118.0 },
                    { 83, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7541), "This a simple description for project 83", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 83", 8217.0 },
                    { 84, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7552), "This a simple description for project 84", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 84", 8316.0 },
                    { 85, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7565), "This a simple description for project 85", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 85", 8415.0 },
                    { 86, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7577), "This a simple description for project 86", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 86", 8514.0 },
                    { 87, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7589), "This a simple description for project 87", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 87", 8613.0 },
                    { 88, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7639), "This a simple description for project 88", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 88", 8712.0 },
                    { 89, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7653), "This a simple description for project 89", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 89", 8811.0 },
                    { 90, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7665), "This a simple description for project 90", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 90", 8910.0 },
                    { 91, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7678), "This a simple description for project 91", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 91", 9009.0 },
                    { 92, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7691), "This a simple description for project 92", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 92", 9108.0 },
                    { 93, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 32, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7703), "This a simple description for project 93", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 93", 9207.0 },
                    { 94, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7715), "This a simple description for project 94", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 94", 9306.0 },
                    { 95, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7727), "This a simple description for project 95", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 95", 9405.0 },
                    { 96, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7738), "This a simple description for project 96", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 96", 9504.0 },
                    { 97, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 33, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7751), "This a simple description for project 97", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 97", 9603.0 },
                    { 98, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7810), "This a simple description for project 98", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 98", 9702.0 },
                    { 99, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7824), "This a simple description for project 99", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 99", 9801.0 },
                    { 100, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 9, 20, 53, 42, 619, DateTimeKind.Local).AddTicks(7837), "This a simple description for project 100", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 100", 9900.0 }
                });

            migrationBuilder.InsertData(
                table: "JobCategories",
                columns: new[] { "CategoryId", "JobId" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 3, 2 },
                    { 6, 3 },
                    { 3, 4 },
                    { 6, 5 },
                    { 7, 6 },
                    { 6, 7 },
                    { 7, 8 },
                    { 2, 9 },
                    { 6, 10 },
                    { 7, 11 },
                    { 6, 12 },
                    { 1, 13 },
                    { 2, 14 },
                    { 5, 15 },
                    { 7, 16 },
                    { 3, 17 },
                    { 2, 18 },
                    { 3, 19 },
                    { 1, 20 },
                    { 5, 21 },
                    { 5, 22 },
                    { 3, 23 },
                    { 3, 24 },
                    { 7, 25 },
                    { 7, 26 },
                    { 3, 27 },
                    { 4, 28 },
                    { 7, 29 },
                    { 1, 30 },
                    { 5, 31 },
                    { 3, 32 },
                    { 7, 33 },
                    { 4, 34 },
                    { 2, 35 },
                    { 1, 36 },
                    { 2, 37 },
                    { 5, 38 },
                    { 1, 39 },
                    { 7, 40 },
                    { 4, 41 },
                    { 5, 42 },
                    { 5, 43 },
                    { 4, 44 },
                    { 3, 45 },
                    { 6, 46 },
                    { 7, 47 },
                    { 3, 48 },
                    { 3, 49 },
                    { 3, 50 },
                    { 4, 51 },
                    { 2, 52 },
                    { 1, 53 },
                    { 7, 54 },
                    { 6, 55 },
                    { 4, 56 },
                    { 2, 57 },
                    { 3, 58 },
                    { 5, 59 },
                    { 5, 60 },
                    { 1, 61 },
                    { 6, 62 },
                    { 4, 63 },
                    { 4, 64 },
                    { 2, 65 },
                    { 3, 66 },
                    { 1, 67 },
                    { 4, 68 },
                    { 6, 69 },
                    { 4, 70 },
                    { 5, 71 },
                    { 6, 72 },
                    { 4, 73 },
                    { 7, 74 },
                    { 1, 75 },
                    { 7, 76 },
                    { 2, 77 },
                    { 3, 78 },
                    { 6, 79 },
                    { 4, 80 },
                    { 5, 81 },
                    { 7, 82 },
                    { 1, 83 },
                    { 5, 84 },
                    { 2, 85 },
                    { 7, 86 },
                    { 1, 87 },
                    { 6, 88 },
                    { 2, 89 },
                    { 5, 90 },
                    { 2, 91 },
                    { 2, 92 },
                    { 7, 93 },
                    { 3, 94 },
                    { 5, 95 },
                    { 7, 96 },
                    { 6, 97 },
                    { 1, 98 },
                    { 5, 99 },
                    { 3, 100 }
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
