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
                    { 1, 0, "HCM", "10501a98-c180-4aa7-afc7-6da9dd58ea75", "adminhcm@gmail.com", true, "Toan", false, "Bach", false, null, "adminhcm@gmail.com", "adminhcm", "AQAAAAIAAYagAAAAEB7W4lzq4B9QnxWDJaK5FgLAvLGYuFK1IwcXjYyWQ4sE8VleOMBBQopyN6UrpUzcCA==", null, false, "", false, "adminhcm" },
                    { 2, 0, "HCM", "282c2dc1-038d-4c12-af44-ee779acbad9a", "adminhn@gmail.com", true, "Toan", false, "Bach", false, null, "adminhn@gmail.com", "adminhn", "AQAAAAIAAYagAAAAEIG0Vh7b5vmgVWXYAQDXEFmO2y08uB6bIXflUYctSY8inbAg1fm4yqB7sD4O4KeFgw==", null, false, "", false, "adminhn" },
                    { 3, 0, "HCM", "ed7695f7-70b3-4de1-9e54-8447c3da8a8b", "staff@gmail.com", true, "Toan", false, "Bach", false, null, "staff@gmail.com", "staff1", "AQAAAAIAAYagAAAAEI460A0timdxmB8BKtqCgoXhDyzGUBVJxikhvTftuzo2qOJ6wjUQ3wbVH+C0NMPxsQ==", null, false, "", false, "staff1" },
                    { 4, 0, "HCM", "ee6eaf5e-f64d-4d3b-ac32-6976d8fb756d", "staff@gmail.com", true, "Toan", false, "Bach", false, null, "staff@gmail.com", "staff2", "AQAAAAIAAYagAAAAEEjSkAXKfdtIbZ/vgAxV7DVnRHMLHSYTfG/nLGreFMZpqnYeNsE9Z/jPjAqXE6fR+w==", null, false, "", false, "staff2" },
                    { 5, 0, "HCM", "01f07a1e-5a33-4357-8336-7dd692dddfcc", "staffdis@gmail.com", true, "Toan", false, "Bach", false, null, "staffdis@gmail.com", "staffdis", "AQAAAAIAAYagAAAAEIk0qqLswqkWXwPSPiEy/5HixJzMR/2+sJkFhsp+oMvJmnumVDfua8eu+gPwUvYvGA==", null, false, "", false, "staffDis" },
                    { 6, 0, "HCM", "74286cb4-2605-43d5-b7fd-c2e8be511bd0", "normaluser6@gmail.com", true, "6", false, "Nguyen Van", false, null, "normaluser6@gmail.com", "normalUser6", "AQAAAAIAAYagAAAAEAYOnRmB9QKsjBOphGbl9hCMAbU2J+RZEs3Y5x41T4wsIPzg62JJA6LEmLXOKqr6Xw==", null, false, "", false, "normalUser6" },
                    { 7, 0, "HCM", "8503399c-3bce-469c-9420-5a956d80157e", "normaluser7@gmail.com", true, "7", false, "Nguyen Van", false, null, "normaluser7@gmail.com", "normalUser7", "AQAAAAIAAYagAAAAENe16Eb96v6mZR80VX5+Lm0sWE+pYASISa/QQXptnJLZFkyr7BXmvz4L29nkv750qQ==", null, false, "", false, "normalUser7" },
                    { 8, 0, "HCM", "f7a13974-da49-4dcd-84ab-02d36bfceb08", "normaluser8@gmail.com", true, "8", false, "Nguyen Van", false, null, "normaluser8@gmail.com", "normalUser8", "AQAAAAIAAYagAAAAENT0Z6sXsc2SPySnSvV6RAglMnnfxiQT3vP2naagqAkDqSm4iQ1aBw+dXmuiPhL6ug==", null, false, "", false, "normalUser8" },
                    { 9, 0, "HCM", "01e2ddf7-4c1b-4c20-8d5f-1962ca1016f0", "normaluser9@gmail.com", true, "9", false, "Nguyen Van", false, null, "normaluser9@gmail.com", "normalUser9", "AQAAAAIAAYagAAAAECzyEzOEV51BsNs4yO7DrQ/Hg+nPZt4roDThMZnfREWBdN7teFF/7zfg/5Flo/5FyA==", null, false, "", false, "normalUser9" },
                    { 10, 0, "HCM", "0d20e990-d56b-45b3-9fdf-fc15a8a231b6", "normaluser10@gmail.com", true, "10", false, "Nguyen Van", false, null, "normaluser10@gmail.com", "normalUser10", "AQAAAAIAAYagAAAAEMuT+3EfcaECrnfKFYHJsrcWYwg9RTlD+jJGbHuXM322Vp42gAt47IW1LWGz/FYLXQ==", null, false, "", false, "normalUser10" },
                    { 11, 0, "HCM", "828f5a85-84e3-4ba5-b48a-e138984d22ce", "normaluser11@gmail.com", true, "11", false, "Nguyen Van", false, null, "normaluser11@gmail.com", "normalUser11", "AQAAAAIAAYagAAAAEE1k83+P83ZD490fD9NmJO7hMMOmBaLqEIV0lUd0Q0MJ55jnKHsch7coHKl3wH90qg==", null, false, "", false, "normalUser11" },
                    { 12, 0, "HCM", "00a658d9-5d0a-428c-900c-844447685c29", "normaluser12@gmail.com", true, "12", false, "Nguyen Van", false, null, "normaluser12@gmail.com", "normalUser12", "AQAAAAIAAYagAAAAEJF8l8BxzYDpvC/lRaPssxCrwVgvLPWBUP54dP4wroNPIpQ7U9ejUg3pVDmIaTK6AQ==", null, false, "", false, "normalUser12" },
                    { 13, 0, "HCM", "761543c6-7e39-43bc-936a-1697d2a74a56", "normaluser13@gmail.com", true, "13", false, "Nguyen Van", false, null, "normaluser13@gmail.com", "normalUser13", "AQAAAAIAAYagAAAAEJ2Oc32msEX8I6eJMxRHcPLLBghwDsTunXalXsDz3WonYOSSilCHjnloZoP3kJOTzw==", null, false, "", false, "normalUser13" },
                    { 14, 0, "HCM", "e5b0705b-9793-4fe3-8ab0-b7815f917613", "normaluser14@gmail.com", true, "14", false, "Nguyen Van", false, null, "normaluser14@gmail.com", "normalUser14", "AQAAAAIAAYagAAAAEMAlRaQZ6IFD14TxY3xnNkFE/RWfT3PNVBXvEdd4rlCzgrlPtY7joMJaZvD2zSLtMg==", null, false, "", false, "normalUser14" },
                    { 15, 0, "HCM", "a4322159-3c98-4cb0-9827-39a4c27c0869", "normaluser15@gmail.com", true, "15", false, "Nguyen Van", false, null, "normaluser15@gmail.com", "normalUser15", "AQAAAAIAAYagAAAAEPpf2/byHy+e3nbh8ct4pF2XyODg8yE82aGoBaOgfqgmtYQHYMjlgHej/SWGglGPPQ==", null, false, "", false, "normalUser15" },
                    { 16, 0, "HCM", "375f68b7-5e62-421d-b4a0-535b49919cc6", "normaluser16@gmail.com", true, "16", false, "Nguyen Van", false, null, "normaluser16@gmail.com", "normalUser16", "AQAAAAIAAYagAAAAEPc9a/uHFTm5ZjcsPgfDCyZsXnhI5OfJ7Ae26YfZsmFc1PUyco6hsOUxXOSnXiWGtg==", null, false, "", false, "normalUser16" },
                    { 17, 0, "HCM", "36cf03a6-8ed1-4539-9c7b-48f73d0e4130", "normaluser17@gmail.com", true, "17", false, "Nguyen Van", false, null, "normaluser17@gmail.com", "normalUser17", "AQAAAAIAAYagAAAAEAGGduKdvXtnybsFXPPc98FwvGlS9pp7awlhSlmcvJ6ap7T6tBX/3QBgUEOVE9MG4Q==", null, false, "", false, "normalUser17" },
                    { 18, 0, "HCM", "81cbc52d-1b55-4b2b-b7f6-62a33a2bceaf", "normaluser18@gmail.com", true, "18", false, "Nguyen Van", false, null, "normaluser18@gmail.com", "normalUser18", "AQAAAAIAAYagAAAAENmdAWpBvHvvVdWoVrBHdXC4Ytn8FmV6fiSXOXf1z5cq81t8JBdekju2uCQVIJ1MsA==", null, false, "", false, "normalUser18" },
                    { 19, 0, "HCM", "0ee5876b-3e40-4436-a573-bfd239c686e0", "normaluser19@gmail.com", true, "19", false, "Nguyen Van", false, null, "normaluser19@gmail.com", "normalUser19", "AQAAAAIAAYagAAAAEKQG7Ybf9QzOt3QKIPUFb42JNCH+qpa6GfR/GEbz0t/X6fJIXzmEfLY2LH1eEP7pdA==", null, false, "", false, "normalUser19" },
                    { 20, 0, "HCM", "f331dbf6-4a79-4599-b6b1-e1caab796574", "normaluser20@gmail.com", true, "20", false, "Nguyen Van", false, null, "normaluser20@gmail.com", "normalUser20", "AQAAAAIAAYagAAAAEN1SP/DuJLS3iCIu3/RJDdn5D70DlQAPbbWIlIz6boIXVG0YWA4boB1Wm7RioFMDcA==", null, false, "", false, "normalUser20" },
                    { 21, 0, "HCM", "407e40e8-7fd5-4627-89a2-d44ae4ab7ce3", "normaluser21@gmail.com", true, "21", false, "Nguyen Van", false, null, "normaluser21@gmail.com", "normalUser21", "AQAAAAIAAYagAAAAEDDytxifVn9cFQ0DJo0lLVH4h9gLAQCnNWKro8wTXYe2N+1m1TgttDd4ZmAu14MJXw==", null, false, "", false, "normalUser21" },
                    { 22, 0, "HCM", "435cf177-a081-473c-81f0-d51eee6f707c", "normaluser22@gmail.com", true, "22", false, "Nguyen Van", false, null, "normaluser22@gmail.com", "normalUser22", "AQAAAAIAAYagAAAAEPyCKA3SoW41+LPQGmc2rbek57TPkx9+yFAI5Z7MbmqHhjfgTyBy/w2+5UAleOCl1g==", null, false, "", false, "normalUser22" },
                    { 23, 0, "HCM", "0a998879-ce7c-4574-bfcc-e5f2d97c01e2", "normaluser23@gmail.com", true, "23", false, "Nguyen Van", false, null, "normaluser23@gmail.com", "normalUser23", "AQAAAAIAAYagAAAAEGL9beucNvWA04CZxDOeTaSpN2G8dSipDOhpHI2rCsdlBZoZHjAc7bRE2ikNE9ZETw==", null, false, "", false, "normalUser23" },
                    { 24, 0, "HCM", "d4e58b1b-0683-4e85-8a88-07db0b476916", "normaluser24@gmail.com", true, "24", false, "Nguyen Van", false, null, "normaluser24@gmail.com", "normalUser24", "AQAAAAIAAYagAAAAEIE/q7pDjkmtdMdsDuc3lpa/PB7iBbBWcfE1VlNUoJeDQAFAjo+inNrD94LakYqmOQ==", null, false, "", false, "normalUser24" },
                    { 25, 0, "HCM", "fc982cf2-3e2b-46f6-98f7-d43a664aa52d", "normaluser25@gmail.com", true, "25", false, "Nguyen Van", false, null, "normaluser25@gmail.com", "normalUser25", "AQAAAAIAAYagAAAAEFKF4D8xAzal4EQ0GuL1Ut39en9Cx0cMX/bcnMLmllx/Ma5/rn2wvBvqc3B0RSkiIA==", null, false, "", false, "normalUser25" },
                    { 26, 0, "HCM", "02784a20-ba43-43fa-a5c3-495617a76ff7", "normaluser26@gmail.com", true, "26", false, "Nguyen Van", false, null, "normaluser26@gmail.com", "normalUser26", "AQAAAAIAAYagAAAAEM9odGZruA95GW30vlSzABT0l89VloCQOH+v/16roMfafjwoeJaHKwXqQVHPaIp9hg==", null, false, "", false, "normalUser26" },
                    { 27, 0, "HCM", "0e118606-abae-4eb0-8567-01a7e1f668d1", "normaluser27@gmail.com", true, "27", false, "Nguyen Van", false, null, "normaluser27@gmail.com", "normalUser27", "AQAAAAIAAYagAAAAEO5Tdm5KupbHpqwioPnUUGlCh9HwNHbgVak6ENriDwITF6BFzp6zuWgbHtNNI3Ibog==", null, false, "", false, "normalUser27" },
                    { 28, 0, "HCM", "b49d0878-7b0b-4946-8905-fcc2e66271c0", "normaluser28@gmail.com", true, "28", false, "Nguyen Van", false, null, "normaluser28@gmail.com", "normalUser28", "AQAAAAIAAYagAAAAEFcbjzJLj4hKxoyP3nkbkIawbqmBEP7YJocGzBTkrEtGG10ha1HLQkZ1XiyZN0n46w==", null, false, "", false, "normalUser28" },
                    { 29, 0, "HCM", "63e32ae2-318f-4511-a25a-256a5cd89e26", "normaluser29@gmail.com", true, "29", false, "Nguyen Van", false, null, "normaluser29@gmail.com", "normalUser29", "AQAAAAIAAYagAAAAEPHuJvxMdO1xQ560vFJgEjCOS2WyhGsLWSHwJj2YWRlsHNBft4vOQkGzoyWbfWVTWg==", null, false, "", false, "normalUser29" },
                    { 30, 0, "HCM", "ef31ac72-396b-47af-8bba-4399d89a4a4b", "normaluser30@gmail.com", true, "30", false, "Nguyen Van", false, null, "normaluser30@gmail.com", "normalUser30", "AQAAAAIAAYagAAAAEKOehrpTNkXKrudFr5oi9GBxRhYof9Nft9bBYdD0YXLiA7++IC9zo2ru+ckDQFxZew==", null, false, "", false, "normalUser30" },
                    { 31, 0, "HCM", "8c27800a-04db-4634-87cc-07d7a78995c7", "normaluser31@gmail.com", true, "31", false, "Nguyen Van", false, null, "normaluser31@gmail.com", "normalUser31", "AQAAAAIAAYagAAAAEN9htar2TWWIORQ38io93/qMOYqGLYywQb/5xRPE8AJtpXIqlwJa2f5+Kzbvs1FMlg==", null, false, "", false, "normalUser31" },
                    { 32, 0, "HCM", "a27d4908-5fb7-4ff9-b7c4-cf936bb8b923", "normaluser32@gmail.com", true, "32", false, "Nguyen Van", false, null, "normaluser32@gmail.com", "normalUser32", "AQAAAAIAAYagAAAAEKPdI0hRSoT4Yi2+uUpWmbCAMbN9asvOcHN5EesalkBtJbzisr1yBvb/p8W92reCrw==", null, false, "", false, "normalUser32" },
                    { 33, 0, "HCM", "8c4e8446-f579-4190-a641-88bdd76de7a6", "normaluser33@gmail.com", true, "33", false, "Nguyen Van", false, null, "normaluser33@gmail.com", "normalUser33", "AQAAAAIAAYagAAAAEFuAtJOzqdSQOIsGLoPb4nTb4WuscsjrrMFqtWEe+mN0qBn9JmgB0G2alHSWh62TBw==", null, false, "", false, "normalUser33" },
                    { 34, 0, "HCM", "00dce79b-caf3-44b7-b768-9f62be260872", "normaluser34@gmail.com", true, "34", false, "Nguyen Van", false, null, "normaluser34@gmail.com", "normalUser34", "AQAAAAIAAYagAAAAEIRPusL21Ld5epyOzB/2kyLxaVSB3qv4xXJ4S7OTg82/Ojv4yG1VyvlaOCWQEG/gxg==", null, false, "", false, "normalUser34" },
                    { 35, 0, "HCM", "4ec8db1d-29ba-444d-b61e-21ecd656b13d", "normaluser35@gmail.com", true, "35", false, "Nguyen Van", false, null, "normaluser35@gmail.com", "normalUser35", "AQAAAAIAAYagAAAAEEYnXrSQB80SO/P0+K2SFjmMEVwd6iiaHw6YBUdioJg/u47AWiE4Ce2ymc2V8jJ4sA==", null, false, "", false, "normalUser35" },
                    { 36, 0, "HCM", "9a2b9ac6-fce3-4887-8ff6-b0fcd5c98749", "normaluser36@gmail.com", true, "36", false, "Nguyen Van", false, null, "normaluser36@gmail.com", "normalUser36", "AQAAAAIAAYagAAAAEBws2+FSy+Odxq1T7lqp72gimfS2TJR1kBXPqh80nNzrFyp6LEuuCQBh1Hr9Zx3bfQ==", null, false, "", false, "normalUser36" },
                    { 37, 0, "HCM", "cddbef87-9372-4842-9a56-7b9a6c13deac", "normaluser37@gmail.com", true, "37", false, "Nguyen Van", false, null, "normaluser37@gmail.com", "normalUser37", "AQAAAAIAAYagAAAAEHZkHMD9pDevafHbvTP0XQU+vmjxJgFw2cgPVshtRPCIg+U64Stg/eeGfkXEmlQ1wQ==", null, false, "", false, "normalUser37" },
                    { 38, 0, "HCM", "7ed92aa1-28c1-41a9-adf2-cfc66da59e57", "normaluser38@gmail.com", true, "38", false, "Nguyen Van", false, null, "normaluser38@gmail.com", "normalUser38", "AQAAAAIAAYagAAAAEMkhsdfQzy0Ymd9rCNmsNm+hnLrZ/oR11r0LpX6FKZThY0WtncTIbQY9eyVZbnXAUQ==", null, false, "", false, "normalUser38" },
                    { 39, 0, "HCM", "ef04cdcd-2549-4361-b645-30fef831d89f", "normaluser39@gmail.com", true, "39", false, "Nguyen Van", false, null, "normaluser39@gmail.com", "normalUser39", "AQAAAAIAAYagAAAAELARI82KWRXWA/jfi1bxYdRp/hiq+vSIt3JPBRvkkWnzIPvjiKXBVve7B/Sk/682oQ==", null, false, "", false, "normalUser39" },
                    { 40, 0, "HCM", "6d478b15-c12a-428e-93d8-df524618b711", "normaluser40@gmail.com", true, "40", false, "Nguyen Van", false, null, "normaluser40@gmail.com", "normalUser40", "AQAAAAIAAYagAAAAECNDFM3YCiR1JjlOQZaWFF5I4H+CdImoYlXYb2COcWfEI+vfJBBqXTOMzAHsgOW47Q==", null, false, "", false, "normalUser40" },
                    { 41, 0, "HCM", "e9d233ae-f4dd-41bc-9923-0e8fff155106", "normaluser41@gmail.com", true, "41", false, "Nguyen Van", false, null, "normaluser41@gmail.com", "normalUser41", "AQAAAAIAAYagAAAAEPflgTp4qjmKNVwCdN/0R/uPoXerO2NcxuQroMFSftCjZ0p9BOd9mLdJH9uloAGqTg==", null, false, "", false, "normalUser41" },
                    { 42, 0, "HCM", "207eb306-a6a8-425d-a737-63b1614b3c6f", "normaluser42@gmail.com", true, "42", false, "Nguyen Van", false, null, "normaluser42@gmail.com", "normalUser42", "AQAAAAIAAYagAAAAEB/qwKVu9slenYw9rg3FWjSipjJ/BZRDjcuIK/NPDp/jm8qj773KVUBOSWy21j/lgw==", null, false, "", false, "normalUser42" },
                    { 43, 0, "HCM", "a72365c0-6b98-4fcf-8903-40c02536c125", "normaluser43@gmail.com", true, "43", false, "Nguyen Van", false, null, "normaluser43@gmail.com", "normalUser43", "AQAAAAIAAYagAAAAECG7hNR9LCdAvO9CIPlWpjVu7tWLGIUnnAQdH4mbGJXypTPrhvBSR7LiVyDi0fM5vg==", null, false, "", false, "normalUser43" },
                    { 44, 0, "HCM", "ff84383c-2b27-4c76-957c-d6353614be69", "normaluser44@gmail.com", true, "44", false, "Nguyen Van", false, null, "normaluser44@gmail.com", "normalUser44", "AQAAAAIAAYagAAAAEOVe/SF4AyQaWsU6MTiYYO7afcWykOtV9BHInUf3b4jys9uCXYRxtua1EfaYvC49aA==", null, false, "", false, "normalUser44" },
                    { 45, 0, "HCM", "cf811e1b-e088-43f3-9068-a3ae71464f9b", "normaluser45@gmail.com", true, "45", false, "Nguyen Van", false, null, "normaluser45@gmail.com", "normalUser45", "AQAAAAIAAYagAAAAECN4wuIj6Mb506FnA22GL/kKdnUYJ8Db/aKHuE7NfaXGTmlJCbL1NuelUp9QFcFSAw==", null, false, "", false, "normalUser45" },
                    { 46, 0, "HCM", "9f2efefa-63e8-4dc4-a4d6-0b6e28490e16", "normaluser46@gmail.com", true, "46", false, "Nguyen Van", false, null, "normaluser46@gmail.com", "normalUser46", "AQAAAAIAAYagAAAAEEhDxw+Mx4xhugQC9CeCCEiQeqiEMv8R8dVbbE3tKE21f41HJbHOsce1f4NDcPQW2w==", null, false, "", false, "normalUser46" },
                    { 47, 0, "HCM", "4f8676b2-fd3e-43e2-a0b7-f0d92f1dfe8b", "normaluser47@gmail.com", true, "47", false, "Nguyen Van", false, null, "normaluser47@gmail.com", "normalUser47", "AQAAAAIAAYagAAAAEIhTxDV/GHLdLBFGRQsK8ntBTOBJWI7vIggRqGVJ3bdgWg1xigEkYJ+DdypJPral5w==", null, false, "", false, "normalUser47" },
                    { 48, 0, "HCM", "1d39f8f5-1405-42d9-818e-1347b37b32c3", "normaluser48@gmail.com", true, "48", false, "Nguyen Van", false, null, "normaluser48@gmail.com", "normalUser48", "AQAAAAIAAYagAAAAEDYzcIBMuMnEsadOr648b1pf4IXjHCub+tMobe4p3CvYwF6Eoe4mAGa0Gr+z86e37A==", null, false, "", false, "normalUser48" },
                    { 49, 0, "HCM", "34dc4ca3-e02b-4d42-8e9c-42bfd42bc221", "normaluser49@gmail.com", true, "49", false, "Nguyen Van", false, null, "normaluser49@gmail.com", "normalUser49", "AQAAAAIAAYagAAAAEOmEV1DDEE8nGDMrrTt3B85fenR2AtSmpwB4Tn0fcAs/KXeIQy6R4aIBBNsEZV5ZAw==", null, false, "", false, "normalUser49" },
                    { 50, 0, "HCM", "1d7bcd30-5581-44a4-9479-728fa552588d", "normaluser50@gmail.com", true, "50", false, "Nguyen Van", false, null, "normaluser50@gmail.com", "normalUser50", "AQAAAAIAAYagAAAAEOla+1P6pDO2kxR4X0HAAGZaO/H6X5J4gz9AqCp9lSSRouj98NCsPFNVK3Z3wndcag==", null, false, "", false, "normalUser50" },
                    { 51, 0, "HCM", "84733d3e-6ca2-4ac9-96b8-f238623f1d7b", "normaluser51@gmail.com", true, "51", false, "Nguyen Van", false, null, "normaluser51@gmail.com", "normalUser51", "AQAAAAIAAYagAAAAEEmxrtgYpUuL07vXmvXybbwx4pb/At8sRoYE/cibHnoxlrDVwk7cjPsk81qsIkiQiw==", null, false, "", false, "normalUser51" },
                    { 52, 0, "HCM", "2201582e-d479-46ce-8bd7-5828378dbc83", "normaluser52@gmail.com", true, "52", false, "Nguyen Van", false, null, "normaluser52@gmail.com", "normalUser52", "AQAAAAIAAYagAAAAEHVDbdyX6JJ7gUOEDeGuTgU6sUOfmC3nttMOrHTovWB9QnCOtFkmHR1B+Q+CcoNh3w==", null, false, "", false, "normalUser52" },
                    { 53, 0, "HCM", "a753ec24-298e-45b4-9743-1b22798b2842", "normaluser53@gmail.com", true, "53", false, "Nguyen Van", false, null, "normaluser53@gmail.com", "normalUser53", "AQAAAAIAAYagAAAAEBB9R49KFY6MeQMDMWYB6K8SJ2W1HUFyrYEwKwo9uTQrkLiWpCkDKMCsQ1IxZ/L+gA==", null, false, "", false, "normalUser53" },
                    { 54, 0, "HCM", "c9669d96-a7ad-416f-8aa7-a437978b6589", "normaluser54@gmail.com", true, "54", false, "Nguyen Van", false, null, "normaluser54@gmail.com", "normalUser54", "AQAAAAIAAYagAAAAEPe5pcdRhPs0n7tt4SQhWWlT7TKrpa7WeOTAaqtt4KQEsjh4G3r6qFYXJ7rZQOpv6g==", null, false, "", false, "normalUser54" },
                    { 55, 0, "HCM", "9187fa34-124f-4697-aa9e-69fccd2b07e9", "normaluser55@gmail.com", true, "55", false, "Nguyen Van", false, null, "normaluser55@gmail.com", "normalUser55", "AQAAAAIAAYagAAAAEE21VLO8mctneGB2K3Z45A7aTHpd7rNpMvhTvNkuf9fFcqifWocKttxf94WUUb/LRw==", null, false, "", false, "normalUser55" },
                    { 56, 0, "HCM", "fadb2c46-2490-42b6-89c2-0e872e2b352b", "normaluser56@gmail.com", true, "56", false, "Nguyen Van", false, null, "normaluser56@gmail.com", "normalUser56", "AQAAAAIAAYagAAAAEJLjzzFEAhGRdKPbrIwQQcu7tlJzMCMpPR9UneKMtdkFtyd8D7byKxoFRAJO8DZ6pw==", null, false, "", false, "normalUser56" },
                    { 57, 0, "HCM", "72736de8-e8ee-4011-ba25-330418922d68", "normaluser57@gmail.com", true, "57", false, "Nguyen Van", false, null, "normaluser57@gmail.com", "normalUser57", "AQAAAAIAAYagAAAAEFZX0Uy1cJV615g8YIRxXhSXp5SI6izbFzwwewHtMK7qx3EpW/uIpO8kSPTCM4W6tg==", null, false, "", false, "normalUser57" },
                    { 58, 0, "HCM", "9adbeb49-8ee0-4141-8127-092a5f1ba5ed", "normaluser58@gmail.com", true, "58", false, "Nguyen Van", false, null, "normaluser58@gmail.com", "normalUser58", "AQAAAAIAAYagAAAAENMh9oKwKBbomxGifKQ9F08TTaGV4f9J5WEJxucPyuCSXbj+DHfsPhrwovVXv2QBkA==", null, false, "", false, "normalUser58" },
                    { 59, 0, "HCM", "9f37aae3-a33e-4e4c-bea7-6223ca2361c9", "normaluser59@gmail.com", true, "59", false, "Nguyen Van", false, null, "normaluser59@gmail.com", "normalUser59", "AQAAAAIAAYagAAAAEC09Kt+oU/oGI1jEQ5BrsigkBSe5gdf/KJ795wPnQrnFoXNvim7sgZIABkqlFwV9ug==", null, false, "", false, "normalUser59" },
                    { 60, 0, "HCM", "45ea0e24-9d83-4b35-808f-7be5ff05a69b", "normaluser60@gmail.com", true, "60", false, "Nguyen Van", false, null, "normaluser60@gmail.com", "normalUser60", "AQAAAAIAAYagAAAAEP/eDijyyPTvofXnGbIAaVjWHHPzyoqKlPBh/T1px4qRmvDkErDCu4SlnCj2pwKiFw==", null, false, "", false, "normalUser60" },
                    { 61, 0, "HCM", "965f301c-c9be-49c0-8c64-4edc5e098f77", "normaluser61@gmail.com", true, "61", false, "Nguyen Van", false, null, "normaluser61@gmail.com", "normalUser61", "AQAAAAIAAYagAAAAEEma4We2FcgRyyZNEJKycOfY/rovxNcZQA1v92UwOzFFrVnAFEvzesArCtqAdHXlkA==", null, false, "", false, "normalUser61" },
                    { 62, 0, "HCM", "73d5d19d-a8cb-4526-b9bf-8bc2578577ee", "normaluser62@gmail.com", true, "62", false, "Nguyen Van", false, null, "normaluser62@gmail.com", "normalUser62", "AQAAAAIAAYagAAAAEFkFqyrm79SgfDoZ8I9KZqTK7gmBXmhGsiWebcv5Wbv0xi25mj13Ems9+wd9UiB+vg==", null, false, "", false, "normalUser62" },
                    { 63, 0, "HCM", "4e4c5a1f-82bc-44d2-afe3-6340eb7312a1", "normaluser63@gmail.com", true, "63", false, "Nguyen Van", false, null, "normaluser63@gmail.com", "normalUser63", "AQAAAAIAAYagAAAAELkv0iHC+Xc6fj1I/8eUaPy34ugcq9UTCsOJ260SU/W0O9G6x+1yup/mZUIg0Au9vA==", null, false, "", false, "normalUser63" },
                    { 64, 0, "HCM", "00f48ba1-0818-4fde-ac22-861f4101cefa", "normaluser64@gmail.com", true, "64", false, "Nguyen Van", false, null, "normaluser64@gmail.com", "normalUser64", "AQAAAAIAAYagAAAAEIfq5cyiTpGy9hsPNtzt6myzFwhUqN4FmdsmoIwJIJ8PAQirj11dE/mpN/s3Q4Yfdg==", null, false, "", false, "normalUser64" },
                    { 65, 0, "HCM", "6c7ecf22-dcfd-4bb4-97df-f052726bbfd0", "normaluser65@gmail.com", true, "65", false, "Nguyen Van", false, null, "normaluser65@gmail.com", "normalUser65", "AQAAAAIAAYagAAAAECaRYpJJsHRHluXv/1XeVPy4I+TxW9jsw6juhMb+3ajV1jmlk039ZKr4xp0c/TefnA==", null, false, "", false, "normalUser65" }
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
                columns: new[] { "Id", "AppUserId", "Description", "ImageUrl", "Price", "ResumeUrl", "Title" },
                values: new object[,]
                {
                    { 36, 36, "I am 36, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/31/500/500", 3600.0, "This is my resume", "Title 36" },
                    { 37, 37, "I am 37, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/32/500/500", 3700.0, "This is my resume", "Title 37" },
                    { 38, 38, "I am 38, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/33/500/500", 3800.0, "This is my resume", "Title 38" },
                    { 39, 39, "I am 39, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/34/500/500", 3900.0, "This is my resume", "Title 39" },
                    { 40, 40, "I am 40, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/35/500/500", 4000.0, "This is my resume", "Title 40" },
                    { 41, 41, "I am 41, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/36/500/500", 4100.0, "This is my resume", "Title 41" },
                    { 42, 42, "I am 42, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/37/500/500", 4200.0, "This is my resume", "Title 42" },
                    { 43, 43, "I am 43, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/38/500/500", 4300.0, "This is my resume", "Title 43" },
                    { 44, 44, "I am 44, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/39/500/500", 4400.0, "This is my resume", "Title 44" },
                    { 45, 45, "I am 45, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/40/500/500", 4500.0, "This is my resume", "Title 45" },
                    { 46, 46, "I am 46, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/41/500/500", 4600.0, "This is my resume", "Title 46" },
                    { 47, 47, "I am 47, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/42/500/500", 4700.0, "This is my resume", "Title 47" },
                    { 48, 48, "I am 48, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/43/500/500", 4800.0, "This is my resume", "Title 48" },
                    { 49, 49, "I am 49, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/44/500/500", 4900.0, "This is my resume", "Title 49" },
                    { 50, 50, "I am 50, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/45/500/500", 5000.0, "This is my resume", "Title 50" },
                    { 51, 51, "I am 51, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/46/500/500", 5100.0, "This is my resume", "Title 51" },
                    { 52, 52, "I am 52, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/47/500/500", 5200.0, "This is my resume", "Title 52" },
                    { 53, 53, "I am 53, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/48/500/500", 5300.0, "This is my resume", "Title 53" },
                    { 54, 54, "I am 54, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/49/500/500", 5400.0, "This is my resume", "Title 54" },
                    { 55, 55, "I am 55, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/50/500/500", 5500.0, "This is my resume", "Title 55" },
                    { 56, 56, "I am 56, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/51/500/500", 5600.0, "This is my resume", "Title 56" },
                    { 57, 57, "I am 57, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/52/500/500", 5700.0, "This is my resume", "Title 57" },
                    { 58, 58, "I am 58, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/53/500/500", 5800.0, "This is my resume", "Title 58" },
                    { 59, 59, "I am 59, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/54/500/500", 5900.0, "This is my resume", "Title 59" },
                    { 60, 60, "I am 60, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/55/500/500", 6000.0, "This is my resume", "Title 60" },
                    { 61, 61, "I am 61, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/56/500/500", 6100.0, "This is my resume", "Title 61" },
                    { 62, 62, "I am 62, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/57/500/500", 6200.0, "This is my resume", "Title 62" },
                    { 63, 63, "I am 63, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/58/500/500", 6300.0, "This is my resume", "Title 63" },
                    { 64, 64, "I am 64, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/59/500/500", 6400.0, "This is my resume", "Title 64" },
                    { 65, 65, "I am 65, I am an individual with unique qualities, experiences, and aspirations. I have a distinct personality that shapes my thoughts, actions, and interactions with others. I possess a combination of strengths, weaknesses, and personal values that contribute to my identity. Throughout my life, I have acquired knowledge, skills, and talents that allow me to engage in various activities and pursuits. I have dreams, goals, and ambitions that drive me to continually learn, grow, and make a positive impact in the world. I value integrity, empathy, and authenticity in my relationships and strive to be a compassionate and understanding individual. I believe in the power of self-improvement and continuously work towards becoming the best version of myself. Overall, I am a unique individual on a personal journey, navigating through life's challenges and experiences while striving for personal fulfillment and making meaningful connections with others.", "https://picsum.photos/seed/60/500/500", 6500.0, "This is my resume", "Title 65" }
                });

            migrationBuilder.InsertData(
                table: "FreelancerCategories",
                columns: new[] { "CategoryId", "FreelancerProfileId" },
                values: new object[,]
                {
                    { 5, 36 },
                    { 7, 37 },
                    { 6, 38 },
                    { 3, 39 },
                    { 5, 40 },
                    { 2, 41 },
                    { 7, 42 },
                    { 7, 43 },
                    { 6, 44 },
                    { 6, 45 },
                    { 3, 46 },
                    { 7, 47 },
                    { 4, 48 },
                    { 5, 49 },
                    { 5, 50 },
                    { 8, 51 },
                    { 6, 52 },
                    { 2, 53 },
                    { 2, 54 },
                    { 6, 55 },
                    { 2, 56 },
                    { 2, 57 },
                    { 6, 58 },
                    { 5, 59 },
                    { 8, 60 },
                    { 1, 61 },
                    { 6, 62 },
                    { 1, 63 },
                    { 1, 64 },
                    { 2, 65 }
                });

            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "Id", "ApplyExpireDate", "BusinessProfileId", "CreatedDate", "Description", "IsActive", "Name", "Offer" },
                values: new object[,]
                {
                    { 1, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6112), "This a simple description for project 1 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 1", 99.0 },
                    { 2, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 33, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6170), "This a simple description for project 2 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 2", 198.0 },
                    { 3, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6183), "This a simple description for project 3 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 3", 297.0 },
                    { 4, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6249), "This a simple description for project 4 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 4", 396.0 },
                    { 5, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6264), "This a simple description for project 5 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 5", 495.0 },
                    { 6, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6278), "This a simple description for project 6 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 6", 594.0 },
                    { 7, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6290), "This a simple description for project 7 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 7", 693.0 },
                    { 8, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6302), "This a simple description for project 8 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 8", 792.0 },
                    { 9, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6313), "This a simple description for project 9 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 9", 891.0 },
                    { 10, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6375), "This a simple description for project 10 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 10", 990.0 },
                    { 11, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6390), "This a simple description for project 11 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 11", 1089.0 },
                    { 12, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6402), "This a simple description for project 12 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 12", 1188.0 },
                    { 13, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6413), "This a simple description for project 13 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 13", 1287.0 },
                    { 14, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6425), "This a simple description for project 14 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 14", 1386.0 },
                    { 15, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6437), "This a simple description for project 15 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 15", 1485.0 },
                    { 16, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6494), "This a simple description for project 16 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 16", 1584.0 },
                    { 17, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 30, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6508), "This a simple description for project 17 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 17", 1683.0 },
                    { 18, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6522), "This a simple description for project 18 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 18", 1782.0 },
                    { 19, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6534), "This a simple description for project 19 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 19", 1881.0 },
                    { 20, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6546), "This a simple description for project 20 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 20", 1980.0 },
                    { 21, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6597), "This a simple description for project 21 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 21", 2079.0 },
                    { 22, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6611), "This a simple description for project 22 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 22", 2178.0 },
                    { 23, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6622), "This a simple description for project 23 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 23", 2277.0 },
                    { 24, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6634), "This a simple description for project 24 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 24", 2376.0 },
                    { 25, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6646), "This a simple description for project 25 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 25", 2475.0 },
                    { 26, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6658), "This a simple description for project 26 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 26", 2574.0 },
                    { 27, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6716), "This a simple description for project 27 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 27", 2673.0 },
                    { 28, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6729), "This a simple description for project 28 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 28", 2772.0 },
                    { 29, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(6741), "This a simple description for project 29 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 29", 2871.0 },
                    { 30, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(7515), "This a simple description for project 30 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 30", 2970.0 },
                    { 31, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(7592), "This a simple description for project 31 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 31", 3069.0 },
                    { 32, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(7605), "This a simple description for project 32 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 32", 3168.0 },
                    { 33, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(7669), "This a simple description for project 33 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 33", 3267.0 },
                    { 34, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(7689), "This a simple description for project 34 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 34", 3366.0 },
                    { 35, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(7700), "This a simple description for project 35 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 35", 3465.0 },
                    { 36, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(7712), "This a simple description for project 36 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 36", 3564.0 },
                    { 37, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(7724), "This a simple description for project 37 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 37", 3663.0 },
                    { 38, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(7781), "This a simple description for project 38 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 38", 3762.0 },
                    { 39, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(7794), "This a simple description for project 39 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 39", 3861.0 },
                    { 40, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(7806), "This a simple description for project 40 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 40", 3960.0 },
                    { 41, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(7818), "This a simple description for project 41 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 41", 4059.0 },
                    { 42, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(7830), "This a simple description for project 42 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 42", 4158.0 },
                    { 43, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(7842), "This a simple description for project 43 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 43", 4257.0 },
                    { 44, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(7924), "This a simple description for project 44 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 44", 4356.0 },
                    { 45, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(7939), "This a simple description for project 45 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 45", 4455.0 },
                    { 46, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(7951), "This a simple description for project 46 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 46", 4554.0 },
                    { 47, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(7963), "This a simple description for project 47 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 47", 4653.0 },
                    { 48, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(7974), "This a simple description for project 48 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 48", 4752.0 },
                    { 49, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(7986), "This a simple description for project 49 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 49", 4851.0 },
                    { 50, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8046), "This a simple description for project 50 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 50", 4950.0 },
                    { 51, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 30, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8060), "This a simple description for project 51 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 51", 5049.0 },
                    { 52, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8072), "This a simple description for project 52 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 52", 5148.0 },
                    { 53, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8084), "This a simple description for project 53 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 53", 5247.0 },
                    { 54, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8096), "This a simple description for project 54 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 54", 5346.0 },
                    { 55, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8108), "This a simple description for project 55 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 55", 5445.0 },
                    { 56, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8177), "This a simple description for project 56 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 56", 5544.0 },
                    { 57, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8192), "This a simple description for project 57 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 57", 5643.0 },
                    { 58, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8204), "This a simple description for project 58 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 58", 5742.0 },
                    { 59, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8216), "This a simple description for project 59 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 59", 5841.0 },
                    { 60, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8228), "This a simple description for project 60 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 60", 5940.0 },
                    { 61, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8239), "This a simple description for project 61 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 61", 6039.0 },
                    { 62, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8294), "This a simple description for project 62 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 62", 6138.0 },
                    { 63, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8307), "This a simple description for project 63 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 63", 6237.0 },
                    { 64, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8319), "This a simple description for project 64 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 64", 6336.0 },
                    { 65, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8331), "This a simple description for project 65 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 65", 6435.0 },
                    { 66, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8388), "This a simple description for project 66 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 66", 6534.0 },
                    { 67, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8402), "This a simple description for project 67 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 67", 6633.0 },
                    { 68, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8414), "This a simple description for project 68 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 68", 6732.0 },
                    { 69, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8426), "This a simple description for project 69 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 69", 6831.0 },
                    { 70, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8437), "This a simple description for project 70 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 70", 6930.0 },
                    { 71, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8449), "This a simple description for project 71 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 71", 7029.0 },
                    { 72, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8505), "This a simple description for project 72 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 72", 7128.0 },
                    { 73, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8518), "This a simple description for project 73 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 73", 7227.0 },
                    { 74, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8530), "This a simple description for project 74 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 74", 7326.0 },
                    { 75, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 33, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8543), "This a simple description for project 75 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 75", 7425.0 },
                    { 76, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8555), "This a simple description for project 76 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 76", 7524.0 },
                    { 77, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8567), "This a simple description for project 77 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 77", 7623.0 },
                    { 78, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8626), "This a simple description for project 78 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 78", 7722.0 },
                    { 79, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8640), "This a simple description for project 79 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 79", 7821.0 },
                    { 80, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8652), "This a simple description for project 80 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 80", 7920.0 },
                    { 81, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8664), "This a simple description for project 81 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 81", 8019.0 },
                    { 82, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8675), "This a simple description for project 82 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 82", 8118.0 },
                    { 83, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8687), "This a simple description for project 83 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 83", 8217.0 },
                    { 84, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8745), "This a simple description for project 84 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 84", 8316.0 },
                    { 85, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 33, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8757), "This a simple description for project 85 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 85", 8415.0 },
                    { 86, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8770), "This a simple description for project 86 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 86", 8514.0 },
                    { 87, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8782), "This a simple description for project 87 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 87", 8613.0 },
                    { 88, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8794), "This a simple description for project 88 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 88", 8712.0 },
                    { 89, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8806), "This a simple description for project 89 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 89", 8811.0 },
                    { 90, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 30, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8874), "This a simple description for project 90 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 90", 8910.0 },
                    { 91, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 30, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8886), "This a simple description for project 91 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 91", 9009.0 },
                    { 92, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8898), "This a simple description for project 92 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 92", 9108.0 },
                    { 93, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8909), "This a simple description for project 93 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 93", 9207.0 },
                    { 94, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8921), "This a simple description for project 94 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 94", 9306.0 },
                    { 95, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8977), "This a simple description for project 95 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 95", 9405.0 },
                    { 96, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(8991), "This a simple description for project 96 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 96", 9504.0 },
                    { 97, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(9003), "This a simple description for project 97 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 97", 9603.0 },
                    { 98, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(9015), "This a simple description for project 98 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 98", 9702.0 },
                    { 99, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(9026), "This a simple description for project 99 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 99", 9801.0 },
                    { 100, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 12, 12, 45, 11, 879, DateTimeKind.Local).AddTicks(9039), "This a simple description for project 100 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 100", 9900.0 }
                });

            migrationBuilder.InsertData(
                table: "JobCategories",
                columns: new[] { "CategoryId", "JobId" },
                values: new object[,]
                {
                    { 6, 1 },
                    { 6, 2 },
                    { 5, 3 },
                    { 4, 4 },
                    { 6, 5 },
                    { 6, 6 },
                    { 1, 7 },
                    { 2, 8 },
                    { 1, 9 },
                    { 5, 10 },
                    { 7, 11 },
                    { 4, 12 },
                    { 1, 13 },
                    { 4, 14 },
                    { 1, 15 },
                    { 4, 16 },
                    { 1, 17 },
                    { 6, 18 },
                    { 6, 19 },
                    { 3, 20 },
                    { 2, 21 },
                    { 2, 22 },
                    { 1, 23 },
                    { 5, 24 },
                    { 5, 25 },
                    { 7, 26 },
                    { 6, 27 },
                    { 6, 28 },
                    { 2, 29 },
                    { 2, 30 },
                    { 5, 31 },
                    { 1, 32 },
                    { 7, 33 },
                    { 4, 34 },
                    { 3, 35 },
                    { 2, 36 },
                    { 6, 37 },
                    { 1, 38 },
                    { 4, 39 },
                    { 6, 40 },
                    { 1, 41 },
                    { 1, 42 },
                    { 7, 43 },
                    { 3, 44 },
                    { 6, 45 },
                    { 7, 46 },
                    { 5, 47 },
                    { 2, 48 },
                    { 7, 49 },
                    { 6, 50 },
                    { 4, 51 },
                    { 5, 52 },
                    { 5, 53 },
                    { 7, 54 },
                    { 6, 55 },
                    { 2, 56 },
                    { 6, 57 },
                    { 5, 58 },
                    { 4, 59 },
                    { 6, 60 },
                    { 7, 61 },
                    { 1, 62 },
                    { 5, 63 },
                    { 3, 64 },
                    { 1, 65 },
                    { 2, 66 },
                    { 4, 67 },
                    { 1, 68 },
                    { 3, 69 },
                    { 3, 70 },
                    { 2, 71 },
                    { 5, 72 },
                    { 2, 73 },
                    { 6, 74 },
                    { 6, 75 },
                    { 7, 76 },
                    { 7, 77 },
                    { 2, 78 },
                    { 2, 79 },
                    { 6, 80 },
                    { 5, 81 },
                    { 2, 82 },
                    { 7, 83 },
                    { 7, 84 },
                    { 3, 85 },
                    { 7, 86 },
                    { 2, 87 },
                    { 7, 88 },
                    { 6, 89 },
                    { 3, 90 },
                    { 4, 91 },
                    { 2, 92 },
                    { 3, 93 },
                    { 3, 94 },
                    { 5, 95 },
                    { 1, 96 },
                    { 3, 97 },
                    { 1, 98 },
                    { 3, 99 },
                    { 1, 100 }
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
