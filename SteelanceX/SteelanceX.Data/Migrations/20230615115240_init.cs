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
                    { 1, 0, "HCM", "7f2e0598-40e0-4360-8cec-dfad7bf90ec3", "normaluser1@gmail.com", true, "1", true, "Nguyen Van", false, null, "normaluser1@gmail.com", "normalUser1", "AQAAAAIAAYagAAAAEFDopoFb+6WuSllpElYt7Aqz7lnAy7crvbv3t5K3ZhvUPmGVkJ51h8zPI1jT5Lv+UQ==", null, false, "", false, "normalUser1" },
                    { 2, 0, "HCM", "00646cce-b10c-4fd9-a433-65e7cc358149", "normaluser2@gmail.com", true, "2", true, "Nguyen Van", false, null, "normaluser2@gmail.com", "normalUser2", "AQAAAAIAAYagAAAAEKVkWJcRYHGT1KlrWfPraptSJjAk7iWaQvpoxlBb11QgDX+qgPZvCcdE7T7oRu6FRw==", null, false, "", false, "normalUser2" },
                    { 3, 0, "HCM", "f7ffb637-7fd4-4d22-9160-77d932016f5e", "normaluser3@gmail.com", true, "3", true, "Nguyen Van", false, null, "normaluser3@gmail.com", "normalUser3", "AQAAAAIAAYagAAAAEDWhnEK0HBsj1YIFxdkfCzM9Mo8jvfjd0aAJ2gEk5O7VWFnQPR4Ek+S6288E5d5bFw==", null, false, "", false, "normalUser3" },
                    { 4, 0, "HCM", "85fa8006-f61a-4067-accf-ca24b7d27e16", "normaluser4@gmail.com", true, "4", true, "Nguyen Van", false, null, "normaluser4@gmail.com", "normalUser4", "AQAAAAIAAYagAAAAEEqOIHfANyMc22N5bwPZmbu3wkXMjvcNJYuxa2O6HvcqDHahB4ka4QuHaa/wRDIzaQ==", null, false, "", false, "normalUser4" },
                    { 5, 0, "HCM", "d48a0b85-3bf7-4d03-bf6d-3febd1625051", "normaluser5@gmail.com", true, "5", true, "Nguyen Van", false, null, "normaluser5@gmail.com", "normalUser5", "AQAAAAIAAYagAAAAEDt6w636Tf/Qfn6KuJ/+YAxnpeTvXGw+GVOUpl33M5ARm5HN0lKYAbTo3gj28se1tw==", null, false, "", false, "normalUser5" },
                    { 6, 0, "HCM", "584488aa-f184-449d-b4c0-a6912ff55b71", "normaluser6@gmail.com", true, "6", true, "Nguyen Van", false, null, "normaluser6@gmail.com", "normalUser6", "AQAAAAIAAYagAAAAEL4zhSX2c8rLe7DLfWvDyyeREZgNro44xYYDifdFwopejHngRYirhwNrSlBs2VqwCw==", null, false, "", false, "normalUser6" },
                    { 7, 0, "HCM", "dae3d6a6-3731-4ba2-b0cb-ac9b9ae65cb7", "normaluser7@gmail.com", true, "7", true, "Nguyen Van", false, null, "normaluser7@gmail.com", "normalUser7", "AQAAAAIAAYagAAAAEAkduQzmCeCKpevfWQZofuGLwPQieLfoIE4cPb2h/xkXKM851GVwOPal8/NqJ7PwOg==", null, false, "", false, "normalUser7" },
                    { 8, 0, "HCM", "49d08ca1-b80d-4a74-aff2-195797ba0f85", "normaluser8@gmail.com", true, "8", true, "Nguyen Van", false, null, "normaluser8@gmail.com", "normalUser8", "AQAAAAIAAYagAAAAECcUnkx5/62pf3dJyuFtR6GsZNkWS/mfVCZZH30KC/nRM9WlOkjamnm+L45rEynE4g==", null, false, "", false, "normalUser8" },
                    { 9, 0, "HCM", "55cc8e6a-ccc3-4e1c-835b-078b3a95571f", "normaluser9@gmail.com", true, "9", true, "Nguyen Van", false, null, "normaluser9@gmail.com", "normalUser9", "AQAAAAIAAYagAAAAEBi9ykkHqHibfdRcEfTaz2wxZsaET6/CtyUyo30cy/3m4ntGfmkzpsurCYENkh0hNw==", null, false, "", false, "normalUser9" },
                    { 10, 0, "HCM", "bcfda917-5e81-481d-ae90-8f0c70c85cdd", "normaluser10@gmail.com", true, "10", true, "Nguyen Van", false, null, "normaluser10@gmail.com", "normalUser10", "AQAAAAIAAYagAAAAEMrJQk5+k9ss0PZ4oYMHlF02gwjByNfU2zhsQSeATY0NW7UT3zyBj2bCtI7XTXJZXQ==", null, false, "", false, "normalUser10" },
                    { 11, 0, "HCM", "96cbbfa6-df30-4e51-8bf1-93c0211fe0e5", "normaluser11@gmail.com", true, "11", true, "Nguyen Van", false, null, "normaluser11@gmail.com", "normalUser11", "AQAAAAIAAYagAAAAEFHrDq9txkyQ4eSUCdVkXsM0FOFwd+FMHs77XDwjUnLk1+OOyg8+NPqZ0c4lEaig2w==", null, false, "", false, "normalUser11" },
                    { 12, 0, "HCM", "78695388-4369-455d-8888-edab5470087b", "normaluser12@gmail.com", true, "12", true, "Nguyen Van", false, null, "normaluser12@gmail.com", "normalUser12", "AQAAAAIAAYagAAAAECXJl9egv3ABukFbgfu8uu4Tby/x/vLTBuqgHTo3VUMfoiD/MuKMcrIEaqr1Sn5P6A==", null, false, "", false, "normalUser12" },
                    { 13, 0, "HCM", "32924f9c-d2cd-4374-89f1-c22bc09ca946", "normaluser13@gmail.com", true, "13", true, "Nguyen Van", false, null, "normaluser13@gmail.com", "normalUser13", "AQAAAAIAAYagAAAAEKWV20WbqZm/JvidTpwcqjl+3GRrhoniVoTT2j0MxaQ/gqr9hcTHx3CifEZZJMW+hw==", null, false, "", false, "normalUser13" },
                    { 14, 0, "HCM", "a80ccae7-4eae-4f41-ad26-56d38ebf41ab", "normaluser14@gmail.com", true, "14", true, "Nguyen Van", false, null, "normaluser14@gmail.com", "normalUser14", "AQAAAAIAAYagAAAAEKl9GXcbEnFeZccjyT9VBaKgVxo/p2S1fPDL7+IllI0/7mSs6TlhDmMU2cNABLTF2g==", null, false, "", false, "normalUser14" },
                    { 15, 0, "HCM", "4e548d57-2b28-4566-be1b-874b692df6f1", "normaluser15@gmail.com", true, "15", true, "Nguyen Van", false, null, "normaluser15@gmail.com", "normalUser15", "AQAAAAIAAYagAAAAEHHrX+L6GOfWJPXN5LWRiuUpzJljFOGRlu7Bxdq+rkvTuePhSUg+7r4J7EosCzYsrQ==", null, false, "", false, "normalUser15" },
                    { 16, 0, "HCM", "beba5b26-39c1-4e7f-8ba4-269fe6573e69", "normaluser16@gmail.com", true, "16", true, "Nguyen Van", false, null, "normaluser16@gmail.com", "normalUser16", "AQAAAAIAAYagAAAAEDu8wW2AYLzfrl/+/D/1aLZCbB4qyMJDDKDm4VogJ3KgEKXtwrVsa9k2yILcyKVeqw==", null, false, "", false, "normalUser16" },
                    { 17, 0, "HCM", "582252b7-18f0-4267-b15f-7831b79e1ddb", "normaluser17@gmail.com", true, "17", true, "Nguyen Van", false, null, "normaluser17@gmail.com", "normalUser17", "AQAAAAIAAYagAAAAECtBbx9KxNilelU3iPod0B3vUAMpzbIhl8hK8rcmSZE/NUwxwhq/4nQVbgoQsg+sRw==", null, false, "", false, "normalUser17" },
                    { 18, 0, "HCM", "618234f3-9877-421d-a944-d34b71db3ac0", "normaluser18@gmail.com", true, "18", true, "Nguyen Van", false, null, "normaluser18@gmail.com", "normalUser18", "AQAAAAIAAYagAAAAECfV9bakDfiUTEinW1QTb6gY3fJOXXpRIE6bKvSNp13v/gqhRqkS3fBOurGJmyeSPg==", null, false, "", false, "normalUser18" },
                    { 19, 0, "HCM", "3d2a1b4a-057a-4660-a8a8-4422ff64bd26", "normaluser19@gmail.com", true, "19", true, "Nguyen Van", false, null, "normaluser19@gmail.com", "normalUser19", "AQAAAAIAAYagAAAAEBv6uJeWQAr+ljt4EmsxNytDWKZKqWolc0fIhZ7pnsaGsoyQ6ikOWzaVKpmm3Qu+kQ==", null, false, "", false, "normalUser19" },
                    { 20, 0, "HCM", "87208e22-00eb-4ecb-a8bf-a7d71970b887", "normaluser20@gmail.com", true, "20", true, "Nguyen Van", false, null, "normaluser20@gmail.com", "normalUser20", "AQAAAAIAAYagAAAAEDze5PL9pQ33p0lOv3EMzKLZU5SRuO/Y0zDrhH092Bfm+y7IJV6ObWdTVRrTxjNiwg==", null, false, "", false, "normalUser20" },
                    { 21, 0, "HCM", "a1a2795a-05e1-425f-af37-f6d472c4ab78", "normaluser21@gmail.com", true, "21", true, "Nguyen Van", false, null, "normaluser21@gmail.com", "normalUser21", "AQAAAAIAAYagAAAAEKLXRgBtmQVaGVUxl/tTNOnSKTSvtEE9nB++AB5jl7k+l1lxoihR2cN/Wjo31mYE2A==", null, false, "", false, "normalUser21" },
                    { 22, 0, "HCM", "6a89f084-a38f-4795-93d0-d7449223bd0e", "normaluser22@gmail.com", true, "22", true, "Nguyen Van", false, null, "normaluser22@gmail.com", "normalUser22", "AQAAAAIAAYagAAAAELURx1U51abiE+CoRmskyTkwGpgZ2afbzJzK/Jwfhfcp1mJTkfPEcvwpblM94yGS6w==", null, false, "", false, "normalUser22" },
                    { 23, 0, "HCM", "0f67796b-55e0-45a9-b7f2-ace79b303685", "normaluser23@gmail.com", true, "23", true, "Nguyen Van", false, null, "normaluser23@gmail.com", "normalUser23", "AQAAAAIAAYagAAAAEN/7IuePPLvaowADuL+CzmPIibL+Hn/iMqwyIco50UxGyOPSOxcHuxq2X5Tx2ORXqA==", null, false, "", false, "normalUser23" },
                    { 24, 0, "HCM", "7cde0510-5074-4c89-a472-6a2ac8bd2ac0", "normaluser24@gmail.com", true, "24", true, "Nguyen Van", false, null, "normaluser24@gmail.com", "normalUser24", "AQAAAAIAAYagAAAAECNViAXMiiw1RL9hCL55V5EGew+uMXNhW/NGc4IgHGzIbjV6hXY6MwZHz0zLchScpw==", null, false, "", false, "normalUser24" },
                    { 25, 0, "HCM", "b0b3cef4-4aca-4601-a1ed-9c8f58f502a7", "normaluser25@gmail.com", true, "25", true, "Nguyen Van", false, null, "normaluser25@gmail.com", "normalUser25", "AQAAAAIAAYagAAAAEFQk21sLniI71tSR7rC4SbPvqYuaKfyHNMNVky9jWlxyruGc8R/NdRu57hTjCEv2tA==", null, false, "", false, "normalUser25" },
                    { 26, 0, "HCM", "d6ab9547-5e34-4f5f-8b77-2ca8a9700d68", "normaluser26@gmail.com", true, "26", true, "Nguyen Van", false, null, "normaluser26@gmail.com", "normalUser26", "AQAAAAIAAYagAAAAEEFWeRQg9Tw6nDgbNDZeFrHXAGNuDV0NaZclYYIPZIrphRLiRiwSzSrCQdXXBrdtTw==", null, false, "", false, "normalUser26" },
                    { 27, 0, "HCM", "f8f9dfec-774d-4c15-9873-d2339a1d8423", "normaluser27@gmail.com", true, "27", true, "Nguyen Van", false, null, "normaluser27@gmail.com", "normalUser27", "AQAAAAIAAYagAAAAEH0fsbX8rYO2WJA9e/S+nNfYBvsseBEJubD+hKtJrQaSyqaVDuEV50Y+FZfQLfVy+Q==", null, false, "", false, "normalUser27" },
                    { 28, 0, "HCM", "14a597b4-25aa-43be-84f0-23ad76af83f3", "normaluser28@gmail.com", true, "28", true, "Nguyen Van", false, null, "normaluser28@gmail.com", "normalUser28", "AQAAAAIAAYagAAAAEEsXpxu/gLNsQeC1mhhT7iucjiKVdbYktz0aaMd471TNf3F4wlQEZOmrgkhiq2/Prg==", null, false, "", false, "normalUser28" },
                    { 29, 0, "HCM", "fe2d3137-d462-47f9-a7f7-fd19f384bcb6", "normaluser29@gmail.com", true, "29", true, "Nguyen Van", false, null, "normaluser29@gmail.com", "normalUser29", "AQAAAAIAAYagAAAAEMazHaV5TAmGm7R1e8k8nYjIFEzjtLWkUsf99JulbpMi00xUkwwwxU9odMVRUIUpyQ==", null, false, "", false, "normalUser29" },
                    { 30, 0, "HCM", "49bce5b8-b290-4d9c-8af4-3a779a3f17dd", "normaluser30@gmail.com", true, "30", true, "Nguyen Van", false, null, "normaluser30@gmail.com", "normalUser30", "AQAAAAIAAYagAAAAEEwKFuOL4lPGXTQSVDI9bIsLibpq00P1U5SZlHxvjOUW5L41l76DrtMzx1GlUsnWbw==", null, false, "", false, "normalUser30" },
                    { 31, 0, "HCM", "26d6b131-9490-4ecb-a432-a1fa093191c0", "normaluser31@gmail.com", true, "31", true, "Nguyen Van", false, null, "normaluser31@gmail.com", "normalUser31", "AQAAAAIAAYagAAAAEE+QpCGFoBgGf6Dqj2nxqmZWvT3sjLswBVhB4PFWsM3m/uQnaIs2BubXaD+5z0kRow==", null, false, "", false, "normalUser31" },
                    { 32, 0, "HCM", "8e9de254-6c15-4da1-941a-53995c86a835", "normaluser32@gmail.com", true, "32", true, "Nguyen Van", false, null, "normaluser32@gmail.com", "normalUser32", "AQAAAAIAAYagAAAAELR/9cns3WSHInJ2MxRlErH50kY0O49i0KvnI8AFkxFd05iB3p3oWEkJABc8LE8xjg==", null, false, "", false, "normalUser32" },
                    { 33, 0, "HCM", "95c8dd9b-e793-4386-b370-18c455812adf", "normaluser33@gmail.com", true, "33", true, "Nguyen Van", false, null, "normaluser33@gmail.com", "normalUser33", "AQAAAAIAAYagAAAAEFO8DQQ839/bpYa8KT/5ccLrPhPQsHvjvcJYh+lNYdm6wIX+tWzbMdgnx95ARbaKow==", null, false, "", false, "normalUser33" },
                    { 34, 0, "HCM", "72980b95-cb01-49bc-8bb6-f4ddfe7be4ff", "normaluser34@gmail.com", true, "34", true, "Nguyen Van", false, null, "normaluser34@gmail.com", "normalUser34", "AQAAAAIAAYagAAAAEBPtjJQIBMSPAT7gengK+fULk5S3oJUJSLNGotnSir1Q3HTRDB9JZkQFw6/F4oLHHw==", null, false, "", false, "normalUser34" },
                    { 35, 0, "HCM", "702156ed-3298-4d67-b17e-4f2dee638010", "normaluser35@gmail.com", true, "35", true, "Nguyen Van", false, null, "normaluser35@gmail.com", "normalUser35", "AQAAAAIAAYagAAAAEHsd0GQLQoaw7nwiqSqjYdqiaqgUTikJyvC3dMPnGRw7d1TnS7JKrWjyAsE+MCYeMw==", null, false, "", false, "normalUser35" },
                    { 36, 0, "HCM", "df587bff-adcb-41f0-b2b7-f3ebae1e2131", "normaluser36@gmail.com", true, "36", true, "Nguyen Van", false, null, "normaluser36@gmail.com", "normalUser36", "AQAAAAIAAYagAAAAEH5CT/3PkhvlvaxXY7UBqp9h3820Z8CzNKvFuL7mn6BvpxsTcWW3pKsk0r3FkxEE6g==", null, false, "", false, "normalUser36" },
                    { 37, 0, "HCM", "94a05aaa-331d-451d-bdc6-a067d529ab57", "normaluser37@gmail.com", true, "37", true, "Nguyen Van", false, null, "normaluser37@gmail.com", "normalUser37", "AQAAAAIAAYagAAAAENoBjCACMnPVuG3/K9NbSblga6U9d56H7oDacBkg5trRFU3Qh91XUVhzwboXB5ma7g==", null, false, "", false, "normalUser37" },
                    { 38, 0, "HCM", "4a1ac2e7-ee55-4490-a3d8-e3a7e52fccd9", "normaluser38@gmail.com", true, "38", true, "Nguyen Van", false, null, "normaluser38@gmail.com", "normalUser38", "AQAAAAIAAYagAAAAEOb6uwqdhSxAip7DN9cXPBAFamTy+bbLcshZrQnKltMxlPkoGURP6SiocoKjlYVrxg==", null, false, "", false, "normalUser38" },
                    { 39, 0, "HCM", "cd131041-ba7b-48bd-aa01-f8bc29e82e0e", "normaluser39@gmail.com", true, "39", true, "Nguyen Van", false, null, "normaluser39@gmail.com", "normalUser39", "AQAAAAIAAYagAAAAELi2ERo7vYTXGoMiz/3RJ3VArw8IjUvzKzz8XsEsuz0NMKJ/+OKVV/x8TIdigxK7Lw==", null, false, "", false, "normalUser39" },
                    { 40, 0, "HCM", "b53a1a3e-af6d-472a-8171-e90af1064664", "normaluser40@gmail.com", true, "40", true, "Nguyen Van", false, null, "normaluser40@gmail.com", "normalUser40", "AQAAAAIAAYagAAAAEES/2sq21QfIknHoxsqJszF+BixSndxsKx8cxy0eAEhQ4laHtXCxtNGx5EX8EAJofA==", null, false, "", false, "normalUser40" },
                    { 41, 0, "HCM", "43e0b8e3-31fc-4c24-9b64-76c96d5d7f65", "normaluser41@gmail.com", true, "41", true, "Nguyen Van", false, null, "normaluser41@gmail.com", "normalUser41", "AQAAAAIAAYagAAAAEIEMdRU9KOoSRVWMA0ppGeh/e3Gi5LEY6i4byQE47/e2rfJAfIb525hotdZM75jtnA==", null, false, "", false, "normalUser41" },
                    { 42, 0, "HCM", "c8a455c9-2e14-4990-a169-deb7e907ab92", "normaluser42@gmail.com", true, "42", true, "Nguyen Van", false, null, "normaluser42@gmail.com", "normalUser42", "AQAAAAIAAYagAAAAEJcdSkNiHCJV9MJzo+fgaAkNQ/Yettgy69pevjMPfNuVi2j3J1Lw7ywj7BvRAXYTRw==", null, false, "", false, "normalUser42" },
                    { 43, 0, "HCM", "c616ebeb-75bb-4a54-9822-8111588f79ef", "normaluser43@gmail.com", true, "43", true, "Nguyen Van", false, null, "normaluser43@gmail.com", "normalUser43", "AQAAAAIAAYagAAAAEBo3z9e1cb0CqWCmWIbzBtoO1rQCDi6NahujsXTVt+tQfGCUJ6fWZ3lK/yR4pC6HhQ==", null, false, "", false, "normalUser43" },
                    { 44, 0, "HCM", "1998235f-5e2c-4572-ad43-518ea39b9e55", "normaluser44@gmail.com", true, "44", true, "Nguyen Van", false, null, "normaluser44@gmail.com", "normalUser44", "AQAAAAIAAYagAAAAEBpS4StbIqx5viKJz/jISQDdvPJgETGUtB9Fwu/fS7CJK90hZN28wqke5jHP/diCug==", null, false, "", false, "normalUser44" },
                    { 45, 0, "HCM", "f0600ed4-c11a-4ed4-9dc4-accb76c78a3d", "normaluser45@gmail.com", true, "45", true, "Nguyen Van", false, null, "normaluser45@gmail.com", "normalUser45", "AQAAAAIAAYagAAAAEINE3BgKKEqaPZY+MY3WrJ43lmMdmL3gESvbm1QHwwMdl1XJZNsJlX0zzDlHhMUD3g==", null, false, "", false, "normalUser45" },
                    { 46, 0, "HCM", "88bd2750-ac3c-4c54-848f-06184534eaeb", "normaluser46@gmail.com", true, "46", true, "Nguyen Van", false, null, "normaluser46@gmail.com", "normalUser46", "AQAAAAIAAYagAAAAEAh89Cnbi7vrDlcgwo3v0KBjIZL/RrD7IJTNz7Yv48i6SYraIhZENEVpyplZfWdnHA==", null, false, "", false, "normalUser46" },
                    { 47, 0, "HCM", "16f98db9-c65d-4416-b63a-6c981d6c18ec", "normaluser47@gmail.com", true, "47", true, "Nguyen Van", false, null, "normaluser47@gmail.com", "normalUser47", "AQAAAAIAAYagAAAAEF+yP09x7ExdeTqOZrd7bEs2gXt8l09HI1sdZZYz9gIXSos692e/YUWrjmVYyvJonw==", null, false, "", false, "normalUser47" },
                    { 48, 0, "HCM", "82535705-f4be-4855-98ee-becb0b4390fe", "normaluser48@gmail.com", true, "48", true, "Nguyen Van", false, null, "normaluser48@gmail.com", "normalUser48", "AQAAAAIAAYagAAAAEPWxHDDEXWbBtzdx+5OZk1kDRXVogCP+ptsIrT71gc3fekdnolhaujpNmNO3SsGwYA==", null, false, "", false, "normalUser48" },
                    { 49, 0, "HCM", "aeb7fd69-e1c4-4c01-b677-b5e62835af4b", "normaluser49@gmail.com", true, "49", true, "Nguyen Van", false, null, "normaluser49@gmail.com", "normalUser49", "AQAAAAIAAYagAAAAEJ7FMOysQU6FtWDFXCwcimtENA3Zhkj/ZPuUNfjcGPQ4pIbVt89oio/nxWu9xT6jvg==", null, false, "", false, "normalUser49" },
                    { 50, 0, "HCM", "0e2f0ba3-28c3-406a-b49e-175cc7013129", "normaluser50@gmail.com", true, "50", true, "Nguyen Van", false, null, "normaluser50@gmail.com", "normalUser50", "AQAAAAIAAYagAAAAEFMs2oYvMUDiH36VhgLWfS2AjyDKwmbJ+767lNuiq9J3sGOvTfxkZwWjSJC1xXbFPw==", null, false, "", false, "normalUser50" },
                    { 51, 0, "HCM", "c61e5b2f-c4b6-4211-a934-c67971b2e538", "normaluser51@gmail.com", true, "51", true, "Nguyen Van", false, null, "normaluser51@gmail.com", "normalUser51", "AQAAAAIAAYagAAAAEMNWmxZFAOiq7f6WFUAABO5zslcXnXeHc+iIY82Z1ZdfBtr2iPiTliQ2r5zdHAdCZg==", null, false, "", false, "normalUser51" },
                    { 52, 0, "HCM", "08ec4010-d28b-42f9-a84f-795f60af71b2", "normaluser52@gmail.com", true, "52", true, "Nguyen Van", false, null, "normaluser52@gmail.com", "normalUser52", "AQAAAAIAAYagAAAAEOig9Qtf4AWz3MiPp77PxJ0NvfnydYhUnFB9cJmWztpDcEzYSd1Uy0EK9vyu8/Hp3w==", null, false, "", false, "normalUser52" },
                    { 53, 0, "HCM", "d0d9eea5-ad2f-403f-8932-78e44d9cb062", "normaluser53@gmail.com", true, "53", true, "Nguyen Van", false, null, "normaluser53@gmail.com", "normalUser53", "AQAAAAIAAYagAAAAEPsKbwJZjjsRMzEk0ueEaSc/kuBwtuBDEsGBqUusSX+13aBwPigwewJ9elSvzyxftA==", null, false, "", false, "normalUser53" },
                    { 54, 0, "HCM", "1e4e77c2-341f-4bf1-b268-5c1ff45f5eb6", "normaluser54@gmail.com", true, "54", true, "Nguyen Van", false, null, "normaluser54@gmail.com", "normalUser54", "AQAAAAIAAYagAAAAECwtGEf49iTH6420Ly+xsgPs6aNkjK17hvfHNWKaGrcS1WACzaf7mcjf08DrFmZ6pA==", null, false, "", false, "normalUser54" },
                    { 55, 0, "HCM", "d9a5428a-1f4e-4595-99a7-d7ab9ad2132a", "normaluser55@gmail.com", true, "55", true, "Nguyen Van", false, null, "normaluser55@gmail.com", "normalUser55", "AQAAAAIAAYagAAAAEC/0CBGd1+C8KaH765peO8gET7Fr7Q7oejCSS/rPAff4uQRizd7NgjxieNWY/oTKWw==", null, false, "", false, "normalUser55" },
                    { 56, 0, "HCM", "9bfb82e6-7689-4bbe-b4e3-26d34f97d1af", "normaluser56@gmail.com", true, "56", true, "Nguyen Van", false, null, "normaluser56@gmail.com", "normalUser56", "AQAAAAIAAYagAAAAEEoY2g9gQGPCcW6GutvFIfOgTZeUlJUSriFcnG+AHPJZazv0LCAGMT3c84egP6YiPw==", null, false, "", false, "normalUser56" },
                    { 57, 0, "HCM", "83e9988b-592e-4dde-8e49-770c4d922931", "normaluser57@gmail.com", true, "57", true, "Nguyen Van", false, null, "normaluser57@gmail.com", "normalUser57", "AQAAAAIAAYagAAAAEAd42gCprkEK/3zBnSSdbLIgCFVjUwcVdKbOwrcGTEEWCYUEIDmrdHXm1c9V9MogVw==", null, false, "", false, "normalUser57" },
                    { 58, 0, "HCM", "95639ff0-d4fd-4447-84a8-3e1a2e1f04c0", "normaluser58@gmail.com", true, "58", true, "Nguyen Van", false, null, "normaluser58@gmail.com", "normalUser58", "AQAAAAIAAYagAAAAECwHw+12u2eJPNGJ/Oi76keKjqSMps1Z6OFsiT7l5wCenRh23vMlMzg5smT7J00A7g==", null, false, "", false, "normalUser58" },
                    { 59, 0, "HCM", "41944a5e-21ec-4429-82c7-7527be79aa0b", "normaluser59@gmail.com", true, "59", true, "Nguyen Van", false, null, "normaluser59@gmail.com", "normalUser59", "AQAAAAIAAYagAAAAELTcht99F2mT3Ul+EjgZVxBuZ8pcHY8Ow+OJnJaQf0N96GfGn+UUyJ2boGdIN3U0IQ==", null, false, "", false, "normalUser59" },
                    { 60, 0, "HCM", "ba4ccae5-a196-4a55-a1dd-091f7c3e7d36", "normaluser60@gmail.com", true, "60", true, "Nguyen Van", false, null, "normaluser60@gmail.com", "normalUser60", "AQAAAAIAAYagAAAAELTnjZWaHOVKWgbA9YGliezpgRONu9BzyGfY2hW7hHQU2CwnZctPkKiEnrYU0LGaUA==", null, false, "", false, "normalUser60" }
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
                    { 5, 31 },
                    { 7, 32 },
                    { 5, 33 },
                    { 6, 34 },
                    { 1, 35 },
                    { 5, 36 },
                    { 4, 37 },
                    { 6, 38 },
                    { 5, 39 },
                    { 6, 40 },
                    { 1, 41 },
                    { 2, 42 },
                    { 7, 43 },
                    { 6, 44 },
                    { 2, 45 },
                    { 6, 46 },
                    { 6, 47 },
                    { 6, 48 },
                    { 1, 49 },
                    { 8, 50 },
                    { 7, 51 },
                    { 3, 52 },
                    { 8, 53 },
                    { 5, 54 },
                    { 7, 55 },
                    { 5, 56 },
                    { 6, 57 },
                    { 2, 58 },
                    { 1, 59 },
                    { 2, 60 }
                });

            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "Id", "ApplyExpireDate", "BusinessProfileId", "CreatedDate", "Description", "IsActive", "Name", "Offer" },
                values: new object[,]
                {
                    { 1, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(3619), "This a simple description for project 1 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 1", 99.0 },
                    { 2, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 2, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(3690), "This a simple description for project 2 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 2", 198.0 },
                    { 3, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(3704), "This a simple description for project 3 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 3", 297.0 },
                    { 4, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 3, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(3717), "This a simple description for project 4 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 4", 396.0 },
                    { 5, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(3775), "This a simple description for project 5 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 5", 495.0 },
                    { 6, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 30, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(3792), "This a simple description for project 6 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 6", 594.0 },
                    { 7, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(3806), "This a simple description for project 7 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 7", 693.0 },
                    { 8, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(3818), "This a simple description for project 8 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 8", 792.0 },
                    { 9, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(3830), "This a simple description for project 9 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 9", 891.0 },
                    { 10, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(3845), "This a simple description for project 10 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 10", 990.0 },
                    { 11, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(3965), "This a simple description for project 11 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 11", 1089.0 },
                    { 12, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(3981), "This a simple description for project 12 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 12", 1188.0 },
                    { 13, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(3994), "This a simple description for project 13 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 13", 1287.0 },
                    { 14, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(4006), "This a simple description for project 14 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 14", 1386.0 },
                    { 15, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(4018), "This a simple description for project 15 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 15", 1485.0 },
                    { 16, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(4030), "This a simple description for project 16 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 16", 1584.0 },
                    { 17, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(4082), "This a simple description for project 17 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 17", 1683.0 },
                    { 18, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 22, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(4099), "This a simple description for project 18 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 18", 1782.0 },
                    { 19, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(4111), "This a simple description for project 19 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 19", 1881.0 },
                    { 20, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 1, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(4123), "This a simple description for project 20 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 20", 1980.0 },
                    { 21, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 4, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(4135), "This a simple description for project 21 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 21", 2079.0 },
                    { 22, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(4187), "This a simple description for project 22 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 22", 2178.0 },
                    { 23, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(4201), "This a simple description for project 23 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 23", 2277.0 },
                    { 24, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 2, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(4214), "This a simple description for project 24 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 24", 2376.0 },
                    { 25, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(4226), "This a simple description for project 25 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 25", 2475.0 },
                    { 26, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(4237), "This a simple description for project 26 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 26", 2574.0 },
                    { 27, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(4250), "This a simple description for project 27 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 27", 2673.0 },
                    { 28, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(4300), "This a simple description for project 28 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 28", 2772.0 },
                    { 29, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(4315), "This a simple description for project 29 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 29", 2871.0 },
                    { 30, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5113), "This a simple description for project 30 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 30", 2970.0 },
                    { 31, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5183), "This a simple description for project 31 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 31", 3069.0 },
                    { 32, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5197), "This a simple description for project 32 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 32", 3168.0 },
                    { 33, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 3, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5209), "This a simple description for project 33 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 33", 3267.0 },
                    { 34, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 25, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5287), "This a simple description for project 34 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 34", 3366.0 },
                    { 35, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5300), "This a simple description for project 35 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 35", 3465.0 },
                    { 36, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5313), "This a simple description for project 36 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 36", 3564.0 },
                    { 37, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5325), "This a simple description for project 37 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 37", 3663.0 },
                    { 38, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5338), "This a simple description for project 38 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 38", 3762.0 },
                    { 39, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5394), "This a simple description for project 39 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 39", 3861.0 },
                    { 40, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5409), "This a simple description for project 40 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 40", 3960.0 },
                    { 41, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5422), "This a simple description for project 41 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 41", 4059.0 },
                    { 42, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 3, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5435), "This a simple description for project 42 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 42", 4158.0 },
                    { 43, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 12, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5447), "This a simple description for project 43 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 43", 4257.0 },
                    { 44, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 3, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5460), "This a simple description for project 44 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 44", 4356.0 },
                    { 45, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5515), "This a simple description for project 45 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 45", 4455.0 },
                    { 46, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5530), "This a simple description for project 46 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 46", 4554.0 },
                    { 47, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 5, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5543), "This a simple description for project 47 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 47", 4653.0 },
                    { 48, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5556), "This a simple description for project 48 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 48", 4752.0 },
                    { 49, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 27, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5568), "This a simple description for project 49 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 49", 4851.0 },
                    { 50, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5581), "This a simple description for project 50 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", true, "Project 50", 4950.0 },
                    { 51, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 18, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5640), "This a simple description for project 51 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 51", 5049.0 },
                    { 52, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5655), "This a simple description for project 52 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 52", 5148.0 },
                    { 53, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5668), "This a simple description for project 53 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 53", 5247.0 },
                    { 54, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5681), "This a simple description for project 54 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 54", 5346.0 },
                    { 55, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 23, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5693), "This a simple description for project 55 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 55", 5445.0 },
                    { 56, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 30, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5706), "This a simple description for project 56 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 56", 5544.0 },
                    { 57, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5798), "This a simple description for project 57 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 57", 5643.0 },
                    { 58, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 21, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5812), "This a simple description for project 58 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 58", 5742.0 },
                    { 59, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5825), "This a simple description for project 59 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 59", 5841.0 },
                    { 60, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5838), "This a simple description for project 60 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 60", 5940.0 },
                    { 61, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5850), "This a simple description for project 61 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 61", 6039.0 },
                    { 62, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 7, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5909), "This a simple description for project 62 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 62", 6138.0 },
                    { 63, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5924), "This a simple description for project 63 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 63", 6237.0 },
                    { 64, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 28, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5937), "This a simple description for project 64 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 64", 6336.0 },
                    { 65, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 1, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5949), "This a simple description for project 65 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 65", 6435.0 },
                    { 66, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 4, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(5966), "This a simple description for project 66 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 66", 6534.0 },
                    { 67, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 17, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6020), "This a simple description for project 67 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 67", 6633.0 },
                    { 68, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6034), "This a simple description for project 68 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 68", 6732.0 },
                    { 69, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 2, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6047), "This a simple description for project 69 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 69", 6831.0 },
                    { 70, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 11, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6060), "This a simple description for project 70 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 70", 6930.0 },
                    { 71, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6072), "This a simple description for project 71 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 71", 7029.0 },
                    { 72, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 13, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6085), "This a simple description for project 72 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 72", 7128.0 },
                    { 73, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 2, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6138), "This a simple description for project 73 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 73", 7227.0 },
                    { 74, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 24, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6153), "This a simple description for project 74 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 74", 7326.0 },
                    { 75, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 1, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6165), "This a simple description for project 75 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 75", 7425.0 },
                    { 76, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 29, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6178), "This a simple description for project 76 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 76", 7524.0 },
                    { 77, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 30, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6191), "This a simple description for project 77 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 77", 7623.0 },
                    { 78, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6204), "This a simple description for project 78 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 78", 7722.0 },
                    { 79, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6256), "This a simple description for project 79 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 79", 7821.0 },
                    { 80, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6269), "This a simple description for project 80 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 80", 7920.0 },
                    { 81, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 3, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6282), "This a simple description for project 81 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 81", 8019.0 },
                    { 82, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 2, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6295), "This a simple description for project 82 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 82", 8118.0 },
                    { 83, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6307), "This a simple description for project 83 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 83", 8217.0 },
                    { 84, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6463), "This a simple description for project 84 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 84", 8316.0 },
                    { 85, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 15, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6484), "This a simple description for project 85 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 85", 8415.0 },
                    { 86, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 1, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6497), "This a simple description for project 86 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 86", 8514.0 },
                    { 87, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6510), "This a simple description for project 87 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 87", 8613.0 },
                    { 88, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 26, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6523), "This a simple description for project 88 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 88", 8712.0 },
                    { 89, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 30, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6535), "This a simple description for project 89 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 89", 8811.0 },
                    { 90, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 8, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6694), "This a simple description for project 90 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 90", 8910.0 },
                    { 91, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 14, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6714), "This a simple description for project 91 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 91", 9009.0 },
                    { 92, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6727), "This a simple description for project 92 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 92", 9108.0 },
                    { 93, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6740), "This a simple description for project 93 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 93", 9207.0 },
                    { 94, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 19, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6753), "This a simple description for project 94 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 94", 9306.0 },
                    { 95, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 20, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6765), "This a simple description for project 95 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 95", 9405.0 },
                    { 96, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 4, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6820), "This a simple description for project 96 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 96", 9504.0 },
                    { 97, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 2, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6835), "This a simple description for project 97 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 97", 9603.0 },
                    { 98, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 9, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6848), "This a simple description for project 98 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 98", 9702.0 },
                    { 99, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 2, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6860), "This a simple description for project 99 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 99", 9801.0 },
                    { 100, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 16, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6874), "This a simple description for project 100 As a Software Developer, your primary responsibility is to design, develop, and maintain software applications and systems. You will collaborate with a team of developers and other stakeholders to understand requirements, create efficient code, and deliver high-quality software solutions.", false, "Project 100", 9900.0 }
                });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "Id", "CreateDate", "FreelancerProfileId", "IsAccepted", "JobId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6908), 32, true, 1 },
                    { 2, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6919), 40, false, 1 },
                    { 3, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6928), 51, true, 1 },
                    { 4, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6936), 55, false, 1 },
                    { 5, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6943), 34, true, 2 },
                    { 6, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(6951), 45, false, 2 },
                    { 7, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7022), 50, true, 2 },
                    { 8, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7029), 58, false, 2 },
                    { 9, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7035), 34, true, 3 },
                    { 10, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7042), 40, false, 3 },
                    { 11, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7048), 51, true, 3 },
                    { 12, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7053), 56, false, 3 },
                    { 13, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7059), 32, true, 4 },
                    { 14, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7065), 45, false, 4 },
                    { 15, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7071), 50, true, 4 },
                    { 16, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7076), 57, false, 4 },
                    { 17, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7082), 31, true, 5 },
                    { 18, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7088), 45, false, 5 },
                    { 19, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7094), 53, true, 5 },
                    { 20, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7099), 58, false, 5 },
                    { 21, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7105), 31, true, 6 },
                    { 22, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7111), 38, false, 6 },
                    { 23, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7116), 48, true, 6 },
                    { 24, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7122), 55, false, 6 },
                    { 25, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7127), 34, true, 7 },
                    { 26, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7133), 39, false, 7 },
                    { 27, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7139), 52, true, 7 },
                    { 28, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7144), 57, false, 7 },
                    { 29, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7150), 36, true, 8 },
                    { 30, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7155), 44, false, 8 },
                    { 31, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7162), 48, true, 8 },
                    { 32, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7168), 55, false, 8 },
                    { 33, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7174), 35, true, 9 },
                    { 34, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7221), 39, false, 9 },
                    { 35, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7228), 50, true, 9 },
                    { 36, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7233), 57, false, 9 },
                    { 37, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7239), 37, true, 10 },
                    { 38, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7245), 41, false, 10 },
                    { 39, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7250), 50, true, 10 },
                    { 40, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7256), 54, false, 10 },
                    { 41, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7261), 32, true, 11 },
                    { 42, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7267), 42, false, 11 },
                    { 43, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7272), 49, true, 11 },
                    { 44, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7278), 57, false, 11 },
                    { 45, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7284), 36, true, 12 },
                    { 46, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7289), 38, false, 12 },
                    { 47, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7295), 50, true, 12 },
                    { 48, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7300), 57, false, 12 },
                    { 49, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7306), 35, true, 13 },
                    { 50, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7311), 38, false, 13 },
                    { 51, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7316), 49, true, 13 },
                    { 52, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7322), 58, false, 13 },
                    { 53, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7328), 37, true, 14 },
                    { 54, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7333), 40, false, 14 },
                    { 55, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7339), 46, true, 14 },
                    { 56, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7344), 54, false, 14 },
                    { 57, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7350), 34, true, 15 },
                    { 58, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7356), 45, false, 15 },
                    { 59, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7361), 48, true, 15 },
                    { 60, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7367), 58, false, 15 },
                    { 61, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7417), 36, true, 16 },
                    { 62, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7424), 38, false, 16 },
                    { 63, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7430), 47, true, 16 },
                    { 64, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7435), 58, false, 16 },
                    { 65, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7441), 35, true, 17 },
                    { 66, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7449), 42, false, 17 },
                    { 67, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7454), 48, true, 17 },
                    { 68, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7460), 59, false, 17 },
                    { 69, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7466), 33, true, 18 },
                    { 70, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7471), 45, false, 18 },
                    { 71, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7477), 52, true, 18 },
                    { 72, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7483), 56, false, 18 },
                    { 73, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7488), 35, true, 19 },
                    { 74, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7494), 42, false, 19 },
                    { 75, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7499), 49, true, 19 },
                    { 76, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7505), 54, false, 19 },
                    { 77, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7510), 35, true, 20 },
                    { 78, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7516), 38, false, 20 },
                    { 79, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7522), 51, true, 20 },
                    { 80, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7527), 56, false, 20 },
                    { 81, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7533), 36, true, 21 },
                    { 82, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7538), 41, false, 21 },
                    { 83, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7544), 49, true, 21 },
                    { 84, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7550), 57, false, 21 },
                    { 85, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7556), 31, true, 22 },
                    { 86, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7562), 40, false, 22 },
                    { 87, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7608), 50, true, 22 },
                    { 88, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7614), 55, false, 22 },
                    { 89, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7620), 34, true, 23 },
                    { 90, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7625), 41, false, 23 },
                    { 91, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7631), 46, true, 23 },
                    { 92, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7636), 59, false, 23 },
                    { 93, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7642), 34, true, 24 },
                    { 94, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7647), 42, false, 24 },
                    { 95, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7653), 49, true, 24 },
                    { 96, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7658), 58, false, 24 },
                    { 97, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7664), 37, true, 25 },
                    { 98, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7669), 44, false, 25 },
                    { 99, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7675), 49, true, 25 },
                    { 100, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7681), 58, false, 25 },
                    { 101, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7687), 32, true, 26 },
                    { 102, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7693), 44, false, 26 },
                    { 103, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7698), 47, true, 26 },
                    { 104, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7704), 56, false, 26 },
                    { 105, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7709), 31, true, 27 },
                    { 106, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7715), 41, false, 27 },
                    { 107, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7721), 48, true, 27 },
                    { 108, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7726), 58, false, 27 },
                    { 109, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7732), 33, true, 28 },
                    { 110, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7737), 42, false, 28 },
                    { 111, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7743), 48, true, 28 },
                    { 112, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7749), 54, false, 28 },
                    { 113, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7755), 33, true, 29 },
                    { 114, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7761), 38, false, 29 },
                    { 115, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7766), 47, true, 29 },
                    { 116, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7818), 56, false, 29 },
                    { 117, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7824), 31, true, 30 },
                    { 118, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7829), 39, false, 30 },
                    { 119, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7835), 47, true, 30 },
                    { 120, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7841), 55, false, 30 },
                    { 121, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7846), 37, true, 31 },
                    { 122, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7852), 45, false, 31 },
                    { 123, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7858), 53, true, 31 },
                    { 124, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7863), 59, false, 31 },
                    { 125, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7869), 37, true, 32 },
                    { 126, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7875), 39, false, 32 },
                    { 127, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7880), 53, true, 32 },
                    { 128, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7886), 57, false, 32 },
                    { 129, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7891), 32, true, 33 },
                    { 130, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7899), 39, false, 33 },
                    { 131, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7904), 51, true, 33 },
                    { 132, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7910), 54, false, 33 },
                    { 133, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7916), 34, true, 34 },
                    { 134, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7921), 44, false, 34 },
                    { 135, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7927), 48, true, 34 },
                    { 136, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7932), 55, false, 34 },
                    { 137, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7938), 34, true, 35 },
                    { 138, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7985), 43, false, 35 },
                    { 139, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7992), 51, true, 35 },
                    { 140, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(7997), 57, false, 35 },
                    { 141, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8003), 33, true, 36 },
                    { 142, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8009), 44, false, 36 },
                    { 143, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8014), 53, true, 36 },
                    { 144, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8020), 57, false, 36 },
                    { 145, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8025), 33, true, 37 },
                    { 146, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8031), 42, false, 37 },
                    { 147, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8036), 50, true, 37 },
                    { 148, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8042), 56, false, 37 },
                    { 149, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8048), 33, true, 38 },
                    { 150, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8054), 42, false, 38 },
                    { 151, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8059), 48, true, 38 },
                    { 152, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8065), 58, false, 38 },
                    { 153, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8071), 33, true, 39 },
                    { 154, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8076), 38, false, 39 },
                    { 155, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8082), 48, true, 39 },
                    { 156, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8088), 59, false, 39 },
                    { 157, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8094), 36, true, 40 },
                    { 158, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8099), 42, false, 40 },
                    { 159, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8105), 47, true, 40 },
                    { 160, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8112), 55, false, 40 },
                    { 161, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8117), 36, true, 41 },
                    { 162, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8123), 41, false, 41 },
                    { 163, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8129), 52, true, 41 },
                    { 164, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8135), 58, false, 41 },
                    { 165, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8141), 33, true, 42 },
                    { 166, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8147), 43, false, 42 },
                    { 167, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8196), 48, true, 42 },
                    { 168, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8202), 58, false, 42 },
                    { 169, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8208), 33, true, 43 },
                    { 170, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8214), 38, false, 43 },
                    { 171, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8219), 46, true, 43 },
                    { 172, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8225), 55, false, 43 },
                    { 173, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8230), 32, true, 44 },
                    { 174, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8236), 44, false, 44 },
                    { 175, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8241), 49, true, 44 },
                    { 176, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8247), 59, false, 44 },
                    { 177, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8253), 35, true, 45 },
                    { 178, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8258), 41, false, 45 },
                    { 179, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8264), 49, true, 45 },
                    { 180, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8269), 58, false, 45 },
                    { 181, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8275), 35, true, 46 },
                    { 182, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8280), 38, false, 46 },
                    { 183, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8286), 50, true, 46 },
                    { 184, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8291), 58, false, 46 },
                    { 185, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8297), 35, true, 47 },
                    { 186, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8303), 38, false, 47 },
                    { 187, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8308), 51, true, 47 },
                    { 188, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8314), 54, false, 47 },
                    { 189, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8320), 34, true, 48 },
                    { 190, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8325), 41, false, 48 },
                    { 191, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8331), 47, true, 48 },
                    { 192, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8336), 54, false, 48 },
                    { 193, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8342), 32, true, 49 },
                    { 194, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8348), 38, false, 49 },
                    { 195, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8354), 53, true, 49 },
                    { 196, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8400), 59, false, 49 },
                    { 197, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8407), 32, true, 50 },
                    { 198, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8412), 41, false, 50 },
                    { 199, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8418), 48, true, 50 },
                    { 200, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8424), 57, false, 50 },
                    { 201, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8429), 34, true, 51 },
                    { 202, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8435), 44, false, 51 },
                    { 203, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8440), 53, true, 51 },
                    { 204, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8446), 56, false, 51 },
                    { 205, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8451), 35, true, 52 },
                    { 206, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8457), 40, false, 52 },
                    { 207, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8462), 48, true, 52 },
                    { 208, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8468), 56, false, 52 },
                    { 209, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8473), 35, true, 53 },
                    { 210, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8479), 45, false, 53 },
                    { 211, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8484), 49, true, 53 },
                    { 212, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8490), 58, false, 53 },
                    { 213, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8495), 33, true, 54 },
                    { 214, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8501), 41, false, 54 },
                    { 215, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8507), 50, true, 54 },
                    { 216, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8512), 55, false, 54 },
                    { 217, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8518), 34, true, 55 },
                    { 218, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8523), 38, false, 55 },
                    { 219, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8529), 53, true, 55 },
                    { 220, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8534), 59, false, 55 },
                    { 221, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8540), 37, true, 56 },
                    { 222, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8545), 44, false, 56 },
                    { 223, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8551), 49, true, 56 },
                    { 224, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8556), 56, false, 56 },
                    { 225, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8617), 31, true, 57 },
                    { 226, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8625), 44, false, 57 },
                    { 227, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8631), 49, true, 57 },
                    { 228, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8636), 54, false, 57 },
                    { 229, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8642), 36, true, 58 },
                    { 230, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8648), 42, false, 58 },
                    { 231, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8653), 46, true, 58 },
                    { 232, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8659), 54, false, 58 },
                    { 233, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8665), 32, true, 59 },
                    { 234, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8671), 40, false, 59 },
                    { 235, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8676), 46, true, 59 },
                    { 236, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8682), 55, false, 59 },
                    { 237, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8687), 35, true, 60 },
                    { 238, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8693), 40, false, 60 },
                    { 239, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8698), 47, true, 60 },
                    { 240, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8704), 54, false, 60 },
                    { 241, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8710), 36, true, 61 },
                    { 242, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8716), 40, false, 61 },
                    { 243, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8721), 50, true, 61 },
                    { 244, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8727), 56, false, 61 },
                    { 245, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8732), 31, true, 62 },
                    { 246, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8738), 38, false, 62 },
                    { 247, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8743), 50, true, 62 },
                    { 248, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8749), 58, false, 62 },
                    { 249, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8755), 31, true, 63 },
                    { 250, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8760), 39, false, 63 },
                    { 251, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8766), 53, true, 63 },
                    { 252, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8771), 56, false, 63 },
                    { 253, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8777), 32, true, 64 },
                    { 254, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8783), 40, false, 64 },
                    { 255, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8828), 47, true, 64 },
                    { 256, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8834), 57, false, 64 },
                    { 257, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8840), 32, true, 65 },
                    { 258, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8848), 40, false, 65 },
                    { 259, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8854), 47, true, 65 },
                    { 260, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8859), 59, false, 65 },
                    { 261, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8865), 34, true, 66 },
                    { 262, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8871), 44, false, 66 },
                    { 263, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8876), 47, true, 66 },
                    { 264, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8882), 57, false, 66 },
                    { 265, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8887), 37, true, 67 },
                    { 266, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8893), 39, false, 67 },
                    { 267, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8898), 47, true, 67 },
                    { 268, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8904), 55, false, 67 },
                    { 269, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8948), 37, true, 68 },
                    { 270, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8955), 42, false, 68 },
                    { 271, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8960), 50, true, 68 },
                    { 272, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8966), 56, false, 68 },
                    { 273, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8973), 37, true, 69 },
                    { 274, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8979), 44, false, 69 },
                    { 275, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8985), 52, true, 69 },
                    { 276, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8991), 57, false, 69 },
                    { 277, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(8997), 32, true, 70 },
                    { 278, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9003), 38, false, 70 },
                    { 279, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9008), 52, true, 70 },
                    { 280, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9014), 56, false, 70 },
                    { 281, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9020), 32, true, 71 },
                    { 282, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9025), 41, false, 71 },
                    { 283, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9031), 50, true, 71 },
                    { 284, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9036), 59, false, 71 },
                    { 285, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9042), 31, true, 72 },
                    { 286, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9047), 40, false, 72 },
                    { 287, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9053), 47, true, 72 },
                    { 288, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9059), 58, false, 72 },
                    { 289, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9064), 36, true, 73 },
                    { 290, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9070), 43, false, 73 },
                    { 291, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9076), 49, true, 73 },
                    { 292, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9081), 57, false, 73 },
                    { 293, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9087), 34, true, 74 },
                    { 294, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9092), 39, false, 74 },
                    { 295, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9098), 46, true, 74 },
                    { 296, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9103), 54, false, 74 },
                    { 297, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9109), 33, true, 75 },
                    { 298, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9156), 44, false, 75 },
                    { 299, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9162), 47, true, 75 },
                    { 300, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9168), 59, false, 75 },
                    { 301, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9174), 31, true, 76 },
                    { 302, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9179), 43, false, 76 },
                    { 303, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9184), 47, true, 76 },
                    { 304, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9190), 58, false, 76 },
                    { 305, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9196), 32, true, 77 },
                    { 306, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9201), 42, false, 77 },
                    { 307, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9206), 48, true, 77 },
                    { 308, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9212), 59, false, 77 },
                    { 309, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9218), 35, true, 78 },
                    { 310, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9223), 41, false, 78 },
                    { 311, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9229), 48, true, 78 },
                    { 312, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9234), 57, false, 78 },
                    { 313, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9240), 35, true, 79 },
                    { 314, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9245), 41, false, 79 },
                    { 315, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9251), 51, true, 79 },
                    { 316, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9256), 54, false, 79 },
                    { 317, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9262), 34, true, 80 },
                    { 318, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9267), 44, false, 80 },
                    { 319, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9273), 49, true, 80 },
                    { 320, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9278), 57, false, 80 },
                    { 321, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9284), 31, true, 81 },
                    { 322, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9290), 45, false, 81 },
                    { 323, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9295), 51, true, 81 },
                    { 324, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9301), 54, false, 81 },
                    { 325, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9307), 31, true, 82 },
                    { 326, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9313), 39, false, 82 },
                    { 327, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9360), 46, true, 82 },
                    { 328, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9368), 54, false, 82 },
                    { 329, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9373), 33, true, 83 },
                    { 330, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9379), 45, false, 83 },
                    { 331, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9384), 50, true, 83 },
                    { 332, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9390), 56, false, 83 },
                    { 333, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9395), 32, true, 84 },
                    { 334, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9401), 44, false, 84 },
                    { 335, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9406), 53, true, 84 },
                    { 336, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9412), 59, false, 84 },
                    { 337, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9417), 32, true, 85 },
                    { 338, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9423), 43, false, 85 },
                    { 339, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9429), 52, true, 85 },
                    { 340, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9434), 59, false, 85 },
                    { 341, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9440), 35, true, 86 },
                    { 342, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9445), 40, false, 86 },
                    { 343, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9451), 51, true, 86 },
                    { 344, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9456), 56, false, 86 },
                    { 345, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9462), 31, true, 87 },
                    { 346, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9468), 43, false, 87 },
                    { 347, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9473), 49, true, 87 },
                    { 348, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9478), 58, false, 87 },
                    { 349, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9484), 35, true, 88 },
                    { 350, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9490), 39, false, 88 },
                    { 351, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9495), 46, true, 88 },
                    { 352, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9501), 59, false, 88 },
                    { 353, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9507), 35, true, 89 },
                    { 354, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9512), 44, false, 89 },
                    { 355, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9518), 48, true, 89 },
                    { 356, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9523), 57, false, 89 },
                    { 357, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9573), 35, true, 90 },
                    { 358, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9579), 45, false, 90 },
                    { 359, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9584), 52, true, 90 },
                    { 360, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9590), 55, false, 90 },
                    { 361, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9596), 33, true, 91 },
                    { 362, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9601), 41, false, 91 },
                    { 363, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9607), 47, true, 91 },
                    { 364, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9612), 56, false, 91 },
                    { 365, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9618), 32, true, 92 },
                    { 366, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9623), 43, false, 92 },
                    { 367, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9629), 52, true, 92 },
                    { 368, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9634), 59, false, 92 },
                    { 369, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9640), 36, true, 93 },
                    { 370, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9646), 39, false, 93 },
                    { 371, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9651), 51, true, 93 },
                    { 372, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9658), 55, false, 93 },
                    { 373, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9663), 33, true, 94 },
                    { 374, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9669), 42, false, 94 },
                    { 375, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9675), 50, true, 94 },
                    { 376, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9680), 54, false, 94 },
                    { 377, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9686), 37, true, 95 },
                    { 378, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9692), 39, false, 95 },
                    { 379, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9697), 47, true, 95 },
                    { 380, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9703), 57, false, 95 },
                    { 381, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9708), 33, true, 96 },
                    { 382, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9714), 45, false, 96 },
                    { 383, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9720), 53, true, 96 },
                    { 384, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9725), 54, false, 96 },
                    { 385, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9731), 36, true, 97 },
                    { 386, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9781), 42, false, 97 },
                    { 387, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9787), 47, true, 97 },
                    { 388, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9792), 54, false, 97 },
                    { 389, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9798), 33, true, 98 },
                    { 390, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9804), 44, false, 98 },
                    { 391, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9809), 51, true, 98 },
                    { 392, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9815), 58, false, 98 },
                    { 393, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9821), 36, true, 99 },
                    { 394, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9826), 42, false, 99 },
                    { 395, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9832), 49, true, 99 },
                    { 396, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9837), 54, false, 99 },
                    { 397, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9843), 31, true, 100 },
                    { 398, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9849), 39, false, 100 },
                    { 399, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9854), 47, true, 100 },
                    { 400, new DateTime(2023, 6, 15, 18, 52, 39, 837, DateTimeKind.Local).AddTicks(9860), 56, false, 100 }
                });

            migrationBuilder.InsertData(
                table: "JobCategories",
                columns: new[] { "CategoryId", "JobId" },
                values: new object[,]
                {
                    { 4, 1 },
                    { 7, 2 },
                    { 7, 3 },
                    { 5, 4 },
                    { 8, 5 },
                    { 6, 6 },
                    { 6, 7 },
                    { 1, 8 },
                    { 3, 9 },
                    { 6, 10 },
                    { 6, 11 },
                    { 5, 12 },
                    { 7, 13 },
                    { 8, 14 },
                    { 7, 15 },
                    { 3, 16 },
                    { 5, 17 },
                    { 6, 18 },
                    { 8, 19 },
                    { 5, 20 },
                    { 8, 21 },
                    { 2, 22 },
                    { 3, 23 },
                    { 7, 24 },
                    { 5, 25 },
                    { 8, 26 },
                    { 1, 27 },
                    { 2, 28 },
                    { 4, 29 },
                    { 7, 30 },
                    { 4, 31 },
                    { 6, 32 },
                    { 5, 33 },
                    { 8, 34 },
                    { 5, 35 },
                    { 6, 36 },
                    { 5, 37 },
                    { 7, 38 },
                    { 6, 39 },
                    { 4, 40 },
                    { 6, 41 },
                    { 1, 42 },
                    { 1, 43 },
                    { 2, 44 },
                    { 1, 45 },
                    { 4, 46 },
                    { 5, 47 },
                    { 8, 48 },
                    { 8, 49 },
                    { 2, 50 },
                    { 5, 51 },
                    { 1, 52 },
                    { 6, 53 },
                    { 8, 54 },
                    { 2, 55 },
                    { 7, 56 },
                    { 3, 57 },
                    { 5, 58 },
                    { 8, 59 },
                    { 7, 60 },
                    { 4, 61 },
                    { 6, 62 },
                    { 7, 63 },
                    { 1, 64 },
                    { 8, 65 },
                    { 3, 66 },
                    { 1, 67 },
                    { 7, 68 },
                    { 1, 69 },
                    { 3, 70 },
                    { 2, 71 },
                    { 2, 72 },
                    { 4, 73 },
                    { 4, 74 },
                    { 2, 75 },
                    { 6, 76 },
                    { 1, 77 },
                    { 4, 78 },
                    { 6, 79 },
                    { 3, 80 },
                    { 8, 81 },
                    { 6, 82 },
                    { 7, 83 },
                    { 5, 84 },
                    { 7, 85 },
                    { 2, 86 },
                    { 6, 87 },
                    { 8, 88 },
                    { 3, 89 },
                    { 4, 90 },
                    { 1, 91 },
                    { 3, 92 },
                    { 8, 93 },
                    { 7, 94 },
                    { 1, 95 },
                    { 7, 96 },
                    { 1, 97 },
                    { 6, 98 },
                    { 3, 99 },
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
