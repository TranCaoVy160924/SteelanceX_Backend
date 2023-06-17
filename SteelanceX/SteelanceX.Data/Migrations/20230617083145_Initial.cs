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
                    { 1, 0, "HCM", "f59dd2a9-29fd-4814-900e-c164c298ee2e", "normaluser1@gmail.com", true, "1", true, "Nguyen Van", false, null, "normaluser1@gmail.com", "normalUser1", "AQAAAAIAAYagAAAAELtb+3qkD5tCDzDE+0N54WqJu27WsJu0lEtbsLMv3NbDk0m9RTZmjRlD8vDYJTIDnw==", null, false, "", false, "normalUser1" },
                    { 2, 0, "HCM", "2ae5374e-609b-4dbc-8f36-dca2605988f4", "normaluser2@gmail.com", true, "2", true, "Nguyen Van", false, null, "normaluser2@gmail.com", "normalUser2", "AQAAAAIAAYagAAAAEN/GjEe8muP912iGGTjCz4LIAnEcAS6N7EYmcajSeDXgSfsk8S4KDPS+vrnOk82gWQ==", null, false, "", false, "normalUser2" },
                    { 3, 0, "HCM", "b921f35f-5690-49f0-b09f-0509efeee131", "normaluser3@gmail.com", true, "3", true, "Nguyen Van", false, null, "normaluser3@gmail.com", "normalUser3", "AQAAAAIAAYagAAAAEHy1RX6kf/o3ptemdTmZjaZhVlQCNJjD7kooSFOr10AD/YSQ81M4vfy6/bnbNLBkQQ==", null, false, "", false, "normalUser3" },
                    { 4, 0, "HCM", "e97ffa83-e9ce-4083-ab81-2323d7b0a2fa", "normaluser4@gmail.com", true, "4", true, "Nguyen Van", false, null, "normaluser4@gmail.com", "normalUser4", "AQAAAAIAAYagAAAAEAXEQsD1+ohGmSzpeywVAKsr21mhO6+CsO6qAAEzr3Dui6p0BwoVFK1O5OuVplQNTg==", null, false, "", false, "normalUser4" },
                    { 5, 0, "HCM", "0c6eb5a1-628a-4a25-a624-5d3e9a028ebd", "normaluser5@gmail.com", true, "5", true, "Nguyen Van", false, null, "normaluser5@gmail.com", "normalUser5", "AQAAAAIAAYagAAAAEGRWap4hzyVgjfkscE6waI3ziIr18miHzfxBFG+YGXxTB/1YyflnYGWSDUOVF85jHg==", null, false, "", false, "normalUser5" },
                    { 6, 0, "HCM", "80a29ddb-8753-4654-891b-8f24b593626e", "normaluser6@gmail.com", true, "6", true, "Nguyen Van", false, null, "normaluser6@gmail.com", "normalUser6", "AQAAAAIAAYagAAAAEEJTDU7eP9niIbAy6RPYJq6J8cuHKhBlW4HSQSxnGX+LlGjIrslP6IWxDq8ayb7xHg==", null, false, "", false, "normalUser6" },
                    { 7, 0, "HCM", "35ef3018-38be-4e9d-8a6b-a77857fc5bef", "normaluser7@gmail.com", true, "7", true, "Nguyen Van", false, null, "normaluser7@gmail.com", "normalUser7", "AQAAAAIAAYagAAAAEBWTmQFwXXPYkb3N0uWiGTqbV3x5wHMPparAD3JELB3bCCoksqYwnkOur+xWxRXNNA==", null, false, "", false, "normalUser7" },
                    { 8, 0, "HCM", "cc6e91ad-e515-4854-829f-bb90d39f3601", "normaluser8@gmail.com", true, "8", true, "Nguyen Van", false, null, "normaluser8@gmail.com", "normalUser8", "AQAAAAIAAYagAAAAEG6d/LNXpwpTYW18NaI4VNYX3Ocq5WIfbRBG/fuV74o2NZ1S7nhCknOxJ1aghth82Q==", null, false, "", false, "normalUser8" },
                    { 9, 0, "HCM", "409e3a3c-ea50-492d-97da-15344cf02f4e", "normaluser9@gmail.com", true, "9", true, "Nguyen Van", false, null, "normaluser9@gmail.com", "normalUser9", "AQAAAAIAAYagAAAAEGl/uPpnJou1/6gOyLfNoiGD8/glyLiC6HO9e7/LMGAmwI8bx7VIk7XgYT49fuxk2A==", null, false, "", false, "normalUser9" },
                    { 10, 0, "HCM", "0413e78a-df05-46e3-a172-01336e03215e", "normaluser10@gmail.com", true, "10", true, "Nguyen Van", false, null, "normaluser10@gmail.com", "normalUser10", "AQAAAAIAAYagAAAAEPGLBa9R8VD4+D+4ZQdL2ISK9zcEiSa1xnff8jqLEI/5RUC9vGAN1i4Fx9Wmecsk/Q==", null, false, "", false, "normalUser10" },
                    { 11, 0, "HCM", "e82604b4-da94-47f6-aa19-3826c132f851", "normaluser11@gmail.com", true, "11", true, "Nguyen Van", false, null, "normaluser11@gmail.com", "normalUser11", "AQAAAAIAAYagAAAAEIupouA1URLoxwbL6MQRhX/ZR+3A0GBKfxkFdY8dbVTikFAgeIqey+JCABXVoIR/fw==", null, false, "", false, "normalUser11" },
                    { 12, 0, "HCM", "0008b321-dd6a-4c98-8cdc-7981cd372805", "normaluser12@gmail.com", true, "12", true, "Nguyen Van", false, null, "normaluser12@gmail.com", "normalUser12", "AQAAAAIAAYagAAAAEEF5GYqO2kvEemH6aPUM6pDnjvXK6m3u4Y954dadxIhxwpZWkJcMn43UAsHdYJUBDw==", null, false, "", false, "normalUser12" },
                    { 13, 0, "HCM", "1ad469dc-5526-421f-905e-5b68fe32f6af", "normaluser13@gmail.com", true, "13", true, "Nguyen Van", false, null, "normaluser13@gmail.com", "normalUser13", "AQAAAAIAAYagAAAAEBy8DzJb7DZ7dPu68dfjP78YDPeFwODbTPFOcHEpl3r/Z0GyOh5UlOuzMj+VgesbYQ==", null, false, "", false, "normalUser13" },
                    { 14, 0, "HCM", "4723d904-aea4-4c4d-bda8-8b1fbf024ceb", "normaluser14@gmail.com", true, "14", true, "Nguyen Van", false, null, "normaluser14@gmail.com", "normalUser14", "AQAAAAIAAYagAAAAEOr48YpEdMxGYQ6HQUrlStoCASeZJlGC5oypOL9AfgTz2pNOco8ojsKyAY8NjWc2ew==", null, false, "", false, "normalUser14" },
                    { 15, 0, "HCM", "74cf0d73-8a7f-45ea-b050-a231274dd877", "normaluser15@gmail.com", true, "15", true, "Nguyen Van", false, null, "normaluser15@gmail.com", "normalUser15", "AQAAAAIAAYagAAAAEK4/+ZVy265cqKP4Yr2BXvjfGLoopkIrSmhh4TcJduQpflqmcxrHJNN8o5IwneLl/w==", null, false, "", false, "normalUser15" },
                    { 16, 0, "HCM", "c3b428bf-6cd7-4168-81d9-dd3971b2f511", "normaluser16@gmail.com", true, "16", true, "Nguyen Van", false, null, "normaluser16@gmail.com", "normalUser16", "AQAAAAIAAYagAAAAEBHPRS4ZlQsEApkVW+mY13xYuKwA2Pt6NeW69uekCnYVJS55wk//BhV41ZtQJMFoRQ==", null, false, "", false, "normalUser16" },
                    { 17, 0, "HCM", "93b03840-4bcb-4ce0-a2e2-7d85049cb021", "normaluser17@gmail.com", true, "17", true, "Nguyen Van", false, null, "normaluser17@gmail.com", "normalUser17", "AQAAAAIAAYagAAAAEBI/p5SpkSGZ2zY427ooBiQcyA5UPWjDO9Ls58O1vHCsd8QdWXScmFltse+GtNqjGA==", null, false, "", false, "normalUser17" },
                    { 18, 0, "HCM", "74035d18-8c7d-4373-9964-bec1174e1b80", "normaluser18@gmail.com", true, "18", true, "Nguyen Van", false, null, "normaluser18@gmail.com", "normalUser18", "AQAAAAIAAYagAAAAEHVHrCxK3rXkke7hsZCkayjHXGEh//huGSfiUAfEHaqzOyV2E+CKZ6v5h5NelkUzUQ==", null, false, "", false, "normalUser18" },
                    { 19, 0, "HCM", "a5ac98a5-7112-4cef-a4e9-abce191f33a6", "normaluser19@gmail.com", true, "19", true, "Nguyen Van", false, null, "normaluser19@gmail.com", "normalUser19", "AQAAAAIAAYagAAAAEFGrrFfqrATRXYQwSvxJEZmFNDCJhwSZicgXFMqONsySdNPofrLIsNHO1lmGxC0Y8w==", null, false, "", false, "normalUser19" },
                    { 20, 0, "HCM", "37cdcf85-6dbf-4120-aea2-7136f708a996", "normaluser20@gmail.com", true, "20", true, "Nguyen Van", false, null, "normaluser20@gmail.com", "normalUser20", "AQAAAAIAAYagAAAAEDcwoGANtGkMPMhERcAGcau8d4frziWIKagPVh0qFZLUT9vooo5DER4CXXFj6UV9Eg==", null, false, "", false, "normalUser20" },
                    { 21, 0, "HCM", "7190ddef-671c-4607-beb8-819af94e6615", "normaluser21@gmail.com", true, "21", true, "Nguyen Van", false, null, "normaluser21@gmail.com", "normalUser21", "AQAAAAIAAYagAAAAECwe0UMZKsoNlPDCL3QS0WEqCwmFZfESviW8bmeMdVgP2bG8AMSl22IJXuWplgBnxQ==", null, false, "", false, "normalUser21" },
                    { 22, 0, "HCM", "2023897b-a862-470b-8fe7-2d474ae7e71a", "normaluser22@gmail.com", true, "22", true, "Nguyen Van", false, null, "normaluser22@gmail.com", "normalUser22", "AQAAAAIAAYagAAAAELQdNcO5KXQD+HTgiFAfKe0J6OOAvAk8i43cx6kMdFd5kN5VwWykVob2TnrGkmSZgg==", null, false, "", false, "normalUser22" },
                    { 23, 0, "HCM", "138a7ec9-6ba7-4172-bdf6-d076cf1aad80", "normaluser23@gmail.com", true, "23", true, "Nguyen Van", false, null, "normaluser23@gmail.com", "normalUser23", "AQAAAAIAAYagAAAAEFT4IIo7FW0PbpjNAZUzO2v6+6wOdfX3+YjMfkBD4nJWXauaZQW+l/fUUHpHoAl9Vg==", null, false, "", false, "normalUser23" },
                    { 24, 0, "HCM", "d3ae0066-2bdc-46b2-8de1-5c8d9d05bbbb", "normaluser24@gmail.com", true, "24", true, "Nguyen Van", false, null, "normaluser24@gmail.com", "normalUser24", "AQAAAAIAAYagAAAAEEJ707Jnrty/UzXYpC4dQJaKGs+cSZxmlr7S2wBg5h/yAJ8VZw6VLJ8Va05aKTjtwQ==", null, false, "", false, "normalUser24" },
                    { 25, 0, "HCM", "75ba670f-8a05-4fdc-91d5-957ef4b504a9", "normaluser25@gmail.com", true, "25", true, "Nguyen Van", false, null, "normaluser25@gmail.com", "normalUser25", "AQAAAAIAAYagAAAAEFy84T1wwRZWKk+N9pSgWg/uPC7eybm1VBQd1DeBV0pOLeJgb8Hlr4AdKOXvE/PGbA==", null, false, "", false, "normalUser25" },
                    { 26, 0, "HCM", "4c3b2eb2-3cd6-4157-8eb2-23d1750e5818", "normaluser26@gmail.com", true, "26", true, "Nguyen Van", false, null, "normaluser26@gmail.com", "normalUser26", "AQAAAAIAAYagAAAAEEUwWac6eLfMbVEPoP8wg9UpF10Qrl4CTTVdoW4NvAiIN8b6h8V6xIUljnjc4k3SPg==", null, false, "", false, "normalUser26" },
                    { 27, 0, "HCM", "8fc2d9ac-41ea-4f66-b916-3b11fc23c065", "normaluser27@gmail.com", true, "27", true, "Nguyen Van", false, null, "normaluser27@gmail.com", "normalUser27", "AQAAAAIAAYagAAAAEO64TEokCLAaXxuQ/Nl8YqeTJ7WBM7YmMledBET4aCmZbMSv17iHAS7wTKO2eWDwxg==", null, false, "", false, "normalUser27" },
                    { 28, 0, "HCM", "975bac70-3a65-44f4-bd87-bfbc36c44722", "normaluser28@gmail.com", true, "28", true, "Nguyen Van", false, null, "normaluser28@gmail.com", "normalUser28", "AQAAAAIAAYagAAAAEOVniZ0hnQXrfycwK6GJTqW44y6RAWx69v+Sx9iYY/s0MM3+pwTpUsYP+pDs5Q7HDg==", null, false, "", false, "normalUser28" },
                    { 29, 0, "HCM", "c8b701a1-a003-4e61-9bd2-0150b60f664c", "normaluser29@gmail.com", true, "29", true, "Nguyen Van", false, null, "normaluser29@gmail.com", "normalUser29", "AQAAAAIAAYagAAAAEBtuRKW1bmqnTSBN0MIJrNxbHjUhYl6RCXEJLm3YR6d8r4dM5UJllfaZzm0cGxs+hw==", null, false, "", false, "normalUser29" },
                    { 30, 0, "HCM", "071e5512-ee3f-4096-b439-e46be5300fb6", "normaluser30@gmail.com", true, "30", true, "Nguyen Van", false, null, "normaluser30@gmail.com", "normalUser30", "AQAAAAIAAYagAAAAEMQ6/P6DAGD6VlHRKdDOSV6+2Zdmclrxdc+lFgNpB3Lb7t0fncEIp9DFlrdhcnCfIg==", null, false, "", false, "normalUser30" },
                    { 31, 0, "HCM", "336c77ca-b9b0-4980-9255-4670a7f14d9c", "normaluser31@gmail.com", true, "31", true, "Nguyen Van", false, null, "normaluser31@gmail.com", "normalUser31", "AQAAAAIAAYagAAAAECFF7unJBupALEbc0wJ/lOlYuRrhr3er30/dOPjoQOrxa5dQmF+Ls+f0SIo1fE6+gA==", null, false, "", false, "normalUser31" },
                    { 32, 0, "HCM", "2692bc14-062b-4f0f-956d-548dce3823b5", "normaluser32@gmail.com", true, "32", true, "Nguyen Van", false, null, "normaluser32@gmail.com", "normalUser32", "AQAAAAIAAYagAAAAEHWrAwZE52FvMFsUi/crLh4Q7fODWkngeB3OFblchJJC1TuLlCpw1g/lWhXRaFw/+w==", null, false, "", false, "normalUser32" },
                    { 33, 0, "HCM", "167eb097-1a52-4058-a3b8-21d3d844a5ac", "normaluser33@gmail.com", true, "33", true, "Nguyen Van", false, null, "normaluser33@gmail.com", "normalUser33", "AQAAAAIAAYagAAAAEEiQ0QxjMEcTsy/sRulrY8G0y4n/kBMtlXhQg0EZlPBhKBQG8gi41ETtuDxIkjMT0w==", null, false, "", false, "normalUser33" },
                    { 34, 0, "HCM", "5b242cbc-ca19-42ab-8b2d-3a961d0529ff", "normaluser34@gmail.com", true, "34", true, "Nguyen Van", false, null, "normaluser34@gmail.com", "normalUser34", "AQAAAAIAAYagAAAAEJ4th2QTBrS1PEKFnHoQ213ci/wuetKbrmRV0aYXADTcnieVP4klTDc7C6mCXTFQcg==", null, false, "", false, "normalUser34" },
                    { 35, 0, "HCM", "78054faf-d251-43c7-8934-bfcb5a13c563", "normaluser35@gmail.com", true, "35", true, "Nguyen Van", false, null, "normaluser35@gmail.com", "normalUser35", "AQAAAAIAAYagAAAAEEoZRWnxNmLhSVX4vk/HLpbJxabTJy2Ng3CVlS4eojTxlVEgoCAQ4tYi/ok63ESTqg==", null, false, "", false, "normalUser35" },
                    { 36, 0, "HCM", "27ea6a36-e843-4d5a-b971-da3f35904d0c", "normaluser36@gmail.com", true, "36", true, "Nguyen Van", false, null, "normaluser36@gmail.com", "normalUser36", "AQAAAAIAAYagAAAAEDxTMj7ukHK8hZlG08zay6jYW50jAtgP3/Dnolg1LlPu8Rv+rj6i5Bm81wfPY66rNQ==", null, false, "", false, "normalUser36" },
                    { 37, 0, "HCM", "f2e2b5d4-2d62-4240-81ca-bb1b6751cb58", "normaluser37@gmail.com", true, "37", true, "Nguyen Van", false, null, "normaluser37@gmail.com", "normalUser37", "AQAAAAIAAYagAAAAEK8tyRSZUeo0cNcHRT+wWTsfjCkgg1bfy1zvf1hxyx+E+bl5qAtC0ZLaz3pcPeUlkQ==", null, false, "", false, "normalUser37" },
                    { 38, 0, "HCM", "5731ef03-c79b-4b82-b085-5a1716b56dac", "normaluser38@gmail.com", true, "38", true, "Nguyen Van", false, null, "normaluser38@gmail.com", "normalUser38", "AQAAAAIAAYagAAAAEGa2Hb15w81Dtta1K98MLBDQd5b1ilewOaqvSKirHUSbte4WDapHs3FU4pomvr1Xvw==", null, false, "", false, "normalUser38" },
                    { 39, 0, "HCM", "47912233-f145-4373-a53a-de9a8f963d31", "normaluser39@gmail.com", true, "39", true, "Nguyen Van", false, null, "normaluser39@gmail.com", "normalUser39", "AQAAAAIAAYagAAAAEEyC6LN4haLGpgAbIXLe6ZVrgwn8SdfgSKXpmYfqzZ6oWvqefe4j3w3haY4/TQvRWA==", null, false, "", false, "normalUser39" },
                    { 40, 0, "HCM", "c740c6a6-0942-4caf-b0db-12f9f6d06b00", "normaluser40@gmail.com", true, "40", true, "Nguyen Van", false, null, "normaluser40@gmail.com", "normalUser40", "AQAAAAIAAYagAAAAEI1MAJ1zkCPjGJZ4HDhT8rQPX0+pRuUk+Q+S2jVyGZFx50ZmIHOyrMNnRT5Ih6X8Cw==", null, false, "", false, "normalUser40" },
                    { 41, 0, "HCM", "654df322-958f-4685-b64f-317e57a58473", "normaluser41@gmail.com", true, "41", true, "Nguyen Van", false, null, "normaluser41@gmail.com", "normalUser41", "AQAAAAIAAYagAAAAEGjR5M/Fcaf1EafjgBbybOAuCJF67dZYOXJVq8nyVS5uExwSQ+TwViQdw517xBjiug==", null, false, "", false, "normalUser41" },
                    { 42, 0, "HCM", "7307e3f2-e193-484f-bd6d-e375ea6f9b30", "normaluser42@gmail.com", true, "42", true, "Nguyen Van", false, null, "normaluser42@gmail.com", "normalUser42", "AQAAAAIAAYagAAAAEDgfVfLg25N+MGsOGh5lnOfgI8+0B7W1dDJKlem6kkHSjpwwTmWssH1D3J+cNYVuoQ==", null, false, "", false, "normalUser42" },
                    { 43, 0, "HCM", "102a0cc4-19f7-465f-b57e-ebea02845e51", "normaluser43@gmail.com", true, "43", true, "Nguyen Van", false, null, "normaluser43@gmail.com", "normalUser43", "AQAAAAIAAYagAAAAEOaVTAjY36iRiIzxAJUvPQRXaaq6Kc0zIgVlltEaxMTfek+yVwsAhRhN3kbLAM3vEA==", null, false, "", false, "normalUser43" },
                    { 44, 0, "HCM", "796daa38-1798-4e9a-96d8-4d5a0b1e14c0", "normaluser44@gmail.com", true, "44", true, "Nguyen Van", false, null, "normaluser44@gmail.com", "normalUser44", "AQAAAAIAAYagAAAAEJ2p4bGB3ggOCUNKm3lVfo+jFI7XzTgIGqVSecgyHfyEF7zy8aImJnaxsN6dWnpT0w==", null, false, "", false, "normalUser44" },
                    { 45, 0, "HCM", "ac0e3585-bbd7-4660-af2d-938cd1bd6b37", "normaluser45@gmail.com", true, "45", true, "Nguyen Van", false, null, "normaluser45@gmail.com", "normalUser45", "AQAAAAIAAYagAAAAEOI5VYxet0xAvGU7TMmWoEBdYfB+YjTSNmmyrjx3gPQYuFgx4MYxyrKMbOx5VhyTBw==", null, false, "", false, "normalUser45" },
                    { 46, 0, "HCM", "68532aca-8711-415a-bfcd-82f7fad09b25", "normaluser46@gmail.com", true, "46", true, "Nguyen Van", false, null, "normaluser46@gmail.com", "normalUser46", "AQAAAAIAAYagAAAAEMurfCpM0swOQj/sxAT+WYxztLcC3LPFiNVkWxBcUq8tIUBlQXxpy12zLgEO1kkptw==", null, false, "", false, "normalUser46" },
                    { 47, 0, "HCM", "ef9602e2-8976-4412-a361-8ca0862293fd", "normaluser47@gmail.com", true, "47", true, "Nguyen Van", false, null, "normaluser47@gmail.com", "normalUser47", "AQAAAAIAAYagAAAAEAtyWRechIX2aupBWFLaWO172QwblNbDs5qrC1a9sc+VxI0kV4WiQFO7re/qvtnjvQ==", null, false, "", false, "normalUser47" },
                    { 48, 0, "HCM", "52873cb1-470f-4bde-80a6-69602aaae5e3", "normaluser48@gmail.com", true, "48", true, "Nguyen Van", false, null, "normaluser48@gmail.com", "normalUser48", "AQAAAAIAAYagAAAAEILEPksvCGyscCA3k37qArREpNOxzJ8nKGLyhBXrz8Gu0Yq9YxEaql8ySNmUmCjXgQ==", null, false, "", false, "normalUser48" },
                    { 49, 0, "HCM", "7095b2ab-1ed5-4b15-adcd-44c7b47cc268", "normaluser49@gmail.com", true, "49", true, "Nguyen Van", false, null, "normaluser49@gmail.com", "normalUser49", "AQAAAAIAAYagAAAAEMgRcP8l+lzCkOHUsuusbIOtFVOpWkatRXSPpctX9yE37LDfRUimUIn29EeyzHoo+A==", null, false, "", false, "normalUser49" },
                    { 50, 0, "HCM", "fcc24475-a857-49f7-8582-f6cd46cd7acd", "normaluser50@gmail.com", true, "50", true, "Nguyen Van", false, null, "normaluser50@gmail.com", "normalUser50", "AQAAAAIAAYagAAAAEJIyxkreTzfhQ8l+hjzCHuUee0GvDEKvIMN8IPbYtMiNkiIvrq8kY1pLcw/fXreqsQ==", null, false, "", false, "normalUser50" },
                    { 51, 0, "HCM", "7973b139-7aba-459e-b92b-6a3f570fe4b4", "normaluser51@gmail.com", true, "51", true, "Nguyen Van", false, null, "normaluser51@gmail.com", "normalUser51", "AQAAAAIAAYagAAAAEEu11u41iZgqyM5o18ov5u/4JF8JGP388eewjBpejvg0SuyHSx3GM+bRuHi4yxFB5w==", null, false, "", false, "normalUser51" },
                    { 52, 0, "HCM", "ad2bb87c-a5cd-45e1-9315-3b7a4270dfa8", "normaluser52@gmail.com", true, "52", true, "Nguyen Van", false, null, "normaluser52@gmail.com", "normalUser52", "AQAAAAIAAYagAAAAEB5BO0vje2sHBvVxwTsFzytnzBTqrOFNEgmcq2yISzA7p42h6WcZ8KqhDAQNiCI2cg==", null, false, "", false, "normalUser52" },
                    { 53, 0, "HCM", "d26ae461-a502-4a00-becc-c15e01c90f16", "normaluser53@gmail.com", true, "53", true, "Nguyen Van", false, null, "normaluser53@gmail.com", "normalUser53", "AQAAAAIAAYagAAAAEGq3W/ZIDvn+a61iTrD4H50Wy6V2W4mO/D4Tw5RXITXO/bkCdVmXB99hwdMh7JwnPQ==", null, false, "", false, "normalUser53" },
                    { 54, 0, "HCM", "2fc11890-25d5-4809-a8bb-cfc01afb6f7b", "normaluser54@gmail.com", true, "54", true, "Nguyen Van", false, null, "normaluser54@gmail.com", "normalUser54", "AQAAAAIAAYagAAAAEIM114CCLZJvRYrQYaXpmPNiKUnYB0vqY7hY0uI4+wbrAVplIQY6wB2mwPFn11XVMQ==", null, false, "", false, "normalUser54" },
                    { 55, 0, "HCM", "32efa441-4ef4-41b9-8b2a-947e5741975e", "normaluser55@gmail.com", true, "55", true, "Nguyen Van", false, null, "normaluser55@gmail.com", "normalUser55", "AQAAAAIAAYagAAAAEIGhQ50lT+W+dGR8KWojFGR0BPMICto13akZVxUTiiwpIXlJHvI10v/RRpRuZxmMjA==", null, false, "", false, "normalUser55" },
                    { 56, 0, "HCM", "49cfe366-f518-43fe-a36b-a36705c72d31", "normaluser56@gmail.com", true, "56", true, "Nguyen Van", false, null, "normaluser56@gmail.com", "normalUser56", "AQAAAAIAAYagAAAAEOCVVmES7w8wg3G6Q7O1kiTS/g8LDNRvyqkmDSYC3b/QiREfTCJuaDwsRUhLqlM79Q==", null, false, "", false, "normalUser56" },
                    { 57, 0, "HCM", "2eb7becc-38dc-4f23-9749-f56c06822200", "normaluser57@gmail.com", true, "57", true, "Nguyen Van", false, null, "normaluser57@gmail.com", "normalUser57", "AQAAAAIAAYagAAAAELUDeXx1LU0IA4L8vs+36xzL6jmGzOvv7pgaPOjCS16n5oVwvNl0wGszHG8ovHKeJQ==", null, false, "", false, "normalUser57" },
                    { 58, 0, "HCM", "fd453b5d-a918-4e5f-a76e-f7dbede23f29", "normaluser58@gmail.com", true, "58", true, "Nguyen Van", false, null, "normaluser58@gmail.com", "normalUser58", "AQAAAAIAAYagAAAAEE99VO8+MGcmkaNQtDptU4MIytiC8rS/zDA12T+vy0gpHulxzbNGypk7UaAk8xGzkQ==", null, false, "", false, "normalUser58" },
                    { 59, 0, "HCM", "4338436d-1043-4905-a97e-9f6091185ce7", "normaluser59@gmail.com", true, "59", true, "Nguyen Van", false, null, "normaluser59@gmail.com", "normalUser59", "AQAAAAIAAYagAAAAEL/yr7Ol0eCfYh/1Rlt3SP5bSIaPhI87+wIOdBgUMX5ixTYmxgKMfzz6D0yAyX3NmA==", null, false, "", false, "normalUser59" },
                    { 60, 0, "HCM", "a33f1f0d-b373-49d0-be7e-de839409eab6", "normaluser60@gmail.com", true, "60", true, "Nguyen Van", false, null, "normaluser60@gmail.com", "normalUser60", "AQAAAAIAAYagAAAAEJmg5/GBiQKr3TfEpaAcAOqFRI0yQb/RcZa6Djg8zp0rSKfaATNeLu7pNSCerh2nxQ==", null, false, "", false, "normalUser60" }
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
                    { 7, 31 },
                    { 5, 32 },
                    { 8, 33 },
                    { 3, 34 },
                    { 5, 35 },
                    { 7, 36 },
                    { 5, 37 },
                    { 5, 38 },
                    { 6, 39 },
                    { 3, 40 },
                    { 5, 41 },
                    { 2, 42 },
                    { 5, 43 },
                    { 1, 44 },
                    { 4, 45 },
                    { 4, 46 },
                    { 4, 47 },
                    { 7, 48 },
                    { 3, 49 },
                    { 5, 50 },
                    { 5, 51 },
                    { 8, 52 },
                    { 2, 53 },
                    { 5, 54 },
                    { 5, 55 },
                    { 7, 56 },
                    { 3, 57 },
                    { 5, 58 },
                    { 8, 59 },
                    { 1, 60 }
                });

            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "Id", "ApplyExpireDate", "BusinessProfileId", "CreatedDate", "Description", "IsActive", "Name", "Offer" },
                values: new object[,]
                {
                    { 1, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(6949), "This a simple description for project 1 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 1", 99.0 },
                    { 2, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 2, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7062), "This a simple description for project 2 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 2", 198.0 },
                    { 3, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7070), "This a simple description for project 3 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 3", 297.0 },
                    { 4, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7077), "This a simple description for project 4 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 4", 396.0 },
                    { 5, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7085), "This a simple description for project 5 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 5", 495.0 },
                    { 6, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7094), "This a simple description for project 6 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 6", 594.0 },
                    { 7, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 2, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7102), "This a simple description for project 7 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 7", 693.0 },
                    { 8, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 1, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7144), "This a simple description for project 8 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 8", 792.0 },
                    { 9, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7152), "This a simple description for project 9 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 9", 891.0 },
                    { 10, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7162), "This a simple description for project 10 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 10", 990.0 },
                    { 11, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 5, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7169), "This a simple description for project 11 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 11", 1089.0 },
                    { 12, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7177), "This a simple description for project 12 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 12", 1188.0 },
                    { 13, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7218), "This a simple description for project 13 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 13", 1287.0 },
                    { 14, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7226), "This a simple description for project 14 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 14", 1386.0 },
                    { 15, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7234), "This a simple description for project 15 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 15", 1485.0 },
                    { 16, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7242), "This a simple description for project 16 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 16", 1584.0 },
                    { 17, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7249), "This a simple description for project 17 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 17", 1683.0 },
                    { 18, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7258), "This a simple description for project 18 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 18", 1782.0 },
                    { 19, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7297), "This a simple description for project 19 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 19", 1881.0 },
                    { 20, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 1, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7305), "This a simple description for project 20 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 20", 1980.0 },
                    { 21, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7312), "This a simple description for project 21 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 21", 2079.0 },
                    { 22, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7320), "This a simple description for project 22 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 22", 2178.0 },
                    { 23, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7327), "This a simple description for project 23 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 23", 2277.0 },
                    { 24, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 1, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7335), "This a simple description for project 24 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 24", 2376.0 },
                    { 25, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7373), "This a simple description for project 25 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 25", 2475.0 },
                    { 26, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7381), "This a simple description for project 26 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 26", 2574.0 },
                    { 27, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7388), "This a simple description for project 27 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 27", 2673.0 },
                    { 28, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 1, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7396), "This a simple description for project 28 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 28", 2772.0 },
                    { 29, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7403), "This a simple description for project 29 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 29", 2871.0 },
                    { 30, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(7959), "This a simple description for project 30 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 30", 2970.0 },
                    { 31, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8061), "This a simple description for project 31 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 31", 3069.0 },
                    { 32, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8069), "This a simple description for project 32 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 32", 3168.0 },
                    { 33, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8076), "This a simple description for project 33 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 33", 3267.0 },
                    { 34, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 5, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8086), "This a simple description for project 34 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 34", 3366.0 },
                    { 35, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8094), "This a simple description for project 35 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 35", 3465.0 },
                    { 36, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8138), "This a simple description for project 36 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 36", 3564.0 },
                    { 37, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8149), "This a simple description for project 37 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 37", 3663.0 },
                    { 38, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8156), "This a simple description for project 38 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 38", 3762.0 },
                    { 39, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8163), "This a simple description for project 39 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 39", 3861.0 },
                    { 40, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8170), "This a simple description for project 40 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 40", 3960.0 },
                    { 41, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8219), "This a simple description for project 41 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 41", 4059.0 },
                    { 42, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 4, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8228), "This a simple description for project 42 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 42", 4158.0 },
                    { 43, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8235), "This a simple description for project 43 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 43", 4257.0 },
                    { 44, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8242), "This a simple description for project 44 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 44", 4356.0 },
                    { 45, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8250), "This a simple description for project 45 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 45", 4455.0 },
                    { 46, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 30, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8257), "This a simple description for project 46 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 46", 4554.0 },
                    { 47, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8298), "This a simple description for project 47 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 47", 4653.0 },
                    { 48, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8307), "This a simple description for project 48 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 48", 4752.0 },
                    { 49, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8314), "This a simple description for project 49 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 49", 4851.0 },
                    { 50, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8321), "This a simple description for project 50 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 50", 4950.0 },
                    { 51, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 2, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8328), "This a simple description for project 51 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 51", 5049.0 },
                    { 52, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8335), "This a simple description for project 52 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 52", 5148.0 },
                    { 53, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8375), "This a simple description for project 53 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 53", 5247.0 },
                    { 54, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8383), "This a simple description for project 54 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 54", 5346.0 },
                    { 55, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8390), "This a simple description for project 55 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 55", 5445.0 },
                    { 56, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8398), "This a simple description for project 56 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 56", 5544.0 },
                    { 57, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8405), "This a simple description for project 57 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 57", 5643.0 },
                    { 58, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8412), "This a simple description for project 58 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 58", 5742.0 },
                    { 59, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8450), "This a simple description for project 59 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 59", 5841.0 },
                    { 60, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 1, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8458), "This a simple description for project 60 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 60", 5940.0 },
                    { 61, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8465), "This a simple description for project 61 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 61", 6039.0 },
                    { 62, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8472), "This a simple description for project 62 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 62", 6138.0 },
                    { 63, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8480), "This a simple description for project 63 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 63", 6237.0 },
                    { 64, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8487), "This a simple description for project 64 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 64", 6336.0 },
                    { 65, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8526), "This a simple description for project 65 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 65", 6435.0 },
                    { 66, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8536), "This a simple description for project 66 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 66", 6534.0 },
                    { 67, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 3, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8544), "This a simple description for project 67 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 67", 6633.0 },
                    { 68, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8551), "This a simple description for project 68 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 68", 6732.0 },
                    { 69, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8588), "This a simple description for project 69 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 69", 6831.0 },
                    { 70, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8597), "This a simple description for project 70 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 70", 6930.0 },
                    { 71, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8605), "This a simple description for project 71 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 71", 7029.0 },
                    { 72, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 4, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8612), "This a simple description for project 72 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 72", 7128.0 },
                    { 73, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8620), "This a simple description for project 73 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 73", 7227.0 },
                    { 74, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8627), "This a simple description for project 74 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 74", 7326.0 },
                    { 75, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8678), "This a simple description for project 75 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 75", 7425.0 },
                    { 76, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8687), "This a simple description for project 76 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 76", 7524.0 },
                    { 77, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8695), "This a simple description for project 77 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 77", 7623.0 },
                    { 78, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 3, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8702), "This a simple description for project 78 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 78", 7722.0 },
                    { 79, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8709), "This a simple description for project 79 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 79", 7821.0 },
                    { 80, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8717), "This a simple description for project 80 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 80", 7920.0 },
                    { 81, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 2, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8760), "This a simple description for project 81 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 81", 8019.0 },
                    { 82, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8769), "This a simple description for project 82 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 82", 8118.0 },
                    { 83, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8777), "This a simple description for project 83 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 83", 8217.0 },
                    { 84, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8784), "This a simple description for project 84 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 84", 8316.0 },
                    { 85, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8792), "This a simple description for project 85 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 85", 8415.0 },
                    { 86, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8799), "This a simple description for project 86 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 86", 8514.0 },
                    { 87, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8840), "This a simple description for project 87 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 87", 8613.0 },
                    { 88, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8849), "This a simple description for project 88 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 88", 8712.0 },
                    { 89, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8856), "This a simple description for project 89 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 89", 8811.0 },
                    { 90, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 3, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8864), "This a simple description for project 90 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 90", 8910.0 },
                    { 91, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8871), "This a simple description for project 91 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 91", 9009.0 },
                    { 92, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8879), "This a simple description for project 92 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 92", 9108.0 },
                    { 93, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8918), "This a simple description for project 93 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 93", 9207.0 },
                    { 94, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8926), "This a simple description for project 94 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 94", 9306.0 },
                    { 95, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8934), "This a simple description for project 95 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 95", 9405.0 },
                    { 96, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8942), "This a simple description for project 96 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 96", 9504.0 },
                    { 97, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8949), "This a simple description for project 97 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 97", 9603.0 },
                    { 98, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8956), "This a simple description for project 98 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 98", 9702.0 },
                    { 99, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(8997), "This a simple description for project 99 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 99", 9801.0 },
                    { 100, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9005), "This a simple description for project 100 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 100", 9900.0 }
                });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "Id", "CreateDate", "FreelancerProfileId", "IsAccepted", "JobId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9030), 35, true, 1 },
                    { 2, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9039), 38, false, 1 },
                    { 3, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9044), 50, true, 1 },
                    { 4, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9049), 58, false, 1 },
                    { 5, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9053), 36, true, 2 },
                    { 6, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9058), 44, false, 2 },
                    { 7, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9062), 49, true, 2 },
                    { 8, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9065), 59, false, 2 },
                    { 9, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9069), 36, true, 3 },
                    { 10, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9073), 45, false, 3 },
                    { 11, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9077), 50, true, 3 },
                    { 12, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9081), 55, false, 3 },
                    { 13, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9085), 34, true, 4 },
                    { 14, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9089), 39, false, 4 },
                    { 15, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9092), 49, true, 4 },
                    { 16, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9096), 55, false, 4 },
                    { 17, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9100), 35, true, 5 },
                    { 18, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9139), 45, false, 5 },
                    { 19, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9143), 51, true, 5 },
                    { 20, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9147), 57, false, 5 },
                    { 21, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9151), 34, true, 6 },
                    { 22, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9155), 38, false, 6 },
                    { 23, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9158), 49, true, 6 },
                    { 24, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9163), 58, false, 6 },
                    { 25, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9169), 35, true, 7 },
                    { 26, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9174), 38, false, 7 },
                    { 27, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9180), 53, true, 7 },
                    { 28, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9185), 59, false, 7 },
                    { 29, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9190), 36, true, 8 },
                    { 30, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9195), 41, false, 8 },
                    { 31, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9200), 52, true, 8 },
                    { 32, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9205), 56, false, 8 },
                    { 33, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9211), 35, true, 9 },
                    { 34, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9218), 39, false, 9 },
                    { 35, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9223), 51, true, 9 },
                    { 36, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9229), 54, false, 9 },
                    { 37, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9234), 37, true, 10 },
                    { 38, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9239), 38, false, 10 },
                    { 39, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9244), 46, true, 10 },
                    { 40, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9275), 59, false, 10 },
                    { 41, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9288), 34, true, 11 },
                    { 42, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9295), 41, false, 11 },
                    { 43, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9302), 48, true, 11 },
                    { 44, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9308), 54, false, 11 },
                    { 45, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9373), 33, true, 12 },
                    { 46, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9379), 41, false, 12 },
                    { 47, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9385), 48, true, 12 },
                    { 48, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9390), 57, false, 12 },
                    { 49, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9396), 32, true, 13 },
                    { 50, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9401), 40, false, 13 },
                    { 51, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9407), 52, true, 13 },
                    { 52, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9412), 58, false, 13 },
                    { 53, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9417), 32, true, 14 },
                    { 54, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9423), 45, false, 14 },
                    { 55, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9438), 47, true, 14 },
                    { 56, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9472), 59, false, 14 },
                    { 57, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9490), 37, true, 15 },
                    { 58, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9498), 43, false, 15 },
                    { 59, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9504), 49, true, 15 },
                    { 60, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9511), 57, false, 15 },
                    { 61, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9516), 36, true, 16 },
                    { 62, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9521), 42, false, 16 },
                    { 63, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9526), 50, true, 16 },
                    { 64, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9532), 59, false, 16 },
                    { 65, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9536), 34, true, 17 },
                    { 66, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9541), 42, false, 17 },
                    { 67, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9544), 53, true, 17 },
                    { 68, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9548), 57, false, 17 },
                    { 69, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9551), 36, true, 18 },
                    { 70, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9597), 39, false, 18 },
                    { 71, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9601), 52, true, 18 },
                    { 72, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9604), 54, false, 18 },
                    { 73, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9608), 33, true, 19 },
                    { 74, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9611), 44, false, 19 },
                    { 75, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9614), 50, true, 19 },
                    { 76, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9618), 57, false, 19 },
                    { 77, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9621), 35, true, 20 },
                    { 78, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9624), 42, false, 20 },
                    { 79, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9627), 53, true, 20 },
                    { 80, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9630), 56, false, 20 },
                    { 81, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9634), 33, true, 21 },
                    { 82, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9637), 43, false, 21 },
                    { 83, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9640), 50, true, 21 },
                    { 84, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9643), 56, false, 21 },
                    { 85, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9647), 36, true, 22 },
                    { 86, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9650), 42, false, 22 },
                    { 87, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9653), 53, true, 22 },
                    { 88, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9656), 56, false, 22 },
                    { 89, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9659), 31, true, 23 },
                    { 90, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9663), 39, false, 23 },
                    { 91, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9666), 47, true, 23 },
                    { 92, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9669), 57, false, 23 },
                    { 93, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9672), 33, true, 24 },
                    { 94, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9675), 38, false, 24 },
                    { 95, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9679), 53, true, 24 },
                    { 96, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9682), 58, false, 24 },
                    { 97, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9685), 32, true, 25 },
                    { 98, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9689), 44, false, 25 },
                    { 99, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9741), 51, true, 25 },
                    { 100, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9745), 55, false, 25 },
                    { 101, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9748), 36, true, 26 },
                    { 102, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9752), 39, false, 26 },
                    { 103, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9755), 49, true, 26 },
                    { 104, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9758), 58, false, 26 },
                    { 105, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9761), 32, true, 27 },
                    { 106, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9765), 38, false, 27 },
                    { 107, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9768), 53, true, 27 },
                    { 108, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9771), 55, false, 27 },
                    { 109, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9774), 33, true, 28 },
                    { 110, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9777), 40, false, 28 },
                    { 111, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9781), 50, true, 28 },
                    { 112, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9784), 54, false, 28 },
                    { 113, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9787), 34, true, 29 },
                    { 114, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9790), 39, false, 29 },
                    { 115, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9793), 53, true, 29 },
                    { 116, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9797), 58, false, 29 },
                    { 117, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9800), 33, true, 30 },
                    { 118, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9803), 43, false, 30 },
                    { 119, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9806), 48, true, 30 },
                    { 120, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9810), 56, false, 30 },
                    { 121, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9814), 36, true, 31 },
                    { 122, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9817), 40, false, 31 },
                    { 123, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9820), 49, true, 31 },
                    { 124, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9823), 55, false, 31 },
                    { 125, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9827), 37, true, 32 },
                    { 126, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9830), 38, false, 32 },
                    { 127, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9833), 49, true, 32 },
                    { 128, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9869), 58, false, 32 },
                    { 129, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9873), 34, true, 33 },
                    { 130, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9877), 41, false, 33 },
                    { 131, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9881), 48, true, 33 },
                    { 132, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9884), 55, false, 33 },
                    { 133, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9887), 33, true, 34 },
                    { 134, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9890), 41, false, 34 },
                    { 135, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9894), 51, true, 34 },
                    { 136, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9897), 57, false, 34 },
                    { 137, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9900), 34, true, 35 },
                    { 138, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9904), 45, false, 35 },
                    { 139, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9907), 52, true, 35 },
                    { 140, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9910), 57, false, 35 },
                    { 141, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9913), 34, true, 36 },
                    { 142, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9916), 41, false, 36 },
                    { 143, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9920), 52, true, 36 },
                    { 144, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9923), 55, false, 36 },
                    { 145, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9926), 34, true, 37 },
                    { 146, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9930), 41, false, 37 },
                    { 147, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9933), 52, true, 37 },
                    { 148, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9936), 54, false, 37 },
                    { 149, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9939), 35, true, 38 },
                    { 150, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9984), 39, false, 38 },
                    { 151, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9987), 46, true, 38 },
                    { 152, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9991), 59, false, 38 },
                    { 153, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9994), 35, true, 39 },
                    { 154, new DateTime(2023, 6, 17, 15, 31, 44, 967, DateTimeKind.Local).AddTicks(9998), 42, false, 39 },
                    { 155, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(1), 46, true, 39 },
                    { 156, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(4), 56, false, 39 },
                    { 157, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(7), 32, true, 40 },
                    { 158, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(11), 42, false, 40 },
                    { 159, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(14), 52, true, 40 },
                    { 160, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(17), 55, false, 40 },
                    { 161, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(20), 34, true, 41 },
                    { 162, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(23), 44, false, 41 },
                    { 163, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(27), 52, true, 41 },
                    { 164, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(30), 59, false, 41 },
                    { 165, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(33), 34, true, 42 },
                    { 166, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(36), 38, false, 42 },
                    { 167, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(40), 50, true, 42 },
                    { 168, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(43), 57, false, 42 },
                    { 169, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(46), 35, true, 43 },
                    { 170, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(49), 39, false, 43 },
                    { 171, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(53), 50, true, 43 },
                    { 172, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(56), 55, false, 43 },
                    { 173, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(59), 33, true, 44 },
                    { 174, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(62), 38, false, 44 },
                    { 175, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(66), 50, true, 44 },
                    { 176, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(69), 57, false, 44 },
                    { 177, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(72), 36, true, 45 },
                    { 178, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(75), 40, false, 45 },
                    { 179, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(115), 51, true, 45 },
                    { 180, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(118), 54, false, 45 },
                    { 181, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(122), 37, true, 46 },
                    { 182, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(125), 40, false, 46 },
                    { 183, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(129), 53, true, 46 },
                    { 184, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(132), 54, false, 46 },
                    { 185, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(135), 34, true, 47 },
                    { 186, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(138), 44, false, 47 },
                    { 187, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(141), 53, true, 47 },
                    { 188, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(145), 56, false, 47 },
                    { 189, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(148), 37, true, 48 },
                    { 190, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(151), 43, false, 48 },
                    { 191, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(154), 47, true, 48 },
                    { 192, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(158), 57, false, 48 },
                    { 193, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(161), 32, true, 49 },
                    { 194, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(164), 45, false, 49 },
                    { 195, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(167), 48, true, 49 },
                    { 196, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(170), 56, false, 49 },
                    { 197, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(174), 31, true, 50 },
                    { 198, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(177), 42, false, 50 },
                    { 199, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(180), 46, true, 50 },
                    { 200, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(184), 56, false, 50 },
                    { 201, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(187), 32, true, 51 },
                    { 202, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(190), 42, false, 51 },
                    { 203, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(193), 49, true, 51 },
                    { 204, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(196), 55, false, 51 },
                    { 205, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(200), 37, true, 52 },
                    { 206, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(203), 45, false, 52 },
                    { 207, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(206), 50, true, 52 },
                    { 208, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(242), 54, false, 52 },
                    { 209, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(246), 37, true, 53 },
                    { 210, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(249), 45, false, 53 },
                    { 211, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(252), 49, true, 53 },
                    { 212, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(255), 54, false, 53 },
                    { 213, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(259), 31, true, 54 },
                    { 214, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(262), 44, false, 54 },
                    { 215, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(265), 51, true, 54 },
                    { 216, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(268), 58, false, 54 },
                    { 217, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(271), 37, true, 55 },
                    { 218, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(275), 38, false, 55 },
                    { 219, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(278), 46, true, 55 },
                    { 220, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(281), 58, false, 55 },
                    { 221, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(285), 37, true, 56 },
                    { 222, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(288), 42, false, 56 },
                    { 223, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(291), 49, true, 56 },
                    { 224, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(294), 54, false, 56 },
                    { 225, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(299), 34, true, 57 },
                    { 226, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(302), 39, false, 57 },
                    { 227, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(305), 50, true, 57 },
                    { 228, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(308), 54, false, 57 },
                    { 229, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(312), 33, true, 58 },
                    { 230, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(315), 45, false, 58 },
                    { 231, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(318), 46, true, 58 },
                    { 232, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(321), 54, false, 58 },
                    { 233, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(324), 36, true, 59 },
                    { 234, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(328), 43, false, 59 },
                    { 235, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(331), 49, true, 59 },
                    { 236, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(334), 58, false, 59 },
                    { 237, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(338), 34, true, 60 },
                    { 238, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(374), 45, false, 60 },
                    { 239, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(378), 46, true, 60 },
                    { 240, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(381), 57, false, 60 },
                    { 241, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(384), 35, true, 61 },
                    { 242, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(388), 40, false, 61 },
                    { 243, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(391), 51, true, 61 },
                    { 244, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(394), 55, false, 61 },
                    { 245, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(397), 33, true, 62 },
                    { 246, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(401), 40, false, 62 },
                    { 247, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(404), 49, true, 62 },
                    { 248, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(407), 54, false, 62 },
                    { 249, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(410), 31, true, 63 },
                    { 250, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(413), 42, false, 63 },
                    { 251, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(417), 47, true, 63 },
                    { 252, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(420), 58, false, 63 },
                    { 253, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(423), 31, true, 64 },
                    { 254, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(427), 41, false, 64 },
                    { 255, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(430), 46, true, 64 },
                    { 256, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(433), 56, false, 64 },
                    { 257, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(436), 36, true, 65 },
                    { 258, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(472), 44, false, 65 },
                    { 259, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(475), 53, true, 65 },
                    { 260, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(479), 57, false, 65 },
                    { 261, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(482), 35, true, 66 },
                    { 262, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(485), 45, false, 66 },
                    { 263, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(489), 50, true, 66 },
                    { 264, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(492), 56, false, 66 },
                    { 265, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(495), 34, true, 67 },
                    { 266, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(498), 40, false, 67 },
                    { 267, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(502), 49, true, 67 },
                    { 268, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(505), 54, false, 67 },
                    { 269, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(508), 32, true, 68 },
                    { 270, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(511), 42, false, 68 },
                    { 271, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(514), 50, true, 68 },
                    { 272, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(517), 55, false, 68 },
                    { 273, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(521), 35, true, 69 },
                    { 274, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(524), 38, false, 69 },
                    { 275, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(527), 51, true, 69 },
                    { 276, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(530), 58, false, 69 },
                    { 277, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(534), 34, true, 70 },
                    { 278, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(537), 38, false, 70 },
                    { 279, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(541), 53, true, 70 },
                    { 280, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(544), 58, false, 70 },
                    { 281, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(578), 33, true, 71 },
                    { 282, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(582), 43, false, 71 },
                    { 283, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(585), 47, true, 71 },
                    { 284, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(589), 59, false, 71 },
                    { 285, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(592), 32, true, 72 },
                    { 286, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(595), 42, false, 72 },
                    { 287, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(598), 53, true, 72 },
                    { 288, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(602), 58, false, 72 },
                    { 289, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(605), 37, true, 73 },
                    { 290, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(608), 42, false, 73 },
                    { 291, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(611), 53, true, 73 },
                    { 292, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(615), 55, false, 73 },
                    { 293, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(618), 31, true, 74 },
                    { 294, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(621), 39, false, 74 },
                    { 295, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(624), 48, true, 74 },
                    { 296, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(627), 54, false, 74 },
                    { 297, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(631), 33, true, 75 },
                    { 298, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(634), 44, false, 75 },
                    { 299, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(637), 48, true, 75 },
                    { 300, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(641), 56, false, 75 },
                    { 301, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(644), 34, true, 76 },
                    { 302, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(647), 44, false, 76 },
                    { 303, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(650), 50, true, 76 },
                    { 304, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(654), 57, false, 76 },
                    { 305, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(657), 31, true, 77 },
                    { 306, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(660), 45, false, 77 },
                    { 307, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(664), 49, true, 77 },
                    { 308, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(667), 54, false, 77 },
                    { 309, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(670), 32, true, 78 },
                    { 310, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(715), 42, false, 78 },
                    { 311, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(719), 46, true, 78 },
                    { 312, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(723), 55, false, 78 },
                    { 313, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(726), 34, true, 79 },
                    { 314, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(729), 39, false, 79 },
                    { 315, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(732), 51, true, 79 },
                    { 316, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(736), 59, false, 79 },
                    { 317, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(739), 31, true, 80 },
                    { 318, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(742), 45, false, 80 },
                    { 319, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(745), 50, true, 80 },
                    { 320, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(748), 59, false, 80 },
                    { 321, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(752), 33, true, 81 },
                    { 322, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(755), 41, false, 81 },
                    { 323, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(758), 51, true, 81 },
                    { 324, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(762), 54, false, 81 },
                    { 325, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(765), 33, true, 82 },
                    { 326, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(768), 40, false, 82 },
                    { 327, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(771), 48, true, 82 },
                    { 328, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(775), 58, false, 82 },
                    { 329, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(778), 37, true, 83 },
                    { 330, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(781), 40, false, 83 },
                    { 331, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(785), 47, true, 83 },
                    { 332, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(788), 57, false, 83 },
                    { 333, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(791), 36, true, 84 },
                    { 334, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(794), 39, false, 84 },
                    { 335, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(798), 46, true, 84 },
                    { 336, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(801), 56, false, 84 },
                    { 337, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(804), 35, true, 85 },
                    { 338, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(807), 38, false, 85 },
                    { 339, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(811), 50, true, 85 },
                    { 340, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(849), 54, false, 85 },
                    { 341, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(852), 32, true, 86 },
                    { 342, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(856), 39, false, 86 },
                    { 343, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(859), 49, true, 86 },
                    { 344, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(862), 59, false, 86 },
                    { 345, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(865), 32, true, 87 },
                    { 346, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(868), 43, false, 87 },
                    { 347, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(872), 48, true, 87 },
                    { 348, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(875), 59, false, 87 },
                    { 349, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(878), 31, true, 88 },
                    { 350, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(881), 40, false, 88 },
                    { 351, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(884), 47, true, 88 },
                    { 352, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(888), 59, false, 88 },
                    { 353, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(891), 33, true, 89 },
                    { 354, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(894), 40, false, 89 },
                    { 355, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(897), 50, true, 89 },
                    { 356, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(900), 56, false, 89 },
                    { 357, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(904), 33, true, 90 },
                    { 358, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(907), 43, false, 90 },
                    { 359, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(910), 48, true, 90 },
                    { 360, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(913), 55, false, 90 },
                    { 361, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(917), 35, true, 91 },
                    { 362, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(920), 40, false, 91 },
                    { 363, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(923), 50, true, 91 },
                    { 364, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(926), 55, false, 91 },
                    { 365, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(930), 32, true, 92 },
                    { 366, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(933), 42, false, 92 },
                    { 367, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(936), 49, true, 92 },
                    { 368, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(939), 59, false, 92 },
                    { 369, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(976), 34, true, 93 },
                    { 370, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(979), 39, false, 93 },
                    { 371, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(982), 47, true, 93 },
                    { 372, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(985), 58, false, 93 },
                    { 373, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(989), 33, true, 94 },
                    { 374, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(992), 38, false, 94 },
                    { 375, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(995), 52, true, 94 },
                    { 376, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(998), 58, false, 94 },
                    { 377, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(1002), 36, true, 95 },
                    { 378, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(1005), 44, false, 95 },
                    { 379, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(1009), 52, true, 95 },
                    { 380, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(1012), 57, false, 95 },
                    { 381, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(1015), 32, true, 96 },
                    { 382, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(1018), 42, false, 96 },
                    { 383, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(1021), 49, true, 96 },
                    { 384, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(1024), 54, false, 96 },
                    { 385, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(1028), 34, true, 97 },
                    { 386, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(1031), 45, false, 97 },
                    { 387, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(1034), 49, true, 97 },
                    { 388, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(1037), 54, false, 97 },
                    { 389, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(1040), 32, true, 98 },
                    { 390, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(1044), 44, false, 98 },
                    { 391, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(1047), 53, true, 98 },
                    { 392, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(1050), 58, false, 98 },
                    { 393, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(1053), 35, true, 99 },
                    { 394, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(1056), 41, false, 99 },
                    { 395, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(1060), 52, true, 99 },
                    { 396, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(1063), 56, false, 99 },
                    { 397, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(1066), 31, true, 100 },
                    { 398, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(1104), 39, false, 100 },
                    { 399, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(1107), 53, true, 100 },
                    { 400, new DateTime(2023, 6, 17, 15, 31, 44, 968, DateTimeKind.Local).AddTicks(1110), 59, false, 100 }
                });

            migrationBuilder.InsertData(
                table: "JobCategories",
                columns: new[] { "CategoryId", "JobId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 6, 2 },
                    { 4, 3 },
                    { 5, 4 },
                    { 3, 5 },
                    { 8, 6 },
                    { 4, 7 },
                    { 4, 8 },
                    { 7, 9 },
                    { 8, 10 },
                    { 2, 11 },
                    { 8, 12 },
                    { 6, 13 },
                    { 8, 14 },
                    { 3, 15 },
                    { 4, 16 },
                    { 7, 17 },
                    { 6, 18 },
                    { 6, 19 },
                    { 4, 20 },
                    { 8, 21 },
                    { 5, 22 },
                    { 3, 23 },
                    { 3, 24 },
                    { 1, 25 },
                    { 2, 26 },
                    { 5, 27 },
                    { 3, 28 },
                    { 1, 29 },
                    { 2, 30 },
                    { 6, 31 },
                    { 5, 32 },
                    { 7, 33 },
                    { 3, 34 },
                    { 1, 35 },
                    { 4, 36 },
                    { 7, 37 },
                    { 5, 38 },
                    { 4, 39 },
                    { 2, 40 },
                    { 5, 41 },
                    { 7, 42 },
                    { 7, 43 },
                    { 6, 44 },
                    { 1, 45 },
                    { 1, 46 },
                    { 5, 47 },
                    { 3, 48 },
                    { 5, 49 },
                    { 1, 50 },
                    { 3, 51 },
                    { 5, 52 },
                    { 7, 53 },
                    { 1, 54 },
                    { 8, 55 },
                    { 1, 56 },
                    { 6, 57 },
                    { 2, 58 },
                    { 6, 59 },
                    { 1, 60 },
                    { 8, 61 },
                    { 2, 62 },
                    { 7, 63 },
                    { 1, 64 },
                    { 6, 65 },
                    { 1, 66 },
                    { 8, 67 },
                    { 6, 68 },
                    { 1, 69 },
                    { 7, 70 },
                    { 7, 71 },
                    { 1, 72 },
                    { 7, 73 },
                    { 3, 74 },
                    { 6, 75 },
                    { 2, 76 },
                    { 7, 77 },
                    { 8, 78 },
                    { 1, 79 },
                    { 7, 80 },
                    { 5, 81 },
                    { 4, 82 },
                    { 6, 83 },
                    { 3, 84 },
                    { 8, 85 },
                    { 5, 86 },
                    { 2, 87 },
                    { 8, 88 },
                    { 2, 89 },
                    { 4, 90 },
                    { 2, 91 },
                    { 4, 92 },
                    { 6, 93 },
                    { 4, 94 },
                    { 7, 95 },
                    { 3, 96 },
                    { 1, 97 },
                    { 4, 98 },
                    { 6, 99 },
                    { 2, 100 }
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
