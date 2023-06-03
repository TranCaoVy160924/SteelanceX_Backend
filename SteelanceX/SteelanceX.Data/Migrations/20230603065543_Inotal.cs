using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SteelanceX.Data.Migrations
{
    /// <inheritdoc />
    public partial class Inotal : Migration
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResumeUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Offer = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplyExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JobExpiredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobDescriptionFileUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    { 1, 0, "HCM", "7ac3e41e-5c37-4d36-8c42-09df2cd25140", "adminhcm@gmail.com", true, "Toan", "Bach", false, null, "adminhcm@gmail.com", "adminhcm", "AQAAAAIAAYagAAAAEL/yWgElx4OZrpUHSIzNO84uogiwKesthBXnJYf4xaAaA821aoeIAjsIJR9uOxqTcQ==", null, false, "", false, "adminhcm" },
                    { 2, 0, "HCM", "85f93f73-ae5b-427d-b6b6-a7ba4ad3139c", "adminhn@gmail.com", true, "Toan", "Bach", false, null, "adminhn@gmail.com", "adminhn", "AQAAAAIAAYagAAAAEAGMoqgYVBji/W3hb1BrSiJEQ4tSjLPJwxYgTr8pzUoMrIAKienBuvwwJiVebUceng==", null, false, "", false, "adminhn" },
                    { 3, 0, "HCM", "780ded1d-8844-45ba-8ba9-3fd82b687e7c", "staff@gmail.com", true, "Toan", "Bach", false, null, "staff@gmail.com", "staff1", "AQAAAAIAAYagAAAAEKbegtEVaBt97dRnaSjsEraB23Kor0t2DJeIaYxAgBmM4+zPX0Y48AuAlL8NLdkjbQ==", null, false, "", false, "staff1" },
                    { 4, 0, "HCM", "e2c67205-3884-48e2-a39d-d5c270444c0e", "staff@gmail.com", true, "Toan", "Bach", false, null, "staff@gmail.com", "staff2", "AQAAAAIAAYagAAAAEDNx7h+QmgQiDYmJUkpLN7GuictdnsOF2Q/cp6DH3W5FYNwxQOxAQwUqI4O3dHoB/g==", null, false, "", false, "staff2" },
                    { 5, 0, "HCM", "4b75832f-66b2-4256-bbbd-7927f7b36b9c", "staffdis@gmail.com", true, "Toan", "Bach", false, null, "staffdis@gmail.com", "staffdis", "AQAAAAIAAYagAAAAECp3wBg9RCTozoNvFtivP8AmPDvuajRRl2M3ltpADoUyJ2omeITB/L2b7mg1ZJ606w==", null, false, "", false, "staffDis" },
                    { 6, 0, "HCM", "2189055b-d5b7-4a3e-8819-b9472509fadb", "normaluser6@gmail.com", true, "6", "Nguyen Van", false, null, "normaluser6@gmail.com", "normalUser6", "AQAAAAIAAYagAAAAEFQBf2nFba2cUMv2aSG/eTN3X+s6+WjODozulXvz6NecnfNG2+iUpM9P19yfldbfVQ==", null, false, "", false, "normalUser6" },
                    { 7, 0, "HCM", "7f81aead-b903-43c4-a53b-df1893dd20e7", "normaluser7@gmail.com", true, "7", "Nguyen Van", false, null, "normaluser7@gmail.com", "normalUser7", "AQAAAAIAAYagAAAAEFGoQTCqC/kA8qGqArtKzTOnvqRSit4K7do0xD3xZ82FOcC5WnjXW+kanfWp9egZzA==", null, false, "", false, "normalUser7" },
                    { 8, 0, "HCM", "f70b63c4-a89e-41e8-bf1f-069270f9a41d", "normaluser8@gmail.com", true, "8", "Nguyen Van", false, null, "normaluser8@gmail.com", "normalUser8", "AQAAAAIAAYagAAAAEOW/Ixrpk8VHQwMYW0QNbcacrP/2G1uP7zImvIZgIF+wnM+bvNp9ZapXY6Z3A5E/Jw==", null, false, "", false, "normalUser8" },
                    { 9, 0, "HCM", "0434548e-7069-4285-acc3-353e46fd8f21", "normaluser9@gmail.com", true, "9", "Nguyen Van", false, null, "normaluser9@gmail.com", "normalUser9", "AQAAAAIAAYagAAAAEMwR22Eyq5aAnBP50Efy9DKvnWjnlfW360z42XC9nlYw/yZsGmDR/Pie82AjixvGaw==", null, false, "", false, "normalUser9" },
                    { 10, 0, "HCM", "db664b0b-a4c0-47af-a586-e3c3051ac4fd", "normaluser10@gmail.com", true, "10", "Nguyen Van", false, null, "normaluser10@gmail.com", "normalUser10", "AQAAAAIAAYagAAAAEEPZhGOdfQKKPcQcMf7QTTtp4NkbGbbT/rKzIkNIfuy9eEYCtwRy5G91psS6CpB3oQ==", null, false, "", false, "normalUser10" },
                    { 11, 0, "HCM", "7560eee8-354c-40d7-aa32-d097cc457774", "normaluser11@gmail.com", true, "11", "Nguyen Van", false, null, "normaluser11@gmail.com", "normalUser11", "AQAAAAIAAYagAAAAELgFEW6I+btS+KPkU/RzmeXeYNSkODCOvIr23QqYBT9SzKOGJSS/8ggf16PcC5AqJA==", null, false, "", false, "normalUser11" },
                    { 12, 0, "HCM", "0e98f660-958c-4cb4-8774-da62bc3f6ae6", "normaluser12@gmail.com", true, "12", "Nguyen Van", false, null, "normaluser12@gmail.com", "normalUser12", "AQAAAAIAAYagAAAAEFZvKW6TcRTm8qmJEbKv6NyeidzDa0cafjNEtRk6wkZcSpXR52iw/F9e7esIzSFo4w==", null, false, "", false, "normalUser12" },
                    { 13, 0, "HCM", "2aa4544e-85c8-43dc-9b22-d9e3ccfc28bb", "normaluser13@gmail.com", true, "13", "Nguyen Van", false, null, "normaluser13@gmail.com", "normalUser13", "AQAAAAIAAYagAAAAENYsb7QDvhNZR5VIl7aQLGR3oLM7haVXcb5WHtWiNXu6/5icusZbQ7wsQ+nOIrQmwA==", null, false, "", false, "normalUser13" },
                    { 14, 0, "HCM", "eccdd211-ec83-45a2-98d8-bb3549e29042", "normaluser14@gmail.com", true, "14", "Nguyen Van", false, null, "normaluser14@gmail.com", "normalUser14", "AQAAAAIAAYagAAAAEM7X9bSTJaPBWE7py0aANITr2Khb9oOedY+lhclPNpz9dHfpvmVLTQHwBvxyRhx3jw==", null, false, "", false, "normalUser14" },
                    { 15, 0, "HCM", "c074c764-dd97-47e9-85b7-1ec030f814c1", "normaluser15@gmail.com", true, "15", "Nguyen Van", false, null, "normaluser15@gmail.com", "normalUser15", "AQAAAAIAAYagAAAAEG+niCz6IhixCgVjmA+DsS3CBry0R7WuQC/QJRR/axdAqv17/i39Bbto3zmPttV3DQ==", null, false, "", false, "normalUser15" },
                    { 16, 0, "HCM", "2e2ce04f-a94b-4e80-a5b4-c1ecbd73561c", "normaluser16@gmail.com", true, "16", "Nguyen Van", false, null, "normaluser16@gmail.com", "normalUser16", "AQAAAAIAAYagAAAAEJ/j1RzWHIbAwyfMQ4+zyUMJ2IU4G5qi9YU/19qTsXryz1mIabl38TcsHrTWT/tePg==", null, false, "", false, "normalUser16" },
                    { 17, 0, "HCM", "23534734-a366-4a8c-a41d-27007fed0f8a", "normaluser17@gmail.com", true, "17", "Nguyen Van", false, null, "normaluser17@gmail.com", "normalUser17", "AQAAAAIAAYagAAAAEBZJ8hUCzLT7c598dY9EZqmmZNxPblrof1yd9+vfvqy+tT3dAcSadNuij2fXsh0ilw==", null, false, "", false, "normalUser17" },
                    { 18, 0, "HCM", "0cd969a1-f423-42a5-9538-a2b5e48643c2", "normaluser18@gmail.com", true, "18", "Nguyen Van", false, null, "normaluser18@gmail.com", "normalUser18", "AQAAAAIAAYagAAAAECELtg+hJlWMwaKHmXCSCNMV8YXIQdjGUsveQnevob1I71oRkJ4phONFeRl3/COGAQ==", null, false, "", false, "normalUser18" },
                    { 19, 0, "HCM", "a0e0414e-b503-4783-afe4-cbc6511ff37e", "normaluser19@gmail.com", true, "19", "Nguyen Van", false, null, "normaluser19@gmail.com", "normalUser19", "AQAAAAIAAYagAAAAENoUkPCPyaeU3P5GConorqtsT1VAPF2qF7cIINTQ7/QQGMco+rtOz+y6bcT5YbmK6Q==", null, false, "", false, "normalUser19" },
                    { 20, 0, "HCM", "8ac66cf9-6148-4a7c-85c3-78808ca56862", "normaluser20@gmail.com", true, "20", "Nguyen Van", false, null, "normaluser20@gmail.com", "normalUser20", "AQAAAAIAAYagAAAAEO61IW+mJYJxpQSJiXOA1lP4Wo2Beyz9Dc8gMTTtiaxLMLbDRGW/RaqzafZLemTRWg==", null, false, "", false, "normalUser20" },
                    { 21, 0, "HCM", "d624142b-3786-4537-97be-e21088c05a2d", "normaluser21@gmail.com", true, "21", "Nguyen Van", false, null, "normaluser21@gmail.com", "normalUser21", "AQAAAAIAAYagAAAAEIO6DDrEdrZzN+6oOeRiJwzjdXIPcuzfgDvJaPktRRfM65tkpD5VEW1lQ8uMYF4S/w==", null, false, "", false, "normalUser21" },
                    { 22, 0, "HCM", "acdf3872-759b-4131-a3d3-d5e89bd4b684", "normaluser22@gmail.com", true, "22", "Nguyen Van", false, null, "normaluser22@gmail.com", "normalUser22", "AQAAAAIAAYagAAAAEJt9Chc+9cp36qOrIWGpGpNxGeZGwSdG6OOIclY1Co/4P3dQBmaqq5i245kgSBZlsA==", null, false, "", false, "normalUser22" },
                    { 23, 0, "HCM", "f1ae0bdf-1cbb-47a3-b9df-63045d7c99c8", "normaluser23@gmail.com", true, "23", "Nguyen Van", false, null, "normaluser23@gmail.com", "normalUser23", "AQAAAAIAAYagAAAAEOKsuR2AqXOCR1rrxdYnuw3VwRXTRTpqjkAdHT+6dviR4neFYiGY1vcAFXcrw5WsQg==", null, false, "", false, "normalUser23" },
                    { 24, 0, "HCM", "08201b61-ec8b-42de-99b1-798649308ecc", "normaluser24@gmail.com", true, "24", "Nguyen Van", false, null, "normaluser24@gmail.com", "normalUser24", "AQAAAAIAAYagAAAAENUH+6tiumFLohZIPfgr5utD3yMI8s81nAPh1srwCnm06gI7GdFJCl1XOG1kcnaWsw==", null, false, "", false, "normalUser24" },
                    { 25, 0, "HCM", "6f0c8b33-2b8c-4ff4-bbd1-d658f9e03159", "normaluser25@gmail.com", true, "25", "Nguyen Van", false, null, "normaluser25@gmail.com", "normalUser25", "AQAAAAIAAYagAAAAEGkwDV1sFU9IgH8k6rNhPH48fXDXJU2RNT3d8fg8NPF5LHFrJZncH4qr1gpW/Yfk3g==", null, false, "", false, "normalUser25" },
                    { 26, 0, "HCM", "67063735-dfcd-4c71-b9c7-7acd682d8ba3", "normaluser26@gmail.com", true, "26", "Nguyen Van", false, null, "normaluser26@gmail.com", "normalUser26", "AQAAAAIAAYagAAAAED3JXmU4DsYVoU5559CSWz4O7HofkGBfryEFMJhyct/s5swb2DXXUYzIz/Uxt/VpFA==", null, false, "", false, "normalUser26" },
                    { 27, 0, "HCM", "a82fbfd0-0f25-4907-a99f-cf29840b74cb", "normaluser27@gmail.com", true, "27", "Nguyen Van", false, null, "normaluser27@gmail.com", "normalUser27", "AQAAAAIAAYagAAAAELRGYlli2q+y4LOikBCQBOv2f+lg08G8AQ/iyTfA8Ua6qZI8bhXtMBukZkQ8lvsKbw==", null, false, "", false, "normalUser27" },
                    { 28, 0, "HCM", "381bcad3-4eae-43a7-94c6-e1d3d0e8b1d8", "normaluser28@gmail.com", true, "28", "Nguyen Van", false, null, "normaluser28@gmail.com", "normalUser28", "AQAAAAIAAYagAAAAEIkRA/4IYlkd5x3euup4sgYtz9sYjCespeZDcQEBMI4Lm7Q15AhRqRaZOaJlv8888g==", null, false, "", false, "normalUser28" },
                    { 29, 0, "HCM", "4178e37c-ad7d-46d1-a521-6786dacb2eb1", "normaluser29@gmail.com", true, "29", "Nguyen Van", false, null, "normaluser29@gmail.com", "normalUser29", "AQAAAAIAAYagAAAAEJaKgKXt+hiu58T1B0JZ9Q6b+nJWl+cTYbMfySSspuDnOllkCJ3ZadwVo3FIk+dPGg==", null, false, "", false, "normalUser29" },
                    { 30, 0, "HCM", "bb20199c-aa19-4e4d-97fd-264f2e14bd70", "normaluser30@gmail.com", true, "30", "Nguyen Van", false, null, "normaluser30@gmail.com", "normalUser30", "AQAAAAIAAYagAAAAEJ5aNDM+0HWcmp3tDVwDh+FZaUvWgmxtADe5cYzq2rm+0He4JJ4G9TRWKRDu+mNhzw==", null, false, "", false, "normalUser30" },
                    { 31, 0, "HCM", "1ee532dc-ac15-4c9a-9e87-c6dbfba40c50", "normaluser31@gmail.com", true, "31", "Nguyen Van", false, null, "normaluser31@gmail.com", "normalUser31", "AQAAAAIAAYagAAAAENX8LyGnmDsjcVv+1QrvWr8mNwlzoB2t/dyR9r3wkV/p+GWRicxJ24f9za/1ndAQqQ==", null, false, "", false, "normalUser31" },
                    { 32, 0, "HCM", "ff51c348-b35c-4bf8-ab8a-8cc5404c442a", "normaluser32@gmail.com", true, "32", "Nguyen Van", false, null, "normaluser32@gmail.com", "normalUser32", "AQAAAAIAAYagAAAAEPtdvXvHVtvcpT6nOGLTw8lwK4lfQBSQjdZfcBVBtqQlouXwrb27Ph7M/1ocDlQGNg==", null, false, "", false, "normalUser32" },
                    { 33, 0, "HCM", "fb1a1c87-b814-4f93-99b4-bb39e491d7ee", "normaluser33@gmail.com", true, "33", "Nguyen Van", false, null, "normaluser33@gmail.com", "normalUser33", "AQAAAAIAAYagAAAAEHVjZSH5jrckXptSawe+HsGTzMV3Wwgwm+Q7bK/pvtnGGjSgC12lgxDo2om4HNc0Kg==", null, false, "", false, "normalUser33" },
                    { 34, 0, "HCM", "538da2b8-cbd4-4bf2-8979-6b3ff047c3fb", "normaluser34@gmail.com", true, "34", "Nguyen Van", false, null, "normaluser34@gmail.com", "normalUser34", "AQAAAAIAAYagAAAAEH8TgMQSj5One5hD36kOvgVsw4rUhnaxhYn37rWVSiwM2xtbcqEV7y7iOeebC+uIrA==", null, false, "", false, "normalUser34" },
                    { 35, 0, "HCM", "0c3046da-4d38-4b8c-ac7c-f3ebf644ea5c", "normaluser35@gmail.com", true, "35", "Nguyen Van", false, null, "normaluser35@gmail.com", "normalUser35", "AQAAAAIAAYagAAAAEAcp9xWg4JGsM6EKT4uURk7pDKQ2W7klqEhbbqX+cAHD6jjysFtDoW0yREscuPyVbA==", null, false, "", false, "normalUser35" },
                    { 36, 0, "HCM", "cf3a7b2b-5315-4084-b7cd-b659e0d2568f", "normaluser36@gmail.com", true, "36", "Nguyen Van", false, null, "normaluser36@gmail.com", "normalUser36", "AQAAAAIAAYagAAAAENi9z/uNMh5cqE7PLwOCDrWFprawZiMLrDLCBbnWQXXfyGOculE3A1yveEIdNAK1Mg==", null, false, "", false, "normalUser36" },
                    { 37, 0, "HCM", "8c6870c7-7cee-40df-9fcb-67934e32158c", "normaluser37@gmail.com", true, "37", "Nguyen Van", false, null, "normaluser37@gmail.com", "normalUser37", "AQAAAAIAAYagAAAAEJY/rzbBSEZuXCyJ0gH9svOwpB8oyg9cwp+RYV2M4XCQAeWt9q53dMc423LLTly26Q==", null, false, "", false, "normalUser37" },
                    { 38, 0, "HCM", "1702808e-5fa1-472e-bd27-bdd5b0de8ae4", "normaluser38@gmail.com", true, "38", "Nguyen Van", false, null, "normaluser38@gmail.com", "normalUser38", "AQAAAAIAAYagAAAAEImTYi2Ic8QcYGc9HZmITCJfydoMjh2wcOTM2YP8IMeZRkxg3arBfX8MJ4e2EAugFA==", null, false, "", false, "normalUser38" },
                    { 39, 0, "HCM", "7409c0d6-304a-43f0-ba3d-b1635474113a", "normaluser39@gmail.com", true, "39", "Nguyen Van", false, null, "normaluser39@gmail.com", "normalUser39", "AQAAAAIAAYagAAAAELgRH5kJ2TLl1vDrJKCXUYMl+P0usRokKgi4nEeTuEwU+bprEM7qFk1nvjthpf+now==", null, false, "", false, "normalUser39" },
                    { 40, 0, "HCM", "fe86e29b-ee04-44d2-a290-6a57c369ed6b", "normaluser40@gmail.com", true, "40", "Nguyen Van", false, null, "normaluser40@gmail.com", "normalUser40", "AQAAAAIAAYagAAAAENinT0rww/eBpDmn96m0clHVW3H55fFWLPtTkAjobv6IGamNwwOhCs0DJb+o8iazWg==", null, false, "", false, "normalUser40" },
                    { 41, 0, "HCM", "8c9bccd0-db3c-4efc-a039-5ef77239ecc6", "normaluser41@gmail.com", true, "41", "Nguyen Van", false, null, "normaluser41@gmail.com", "normalUser41", "AQAAAAIAAYagAAAAEHYey6JicIVQ6JtEMREgPs9hnTr+Y4ALVxpSqd1j4vHWISa1bf8J/EThKvPCLJReXw==", null, false, "", false, "normalUser41" },
                    { 42, 0, "HCM", "88a46a61-174c-4dd9-8c7b-a6a970fabf3f", "normaluser42@gmail.com", true, "42", "Nguyen Van", false, null, "normaluser42@gmail.com", "normalUser42", "AQAAAAIAAYagAAAAEG0mB+XxkERUoJJeMj+gekiOVwvtX1B8ZQ7iLCTrNOCUjQAx35Q/9zXJF0O5GXMy4g==", null, false, "", false, "normalUser42" },
                    { 43, 0, "HCM", "a1482e59-d258-4b3f-9695-2485749e60d1", "normaluser43@gmail.com", true, "43", "Nguyen Van", false, null, "normaluser43@gmail.com", "normalUser43", "AQAAAAIAAYagAAAAELAHBtQiRnz2qsdsuilrVZP9EygZv9B9m0clQTA0gLoP6Jvo8LEI8zwLuXKWWRqJTA==", null, false, "", false, "normalUser43" },
                    { 44, 0, "HCM", "e7e8798a-f778-416b-be2a-8c6d3434bb5f", "normaluser44@gmail.com", true, "44", "Nguyen Van", false, null, "normaluser44@gmail.com", "normalUser44", "AQAAAAIAAYagAAAAEMnjtBaidgWPbrDGOoSNd6APFDqtiCfb3Dj2s/j493vkocRxDnjGzT45xb7GqzdiEg==", null, false, "", false, "normalUser44" },
                    { 45, 0, "HCM", "1684d7c6-7314-472f-9e75-4e4e6265ae70", "normaluser45@gmail.com", true, "45", "Nguyen Van", false, null, "normaluser45@gmail.com", "normalUser45", "AQAAAAIAAYagAAAAEAeV1SU3C20Ko2DEYxS3pJmq1/7vTBxWr8ip7HMfoQHnsBOIYDZrDLQzHVz9kXG6bQ==", null, false, "", false, "normalUser45" },
                    { 46, 0, "HCM", "fd9ff8cb-5eae-4593-b5ae-e5ba8bd6ed78", "normaluser46@gmail.com", true, "46", "Nguyen Van", false, null, "normaluser46@gmail.com", "normalUser46", "AQAAAAIAAYagAAAAEOcxaiDggGLP20JTDZ8Y8QAD2z+y1cFsnHX4eIQJLdPom990Zua5ypjj33/chD2MfQ==", null, false, "", false, "normalUser46" },
                    { 47, 0, "HCM", "1dcbb495-55c6-4914-90eb-0cb5d98127af", "normaluser47@gmail.com", true, "47", "Nguyen Van", false, null, "normaluser47@gmail.com", "normalUser47", "AQAAAAIAAYagAAAAEHBQvSQBtIAJyLiKvWtSJ98uFIBZw3DxyweW74Vbp5pICO7HJEUPt6PIgtDWuIBrfg==", null, false, "", false, "normalUser47" },
                    { 48, 0, "HCM", "6f728aa3-4a97-4dc5-8fe8-744f0250c5ba", "normaluser48@gmail.com", true, "48", "Nguyen Van", false, null, "normaluser48@gmail.com", "normalUser48", "AQAAAAIAAYagAAAAEO5Keeuu5w5PEV1hBj/uE24/DScHaWmLf17JJciyvVrwIVQ5Jfb0Z1pHweFq7TohZw==", null, false, "", false, "normalUser48" },
                    { 49, 0, "HCM", "3f80a462-9b24-43b6-a384-d99c5ce5a24c", "normaluser49@gmail.com", true, "49", "Nguyen Van", false, null, "normaluser49@gmail.com", "normalUser49", "AQAAAAIAAYagAAAAELzncderJ6/kmW6OHtDKUr2kSOUCIesjjkUOOFTwDH0HCqqo8/nNlXd1nGOs2yt8MA==", null, false, "", false, "normalUser49" },
                    { 50, 0, "HCM", "b4cac058-c25a-46ef-9a7f-ab73ecc22da2", "normaluser50@gmail.com", true, "50", "Nguyen Van", false, null, "normaluser50@gmail.com", "normalUser50", "AQAAAAIAAYagAAAAEPDWAxK/MxnuEcs99YnM4E//YbnMelp91+6c/vU4GvReTe8UXirlpfic225g5o/Ivg==", null, false, "", false, "normalUser50" },
                    { 51, 0, "HCM", "4bda7c37-2c46-4da1-8ff1-67752b41e738", "normaluser51@gmail.com", true, "51", "Nguyen Van", false, null, "normaluser51@gmail.com", "normalUser51", "AQAAAAIAAYagAAAAEBQVG1ozFJvFf42TDkyoD4D78wTp01AM6DyzYGbCFsDuiLwNGA6jBGS1mFPiT2yp7Q==", null, false, "", false, "normalUser51" },
                    { 52, 0, "HCM", "ef65bb07-2ad5-49d1-8ce8-a30f35cf824b", "normaluser52@gmail.com", true, "52", "Nguyen Van", false, null, "normaluser52@gmail.com", "normalUser52", "AQAAAAIAAYagAAAAEDloi9zZJdnA4IlscBZarmTDjVqTnd7T/mU0G4lEPBJN27yrvVxsUbyfe01w5Xm6qQ==", null, false, "", false, "normalUser52" },
                    { 53, 0, "HCM", "6b510d6a-f5ae-44de-a71c-998c2d6f1251", "normaluser53@gmail.com", true, "53", "Nguyen Van", false, null, "normaluser53@gmail.com", "normalUser53", "AQAAAAIAAYagAAAAEGSui4DGM1KBrmZ+c6BoXLmWNRU72RluMJG0Z6JxkTvRyK4MB+5tkE0ylcPUcXMy+w==", null, false, "", false, "normalUser53" },
                    { 54, 0, "HCM", "47eb75f6-2a04-435e-9a14-49933ceeb111", "normaluser54@gmail.com", true, "54", "Nguyen Van", false, null, "normaluser54@gmail.com", "normalUser54", "AQAAAAIAAYagAAAAEEWAQHdx9+yPA+5oe1gD0aKNWgl6WJw4lse9kagZ2+loTGw/f+yJDwjg0blkx3rSng==", null, false, "", false, "normalUser54" },
                    { 55, 0, "HCM", "a8d3f731-6436-4dd6-9bf4-24eec73b2ed2", "normaluser55@gmail.com", true, "55", "Nguyen Van", false, null, "normaluser55@gmail.com", "normalUser55", "AQAAAAIAAYagAAAAEKme7Siw04xdC1IxA/noUe2AuSbTlVYTsC+o/Lfk7WgOuqngs6OSdZQfGGt1F5oe4w==", null, false, "", false, "normalUser55" },
                    { 56, 0, "HCM", "6028cbc2-6564-4795-bb8d-c3118e982263", "normaluser56@gmail.com", true, "56", "Nguyen Van", false, null, "normaluser56@gmail.com", "normalUser56", "AQAAAAIAAYagAAAAEExNC0mdt5bhVXBizvKjDwt8JlpI3wElau7zUGrSnLywyyUcgFWtMx232AhEEMEnhg==", null, false, "", false, "normalUser56" },
                    { 57, 0, "HCM", "14e803b9-fd0d-4486-b847-935bbe80bc70", "normaluser57@gmail.com", true, "57", "Nguyen Van", false, null, "normaluser57@gmail.com", "normalUser57", "AQAAAAIAAYagAAAAECMOJXWuYA0hwnUKUXT/GtjJgyDmszb07WZtfQteiqyoILHga3uoZ4n8qOfqsEm24w==", null, false, "", false, "normalUser57" },
                    { 58, 0, "HCM", "a07c9a19-4e81-4d1d-8f8f-0f9403d4e6d0", "normaluser58@gmail.com", true, "58", "Nguyen Van", false, null, "normaluser58@gmail.com", "normalUser58", "AQAAAAIAAYagAAAAEJJUTj/q5RAEb/kPn8H34d3oBB4ioS+C38w3BQ+auZnx11A/YPSo+sSmnvsM9azXDg==", null, false, "", false, "normalUser58" },
                    { 59, 0, "HCM", "e69db0fd-1676-4275-93e7-3f70a4b743c0", "normaluser59@gmail.com", true, "59", "Nguyen Van", false, null, "normaluser59@gmail.com", "normalUser59", "AQAAAAIAAYagAAAAEC8E1ZqiOW1/OPXeaxiDaUxPhaL1fqTWa24F6wziXaWv+MitqDjF9HTkUbWB1sbxmQ==", null, false, "", false, "normalUser59" },
                    { 60, 0, "HCM", "fea726f9-fff5-44ec-b711-ac42fbf3d630", "normaluser60@gmail.com", true, "60", "Nguyen Van", false, null, "normaluser60@gmail.com", "normalUser60", "AQAAAAIAAYagAAAAEPK/QAyp2fSRhsWNoB2+i1K/DFQI+PW8ieQswHdzmX/Zwnh91sxBJZIZB6NobFIHjg==", null, false, "", false, "normalUser60" },
                    { 61, 0, "HCM", "d9291eb4-c00c-4091-9c84-9cf0eaf70621", "normaluser61@gmail.com", true, "61", "Nguyen Van", false, null, "normaluser61@gmail.com", "normalUser61", "AQAAAAIAAYagAAAAELApn5pSe63vEsBNEWXW/26hnyq3mJmcBHKV6BeSG6EZYntwPUX83Q8Yod2cisTbDQ==", null, false, "", false, "normalUser61" },
                    { 62, 0, "HCM", "dc84092c-bb09-41a7-b417-ca20abae94c2", "normaluser62@gmail.com", true, "62", "Nguyen Van", false, null, "normaluser62@gmail.com", "normalUser62", "AQAAAAIAAYagAAAAEDsTXRNqNXW6aMazdmZzQMzqwys718Nr0xsfq8qt4X7C2Sv0Djgsbtxp/bAm9uiuZg==", null, false, "", false, "normalUser62" },
                    { 63, 0, "HCM", "d6537cb0-9f05-4aac-856b-4cd86180f5c5", "normaluser63@gmail.com", true, "63", "Nguyen Van", false, null, "normaluser63@gmail.com", "normalUser63", "AQAAAAIAAYagAAAAEPI6YROtMvrGtgjrsEVc5MTMYaycoe3dP+zn838kM4bmX6GVuf7sHgfeozLOByEgYw==", null, false, "", false, "normalUser63" },
                    { 64, 0, "HCM", "2930e5d8-85a2-42b1-99cd-2274a62989a9", "normaluser64@gmail.com", true, "64", "Nguyen Van", false, null, "normaluser64@gmail.com", "normalUser64", "AQAAAAIAAYagAAAAEEAYOvFFjYKlARjssyvpgiPw1E2nakZQakj+o5B7iiVfhJh3DhswesvECBGtlJbUkw==", null, false, "", false, "normalUser64" },
                    { 65, 0, "HCM", "3fde29c7-93cf-41fc-8d39-8277ed82bb26", "normaluser65@gmail.com", true, "65", "Nguyen Van", false, null, "normaluser65@gmail.com", "normalUser65", "AQAAAAIAAYagAAAAEPxmFGFzsrAvYWr7aGxxNjM4NRzvpGkAoWKEe/BzQCtslfjQK7ERBn9H844zGcO04g==", null, false, "", false, "normalUser65" }
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
                columns: new[] { "Id", "AppUserId" },
                values: new object[,]
                {
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 },
                    { 11, 11 },
                    { 12, 12 },
                    { 13, 13 },
                    { 14, 14 },
                    { 15, 15 },
                    { 16, 16 },
                    { 17, 17 },
                    { 18, 18 },
                    { 19, 19 },
                    { 20, 20 },
                    { 21, 21 },
                    { 22, 22 },
                    { 23, 23 },
                    { 24, 24 },
                    { 25, 25 },
                    { 26, 26 },
                    { 27, 27 },
                    { 28, 28 },
                    { 29, 29 },
                    { 30, 30 },
                    { 31, 31 },
                    { 32, 32 },
                    { 33, 33 },
                    { 34, 34 },
                    { 35, 35 }
                });

            migrationBuilder.InsertData(
                table: "FreelancerProfiles",
                columns: new[] { "Id", "AppUserId", "Description", "ResumeUrl" },
                values: new object[,]
                {
                    { 36, 36, "I am 36", "This is my resume" },
                    { 37, 37, "I am 37", "This is my resume" },
                    { 38, 38, "I am 38", "This is my resume" },
                    { 39, 39, "I am 39", "This is my resume" },
                    { 40, 40, "I am 40", "This is my resume" },
                    { 41, 41, "I am 41", "This is my resume" },
                    { 42, 42, "I am 42", "This is my resume" },
                    { 43, 43, "I am 43", "This is my resume" },
                    { 44, 44, "I am 44", "This is my resume" },
                    { 45, 45, "I am 45", "This is my resume" },
                    { 46, 46, "I am 46", "This is my resume" },
                    { 47, 47, "I am 47", "This is my resume" },
                    { 48, 48, "I am 48", "This is my resume" },
                    { 49, 49, "I am 49", "This is my resume" },
                    { 50, 50, "I am 50", "This is my resume" },
                    { 51, 51, "I am 51", "This is my resume" },
                    { 52, 52, "I am 52", "This is my resume" },
                    { 53, 53, "I am 53", "This is my resume" },
                    { 54, 54, "I am 54", "This is my resume" },
                    { 55, 55, "I am 55", "This is my resume" },
                    { 56, 56, "I am 56", "This is my resume" },
                    { 57, 57, "I am 57", "This is my resume" },
                    { 58, 58, "I am 58", "This is my resume" },
                    { 59, 59, "I am 59", "This is my resume" },
                    { 60, 60, "I am 60", "This is my resume" },
                    { 61, 61, "I am 61", "This is my resume" },
                    { 62, 62, "I am 62", "This is my resume" },
                    { 63, 63, "I am 63", "This is my resume" },
                    { 64, 64, "I am 64", "This is my resume" },
                    { 65, 65, "I am 65", "This is my resume" }
                });

            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "Id", "ApplyExpireDate", "BusinessProfileId", "CreatedDate", "Description", "ImageUrl", "IsActive", "JobDescriptionFileUrl", "JobExpiredDate", "Name", "Offer" },
                values: new object[,]
                {
                    { 1, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(473), "This a simple description for project 1", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 1", 99.0 },
                    { 2, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(549), "This a simple description for project 2", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 2", 198.0 },
                    { 3, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(564), "This a simple description for project 3", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 3", 297.0 },
                    { 4, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(577), "This a simple description for project 4", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 4", 396.0 },
                    { 5, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(590), "This a simple description for project 5", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 5", 495.0 },
                    { 6, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(605), "This a simple description for project 6", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 6", 594.0 },
                    { 7, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 33, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(676), "This a simple description for project 7", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 7", 693.0 },
                    { 8, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(693), "This a simple description for project 8", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 8", 792.0 },
                    { 9, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 33, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(705), "This a simple description for project 9", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 9", 891.0 },
                    { 10, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(721), "This a simple description for project 10", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 10", 990.0 },
                    { 11, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(735), "This a simple description for project 11", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 11", 1089.0 },
                    { 12, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(748), "This a simple description for project 12", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 12", 1188.0 },
                    { 13, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(761), "This a simple description for project 13", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 13", 1287.0 },
                    { 14, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(773), "This a simple description for project 14", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 14", 1386.0 },
                    { 15, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(786), "This a simple description for project 15", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 15", 1485.0 },
                    { 16, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(1769), "This a simple description for project 16", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 16", 1584.0 },
                    { 17, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(1855), "This a simple description for project 17", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 17", 1683.0 },
                    { 18, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(1873), "This a simple description for project 18", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 18", 1782.0 },
                    { 19, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(1885), "This a simple description for project 19", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 19", 1881.0 },
                    { 20, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(1898), "This a simple description for project 20", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 20", 1980.0 },
                    { 21, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(1911), "This a simple description for project 21", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 21", 2079.0 },
                    { 22, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(1924), "This a simple description for project 22", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 22", 2178.0 },
                    { 23, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 32, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(1937), "This a simple description for project 23", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 23", 2277.0 },
                    { 24, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(1950), "This a simple description for project 24", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 24", 2376.0 },
                    { 25, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(1963), "This a simple description for project 25", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 25", 2475.0 },
                    { 26, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 30, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2024), "This a simple description for project 26", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 26", 2574.0 },
                    { 27, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2038), "This a simple description for project 27", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 27", 2673.0 },
                    { 28, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2051), "This a simple description for project 28", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 28", 2772.0 },
                    { 29, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2064), "This a simple description for project 29", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 29", 2871.0 },
                    { 30, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2098), "This a simple description for project 30", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 30", 2970.0 },
                    { 31, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2130), "This a simple description for project 31", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 31", 3069.0 },
                    { 32, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 30, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2143), "This a simple description for project 32", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 32", 3168.0 },
                    { 33, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2156), "This a simple description for project 33", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 33", 3267.0 },
                    { 34, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2219), "This a simple description for project 34", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 34", 3366.0 },
                    { 35, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 30, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2234), "This a simple description for project 35", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 35", 3465.0 },
                    { 36, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2247), "This a simple description for project 36", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 36", 3564.0 },
                    { 37, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2260), "This a simple description for project 37", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 37", 3663.0 },
                    { 38, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 33, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2272), "This a simple description for project 38", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 38", 3762.0 },
                    { 39, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2285), "This a simple description for project 39", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 39", 3861.0 },
                    { 40, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2298), "This a simple description for project 40", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 40", 3960.0 },
                    { 41, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2311), "This a simple description for project 41", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 41", 4059.0 },
                    { 42, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2324), "This a simple description for project 42", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 42", 4158.0 },
                    { 43, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2337), "This a simple description for project 43", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 43", 4257.0 },
                    { 44, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2391), "This a simple description for project 44", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 44", 4356.0 },
                    { 45, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2405), "This a simple description for project 45", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 45", 4455.0 },
                    { 46, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2418), "This a simple description for project 46", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 46", 4554.0 },
                    { 47, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2431), "This a simple description for project 47", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 47", 4653.0 },
                    { 48, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2444), "This a simple description for project 48", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 48", 4752.0 },
                    { 49, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2456), "This a simple description for project 49", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 49", 4851.0 },
                    { 50, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2469), "This a simple description for project 50", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 50", 4950.0 },
                    { 51, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2482), "This a simple description for project 51", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 51", 5049.0 },
                    { 52, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2496), "This a simple description for project 52", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 52", 5148.0 },
                    { 53, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2510), "This a simple description for project 53", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 53", 5247.0 },
                    { 54, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2564), "This a simple description for project 54", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 54", 5346.0 },
                    { 55, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2579), "This a simple description for project 55", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 55", 5445.0 },
                    { 56, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2592), "This a simple description for project 56", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 56", 5544.0 },
                    { 57, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2605), "This a simple description for project 57", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 57", 5643.0 },
                    { 58, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2619), "This a simple description for project 58", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 58", 5742.0 },
                    { 59, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2632), "This a simple description for project 59", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 59", 5841.0 },
                    { 60, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 33, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2646), "This a simple description for project 60", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 60", 5940.0 },
                    { 61, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2659), "This a simple description for project 61", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 61", 6039.0 },
                    { 62, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2672), "This a simple description for project 62", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 62", 6138.0 },
                    { 63, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2685), "This a simple description for project 63", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 63", 6237.0 },
                    { 64, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2738), "This a simple description for project 64", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 64", 6336.0 },
                    { 65, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2753), "This a simple description for project 65", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 65", 6435.0 },
                    { 66, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2768), "This a simple description for project 66", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 66", 6534.0 },
                    { 67, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2781), "This a simple description for project 67", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 67", 6633.0 },
                    { 68, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 33, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2795), "This a simple description for project 68", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 68", 6732.0 },
                    { 69, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2808), "This a simple description for project 69", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 69", 6831.0 },
                    { 70, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2821), "This a simple description for project 70", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 70", 6930.0 },
                    { 71, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2904), "This a simple description for project 71", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 71", 7029.0 },
                    { 72, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2920), "This a simple description for project 72", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 72", 7128.0 },
                    { 73, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2934), "This a simple description for project 73", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 73", 7227.0 },
                    { 74, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2947), "This a simple description for project 74", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 74", 7326.0 },
                    { 75, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2960), "This a simple description for project 75", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 75", 7425.0 },
                    { 76, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2973), "This a simple description for project 76", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 76", 7524.0 },
                    { 77, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(2986), "This a simple description for project 77", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 77", 7623.0 },
                    { 78, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(3000), "This a simple description for project 78", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 78", 7722.0 },
                    { 79, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(3013), "This a simple description for project 79", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 79", 7821.0 },
                    { 80, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 33, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(3026), "This a simple description for project 80", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 80", 7920.0 },
                    { 81, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(3083), "This a simple description for project 81", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 81", 8019.0 },
                    { 82, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(3097), "This a simple description for project 82", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 82", 8118.0 },
                    { 83, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(3111), "This a simple description for project 83", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 83", 8217.0 },
                    { 84, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(3124), "This a simple description for project 84", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 84", 8316.0 },
                    { 85, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(3137), "This a simple description for project 85", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 85", 8415.0 },
                    { 86, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(3151), "This a simple description for project 86", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 86", 8514.0 },
                    { 87, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(3164), "This a simple description for project 87", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 87", 8613.0 },
                    { 88, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(3177), "This a simple description for project 88", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 88", 8712.0 },
                    { 89, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(3190), "This a simple description for project 89", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 89", 8811.0 },
                    { 90, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(3203), "This a simple description for project 90", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 90", 8910.0 },
                    { 91, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(3258), "This a simple description for project 91", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 91", 9009.0 },
                    { 92, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(3272), "This a simple description for project 92", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 92", 9108.0 },
                    { 93, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(3286), "This a simple description for project 93", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 93", 9207.0 },
                    { 94, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(3299), "This a simple description for project 94", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 94", 9306.0 },
                    { 95, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(3312), "This a simple description for project 95", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 95", 9405.0 },
                    { 96, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(3326), "This a simple description for project 96", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 96", 9504.0 },
                    { 97, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(3339), "This a simple description for project 97", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 97", 9603.0 },
                    { 98, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(3352), "This a simple description for project 98", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 98", 9702.0 },
                    { 99, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 33, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(3365), "This a simple description for project 99", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 99", 9801.0 },
                    { 100, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 3, 13, 55, 42, 732, DateTimeKind.Local).AddTicks(3379), "This a simple description for project 100", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 100", 9900.0 }
                });

            migrationBuilder.InsertData(
                table: "JobCategories",
                columns: new[] { "CategoryId", "JobId" },
                values: new object[,]
                {
                    { 6, 1 },
                    { 7, 2 },
                    { 6, 3 },
                    { 6, 4 },
                    { 5, 5 },
                    { 2, 6 },
                    { 1, 7 },
                    { 2, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 7, 11 },
                    { 5, 12 },
                    { 4, 13 },
                    { 3, 14 },
                    { 1, 15 },
                    { 7, 16 },
                    { 3, 17 },
                    { 2, 18 },
                    { 3, 19 },
                    { 7, 20 },
                    { 2, 21 },
                    { 6, 22 },
                    { 1, 23 },
                    { 1, 24 },
                    { 7, 25 },
                    { 4, 26 },
                    { 2, 27 },
                    { 3, 28 },
                    { 6, 29 },
                    { 1, 30 },
                    { 7, 31 },
                    { 6, 32 },
                    { 5, 33 },
                    { 7, 34 },
                    { 5, 35 },
                    { 2, 36 },
                    { 2, 37 },
                    { 7, 38 },
                    { 2, 39 },
                    { 7, 40 },
                    { 4, 41 },
                    { 5, 42 },
                    { 2, 43 },
                    { 7, 44 },
                    { 1, 45 },
                    { 3, 46 },
                    { 1, 47 },
                    { 1, 48 },
                    { 7, 49 },
                    { 6, 50 },
                    { 5, 51 },
                    { 4, 52 },
                    { 6, 53 },
                    { 6, 54 },
                    { 1, 55 },
                    { 3, 56 },
                    { 7, 57 },
                    { 6, 58 },
                    { 1, 59 },
                    { 4, 60 },
                    { 6, 61 },
                    { 3, 62 },
                    { 3, 63 },
                    { 3, 64 },
                    { 5, 65 },
                    { 7, 66 },
                    { 5, 67 },
                    { 3, 68 },
                    { 7, 69 },
                    { 7, 70 },
                    { 6, 71 },
                    { 1, 72 },
                    { 2, 73 },
                    { 5, 74 },
                    { 5, 75 },
                    { 7, 76 },
                    { 3, 77 },
                    { 2, 78 },
                    { 7, 79 },
                    { 4, 80 },
                    { 1, 81 },
                    { 1, 82 },
                    { 5, 83 },
                    { 5, 84 },
                    { 1, 85 },
                    { 2, 86 },
                    { 5, 87 },
                    { 2, 88 },
                    { 7, 89 },
                    { 4, 90 },
                    { 5, 91 },
                    { 3, 92 },
                    { 7, 93 },
                    { 2, 94 },
                    { 7, 95 },
                    { 4, 96 },
                    { 7, 97 },
                    { 3, 98 },
                    { 6, 99 },
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
