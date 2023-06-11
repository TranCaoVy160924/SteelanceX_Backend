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
                    { 1, 0, "HCM", "007a3ecf-e7de-4903-8d6f-6f2e8390b597", "adminhcm@gmail.com", true, "Toan", false, "Bach", false, null, "adminhcm@gmail.com", "adminhcm", "AQAAAAIAAYagAAAAEJcRdt1govuakbcO4WXJ3eNWK17qWdlxO3WcYDuO/lYMgOqsDol5P71brqBof3FGtg==", null, false, "", false, "adminhcm" },
                    { 2, 0, "HCM", "694fd7db-a9d5-479e-a188-3549384f9436", "adminhn@gmail.com", true, "Toan", false, "Bach", false, null, "adminhn@gmail.com", "adminhn", "AQAAAAIAAYagAAAAENJUiAQUtn5p2ENYKpbXLy4t3zcxGGvYu6P0Vg2OeW8Lu+w6uSvOgo9+HB/51X70ow==", null, false, "", false, "adminhn" },
                    { 3, 0, "HCM", "ddb0b98a-a187-4181-ab1b-07a2a8e261e9", "staff@gmail.com", true, "Toan", false, "Bach", false, null, "staff@gmail.com", "staff1", "AQAAAAIAAYagAAAAEKSW7AULj+i3xOmrAtOvY/HYpvhpfPqcKKY5u7fz/qKsA75btxJYe5MPWrQMlXoxag==", null, false, "", false, "staff1" },
                    { 4, 0, "HCM", "7d23f3f5-4616-4e08-a7a5-6d3e3fc878ff", "staff@gmail.com", true, "Toan", false, "Bach", false, null, "staff@gmail.com", "staff2", "AQAAAAIAAYagAAAAEG3ZQ0XjExHVgIk+LZVlGs2Nv68TY/apT+MhIobW8qwLdQJdaLxwL2F2khh1Sw7iOg==", null, false, "", false, "staff2" },
                    { 5, 0, "HCM", "f3211b78-af2c-4a00-aa8c-a5198671fec3", "staffdis@gmail.com", true, "Toan", false, "Bach", false, null, "staffdis@gmail.com", "staffdis", "AQAAAAIAAYagAAAAEM60seeXoDKABfOIQ4vg0ggIwJu4eCrqA+dySSR8lVfuLxfC9PlJB73cqVvkFN4+9w==", null, false, "", false, "staffDis" },
                    { 6, 0, "HCM", "588d05e5-0bf0-412d-8022-742be04aa30c", "normaluser6@gmail.com", true, "6", false, "Nguyen Van", false, null, "normaluser6@gmail.com", "normalUser6", "AQAAAAIAAYagAAAAENrZRX83TdbyrWYLlPcwzYt9uHjCpTOBaSnP5y/F9LN8whAZhUv3IF3VdtHObpLd/A==", null, false, "", false, "normalUser6" },
                    { 7, 0, "HCM", "2be99ed8-dd5e-434f-a0ba-698a163feae4", "normaluser7@gmail.com", true, "7", false, "Nguyen Van", false, null, "normaluser7@gmail.com", "normalUser7", "AQAAAAIAAYagAAAAEDe1MVVlr69ouxS1M57AMbKMLFbrza1PVvDHCPa7Ywgctt2mP4+FnRv2BKwzCujyiQ==", null, false, "", false, "normalUser7" },
                    { 8, 0, "HCM", "f793ea3a-e292-4e23-bc38-50e44d62f30c", "normaluser8@gmail.com", true, "8", false, "Nguyen Van", false, null, "normaluser8@gmail.com", "normalUser8", "AQAAAAIAAYagAAAAENfoYKQ3Lj3Cvyyi6V589Tro7Y5n3heHeXMZAsPXyIldagHZzu4eZz3tYeF4vhufLA==", null, false, "", false, "normalUser8" },
                    { 9, 0, "HCM", "5c5a23b7-c1c0-4754-b690-161eddfc16ea", "normaluser9@gmail.com", true, "9", false, "Nguyen Van", false, null, "normaluser9@gmail.com", "normalUser9", "AQAAAAIAAYagAAAAENe1npRxZKqOPtNshEMzXwJtQWYYQA3ipFAVDtCbUzgwMbJX1qzXEVGEFwHZ4XQ/Rg==", null, false, "", false, "normalUser9" },
                    { 10, 0, "HCM", "affd7bb8-3773-4e48-8eef-d0655404f122", "normaluser10@gmail.com", true, "10", false, "Nguyen Van", false, null, "normaluser10@gmail.com", "normalUser10", "AQAAAAIAAYagAAAAEPiKYr0NtYWGCfup8KPHyqTz4TK3XqOU7rDfElIdtR7fKMBH9GE/zJ6ftzXf69Ccqg==", null, false, "", false, "normalUser10" },
                    { 11, 0, "HCM", "a1fb4aa5-de98-4f4a-8cac-9d02296e0cc0", "normaluser11@gmail.com", true, "11", false, "Nguyen Van", false, null, "normaluser11@gmail.com", "normalUser11", "AQAAAAIAAYagAAAAEPWrqGdWFz7rX4wk1vKbA8jY2QRw9ldvm3sWbrQclYErXOi/Z1JZb1wwEjXHWJObug==", null, false, "", false, "normalUser11" },
                    { 12, 0, "HCM", "f3edb06b-2ecb-4505-87cf-5cb4b6f5d024", "normaluser12@gmail.com", true, "12", false, "Nguyen Van", false, null, "normaluser12@gmail.com", "normalUser12", "AQAAAAIAAYagAAAAEKIBRDAhYmtPssTPFpPhcvnihMlO/JixxAPVQxd1/DnWKjoUpq/oI/6N0SB0VYZPiQ==", null, false, "", false, "normalUser12" },
                    { 13, 0, "HCM", "3de2f605-aec1-46cf-82ea-2bf307ce406d", "normaluser13@gmail.com", true, "13", false, "Nguyen Van", false, null, "normaluser13@gmail.com", "normalUser13", "AQAAAAIAAYagAAAAEAKflepJiosws0B3pFvh0eI/bwPE2Gfkq6nHrb45QhgeqBwK0JPPGO7yojG5KWWEUQ==", null, false, "", false, "normalUser13" },
                    { 14, 0, "HCM", "a58b7f5a-7884-4a4b-a9c9-19174bada9b3", "normaluser14@gmail.com", true, "14", false, "Nguyen Van", false, null, "normaluser14@gmail.com", "normalUser14", "AQAAAAIAAYagAAAAEO9hkDXYgXusmYMy1r2HXkhGHbp80LMCdORElqoRm2l1elft6I7lpFeV8LiTSA/Jjg==", null, false, "", false, "normalUser14" },
                    { 15, 0, "HCM", "846d346c-0921-493a-8474-feb9ac667b50", "normaluser15@gmail.com", true, "15", false, "Nguyen Van", false, null, "normaluser15@gmail.com", "normalUser15", "AQAAAAIAAYagAAAAECDwTHxJcPf9qdCydQwE6SoQvDo3lfTJs0rImr2NjSVc151RNvWvGHrUDV2dB9nCAg==", null, false, "", false, "normalUser15" },
                    { 16, 0, "HCM", "a68643d8-5ca0-458a-951d-8ea79c1b6d71", "normaluser16@gmail.com", true, "16", false, "Nguyen Van", false, null, "normaluser16@gmail.com", "normalUser16", "AQAAAAIAAYagAAAAEAAymPkEPf8VXosjBFC5Em3E21WLVP9OeV05GLziL9NcdifMSd9DuaYa4MgPIXQXzQ==", null, false, "", false, "normalUser16" },
                    { 17, 0, "HCM", "ab62d8b1-e684-4cee-a7d3-c47297c274cd", "normaluser17@gmail.com", true, "17", false, "Nguyen Van", false, null, "normaluser17@gmail.com", "normalUser17", "AQAAAAIAAYagAAAAEASSPdYzxxg7PNoGxd+wDGGOMx138qXoltG0yTrcZ9Ox8fyIYKxqfACcoyeTkKWlkQ==", null, false, "", false, "normalUser17" },
                    { 18, 0, "HCM", "4ce22b6d-596d-428b-941b-4a0278717397", "normaluser18@gmail.com", true, "18", false, "Nguyen Van", false, null, "normaluser18@gmail.com", "normalUser18", "AQAAAAIAAYagAAAAEFTDrhgyfEsRc8fLCeSCUSp0S6NLS4yAvSkk2zZER2ygaSZ2McdXXdoLCFOrOKu1dg==", null, false, "", false, "normalUser18" },
                    { 19, 0, "HCM", "29c94cfa-bb28-4f4e-966b-b9627da4a7cc", "normaluser19@gmail.com", true, "19", false, "Nguyen Van", false, null, "normaluser19@gmail.com", "normalUser19", "AQAAAAIAAYagAAAAEHtagFTc6CmtP5WIbJVKdVCX3XZq5NutS1mci+2zVz/hKFbv7nPm+ohdXUA8WshO8g==", null, false, "", false, "normalUser19" },
                    { 20, 0, "HCM", "c9681f8f-3d2e-4776-8181-d3e425aa15ea", "normaluser20@gmail.com", true, "20", false, "Nguyen Van", false, null, "normaluser20@gmail.com", "normalUser20", "AQAAAAIAAYagAAAAEG7WkgvTtWIHstK2HVrouA4PCf0RUKO0uOZMRydStziEd/nxB2jULdnK4DOWbBQO1A==", null, false, "", false, "normalUser20" },
                    { 21, 0, "HCM", "ca1420f1-0af0-4eff-b431-c9c52856d70b", "normaluser21@gmail.com", true, "21", false, "Nguyen Van", false, null, "normaluser21@gmail.com", "normalUser21", "AQAAAAIAAYagAAAAENtfy6QXdEjiEZe6AI4wr1FWUv8Mebl4SZrNMZupJ1lGd/ohxOC8DFUq5i0S9hwiag==", null, false, "", false, "normalUser21" },
                    { 22, 0, "HCM", "30c922a6-5929-4f18-895d-d1af40122519", "normaluser22@gmail.com", true, "22", false, "Nguyen Van", false, null, "normaluser22@gmail.com", "normalUser22", "AQAAAAIAAYagAAAAEEdDN4/DEb9WeNKifeDwKTpM3Drike9BZyCVQYmNma/Nb4XkUf2PdeWIgPtZlX2NFw==", null, false, "", false, "normalUser22" },
                    { 23, 0, "HCM", "7e9350f5-426b-4805-b327-816db1176ad3", "normaluser23@gmail.com", true, "23", false, "Nguyen Van", false, null, "normaluser23@gmail.com", "normalUser23", "AQAAAAIAAYagAAAAEI9WQxN6LdXfciEDBJqv2Xk8PSq/mwYXAjrLINunPa9yOQhHeLgpKouWHxIbRX820g==", null, false, "", false, "normalUser23" },
                    { 24, 0, "HCM", "4e02b496-e25b-4947-9447-33b0396bdc69", "normaluser24@gmail.com", true, "24", false, "Nguyen Van", false, null, "normaluser24@gmail.com", "normalUser24", "AQAAAAIAAYagAAAAEC7tCFCR2BO45dxZxF4otmy7tstjEV/0DY5w/hHpjEaY1pQwiLt+gi1uhxfrylc+QA==", null, false, "", false, "normalUser24" },
                    { 25, 0, "HCM", "81ba1d74-70b1-4071-86d5-d13e74d9c161", "normaluser25@gmail.com", true, "25", false, "Nguyen Van", false, null, "normaluser25@gmail.com", "normalUser25", "AQAAAAIAAYagAAAAEEs+msn6PshUu53EzSfY2Cit1aKqkaQuCS1QKUW4p2G4qJ+iYtyH3i1w/1RgHFFHXg==", null, false, "", false, "normalUser25" },
                    { 26, 0, "HCM", "685f3dfa-561b-4c8d-bb02-474cc3e16858", "normaluser26@gmail.com", true, "26", false, "Nguyen Van", false, null, "normaluser26@gmail.com", "normalUser26", "AQAAAAIAAYagAAAAEDUY4luwzQvk0pC+maD388x4CHbvVHsyGvr+U7zEFcQSh/7aZ57moDOdGwdHA8Oj/Q==", null, false, "", false, "normalUser26" },
                    { 27, 0, "HCM", "8cc544cd-ed25-4848-9d2f-e459d8b75aeb", "normaluser27@gmail.com", true, "27", false, "Nguyen Van", false, null, "normaluser27@gmail.com", "normalUser27", "AQAAAAIAAYagAAAAEJuYrLTmycBruMBf4hW1vkpSQbXPZMjdwwPEUTeIrKCREyJj9kS9QW5on31BybYmUQ==", null, false, "", false, "normalUser27" },
                    { 28, 0, "HCM", "454567c8-72b3-4b24-84c3-9d9b49fe389b", "normaluser28@gmail.com", true, "28", false, "Nguyen Van", false, null, "normaluser28@gmail.com", "normalUser28", "AQAAAAIAAYagAAAAEE8HCFduznRa2EZPSQ4bdQxkvsr1/n/VAk3xw94JemNOLooixXiHPua3ew8mBBoOFw==", null, false, "", false, "normalUser28" },
                    { 29, 0, "HCM", "e2d23f8a-9d70-4b9e-a001-de3f4aacd7cc", "normaluser29@gmail.com", true, "29", false, "Nguyen Van", false, null, "normaluser29@gmail.com", "normalUser29", "AQAAAAIAAYagAAAAEEouSkkPjwu5l7eFH6C53sdWbTs1lsQkRZ4vBj0TuvvvJ6sfM2V862FzP3xMvMCTIA==", null, false, "", false, "normalUser29" },
                    { 30, 0, "HCM", "feeda0f7-b376-432b-845b-3d038ce26eef", "normaluser30@gmail.com", true, "30", false, "Nguyen Van", false, null, "normaluser30@gmail.com", "normalUser30", "AQAAAAIAAYagAAAAEPyvzU7UUHnIcxwppX2nBLlOrkPGR5zgnWKNAzSJRlV0EMXbsdibbxBSqI/B6Vdy3A==", null, false, "", false, "normalUser30" },
                    { 31, 0, "HCM", "6f6285f4-79b1-48a5-87a7-610e97852d0e", "normaluser31@gmail.com", true, "31", false, "Nguyen Van", false, null, "normaluser31@gmail.com", "normalUser31", "AQAAAAIAAYagAAAAEEStEWzU3iSB3s/l6DSQEzY4alWijVgywwFFU7mBjCTkjJK1HhWGBcHmZbcXJYuhQw==", null, false, "", false, "normalUser31" },
                    { 32, 0, "HCM", "d8ff13ad-0aba-426b-9265-eb91452d028e", "normaluser32@gmail.com", true, "32", false, "Nguyen Van", false, null, "normaluser32@gmail.com", "normalUser32", "AQAAAAIAAYagAAAAECfQT7bQfEqsc/DL7OiOMb2gz1Ijzs49ySq077ChKtztks3ztrE3DCLFxcHdaWWDbg==", null, false, "", false, "normalUser32" },
                    { 33, 0, "HCM", "e6d52145-14d4-46c5-93c8-d00cfbc54d01", "normaluser33@gmail.com", true, "33", false, "Nguyen Van", false, null, "normaluser33@gmail.com", "normalUser33", "AQAAAAIAAYagAAAAELtvZ8KxMJfU/BgqQr11Sb3lfWjRknQVgYVT4I8CzYrYgTaj5TFkravVfNywB2kZ5A==", null, false, "", false, "normalUser33" },
                    { 34, 0, "HCM", "f5df3e16-7d24-46de-8595-36362cd8bacb", "normaluser34@gmail.com", true, "34", false, "Nguyen Van", false, null, "normaluser34@gmail.com", "normalUser34", "AQAAAAIAAYagAAAAECCd4AyhFRhGgwpzTeT67gJSumsk0xBJGGKrlncyUNCgwTfMIdtmhkNGpnt/RJ5EIg==", null, false, "", false, "normalUser34" },
                    { 35, 0, "HCM", "cbc98693-cb35-4fc6-a1c9-5b014ade86d0", "normaluser35@gmail.com", true, "35", false, "Nguyen Van", false, null, "normaluser35@gmail.com", "normalUser35", "AQAAAAIAAYagAAAAEEtVgSc79PIXYWXNVuFEX63FtvKM3jHFqU8GCu7s6LunLI3RxrWVjf/acMVjJduJzA==", null, false, "", false, "normalUser35" },
                    { 36, 0, "HCM", "9b945258-8e33-4a99-8567-5bd94aa76ad8", "normaluser36@gmail.com", true, "36", false, "Nguyen Van", false, null, "normaluser36@gmail.com", "normalUser36", "AQAAAAIAAYagAAAAEKXNFJ0k7kL1hNiz2U40/lq3Kv6lTd4P/iIpi2L89xWy6C8xK6fNR2NvLhTAIWYNsA==", null, false, "", false, "normalUser36" },
                    { 37, 0, "HCM", "d14f4a6e-9f85-4bcf-a830-cdccede9a68a", "normaluser37@gmail.com", true, "37", false, "Nguyen Van", false, null, "normaluser37@gmail.com", "normalUser37", "AQAAAAIAAYagAAAAEHNpdFL4SSLXZB/mQ4SiGH5LWBJzNWe1r3S4rCLiSioH3Y/92viYMKjfI9OPhKHHQA==", null, false, "", false, "normalUser37" },
                    { 38, 0, "HCM", "aa63bfa0-154d-4e1a-bd74-98a97a34849c", "normaluser38@gmail.com", true, "38", false, "Nguyen Van", false, null, "normaluser38@gmail.com", "normalUser38", "AQAAAAIAAYagAAAAEDZSwL8ThZ2KQ3UiLn48L4wf4yvBW6lkKsf/CrbRzUZqL5NVqpw9u6hO7URBj1wrDA==", null, false, "", false, "normalUser38" },
                    { 39, 0, "HCM", "0151d45c-2c8d-45b0-9498-70c43faf4702", "normaluser39@gmail.com", true, "39", false, "Nguyen Van", false, null, "normaluser39@gmail.com", "normalUser39", "AQAAAAIAAYagAAAAEMgGhZil6iS6/Mw3wdx/0BRcQoDoAdLuRbl/UDHVkPCV5xp7OWkhQWsSbdYDLljhDw==", null, false, "", false, "normalUser39" },
                    { 40, 0, "HCM", "4775cc49-9888-4edc-8240-9638816b135b", "normaluser40@gmail.com", true, "40", false, "Nguyen Van", false, null, "normaluser40@gmail.com", "normalUser40", "AQAAAAIAAYagAAAAED6XuY5I5oq8oHjcg0iCMs3rldjOuZRoXCs81WFetj4gZugvnATpVkd1BHRDHwHeqw==", null, false, "", false, "normalUser40" },
                    { 41, 0, "HCM", "863091ae-2c44-48fc-af77-7fa27d5dfd6d", "normaluser41@gmail.com", true, "41", false, "Nguyen Van", false, null, "normaluser41@gmail.com", "normalUser41", "AQAAAAIAAYagAAAAECExRfceZiN/U6PW1lLkn+nwez3nyWPMRk9oHEQ30TXzxN6u6gmZqQq1+vffJU7rLw==", null, false, "", false, "normalUser41" },
                    { 42, 0, "HCM", "fb875f9b-fd12-4cc3-aa5f-afcf9a0fd591", "normaluser42@gmail.com", true, "42", false, "Nguyen Van", false, null, "normaluser42@gmail.com", "normalUser42", "AQAAAAIAAYagAAAAEKcCO/m+bzVfTB9zIoAWM74rj6IuvcLJc7ZJjW+ws1IE9aOPIcZHIIE3Pc1YN//xSw==", null, false, "", false, "normalUser42" },
                    { 43, 0, "HCM", "8e85cd0d-f599-4cce-96dd-57dc341cbfcd", "normaluser43@gmail.com", true, "43", false, "Nguyen Van", false, null, "normaluser43@gmail.com", "normalUser43", "AQAAAAIAAYagAAAAEMmqI/tANDZgUqxe45cGOagyNm4EUDkqhuWDHRqN+i9EcUDVoSVDBnb3+Uc8q2QRHQ==", null, false, "", false, "normalUser43" },
                    { 44, 0, "HCM", "bfb2593a-85ae-45d5-89a4-a5dd1aaf5146", "normaluser44@gmail.com", true, "44", false, "Nguyen Van", false, null, "normaluser44@gmail.com", "normalUser44", "AQAAAAIAAYagAAAAEF+ZSQigwzJLy6bA38qIHgFv1wOUNX7MVyHzJdiypFqryPEUTk6ONLEe1qJUd2Ksjg==", null, false, "", false, "normalUser44" },
                    { 45, 0, "HCM", "4bb74423-fbc5-4892-80c1-5a8420abe571", "normaluser45@gmail.com", true, "45", false, "Nguyen Van", false, null, "normaluser45@gmail.com", "normalUser45", "AQAAAAIAAYagAAAAEK9/TZmyPfcX4nGOkcc33DQ85J+RKVK+W8lQpULFSP4upNiOjaCjCpNzlyRk+EL5DQ==", null, false, "", false, "normalUser45" },
                    { 46, 0, "HCM", "860a1891-d4bb-4d40-8d18-daa73476265e", "normaluser46@gmail.com", true, "46", false, "Nguyen Van", false, null, "normaluser46@gmail.com", "normalUser46", "AQAAAAIAAYagAAAAEBCqPiRRTCVFwGxZMDNgHOpZzGnmwN28WwrCN1Dcp4JmaTzVAxxvI0qAZWphugB6DQ==", null, false, "", false, "normalUser46" },
                    { 47, 0, "HCM", "abcf4e29-be26-4f4f-91e4-2f5ee71ac993", "normaluser47@gmail.com", true, "47", false, "Nguyen Van", false, null, "normaluser47@gmail.com", "normalUser47", "AQAAAAIAAYagAAAAEAxWce1tkU3F9li5ZoeSSAjLnmy/wy0zZk2WqtKsEZC6YrcqqIfETt61wGqJmWSrfA==", null, false, "", false, "normalUser47" },
                    { 48, 0, "HCM", "3f8d681a-2576-42f9-a037-23bf22f478f6", "normaluser48@gmail.com", true, "48", false, "Nguyen Van", false, null, "normaluser48@gmail.com", "normalUser48", "AQAAAAIAAYagAAAAEOUq0VCagWSlQz3nw+AvR/FwViH9A3QmO1NGo82cLSsXLKwyg5FPBwxiBmGh/LHgPQ==", null, false, "", false, "normalUser48" },
                    { 49, 0, "HCM", "b792aab0-f829-4206-85dc-9e2018bd501b", "normaluser49@gmail.com", true, "49", false, "Nguyen Van", false, null, "normaluser49@gmail.com", "normalUser49", "AQAAAAIAAYagAAAAEIj4LqurSg98VBVS6St9oH4aQK3Ij9/1mjxPp02WZGiB2qUv1JnCZSx1KsL5ZAHRpg==", null, false, "", false, "normalUser49" },
                    { 50, 0, "HCM", "9690a29a-804e-4ad8-bed3-51e4476d200d", "normaluser50@gmail.com", true, "50", false, "Nguyen Van", false, null, "normaluser50@gmail.com", "normalUser50", "AQAAAAIAAYagAAAAEGuX3iXZQBAsniihneduhq8Mm9xU7+LO4KMuM4VlP+gFVGkJoIlkndtfG5uSisHFHw==", null, false, "", false, "normalUser50" },
                    { 51, 0, "HCM", "0137ef68-f090-4f7a-a34c-def3b6cdbda4", "normaluser51@gmail.com", true, "51", false, "Nguyen Van", false, null, "normaluser51@gmail.com", "normalUser51", "AQAAAAIAAYagAAAAEGeUjMrt5Q+P8ElC00bKwX0zMXnHsd33Da9iqNEmd29HbrUd1Uf0wrDnlyMtavTUTw==", null, false, "", false, "normalUser51" },
                    { 52, 0, "HCM", "d195ed0d-5f3e-4fd6-ad85-05f93797fdb2", "normaluser52@gmail.com", true, "52", false, "Nguyen Van", false, null, "normaluser52@gmail.com", "normalUser52", "AQAAAAIAAYagAAAAECldSH9XrulEGbin1thXxsj96R0k+PRHnn5RccCKJJeUT9Nujxyd/i1G+pViCTJsoA==", null, false, "", false, "normalUser52" },
                    { 53, 0, "HCM", "5a207898-6f39-4c46-9397-d4b3d239176c", "normaluser53@gmail.com", true, "53", false, "Nguyen Van", false, null, "normaluser53@gmail.com", "normalUser53", "AQAAAAIAAYagAAAAEEktApTBOgs8p+SLo/WMcgCeUtZTs0sEJ2f8cjGo3pfTysaSdlTTkf9ik0y9rOruuw==", null, false, "", false, "normalUser53" },
                    { 54, 0, "HCM", "2d7f113f-7aca-4e61-91f3-6f8e2afbb455", "normaluser54@gmail.com", true, "54", false, "Nguyen Van", false, null, "normaluser54@gmail.com", "normalUser54", "AQAAAAIAAYagAAAAEHNJ83oBZ3LHyaHV4hPFl035j++K29xUxIUWUKN0gVy/oqTix4oKaxyqTGeSW4sFSw==", null, false, "", false, "normalUser54" },
                    { 55, 0, "HCM", "f7e8e983-2525-43ec-b03d-df60f609173e", "normaluser55@gmail.com", true, "55", false, "Nguyen Van", false, null, "normaluser55@gmail.com", "normalUser55", "AQAAAAIAAYagAAAAEEqq2Nr7hlxqwpdMAJ/XYyHZfvENPqXcczRS5chlTUzwkfzP8acQMA/TLZ882AmiOQ==", null, false, "", false, "normalUser55" },
                    { 56, 0, "HCM", "f4b61743-e3f2-40af-81a7-c8e768333f7a", "normaluser56@gmail.com", true, "56", false, "Nguyen Van", false, null, "normaluser56@gmail.com", "normalUser56", "AQAAAAIAAYagAAAAEEPt7N5ARDRYrEYXgLvxWrMXQ6+9Ak3EQTpB1ETBUhwFbFq3YYKgGqCGwlSM6IzYkA==", null, false, "", false, "normalUser56" },
                    { 57, 0, "HCM", "f1bda631-7e16-4686-b597-2308632764c6", "normaluser57@gmail.com", true, "57", false, "Nguyen Van", false, null, "normaluser57@gmail.com", "normalUser57", "AQAAAAIAAYagAAAAEADbbYVxlJhTKVzCjhU3t8SjliQaQNvJtC9bZOD5ahXt0QjKve059L9dg+O5ZYPYBQ==", null, false, "", false, "normalUser57" },
                    { 58, 0, "HCM", "bf7fe650-5250-482c-99dd-67972732f468", "normaluser58@gmail.com", true, "58", false, "Nguyen Van", false, null, "normaluser58@gmail.com", "normalUser58", "AQAAAAIAAYagAAAAEBO82V9dDFaAQyT4586U6mEtiANYeVX87s6bJBMFBe+bfe51ub4qEd4D0gZPquslLg==", null, false, "", false, "normalUser58" },
                    { 59, 0, "HCM", "ac14090d-d90a-4473-ab08-271988fe0ad7", "normaluser59@gmail.com", true, "59", false, "Nguyen Van", false, null, "normaluser59@gmail.com", "normalUser59", "AQAAAAIAAYagAAAAEKlfu8cI4Y1iUUHsxuzRCg/yf9Z5aojq6i3kIc3FTTDiAZhhuvVt0chrMox7+Y8aWQ==", null, false, "", false, "normalUser59" },
                    { 60, 0, "HCM", "97ea6792-05e3-42b0-90fd-4a569f2c7d9f", "normaluser60@gmail.com", true, "60", false, "Nguyen Van", false, null, "normaluser60@gmail.com", "normalUser60", "AQAAAAIAAYagAAAAECSVhfpr1FMVAssaOjQZGzCd4UptJFo6OO1Z3UvPPVA7F5f1mcyqiqwuxCdXHq1Mfg==", null, false, "", false, "normalUser60" },
                    { 61, 0, "HCM", "5b1b0b74-34c8-465b-9a45-c8ccccdf7383", "normaluser61@gmail.com", true, "61", false, "Nguyen Van", false, null, "normaluser61@gmail.com", "normalUser61", "AQAAAAIAAYagAAAAEKFb6IztHnWhIp/t0n+73ImZvY6tXhBFMngXrus3FlIk3aL8BUMe6svI3HIpVfXmCA==", null, false, "", false, "normalUser61" },
                    { 62, 0, "HCM", "a26f884b-c58b-4a2f-80a3-cba79e39d5e0", "normaluser62@gmail.com", true, "62", false, "Nguyen Van", false, null, "normaluser62@gmail.com", "normalUser62", "AQAAAAIAAYagAAAAELPDezsFMdhrD4RssjRVdo/mIObrn+XkjPsaAEXiuKYlEDI9cn+nanPr/0oe8cG9xA==", null, false, "", false, "normalUser62" },
                    { 63, 0, "HCM", "b9dccef6-df47-44d4-a4b3-91d37748aa05", "normaluser63@gmail.com", true, "63", false, "Nguyen Van", false, null, "normaluser63@gmail.com", "normalUser63", "AQAAAAIAAYagAAAAEJqnep9XgFgLZkgzMHGj4bfSbxmiU4HHtOaMEN3ahCE6xqI9iQdS0VDstv7vaxI/1Q==", null, false, "", false, "normalUser63" },
                    { 64, 0, "HCM", "0cd340d0-a360-4f67-b541-6aae28f4329a", "normaluser64@gmail.com", true, "64", false, "Nguyen Van", false, null, "normaluser64@gmail.com", "normalUser64", "AQAAAAIAAYagAAAAEBSlnyDPNTqIHlV8GnksBzwwYJ2R91J+bzWlFBbKMEbPLljPCX4FLu7nNQu9R3lHiw==", null, false, "", false, "normalUser64" },
                    { 65, 0, "HCM", "7c66930c-3ab1-4ad1-b03d-e10fdaf407a7", "normaluser65@gmail.com", true, "65", false, "Nguyen Van", false, null, "normaluser65@gmail.com", "normalUser65", "AQAAAAIAAYagAAAAEOOgsfpe8TWJ++l9FIkoM1ALuaRECkusDWIrB328m0SvtcJvmcxbrL90p0ML7ve/mg==", null, false, "", false, "normalUser65" }
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
                    { 7, 36 },
                    { 2, 37 },
                    { 8, 38 },
                    { 4, 39 },
                    { 5, 40 },
                    { 6, 41 },
                    { 2, 42 },
                    { 1, 43 },
                    { 7, 44 },
                    { 3, 45 },
                    { 1, 46 },
                    { 7, 47 },
                    { 8, 48 },
                    { 5, 49 },
                    { 6, 50 },
                    { 2, 51 },
                    { 1, 52 },
                    { 5, 53 },
                    { 5, 54 },
                    { 4, 55 },
                    { 1, 56 },
                    { 7, 57 },
                    { 3, 58 },
                    { 2, 59 },
                    { 2, 60 },
                    { 5, 61 },
                    { 1, 62 },
                    { 4, 63 },
                    { 3, 64 },
                    { 1, 65 }
                });

            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "Id", "ApplyExpireDate", "BusinessProfileId", "CreatedDate", "Description", "IsActive", "JobExpiredDate", "Name", "Offer" },
                values: new object[,]
                {
                    { 1, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9637), "This a simple description for project 1", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 1", 99.0 },
                    { 2, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9676), "This a simple description for project 2", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 2", 198.0 },
                    { 3, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9683), "This a simple description for project 3", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 3", 297.0 },
                    { 4, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9689), "This a simple description for project 4", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 4", 396.0 },
                    { 5, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9730), "This a simple description for project 5", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 5", 495.0 },
                    { 6, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9739), "This a simple description for project 6", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 6", 594.0 },
                    { 7, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9745), "This a simple description for project 7", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 7", 693.0 },
                    { 8, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9752), "This a simple description for project 8", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 8", 792.0 },
                    { 9, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9758), "This a simple description for project 9", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 9", 891.0 },
                    { 10, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9766), "This a simple description for project 10", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 10", 990.0 },
                    { 11, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9772), "This a simple description for project 11", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 11", 1089.0 },
                    { 12, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9779), "This a simple description for project 12", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 12", 1188.0 },
                    { 13, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9785), "This a simple description for project 13", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 13", 1287.0 },
                    { 14, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9792), "This a simple description for project 14", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 14", 1386.0 },
                    { 15, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9828), "This a simple description for project 15", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 15", 1485.0 },
                    { 16, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9836), "This a simple description for project 16", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 16", 1584.0 },
                    { 17, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9842), "This a simple description for project 17", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 17", 1683.0 },
                    { 18, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9850), "This a simple description for project 18", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 18", 1782.0 },
                    { 19, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9857), "This a simple description for project 19", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 19", 1881.0 },
                    { 20, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9863), "This a simple description for project 20", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 20", 1980.0 },
                    { 21, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9870), "This a simple description for project 21", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 21", 2079.0 },
                    { 22, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9876), "This a simple description for project 22", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 22", 2178.0 },
                    { 23, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9883), "This a simple description for project 23", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 23", 2277.0 },
                    { 24, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9920), "This a simple description for project 24", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 24", 2376.0 },
                    { 25, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9927), "This a simple description for project 25", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 25", 2475.0 },
                    { 26, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9934), "This a simple description for project 26", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 26", 2574.0 },
                    { 27, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9940), "This a simple description for project 27", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 27", 2673.0 },
                    { 28, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9947), "This a simple description for project 28", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 28", 2772.0 },
                    { 29, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9953), "This a simple description for project 29", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 29", 2871.0 },
                    { 30, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(532), "This a simple description for project 30", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 30", 2970.0 },
                    { 31, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(569), "This a simple description for project 31", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 31", 3069.0 },
                    { 32, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(576), "This a simple description for project 32", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 32", 3168.0 },
                    { 33, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(582), "This a simple description for project 33", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 33", 3267.0 },
                    { 34, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(631), "This a simple description for project 34", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 34", 3366.0 },
                    { 35, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 32, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(638), "This a simple description for project 35", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 35", 3465.0 },
                    { 36, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(644), "This a simple description for project 36", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 36", 3564.0 },
                    { 37, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(651), "This a simple description for project 37", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 37", 3663.0 },
                    { 38, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(657), "This a simple description for project 38", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 38", 3762.0 },
                    { 39, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(663), "This a simple description for project 39", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 39", 3861.0 },
                    { 40, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(670), "This a simple description for project 40", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 40", 3960.0 },
                    { 41, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(676), "This a simple description for project 41", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 41", 4059.0 },
                    { 42, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(683), "This a simple description for project 42", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 42", 4158.0 },
                    { 43, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(721), "This a simple description for project 43", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 43", 4257.0 },
                    { 44, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(728), "This a simple description for project 44", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 44", 4356.0 },
                    { 45, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(734), "This a simple description for project 45", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 45", 4455.0 },
                    { 46, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(741), "This a simple description for project 46", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 46", 4554.0 },
                    { 47, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(747), "This a simple description for project 47", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 47", 4653.0 },
                    { 48, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(754), "This a simple description for project 48", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 48", 4752.0 },
                    { 49, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(760), "This a simple description for project 49", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 49", 4851.0 },
                    { 50, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(766), "This a simple description for project 50", true, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 50", 4950.0 },
                    { 51, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(774), "This a simple description for project 51", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 51", 5049.0 },
                    { 52, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(780), "This a simple description for project 52", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 52", 5148.0 },
                    { 53, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(816), "This a simple description for project 53", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 53", 5247.0 },
                    { 54, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(824), "This a simple description for project 54", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 54", 5346.0 },
                    { 55, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(830), "This a simple description for project 55", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 55", 5445.0 },
                    { 56, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(837), "This a simple description for project 56", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 56", 5544.0 },
                    { 57, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(843), "This a simple description for project 57", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 57", 5643.0 },
                    { 58, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(849), "This a simple description for project 58", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 58", 5742.0 },
                    { 59, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 32, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(856), "This a simple description for project 59", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 59", 5841.0 },
                    { 60, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(862), "This a simple description for project 60", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 60", 5940.0 },
                    { 61, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(869), "This a simple description for project 61", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 61", 6039.0 },
                    { 62, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(875), "This a simple description for project 62", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 62", 6138.0 },
                    { 63, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(912), "This a simple description for project 63", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 63", 6237.0 },
                    { 64, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(920), "This a simple description for project 64", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 64", 6336.0 },
                    { 65, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(926), "This a simple description for project 65", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 65", 6435.0 },
                    { 66, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(934), "This a simple description for project 66", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 66", 6534.0 },
                    { 67, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(940), "This a simple description for project 67", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 67", 6633.0 },
                    { 68, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(946), "This a simple description for project 68", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 68", 6732.0 },
                    { 69, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(953), "This a simple description for project 69", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 69", 6831.0 },
                    { 70, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(959), "This a simple description for project 70", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 70", 6930.0 },
                    { 71, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1024), "This a simple description for project 71", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 71", 7029.0 },
                    { 72, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1030), "This a simple description for project 72", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 72", 7128.0 },
                    { 73, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1037), "This a simple description for project 73", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 73", 7227.0 },
                    { 74, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1043), "This a simple description for project 74", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 74", 7326.0 },
                    { 75, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1049), "This a simple description for project 75", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 75", 7425.0 },
                    { 76, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1056), "This a simple description for project 76", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 76", 7524.0 },
                    { 77, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1062), "This a simple description for project 77", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 77", 7623.0 },
                    { 78, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 32, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1068), "This a simple description for project 78", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 78", 7722.0 },
                    { 79, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1075), "This a simple description for project 79", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 79", 7821.0 },
                    { 80, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1081), "This a simple description for project 80", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 80", 7920.0 },
                    { 81, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1123), "This a simple description for project 81", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 81", 8019.0 },
                    { 82, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1129), "This a simple description for project 82", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 82", 8118.0 },
                    { 83, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1136), "This a simple description for project 83", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 83", 8217.0 },
                    { 84, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1142), "This a simple description for project 84", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 84", 8316.0 },
                    { 85, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1149), "This a simple description for project 85", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 85", 8415.0 },
                    { 86, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1155), "This a simple description for project 86", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 86", 8514.0 },
                    { 87, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1161), "This a simple description for project 87", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 87", 8613.0 },
                    { 88, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1168), "This a simple description for project 88", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 88", 8712.0 },
                    { 89, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1174), "This a simple description for project 89", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 89", 8811.0 },
                    { 90, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1181), "This a simple description for project 90", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 90", 8910.0 },
                    { 91, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 30, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1219), "This a simple description for project 91", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 91", 9009.0 },
                    { 92, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1226), "This a simple description for project 92", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 92", 9108.0 },
                    { 93, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1232), "This a simple description for project 93", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 93", 9207.0 },
                    { 94, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1238), "This a simple description for project 94", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 94", 9306.0 },
                    { 95, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1244), "This a simple description for project 95", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 95", 9405.0 },
                    { 96, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1251), "This a simple description for project 96", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 96", 9504.0 },
                    { 97, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1257), "This a simple description for project 97", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 97", 9603.0 },
                    { 98, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1264), "This a simple description for project 98", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 98", 9702.0 },
                    { 99, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1270), "This a simple description for project 99", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 99", 9801.0 },
                    { 100, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1277), "This a simple description for project 100", false, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 100", 9900.0 }
                });

            migrationBuilder.InsertData(
                table: "JobCategories",
                columns: new[] { "CategoryId", "JobId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 3, 4 },
                    { 6, 5 },
                    { 2, 6 },
                    { 5, 7 },
                    { 1, 8 },
                    { 5, 9 },
                    { 1, 10 },
                    { 4, 11 },
                    { 1, 12 },
                    { 7, 13 },
                    { 6, 14 },
                    { 2, 15 },
                    { 3, 16 },
                    { 4, 17 },
                    { 2, 18 },
                    { 3, 19 },
                    { 7, 20 },
                    { 1, 21 },
                    { 6, 22 },
                    { 6, 23 },
                    { 4, 24 },
                    { 2, 25 },
                    { 2, 26 },
                    { 4, 27 },
                    { 5, 28 },
                    { 3, 29 },
                    { 2, 30 },
                    { 3, 31 },
                    { 2, 32 },
                    { 5, 33 },
                    { 6, 34 },
                    { 5, 35 },
                    { 6, 36 },
                    { 7, 37 },
                    { 3, 38 },
                    { 3, 39 },
                    { 5, 40 },
                    { 2, 41 },
                    { 6, 42 },
                    { 2, 43 },
                    { 2, 44 },
                    { 5, 45 },
                    { 4, 46 },
                    { 1, 47 },
                    { 2, 48 },
                    { 2, 49 },
                    { 6, 50 },
                    { 5, 51 },
                    { 6, 52 },
                    { 2, 53 },
                    { 1, 54 },
                    { 7, 55 },
                    { 1, 56 },
                    { 6, 57 },
                    { 7, 58 },
                    { 5, 59 },
                    { 7, 60 },
                    { 2, 61 },
                    { 1, 62 },
                    { 5, 63 },
                    { 3, 64 },
                    { 2, 65 },
                    { 6, 66 },
                    { 3, 67 },
                    { 4, 68 },
                    { 7, 69 },
                    { 7, 70 },
                    { 2, 71 },
                    { 6, 72 },
                    { 1, 73 },
                    { 2, 74 },
                    { 5, 75 },
                    { 2, 76 },
                    { 2, 77 },
                    { 3, 78 },
                    { 7, 79 },
                    { 2, 80 },
                    { 7, 81 },
                    { 7, 82 },
                    { 6, 83 },
                    { 4, 84 },
                    { 2, 85 },
                    { 3, 86 },
                    { 3, 87 },
                    { 5, 88 },
                    { 3, 89 },
                    { 4, 90 },
                    { 5, 91 },
                    { 5, 92 },
                    { 3, 93 },
                    { 6, 94 },
                    { 5, 95 },
                    { 7, 96 },
                    { 6, 97 },
                    { 5, 98 },
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
