using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SteelanceX.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
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
                    { 1, 0, "HCM", "d331e4e2-38e3-4b65-b8e4-8ceffdd59052", "adminhcm@gmail.com", true, "Toan", "Bach", false, null, "adminhcm@gmail.com", "adminhcm", "AQAAAAIAAYagAAAAELJ3j2pPV4Iw5wff7RfJ7QQJ0En4D4iH+BWfhsLcMnTy+gpm1sRhFoDGfcSS8RAoGQ==", null, false, "", false, "adminhcm" },
                    { 2, 0, "HCM", "9c60a5bd-2a05-4a69-9ef3-496ba9958804", "adminhn@gmail.com", true, "Toan", "Bach", false, null, "adminhn@gmail.com", "adminhn", "AQAAAAIAAYagAAAAEOrCI7n7QwmpC+YM/sok0SSMHqdGi5C6OkIFEflwPzgJNwAJaFR50NEdTupk7OiIYw==", null, false, "", false, "adminhn" },
                    { 3, 0, "HCM", "25537a25-519a-4347-8e33-c705bd2ac4cf", "staff@gmail.com", true, "Toan", "Bach", false, null, "staff@gmail.com", "staff1", "AQAAAAIAAYagAAAAENgtV/CRlpMtLvdEQAUyDlMLMe+RqWuwRNxAy2UoPTrxfvImLn7HclvpLvP2kLRn1A==", null, false, "", false, "staff1" },
                    { 4, 0, "HCM", "34f01c53-9777-48bf-8497-582431977244", "staff@gmail.com", true, "Toan", "Bach", false, null, "staff@gmail.com", "staff2", "AQAAAAIAAYagAAAAEM40+eyO7/Q+ypmEwLlqetNEzIyEDsnKjwvDwEM1PAj5qa97eiwLLWS3E8H4QyBwtw==", null, false, "", false, "staff2" },
                    { 5, 0, "HCM", "f0e50338-3e71-430d-bd91-835f10502174", "staffdis@gmail.com", true, "Toan", "Bach", false, null, "staffdis@gmail.com", "staffdis", "AQAAAAIAAYagAAAAEGLcMCQheymy8S3UgIE0hcnRCOVOz/yLkwRVaTo5MUJdvIJ2CDdBq5Q5MWtGE7c8pA==", null, false, "", false, "staffDis" },
                    { 6, 0, "HCM", "809d5efd-f435-4a32-bf1b-3e0b21c2d6f7", "normaluser15@gmail.com", true, "6", "Nguyen Van", false, null, "normaluser15@gmail.com", "normalUser15", "AQAAAAIAAYagAAAAEMbFboxd43PE3TBracH23A3O3mditjD3o4K5MQBWreuX0eAHXdOPj5bqmujw87xu/A==", null, false, "", false, "normalUser15" },
                    { 7, 0, "HCM", "5b85237f-906a-43a5-a99b-bb8206cb30e6", "normaluser25@gmail.com", true, "7", "Nguyen Van", false, null, "normaluser25@gmail.com", "normalUser25", "AQAAAAIAAYagAAAAEMMgBW+LmOdy4VGmTPRB10pNjnqWX6HKYA9P/zvH+T8wHncDfhFVEEL7kQ741Py1rw==", null, false, "", false, "normalUser25" },
                    { 8, 0, "HCM", "abee90c1-7c82-44fa-89a1-41c6e3bf51a1", "normaluser35@gmail.com", true, "8", "Nguyen Van", false, null, "normaluser35@gmail.com", "normalUser35", "AQAAAAIAAYagAAAAECVi/M8vaKyhyLjHl0qudOjExg0KIqhGPMsPnXf8d7PWPrXBiWCxwQ2rh8G16Jk4LQ==", null, false, "", false, "normalUser35" },
                    { 9, 0, "HCM", "2aa824e0-043b-4a38-9019-168af8c2bfe1", "normaluser45@gmail.com", true, "9", "Nguyen Van", false, null, "normaluser45@gmail.com", "normalUser45", "AQAAAAIAAYagAAAAEHqpZR/OEtRNMI5V9zlfIts4Lqrsm/nXmj/jibquiSrOLPSt/8JbZNEJ/EveGaxdjw==", null, false, "", false, "normalUser45" },
                    { 10, 0, "HCM", "b6fe312e-4ce2-4052-abca-b5118b96d4ab", "normaluser55@gmail.com", true, "10", "Nguyen Van", false, null, "normaluser55@gmail.com", "normalUser55", "AQAAAAIAAYagAAAAEEyv+V04Sh+PqfNmXTc2LPlU5DNqp49RvXWOKrtucAQximDo2+KzLP0qEdkZN+lPNQ==", null, false, "", false, "normalUser55" },
                    { 11, 0, "HCM", "02f4a549-b6b8-4d3a-b566-96bbf3ebf3f8", "normaluser65@gmail.com", true, "11", "Nguyen Van", false, null, "normaluser65@gmail.com", "normalUser65", "AQAAAAIAAYagAAAAENdFl2buvC8ZwRjxwD6tsK597NCIUF8YdQXzjuCwFObF4iWtuveW0rXHi5J9Op5Cow==", null, false, "", false, "normalUser65" },
                    { 12, 0, "HCM", "9b73fcfb-6c9a-4936-a405-1f8ef27ec7dd", "normaluser75@gmail.com", true, "12", "Nguyen Van", false, null, "normaluser75@gmail.com", "normalUser75", "AQAAAAIAAYagAAAAEG/ZcSNzvo0O3A8N/yB1leg0/yi5jXVz0B5QHF71KjUxvdyx89edMFsTFo18Unvhgw==", null, false, "", false, "normalUser75" },
                    { 13, 0, "HCM", "0d66cd27-4afc-4fe3-94f1-7aa7223f036b", "normaluser85@gmail.com", true, "13", "Nguyen Van", false, null, "normaluser85@gmail.com", "normalUser85", "AQAAAAIAAYagAAAAEK7Hyh/iAfGBPjltfl8hZylQn3ON7PrWQk3E/VuTZCvhimotRau15nscNJKezPkFyw==", null, false, "", false, "normalUser85" },
                    { 14, 0, "HCM", "c74f7d65-322e-4c1f-947a-2584bff4f82d", "normaluser95@gmail.com", true, "14", "Nguyen Van", false, null, "normaluser95@gmail.com", "normalUser95", "AQAAAAIAAYagAAAAEPL919K4j4HkK0QMMZgGFBQW/esxogv2oxR7y571VzfIPUNI8x9xv7b7hZMfXIdZBg==", null, false, "", false, "normalUser95" },
                    { 15, 0, "HCM", "47224636-ccf5-4a2f-a277-1cbd68ae5f46", "normaluser105@gmail.com", true, "15", "Nguyen Van", false, null, "normaluser105@gmail.com", "normalUser105", "AQAAAAIAAYagAAAAEDwLup91JAwNJ8jtdVz9cfR9tW0aeKne2I502bG/cSRmLehz+1k+t+VbgZOBFXFVZA==", null, false, "", false, "normalUser105" },
                    { 16, 0, "HCM", "6dd56a9b-e4a7-4320-ae45-e8f9dfc458e9", "normaluser115@gmail.com", true, "16", "Nguyen Van", false, null, "normaluser115@gmail.com", "normalUser115", "AQAAAAIAAYagAAAAEPJ6+LOiRpgloXVWlxbzcNbuWkbDzHvHU0rPelAfNrz1wF/MTmr2S3djDxs7AD04YQ==", null, false, "", false, "normalUser115" },
                    { 17, 0, "HCM", "d87adb8d-4c49-4dea-b175-1d262e44ad30", "normaluser125@gmail.com", true, "17", "Nguyen Van", false, null, "normaluser125@gmail.com", "normalUser125", "AQAAAAIAAYagAAAAEJh/N/xfb9ly03zjWX/ViK0c9vLQLtWQzZQnin3SHf820s0vVaUlqM3I7EAQmi+Yiw==", null, false, "", false, "normalUser125" },
                    { 18, 0, "HCM", "61a6db78-9cb6-4359-9d44-557a81be886f", "normaluser135@gmail.com", true, "18", "Nguyen Van", false, null, "normaluser135@gmail.com", "normalUser135", "AQAAAAIAAYagAAAAEDOnM7E6c8lHOCWahAfmRtbi3E1ZV4XlNcmMqolG9xQcGl015U1C9JLrODi3qk3SHw==", null, false, "", false, "normalUser135" },
                    { 19, 0, "HCM", "149e0a49-57a6-489b-8f47-980be8482af9", "normaluser145@gmail.com", true, "19", "Nguyen Van", false, null, "normaluser145@gmail.com", "normalUser145", "AQAAAAIAAYagAAAAEFXuf01v8idJ0boOCvdcFU5K3T7mW1FeZBx3JC2ZCGSeHLBDqHTQCOQrW7H28Oie8Q==", null, false, "", false, "normalUser145" },
                    { 20, 0, "HCM", "042a5f11-1d73-4f53-bf95-89951c6ff69c", "normaluser155@gmail.com", true, "20", "Nguyen Van", false, null, "normaluser155@gmail.com", "normalUser155", "AQAAAAIAAYagAAAAECkTrw5qYxLdz/m5aymvGyuIRuigUyredjp4Ktof4y2mcNsbLsL+6nMuUUcg4qzfLQ==", null, false, "", false, "normalUser155" },
                    { 21, 0, "HCM", "45dd0b07-5146-4a37-85ab-75e513a92745", "normaluser165@gmail.com", true, "21", "Nguyen Van", false, null, "normaluser165@gmail.com", "normalUser165", "AQAAAAIAAYagAAAAEBCDtsZC9D1NR0axFAy6i+m0eAvcZCiIbrbTk3HZ7zFghRofOdnpXSsVaB/y52dEaw==", null, false, "", false, "normalUser165" },
                    { 22, 0, "HCM", "d037709d-c616-4aac-ac57-f7a6502b5e46", "normaluser175@gmail.com", true, "22", "Nguyen Van", false, null, "normaluser175@gmail.com", "normalUser175", "AQAAAAIAAYagAAAAEPCuHCXoTrDhlPjyI+cOKctsfT95Oifn2e4B6J3pmiV9U8XYbON+B/0Xugv2yjK3/w==", null, false, "", false, "normalUser175" },
                    { 23, 0, "HCM", "29e44da1-f833-46f8-b4a1-11cc6f348af4", "normaluser185@gmail.com", true, "23", "Nguyen Van", false, null, "normaluser185@gmail.com", "normalUser185", "AQAAAAIAAYagAAAAEOVZtPPf3l49amcOur13dsmhAZ0tJYpkTiHCMWZAp7wz13qKXA6ccDnVTo7ESzgIag==", null, false, "", false, "normalUser185" },
                    { 24, 0, "HCM", "334b9bcc-43e3-49e7-a106-bbc37f5020e0", "normaluser195@gmail.com", true, "24", "Nguyen Van", false, null, "normaluser195@gmail.com", "normalUser195", "AQAAAAIAAYagAAAAEFQb9JKLz8mbeimGzMX4nsXC5kDuXAC4FbY7WaxzmE9g3yBR3tYHxyXS6o1Z9Q1k6g==", null, false, "", false, "normalUser195" },
                    { 25, 0, "HCM", "da668a7d-7664-4c1a-b688-ed1e3b54c96e", "normaluser205@gmail.com", true, "25", "Nguyen Van", false, null, "normaluser205@gmail.com", "normalUser205", "AQAAAAIAAYagAAAAEHqk7BsNBHcAG/HoujBFrpGt7Q8T4snm+Ep/DWxWM2JK4p3sOV7dGEMDDNz8ZF5JIQ==", null, false, "", false, "normalUser205" },
                    { 26, 0, "HCM", "295c4ed2-a77c-4867-b446-9749d4348753", "normaluser215@gmail.com", true, "26", "Nguyen Van", false, null, "normaluser215@gmail.com", "normalUser215", "AQAAAAIAAYagAAAAECDzfS0d5uiRb44mCMtAluKKL+PeOR0z/U4hhRsmTJ0u84/6phe5E0CjOaGhBQpe+w==", null, false, "", false, "normalUser215" },
                    { 27, 0, "HCM", "47175140-0e8d-443c-b057-f92cbb28e2bb", "normaluser225@gmail.com", true, "27", "Nguyen Van", false, null, "normaluser225@gmail.com", "normalUser225", "AQAAAAIAAYagAAAAEM1rd/WSJ/TkdgEU8MiFdBQKqKKEVJegdJmOVqmGxe3bNi3ZIonTfeLT2nrDId+VAg==", null, false, "", false, "normalUser225" },
                    { 28, 0, "HCM", "22ba4a5b-bb2a-4db9-90fd-7ccc9ee809bf", "normaluser235@gmail.com", true, "28", "Nguyen Van", false, null, "normaluser235@gmail.com", "normalUser235", "AQAAAAIAAYagAAAAEOOEuy1mmxPymMoqaiK8aKKu1XvKB/ZRH7GgdhRifhzoTg2wYOvB5mXdl902Ttyd5w==", null, false, "", false, "normalUser235" },
                    { 29, 0, "HCM", "748c47e5-10ac-4ada-9853-e28958cc7bcb", "normaluser245@gmail.com", true, "29", "Nguyen Van", false, null, "normaluser245@gmail.com", "normalUser245", "AQAAAAIAAYagAAAAEOa93krpWyRwhmHWtILdx9en5A9iobHsFwQDSfob+/hjFBhrbMuVMOEEhYX+k+EdGg==", null, false, "", false, "normalUser245" },
                    { 30, 0, "HCM", "56e7240f-1f28-4d76-bcce-e20c437394ae", "normaluser255@gmail.com", true, "30", "Nguyen Van", false, null, "normaluser255@gmail.com", "normalUser255", "AQAAAAIAAYagAAAAEI6b9i2cbao/Qi6Kng7hCi7CNA2cen/38k87Q5FOh36aaKDDxJCkvK08MCCeUi3tvw==", null, false, "", false, "normalUser255" },
                    { 31, 0, "HCM", "dc32ec4b-86e3-48fa-a030-15f635a61bb0", "normaluser265@gmail.com", true, "31", "Nguyen Van", false, null, "normaluser265@gmail.com", "normalUser265", "AQAAAAIAAYagAAAAENA+FDzfr/xks4+WzC1b+lzNb7CFxg0ezaS8Ahi+kTqH7yyF0fBSgpNf5mORalQ1UQ==", null, false, "", false, "normalUser265" },
                    { 32, 0, "HCM", "e6fbff7f-8c6f-451a-832a-d611c22d63b9", "normaluser275@gmail.com", true, "32", "Nguyen Van", false, null, "normaluser275@gmail.com", "normalUser275", "AQAAAAIAAYagAAAAEAj23M3jKdXS9tRw6BbY1r4YptyzPGp4VED24uLdkLW5ZbVZ/8HDwFX/h85Hq3T40g==", null, false, "", false, "normalUser275" },
                    { 33, 0, "HCM", "eb1aa138-a9a5-4ec8-ae0f-9149016ac873", "normaluser285@gmail.com", true, "33", "Nguyen Van", false, null, "normaluser285@gmail.com", "normalUser285", "AQAAAAIAAYagAAAAEFCtNLnOc+YLlo0C1oCWnvXR4AF0af234FEtT/T95fV+Zw/UTBd3OPUYR6JyGKYYuA==", null, false, "", false, "normalUser285" },
                    { 34, 0, "HCM", "3a458f9c-e265-4e2c-9888-8ad81145302b", "normaluser295@gmail.com", true, "34", "Nguyen Van", false, null, "normaluser295@gmail.com", "normalUser295", "AQAAAAIAAYagAAAAEI/7ko8+NI7OPwRngBUQHBy+16sD9afDPZvKLlMqwWB60/fjB6JOYF3bJkOJo0E0GA==", null, false, "", false, "normalUser295" },
                    { 35, 0, "HCM", "ced72a01-0314-4b93-8120-a31511b5c99e", "normaluser305@gmail.com", true, "35", "Nguyen Van", false, null, "normaluser305@gmail.com", "normalUser305", "AQAAAAIAAYagAAAAEGdZ/4/8LmSxujogWU6aKvkJsCb38j3ZRA+2mKzMBs2BTSq/9jBUhBBLyaZ82afgFw==", null, false, "", false, "normalUser305" },
                    { 36, 0, "HCM", "b3dea117-9e27-4e9f-8a67-a721678f1922", "normaluser315@gmail.com", true, "36", "Nguyen Van", false, null, "normaluser315@gmail.com", "normalUser315", "AQAAAAIAAYagAAAAEKnXCtaOqmzIvqZJYUa/evsYMJqJOtKbVlmWm8vsctjAhhWc8BUPehcEileVZDvWQA==", null, false, "", false, "normalUser315" },
                    { 37, 0, "HCM", "e61c2992-bc9c-4304-b41c-5028c59150f8", "normaluser325@gmail.com", true, "37", "Nguyen Van", false, null, "normaluser325@gmail.com", "normalUser325", "AQAAAAIAAYagAAAAEAjvjdl8ChIkv6FNB6YCn6sXLKZ/G6gBmvR+CO1Qc36g6AN16gq0CVu49OwRTovyfQ==", null, false, "", false, "normalUser325" },
                    { 38, 0, "HCM", "ce9f2211-ce15-4892-a082-25478128332c", "normaluser335@gmail.com", true, "38", "Nguyen Van", false, null, "normaluser335@gmail.com", "normalUser335", "AQAAAAIAAYagAAAAEC/1VXuqkIMXT322Xs+uCh6xIUIDnnPw+Tyy9J9wtDTmiSz0r1G9GBA4XfIbO8CcRg==", null, false, "", false, "normalUser335" },
                    { 39, 0, "HCM", "58f89679-f331-467d-99a6-eb81e486cde9", "normaluser345@gmail.com", true, "39", "Nguyen Van", false, null, "normaluser345@gmail.com", "normalUser345", "AQAAAAIAAYagAAAAEAZ90+zrYKN9CJ0Hn25zqT9py3mOPcjba+9Y2EOBCr1/k1pSE7t8ZZZ50HgShtsZJg==", null, false, "", false, "normalUser345" },
                    { 40, 0, "HCM", "f875c30c-7caf-44ec-ba6a-045efaeebf05", "normaluser355@gmail.com", true, "40", "Nguyen Van", false, null, "normaluser355@gmail.com", "normalUser355", "AQAAAAIAAYagAAAAEFiP3eU5oJ81rrdpIF0sUKp/UtE16JbaRcUeGJiYf36xKXdoit06qRK7VFsKFaWAdQ==", null, false, "", false, "normalUser355" },
                    { 41, 0, "HCM", "193eadd2-0789-47a3-b94a-7daf55aa5f91", "normaluser365@gmail.com", true, "41", "Nguyen Van", false, null, "normaluser365@gmail.com", "normalUser365", "AQAAAAIAAYagAAAAEBf+szahA5LjzD6HaJqy4uqJliPbPljbKKiI22GDiCwQK/ycRFtcq2sxDgAelVrang==", null, false, "", false, "normalUser365" },
                    { 42, 0, "HCM", "4dc409c1-50e2-4662-b3c5-b41f7dbdd11c", "normaluser375@gmail.com", true, "42", "Nguyen Van", false, null, "normaluser375@gmail.com", "normalUser375", "AQAAAAIAAYagAAAAEORunjByLSb5DEVS2uN87IFpoU5fk8CFdtgAmCDqPernIJU0GA7QiSBtQHYRsvYtQg==", null, false, "", false, "normalUser375" },
                    { 43, 0, "HCM", "32978811-9b6d-48d0-93c6-a05d85846826", "normaluser385@gmail.com", true, "43", "Nguyen Van", false, null, "normaluser385@gmail.com", "normalUser385", "AQAAAAIAAYagAAAAEDU9ymKHd6pA+Mn2jYKrzKjuNz70uZmehXTks+vBmENKwwr+p7fxCr008XfklVYBGg==", null, false, "", false, "normalUser385" },
                    { 44, 0, "HCM", "1c4ed646-64e8-461f-a94f-676576279a44", "normaluser395@gmail.com", true, "44", "Nguyen Van", false, null, "normaluser395@gmail.com", "normalUser395", "AQAAAAIAAYagAAAAEBOK+Xmoz2KTmaVvsP91Q4hkPIuO4xMk2FYEXWA4plpce8O2Ge0yWjjvw+gcrgC/Sg==", null, false, "", false, "normalUser395" },
                    { 45, 0, "HCM", "73606f89-5f35-420e-8941-505c65499984", "normaluser405@gmail.com", true, "45", "Nguyen Van", false, null, "normaluser405@gmail.com", "normalUser405", "AQAAAAIAAYagAAAAEBRUi5CrQAxUG7ntj7zC6kg4kWPQxXmK5EoJ4BNm8oZ0m/hEbEwivPOQLAa2SFPWaA==", null, false, "", false, "normalUser405" },
                    { 46, 0, "HCM", "d4f58e92-2509-4cba-a5c8-b5b6223f9cfc", "normaluser415@gmail.com", true, "46", "Nguyen Van", false, null, "normaluser415@gmail.com", "normalUser415", "AQAAAAIAAYagAAAAELF5A70CTRvS6V6TEUGoj1ZezUNjrUf19l0e6JAYYp/GigjjxchnKuEWjNsVLkKb4g==", null, false, "", false, "normalUser415" },
                    { 47, 0, "HCM", "b1ba26ac-4ed3-48db-8839-b8a06c0a3a74", "normaluser425@gmail.com", true, "47", "Nguyen Van", false, null, "normaluser425@gmail.com", "normalUser425", "AQAAAAIAAYagAAAAEIS1UmkBZ2lZSEu0yDkyb7YAkD9Y9nTHa8FYzL+b9eH/2s+SgnT+2D8vAeX+D+ftkA==", null, false, "", false, "normalUser425" },
                    { 48, 0, "HCM", "cd0bc622-bb61-4d5c-9cf5-6435af528697", "normaluser435@gmail.com", true, "48", "Nguyen Van", false, null, "normaluser435@gmail.com", "normalUser435", "AQAAAAIAAYagAAAAEP73TTTF5SSE3aIOVLTZ8FkeCu/QVb9LCftBjzA7TF6fS7O2mQCoZ37lhL4CQEZfhQ==", null, false, "", false, "normalUser435" },
                    { 49, 0, "HCM", "e5e39b75-4922-4ad5-a30f-7a342b1b84f8", "normaluser445@gmail.com", true, "49", "Nguyen Van", false, null, "normaluser445@gmail.com", "normalUser445", "AQAAAAIAAYagAAAAEPY5+riYO3Dx4BpU0JzTUMFKvkCyTJLgAzvm6Zdevm90SdGdo0jEeRj+Mnz/SMQgWA==", null, false, "", false, "normalUser445" },
                    { 50, 0, "HCM", "9d7b2824-2284-47f2-a8f3-c7fba46ed193", "normaluser455@gmail.com", true, "50", "Nguyen Van", false, null, "normaluser455@gmail.com", "normalUser455", "AQAAAAIAAYagAAAAEPeFpYMa3HIIHN23BBEhNoccbMRKwK7kBkdwyN7heFntcNPll3MWPqI3jelyyJlseQ==", null, false, "", false, "normalUser455" },
                    { 51, 0, "HCM", "ae5866ba-6b64-4d49-9516-543d6aaafd7b", "normaluser465@gmail.com", true, "51", "Nguyen Van", false, null, "normaluser465@gmail.com", "normalUser465", "AQAAAAIAAYagAAAAEORjtTLdYRObTreFnQ/wjyW9ZbgIPnZxhdiwJH2/N9pa+rtVsgJu4AorulQFmVJhnQ==", null, false, "", false, "normalUser465" },
                    { 52, 0, "HCM", "6fc550fc-7f5b-44e6-9345-50b7085eed72", "normaluser475@gmail.com", true, "52", "Nguyen Van", false, null, "normaluser475@gmail.com", "normalUser475", "AQAAAAIAAYagAAAAEBZumOrV+ZQf4cuTBYk8jGzCDk9l4eSjTS4TE4DM30degT5geulizCPhpQNvsCsMvw==", null, false, "", false, "normalUser475" },
                    { 53, 0, "HCM", "cabfd69d-4eb4-4737-ae8c-1254cb92982f", "normaluser485@gmail.com", true, "53", "Nguyen Van", false, null, "normaluser485@gmail.com", "normalUser485", "AQAAAAIAAYagAAAAEClOoBDujiiydSmg9GsAbwyqBaRzlr/GqNo7nhjT5at3SnxXs02jCZ/iGKmPhb0aNQ==", null, false, "", false, "normalUser485" },
                    { 54, 0, "HCM", "39dd30dd-874b-4de3-a8e0-1439c4e67b38", "normaluser495@gmail.com", true, "54", "Nguyen Van", false, null, "normaluser495@gmail.com", "normalUser495", "AQAAAAIAAYagAAAAEJNIh7a4UQO/JEqA8J+EKDXpgYKqHqNTmNMkcbrSA6WYZ/2yBpOhJ1EXJqAjo3vqTA==", null, false, "", false, "normalUser495" },
                    { 55, 0, "HCM", "708ad3cd-ebb1-4dcd-9a0c-a01201733475", "normaluser505@gmail.com", true, "55", "Nguyen Van", false, null, "normaluser505@gmail.com", "normalUser505", "AQAAAAIAAYagAAAAEG3VLa6k2l3Mc0G3BRnqQ1KUWA5Tib1qxqZQ53BAvthNJdZznFdsxrCeo9otBo8cbw==", null, false, "", false, "normalUser505" },
                    { 56, 0, "HCM", "6618a239-2803-499f-9c4f-67697cbfbcc3", "normaluser515@gmail.com", true, "56", "Nguyen Van", false, null, "normaluser515@gmail.com", "normalUser515", "AQAAAAIAAYagAAAAEIbymOJoFb8azD3C3m8X/1vi1wErcpNVeLVHeds8PsGc+zeE8HQdejgQk2EJZvcWcA==", null, false, "", false, "normalUser515" },
                    { 57, 0, "HCM", "3ff2d7c8-040b-4828-9310-5a39eaaa1cfe", "normaluser525@gmail.com", true, "57", "Nguyen Van", false, null, "normaluser525@gmail.com", "normalUser525", "AQAAAAIAAYagAAAAEJ/WfeyH8GIfFPV2rrTdH1JDdx7G+z45Zzl61UHjfPQgs1UM1qMeDIKuHMWrD/ADgg==", null, false, "", false, "normalUser525" },
                    { 58, 0, "HCM", "6a058267-67cb-426b-a16f-d3016b9b130a", "normaluser535@gmail.com", true, "58", "Nguyen Van", false, null, "normaluser535@gmail.com", "normalUser535", "AQAAAAIAAYagAAAAEGGuptR7vaIViueae3EJR9GZgmC1WAHmVUalfxmrHwmvGFI0Ciu20wxneddxdmOLnA==", null, false, "", false, "normalUser535" },
                    { 59, 0, "HCM", "fa5d8d2f-f885-4051-9577-6470d7f60d28", "normaluser545@gmail.com", true, "59", "Nguyen Van", false, null, "normaluser545@gmail.com", "normalUser545", "AQAAAAIAAYagAAAAENT3HeoRh1tNvlagOP29ZN0A9/wBCbMzFRzNIpFynbhK/jigAYOoxWPGZluoG1oi+w==", null, false, "", false, "normalUser545" },
                    { 60, 0, "HCM", "4dc1463f-1116-4608-ade9-d26e6e83732e", "normaluser555@gmail.com", true, "60", "Nguyen Van", false, null, "normaluser555@gmail.com", "normalUser555", "AQAAAAIAAYagAAAAEGcct6cZjmVv/A73YCYVtbgHxilXGC8b2pmBzeyJitMn/geJrZtxVeGiOVwaXD3v0A==", null, false, "", false, "normalUser555" },
                    { 61, 0, "HCM", "23d3885c-fc1e-4260-a7c6-68c7d70d6d9e", "normaluser565@gmail.com", true, "61", "Nguyen Van", false, null, "normaluser565@gmail.com", "normalUser565", "AQAAAAIAAYagAAAAEMAB4S3070DkThdRz5559op8Tr3tO2cutQoDPeZLtAmVeHiQXJcuokUAd8aJSyF/Nw==", null, false, "", false, "normalUser565" },
                    { 62, 0, "HCM", "1283a742-9331-4a1a-ad31-7e35dd7fafc0", "normaluser575@gmail.com", true, "62", "Nguyen Van", false, null, "normaluser575@gmail.com", "normalUser575", "AQAAAAIAAYagAAAAEE9d5cUYPzLbG9QvImCWxvxhrJrYPfrEVUWGJXwfa9i/U00aT6RU2Kf6o0Qb36cT4g==", null, false, "", false, "normalUser575" },
                    { 63, 0, "HCM", "b2f5db5b-00d2-405c-8573-cf6f69be61d8", "normaluser585@gmail.com", true, "63", "Nguyen Van", false, null, "normaluser585@gmail.com", "normalUser585", "AQAAAAIAAYagAAAAELvOSPdDLljzbO1bCXcjhlo24tVQBGhFImAj5BVU+rrBiiXjBytbrO0+iHDpn/aIhQ==", null, false, "", false, "normalUser585" },
                    { 64, 0, "HCM", "9e24847f-d671-44da-8a66-b4ba9b21fe28", "normaluser595@gmail.com", true, "64", "Nguyen Van", false, null, "normaluser595@gmail.com", "normalUser595", "AQAAAAIAAYagAAAAEA6+aKO9mmrFLJDlFHiZ/AjYR8Sje/DONfk1bKD518yrGSkXABLC3n39cwjrn6hqIQ==", null, false, "", false, "normalUser595" },
                    { 65, 0, "HCM", "970c3d49-6760-4661-81e9-261d1c0bf82b", "normaluser605@gmail.com", true, "65", "Nguyen Van", false, null, "normaluser605@gmail.com", "normalUser605", "AQAAAAIAAYagAAAAEO7zUW/CvfX6D/tO6o5AHqBYeSOdddEYwkK1B2YtjerC7IXYsmgKYykVOF4U+5W8gg==", null, false, "", false, "normalUser605" }
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
                table: "Job",
                columns: new[] { "Id", "ApplyExpireDate", "BusinessProfileId", "CreatedDate", "Description", "ImageUrl", "IsActive", "JobDescriptionFileUrl", "JobExpiredDate", "Name", "Offer" },
                values: new object[,]
                {
                    { 1, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(7304), "This a simple description for project 1", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 1", 99.0 },
                    { 2, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(7379), "This a simple description for project 2", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 2", 198.0 },
                    { 3, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(7392), "This a simple description for project 3", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 3", 297.0 },
                    { 4, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(7484), "This a simple description for project 4", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 4", 396.0 },
                    { 5, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(7498), "This a simple description for project 5", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 5", 495.0 },
                    { 6, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(7513), "This a simple description for project 6", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 6", 594.0 },
                    { 7, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(7525), "This a simple description for project 7", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 7", 693.0 },
                    { 8, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(7537), "This a simple description for project 8", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 8", 792.0 },
                    { 9, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(7549), "This a simple description for project 9", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 9", 891.0 },
                    { 10, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(7564), "This a simple description for project 10", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 10", 990.0 },
                    { 11, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(7576), "This a simple description for project 11", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 11", 1089.0 },
                    { 12, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(7588), "This a simple description for project 12", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 12", 1188.0 },
                    { 13, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(7645), "This a simple description for project 13", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 13", 1287.0 },
                    { 14, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(7660), "This a simple description for project 14", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 14", 1386.0 },
                    { 15, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(7671), "This a simple description for project 15", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 15", 1485.0 },
                    { 16, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 32, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(8432), "This a simple description for project 16", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 16", 1584.0 },
                    { 17, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(8449), "This a simple description for project 17", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 17", 1683.0 },
                    { 18, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(8465), "This a simple description for project 18", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 18", 1782.0 },
                    { 19, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(8477), "This a simple description for project 19", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 19", 1881.0 },
                    { 20, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 33, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(8489), "This a simple description for project 20", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 20", 1980.0 },
                    { 21, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(8501), "This a simple description for project 21", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 21", 2079.0 },
                    { 22, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(8564), "This a simple description for project 22", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 22", 2178.0 },
                    { 23, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(8580), "This a simple description for project 23", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 23", 2277.0 },
                    { 24, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(8591), "This a simple description for project 24", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 24", 2376.0 },
                    { 25, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(8603), "This a simple description for project 25", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 25", 2475.0 },
                    { 26, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(8615), "This a simple description for project 26", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 26", 2574.0 },
                    { 27, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 32, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(8627), "This a simple description for project 27", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 27", 2673.0 },
                    { 28, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(8639), "This a simple description for project 28", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 28", 2772.0 },
                    { 29, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(8651), "This a simple description for project 29", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 29", 2871.0 },
                    { 30, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(8685), "This a simple description for project 30", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 30", 2970.0 },
                    { 31, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(8718), "This a simple description for project 31", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 31", 3069.0 },
                    { 32, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(8875), "This a simple description for project 32", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 32", 3168.0 },
                    { 33, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(8893), "This a simple description for project 33", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 33", 3267.0 },
                    { 34, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(8909), "This a simple description for project 34", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 34", 3366.0 },
                    { 35, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(8920), "This a simple description for project 35", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 35", 3465.0 },
                    { 36, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 32, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(8932), "This a simple description for project 36", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 36", 3564.0 },
                    { 37, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(8944), "This a simple description for project 37", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 37", 3663.0 },
                    { 38, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 32, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(8956), "This a simple description for project 38", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 38", 3762.0 },
                    { 39, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(8968), "This a simple description for project 39", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 39", 3861.0 },
                    { 40, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(8980), "This a simple description for project 40", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 40", 3960.0 },
                    { 41, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9040), "This a simple description for project 41", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 41", 4059.0 },
                    { 42, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9053), "This a simple description for project 42", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 42", 4158.0 },
                    { 43, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 33, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9065), "This a simple description for project 43", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 43", 4257.0 },
                    { 44, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9077), "This a simple description for project 44", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 44", 4356.0 },
                    { 45, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9089), "This a simple description for project 45", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 45", 4455.0 },
                    { 46, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9101), "This a simple description for project 46", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 46", 4554.0 },
                    { 47, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9113), "This a simple description for project 47", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 47", 4653.0 },
                    { 48, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9125), "This a simple description for project 48", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 48", 4752.0 },
                    { 49, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9137), "This a simple description for project 49", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 49", 4851.0 },
                    { 50, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9149), "This a simple description for project 50", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 50", 4950.0 },
                    { 51, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9204), "This a simple description for project 51", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 51", 5049.0 },
                    { 52, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9216), "This a simple description for project 52", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 52", 5148.0 },
                    { 53, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9228), "This a simple description for project 53", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 53", 5247.0 },
                    { 54, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9240), "This a simple description for project 54", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 54", 5346.0 },
                    { 55, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9252), "This a simple description for project 55", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 55", 5445.0 },
                    { 56, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9264), "This a simple description for project 56", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 56", 5544.0 },
                    { 57, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9275), "This a simple description for project 57", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 57", 5643.0 },
                    { 58, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9288), "This a simple description for project 58", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 58", 5742.0 },
                    { 59, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9300), "This a simple description for project 59", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 59", 5841.0 },
                    { 60, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9393), "This a simple description for project 60", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 60", 5940.0 },
                    { 61, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9409), "This a simple description for project 61", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 61", 6039.0 },
                    { 62, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9422), "This a simple description for project 62", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 62", 6138.0 },
                    { 63, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9435), "This a simple description for project 63", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 63", 6237.0 },
                    { 64, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9446), "This a simple description for project 64", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 64", 6336.0 },
                    { 65, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9459), "This a simple description for project 65", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 65", 6435.0 },
                    { 66, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9474), "This a simple description for project 66", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 66", 6534.0 },
                    { 67, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9486), "This a simple description for project 67", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 67", 6633.0 },
                    { 68, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9540), "This a simple description for project 68", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 68", 6732.0 },
                    { 69, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9552), "This a simple description for project 69", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 69", 6831.0 },
                    { 70, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9564), "This a simple description for project 70", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 70", 6930.0 },
                    { 71, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9576), "This a simple description for project 71", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 71", 7029.0 },
                    { 72, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9588), "This a simple description for project 72", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 72", 7128.0 },
                    { 73, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9600), "This a simple description for project 73", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 73", 7227.0 },
                    { 74, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9612), "This a simple description for project 74", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 74", 7326.0 },
                    { 75, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9624), "This a simple description for project 75", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 75", 7425.0 },
                    { 76, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9636), "This a simple description for project 76", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 76", 7524.0 },
                    { 77, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9648), "This a simple description for project 77", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 77", 7623.0 },
                    { 78, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9701), "This a simple description for project 78", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 78", 7722.0 },
                    { 79, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9714), "This a simple description for project 79", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 79", 7821.0 },
                    { 80, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9725), "This a simple description for project 80", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 80", 7920.0 },
                    { 81, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9738), "This a simple description for project 81", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 81", 8019.0 },
                    { 82, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9750), "This a simple description for project 82", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 82", 8118.0 },
                    { 83, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9761), "This a simple description for project 83", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 83", 8217.0 },
                    { 84, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 30, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9773), "This a simple description for project 84", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 84", 8316.0 },
                    { 85, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 33, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9785), "This a simple description for project 85", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 85", 8415.0 },
                    { 86, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9797), "This a simple description for project 86", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 86", 8514.0 },
                    { 87, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9848), "This a simple description for project 87", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 87", 8613.0 },
                    { 88, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9862), "This a simple description for project 88", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 88", 8712.0 },
                    { 89, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9874), "This a simple description for project 89", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 89", 8811.0 },
                    { 90, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9886), "This a simple description for project 90", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 90", 8910.0 },
                    { 91, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9898), "This a simple description for project 91", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 91", 9009.0 },
                    { 92, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9910), "This a simple description for project 92", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 92", 9108.0 },
                    { 93, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9922), "This a simple description for project 93", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 93", 9207.0 },
                    { 94, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9934), "This a simple description for project 94", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 94", 9306.0 },
                    { 95, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9946), "This a simple description for project 95", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 95", 9405.0 },
                    { 96, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 5, 31, 17, 27, 20, 833, DateTimeKind.Local).AddTicks(9958), "This a simple description for project 96", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 96", 9504.0 },
                    { 97, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 5, 31, 17, 27, 20, 834, DateTimeKind.Local).AddTicks(12), "This a simple description for project 97", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 97", 9603.0 },
                    { 98, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 5, 31, 17, 27, 20, 834, DateTimeKind.Local).AddTicks(25), "This a simple description for project 98", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 98", 9702.0 },
                    { 99, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 5, 31, 17, 27, 20, 834, DateTimeKind.Local).AddTicks(37), "This a simple description for project 99", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 99", 9801.0 },
                    { 100, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 5, 31, 17, 27, 20, 834, DateTimeKind.Local).AddTicks(50), "This a simple description for project 100", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 100", 9900.0 }
                });

            migrationBuilder.InsertData(
                table: "JobCategories",
                columns: new[] { "CategoryId", "JobId" },
                values: new object[,]
                {
                    { 6, 1 },
                    { 6, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 4, 6 },
                    { 4, 7 },
                    { 4, 8 },
                    { 6, 9 },
                    { 3, 10 },
                    { 7, 11 },
                    { 2, 12 },
                    { 1, 13 },
                    { 4, 14 },
                    { 5, 15 },
                    { 3, 16 },
                    { 1, 17 },
                    { 1, 18 },
                    { 2, 19 },
                    { 5, 20 },
                    { 3, 21 },
                    { 2, 22 },
                    { 1, 23 },
                    { 2, 24 },
                    { 2, 25 },
                    { 4, 26 },
                    { 5, 27 },
                    { 3, 28 },
                    { 1, 29 },
                    { 6, 30 },
                    { 4, 31 },
                    { 5, 32 },
                    { 7, 33 },
                    { 4, 34 },
                    { 6, 35 },
                    { 5, 36 },
                    { 4, 37 },
                    { 7, 38 },
                    { 3, 39 },
                    { 1, 40 },
                    { 1, 41 },
                    { 3, 42 },
                    { 4, 43 },
                    { 6, 44 },
                    { 6, 45 },
                    { 7, 46 },
                    { 5, 47 },
                    { 5, 48 },
                    { 3, 49 },
                    { 6, 50 },
                    { 6, 51 },
                    { 7, 52 },
                    { 6, 53 },
                    { 3, 54 },
                    { 4, 55 },
                    { 5, 56 },
                    { 3, 57 },
                    { 4, 58 },
                    { 2, 59 },
                    { 4, 60 },
                    { 6, 61 },
                    { 5, 62 },
                    { 3, 63 },
                    { 7, 64 },
                    { 3, 65 },
                    { 5, 66 },
                    { 2, 67 },
                    { 5, 68 },
                    { 7, 69 },
                    { 4, 70 },
                    { 5, 71 },
                    { 1, 72 },
                    { 5, 73 },
                    { 7, 74 },
                    { 6, 75 },
                    { 1, 76 },
                    { 2, 77 },
                    { 6, 78 },
                    { 7, 79 },
                    { 7, 80 },
                    { 7, 81 },
                    { 1, 82 },
                    { 4, 83 },
                    { 6, 84 },
                    { 6, 85 },
                    { 5, 86 },
                    { 2, 87 },
                    { 7, 88 },
                    { 7, 89 },
                    { 5, 90 },
                    { 6, 91 },
                    { 4, 92 },
                    { 4, 93 },
                    { 6, 94 },
                    { 4, 95 },
                    { 2, 96 },
                    { 4, 97 },
                    { 2, 98 },
                    { 1, 99 },
                    { 5, 100 }
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
