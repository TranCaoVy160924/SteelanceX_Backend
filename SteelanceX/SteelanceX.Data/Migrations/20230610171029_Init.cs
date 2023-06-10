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
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "IsPremium", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "HCM", "a6afaf44-1808-4f9a-9e7f-ce9ccb0c3521", "adminhcm@gmail.com", true, "Toan", false, "Bach", false, null, "adminhcm@gmail.com", "adminhcm", "AQAAAAIAAYagAAAAEK5iUCqATAHCgzKkvCGrWjjxSxll22oDgCPFQtCxsp6nfqGnfka9glx/P12Zv8ZTKA==", null, false, "", false, "adminhcm" },
                    { 2, 0, "HCM", "1ba9c239-4fd9-4500-9c2a-f8ee6f3b777c", "adminhn@gmail.com", true, "Toan", false, "Bach", false, null, "adminhn@gmail.com", "adminhn", "AQAAAAIAAYagAAAAEKocT5hpKXpSX4wk9fKYjz/bCrIZ/J4fLcoBh9uVMRfE11CTPAKqXzmlQeu96bbBrw==", null, false, "", false, "adminhn" },
                    { 3, 0, "HCM", "47e330d3-5ea9-4780-8369-919142d74067", "staff@gmail.com", true, "Toan", false, "Bach", false, null, "staff@gmail.com", "staff1", "AQAAAAIAAYagAAAAEKmp2H6wa95U6x47YTsBFSewavM/Qsha5QwCEPpgbT+RpphdHm00OPvGh5hODFBUhQ==", null, false, "", false, "staff1" },
                    { 4, 0, "HCM", "cc52602e-dc36-4872-b15f-f2a373c76018", "staff@gmail.com", true, "Toan", false, "Bach", false, null, "staff@gmail.com", "staff2", "AQAAAAIAAYagAAAAEIKzvDjVWKRpucDF9Dzr5JJm8Rk0gPfLAEuUZj/wM43+m8a6HmgX1aYj0JrVgmaoEQ==", null, false, "", false, "staff2" },
                    { 5, 0, "HCM", "6ac5d0da-72db-40b7-965e-3ab05c4b854a", "staffdis@gmail.com", true, "Toan", false, "Bach", false, null, "staffdis@gmail.com", "staffdis", "AQAAAAIAAYagAAAAENGv0Fx2tU38zSLzV1QYXkVDaN/JWrzaCmVYK/ixebpYa5jAodHjC5lX8fIaA991lA==", null, false, "", false, "staffDis" },
                    { 6, 0, "HCM", "9f8a0958-76a1-4b0e-91d0-e138cefa49c2", "normaluser6@gmail.com", true, "6", false, "Nguyen Van", false, null, "normaluser6@gmail.com", "normalUser6", "AQAAAAIAAYagAAAAEB4pOb4oBLSQZVNS6QC4Evp+rzEqyh9X/cTXy8GLgs3qLMRPOwzyo9PdeI4HDE99nA==", null, false, "", false, "normalUser6" },
                    { 7, 0, "HCM", "bbf1ce87-f1fd-428a-a124-59954af8cf1a", "normaluser7@gmail.com", true, "7", false, "Nguyen Van", false, null, "normaluser7@gmail.com", "normalUser7", "AQAAAAIAAYagAAAAEKrB3Uy8ccFSQaBhVQNk8xxEbgpobvXQE4jAZY4IfzTQ/BhC2b8IwMLB/eTDO6AUKw==", null, false, "", false, "normalUser7" },
                    { 8, 0, "HCM", "df1eee22-5cd8-49c3-b8c5-7c56e202c6ac", "normaluser8@gmail.com", true, "8", false, "Nguyen Van", false, null, "normaluser8@gmail.com", "normalUser8", "AQAAAAIAAYagAAAAEMd/YhPNvRbk/P6v3r0ZSpebBy90Z8qHh0QZ8Z/nhPA2PdZ+y6Px/5pQBoDOIE2EKQ==", null, false, "", false, "normalUser8" },
                    { 9, 0, "HCM", "0b434057-c8c9-4f9a-9efe-ab30640e396c", "normaluser9@gmail.com", true, "9", false, "Nguyen Van", false, null, "normaluser9@gmail.com", "normalUser9", "AQAAAAIAAYagAAAAEF5wijvmaas+WuJGNok+MLz2EnsbWp9tSdW/I9Gh7gkJ+Ci0voNpAXxvX82FYUH1gQ==", null, false, "", false, "normalUser9" },
                    { 10, 0, "HCM", "b101e606-7ac2-4e0d-8dc2-3557023c9d14", "normaluser10@gmail.com", true, "10", false, "Nguyen Van", false, null, "normaluser10@gmail.com", "normalUser10", "AQAAAAIAAYagAAAAEL8qllSX0u8QV3D/oO5z2w5NJLclixT3DVLKM+AGqb2R+Ot1cVJoQ+dOrbdhIMTxjQ==", null, false, "", false, "normalUser10" },
                    { 11, 0, "HCM", "696b6b49-4ff1-4759-bf53-544fa2bb32b5", "normaluser11@gmail.com", true, "11", false, "Nguyen Van", false, null, "normaluser11@gmail.com", "normalUser11", "AQAAAAIAAYagAAAAEFDZgDs0r5BCFCQFsZ0lhYbNjwbd6z7gcWah7OhH4T/pc4XQg3vlyT6C4IKJcAMblg==", null, false, "", false, "normalUser11" },
                    { 12, 0, "HCM", "d563f30c-fae2-457b-aa4b-3e6b50b55ddb", "normaluser12@gmail.com", true, "12", false, "Nguyen Van", false, null, "normaluser12@gmail.com", "normalUser12", "AQAAAAIAAYagAAAAEFku48Sj3uDcepwbTouxnYcNKzNSxouy0C707lqVHhR35TZHhzuNuNxNUkq4sXubdQ==", null, false, "", false, "normalUser12" },
                    { 13, 0, "HCM", "a77e6c0a-406e-41b5-9e60-26eb3328beec", "normaluser13@gmail.com", true, "13", false, "Nguyen Van", false, null, "normaluser13@gmail.com", "normalUser13", "AQAAAAIAAYagAAAAEFGTi+MKGm/r6mV54LDtuKGCnj03AAH1G7vW5izlQi5qhOfRWoWHWY9L1mz2qoPjnw==", null, false, "", false, "normalUser13" },
                    { 14, 0, "HCM", "ffb0bc21-44eb-4561-bdf3-2ce4877d8936", "normaluser14@gmail.com", true, "14", false, "Nguyen Van", false, null, "normaluser14@gmail.com", "normalUser14", "AQAAAAIAAYagAAAAEBoL8eCcJkgfsu//NPqjTKV8cScUYcpGLAc4HeSt+eZOkGVIwlYlzzk1o0bQWWylig==", null, false, "", false, "normalUser14" },
                    { 15, 0, "HCM", "ca0c401d-14df-4c8a-a100-25bbd11f05e9", "normaluser15@gmail.com", true, "15", false, "Nguyen Van", false, null, "normaluser15@gmail.com", "normalUser15", "AQAAAAIAAYagAAAAEAkE++JvZnaMbZyuVdc+e7Xm2PPGLQRRqZ+fS7pu2BEB5+c3zk2YW+2jd4YM/ZI2PA==", null, false, "", false, "normalUser15" },
                    { 16, 0, "HCM", "66510078-c377-4e05-9519-dab81d2dd2e8", "normaluser16@gmail.com", true, "16", false, "Nguyen Van", false, null, "normaluser16@gmail.com", "normalUser16", "AQAAAAIAAYagAAAAEADNsrO6QF/JQRC9mVh9km0YWaMc+4ZaGIej/artFzS6DTtjyX6WeQTLHpQH1Tiy+A==", null, false, "", false, "normalUser16" },
                    { 17, 0, "HCM", "9fe4733d-a8a6-409a-9ead-c84a77fb5069", "normaluser17@gmail.com", true, "17", false, "Nguyen Van", false, null, "normaluser17@gmail.com", "normalUser17", "AQAAAAIAAYagAAAAELvvJVY+vzTAuwYhz74mTU7Z1GIpiwUliGhPcZ+gmGwq23YiXkrnytIMTrmemfykTg==", null, false, "", false, "normalUser17" },
                    { 18, 0, "HCM", "6c8bde71-7c2e-43ea-92ac-4b62239048aa", "normaluser18@gmail.com", true, "18", false, "Nguyen Van", false, null, "normaluser18@gmail.com", "normalUser18", "AQAAAAIAAYagAAAAEOro5q27nXZbxwryypCJ1gQUpeFt9ZjpqHIZw2X47ZouJrkXenT93cZtJ/exSu+xJw==", null, false, "", false, "normalUser18" },
                    { 19, 0, "HCM", "6c4d6eb4-5d34-4b4e-ba77-420f4779719f", "normaluser19@gmail.com", true, "19", false, "Nguyen Van", false, null, "normaluser19@gmail.com", "normalUser19", "AQAAAAIAAYagAAAAED5sYnaKu6obNRN33PRiMTYIIwXONiB0ahYnEd9yyFpgG1dIFBatdcM6HlKcNg83vA==", null, false, "", false, "normalUser19" },
                    { 20, 0, "HCM", "52d09a71-0dd2-40bf-a641-e9cf3c938d1a", "normaluser20@gmail.com", true, "20", false, "Nguyen Van", false, null, "normaluser20@gmail.com", "normalUser20", "AQAAAAIAAYagAAAAEI1lzDKUmFu3cl5D1qpNp+6IA8/nv1Seapgtb+EDYNkdY7kRDlg1ih2/Cg3XvJGpqg==", null, false, "", false, "normalUser20" },
                    { 21, 0, "HCM", "077e4afc-1263-49aa-9301-c43f0e006f7e", "normaluser21@gmail.com", true, "21", false, "Nguyen Van", false, null, "normaluser21@gmail.com", "normalUser21", "AQAAAAIAAYagAAAAEBklUuKKLM08pG0n6N5JcxwTzApJXjI7DmDKcISSZ+DL4QWGRAeoUNFTv55pMIXIAA==", null, false, "", false, "normalUser21" },
                    { 22, 0, "HCM", "8a7cc237-aa6c-4e68-bf52-d4a87720afc5", "normaluser22@gmail.com", true, "22", false, "Nguyen Van", false, null, "normaluser22@gmail.com", "normalUser22", "AQAAAAIAAYagAAAAEG0na5MXnUWud1aT3HcuNZgsPh/t8BntebfDAo4pjM6FHnLPqRGUbVz3KiDE7Y+cIw==", null, false, "", false, "normalUser22" },
                    { 23, 0, "HCM", "1a9e4020-4360-47bf-845b-9305cc82ac84", "normaluser23@gmail.com", true, "23", false, "Nguyen Van", false, null, "normaluser23@gmail.com", "normalUser23", "AQAAAAIAAYagAAAAELLaVbV6Hnc26Qnpzh92AQ0pew8VB6Ti++tJe/CUpBxWbbLvv94/AIsZwzwG38LLhg==", null, false, "", false, "normalUser23" },
                    { 24, 0, "HCM", "2c017b48-0055-45cf-9c30-00b60573f8a4", "normaluser24@gmail.com", true, "24", false, "Nguyen Van", false, null, "normaluser24@gmail.com", "normalUser24", "AQAAAAIAAYagAAAAEI1XgXsgNCEdPptcvDqxwSK/7KV8UkVdm3CmuE9f1d/uXxOqZsJZ5WZnfCmBwrzL5w==", null, false, "", false, "normalUser24" },
                    { 25, 0, "HCM", "fb122551-5ba9-4a33-ba30-48480f3630d4", "normaluser25@gmail.com", true, "25", false, "Nguyen Van", false, null, "normaluser25@gmail.com", "normalUser25", "AQAAAAIAAYagAAAAEMp7wruaUnhgx6sjoOrn9QWANr+X2U2Cavlx75UyndY9di5fSJ8SeAip8tcVIZbLVA==", null, false, "", false, "normalUser25" },
                    { 26, 0, "HCM", "63355b69-c857-48e4-aea3-d9f10a4b0c40", "normaluser26@gmail.com", true, "26", false, "Nguyen Van", false, null, "normaluser26@gmail.com", "normalUser26", "AQAAAAIAAYagAAAAENhBVYYMfotR0yr1dhFlMYbCFNunjShfvrqQcDhclmt5TQqAZ3ZcWMoIJUtvqrAn3w==", null, false, "", false, "normalUser26" },
                    { 27, 0, "HCM", "23d01356-955b-4a87-8165-c99a1986a47b", "normaluser27@gmail.com", true, "27", false, "Nguyen Van", false, null, "normaluser27@gmail.com", "normalUser27", "AQAAAAIAAYagAAAAEE9sY9vWDpaZufr8rGZZe3XFl8ovC8TqODrJ0N23qO8RZCXt/S1fCO4XqFHu3NZpVw==", null, false, "", false, "normalUser27" },
                    { 28, 0, "HCM", "b62cff88-1081-44d5-80e2-e1a92e82cddf", "normaluser28@gmail.com", true, "28", false, "Nguyen Van", false, null, "normaluser28@gmail.com", "normalUser28", "AQAAAAIAAYagAAAAEFqAkdRLx71+hIYvnTehaMWHHMCeXQpFdOWDUfdgQvj7vF7ulkvZHARU+fi/MH3d5Q==", null, false, "", false, "normalUser28" },
                    { 29, 0, "HCM", "0ef90d7e-17ce-4b3d-9499-5e5342dea9bb", "normaluser29@gmail.com", true, "29", false, "Nguyen Van", false, null, "normaluser29@gmail.com", "normalUser29", "AQAAAAIAAYagAAAAEBHO5HwhUOlz53ieo4T63ckndHz8MTWCdK1qVVTiQUitF3sSaPWmlHrXn0Htz+8J7A==", null, false, "", false, "normalUser29" },
                    { 30, 0, "HCM", "5ababfab-0b7d-4d73-8315-1f8c96a66aee", "normaluser30@gmail.com", true, "30", false, "Nguyen Van", false, null, "normaluser30@gmail.com", "normalUser30", "AQAAAAIAAYagAAAAEGLbf1glH33U6z1pnFlrc+irM+5o6Sa5cNwlTHm3Ro4XaZdDEbtFCWND86bFmrC82g==", null, false, "", false, "normalUser30" },
                    { 31, 0, "HCM", "67a35d8f-72ab-47e0-9a19-35596e15f596", "normaluser31@gmail.com", true, "31", false, "Nguyen Van", false, null, "normaluser31@gmail.com", "normalUser31", "AQAAAAIAAYagAAAAEDssiBxl3Lq3LjDm4FYMwLWvN14YUSbhHkeZlJ0XxPppJP/7CPvlSGWsnFXSauSSvg==", null, false, "", false, "normalUser31" },
                    { 32, 0, "HCM", "683fb2ce-3bfe-4534-b8c7-3c54335d544c", "normaluser32@gmail.com", true, "32", false, "Nguyen Van", false, null, "normaluser32@gmail.com", "normalUser32", "AQAAAAIAAYagAAAAEPywy6ZGmaUTsxPK7wvkTUK1O5otAlgkZyKll/XMyg4IX4Lfg0ubixRLNto0CLaj5A==", null, false, "", false, "normalUser32" },
                    { 33, 0, "HCM", "64c08909-f49b-467e-8545-e319e547f010", "normaluser33@gmail.com", true, "33", false, "Nguyen Van", false, null, "normaluser33@gmail.com", "normalUser33", "AQAAAAIAAYagAAAAEJRnMsFAGdraryiYBDz1nGcUmmx2UjILbd9UUeP+vaUAnGiawpASx7+JN9kXlpG4Jg==", null, false, "", false, "normalUser33" },
                    { 34, 0, "HCM", "a8a3d1ae-5828-4fb0-9b05-988b0d95881d", "normaluser34@gmail.com", true, "34", false, "Nguyen Van", false, null, "normaluser34@gmail.com", "normalUser34", "AQAAAAIAAYagAAAAEBg6hhpJjWTHL/rq2qlsP6uF49QfUryR9n0NewMHnx45InWZdAQzWPIJ3gbou3HOfw==", null, false, "", false, "normalUser34" },
                    { 35, 0, "HCM", "9a792708-9d26-40e8-92e5-a7c9084000c2", "normaluser35@gmail.com", true, "35", false, "Nguyen Van", false, null, "normaluser35@gmail.com", "normalUser35", "AQAAAAIAAYagAAAAED22J58W1MqG9653gaVq0P4rpzuNCJmoLYaiEyRixrCrvoB95++eNc9Pl5bLWXkBUg==", null, false, "", false, "normalUser35" },
                    { 36, 0, "HCM", "fa6850e9-f2f9-4e19-b670-30b02a1530bf", "normaluser36@gmail.com", true, "36", false, "Nguyen Van", false, null, "normaluser36@gmail.com", "normalUser36", "AQAAAAIAAYagAAAAEMt57sxDtY4btPutsFxjuShqhjzD9AlAZcv4hdPl2e3kyPE5S3FA4Xw+0B+fo9MjMQ==", null, false, "", false, "normalUser36" },
                    { 37, 0, "HCM", "67634473-e2d9-419a-a3fb-ace5ac98adf1", "normaluser37@gmail.com", true, "37", false, "Nguyen Van", false, null, "normaluser37@gmail.com", "normalUser37", "AQAAAAIAAYagAAAAEI3Q9ZAWPYjJ3vIzUCC3HSvxJWguD6n8QKUuLN/ndmKF8xdPz8gu0jjT/2NzYcN4fA==", null, false, "", false, "normalUser37" },
                    { 38, 0, "HCM", "1ea5aaf3-65c6-476a-af30-8fd49b21cef4", "normaluser38@gmail.com", true, "38", false, "Nguyen Van", false, null, "normaluser38@gmail.com", "normalUser38", "AQAAAAIAAYagAAAAEB9nsXAUJhSGX+RjCdENPMZoTDDckcNcypth/VNu8GqLAqnQg/7uOXUaMOMNQMefAw==", null, false, "", false, "normalUser38" },
                    { 39, 0, "HCM", "6709d0a1-680f-4164-8e37-12b2c6ff0590", "normaluser39@gmail.com", true, "39", false, "Nguyen Van", false, null, "normaluser39@gmail.com", "normalUser39", "AQAAAAIAAYagAAAAEDxu2hatEtlSqtdASKT3aW4qniiv50D4VBQNFjlF62Xk+z9R6Nfdjsr87vfVzgcxiQ==", null, false, "", false, "normalUser39" },
                    { 40, 0, "HCM", "40e8c3b2-dd2f-400b-9862-3dfb0322b718", "normaluser40@gmail.com", true, "40", false, "Nguyen Van", false, null, "normaluser40@gmail.com", "normalUser40", "AQAAAAIAAYagAAAAEB3P0cdsJLK08zDngegvYnjQPVKmEzX2YEe/xSXP7nrXqTyMs12qajnUjrIDcKyP3Q==", null, false, "", false, "normalUser40" },
                    { 41, 0, "HCM", "0e123b79-873c-48eb-8f00-ec65f4446e2b", "normaluser41@gmail.com", true, "41", false, "Nguyen Van", false, null, "normaluser41@gmail.com", "normalUser41", "AQAAAAIAAYagAAAAEKpfsjUHsRTwPrY+eXYmlcY4FmBrGalLRn1uTXOQKpW48Ib7e0++azz8e79HmP5AfA==", null, false, "", false, "normalUser41" },
                    { 42, 0, "HCM", "44c0ac5c-e34a-4754-8ee9-41b6bdea5d86", "normaluser42@gmail.com", true, "42", false, "Nguyen Van", false, null, "normaluser42@gmail.com", "normalUser42", "AQAAAAIAAYagAAAAEAMasDTnIupJn5NblPgNIv6lsZLHsnOF8KPnUEEPkqp0QQgI6u6n7OhZvo1kfQnSLQ==", null, false, "", false, "normalUser42" },
                    { 43, 0, "HCM", "98c6bff1-4896-4cc8-abaf-068bf00f704d", "normaluser43@gmail.com", true, "43", false, "Nguyen Van", false, null, "normaluser43@gmail.com", "normalUser43", "AQAAAAIAAYagAAAAENyIIHno3m1FJM7f07bf381w82opOksqTnI37nU5iSpPiqbcW57KGXOhT47KOcefbQ==", null, false, "", false, "normalUser43" },
                    { 44, 0, "HCM", "73db8957-d393-4436-88f3-fffa8ed8b244", "normaluser44@gmail.com", true, "44", false, "Nguyen Van", false, null, "normaluser44@gmail.com", "normalUser44", "AQAAAAIAAYagAAAAEPOZ1LlUSBuZ/+iZdoWhMnv6rg95VkaMRMeWDWyTjEaSc/5qYnf7frLXKTm5ZoxHFg==", null, false, "", false, "normalUser44" },
                    { 45, 0, "HCM", "714b49d4-03ec-4618-bfde-158996883150", "normaluser45@gmail.com", true, "45", false, "Nguyen Van", false, null, "normaluser45@gmail.com", "normalUser45", "AQAAAAIAAYagAAAAEAyE7r+94SzqZyN68aJW4Z8g9vyR/cYNK/ZM8VpD/4Ns5c0dOe93cMc+3155Y+FbmQ==", null, false, "", false, "normalUser45" },
                    { 46, 0, "HCM", "d5d0554f-a1ea-4d53-80aa-a9b155af8326", "normaluser46@gmail.com", true, "46", false, "Nguyen Van", false, null, "normaluser46@gmail.com", "normalUser46", "AQAAAAIAAYagAAAAEBnfJMiC0ux6NZRMARyZbOIT64KAcGBejuwpTpvxzK91jlpw0c++ZD6wYsL8emZ7ew==", null, false, "", false, "normalUser46" },
                    { 47, 0, "HCM", "18ed6a34-d3a3-43c3-bca7-438fac1ad5b9", "normaluser47@gmail.com", true, "47", false, "Nguyen Van", false, null, "normaluser47@gmail.com", "normalUser47", "AQAAAAIAAYagAAAAEEQ1rIDjtWGU36PdzZGPNR1umSGUy/e1t1/27hVJDWScEu/Yq37+kMqCngJZOZOfwA==", null, false, "", false, "normalUser47" },
                    { 48, 0, "HCM", "5f20fcd8-fed5-45d8-b951-7cacc550d201", "normaluser48@gmail.com", true, "48", false, "Nguyen Van", false, null, "normaluser48@gmail.com", "normalUser48", "AQAAAAIAAYagAAAAEGByJn0qmKnI3Q1Dgq7RLA0Ldz1HqQBpHImzcsTOEQrWo4afS+B0r9TcOGHW16UT7g==", null, false, "", false, "normalUser48" },
                    { 49, 0, "HCM", "33b260a4-9132-43f8-8283-00a435900761", "normaluser49@gmail.com", true, "49", false, "Nguyen Van", false, null, "normaluser49@gmail.com", "normalUser49", "AQAAAAIAAYagAAAAEHsSpieGwyA9gGAPVft7/2/4daeKb4kPzcFHXXNvl8GBovcgrJfmr04JAl8fHmufvg==", null, false, "", false, "normalUser49" },
                    { 50, 0, "HCM", "68030e88-5e75-45c4-a0a6-8d41d1529b48", "normaluser50@gmail.com", true, "50", false, "Nguyen Van", false, null, "normaluser50@gmail.com", "normalUser50", "AQAAAAIAAYagAAAAEGZcXv+zpZPQJ0nd3eZpQX13fs569oG98RQkBlhH5Gi4tQAco6vNH2ZicForuSdi0A==", null, false, "", false, "normalUser50" },
                    { 51, 0, "HCM", "1f756f78-2e5c-424d-a7f3-76eab67e1b01", "normaluser51@gmail.com", true, "51", false, "Nguyen Van", false, null, "normaluser51@gmail.com", "normalUser51", "AQAAAAIAAYagAAAAEJDMZuUB79tmQ/SjqD3rpN59aQaR2+0ZWI6bap1Qm5COEhhWeQMOhUT19xmB7pkMYQ==", null, false, "", false, "normalUser51" },
                    { 52, 0, "HCM", "66cfbaff-7585-49dd-8b24-832917860967", "normaluser52@gmail.com", true, "52", false, "Nguyen Van", false, null, "normaluser52@gmail.com", "normalUser52", "AQAAAAIAAYagAAAAEMVMuzWQyMOoXukDT13gidbTkpwYPdOgFE0DV1TyRj97xjLFNPQ1VLIW8Xnz1xDWxQ==", null, false, "", false, "normalUser52" },
                    { 53, 0, "HCM", "0913f528-7581-4b2f-8190-ada76ccbb064", "normaluser53@gmail.com", true, "53", false, "Nguyen Van", false, null, "normaluser53@gmail.com", "normalUser53", "AQAAAAIAAYagAAAAEIB+WeHE8XosR/UMw7S7pPyf5rIwKrIrfyd+yf6YeisjD9qdZEzqAlWoYeCa/no2vw==", null, false, "", false, "normalUser53" },
                    { 54, 0, "HCM", "e1531de2-0177-4652-8370-b8151991aeb0", "normaluser54@gmail.com", true, "54", false, "Nguyen Van", false, null, "normaluser54@gmail.com", "normalUser54", "AQAAAAIAAYagAAAAEKJSuI8geB2X/jmKQj25bsCka3By6ApUmY6SWX52gIDFGhS1itTfCiHmA0p6ERNZnw==", null, false, "", false, "normalUser54" },
                    { 55, 0, "HCM", "d8f61e6c-d070-4ba6-8b90-09dff7558882", "normaluser55@gmail.com", true, "55", false, "Nguyen Van", false, null, "normaluser55@gmail.com", "normalUser55", "AQAAAAIAAYagAAAAEOwBAYcDJSpIGbCYhKLl2vmtnZXkZu6U1nUCoYQ6xadLbhpmk6v6dzOkKSi42lNMVw==", null, false, "", false, "normalUser55" },
                    { 56, 0, "HCM", "53493dd0-2369-4e0c-a1cc-c430c42b709c", "normaluser56@gmail.com", true, "56", false, "Nguyen Van", false, null, "normaluser56@gmail.com", "normalUser56", "AQAAAAIAAYagAAAAEBK5A51Nup16oQvf9vkZglMS6k4/rzwpAQl/HNqi/ds18dYa2XJkb9rK2q+B73zEdA==", null, false, "", false, "normalUser56" },
                    { 57, 0, "HCM", "ac22f631-7036-420e-bb5d-7ac3070028e9", "normaluser57@gmail.com", true, "57", false, "Nguyen Van", false, null, "normaluser57@gmail.com", "normalUser57", "AQAAAAIAAYagAAAAEAlHl8vEPUIPnLKFRMdzhagGNQHkGt6D4VNLVp6bui8wMg6DpHK/L/M8i8Ks347WZg==", null, false, "", false, "normalUser57" },
                    { 58, 0, "HCM", "7639103e-2346-48aa-a03a-cc1fb23af18d", "normaluser58@gmail.com", true, "58", false, "Nguyen Van", false, null, "normaluser58@gmail.com", "normalUser58", "AQAAAAIAAYagAAAAENs0j8LYHDjbrQcgVQqJXsNBjMkDxbnLf75dSL6ZxQcT055EU6WWZPsMExkn463tqA==", null, false, "", false, "normalUser58" },
                    { 59, 0, "HCM", "50effd5e-3d73-4cdd-85b9-3ed022b5924a", "normaluser59@gmail.com", true, "59", false, "Nguyen Van", false, null, "normaluser59@gmail.com", "normalUser59", "AQAAAAIAAYagAAAAEDzAryN9X8jq2A7HcXq8S16p5WN3H3L5w/JbNfRNaiapwmJ4xG+pnQLjKa1FTKcESQ==", null, false, "", false, "normalUser59" },
                    { 60, 0, "HCM", "36679a50-94e0-4118-b0ce-a81d3df29d3c", "normaluser60@gmail.com", true, "60", false, "Nguyen Van", false, null, "normaluser60@gmail.com", "normalUser60", "AQAAAAIAAYagAAAAEMlz5Cu7RWozPT6glSPYBlYC8jWTZkps0Cv6YDFUE4uUWBYjkJ4m1Y3YUYMiAkZynQ==", null, false, "", false, "normalUser60" },
                    { 61, 0, "HCM", "ccf72578-5751-464b-917a-f214e1db1f78", "normaluser61@gmail.com", true, "61", false, "Nguyen Van", false, null, "normaluser61@gmail.com", "normalUser61", "AQAAAAIAAYagAAAAENPT8Mrwwc+0SK1FYhFivlIMQ6zO+oQNSR5rk3PyefGSOAqOSoRGvZOWPQeW+s/pVg==", null, false, "", false, "normalUser61" },
                    { 62, 0, "HCM", "1b54d460-129a-46e3-a0ef-2a79b8239454", "normaluser62@gmail.com", true, "62", false, "Nguyen Van", false, null, "normaluser62@gmail.com", "normalUser62", "AQAAAAIAAYagAAAAEBg0/x8Wk4BOC595Iye4iYV52iplrMaCcpJbiEC+masIiEs3JkU3cwYUBSezK+jrhg==", null, false, "", false, "normalUser62" },
                    { 63, 0, "HCM", "64333eca-7d11-4a09-b266-bf7b9a7b00b3", "normaluser63@gmail.com", true, "63", false, "Nguyen Van", false, null, "normaluser63@gmail.com", "normalUser63", "AQAAAAIAAYagAAAAEP0UHMyVfvlsI64XITw0M8ieJS8OkjIzDe4Slij/T26huVG9YdmffY14E4pwEtbSRw==", null, false, "", false, "normalUser63" },
                    { 64, 0, "HCM", "aeb7b4a8-7120-4b5a-908f-333885e75e69", "normaluser64@gmail.com", true, "64", false, "Nguyen Van", false, null, "normaluser64@gmail.com", "normalUser64", "AQAAAAIAAYagAAAAEFzr4VnrbrLQ/NWkM0T4xIFXd75k5JARQNrlzv1wW6tTjBKmnchw11/PRqjqEJQ7Iw==", null, false, "", false, "normalUser64" },
                    { 65, 0, "HCM", "242ed433-eb8d-4756-883f-933945626663", "normaluser65@gmail.com", true, "65", false, "Nguyen Van", false, null, "normaluser65@gmail.com", "normalUser65", "AQAAAAIAAYagAAAAEO05v7m2/lFpaDWmWSF4dzPL4Uk7c5xJsGbHkPwhzZVJrsSSZb4U2G+QEYsbWYCHOA==", null, false, "", false, "normalUser65" }
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
                    { 2, 36 },
                    { 5, 37 },
                    { 6, 38 },
                    { 5, 39 },
                    { 7, 40 },
                    { 5, 41 },
                    { 2, 42 },
                    { 3, 43 },
                    { 4, 44 },
                    { 7, 45 },
                    { 2, 46 },
                    { 1, 47 },
                    { 8, 48 },
                    { 4, 49 },
                    { 4, 50 },
                    { 6, 51 },
                    { 7, 52 },
                    { 6, 53 },
                    { 6, 54 },
                    { 1, 55 },
                    { 8, 56 },
                    { 3, 57 },
                    { 6, 58 },
                    { 2, 59 },
                    { 2, 60 },
                    { 4, 61 },
                    { 6, 62 },
                    { 1, 63 },
                    { 8, 64 },
                    { 3, 65 }
                });

            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "Id", "ApplyExpireDate", "BusinessProfileId", "CreatedDate", "Description", "ImageUrl", "IsActive", "JobDescriptionFileUrl", "JobExpiredDate", "Name", "Offer" },
                values: new object[,]
                {
                    { 1, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 32, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(745), "This a simple description for project 1", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 1", 99.0 },
                    { 2, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(813), "This a simple description for project 2", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 2", 198.0 },
                    { 3, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(826), "This a simple description for project 3", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 3", 297.0 },
                    { 4, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(838), "This a simple description for project 4", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 4", 396.0 },
                    { 5, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(850), "This a simple description for project 5", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 5", 495.0 },
                    { 6, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(863), "This a simple description for project 6", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 6", 594.0 },
                    { 7, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(875), "This a simple description for project 7", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 7", 693.0 },
                    { 8, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(887), "This a simple description for project 8", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 8", 792.0 },
                    { 9, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(899), "This a simple description for project 9", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 9", 891.0 },
                    { 10, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(914), "This a simple description for project 10", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 10", 990.0 },
                    { 11, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(980), "This a simple description for project 11", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 11", 1089.0 },
                    { 12, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(993), "This a simple description for project 12", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 12", 1188.0 },
                    { 13, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(1005), "This a simple description for project 13", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 13", 1287.0 },
                    { 14, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(1017), "This a simple description for project 14", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 14", 1386.0 },
                    { 15, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(1029), "This a simple description for project 15", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 15", 1485.0 },
                    { 16, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(1042), "This a simple description for project 16", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 16", 1584.0 },
                    { 17, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(1053), "This a simple description for project 17", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 17", 1683.0 },
                    { 18, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(1069), "This a simple description for project 18", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 18", 1782.0 },
                    { 19, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(1080), "This a simple description for project 19", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 19", 1881.0 },
                    { 20, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(1141), "This a simple description for project 20", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 20", 1980.0 },
                    { 21, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(1153), "This a simple description for project 21", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 21", 2079.0 },
                    { 22, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(1165), "This a simple description for project 22", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 22", 2178.0 },
                    { 23, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(1177), "This a simple description for project 23", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 23", 2277.0 },
                    { 24, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(1189), "This a simple description for project 24", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 24", 2376.0 },
                    { 25, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(1201), "This a simple description for project 25", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 25", 2475.0 },
                    { 26, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(1213), "This a simple description for project 26", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 26", 2574.0 },
                    { 27, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(1225), "This a simple description for project 27", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 27", 2673.0 },
                    { 28, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(1237), "This a simple description for project 28", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 28", 2772.0 },
                    { 29, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(1249), "This a simple description for project 29", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 29", 2871.0 },
                    { 30, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2234), "This a simple description for project 30", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 30", 2970.0 },
                    { 31, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2305), "This a simple description for project 31", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 31", 3069.0 },
                    { 32, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 32, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2317), "This a simple description for project 32", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 32", 3168.0 },
                    { 33, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2329), "This a simple description for project 33", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 33", 3267.0 },
                    { 34, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2346), "This a simple description for project 34", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 34", 3366.0 },
                    { 35, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 33, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2360), "This a simple description for project 35", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 35", 3465.0 },
                    { 36, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2373), "This a simple description for project 36", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 36", 3564.0 },
                    { 37, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2384), "This a simple description for project 37", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 37", 3663.0 },
                    { 38, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2462), "This a simple description for project 38", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 38", 3762.0 },
                    { 39, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2478), "This a simple description for project 39", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 39", 3861.0 },
                    { 40, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2490), "This a simple description for project 40", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 40", 3960.0 },
                    { 41, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2502), "This a simple description for project 41", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 41", 4059.0 },
                    { 42, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2514), "This a simple description for project 42", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 42", 4158.0 },
                    { 43, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2527), "This a simple description for project 43", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 43", 4257.0 },
                    { 44, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2539), "This a simple description for project 44", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 44", 4356.0 },
                    { 45, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2551), "This a simple description for project 45", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 45", 4455.0 },
                    { 46, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2563), "This a simple description for project 46", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 46", 4554.0 },
                    { 47, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2575), "This a simple description for project 47", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 47", 4653.0 },
                    { 48, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 30, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2663), "This a simple description for project 48", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 48", 4752.0 },
                    { 49, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2677), "This a simple description for project 49", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 49", 4851.0 },
                    { 50, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2703), "This a simple description for project 50", "This is an image. If you do not see anything, you are so blind!!!", true, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 50", 4950.0 },
                    { 51, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 32, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2716), "This a simple description for project 51", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 51", 5049.0 },
                    { 52, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2728), "This a simple description for project 52", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 52", 5148.0 },
                    { 53, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2741), "This a simple description for project 53", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 53", 5247.0 },
                    { 54, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2753), "This a simple description for project 54", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 54", 5346.0 },
                    { 55, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2764), "This a simple description for project 55", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 55", 5445.0 },
                    { 56, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2776), "This a simple description for project 56", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 56", 5544.0 },
                    { 57, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2789), "This a simple description for project 57", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 57", 5643.0 },
                    { 58, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2850), "This a simple description for project 58", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 58", 5742.0 },
                    { 59, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2864), "This a simple description for project 59", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 59", 5841.0 },
                    { 60, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2876), "This a simple description for project 60", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 60", 5940.0 },
                    { 61, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2888), "This a simple description for project 61", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 61", 6039.0 },
                    { 62, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2900), "This a simple description for project 62", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 62", 6138.0 },
                    { 63, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2912), "This a simple description for project 63", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 63", 6237.0 },
                    { 64, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2924), "This a simple description for project 64", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 64", 6336.0 },
                    { 65, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2936), "This a simple description for project 65", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 65", 6435.0 },
                    { 66, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(2993), "This a simple description for project 66", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 66", 6534.0 },
                    { 67, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3007), "This a simple description for project 67", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 67", 6633.0 },
                    { 68, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3019), "This a simple description for project 68", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 68", 6732.0 },
                    { 69, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3030), "This a simple description for project 69", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 69", 6831.0 },
                    { 70, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3042), "This a simple description for project 70", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 70", 6930.0 },
                    { 71, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3054), "This a simple description for project 71", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 71", 7029.0 },
                    { 72, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3066), "This a simple description for project 72", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 72", 7128.0 },
                    { 73, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3078), "This a simple description for project 73", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 73", 7227.0 },
                    { 74, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3089), "This a simple description for project 74", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 74", 7326.0 },
                    { 75, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3141), "This a simple description for project 75", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 75", 7425.0 },
                    { 76, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3154), "This a simple description for project 76", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 76", 7524.0 },
                    { 77, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3166), "This a simple description for project 77", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 77", 7623.0 },
                    { 78, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3178), "This a simple description for project 78", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 78", 7722.0 },
                    { 79, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3190), "This a simple description for project 79", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 79", 7821.0 },
                    { 80, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3202), "This a simple description for project 80", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 80", 7920.0 },
                    { 81, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3215), "This a simple description for project 81", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 81", 8019.0 },
                    { 82, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3226), "This a simple description for project 82", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 82", 8118.0 },
                    { 83, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3238), "This a simple description for project 83", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 83", 8217.0 },
                    { 84, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 31, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3250), "This a simple description for project 84", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 84", 8316.0 },
                    { 85, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3303), "This a simple description for project 85", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 85", 8415.0 },
                    { 86, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 6, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3314), "This a simple description for project 86", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 86", 8514.0 },
                    { 87, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3326), "This a simple description for project 87", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 87", 8613.0 },
                    { 88, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 34, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3338), "This a simple description for project 88", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 88", 8712.0 },
                    { 89, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3350), "This a simple description for project 89", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 89", 8811.0 },
                    { 90, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3362), "This a simple description for project 90", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 90", 8910.0 },
                    { 91, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3374), "This a simple description for project 91", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 91", 9009.0 },
                    { 92, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3386), "This a simple description for project 92", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 92", 9108.0 },
                    { 93, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3397), "This a simple description for project 93", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 93", 9207.0 },
                    { 94, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3456), "This a simple description for project 94", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 94", 9306.0 },
                    { 95, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 32, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3470), "This a simple description for project 95", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 95", 9405.0 },
                    { 96, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3482), "This a simple description for project 96", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 96", 9504.0 },
                    { 97, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3494), "This a simple description for project 97", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 97", 9603.0 },
                    { 98, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3505), "This a simple description for project 98", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 98", 9702.0 },
                    { 99, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 30, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3517), "This a simple description for project 99", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 99", 9801.0 },
                    { 100, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 11, 0, 10, 29, 234, DateTimeKind.Local).AddTicks(3530), "This a simple description for project 100", "This is an image. If you do not see anything, you are so blind!!!", false, "This is what decides that you will do the job or run!!!", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), "Project 100", 9900.0 }
                });

            migrationBuilder.InsertData(
                table: "JobCategories",
                columns: new[] { "CategoryId", "JobId" },
                values: new object[,]
                {
                    { 7, 1 },
                    { 4, 2 },
                    { 7, 3 },
                    { 4, 4 },
                    { 3, 5 },
                    { 1, 6 },
                    { 3, 7 },
                    { 2, 8 },
                    { 5, 9 },
                    { 4, 10 },
                    { 4, 11 },
                    { 7, 12 },
                    { 4, 13 },
                    { 2, 14 },
                    { 4, 15 },
                    { 6, 16 },
                    { 7, 17 },
                    { 6, 18 },
                    { 5, 19 },
                    { 7, 20 },
                    { 6, 21 },
                    { 1, 22 },
                    { 4, 23 },
                    { 2, 24 },
                    { 2, 25 },
                    { 1, 26 },
                    { 4, 27 },
                    { 5, 28 },
                    { 6, 29 },
                    { 7, 30 },
                    { 2, 31 },
                    { 6, 32 },
                    { 2, 33 },
                    { 7, 34 },
                    { 2, 35 },
                    { 7, 36 },
                    { 7, 37 },
                    { 3, 38 },
                    { 5, 39 },
                    { 5, 40 },
                    { 3, 41 },
                    { 1, 42 },
                    { 3, 43 },
                    { 7, 44 },
                    { 6, 45 },
                    { 6, 46 },
                    { 5, 47 },
                    { 3, 48 },
                    { 1, 49 },
                    { 7, 50 },
                    { 4, 51 },
                    { 5, 52 },
                    { 6, 53 },
                    { 4, 54 },
                    { 7, 55 },
                    { 7, 56 },
                    { 1, 57 },
                    { 6, 58 },
                    { 6, 59 },
                    { 3, 60 },
                    { 6, 61 },
                    { 7, 62 },
                    { 7, 63 },
                    { 4, 64 },
                    { 6, 65 },
                    { 3, 66 },
                    { 3, 67 },
                    { 7, 68 },
                    { 7, 69 },
                    { 7, 70 },
                    { 5, 71 },
                    { 4, 72 },
                    { 6, 73 },
                    { 5, 74 },
                    { 1, 75 },
                    { 6, 76 },
                    { 3, 77 },
                    { 5, 78 },
                    { 6, 79 },
                    { 1, 80 },
                    { 6, 81 },
                    { 7, 82 },
                    { 6, 83 },
                    { 7, 84 },
                    { 2, 85 },
                    { 7, 86 },
                    { 2, 87 },
                    { 4, 88 },
                    { 1, 89 },
                    { 4, 90 },
                    { 4, 91 },
                    { 5, 92 },
                    { 3, 93 },
                    { 5, 94 },
                    { 5, 95 },
                    { 6, 96 },
                    { 4, 97 },
                    { 6, 98 },
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
