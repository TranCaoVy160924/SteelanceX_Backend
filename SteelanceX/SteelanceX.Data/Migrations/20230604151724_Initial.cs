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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResumeUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    { 1, 0, "HCM", "09c48ac8-b488-4c78-ab86-791689c1ae33", "adminhcm@gmail.com", true, "Toan", "Bach", false, null, "adminhcm@gmail.com", "adminhcm", "AQAAAAIAAYagAAAAEPgLcK3WmAegK8FEhR95OL0rG4aUizJTK5RR3uzQ0ESw8e/DZtRN5nIbfhpwuweUGw==", null, false, "", false, "adminhcm" },
                    { 2, 0, "HCM", "e76e6a12-f793-4b62-a9dd-bca797672990", "adminhn@gmail.com", true, "Toan", "Bach", false, null, "adminhn@gmail.com", "adminhn", "AQAAAAIAAYagAAAAEI5gn3riH3PCKWYa+qH3x/Aib0LGx7KNE2uHzqbbPtygLbDCWG7yqzK8Gz/AD+JQYA==", null, false, "", false, "adminhn" },
                    { 3, 0, "HCM", "f2e4f27c-b506-4795-8209-ea2cd044abbb", "staff@gmail.com", true, "Toan", "Bach", false, null, "staff@gmail.com", "staff1", "AQAAAAIAAYagAAAAEIG9GC1ti+thc4h0qzXWIrlRfOtS8g3ZtljQV+NUzc0tHXIjmbhtS7XfWg9eLZSbHg==", null, false, "", false, "staff1" },
                    { 4, 0, "HCM", "a1fea479-d91a-4fba-8a40-eeaebb68af30", "staff@gmail.com", true, "Toan", "Bach", false, null, "staff@gmail.com", "staff2", "AQAAAAIAAYagAAAAEAbwmOLGk1pcAl99fuVD3W1pb5tbTUrVIFb6n/EzifG+qf2MH9X7Qxe3vohPdPmcug==", null, false, "", false, "staff2" },
                    { 5, 0, "HCM", "8a9894b0-065d-4813-853d-743a845aca4d", "staffdis@gmail.com", true, "Toan", "Bach", false, null, "staffdis@gmail.com", "staffdis", "AQAAAAIAAYagAAAAEEjmCsarOfDenfPr+GXWQ3XwXSLDlq6WaG5d+fMtkhRC3II0L86dFGWKAi7tRxUQCg==", null, false, "", false, "staffDis" },
                    { 6, 0, "HCM", "4874ae0b-0718-4be5-9f9a-e46261993ee6", "normaluser6@gmail.com", true, "6", "Nguyen Van", false, null, "normaluser6@gmail.com", "normalUser6", "AQAAAAIAAYagAAAAEPqZD2Z5A0Ev6ET5ZMZNfe36ttxRbm8vDbot9nOpS7Kzt9fjYt8zlHbEJnXXZWPqdw==", null, false, "", false, "normalUser6" },
                    { 7, 0, "HCM", "f088e132-4453-4d9c-ad0f-8a70ebc0ec9c", "normaluser7@gmail.com", true, "7", "Nguyen Van", false, null, "normaluser7@gmail.com", "normalUser7", "AQAAAAIAAYagAAAAEIuF6XjPdDC6Yec/msOKZDrvP4wiqjxAB4GYsB9QX9Sqcvyc5MgLfmLXVEDj4DgrfA==", null, false, "", false, "normalUser7" },
                    { 8, 0, "HCM", "7b7d5e61-ec84-4606-aed6-4e39942263dd", "normaluser8@gmail.com", true, "8", "Nguyen Van", false, null, "normaluser8@gmail.com", "normalUser8", "AQAAAAIAAYagAAAAEGpx0JKz4ul2uh7A9I1K3Ds4Pjikk4PsnDaIxvK5WGRM9sM71cS9y+9fSmrPLMnFNQ==", null, false, "", false, "normalUser8" },
                    { 9, 0, "HCM", "7fe85384-6139-439b-abac-6b00bb930be0", "normaluser9@gmail.com", true, "9", "Nguyen Van", false, null, "normaluser9@gmail.com", "normalUser9", "AQAAAAIAAYagAAAAEMTV2+RNtddbhED1qxJiZTE+juZodXo6n0RrowHHu62aiym01BE+olTIfmsGsHdmaA==", null, false, "", false, "normalUser9" },
                    { 10, 0, "HCM", "4aa53f7b-e07d-445f-abd8-f88a3d01f89c", "normaluser10@gmail.com", true, "10", "Nguyen Van", false, null, "normaluser10@gmail.com", "normalUser10", "AQAAAAIAAYagAAAAEGpSr/Un8RHy/I0Hy35rdIEPuV6YJEEdwvBylOmnzif2GrVCItHhdG87pReUsWcDIQ==", null, false, "", false, "normalUser10" },
                    { 11, 0, "HCM", "626c6ac2-7de8-4de7-9e37-c8722ea83dc5", "normaluser11@gmail.com", true, "11", "Nguyen Van", false, null, "normaluser11@gmail.com", "normalUser11", "AQAAAAIAAYagAAAAEEk30qaQBNxulr43rK7EbARgnX0vLZflO/jzQg4ZG2REJ4jGC01v8Nb9AtidxUvX4w==", null, false, "", false, "normalUser11" },
                    { 12, 0, "HCM", "34dbc6df-6e0b-4fc5-adb6-3068fe028420", "normaluser12@gmail.com", true, "12", "Nguyen Van", false, null, "normaluser12@gmail.com", "normalUser12", "AQAAAAIAAYagAAAAEBhv8yKtzfveTs2EC6ipP5HvyTJKLr9wXDcCVnFp5ZCRPviduUJtPDQxrbNa21Xgyg==", null, false, "", false, "normalUser12" },
                    { 13, 0, "HCM", "c88f460f-44ab-4f5f-ad9c-0590d6420e5f", "normaluser13@gmail.com", true, "13", "Nguyen Van", false, null, "normaluser13@gmail.com", "normalUser13", "AQAAAAIAAYagAAAAEIB78sArqDPA8E6NP6GYQ308fsySmvaLy3N5e7Gm5KnioOPXNw5Bflb3YfNXHafvPQ==", null, false, "", false, "normalUser13" },
                    { 14, 0, "HCM", "b6dd5f9e-5723-464a-bf42-bf7f82e9dc5d", "normaluser14@gmail.com", true, "14", "Nguyen Van", false, null, "normaluser14@gmail.com", "normalUser14", "AQAAAAIAAYagAAAAEFb2PJ7ao3B9cQcDjqXZSb6IxKcOhw5mlP0G1dtjZVAyyr/ogZow1hLIts3i1MFy9Q==", null, false, "", false, "normalUser14" },
                    { 15, 0, "HCM", "c7dd77b0-c341-4fec-b415-d3f920a86ec0", "normaluser15@gmail.com", true, "15", "Nguyen Van", false, null, "normaluser15@gmail.com", "normalUser15", "AQAAAAIAAYagAAAAEINYfzyckzc/AzlF8Fi8vXtRFBPT8eMnIPBstr2CAFR2BJauVUMPVu4CN7chNr/Big==", null, false, "", false, "normalUser15" },
                    { 16, 0, "HCM", "faf24a30-7f74-4e44-9f7d-f69d53e44f51", "normaluser16@gmail.com", true, "16", "Nguyen Van", false, null, "normaluser16@gmail.com", "normalUser16", "AQAAAAIAAYagAAAAEFqro/G0OFvjSPyaQd1OLBBCwghGz82VrsAFc+oI7QENYMZ67Mm2SnOHQlbiOxTJ/Q==", null, false, "", false, "normalUser16" },
                    { 17, 0, "HCM", "9ffef8fd-e99c-484a-afd8-197013c96254", "normaluser17@gmail.com", true, "17", "Nguyen Van", false, null, "normaluser17@gmail.com", "normalUser17", "AQAAAAIAAYagAAAAECwfFQc1iFMVcNlnrRUedD2OYuTTHNEuD2sd24nb/gfDEUFH/HPWJqnbV43kkHXlYA==", null, false, "", false, "normalUser17" },
                    { 18, 0, "HCM", "b901931a-1b66-4abb-bc70-d9800574a405", "normaluser18@gmail.com", true, "18", "Nguyen Van", false, null, "normaluser18@gmail.com", "normalUser18", "AQAAAAIAAYagAAAAEObCas8gnQgG+5wWc8jQLgUIlpmoLh7uDujkL2QSTiygXQj2HXX/7kfobX/Y1LvCLQ==", null, false, "", false, "normalUser18" },
                    { 19, 0, "HCM", "6837afff-171b-4fe6-a275-cdf2756167e1", "normaluser19@gmail.com", true, "19", "Nguyen Van", false, null, "normaluser19@gmail.com", "normalUser19", "AQAAAAIAAYagAAAAENCpRZQYzYdsnP6O60gDHrQZmA/xhMI5bqLDOWxqJ070FQYp+wcuw5PvlnKiYFoBkA==", null, false, "", false, "normalUser19" },
                    { 20, 0, "HCM", "34c69d3b-a31e-4568-a4c6-b54d13623147", "normaluser20@gmail.com", true, "20", "Nguyen Van", false, null, "normaluser20@gmail.com", "normalUser20", "AQAAAAIAAYagAAAAEM2maYnrpDPSsXvYNmiV2RhJa9UIKP0TXXAHh6d8dW+Mz4XuTUiJ120K+kevEhL+pA==", null, false, "", false, "normalUser20" },
                    { 21, 0, "HCM", "2b139493-69ee-42b7-af81-f82d858d3eff", "normaluser21@gmail.com", true, "21", "Nguyen Van", false, null, "normaluser21@gmail.com", "normalUser21", "AQAAAAIAAYagAAAAELvXDtp8KyDUalbYLhK0qzxHJ3bRDy7AQcmmbS8caLDBBPacWBwxxVP7nm5P2xyk7Q==", null, false, "", false, "normalUser21" },
                    { 22, 0, "HCM", "23a7c9ba-9bf1-4f80-92fc-8a84fa2d825c", "normaluser22@gmail.com", true, "22", "Nguyen Van", false, null, "normaluser22@gmail.com", "normalUser22", "AQAAAAIAAYagAAAAEMpH9k5BkXsb5NCoYKNgnoXBA+9Hicgdz7RIdS9jd/jaiLo2WaokG3jLCY3h/ARlOw==", null, false, "", false, "normalUser22" },
                    { 23, 0, "HCM", "32ff43a0-5940-412f-a9ea-0f665fe8b786", "normaluser23@gmail.com", true, "23", "Nguyen Van", false, null, "normaluser23@gmail.com", "normalUser23", "AQAAAAIAAYagAAAAEAa0PaMRMQF+nKzuRSbaoOwZxZE8+FegJc0eeRHvLQxNJHNBitD6hBXsmiHxy2EJXA==", null, false, "", false, "normalUser23" },
                    { 24, 0, "HCM", "bb75a9fc-ab5f-45c1-a4d8-198694f4ed2c", "normaluser24@gmail.com", true, "24", "Nguyen Van", false, null, "normaluser24@gmail.com", "normalUser24", "AQAAAAIAAYagAAAAEOkfs1wSBcjqhGdH/xSFaLaqZ/rBkk+Ybh04Ogu0lkCFDsTfIeRhHqZgh6wzcymEog==", null, false, "", false, "normalUser24" },
                    { 25, 0, "HCM", "9f7f26b5-8ad3-4cb8-b3d3-3a146ffaaa38", "normaluser25@gmail.com", true, "25", "Nguyen Van", false, null, "normaluser25@gmail.com", "normalUser25", "AQAAAAIAAYagAAAAENTqM16MiLWkB2ZN94LuOaz8Q0SayVFQ5DGOZkxmLTm8D1+XqYex267e0joTBs6U2A==", null, false, "", false, "normalUser25" },
                    { 26, 0, "HCM", "c38a6b2e-288b-46db-acf4-ed5ddec8f2e9", "normaluser26@gmail.com", true, "26", "Nguyen Van", false, null, "normaluser26@gmail.com", "normalUser26", "AQAAAAIAAYagAAAAEKDjR12rOys6+m1wRJ0V/ahINqg5m4kJUdbDKRzcqqmhdRxmMx56XUzLsIxf2KH2UQ==", null, false, "", false, "normalUser26" },
                    { 27, 0, "HCM", "ff46e881-1411-4370-a34a-c3cec264dee7", "normaluser27@gmail.com", true, "27", "Nguyen Van", false, null, "normaluser27@gmail.com", "normalUser27", "AQAAAAIAAYagAAAAEEEZvAHtgDh1sTp/BpxLvNU3rV9k0XDOTV7l4OeUd2Gbkp6Jk30h9b8BcMvUoxnYzA==", null, false, "", false, "normalUser27" },
                    { 28, 0, "HCM", "e5157142-1144-4d8e-9f2e-65b2a780482b", "normaluser28@gmail.com", true, "28", "Nguyen Van", false, null, "normaluser28@gmail.com", "normalUser28", "AQAAAAIAAYagAAAAEODzjkBx5e2lp/TUrpOiV6wBcIf2Hm+m9+jRG2ZHy3OJbfLFQBCr2GBS7LFSebVTXw==", null, false, "", false, "normalUser28" },
                    { 29, 0, "HCM", "9e79213d-efb0-41eb-91f3-294197934636", "normaluser29@gmail.com", true, "29", "Nguyen Van", false, null, "normaluser29@gmail.com", "normalUser29", "AQAAAAIAAYagAAAAED66qs+psSPj1pmhy7QF8QHVkzUmNuPBFCUO18C2XupYMhmMSqrkaKwXtlsMik63pQ==", null, false, "", false, "normalUser29" },
                    { 30, 0, "HCM", "30ccf8e0-dc25-42e3-8fb5-c74d3cdaf0a5", "normaluser30@gmail.com", true, "30", "Nguyen Van", false, null, "normaluser30@gmail.com", "normalUser30", "AQAAAAIAAYagAAAAEL3SOFHpY2xiykPfxGulNmuGFztMxqge/LJjufumz7IjiLUSFhSPbadrJd7Pr2PB/w==", null, false, "", false, "normalUser30" },
                    { 31, 0, "HCM", "0f478caf-a7c4-4e2c-a542-c43ad9c20a8c", "normaluser31@gmail.com", true, "31", "Nguyen Van", false, null, "normaluser31@gmail.com", "normalUser31", "AQAAAAIAAYagAAAAELs8VEh5eQinq0nH6Tb8sX+4+/DnrtWsbKzMggDG5Qnhw/TkE2MewCMJNCzcx+wmUw==", null, false, "", false, "normalUser31" },
                    { 32, 0, "HCM", "cc6edc10-ea17-48da-95f9-5b64dd384d83", "normaluser32@gmail.com", true, "32", "Nguyen Van", false, null, "normaluser32@gmail.com", "normalUser32", "AQAAAAIAAYagAAAAEIAnXhqwRBdEgRNgja2/hlJuo5Nx3/hFMIvHYB9XIEu5ikwfnRB3Jjf2G6q7Xs74ww==", null, false, "", false, "normalUser32" },
                    { 33, 0, "HCM", "17545c9a-86eb-4112-b953-99dde372771b", "normaluser33@gmail.com", true, "33", "Nguyen Van", false, null, "normaluser33@gmail.com", "normalUser33", "AQAAAAIAAYagAAAAEEGh8+DvOAEqwSo/mRlG17j24yLgYZk/7WK2xEkWe/2kEJiUWmjGr4XkDwmYaUotsg==", null, false, "", false, "normalUser33" },
                    { 34, 0, "HCM", "0f74d136-4b7e-47a7-8da6-77d268d207a8", "normaluser34@gmail.com", true, "34", "Nguyen Van", false, null, "normaluser34@gmail.com", "normalUser34", "AQAAAAIAAYagAAAAEMXgUQGJ89g93krAZtcmXbu0q97yYwDr1KFVzyP4CQWOxtbxmWzbqDy57JVHk7kRwg==", null, false, "", false, "normalUser34" },
                    { 35, 0, "HCM", "efe7de41-a53b-4679-aebf-4f9b629c6a61", "normaluser35@gmail.com", true, "35", "Nguyen Van", false, null, "normaluser35@gmail.com", "normalUser35", "AQAAAAIAAYagAAAAEEuI/ABs98CP2H/sMSW5CuTib2l+HoVIliJjbb4r2YNpxGYZsb6b3026954Du8ETJQ==", null, false, "", false, "normalUser35" },
                    { 36, 0, "HCM", "b167b04d-10aa-4ea3-93a5-b7985070a85a", "normaluser36@gmail.com", true, "36", "Nguyen Van", false, null, "normaluser36@gmail.com", "normalUser36", "AQAAAAIAAYagAAAAEIAwBYJF2yoSfxWauLPcvia+sclUFdRwavA1t5CzDRmub5SlvoKZQLCsSZ2PxLYorg==", null, false, "", false, "normalUser36" },
                    { 37, 0, "HCM", "483c2df5-a5c7-46f0-84d8-73db981886d9", "normaluser37@gmail.com", true, "37", "Nguyen Van", false, null, "normaluser37@gmail.com", "normalUser37", "AQAAAAIAAYagAAAAEHtAVvZamMrjBo7FLbVz14x4yiSzSwhnpSh4/31uCYtKPTX02h821Y8zzzVruRf0WA==", null, false, "", false, "normalUser37" },
                    { 38, 0, "HCM", "49cf9279-f6c5-48f0-827f-5b61c4de32ba", "normaluser38@gmail.com", true, "38", "Nguyen Van", false, null, "normaluser38@gmail.com", "normalUser38", "AQAAAAIAAYagAAAAEMsDmZ4dkgovj9P8/wOtHC8KaWIq6LpiNUz/sdZ5cKFRqXMVB5HpSQDeyVUxPCjtJg==", null, false, "", false, "normalUser38" },
                    { 39, 0, "HCM", "b33149be-12a9-479f-9b5e-a10d8da17735", "normaluser39@gmail.com", true, "39", "Nguyen Van", false, null, "normaluser39@gmail.com", "normalUser39", "AQAAAAIAAYagAAAAEIi5l6q+s7mIHjTRVsl/d+ABuJ3yrenUjERuuwUBicpSytzn2nCNLDoeUZoJSwTB1w==", null, false, "", false, "normalUser39" },
                    { 40, 0, "HCM", "3bfdea66-1f8d-4bec-82f1-7d9e7fb22c09", "normaluser40@gmail.com", true, "40", "Nguyen Van", false, null, "normaluser40@gmail.com", "normalUser40", "AQAAAAIAAYagAAAAEO1342ucQP79/sCro7Li4U7Ty8kZYfLuvLicWeu9cmXVu1lrEuW5icMte0PqyGQN8g==", null, false, "", false, "normalUser40" },
                    { 41, 0, "HCM", "09755640-9eef-4400-8d43-6470bcba631e", "normaluser41@gmail.com", true, "41", "Nguyen Van", false, null, "normaluser41@gmail.com", "normalUser41", "AQAAAAIAAYagAAAAEDg6NlK3mR/8AqiEqE7Xx/tszxKyNf/3wNy+7y118NcV2bkUMAXEWck7QPzuytCO4g==", null, false, "", false, "normalUser41" },
                    { 42, 0, "HCM", "3ccd65cf-6f88-4220-9617-b8ad3e4ebeef", "normaluser42@gmail.com", true, "42", "Nguyen Van", false, null, "normaluser42@gmail.com", "normalUser42", "AQAAAAIAAYagAAAAED2NHJ525DbWnqOwFRvvTsgmBXSlyhvjPRSOzlppy3LxHcdXtjL3DQIUo31q81fvqw==", null, false, "", false, "normalUser42" },
                    { 43, 0, "HCM", "cbd045ca-28dc-4be3-b0f8-0dc912e5d231", "normaluser43@gmail.com", true, "43", "Nguyen Van", false, null, "normaluser43@gmail.com", "normalUser43", "AQAAAAIAAYagAAAAEOkyFQOqT66BHYHoNBAl36GyxWp/0Qpt5DI3Qs4rRJ6kvZ3ViAoYR2PxbvyAD7Grbg==", null, false, "", false, "normalUser43" },
                    { 44, 0, "HCM", "bb0ec365-bbf5-41f2-b1c2-45b8a502b3f4", "normaluser44@gmail.com", true, "44", "Nguyen Van", false, null, "normaluser44@gmail.com", "normalUser44", "AQAAAAIAAYagAAAAECsFCxRi24EtF4cNWFnhwej7rdb/8SoUgIrWdPifj0DAzcU1EXlWYoeL2mCKnFZsWw==", null, false, "", false, "normalUser44" },
                    { 45, 0, "HCM", "5bb37d63-35b3-4963-8cad-8a050a22c300", "normaluser45@gmail.com", true, "45", "Nguyen Van", false, null, "normaluser45@gmail.com", "normalUser45", "AQAAAAIAAYagAAAAEJiyPVCBGxn5mSr7VhmMbMPeSBLTsJ+kmuJQJElYPKKtxTP4Ko6CF7qGGu3xMsQIEw==", null, false, "", false, "normalUser45" },
                    { 46, 0, "HCM", "320fcbc0-aa0c-4670-8a01-a02da4233f1b", "normaluser46@gmail.com", true, "46", "Nguyen Van", false, null, "normaluser46@gmail.com", "normalUser46", "AQAAAAIAAYagAAAAECcfkhZjmi7s0iWBO3vYm+YrFbbK4RuAvxAHnyQAxxom6IMMaOtxPyrM7AYsENQCWA==", null, false, "", false, "normalUser46" },
                    { 47, 0, "HCM", "fa4c64ab-b2a6-4a9f-8a3e-f95552f55041", "normaluser47@gmail.com", true, "47", "Nguyen Van", false, null, "normaluser47@gmail.com", "normalUser47", "AQAAAAIAAYagAAAAEOOcJ4TKejK360Q515sqESj2O39O7IoIMEtztnPOz+yVwzaVipsr83J4H3g10L4h4Q==", null, false, "", false, "normalUser47" },
                    { 48, 0, "HCM", "ba8045d0-0983-42c7-9e83-e779a5682b97", "normaluser48@gmail.com", true, "48", "Nguyen Van", false, null, "normaluser48@gmail.com", "normalUser48", "AQAAAAIAAYagAAAAENmy8qocJ/Co6Oiumor02t1uULcu8cUXHxENQkSkJVuG8jp/y0yOe3Y+yNbGa5BmNA==", null, false, "", false, "normalUser48" },
                    { 49, 0, "HCM", "3e7b5aaf-060d-488d-925f-dfb48d11a20f", "normaluser49@gmail.com", true, "49", "Nguyen Van", false, null, "normaluser49@gmail.com", "normalUser49", "AQAAAAIAAYagAAAAELfF0W6uTQHDQMeD8oQKFyIrSDvyUbq/D0rML5Oxvltt+k5pAwYViYIccRvrmb8iRA==", null, false, "", false, "normalUser49" },
                    { 50, 0, "HCM", "04a86b7e-e08a-4aa6-a831-2b39083efb38", "normaluser50@gmail.com", true, "50", "Nguyen Van", false, null, "normaluser50@gmail.com", "normalUser50", "AQAAAAIAAYagAAAAEDH6yU30/SzGtkyswsTJELfMv3ccRwmLzELatolB9r6aF2WFl9SEYlbTqymeMJ1aXA==", null, false, "", false, "normalUser50" },
                    { 51, 0, "HCM", "bd1fbec6-0b4a-4976-9708-d28978e933fe", "normaluser51@gmail.com", true, "51", "Nguyen Van", false, null, "normaluser51@gmail.com", "normalUser51", "AQAAAAIAAYagAAAAEKt7rTemo/xsFkgUEDrwD1fQ4Sywo0VQMOpqUrVBvltFYUsTakL4rUqvxrX9zjoZaw==", null, false, "", false, "normalUser51" },
                    { 52, 0, "HCM", "fc2ea547-e48e-48c2-96b0-b1a2532b0704", "normaluser52@gmail.com", true, "52", "Nguyen Van", false, null, "normaluser52@gmail.com", "normalUser52", "AQAAAAIAAYagAAAAEA7Ti5z3Lp4IEiGGOFyJqRmqqRPSauH8cRmIgZX8+hjRHB3MFOC+CdckOfvI1rsO1g==", null, false, "", false, "normalUser52" },
                    { 53, 0, "HCM", "e92c3a26-0087-4803-9dc1-d428f07dc073", "normaluser53@gmail.com", true, "53", "Nguyen Van", false, null, "normaluser53@gmail.com", "normalUser53", "AQAAAAIAAYagAAAAEAYqug20ykjywGOpEIbSzz8c91jx06XRd/tus+K3E3INHbBknWYVTxA61iXjQ1lPBw==", null, false, "", false, "normalUser53" },
                    { 54, 0, "HCM", "5232c6d5-ac1e-4dd7-84e3-5b2f2176e2b2", "normaluser54@gmail.com", true, "54", "Nguyen Van", false, null, "normaluser54@gmail.com", "normalUser54", "AQAAAAIAAYagAAAAELIAdxYpbRAkp2YTF8jsUsWxMczqKBovpJEU0X6jAckW42J5cM4OPA5IuqysZwKLtg==", null, false, "", false, "normalUser54" },
                    { 55, 0, "HCM", "2f786b82-a42b-4d4a-b5b9-02b94f7cf0c0", "normaluser55@gmail.com", true, "55", "Nguyen Van", false, null, "normaluser55@gmail.com", "normalUser55", "AQAAAAIAAYagAAAAEEwZL286a4nDmwvNFD9G942V59iNYktNmy67Dy1MVJoUj7S3hq+o73cySarz3/VPQA==", null, false, "", false, "normalUser55" },
                    { 56, 0, "HCM", "0d7671d6-0f29-4752-bd03-c43b0d1595c7", "normaluser56@gmail.com", true, "56", "Nguyen Van", false, null, "normaluser56@gmail.com", "normalUser56", "AQAAAAIAAYagAAAAENwbqkRHY2qerbkx+ALhG3Z7k2dkdWZHtmj6douwfG3K/8AN24EkHo3QERy6FHREvg==", null, false, "", false, "normalUser56" },
                    { 57, 0, "HCM", "52758abd-0bcf-49ef-a4dc-2b9cfa5ec1b8", "normaluser57@gmail.com", true, "57", "Nguyen Van", false, null, "normaluser57@gmail.com", "normalUser57", "AQAAAAIAAYagAAAAEJguxjjkPNVm0cETUe46GvalFirc2sL8tuhqxw0ZykbrxRkzhtZiLCE5FlVg5Kb21g==", null, false, "", false, "normalUser57" },
                    { 58, 0, "HCM", "30d812d9-c7ee-478e-8e34-89962a568e9a", "normaluser58@gmail.com", true, "58", "Nguyen Van", false, null, "normaluser58@gmail.com", "normalUser58", "AQAAAAIAAYagAAAAEAg6rNGcnplf8BIO7ayaf5zV0uAN1lH2ULfKoYx5XbfJfbGpWpWvU2eOAYekyE4WdQ==", null, false, "", false, "normalUser58" },
                    { 59, 0, "HCM", "2209c1ae-c486-4fa9-8b37-f22aebd87dd6", "normaluser59@gmail.com", true, "59", "Nguyen Van", false, null, "normaluser59@gmail.com", "normalUser59", "AQAAAAIAAYagAAAAEOKIWwdMuTu6GeNbQhK7xgAKtmxeKjLDp39dDVhFhy5uJH3VSLI2WEWreCWeQhSJyQ==", null, false, "", false, "normalUser59" },
                    { 60, 0, "HCM", "234b5f6c-1992-4e8e-bacc-38603a34cf0a", "normaluser60@gmail.com", true, "60", "Nguyen Van", false, null, "normaluser60@gmail.com", "normalUser60", "AQAAAAIAAYagAAAAECOF2WXkjyYZmTqa/dZ52Rpq7bU86rJKrTg/x8yJmSceAF0M7hKbg+fpTcJjUwMbzg==", null, false, "", false, "normalUser60" },
                    { 61, 0, "HCM", "339dd50c-1067-4b84-b139-d18c643d7770", "normaluser61@gmail.com", true, "61", "Nguyen Van", false, null, "normaluser61@gmail.com", "normalUser61", "AQAAAAIAAYagAAAAEBz2YaOkHxj6x0COXMxpIS0RCm7K600oR5vunG9BdJI41OyRCLga0CJmQgs0yM1FjA==", null, false, "", false, "normalUser61" },
                    { 62, 0, "HCM", "fd950ba7-571b-42ed-9371-e0d32ee64f4a", "normaluser62@gmail.com", true, "62", "Nguyen Van", false, null, "normaluser62@gmail.com", "normalUser62", "AQAAAAIAAYagAAAAEL2PBgZdoE1f7vw6LpJzf7sukQDFtrFr1R6AYdQk2vVy2sXDOA5qmcXmgzL3TDOOLg==", null, false, "", false, "normalUser62" },
                    { 63, 0, "HCM", "e5cdf38e-7962-4e7a-a3b9-870d6f7993f5", "normaluser63@gmail.com", true, "63", "Nguyen Van", false, null, "normaluser63@gmail.com", "normalUser63", "AQAAAAIAAYagAAAAEGiwdRugoTWmhE4W3DhPW+eU6nm4y6fH9sk1mxbsxc1R01V5vQN00xg0ud1gStjhLQ==", null, false, "", false, "normalUser63" },
                    { 64, 0, "HCM", "8454151f-2e2c-4a7d-aad5-58cd169eb3b9", "normaluser64@gmail.com", true, "64", "Nguyen Van", false, null, "normaluser64@gmail.com", "normalUser64", "AQAAAAIAAYagAAAAENUu+sVRGWo/N50r+B+2wddYFyXqEEYaxv0DLaeXaCOdn4HMQTXDgZFJsgynZPyJZw==", null, false, "", false, "normalUser64" },
                    { 65, 0, "HCM", "21737007-e754-4de5-8801-104239a0f999", "normaluser65@gmail.com", true, "65", "Nguyen Van", false, null, "normaluser65@gmail.com", "normalUser65", "AQAAAAIAAYagAAAAEHQhYJwuRO0bltX8A/PAa7170csiK85VYbLZtI1E1gZDGLwZZZi5xLviII5uPVYEQw==", null, false, "", false, "normalUser65" }
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
                    { 1, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 30, new DateTime(2023, 6, 4, 22, 17, 23, 911, DateTimeKind.Local).AddTicks(9781), "This a simple description for project 1", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 1", 99.0 },
                    { 2, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 4, 22, 17, 23, 911, DateTimeKind.Local).AddTicks(9854), "This a simple description for project 2", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 2", 198.0 },
                    { 3, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 4, 22, 17, 23, 911, DateTimeKind.Local).AddTicks(9865), "This a simple description for project 3", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 3", 297.0 },
                    { 4, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 4, 22, 17, 23, 911, DateTimeKind.Local).AddTicks(9875), "This a simple description for project 4", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 4", 396.0 },
                    { 5, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 4, 22, 17, 23, 911, DateTimeKind.Local).AddTicks(9884), "This a simple description for project 5", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 5", 495.0 },
                    { 6, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 4, 22, 17, 23, 911, DateTimeKind.Local).AddTicks(9895), "This a simple description for project 6", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 6", 594.0 },
                    { 7, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 4, 22, 17, 23, 911, DateTimeKind.Local).AddTicks(9904), "This a simple description for project 7", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 7", 693.0 },
                    { 8, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 4, 22, 17, 23, 911, DateTimeKind.Local).AddTicks(9967), "This a simple description for project 8", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 8", 792.0 },
                    { 9, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 4, 22, 17, 23, 911, DateTimeKind.Local).AddTicks(9977), "This a simple description for project 9", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 9", 891.0 },
                    { 10, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 4, 22, 17, 23, 911, DateTimeKind.Local).AddTicks(9989), "This a simple description for project 10", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 10", 990.0 },
                    { 11, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 4, 22, 17, 23, 911, DateTimeKind.Local).AddTicks(9999), "This a simple description for project 11", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 11", 1089.0 },
                    { 12, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(8), "This a simple description for project 12", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 12", 1188.0 },
                    { 13, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(18), "This a simple description for project 13", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 13", 1287.0 },
                    { 14, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(27), "This a simple description for project 14", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 14", 1386.0 },
                    { 15, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(37), "This a simple description for project 15", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 15", 1485.0 },
                    { 16, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(125), "This a simple description for project 16", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 16", 1584.0 },
                    { 17, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(182), "This a simple description for project 17", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 17", 1683.0 },
                    { 18, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(195), "This a simple description for project 18", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 18", 1782.0 },
                    { 19, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 33, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(204), "This a simple description for project 19", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 19", 1881.0 },
                    { 20, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(214), "This a simple description for project 20", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 20", 1980.0 },
                    { 21, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(224), "This a simple description for project 21", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 21", 2079.0 },
                    { 22, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(234), "This a simple description for project 22", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 22", 2178.0 },
                    { 23, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(244), "This a simple description for project 23", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 23", 2277.0 },
                    { 24, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(253), "This a simple description for project 24", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 24", 2376.0 },
                    { 25, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(263), "This a simple description for project 25", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 25", 2475.0 },
                    { 26, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(273), "This a simple description for project 26", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 26", 2574.0 },
                    { 27, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(328), "This a simple description for project 27", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 27", 2673.0 },
                    { 28, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(338), "This a simple description for project 28", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 28", 2772.0 },
                    { 29, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(347), "This a simple description for project 29", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 29", 2871.0 },
                    { 30, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(372), "This a simple description for project 30", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 30", 2970.0 },
                    { 31, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(395), "This a simple description for project 31", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 31", 3069.0 },
                    { 32, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 30, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(405), "This a simple description for project 32", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 32", 3168.0 },
                    { 33, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(414), "This a simple description for project 33", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 33", 3267.0 },
                    { 34, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(425), "This a simple description for project 34", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 34", 3366.0 },
                    { 35, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(475), "This a simple description for project 35", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 35", 3465.0 },
                    { 36, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(488), "This a simple description for project 36", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 36", 3564.0 },
                    { 37, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(498), "This a simple description for project 37", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 37", 3663.0 },
                    { 38, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(509), "This a simple description for project 38", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 38", 3762.0 },
                    { 39, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(519), "This a simple description for project 39", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 39", 3861.0 },
                    { 40, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(530), "This a simple description for project 40", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 40", 3960.0 },
                    { 41, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(541), "This a simple description for project 41", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 41", 4059.0 },
                    { 42, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(552), "This a simple description for project 42", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 42", 4158.0 },
                    { 43, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(563), "This a simple description for project 43", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 43", 4257.0 },
                    { 44, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(570), "This a simple description for project 44", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 44", 4356.0 },
                    { 45, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 32, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(617), "This a simple description for project 45", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 45", 4455.0 },
                    { 46, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(625), "This a simple description for project 46", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 46", 4554.0 },
                    { 47, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(632), "This a simple description for project 47", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 47", 4653.0 },
                    { 48, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 30, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(640), "This a simple description for project 48", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 48", 4752.0 },
                    { 49, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(646), "This a simple description for project 49", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 49", 4851.0 },
                    { 50, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(653), "This a simple description for project 50", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 50", 4950.0 },
                    { 51, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 30, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(659), "This a simple description for project 51", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 51", 5049.0 },
                    { 52, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(666), "This a simple description for project 52", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 52", 5148.0 },
                    { 53, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(673), "This a simple description for project 53", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 53", 5247.0 },
                    { 54, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 30, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(680), "This a simple description for project 54", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 54", 5346.0 },
                    { 55, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(764), "This a simple description for project 55", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 55", 5445.0 },
                    { 56, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(771), "This a simple description for project 56", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 56", 5544.0 },
                    { 57, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(778), "This a simple description for project 57", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 57", 5643.0 },
                    { 58, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 33, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(784), "This a simple description for project 58", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 58", 5742.0 },
                    { 59, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(791), "This a simple description for project 59", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 59", 5841.0 },
                    { 60, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(797), "This a simple description for project 60", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 60", 5940.0 },
                    { 61, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(804), "This a simple description for project 61", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 61", 6039.0 },
                    { 62, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(810), "This a simple description for project 62", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 62", 6138.0 },
                    { 63, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(817), "This a simple description for project 63", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 63", 6237.0 },
                    { 64, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(855), "This a simple description for project 64", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 64", 6336.0 },
                    { 65, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(863), "This a simple description for project 65", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 65", 6435.0 },
                    { 66, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(871), "This a simple description for project 66", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 66", 6534.0 },
                    { 67, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(878), "This a simple description for project 67", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 67", 6633.0 },
                    { 68, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(885), "This a simple description for project 68", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 68", 6732.0 },
                    { 69, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(891), "This a simple description for project 69", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 69", 6831.0 },
                    { 70, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(898), "This a simple description for project 70", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 70", 6930.0 },
                    { 71, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 32, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(905), "This a simple description for project 71", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 71", 7029.0 },
                    { 72, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(943), "This a simple description for project 72", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 72", 7128.0 },
                    { 73, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(950), "This a simple description for project 73", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 73", 7227.0 },
                    { 74, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(956), "This a simple description for project 74", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 74", 7326.0 },
                    { 75, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(963), "This a simple description for project 75", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 75", 7425.0 },
                    { 76, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(969), "This a simple description for project 76", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 76", 7524.0 },
                    { 77, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(976), "This a simple description for project 77", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 77", 7623.0 },
                    { 78, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(982), "This a simple description for project 78", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 78", 7722.0 },
                    { 79, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(989), "This a simple description for project 79", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 79", 7821.0 },
                    { 80, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(995), "This a simple description for project 80", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 80", 7920.0 },
                    { 81, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(1002), "This a simple description for project 81", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 81", 8019.0 },
                    { 82, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(1040), "This a simple description for project 82", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 82", 8118.0 },
                    { 83, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(1046), "This a simple description for project 83", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 83", 8217.0 },
                    { 84, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(1053), "This a simple description for project 84", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 84", 8316.0 },
                    { 85, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(1145), "This a simple description for project 85", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 85", 8415.0 },
                    { 86, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(1152), "This a simple description for project 86", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 86", 8514.0 },
                    { 87, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(1159), "This a simple description for project 87", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 87", 8613.0 },
                    { 88, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(1165), "This a simple description for project 88", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 88", 8712.0 },
                    { 89, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(1172), "This a simple description for project 89", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 89", 8811.0 },
                    { 90, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(1179), "This a simple description for project 90", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 90", 8910.0 },
                    { 91, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(1364), "This a simple description for project 91", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 91", 9009.0 },
                    { 92, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(1377), "This a simple description for project 92", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 92", 9108.0 },
                    { 93, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(1383), "This a simple description for project 93", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 93", 9207.0 },
                    { 94, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(1390), "This a simple description for project 94", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 94", 9306.0 },
                    { 95, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(1397), "This a simple description for project 95", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 95", 9405.0 },
                    { 96, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(1403), "This a simple description for project 96", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 96", 9504.0 },
                    { 97, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(1410), "This a simple description for project 97", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 97", 9603.0 },
                    { 98, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(1416), "This a simple description for project 98", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 98", 9702.0 },
                    { 99, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(1423), "This a simple description for project 99", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 99", 9801.0 },
                    { 100, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 4, 22, 17, 23, 912, DateTimeKind.Local).AddTicks(1430), "This a simple description for project 100", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 100", 9900.0 }
                });

            migrationBuilder.InsertData(
                table: "JobCategories",
                columns: new[] { "CategoryId", "JobId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 4, 2 },
                    { 3, 3 },
                    { 5, 4 },
                    { 6, 5 },
                    { 2, 6 },
                    { 7, 7 },
                    { 5, 8 },
                    { 1, 9 },
                    { 4, 10 },
                    { 6, 11 },
                    { 7, 12 },
                    { 3, 13 },
                    { 7, 14 },
                    { 6, 15 },
                    { 5, 16 },
                    { 6, 17 },
                    { 3, 18 },
                    { 7, 19 },
                    { 2, 20 },
                    { 5, 21 },
                    { 7, 22 },
                    { 1, 23 },
                    { 4, 24 },
                    { 4, 25 },
                    { 1, 26 },
                    { 3, 27 },
                    { 2, 28 },
                    { 3, 29 },
                    { 7, 30 },
                    { 4, 31 },
                    { 5, 32 },
                    { 2, 33 },
                    { 5, 34 },
                    { 1, 35 },
                    { 5, 36 },
                    { 3, 37 },
                    { 5, 38 },
                    { 6, 39 },
                    { 1, 40 },
                    { 3, 41 },
                    { 5, 42 },
                    { 2, 43 },
                    { 1, 44 },
                    { 4, 45 },
                    { 5, 46 },
                    { 2, 47 },
                    { 5, 48 },
                    { 5, 49 },
                    { 3, 50 },
                    { 7, 51 },
                    { 4, 52 },
                    { 1, 53 },
                    { 5, 54 },
                    { 1, 55 },
                    { 7, 56 },
                    { 2, 57 },
                    { 1, 58 },
                    { 6, 59 },
                    { 1, 60 },
                    { 3, 61 },
                    { 5, 62 },
                    { 4, 63 },
                    { 7, 64 },
                    { 3, 65 },
                    { 6, 66 },
                    { 6, 67 },
                    { 1, 68 },
                    { 5, 69 },
                    { 2, 70 },
                    { 1, 71 },
                    { 6, 72 },
                    { 3, 73 },
                    { 6, 74 },
                    { 3, 75 },
                    { 7, 76 },
                    { 1, 77 },
                    { 7, 78 },
                    { 2, 79 },
                    { 2, 80 },
                    { 5, 81 },
                    { 3, 82 },
                    { 2, 83 },
                    { 1, 84 },
                    { 2, 85 },
                    { 3, 86 },
                    { 5, 87 },
                    { 5, 88 },
                    { 2, 89 },
                    { 6, 90 },
                    { 7, 91 },
                    { 4, 92 },
                    { 4, 93 },
                    { 6, 94 },
                    { 6, 95 },
                    { 5, 96 },
                    { 1, 97 },
                    { 2, 98 },
                    { 4, 99 },
                    { 6, 100 }
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
