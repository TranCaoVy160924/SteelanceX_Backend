using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SteelanceX.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                    { 1, 0, "HCM", "9231eb4a-97a8-4add-9505-810b51ae7464", "normaluser1@gmail.com", true, "1", true, "Nguyen Van", false, null, "normaluser1@gmail.com", "normalUser1", "AQAAAAIAAYagAAAAEB/G2y/V9FCtptQeiHT+1ryvfSpn422kV8rvL2GcFoAT7wq9TXLl31bbtuN+R/jEsA==", null, false, "", false, "normalUser1" },
                    { 2, 0, "HCM", "57a42222-0be9-4a51-b212-41e2914a6128", "normaluser2@gmail.com", true, "2", true, "Nguyen Van", false, null, "normaluser2@gmail.com", "normalUser2", "AQAAAAIAAYagAAAAENpmqmcEpNZkhRPJ2iEmN5G6Ga4AeK0346yvtF9LnuzzzsNh0LJOF3m3SG0e6zMvLA==", null, false, "", false, "normalUser2" },
                    { 3, 0, "HCM", "491d2b7a-3f3f-4f48-aa38-800baad49c41", "normaluser3@gmail.com", true, "3", true, "Nguyen Van", false, null, "normaluser3@gmail.com", "normalUser3", "AQAAAAIAAYagAAAAEAiYoNKJnWmvW7bfjSmXTWuHmskjLcWmzZN++QtuvvsjqdNbkKAyU0mKudgrhoWptA==", null, false, "", false, "normalUser3" },
                    { 4, 0, "HCM", "0f0039c5-ea23-40ae-b24a-a5690ea4eb76", "normaluser4@gmail.com", true, "4", true, "Nguyen Van", false, null, "normaluser4@gmail.com", "normalUser4", "AQAAAAIAAYagAAAAEAacqnh+hIaouvNO6JhimcHddBhLv5DE3I2ACfFJgsw9VNzELh9C4U8Ljcel/rM0mQ==", null, false, "", false, "normalUser4" },
                    { 5, 0, "HCM", "fa98f4ee-4e25-4db3-b40d-15b47597ae4e", "normaluser5@gmail.com", true, "5", true, "Nguyen Van", false, null, "normaluser5@gmail.com", "normalUser5", "AQAAAAIAAYagAAAAENa8Vxw/cjYFQM9lkPNEuFXwkbe1ICl4ZWtn7cDMeDjXRxRpn7y6ZRTao/Gx40wAjA==", null, false, "", false, "normalUser5" },
                    { 6, 0, "HCM", "304b238e-9670-462e-8667-5e940f11d834", "normaluser6@gmail.com", true, "6", true, "Nguyen Van", false, null, "normaluser6@gmail.com", "normalUser6", "AQAAAAIAAYagAAAAEPjoUHfGQF5zgwJMEzEO5R9Kh6xcnDqUKb+xjX3Gs9KbK0iTseXzYw+xbdDZeDoGBg==", null, false, "", false, "normalUser6" },
                    { 7, 0, "HCM", "fe3b9247-46ed-4d5c-a50e-147812b8ff2b", "normaluser7@gmail.com", true, "7", true, "Nguyen Van", false, null, "normaluser7@gmail.com", "normalUser7", "AQAAAAIAAYagAAAAEHAFPbA50+/EqxXHN67Z1XE53jR1XHUURsUE/Sht5m2mFh8a07P/HMBzHUBpXoOvkA==", null, false, "", false, "normalUser7" },
                    { 8, 0, "HCM", "e38072b4-c7f9-4b54-af31-9875566c2a52", "normaluser8@gmail.com", true, "8", true, "Nguyen Van", false, null, "normaluser8@gmail.com", "normalUser8", "AQAAAAIAAYagAAAAEBNCAW+u1WfVdo+/EGgAffmWW8yaFoggXdxojVZVhjCXVOPAb9ZYV29kpZ8SUcq21w==", null, false, "", false, "normalUser8" },
                    { 9, 0, "HCM", "6003bbd9-f334-42b0-8a2f-d6e089dd62b1", "normaluser9@gmail.com", true, "9", true, "Nguyen Van", false, null, "normaluser9@gmail.com", "normalUser9", "AQAAAAIAAYagAAAAEDks8hrFB5xwzIzBgPwFwqj6n9GdQsqUxBoQu/uSi8eFJFlFIWJu6wo12mWlsHWS+g==", null, false, "", false, "normalUser9" },
                    { 10, 0, "HCM", "8b4d26fe-8a5e-4c88-9a94-a93712ca8098", "normaluser10@gmail.com", true, "10", true, "Nguyen Van", false, null, "normaluser10@gmail.com", "normalUser10", "AQAAAAIAAYagAAAAEOH5MQO1RlhwiLPKlhavYsa+Pd7HmlQ3XFNy3O+HGZv2n6vf4iVnZ+c2yLeRJRSy5Q==", null, false, "", false, "normalUser10" },
                    { 11, 0, "HCM", "e19967eb-6e6e-4112-95e2-541261f1eda1", "normaluser11@gmail.com", true, "11", true, "Nguyen Van", false, null, "normaluser11@gmail.com", "normalUser11", "AQAAAAIAAYagAAAAEOL5G6QxZggxohLRoA8TpBOVDDb8Ey9OoK9sLIkB1dhLsmQ2ITP+y3CKr0zPW4BUoQ==", null, false, "", false, "normalUser11" },
                    { 12, 0, "HCM", "1c894138-936a-46e8-80de-cc17b832ddd6", "normaluser12@gmail.com", true, "12", true, "Nguyen Van", false, null, "normaluser12@gmail.com", "normalUser12", "AQAAAAIAAYagAAAAEHIp8UJnbBcc0+phJLZhfJ/JBkOUa+vFAc1ihg61T3F+bDty/goO1WdwnmEHUpZiQw==", null, false, "", false, "normalUser12" },
                    { 13, 0, "HCM", "40fe614b-f195-4b51-9aaa-ab6ffdb47d57", "normaluser13@gmail.com", true, "13", true, "Nguyen Van", false, null, "normaluser13@gmail.com", "normalUser13", "AQAAAAIAAYagAAAAEAgN2KwrSwp0Z1zPNfeegNjCJ6ToJih2OPMQHVmOcwGEAgkPUBH4HBCaiCRN4yqpJw==", null, false, "", false, "normalUser13" },
                    { 14, 0, "HCM", "a4fc4e22-be44-41d5-a454-2700cf0bbdce", "normaluser14@gmail.com", true, "14", true, "Nguyen Van", false, null, "normaluser14@gmail.com", "normalUser14", "AQAAAAIAAYagAAAAELH9vdQqSfXixHJPrJhm/+iGHQLzwSyy7gfCaMHgKEBMwWTcE5UcRPHt+7npV0m8ag==", null, false, "", false, "normalUser14" },
                    { 15, 0, "HCM", "0d01149b-4434-40ca-8f62-f68659d52dcc", "normaluser15@gmail.com", true, "15", true, "Nguyen Van", false, null, "normaluser15@gmail.com", "normalUser15", "AQAAAAIAAYagAAAAEIpxhxa2/yW5CI0DhzAyDCEgioLlR+PtNca+XzUXQrXVzH71yTJj6b82Zqaq8u+c+A==", null, false, "", false, "normalUser15" },
                    { 16, 0, "HCM", "78c88f91-1bd3-46ab-9fa9-daf8ddb110ec", "normaluser16@gmail.com", true, "16", true, "Nguyen Van", false, null, "normaluser16@gmail.com", "normalUser16", "AQAAAAIAAYagAAAAEMp9XQEjtoHYoNJouwZERzS0eC6bBBh5a6QIAVQ8UCviewqVdWBLhy/hANpUko/USQ==", null, false, "", false, "normalUser16" },
                    { 17, 0, "HCM", "f4b7e404-916f-4f28-b842-c8f590753988", "normaluser17@gmail.com", true, "17", true, "Nguyen Van", false, null, "normaluser17@gmail.com", "normalUser17", "AQAAAAIAAYagAAAAEAyZ/vl1e1Xv/O5ycygN75qQQ12Ebhx1DLntg0CgRR/yKsVLB8NanPxuTgTsNcKxaw==", null, false, "", false, "normalUser17" },
                    { 18, 0, "HCM", "5706ca30-75bb-4052-9cdf-3a0a0f5aedef", "normaluser18@gmail.com", true, "18", true, "Nguyen Van", false, null, "normaluser18@gmail.com", "normalUser18", "AQAAAAIAAYagAAAAEGgvcxB3L1RNghAw+JsNmW9jnvP8lUqWtXLzMMvQtrfiqEH7RaAOtjsooToQr1oC+A==", null, false, "", false, "normalUser18" },
                    { 19, 0, "HCM", "b053d0a2-2a1c-4b2d-8061-cd37cd923539", "normaluser19@gmail.com", true, "19", true, "Nguyen Van", false, null, "normaluser19@gmail.com", "normalUser19", "AQAAAAIAAYagAAAAEJsIkqr7+8aAW/abheWrkRzY05kdPO1RFyUTxafY39JL1bmhevgrBBI1vjkl/sjv4g==", null, false, "", false, "normalUser19" },
                    { 20, 0, "HCM", "2e5e2a00-5265-4421-8e81-a625d5eb1ad0", "normaluser20@gmail.com", true, "20", true, "Nguyen Van", false, null, "normaluser20@gmail.com", "normalUser20", "AQAAAAIAAYagAAAAEBs8cAV0YImYNe1KywRZOpKKO4m2VJXNiprlfAivxRZz+BntNoM8yQuTC9rcD3PfZQ==", null, false, "", false, "normalUser20" },
                    { 21, 0, "HCM", "c7ccc326-402d-4de4-aca3-79b375990cff", "normaluser21@gmail.com", true, "21", true, "Nguyen Van", false, null, "normaluser21@gmail.com", "normalUser21", "AQAAAAIAAYagAAAAEH5ARnr/44irAEZ4LQPiGWT2Us1UeWTjD/S4Nz1hSnUcU+uvBGh1dHautnGFfT3Q3A==", null, false, "", false, "normalUser21" },
                    { 22, 0, "HCM", "f4c706bc-f545-4fe1-8b63-68a969a70b39", "normaluser22@gmail.com", true, "22", true, "Nguyen Van", false, null, "normaluser22@gmail.com", "normalUser22", "AQAAAAIAAYagAAAAEPN+/bLfqHKhcSiyIsk2JSPldz/RrcFOojuVgWigeCBHe+C0H8+UmQWc7lturNPP7w==", null, false, "", false, "normalUser22" },
                    { 23, 0, "HCM", "dc7c0ea9-1051-4528-b5b6-2c5d2ca5d414", "normaluser23@gmail.com", true, "23", true, "Nguyen Van", false, null, "normaluser23@gmail.com", "normalUser23", "AQAAAAIAAYagAAAAEC4CdFgd2LLweQcTp0WMXiOnM3eZO4P3iF5OsSKrD7baSeZwJ6oMlK4Y9pYGRRuWgA==", null, false, "", false, "normalUser23" },
                    { 24, 0, "HCM", "35d59f2d-bb65-4895-8c60-43bf69632b06", "normaluser24@gmail.com", true, "24", true, "Nguyen Van", false, null, "normaluser24@gmail.com", "normalUser24", "AQAAAAIAAYagAAAAEKeYWrJbvhUXspQwTWVYFFABSTx0aqscnpAs+j1hTyLaTrCNgQD3eB3KqTD3DKfQRg==", null, false, "", false, "normalUser24" },
                    { 25, 0, "HCM", "bd72cd4d-230b-46e2-ad8f-23ded5108ac3", "normaluser25@gmail.com", true, "25", true, "Nguyen Van", false, null, "normaluser25@gmail.com", "normalUser25", "AQAAAAIAAYagAAAAENLe4FEZdT53RS31fd589SA4edmLq7HwjjkHkM0RVCVKEI/yTcSdamVIRHGJvPLoVQ==", null, false, "", false, "normalUser25" },
                    { 26, 0, "HCM", "acf63fd2-8dff-4c18-821a-4303cbaaaa57", "normaluser26@gmail.com", true, "26", true, "Nguyen Van", false, null, "normaluser26@gmail.com", "normalUser26", "AQAAAAIAAYagAAAAEGonMzmB4P2JqDxHf5mtvd/eRTzsAapfoWncqPP/NB6pyq9UwVuU0toI5EPkzZNHYw==", null, false, "", false, "normalUser26" },
                    { 27, 0, "HCM", "e069eff6-e9b3-4fa0-aade-fbdfe6bdffe8", "normaluser27@gmail.com", true, "27", true, "Nguyen Van", false, null, "normaluser27@gmail.com", "normalUser27", "AQAAAAIAAYagAAAAEJ5YhNncNIFf/MeEN6QnCGjYxEopX4/p3hFT/6N18dNY7gB7cyYPJcXiPHOhwwgOjw==", null, false, "", false, "normalUser27" },
                    { 28, 0, "HCM", "a8ec83a1-9762-4339-a4b4-05746501b19a", "normaluser28@gmail.com", true, "28", true, "Nguyen Van", false, null, "normaluser28@gmail.com", "normalUser28", "AQAAAAIAAYagAAAAEAC/ZA6j7+Xc/tyhL6n8neGddN5sIYvX0GM+oysSmWvpVz4HjCRe58GfqkA7DaJjrQ==", null, false, "", false, "normalUser28" },
                    { 29, 0, "HCM", "ea610f6b-f144-493c-a2c3-9bd5599b6dc7", "normaluser29@gmail.com", true, "29", true, "Nguyen Van", false, null, "normaluser29@gmail.com", "normalUser29", "AQAAAAIAAYagAAAAEHjyo8IW9znf3RZo/FOM8UG+DuLcZFu6EizPRPcCpTyxexiusKRUKxNscnPaAPQSQA==", null, false, "", false, "normalUser29" },
                    { 30, 0, "HCM", "c813fd4d-1365-4246-b469-ea81e4d8d6a6", "normaluser30@gmail.com", true, "30", true, "Nguyen Van", false, null, "normaluser30@gmail.com", "normalUser30", "AQAAAAIAAYagAAAAECwCmXzih9bUzh/eAOMyIefbObdzDEF+PVeqyUmY1+yHSOBvSMEJMZn5ib6/RZhtFA==", null, false, "", false, "normalUser30" },
                    { 31, 0, "HCM", "3ecc9e8a-5717-40b8-a2a4-e9f8517e4e8c", "normaluser31@gmail.com", true, "31", true, "Nguyen Van", false, null, "normaluser31@gmail.com", "normalUser31", "AQAAAAIAAYagAAAAEP+y4/slbdOmun+8tXfqFBhVXsnYdKjEkMIFpOf6IfQMEPmShtLxSdL0t4cdGtAO1w==", null, false, "", false, "normalUser31" },
                    { 32, 0, "HCM", "dabaad67-34b6-443b-bbbe-d4a705d21a72", "normaluser32@gmail.com", true, "32", true, "Nguyen Van", false, null, "normaluser32@gmail.com", "normalUser32", "AQAAAAIAAYagAAAAEFOiOZODJ7flVFoLyzTtY9djSCxQCiDgiW+GGwbJNU5QTQWRXHkvQlkwuTs5Ic5UTA==", null, false, "", false, "normalUser32" },
                    { 33, 0, "HCM", "0ef8fafc-ef93-4c79-9528-4283bac97f1b", "normaluser33@gmail.com", true, "33", true, "Nguyen Van", false, null, "normaluser33@gmail.com", "normalUser33", "AQAAAAIAAYagAAAAEIV3GU6kjW1W/SYbYrLdZ519taKeFMrz8bOCaJc61PdNZzgD6NHMTgmasJsC2QG1SA==", null, false, "", false, "normalUser33" },
                    { 34, 0, "HCM", "14780a18-f415-48f9-9fbd-32dd9cf9ec66", "normaluser34@gmail.com", true, "34", true, "Nguyen Van", false, null, "normaluser34@gmail.com", "normalUser34", "AQAAAAIAAYagAAAAEGPvkLlnqTaA9iqMaV7dTW13f/pMptA9gBnWHzTwe8/qWA8oEdTZ4LxvcCKOlHDqdQ==", null, false, "", false, "normalUser34" },
                    { 35, 0, "HCM", "c8145265-a438-4cef-b208-60f738fb68c2", "normaluser35@gmail.com", true, "35", true, "Nguyen Van", false, null, "normaluser35@gmail.com", "normalUser35", "AQAAAAIAAYagAAAAEJb35Go2LVRM5r1Ti+Og4fnjkKzNYbUI97hWJmwzGfTcRsxylFNfw9yzQt94f94BzA==", null, false, "", false, "normalUser35" },
                    { 36, 0, "HCM", "1e9d2137-1e1c-49c7-97fb-ea2cbcdb36aa", "normaluser36@gmail.com", true, "36", true, "Nguyen Van", false, null, "normaluser36@gmail.com", "normalUser36", "AQAAAAIAAYagAAAAEJ/0EgBGS9chMlgNVBdITUX84hr7biJzAlHXX6WcdjYAyFpSvovHhzYWl4PNkcPOEg==", null, false, "", false, "normalUser36" },
                    { 37, 0, "HCM", "76fe44b5-2b93-4a7f-9e03-c1a59c5fa576", "normaluser37@gmail.com", true, "37", true, "Nguyen Van", false, null, "normaluser37@gmail.com", "normalUser37", "AQAAAAIAAYagAAAAEM0QEZBxAb8KRJYUrMMSYK+TBDTnkIdKq514YvZEDGpIeBQ4/J79eGCanQ1aEv1yAQ==", null, false, "", false, "normalUser37" },
                    { 38, 0, "HCM", "18afd05b-83f5-4461-b58e-d915f3e0f05d", "normaluser38@gmail.com", true, "38", true, "Nguyen Van", false, null, "normaluser38@gmail.com", "normalUser38", "AQAAAAIAAYagAAAAEGAwKNhh3ayb1YIXc2+b8bRI/6YsT3u8p5h8EyHOqzNS7CX1mVheTjON+qshEMZfpA==", null, false, "", false, "normalUser38" },
                    { 39, 0, "HCM", "ad78790c-50fc-4492-bf99-2d4d4766156b", "normaluser39@gmail.com", true, "39", true, "Nguyen Van", false, null, "normaluser39@gmail.com", "normalUser39", "AQAAAAIAAYagAAAAEPoFddZZKL47qCquYQfRfk2HQHHv79GYNyK6V6IanVdg43Jd3gZuRDHxk1dEWGLDXw==", null, false, "", false, "normalUser39" },
                    { 40, 0, "HCM", "9f2ef3c0-97b1-40ec-8548-711bb2d58bd2", "normaluser40@gmail.com", true, "40", true, "Nguyen Van", false, null, "normaluser40@gmail.com", "normalUser40", "AQAAAAIAAYagAAAAEIyeCrB0l9i2eq5SpD3HXt+4BK9okWwaMyJJfqvRjXc5Ige9A/YzSIlnp4aTj4logw==", null, false, "", false, "normalUser40" },
                    { 41, 0, "HCM", "922f4852-9b69-4867-9306-d059a46625df", "normaluser41@gmail.com", true, "41", true, "Nguyen Van", false, null, "normaluser41@gmail.com", "normalUser41", "AQAAAAIAAYagAAAAEKtUU36LmNDvCqashZ15dH/Rk5TiLXN/gWurDfg/xc+mQy/nEgRbZvNV105OWgBBtA==", null, false, "", false, "normalUser41" },
                    { 42, 0, "HCM", "a04bd7a7-5e62-4826-9db6-2910402bd744", "normaluser42@gmail.com", true, "42", true, "Nguyen Van", false, null, "normaluser42@gmail.com", "normalUser42", "AQAAAAIAAYagAAAAELSi2/1Sshrhp1qk0qAKREVZI+TfibWahdwXUHrg03WU2kUuhOlI/z0Tr4Ls17c2lw==", null, false, "", false, "normalUser42" },
                    { 43, 0, "HCM", "6b2f597d-55a2-4d69-ab84-49f1937bf371", "normaluser43@gmail.com", true, "43", true, "Nguyen Van", false, null, "normaluser43@gmail.com", "normalUser43", "AQAAAAIAAYagAAAAEJelnFZHyK9mE52OwGKVzsYPNeqJe8VqmUjtZLwZS97MsqgGCSsUGH95x42lZS4Feg==", null, false, "", false, "normalUser43" },
                    { 44, 0, "HCM", "ef4bddc1-69da-41a2-8bfb-fdde70eeafd0", "normaluser44@gmail.com", true, "44", true, "Nguyen Van", false, null, "normaluser44@gmail.com", "normalUser44", "AQAAAAIAAYagAAAAEK6rfkNAzALSZQ7ALcNy6DLcgkboFkhdJRj2FsVGtNE5A4Ae+NblYaaoq+Sf8Kzkcw==", null, false, "", false, "normalUser44" },
                    { 45, 0, "HCM", "e915709a-a4e6-4db5-97d8-130209172725", "normaluser45@gmail.com", true, "45", true, "Nguyen Van", false, null, "normaluser45@gmail.com", "normalUser45", "AQAAAAIAAYagAAAAEAILCFiaclqDpMasgRIkyBe4UjnPIc87xTgXEVHzhIcxBz18niYxWNBQlsu3KfASsQ==", null, false, "", false, "normalUser45" },
                    { 46, 0, "HCM", "ccf16138-1bba-4b04-9f10-8b8d2ad0de67", "normaluser46@gmail.com", true, "46", true, "Nguyen Van", false, null, "normaluser46@gmail.com", "normalUser46", "AQAAAAIAAYagAAAAEDyqiMqkhsGL8tC1jmqz7OwMeNX9zXUyDAZErWLi7dqksKz7en3RnB/++x5XcIeKsg==", null, false, "", false, "normalUser46" },
                    { 47, 0, "HCM", "ad68b37d-cd3c-4e45-ae09-71b760277e5b", "normaluser47@gmail.com", true, "47", true, "Nguyen Van", false, null, "normaluser47@gmail.com", "normalUser47", "AQAAAAIAAYagAAAAEF5/Xbqe8+X/hhFkm+zP+XeGKEs2JDeR3Vg8Kzs4eTREpp+6aFngJnslNH02jNTNcA==", null, false, "", false, "normalUser47" },
                    { 48, 0, "HCM", "bb857557-ccaa-45e0-9629-2efdb00402d7", "normaluser48@gmail.com", true, "48", true, "Nguyen Van", false, null, "normaluser48@gmail.com", "normalUser48", "AQAAAAIAAYagAAAAEK+ccOFSWVFHHeLw6QnRLO9h7T05AT6rFwWnKErOU5RwHZCDwWPDkQj405/ARfc4cg==", null, false, "", false, "normalUser48" },
                    { 49, 0, "HCM", "92c92e22-a1a1-4c45-8bdf-9e31e9fb98de", "normaluser49@gmail.com", true, "49", true, "Nguyen Van", false, null, "normaluser49@gmail.com", "normalUser49", "AQAAAAIAAYagAAAAEH/DFHY14h1167P/KY89fe5UCfY42yM+eVx0iwzxicIowT5nPg+ZIgubORaDf7dQ3Q==", null, false, "", false, "normalUser49" },
                    { 50, 0, "HCM", "54e14d9e-a35b-47ac-a6cb-8238999b644e", "normaluser50@gmail.com", true, "50", true, "Nguyen Van", false, null, "normaluser50@gmail.com", "normalUser50", "AQAAAAIAAYagAAAAEOsJVEY0ZyBufaSqAKO10VBYEwuh/7tDIyvvb1bxN0iZmJZDdtBYbrs7sla3vjI1vQ==", null, false, "", false, "normalUser50" },
                    { 51, 0, "HCM", "d2d04cf5-d7d2-4089-9123-04cb0bb6bded", "normaluser51@gmail.com", true, "51", true, "Nguyen Van", false, null, "normaluser51@gmail.com", "normalUser51", "AQAAAAIAAYagAAAAEJEljEmPqkwVXA3UkhMt3y1bSnAfOCq9OVVvUChqJM8wa5ILxyMTuPvNwwggG8SG9Q==", null, false, "", false, "normalUser51" },
                    { 52, 0, "HCM", "45fe8fc6-d55a-4f38-bab3-86917d837ca8", "normaluser52@gmail.com", true, "52", true, "Nguyen Van", false, null, "normaluser52@gmail.com", "normalUser52", "AQAAAAIAAYagAAAAEKwpeQEfcEEryVg6xPijWIlpU2xjSM4ldWckZwbNI4PVcYtT/mb4l6Y2OoiuQ3FEaQ==", null, false, "", false, "normalUser52" },
                    { 53, 0, "HCM", "cb020d8e-0990-4fe4-897a-09acbe8cb8b4", "normaluser53@gmail.com", true, "53", true, "Nguyen Van", false, null, "normaluser53@gmail.com", "normalUser53", "AQAAAAIAAYagAAAAECFsvDILQ589Poeo4yQ4QJyr8nN8iUdUzhPGbmPmKcM2MYki80lO3SbW9LFq/bcCUw==", null, false, "", false, "normalUser53" },
                    { 54, 0, "HCM", "03b4bafc-d338-439d-8b69-60f8053148f8", "normaluser54@gmail.com", true, "54", true, "Nguyen Van", false, null, "normaluser54@gmail.com", "normalUser54", "AQAAAAIAAYagAAAAEL1wmes6YxcKdJ7uhulFoMe9dKqaJ1lHJcdeB/LweNCZYlOZ0R3wUN+D3qC2XxPAeg==", null, false, "", false, "normalUser54" },
                    { 55, 0, "HCM", "a556b4ad-8980-444d-8640-cd61cab648f0", "normaluser55@gmail.com", true, "55", true, "Nguyen Van", false, null, "normaluser55@gmail.com", "normalUser55", "AQAAAAIAAYagAAAAEFMlxzNnB20B26EeAK97shOrkWpZU7ZtiDB/xbYnZYoIm+oeSqU4dh0QnecRV8JELQ==", null, false, "", false, "normalUser55" },
                    { 56, 0, "HCM", "0cf41b07-c162-4fa8-8c15-28662d4c2d6b", "normaluser56@gmail.com", true, "56", true, "Nguyen Van", false, null, "normaluser56@gmail.com", "normalUser56", "AQAAAAIAAYagAAAAELtvRLVT9UlbSm443POq/Z62GGFVzD4TOQFSVQO/heVViHp+r4o94dpANFFnx9wqMg==", null, false, "", false, "normalUser56" },
                    { 57, 0, "HCM", "d0ecc020-ab53-44da-baa1-055b635d9642", "normaluser57@gmail.com", true, "57", true, "Nguyen Van", false, null, "normaluser57@gmail.com", "normalUser57", "AQAAAAIAAYagAAAAEFK8cwkp2jpz6XBq8xhFEysQUs1LBjFB5MSbIW+kRyf2Sz1xqYIhY3yUfJU3Cm8VQQ==", null, false, "", false, "normalUser57" },
                    { 58, 0, "HCM", "82d60e85-70c2-48b4-b45f-592042f62d8b", "normaluser58@gmail.com", true, "58", true, "Nguyen Van", false, null, "normaluser58@gmail.com", "normalUser58", "AQAAAAIAAYagAAAAECC1s9rHI5VfzfrcZde/h4XUkAGvnvwNzLBq7TuLO3sE8WLbqYjJYRoVAdxQwurzlQ==", null, false, "", false, "normalUser58" },
                    { 59, 0, "HCM", "4e7d3ea4-c12f-4fcc-85b1-99f3249da677", "normaluser59@gmail.com", true, "59", true, "Nguyen Van", false, null, "normaluser59@gmail.com", "normalUser59", "AQAAAAIAAYagAAAAEBD3CPx/+ARRuCNDjDVebyTzCqlHii03yINfxhuZWAWrynUVZGxPnLZ/cnwzuiCkHg==", null, false, "", false, "normalUser59" },
                    { 60, 0, "HCM", "26f797f7-3f3c-43af-a100-ccae669f4ed0", "normaluser60@gmail.com", true, "60", true, "Nguyen Van", false, null, "normaluser60@gmail.com", "normalUser60", "AQAAAAIAAYagAAAAECfllUcy+cB01IpslATGTASLcM+/nWem8Ky158l8eKI7+5IkDNB4uPXGh22d2CfInA==", null, false, "", false, "normalUser60" }
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
                columns: new[] { "Id", "AppUserId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 31, 31, "I am 31, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/31/500/500", 3100.0, "Title 31" },
                    { 32, 32, "I am 32, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/32/500/500", 3200.0, "Title 32" },
                    { 33, 33, "I am 33, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/33/500/500", 3300.0, "Title 33" },
                    { 34, 34, "I am 34, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/34/500/500", 3400.0, "Title 34" },
                    { 35, 35, "I am 35, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/35/500/500", 3500.0, "Title 35" },
                    { 36, 36, "I am 36, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/36/500/500", 3600.0, "Title 36" },
                    { 37, 37, "I am 37, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/37/500/500", 3700.0, "Title 37" },
                    { 38, 38, "I am 38, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/38/500/500", 3800.0, "Title 38" },
                    { 39, 39, "I am 39, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/39/500/500", 3900.0, "Title 39" },
                    { 40, 40, "I am 40, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/40/500/500", 4000.0, "Title 40" },
                    { 41, 41, "I am 41, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/41/500/500", 4100.0, "Title 41" },
                    { 42, 42, "I am 42, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/42/500/500", 4200.0, "Title 42" },
                    { 43, 43, "I am 43, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/43/500/500", 4300.0, "Title 43" },
                    { 44, 44, "I am 44, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/44/500/500", 4400.0, "Title 44" },
                    { 45, 45, "I am 45, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/45/500/500", 4500.0, "Title 45" },
                    { 46, 46, "I am 46, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/46/500/500", 4600.0, "Title 46" },
                    { 47, 47, "I am 47, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/47/500/500", 4700.0, "Title 47" },
                    { 48, 48, "I am 48, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/48/500/500", 4800.0, "Title 48" },
                    { 49, 49, "I am 49, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/49/500/500", 4900.0, "Title 49" },
                    { 50, 50, "I am 50, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/50/500/500", 5000.0, "Title 50" },
                    { 51, 51, "I am 51, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/51/500/500", 5100.0, "Title 51" },
                    { 52, 52, "I am 52, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/52/500/500", 5200.0, "Title 52" },
                    { 53, 53, "I am 53, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/53/500/500", 5300.0, "Title 53" },
                    { 54, 54, "I am 54, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/54/500/500", 5400.0, "Title 54" },
                    { 55, 55, "I am 55, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/55/500/500", 5500.0, "Title 55" },
                    { 56, 56, "I am 56, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/56/500/500", 5600.0, "Title 56" },
                    { 57, 57, "I am 57, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/57/500/500", 5700.0, "Title 57" },
                    { 58, 58, "I am 58, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/58/500/500", 5800.0, "Title 58" },
                    { 59, 59, "I am 59, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/59/500/500", 5900.0, "Title 59" },
                    { 60, 60, "I am 60, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/60/500/500", 6000.0, "Title 60" }
                });

            migrationBuilder.InsertData(
                table: "FreelancerCategories",
                columns: new[] { "CategoryId", "FreelancerProfileId" },
                values: new object[,]
                {
                    { 4, 31 },
                    { 4, 32 },
                    { 2, 33 },
                    { 6, 34 },
                    { 2, 35 },
                    { 4, 36 },
                    { 5, 37 },
                    { 8, 38 },
                    { 8, 39 },
                    { 3, 40 },
                    { 4, 41 },
                    { 8, 42 },
                    { 2, 43 },
                    { 4, 44 },
                    { 2, 45 },
                    { 6, 46 },
                    { 1, 47 },
                    { 3, 48 },
                    { 8, 49 },
                    { 1, 50 },
                    { 3, 51 },
                    { 5, 52 },
                    { 1, 53 },
                    { 5, 54 },
                    { 4, 55 },
                    { 4, 56 },
                    { 6, 57 },
                    { 6, 58 },
                    { 5, 59 },
                    { 1, 60 }
                });

            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "Id", "ApplyExpireDate", "BusinessProfileId", "CreatedDate", "Description", "IsActive", "Name", "Offer" },
                values: new object[,]
                {
                    { 1, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5192), "This a simple description for project 1 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 1", 99.0 },
                    { 2, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5308), "This a simple description for project 2 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 2", 198.0 },
                    { 3, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5315), "This a simple description for project 3 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 3", 297.0 },
                    { 4, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5322), "This a simple description for project 4 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 4", 396.0 },
                    { 5, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5328), "This a simple description for project 5 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 5", 495.0 },
                    { 6, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5336), "This a simple description for project 6 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 6", 594.0 },
                    { 7, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5376), "This a simple description for project 7 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 7", 693.0 },
                    { 8, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5383), "This a simple description for project 8 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 8", 792.0 },
                    { 9, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5391), "This a simple description for project 9 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 9", 891.0 },
                    { 10, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5399), "This a simple description for project 10 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 10", 990.0 },
                    { 11, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 2, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5406), "This a simple description for project 11 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 11", 1089.0 },
                    { 12, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5412), "This a simple description for project 12 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 12", 1188.0 },
                    { 13, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5451), "This a simple description for project 13 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 13", 1287.0 },
                    { 14, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5458), "This a simple description for project 14 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 14", 1386.0 },
                    { 15, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 4, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5465), "This a simple description for project 15 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 15", 1485.0 },
                    { 16, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5471), "This a simple description for project 16 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 16", 1584.0 },
                    { 17, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5477), "This a simple description for project 17 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 17", 1683.0 },
                    { 18, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5485), "This a simple description for project 18 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 18", 1782.0 },
                    { 19, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5525), "This a simple description for project 19 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 19", 1881.0 },
                    { 20, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5532), "This a simple description for project 20 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 20", 1980.0 },
                    { 21, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5539), "This a simple description for project 21 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 21", 2079.0 },
                    { 22, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5546), "This a simple description for project 22 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 22", 2178.0 },
                    { 23, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5552), "This a simple description for project 23 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 23", 2277.0 },
                    { 24, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5558), "This a simple description for project 24 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 24", 2376.0 },
                    { 25, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5600), "This a simple description for project 25 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 25", 2475.0 },
                    { 26, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5607), "This a simple description for project 26 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 26", 2574.0 },
                    { 27, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5613), "This a simple description for project 27 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 27", 2673.0 },
                    { 28, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5620), "This a simple description for project 28 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 28", 2772.0 },
                    { 29, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5626), "This a simple description for project 29 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 29", 2871.0 },
                    { 30, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5730), "This a simple description for project 30 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 30", 2970.0 },
                    { 31, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5765), "This a simple description for project 31 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 31", 3069.0 },
                    { 32, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5771), "This a simple description for project 32 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 32", 3168.0 },
                    { 33, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5778), "This a simple description for project 33 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 33", 3267.0 },
                    { 34, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5786), "This a simple description for project 34 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 34", 3366.0 },
                    { 35, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5793), "This a simple description for project 35 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 35", 3465.0 },
                    { 36, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5834), "This a simple description for project 36 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 36", 3564.0 },
                    { 37, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 2, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5840), "This a simple description for project 37 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 37", 3663.0 },
                    { 38, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5847), "This a simple description for project 38 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 38", 3762.0 },
                    { 39, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5854), "This a simple description for project 39 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 39", 3861.0 },
                    { 40, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5860), "This a simple description for project 40 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 40", 3960.0 },
                    { 41, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5935), "This a simple description for project 41 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 41", 4059.0 },
                    { 42, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5944), "This a simple description for project 42 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 42", 4158.0 },
                    { 43, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5950), "This a simple description for project 43 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 43", 4257.0 },
                    { 44, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5957), "This a simple description for project 44 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 44", 4356.0 },
                    { 45, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5964), "This a simple description for project 45 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 45", 4455.0 },
                    { 46, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(5970), "This a simple description for project 46 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 46", 4554.0 },
                    { 47, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6034), "This a simple description for project 47 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 47", 4653.0 },
                    { 48, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6041), "This a simple description for project 48 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 48", 4752.0 },
                    { 49, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6048), "This a simple description for project 49 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 49", 4851.0 },
                    { 50, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6054), "This a simple description for project 50 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 50", 4950.0 },
                    { 51, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6061), "This a simple description for project 51 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 51", 5049.0 },
                    { 52, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6068), "This a simple description for project 52 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 52", 5148.0 },
                    { 53, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6106), "This a simple description for project 53 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 53", 5247.0 },
                    { 54, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6114), "This a simple description for project 54 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 54", 5346.0 },
                    { 55, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6120), "This a simple description for project 55 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 55", 5445.0 },
                    { 56, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6127), "This a simple description for project 56 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 56", 5544.0 },
                    { 57, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6133), "This a simple description for project 57 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 57", 5643.0 },
                    { 58, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6139), "This a simple description for project 58 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 58", 5742.0 },
                    { 59, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6175), "This a simple description for project 59 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 59", 5841.0 },
                    { 60, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6183), "This a simple description for project 60 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 60", 5940.0 },
                    { 61, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6189), "This a simple description for project 61 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 61", 6039.0 },
                    { 62, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 4, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6196), "This a simple description for project 62 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 62", 6138.0 },
                    { 63, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6202), "This a simple description for project 63 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 63", 6237.0 },
                    { 64, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6209), "This a simple description for project 64 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 64", 6336.0 },
                    { 65, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6246), "This a simple description for project 65 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 65", 6435.0 },
                    { 66, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6254), "This a simple description for project 66 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 66", 6534.0 },
                    { 67, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6261), "This a simple description for project 67 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 67", 6633.0 },
                    { 68, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 5, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6267), "This a simple description for project 68 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 68", 6732.0 },
                    { 69, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6305), "This a simple description for project 69 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 69", 6831.0 },
                    { 70, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6313), "This a simple description for project 70 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 70", 6930.0 },
                    { 71, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6320), "This a simple description for project 71 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 71", 7029.0 },
                    { 72, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6326), "This a simple description for project 72 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 72", 7128.0 },
                    { 73, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6333), "This a simple description for project 73 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 73", 7227.0 },
                    { 74, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6339), "This a simple description for project 74 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 74", 7326.0 },
                    { 75, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 30, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6376), "This a simple description for project 75 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 75", 7425.0 },
                    { 76, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6385), "This a simple description for project 76 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 76", 7524.0 },
                    { 77, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6391), "This a simple description for project 77 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 77", 7623.0 },
                    { 78, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6398), "This a simple description for project 78 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 78", 7722.0 },
                    { 79, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6404), "This a simple description for project 79 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 79", 7821.0 },
                    { 80, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6411), "This a simple description for project 80 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 80", 7920.0 },
                    { 81, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6449), "This a simple description for project 81 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 81", 8019.0 },
                    { 82, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6456), "This a simple description for project 82 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 82", 8118.0 },
                    { 83, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 1, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6463), "This a simple description for project 83 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 83", 8217.0 },
                    { 84, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6469), "This a simple description for project 84 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 84", 8316.0 },
                    { 85, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6476), "This a simple description for project 85 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 85", 8415.0 },
                    { 86, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6482), "This a simple description for project 86 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 86", 8514.0 },
                    { 87, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6535), "This a simple description for project 87 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 87", 8613.0 },
                    { 88, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6543), "This a simple description for project 88 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 88", 8712.0 },
                    { 89, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6549), "This a simple description for project 89 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 89", 8811.0 },
                    { 90, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6555), "This a simple description for project 90 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 90", 8910.0 },
                    { 91, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 1, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6562), "This a simple description for project 91 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 91", 9009.0 },
                    { 92, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6568), "This a simple description for project 92 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 92", 9108.0 },
                    { 93, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6606), "This a simple description for project 93 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 93", 9207.0 },
                    { 94, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 4, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6612), "This a simple description for project 94 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 94", 9306.0 },
                    { 95, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6619), "This a simple description for project 95 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 95", 9405.0 },
                    { 96, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6625), "This a simple description for project 96 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 96", 9504.0 },
                    { 97, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6631), "This a simple description for project 97 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 97", 9603.0 },
                    { 98, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 4, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6638), "This a simple description for project 98 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 98", 9702.0 },
                    { 99, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6677), "This a simple description for project 99 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 99", 9801.0 },
                    { 100, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 2, new DateTime(2023, 6, 14, 21, 38, 2, 722, DateTimeKind.Local).AddTicks(6684), "This a simple description for project 100 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 100", 9900.0 }
                });

            migrationBuilder.InsertData(
                table: "JobCategories",
                columns: new[] { "CategoryId", "JobId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 7, 2 },
                    { 5, 3 },
                    { 3, 4 },
                    { 7, 5 },
                    { 8, 6 },
                    { 7, 7 },
                    { 5, 8 },
                    { 1, 9 },
                    { 8, 10 },
                    { 6, 11 },
                    { 5, 12 },
                    { 2, 13 },
                    { 2, 14 },
                    { 5, 15 },
                    { 8, 16 },
                    { 1, 17 },
                    { 2, 18 },
                    { 5, 19 },
                    { 4, 20 },
                    { 5, 21 },
                    { 3, 22 },
                    { 7, 23 },
                    { 6, 24 },
                    { 2, 25 },
                    { 3, 26 },
                    { 4, 27 },
                    { 2, 28 },
                    { 6, 29 },
                    { 1, 30 },
                    { 1, 31 },
                    { 5, 32 },
                    { 8, 33 },
                    { 8, 34 },
                    { 4, 35 },
                    { 7, 36 },
                    { 2, 37 },
                    { 1, 38 },
                    { 8, 39 },
                    { 4, 40 },
                    { 8, 41 },
                    { 4, 42 },
                    { 1, 43 },
                    { 5, 44 },
                    { 6, 45 },
                    { 6, 46 },
                    { 1, 47 },
                    { 1, 48 },
                    { 2, 49 },
                    { 7, 50 },
                    { 7, 51 },
                    { 1, 52 },
                    { 6, 53 },
                    { 8, 54 },
                    { 8, 55 },
                    { 2, 56 },
                    { 3, 57 },
                    { 7, 58 },
                    { 1, 59 },
                    { 3, 60 },
                    { 5, 61 },
                    { 5, 62 },
                    { 1, 63 },
                    { 8, 64 },
                    { 1, 65 },
                    { 2, 66 },
                    { 8, 67 },
                    { 2, 68 },
                    { 4, 69 },
                    { 1, 70 },
                    { 1, 71 },
                    { 4, 72 },
                    { 5, 73 },
                    { 2, 74 },
                    { 1, 75 },
                    { 7, 76 },
                    { 6, 77 },
                    { 5, 78 },
                    { 4, 79 },
                    { 4, 80 },
                    { 4, 81 },
                    { 1, 82 },
                    { 4, 83 },
                    { 6, 84 },
                    { 4, 85 },
                    { 6, 86 },
                    { 8, 87 },
                    { 2, 88 },
                    { 1, 89 },
                    { 2, 90 },
                    { 8, 91 },
                    { 2, 92 },
                    { 7, 93 },
                    { 5, 94 },
                    { 6, 95 },
                    { 3, 96 },
                    { 8, 97 },
                    { 2, 98 },
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
