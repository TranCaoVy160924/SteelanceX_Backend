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
                    isPremium = table.Column<bool>(type: "bit", nullable: false),
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
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "isPremium" },
                values: new object[,]
                {
                    { 1, 0, "HCM", "8a0cacb9-4193-4de6-b278-02911b4fda71", "adminhcm@gmail.com", true, "Toan", "Bach", false, null, "adminhcm@gmail.com", "adminhcm", "AQAAAAIAAYagAAAAEGkP+mWDWW+yuff5D2MVjrgokTZqjYxBvPGxLrtVxrgKMuLByoX+5fpvAWa4neLNZQ==", null, false, "", false, "adminhcm", false },
                    { 2, 0, "HCM", "c8a823dc-8ce4-4866-8807-5c797ef857c9", "adminhn@gmail.com", true, "Toan", "Bach", false, null, "adminhn@gmail.com", "adminhn", "AQAAAAIAAYagAAAAEPXdTUpTvTGYCBsDwYsvmmSnUVwxheMUukgXzrImxHaUxn1fYm9IGdC41mImcCPFKQ==", null, false, "", false, "adminhn", false },
                    { 3, 0, "HCM", "5117c771-5157-4bd8-9f2b-c9f7c2e688c8", "staff@gmail.com", true, "Toan", "Bach", false, null, "staff@gmail.com", "staff1", "AQAAAAIAAYagAAAAELYPS02rPrEmefqxiy+5iXmmArxY9BcGtwpbqXLCvG/pktBrOmTee92bN458BTR1xA==", null, false, "", false, "staff1", false },
                    { 4, 0, "HCM", "df4cea6d-cba3-426f-bc29-bcfdcb0f7079", "staff@gmail.com", true, "Toan", "Bach", false, null, "staff@gmail.com", "staff2", "AQAAAAIAAYagAAAAEJcvuFwQlgOoFB/7NXaBX2tZhLGDlTUJLrfQuG33qql4o9y2JGEKb/CZLwbHmJvmGA==", null, false, "", false, "staff2", false },
                    { 5, 0, "HCM", "e36d44cc-671c-4f2a-af65-7cd34ca5b5db", "staffdis@gmail.com", true, "Toan", "Bach", false, null, "staffdis@gmail.com", "staffdis", "AQAAAAIAAYagAAAAEA5O5NGj2eBNlGV/4GWpOQmnguKhItWwhrP7djMVNn0Cay7a1Xs/ztASmedKYB0/Ag==", null, false, "", false, "staffDis", false },
                    { 6, 0, "HCM", "44129afe-c248-49d2-8c72-fddaaa68e25c", "normaluser6@gmail.com", true, "6", "Nguyen Van", false, null, "normaluser6@gmail.com", "normalUser6", "AQAAAAIAAYagAAAAEIXt1/ILcMfR+V1rt4OKdtNiG9am5qwUkp4LSbsiujWnCVz0pqzJEb6ia04zaN968g==", null, false, "", false, "normalUser6", false },
                    { 7, 0, "HCM", "5e0867cf-c96b-4b3c-be5e-d5ac5a969370", "normaluser7@gmail.com", true, "7", "Nguyen Van", false, null, "normaluser7@gmail.com", "normalUser7", "AQAAAAIAAYagAAAAELS1teQVWsvf74U0JBZvUFcTupYI8e9rxC18fbvPS+q7w+Ui/skRszm4sAP2eyZfQA==", null, false, "", false, "normalUser7", false },
                    { 8, 0, "HCM", "00b9bd63-a51f-4501-b346-9fe2ada00711", "normaluser8@gmail.com", true, "8", "Nguyen Van", false, null, "normaluser8@gmail.com", "normalUser8", "AQAAAAIAAYagAAAAELlsUIgduESGDbgUBcX9JRUKRcImcUt95iu4bvJTBBI16TOH+OzZOurEj3udvRGmOA==", null, false, "", false, "normalUser8", false },
                    { 9, 0, "HCM", "728e3e12-bb88-4b78-991a-a9db71e2b1f4", "normaluser9@gmail.com", true, "9", "Nguyen Van", false, null, "normaluser9@gmail.com", "normalUser9", "AQAAAAIAAYagAAAAEJYpVBeBfzXB2n8lEiu2CGa7LIhvXbe4Rrwh1eauJ0JYOIXGM/nClo/vGHmxDkQfQg==", null, false, "", false, "normalUser9", false },
                    { 10, 0, "HCM", "df1e15a7-3999-43bf-85eb-5d72ff5e9f90", "normaluser10@gmail.com", true, "10", "Nguyen Van", false, null, "normaluser10@gmail.com", "normalUser10", "AQAAAAIAAYagAAAAECEbnONAa1pwQTEwMfBjBreJPVw+IFWicSwzKe/5CLptvRFxkWKeA7IwH3lk/pNRGA==", null, false, "", false, "normalUser10", false },
                    { 11, 0, "HCM", "ab5ada99-0127-4a5d-86c5-0cc2ec816560", "normaluser11@gmail.com", true, "11", "Nguyen Van", false, null, "normaluser11@gmail.com", "normalUser11", "AQAAAAIAAYagAAAAED+fvpV3DUig3fSaAtn+hhSyeXAgU4jfg7UxZ8zZ4k0qr5l1J68E9iWkA8WBslNMNg==", null, false, "", false, "normalUser11", false },
                    { 12, 0, "HCM", "52efba73-bd3c-4bdb-8598-b371a58c5167", "normaluser12@gmail.com", true, "12", "Nguyen Van", false, null, "normaluser12@gmail.com", "normalUser12", "AQAAAAIAAYagAAAAEBZMgDHfXnWYUpcuZwRPybYyCqI2d6MwufTDtgn7czQVFwO2dgQaOmoVBeL5+Zto1Q==", null, false, "", false, "normalUser12", false },
                    { 13, 0, "HCM", "c8584e97-e5fa-4435-b7ea-52bd1176b6fc", "normaluser13@gmail.com", true, "13", "Nguyen Van", false, null, "normaluser13@gmail.com", "normalUser13", "AQAAAAIAAYagAAAAEL+Qe0LgKelDbipunLjhtFXxlzWD9gYta1tYLHlReYkzs04pSt2Vh4i7CkAgcBwepA==", null, false, "", false, "normalUser13", false },
                    { 14, 0, "HCM", "65141cdd-2eea-4832-ada4-41966b7793db", "normaluser14@gmail.com", true, "14", "Nguyen Van", false, null, "normaluser14@gmail.com", "normalUser14", "AQAAAAIAAYagAAAAEOgJg3B5h0oio/cgPiCLl3oz3/Mvirq/g9z1N6VBvEiyf8/WmLtVmDxiPuPcKvR6Rg==", null, false, "", false, "normalUser14", false },
                    { 15, 0, "HCM", "885f16bb-b049-4195-8607-249eeaebf8eb", "normaluser15@gmail.com", true, "15", "Nguyen Van", false, null, "normaluser15@gmail.com", "normalUser15", "AQAAAAIAAYagAAAAEBbki44qskpk0yRcaPUEcZiPCFTCnW4qgQM8RStYvpdJ4sE5ouAt5dmkbIJKeP5Vfg==", null, false, "", false, "normalUser15", false },
                    { 16, 0, "HCM", "20b0bb28-78be-4478-bcde-9d4ea7e638ec", "normaluser16@gmail.com", true, "16", "Nguyen Van", false, null, "normaluser16@gmail.com", "normalUser16", "AQAAAAIAAYagAAAAEHzd26Tyuswby7KjhpNLXVHhkjX1pzbJLlFKyGEBVftpuhX4gUP6EENTlX0IA5tfOw==", null, false, "", false, "normalUser16", false },
                    { 17, 0, "HCM", "c3836ed4-fcb0-4806-9fea-54c235e5433d", "normaluser17@gmail.com", true, "17", "Nguyen Van", false, null, "normaluser17@gmail.com", "normalUser17", "AQAAAAIAAYagAAAAENQftzh3YtI/ua/hGw+NPiOAsXXwPJrtagXzNcPJN29jIIxi2fdj8S0D8Rem+qUKMA==", null, false, "", false, "normalUser17", false },
                    { 18, 0, "HCM", "183e2e44-8658-4876-9952-4b8886c5f2ee", "normaluser18@gmail.com", true, "18", "Nguyen Van", false, null, "normaluser18@gmail.com", "normalUser18", "AQAAAAIAAYagAAAAEAtFcwna+DT2XFwTOGavIr9tM+JGYkj28CACf2ScKQpEFFwPS75tBDyjugJqwqLjmg==", null, false, "", false, "normalUser18", false },
                    { 19, 0, "HCM", "7ed3bed2-c1bf-45f6-97bc-70e89b5eb9cf", "normaluser19@gmail.com", true, "19", "Nguyen Van", false, null, "normaluser19@gmail.com", "normalUser19", "AQAAAAIAAYagAAAAEBuyMyuy6Q6bRYPfEXhoVGV+jg/uFyOpMHtI2lGXEBOwb2D0Oqj4+4Wv3Uu/8el89g==", null, false, "", false, "normalUser19", false },
                    { 20, 0, "HCM", "77b07fd7-b861-4031-a4fd-0e91a3726d0e", "normaluser20@gmail.com", true, "20", "Nguyen Van", false, null, "normaluser20@gmail.com", "normalUser20", "AQAAAAIAAYagAAAAED5cuF/6HDlE86/Mr9gnol/84yn4udU8FKACm2cV2UWdce8P6qhcX5s2oJX/E3zc2A==", null, false, "", false, "normalUser20", false },
                    { 21, 0, "HCM", "b2406dc8-b77b-47c2-9579-74c2a39b3333", "normaluser21@gmail.com", true, "21", "Nguyen Van", false, null, "normaluser21@gmail.com", "normalUser21", "AQAAAAIAAYagAAAAEO9Gk1kwYWIri2bxyQiBNQ9yqcBHqRL3InzqcsPM65aE+06Tbiu9XCOPIGPtR5wcng==", null, false, "", false, "normalUser21", false },
                    { 22, 0, "HCM", "5e7ce743-6cff-4b0b-8383-063ebd1e73b2", "normaluser22@gmail.com", true, "22", "Nguyen Van", false, null, "normaluser22@gmail.com", "normalUser22", "AQAAAAIAAYagAAAAEO3s95wb3McNtAxasT1YsW+cf1Ekl2FKXXrlzr7aUnciwc6zC7m6YFPgHCFai9s1gQ==", null, false, "", false, "normalUser22", false },
                    { 23, 0, "HCM", "6406afe0-91bd-41be-b78c-d488955ade11", "normaluser23@gmail.com", true, "23", "Nguyen Van", false, null, "normaluser23@gmail.com", "normalUser23", "AQAAAAIAAYagAAAAEF7v8G4i+6c4NZuuK/aPY6SYTE10/3lHnlgTQbL4OjJ039IsQQx1qQiF3j2DWIA10w==", null, false, "", false, "normalUser23", false },
                    { 24, 0, "HCM", "bd2e3161-ccf0-48be-819b-fb47279ee170", "normaluser24@gmail.com", true, "24", "Nguyen Van", false, null, "normaluser24@gmail.com", "normalUser24", "AQAAAAIAAYagAAAAELYzIqUY2i/O5ox8nzhnY3m63Jl7+KEXj9hELrWw5C39x84EyjlSMy9K02hBOpFrOw==", null, false, "", false, "normalUser24", false },
                    { 25, 0, "HCM", "65c16cfe-0889-4994-9750-17a83fbbe68a", "normaluser25@gmail.com", true, "25", "Nguyen Van", false, null, "normaluser25@gmail.com", "normalUser25", "AQAAAAIAAYagAAAAEFBDn5p5W3sd8rHB/nw+tqU8Z2DTUbqm1pae9Yrx7DjSfZ6KtmcOoB4xUmiFIcZNSg==", null, false, "", false, "normalUser25", false },
                    { 26, 0, "HCM", "aa8c7ce5-e566-45a0-905a-f4137f58268a", "normaluser26@gmail.com", true, "26", "Nguyen Van", false, null, "normaluser26@gmail.com", "normalUser26", "AQAAAAIAAYagAAAAEKneJ1laJSqoHVvnvJcAClnSfExTtioGbvJG0cyQ2BeJNAHvTpRIm3vYoW93w33Q6w==", null, false, "", false, "normalUser26", false },
                    { 27, 0, "HCM", "7795d9f8-69ab-4a9c-a964-92e6cde9863f", "normaluser27@gmail.com", true, "27", "Nguyen Van", false, null, "normaluser27@gmail.com", "normalUser27", "AQAAAAIAAYagAAAAEHfRYKyJfFJpx5bk1OSfJZoq8fIJS1oMo8+A0lB3iTeBllXdBTkKh9fDj26AgtYKSQ==", null, false, "", false, "normalUser27", false },
                    { 28, 0, "HCM", "099adc1b-cd44-44e1-9349-f3e8a0d86af6", "normaluser28@gmail.com", true, "28", "Nguyen Van", false, null, "normaluser28@gmail.com", "normalUser28", "AQAAAAIAAYagAAAAEI2ih6cXJRy7VcAhscrMAtNF4z/uR9NDSrDmLCt5Xiuq1+ijS6NVEBS3lbLKUy9oFw==", null, false, "", false, "normalUser28", false },
                    { 29, 0, "HCM", "abb5fd3d-7a2a-4456-abdb-f2697edaa73c", "normaluser29@gmail.com", true, "29", "Nguyen Van", false, null, "normaluser29@gmail.com", "normalUser29", "AQAAAAIAAYagAAAAEKAw1qJgL7fsrrhWG1XZKXLChBsmTDGN+HBT4Zukzckh1so6hGA6b+H3R/M4IkEOCw==", null, false, "", false, "normalUser29", false },
                    { 30, 0, "HCM", "9c80f87b-5f3d-41b9-8150-4a18e06eb4d3", "normaluser30@gmail.com", true, "30", "Nguyen Van", false, null, "normaluser30@gmail.com", "normalUser30", "AQAAAAIAAYagAAAAEKiMDs4Pvjllq2ZAWC5r2bbfI9CsXDnaAIQygiz//QcMYTbeQF0HPEj797DNT0dUZA==", null, false, "", false, "normalUser30", false },
                    { 31, 0, "HCM", "c2c3c73d-d25a-4245-baed-29182522408b", "normaluser31@gmail.com", true, "31", "Nguyen Van", false, null, "normaluser31@gmail.com", "normalUser31", "AQAAAAIAAYagAAAAEAISOCE6pDsuO3rbGIM3blcOh5whd76BWvnW0X/XjTSHmVfTg19fqXBXdRP6yRdzQQ==", null, false, "", false, "normalUser31", false },
                    { 32, 0, "HCM", "c0d26978-d240-4600-99a2-fd4072036db7", "normaluser32@gmail.com", true, "32", "Nguyen Van", false, null, "normaluser32@gmail.com", "normalUser32", "AQAAAAIAAYagAAAAEKIv2JxQBRM6P7EpPbOay6S5akOBomLnltKy0/jzbrPF0VRk4lhmHisEqjUJegarhg==", null, false, "", false, "normalUser32", false },
                    { 33, 0, "HCM", "6ef355ff-6972-4d8c-9328-e1e1d5b88505", "normaluser33@gmail.com", true, "33", "Nguyen Van", false, null, "normaluser33@gmail.com", "normalUser33", "AQAAAAIAAYagAAAAEKe3kRrdMclxHe4ZQjuiDXYIOiafr0PBDJ1C444zcRN4EpJ/o2LOCVTxAI49WdfTzQ==", null, false, "", false, "normalUser33", false },
                    { 34, 0, "HCM", "acd3330f-5c6f-4853-b855-486b7c41c959", "normaluser34@gmail.com", true, "34", "Nguyen Van", false, null, "normaluser34@gmail.com", "normalUser34", "AQAAAAIAAYagAAAAEGIDXMBzbAgB9ZhW/hsVm0lUnWI62Att95Hssg5EvhN/bzRo+fa1t4wCsIEc/SHkng==", null, false, "", false, "normalUser34", false },
                    { 35, 0, "HCM", "04f7851b-10f5-4712-b63f-1292899d68aa", "normaluser35@gmail.com", true, "35", "Nguyen Van", false, null, "normaluser35@gmail.com", "normalUser35", "AQAAAAIAAYagAAAAEONtqryAOHsyhbXDdTBVjIkU1pjN46fnkmcdXJ3h5yBwtQY61jqwrIDDIRl2jQf0QQ==", null, false, "", false, "normalUser35", false },
                    { 36, 0, "HCM", "4785b46f-0ef3-48ef-8472-ac8674674ae7", "normaluser36@gmail.com", true, "36", "Nguyen Van", false, null, "normaluser36@gmail.com", "normalUser36", "AQAAAAIAAYagAAAAEBV3MOtxzEM3AjiKKAu/iS6JEmRXfK5qW0E7xawpO6nh/AmS+aqyxquF4y4HJ7q4ww==", null, false, "", false, "normalUser36", false },
                    { 37, 0, "HCM", "4bd8c204-8add-49bf-b5c5-2488ed9f9603", "normaluser37@gmail.com", true, "37", "Nguyen Van", false, null, "normaluser37@gmail.com", "normalUser37", "AQAAAAIAAYagAAAAEOBMZ+TWzdwPHAL+oRstQJhr7Q3qC1viHgL0Hx970+zAzj3gsr9RmZQVm/tCyzt22w==", null, false, "", false, "normalUser37", false },
                    { 38, 0, "HCM", "02c68f39-fc12-4f3e-82eb-7dbef097e6e0", "normaluser38@gmail.com", true, "38", "Nguyen Van", false, null, "normaluser38@gmail.com", "normalUser38", "AQAAAAIAAYagAAAAED88Br2ULydN045/Ws8jGWJq5zEGgiVQJBJoRBLC679E8FnRQKapgXEtykYj3S5E+g==", null, false, "", false, "normalUser38", false },
                    { 39, 0, "HCM", "28176a1c-86c9-4280-ba5a-c0f118bf4650", "normaluser39@gmail.com", true, "39", "Nguyen Van", false, null, "normaluser39@gmail.com", "normalUser39", "AQAAAAIAAYagAAAAEPkgvPIRT0T6eeJOX51Aj1kR/nnGSUc8MUYiyNQ3CyonXA1fn9qMAg2jHpAoj9ENxw==", null, false, "", false, "normalUser39", false },
                    { 40, 0, "HCM", "f497365e-6c41-49c7-b9ee-c05a1252e1be", "normaluser40@gmail.com", true, "40", "Nguyen Van", false, null, "normaluser40@gmail.com", "normalUser40", "AQAAAAIAAYagAAAAEH/nt6+oVe6qrhP+ocsp2lcaA/sxXmlS9efsne/2mR0ekFsb0Qy+Qq1nNUE4in52xw==", null, false, "", false, "normalUser40", false },
                    { 41, 0, "HCM", "694bfd92-ca01-45c9-94c0-9cb8bbc0aeb6", "normaluser41@gmail.com", true, "41", "Nguyen Van", false, null, "normaluser41@gmail.com", "normalUser41", "AQAAAAIAAYagAAAAECQg4zS9dfkcxrjkUU5eSMi0Jz9xjo8Zib1F33WoI1IhzjRWb4qIIWb4TdJIdpRWyQ==", null, false, "", false, "normalUser41", false },
                    { 42, 0, "HCM", "38d73371-1274-437c-9297-c7865de44784", "normaluser42@gmail.com", true, "42", "Nguyen Van", false, null, "normaluser42@gmail.com", "normalUser42", "AQAAAAIAAYagAAAAEM4CwJMBBEWIlBeTqjGmkJYGe9JbIERrFYLnSoqdKBhvW/AvhzoiMbUiNBYwB1ttHQ==", null, false, "", false, "normalUser42", false },
                    { 43, 0, "HCM", "399d090d-5d63-4dbd-827d-e9cd74ca583a", "normaluser43@gmail.com", true, "43", "Nguyen Van", false, null, "normaluser43@gmail.com", "normalUser43", "AQAAAAIAAYagAAAAEBPjyCWFZrHYuotVjxgiTA9+z9noBeM5OqSoNPO+g0LdWXQEKWRtjMs9GG+bRec+tA==", null, false, "", false, "normalUser43", false },
                    { 44, 0, "HCM", "60d1a01b-fa9b-4812-b618-127d943dcbfd", "normaluser44@gmail.com", true, "44", "Nguyen Van", false, null, "normaluser44@gmail.com", "normalUser44", "AQAAAAIAAYagAAAAEGdrG6bufYwUX4OVYzXC9G2LokL8VXOa/JCkaXBxNqRpF9mD9+uHM1QypXHBqSAw9w==", null, false, "", false, "normalUser44", false },
                    { 45, 0, "HCM", "1b7efb58-3767-4aa3-8813-92c5fe1af7ae", "normaluser45@gmail.com", true, "45", "Nguyen Van", false, null, "normaluser45@gmail.com", "normalUser45", "AQAAAAIAAYagAAAAEKDTjefwq6B4Q+2TRgwhXE1ITrUqMdfCqwldw+xZJu/fg9KALRny9jjiBAiBnWoKRg==", null, false, "", false, "normalUser45", false },
                    { 46, 0, "HCM", "e24f7566-d0b9-4a69-8da5-d5cced8747fe", "normaluser46@gmail.com", true, "46", "Nguyen Van", false, null, "normaluser46@gmail.com", "normalUser46", "AQAAAAIAAYagAAAAENAppMbwz3yjeSShKo7Rad0bAQlZyHkuEpj6otS8O/lGjIo/SmRFRWHuTWwXoinV5A==", null, false, "", false, "normalUser46", false },
                    { 47, 0, "HCM", "bd6bcef9-7bdf-48f6-82ed-112d8c4d3fd9", "normaluser47@gmail.com", true, "47", "Nguyen Van", false, null, "normaluser47@gmail.com", "normalUser47", "AQAAAAIAAYagAAAAELyLoDXfNdSf6648fdIlX+uybF20R2XQAq95iScuTin11aGxN/9+FTbTyg2Poec3bA==", null, false, "", false, "normalUser47", false },
                    { 48, 0, "HCM", "c40402bc-61e3-462f-8808-b8954d866056", "normaluser48@gmail.com", true, "48", "Nguyen Van", false, null, "normaluser48@gmail.com", "normalUser48", "AQAAAAIAAYagAAAAEFwX6XTwMSSCCfO4fywkfjAKQ6DJhTpsLmF0mqvthOtDm28oVYTMVtZS51LjEP1PsQ==", null, false, "", false, "normalUser48", false },
                    { 49, 0, "HCM", "a37e4522-740e-4822-bbea-422f37d99ee5", "normaluser49@gmail.com", true, "49", "Nguyen Van", false, null, "normaluser49@gmail.com", "normalUser49", "AQAAAAIAAYagAAAAEHX10s+AMAH6EM10q0za9tGn4DO4XTn28/61FNJ/JpCCszOlj9bjXHpxbOAhoeaLaQ==", null, false, "", false, "normalUser49", false },
                    { 50, 0, "HCM", "2295879f-058b-4bfd-ae89-709d8d7cb966", "normaluser50@gmail.com", true, "50", "Nguyen Van", false, null, "normaluser50@gmail.com", "normalUser50", "AQAAAAIAAYagAAAAEDUtnozgOqxqUSxzs3e3EaquYJd5kMwGcDgLH7xtHUseT+TFY4fqEAMcKiNfY8D/BQ==", null, false, "", false, "normalUser50", false },
                    { 51, 0, "HCM", "234ed75c-fee6-4cb3-9d8d-bed91ec688c7", "normaluser51@gmail.com", true, "51", "Nguyen Van", false, null, "normaluser51@gmail.com", "normalUser51", "AQAAAAIAAYagAAAAEEiJKhteu5YdZK20sLOEHtmF/Xoi54tdHxv+k8HJg5eWBrXmtgLODOSPsHyZQtGoNw==", null, false, "", false, "normalUser51", false },
                    { 52, 0, "HCM", "24065eb8-bc34-46f0-843b-7ffd946a05d8", "normaluser52@gmail.com", true, "52", "Nguyen Van", false, null, "normaluser52@gmail.com", "normalUser52", "AQAAAAIAAYagAAAAEDGeTeGcEKNHnB9WTppCNiKNvoTMnZd9MXkgmgsfOK6QXfdRjoq1/qRiWXCOMuG1fw==", null, false, "", false, "normalUser52", false },
                    { 53, 0, "HCM", "4ffcd568-56dd-40fe-a5f5-912b1393ed63", "normaluser53@gmail.com", true, "53", "Nguyen Van", false, null, "normaluser53@gmail.com", "normalUser53", "AQAAAAIAAYagAAAAELR4wK9BuLTAb6karNH8CHMqZl2McHZOFqcKD+Hrbfhb2s7bi6TCLvl9OtnR0KV7sA==", null, false, "", false, "normalUser53", false },
                    { 54, 0, "HCM", "f2138b31-00a5-444a-a364-f50502f09443", "normaluser54@gmail.com", true, "54", "Nguyen Van", false, null, "normaluser54@gmail.com", "normalUser54", "AQAAAAIAAYagAAAAEFUblXmdfeUnIxK1XV7Ro8kfTr5L+XAolHWmYACd4RIwei+q6ZXJk3pd3RU5Yt9iGw==", null, false, "", false, "normalUser54", false },
                    { 55, 0, "HCM", "167531be-a5fc-4cea-9c26-228d60533837", "normaluser55@gmail.com", true, "55", "Nguyen Van", false, null, "normaluser55@gmail.com", "normalUser55", "AQAAAAIAAYagAAAAEDz/y0e2RzWZqevO5FizzUM0vhgnF17ct4y0zt8k1YVc++sa8YRZ9IO/fEVdF5xLrw==", null, false, "", false, "normalUser55", false },
                    { 56, 0, "HCM", "8dd87a72-f8c9-4056-8eee-2fcc39352ca6", "normaluser56@gmail.com", true, "56", "Nguyen Van", false, null, "normaluser56@gmail.com", "normalUser56", "AQAAAAIAAYagAAAAEP0JCBsPQB8AbGIeBKooWV9VmB2r5qQFAp2uFBEoCZByY7iYVFUcSr3zjWRSnEIRPw==", null, false, "", false, "normalUser56", false },
                    { 57, 0, "HCM", "731f7973-d58a-4491-9313-4dd118d6be03", "normaluser57@gmail.com", true, "57", "Nguyen Van", false, null, "normaluser57@gmail.com", "normalUser57", "AQAAAAIAAYagAAAAECgoDEQdctpZxdfigZVX9xqN+ueH+HFre+BjEWZU17bqTJEzao8Y0RBXsUK4ad7Kng==", null, false, "", false, "normalUser57", false },
                    { 58, 0, "HCM", "1dd87882-2cc5-49c5-8a38-9a4b869eb05c", "normaluser58@gmail.com", true, "58", "Nguyen Van", false, null, "normaluser58@gmail.com", "normalUser58", "AQAAAAIAAYagAAAAEBMAQ9OgjKD6BwYw7cBwcK1oty+exIsoEijJyNpjAAH1qlZpYxsVtcB4jgAglovSTw==", null, false, "", false, "normalUser58", false },
                    { 59, 0, "HCM", "8f67485e-5d44-4090-b43a-a3b7d09c83eb", "normaluser59@gmail.com", true, "59", "Nguyen Van", false, null, "normaluser59@gmail.com", "normalUser59", "AQAAAAIAAYagAAAAEAtrWmUwi/qe2q3xvXvdIn0b1mKTmqfXatPDSnbHeFQ0hiZYGzw3p59KhwoJIXmepg==", null, false, "", false, "normalUser59", false },
                    { 60, 0, "HCM", "64d3fb5d-e9a2-403e-adab-f78fa2fa388d", "normaluser60@gmail.com", true, "60", "Nguyen Van", false, null, "normaluser60@gmail.com", "normalUser60", "AQAAAAIAAYagAAAAEHvNSANktLPlgH59LpAX5ctrPgscQ3N8EwJUPJ6fIWfXh7RbXaux55R41vGAv6gMLg==", null, false, "", false, "normalUser60", false },
                    { 61, 0, "HCM", "8ff8e786-6eca-441b-a8da-eacdcab17244", "normaluser61@gmail.com", true, "61", "Nguyen Van", false, null, "normaluser61@gmail.com", "normalUser61", "AQAAAAIAAYagAAAAEMRKz/61oA3eXAlKmcSXC0Qf/BKIfDE8yzfqd1s0v/hCWKga6AetyKg+c/wnv04ZZQ==", null, false, "", false, "normalUser61", false },
                    { 62, 0, "HCM", "ff9bdcfc-6388-4afe-b96a-773395bd1473", "normaluser62@gmail.com", true, "62", "Nguyen Van", false, null, "normaluser62@gmail.com", "normalUser62", "AQAAAAIAAYagAAAAEIoBuNR/OJnUcyD0cCdvDKBnzTYy8WxE2na7ANb6tWeXOhO0L/eB8EJF7trD1fkhFQ==", null, false, "", false, "normalUser62", false },
                    { 63, 0, "HCM", "c2c10769-7f20-4a9c-8862-1ffcca23f7b6", "normaluser63@gmail.com", true, "63", "Nguyen Van", false, null, "normaluser63@gmail.com", "normalUser63", "AQAAAAIAAYagAAAAEKznvCoWao8YYp8QL67MViYaI6D8Tzk+/A7GNVvY5Ibp1j/GGzSclo4OtDVQ6iVJxg==", null, false, "", false, "normalUser63", false },
                    { 64, 0, "HCM", "3c819de7-60d9-459e-b4b9-fcbcf6517306", "normaluser64@gmail.com", true, "64", "Nguyen Van", false, null, "normaluser64@gmail.com", "normalUser64", "AQAAAAIAAYagAAAAEHdCGDZQaCxza2JMoVjiqLNG6dD5XKELC9l8vi+rbr2H0Pc3UHAC6xAPUcnZ8PeNQQ==", null, false, "", false, "normalUser64", false },
                    { 65, 0, "HCM", "0dc9fa60-30a7-48e4-a1e4-209f189791b0", "normaluser65@gmail.com", true, "65", "Nguyen Van", false, null, "normaluser65@gmail.com", "normalUser65", "AQAAAAIAAYagAAAAEBfd9kiBZ6KUDRWHHwy3NPpnRHFsDkHTEBbbYN2X7RxHENfgVls6nRGtsuKs3gAMtw==", null, false, "", false, "normalUser65", false }
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
                    { 36, 36, "I am 36", "https://picsum.photos/seed/31/500/500", 3600.0, "This is my resume", "Title 36" },
                    { 37, 37, "I am 37", "https://picsum.photos/seed/32/500/500", 3700.0, "This is my resume", "Title 37" },
                    { 38, 38, "I am 38", "https://picsum.photos/seed/33/500/500", 3800.0, "This is my resume", "Title 38" },
                    { 39, 39, "I am 39", "https://picsum.photos/seed/34/500/500", 3900.0, "This is my resume", "Title 39" },
                    { 40, 40, "I am 40", "https://picsum.photos/seed/35/500/500", 4000.0, "This is my resume", "Title 40" },
                    { 41, 41, "I am 41", "https://picsum.photos/seed/36/500/500", 4100.0, "This is my resume", "Title 41" },
                    { 42, 42, "I am 42", "https://picsum.photos/seed/37/500/500", 4200.0, "This is my resume", "Title 42" },
                    { 43, 43, "I am 43", "https://picsum.photos/seed/38/500/500", 4300.0, "This is my resume", "Title 43" },
                    { 44, 44, "I am 44", "https://picsum.photos/seed/39/500/500", 4400.0, "This is my resume", "Title 44" },
                    { 45, 45, "I am 45", "https://picsum.photos/seed/40/500/500", 4500.0, "This is my resume", "Title 45" },
                    { 46, 46, "I am 46", "https://picsum.photos/seed/41/500/500", 4600.0, "This is my resume", "Title 46" },
                    { 47, 47, "I am 47", "https://picsum.photos/seed/42/500/500", 4700.0, "This is my resume", "Title 47" },
                    { 48, 48, "I am 48", "https://picsum.photos/seed/43/500/500", 4800.0, "This is my resume", "Title 48" },
                    { 49, 49, "I am 49", "https://picsum.photos/seed/44/500/500", 4900.0, "This is my resume", "Title 49" },
                    { 50, 50, "I am 50", "https://picsum.photos/seed/45/500/500", 5000.0, "This is my resume", "Title 50" },
                    { 51, 51, "I am 51", "https://picsum.photos/seed/46/500/500", 5100.0, "This is my resume", "Title 51" },
                    { 52, 52, "I am 52", "https://picsum.photos/seed/47/500/500", 5200.0, "This is my resume", "Title 52" },
                    { 53, 53, "I am 53", "https://picsum.photos/seed/48/500/500", 5300.0, "This is my resume", "Title 53" },
                    { 54, 54, "I am 54", "https://picsum.photos/seed/49/500/500", 5400.0, "This is my resume", "Title 54" },
                    { 55, 55, "I am 55", "https://picsum.photos/seed/50/500/500", 5500.0, "This is my resume", "Title 55" },
                    { 56, 56, "I am 56", "https://picsum.photos/seed/51/500/500", 5600.0, "This is my resume", "Title 56" },
                    { 57, 57, "I am 57", "https://picsum.photos/seed/52/500/500", 5700.0, "This is my resume", "Title 57" },
                    { 58, 58, "I am 58", "https://picsum.photos/seed/53/500/500", 5800.0, "This is my resume", "Title 58" },
                    { 59, 59, "I am 59", "https://picsum.photos/seed/54/500/500", 5900.0, "This is my resume", "Title 59" },
                    { 60, 60, "I am 60", "https://picsum.photos/seed/55/500/500", 6000.0, "This is my resume", "Title 60" },
                    { 61, 61, "I am 61", "https://picsum.photos/seed/56/500/500", 6100.0, "This is my resume", "Title 61" },
                    { 62, 62, "I am 62", "https://picsum.photos/seed/57/500/500", 6200.0, "This is my resume", "Title 62" },
                    { 63, 63, "I am 63", "https://picsum.photos/seed/58/500/500", 6300.0, "This is my resume", "Title 63" },
                    { 64, 64, "I am 64", "https://picsum.photos/seed/59/500/500", 6400.0, "This is my resume", "Title 64" },
                    { 65, 65, "I am 65", "https://picsum.photos/seed/60/500/500", 6500.0, "This is my resume", "Title 65" }
                });

            migrationBuilder.InsertData(
                table: "FreelancerCategories",
                columns: new[] { "CategoryId", "FreelancerProfileId" },
                values: new object[,]
                {
                    { 7, 36 },
                    { 4, 37 },
                    { 4, 38 },
                    { 5, 39 },
                    { 7, 40 },
                    { 6, 41 },
                    { 6, 42 },
                    { 8, 43 },
                    { 6, 44 },
                    { 3, 45 },
                    { 3, 46 },
                    { 8, 47 },
                    { 6, 48 },
                    { 3, 49 },
                    { 1, 50 },
                    { 5, 51 },
                    { 8, 52 },
                    { 5, 53 },
                    { 2, 54 },
                    { 8, 55 },
                    { 1, 56 },
                    { 2, 57 },
                    { 7, 58 },
                    { 8, 59 },
                    { 8, 60 },
                    { 6, 61 },
                    { 5, 62 },
                    { 2, 63 },
                    { 1, 64 },
                    { 8, 65 }
                });

            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "Id", "ApplyExpireDate", "BusinessProfileId", "CreatedDate", "Description", "ImageUrl", "IsActive", "JobDescriptionFileUrl", "JobExpiredDate", "Name", "Offer" },
                values: new object[,]
                {
                    { 1, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(2642), "This a simple description for project 1", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 1", 99.0 },
                    { 2, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 33, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(2905), "This a simple description for project 2", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 2", 198.0 },
                    { 3, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(2921), "This a simple description for project 3", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 3", 297.0 },
                    { 4, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(2933), "This a simple description for project 4", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 4", 396.0 },
                    { 5, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(2945), "This a simple description for project 5", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 5", 495.0 },
                    { 6, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 33, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(2960), "This a simple description for project 6", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 6", 594.0 },
                    { 7, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(2971), "This a simple description for project 7", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 7", 693.0 },
                    { 8, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 33, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(2983), "This a simple description for project 8", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 8", 792.0 },
                    { 9, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(2995), "This a simple description for project 9", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 9", 891.0 },
                    { 10, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(3010), "This a simple description for project 10", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 10", 990.0 },
                    { 11, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 32, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(3107), "This a simple description for project 11", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 11", 1089.0 },
                    { 12, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(3123), "This a simple description for project 12", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 12", 1188.0 },
                    { 13, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(3135), "This a simple description for project 13", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 13", 1287.0 },
                    { 14, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(3147), "This a simple description for project 14", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 14", 1386.0 },
                    { 15, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(3159), "This a simple description for project 15", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 15", 1485.0 },
                    { 16, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(3171), "This a simple description for project 16", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 16", 1584.0 },
                    { 17, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(3183), "This a simple description for project 17", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 17", 1683.0 },
                    { 18, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(3197), "This a simple description for project 18", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 18", 1782.0 },
                    { 19, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 33, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(3209), "This a simple description for project 19", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 19", 1881.0 },
                    { 20, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(3221), "This a simple description for project 20", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 20", 1980.0 },
                    { 21, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(3285), "This a simple description for project 21", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 21", 2079.0 },
                    { 22, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(3297), "This a simple description for project 22", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 22", 2178.0 },
                    { 23, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(3308), "This a simple description for project 23", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 23", 2277.0 },
                    { 24, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(3321), "This a simple description for project 24", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 24", 2376.0 },
                    { 25, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(3333), "This a simple description for project 25", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 25", 2475.0 },
                    { 26, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(3345), "This a simple description for project 26", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 26", 2574.0 },
                    { 27, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(3356), "This a simple description for project 27", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 27", 2673.0 },
                    { 28, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(3369), "This a simple description for project 28", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 28", 2772.0 },
                    { 29, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 33, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(3380), "This a simple description for project 29", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 29", 2871.0 },
                    { 30, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4375), "This a simple description for project 30", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 30", 2970.0 },
                    { 31, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4450), "This a simple description for project 31", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 31", 3069.0 },
                    { 32, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4463), "This a simple description for project 32", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 32", 3168.0 },
                    { 33, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4474), "This a simple description for project 33", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 33", 3267.0 },
                    { 34, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4492), "This a simple description for project 34", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 34", 3366.0 },
                    { 35, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4504), "This a simple description for project 35", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 35", 3465.0 },
                    { 36, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4516), "This a simple description for project 36", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 36", 3564.0 },
                    { 37, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4529), "This a simple description for project 37", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 37", 3663.0 },
                    { 38, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4541), "This a simple description for project 38", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 38", 3762.0 },
                    { 39, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4628), "This a simple description for project 39", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 39", 3861.0 },
                    { 40, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4641), "This a simple description for project 40", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 40", 3960.0 },
                    { 41, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4653), "This a simple description for project 41", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 41", 4059.0 },
                    { 42, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4665), "This a simple description for project 42", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 42", 4158.0 },
                    { 43, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4676), "This a simple description for project 43", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 43", 4257.0 },
                    { 44, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4688), "This a simple description for project 44", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 44", 4356.0 },
                    { 45, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4701), "This a simple description for project 45", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 45", 4455.0 },
                    { 46, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4713), "This a simple description for project 46", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 46", 4554.0 },
                    { 47, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4725), "This a simple description for project 47", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 47", 4653.0 },
                    { 48, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4736), "This a simple description for project 48", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 48", 4752.0 },
                    { 49, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4808), "This a simple description for project 49", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 49", 4851.0 },
                    { 50, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 33, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4820), "This a simple description for project 50", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 50", 4950.0 },
                    { 51, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4832), "This a simple description for project 51", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 51", 5049.0 },
                    { 52, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4844), "This a simple description for project 52", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 52", 5148.0 },
                    { 53, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4857), "This a simple description for project 53", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 53", 5247.0 },
                    { 54, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4868), "This a simple description for project 54", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 54", 5346.0 },
                    { 55, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4881), "This a simple description for project 55", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 55", 5445.0 },
                    { 56, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4893), "This a simple description for project 56", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 56", 5544.0 },
                    { 57, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4904), "This a simple description for project 57", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 57", 5643.0 },
                    { 58, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4967), "This a simple description for project 58", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 58", 5742.0 },
                    { 59, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4981), "This a simple description for project 59", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 59", 5841.0 },
                    { 60, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 32, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(4993), "This a simple description for project 60", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 60", 5940.0 },
                    { 61, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5005), "This a simple description for project 61", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 61", 6039.0 },
                    { 62, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5017), "This a simple description for project 62", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 62", 6138.0 },
                    { 63, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5029), "This a simple description for project 63", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 63", 6237.0 },
                    { 64, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5042), "This a simple description for project 64", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 64", 6336.0 },
                    { 65, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5053), "This a simple description for project 65", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 65", 6435.0 },
                    { 66, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5120), "This a simple description for project 66", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 66", 6534.0 },
                    { 67, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5132), "This a simple description for project 67", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 67", 6633.0 },
                    { 68, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5144), "This a simple description for project 68", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 68", 6732.0 },
                    { 69, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5156), "This a simple description for project 69", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 69", 6831.0 },
                    { 70, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5168), "This a simple description for project 70", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 70", 6930.0 },
                    { 71, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5180), "This a simple description for project 71", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 71", 7029.0 },
                    { 72, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5192), "This a simple description for project 72", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 72", 7128.0 },
                    { 73, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5204), "This a simple description for project 73", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 73", 7227.0 },
                    { 74, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5215), "This a simple description for project 74", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 74", 7326.0 },
                    { 75, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5227), "This a simple description for project 75", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 75", 7425.0 },
                    { 76, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5327), "This a simple description for project 76", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 76", 7524.0 },
                    { 77, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5339), "This a simple description for project 77", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 77", 7623.0 },
                    { 78, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5352), "This a simple description for project 78", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 78", 7722.0 },
                    { 79, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5363), "This a simple description for project 79", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 79", 7821.0 },
                    { 80, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5375), "This a simple description for project 80", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 80", 7920.0 },
                    { 81, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5387), "This a simple description for project 81", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 81", 8019.0 },
                    { 82, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5399), "This a simple description for project 82", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 82", 8118.0 },
                    { 83, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5410), "This a simple description for project 83", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 83", 8217.0 },
                    { 84, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5422), "This a simple description for project 84", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 84", 8316.0 },
                    { 85, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5482), "This a simple description for project 85", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 85", 8415.0 },
                    { 86, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5496), "This a simple description for project 86", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 86", 8514.0 },
                    { 87, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5508), "This a simple description for project 87", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 87", 8613.0 },
                    { 88, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5520), "This a simple description for project 88", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 88", 8712.0 },
                    { 89, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5532), "This a simple description for project 89", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 89", 8811.0 },
                    { 90, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5544), "This a simple description for project 90", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 90", 8910.0 },
                    { 91, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5556), "This a simple description for project 91", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 91", 9009.0 },
                    { 92, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5568), "This a simple description for project 92", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 92", 9108.0 },
                    { 93, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 33, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5580), "This a simple description for project 93", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 93", 9207.0 },
                    { 94, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5592), "This a simple description for project 94", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 94", 9306.0 },
                    { 95, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 33, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5651), "This a simple description for project 95", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 95", 9405.0 },
                    { 96, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5664), "This a simple description for project 96", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 96", 9504.0 },
                    { 97, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5676), "This a simple description for project 97", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 97", 9603.0 },
                    { 98, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5688), "This a simple description for project 98", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 98", 9702.0 },
                    { 99, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5700), "This a simple description for project 99", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 99", 9801.0 },
                    { 100, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 10, 18, 45, 17, 56, DateTimeKind.Local).AddTicks(5712), "This a simple description for project 100", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 100", 9900.0 }
                });

            migrationBuilder.InsertData(
                table: "JobCategories",
                columns: new[] { "CategoryId", "JobId" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 7, 2 },
                    { 2, 3 },
                    { 7, 4 },
                    { 4, 5 },
                    { 4, 6 },
                    { 6, 7 },
                    { 1, 8 },
                    { 6, 9 },
                    { 5, 10 },
                    { 2, 11 },
                    { 1, 12 },
                    { 5, 13 },
                    { 7, 14 },
                    { 5, 15 },
                    { 5, 16 },
                    { 5, 17 },
                    { 4, 18 },
                    { 6, 19 },
                    { 3, 20 },
                    { 7, 21 },
                    { 7, 22 },
                    { 5, 23 },
                    { 4, 24 },
                    { 6, 25 },
                    { 2, 26 },
                    { 7, 27 },
                    { 5, 28 },
                    { 4, 29 },
                    { 5, 30 },
                    { 1, 31 },
                    { 1, 32 },
                    { 4, 33 },
                    { 4, 34 },
                    { 5, 35 },
                    { 5, 36 },
                    { 2, 37 },
                    { 5, 38 },
                    { 5, 39 },
                    { 6, 40 },
                    { 1, 41 },
                    { 3, 42 },
                    { 3, 43 },
                    { 3, 44 },
                    { 5, 45 },
                    { 2, 46 },
                    { 6, 47 },
                    { 3, 48 },
                    { 6, 49 },
                    { 3, 50 },
                    { 4, 51 },
                    { 5, 52 },
                    { 2, 53 },
                    { 3, 54 },
                    { 4, 55 },
                    { 5, 56 },
                    { 7, 57 },
                    { 3, 58 },
                    { 5, 59 },
                    { 5, 60 },
                    { 3, 61 },
                    { 2, 62 },
                    { 7, 63 },
                    { 1, 64 },
                    { 7, 65 },
                    { 1, 66 },
                    { 1, 67 },
                    { 1, 68 },
                    { 2, 69 },
                    { 3, 70 },
                    { 5, 71 },
                    { 4, 72 },
                    { 5, 73 },
                    { 3, 74 },
                    { 1, 75 },
                    { 1, 76 },
                    { 2, 77 },
                    { 4, 78 },
                    { 4, 79 },
                    { 1, 80 },
                    { 5, 81 },
                    { 7, 82 },
                    { 5, 83 },
                    { 7, 84 },
                    { 4, 85 },
                    { 3, 86 },
                    { 2, 87 },
                    { 2, 88 },
                    { 6, 89 },
                    { 5, 90 },
                    { 7, 91 },
                    { 3, 92 },
                    { 5, 93 },
                    { 6, 94 },
                    { 1, 95 },
                    { 5, 96 },
                    { 2, 97 },
                    { 1, 98 },
                    { 5, 99 },
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
