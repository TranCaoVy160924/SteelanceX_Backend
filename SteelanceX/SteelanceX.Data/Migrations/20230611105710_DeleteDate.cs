using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SteelanceX.Data.Migrations
{
    /// <inheritdoc />
    public partial class DeleteDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 2, 37 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 8, 38 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 4, 39 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 5, 40 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 6, 41 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 7, 44 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 3, 45 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 1, 46 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 7, 47 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 8, 48 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 5, 49 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 6, 50 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 2, 51 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 1, 52 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 5, 53 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 5, 54 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 4, 55 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 1, 56 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 7, 57 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 3, 58 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 2, 59 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 2, 60 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 5, 61 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 1, 62 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 4, 63 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 3, 64 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 1, 65 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 7, 13 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 6, 14 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 4, 17 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 19 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 7, 20 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 6, 22 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 6, 23 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 4, 24 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 26 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 4, 27 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 29 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 30 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 33 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 6, 34 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 35 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 6, 36 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 7, 37 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 38 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 39 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 40 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 41 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 6, 42 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 44 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 45 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 4, 46 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 1, 47 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 48 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 49 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 51 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 6, 52 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 53 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 1, 54 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 7, 55 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 7, 58 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 59 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 61 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 1, 62 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 63 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 64 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 65 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 6, 66 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 67 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 4, 68 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 7, 70 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 71 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 6, 72 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 1, 73 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 74 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 75 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 76 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 77 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 78 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 7, 79 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 80 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 7, 81 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 7, 82 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 6, 83 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 4, 84 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 85 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 86 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 87 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 88 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 4, 90 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 91 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 93 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 6, 94 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 95 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 7, 96 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 98 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 100 });

            migrationBuilder.DropColumn(
                name: "JobExpiredDate",
                table: "Job");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "92bc372d-2870-4cff-9674-b5395814d624", "AQAAAAIAAYagAAAAEKetKDmGXa6Vf31geUHkpub+YV09ECl8R2/38FZdnO0l2fcIcATUN4kNirxAxstfZA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ea11fa82-29f2-4b04-bf8c-20b61bc5a398", "AQAAAAIAAYagAAAAEDwYWCHPxgD/JojwMc4oTAOPqq8ORUmm8UsR9xztJruuisLMxGkxNL3LakzJPfj91Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "afd50a91-7004-48a8-9148-511ea228cf2a", "AQAAAAIAAYagAAAAENYYvgWDy1oZvsuHznxssGB5A5Lgvhtec0Dq3nxL2wbEEqAMDXRe3zvgvHEHfIHpTg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e3dabfaa-8ebb-43ce-8082-015895c54d10", "AQAAAAIAAYagAAAAEFbOcV0tL3xuHceCZH9nto27SG9BWeoSENJZZV5Elum0awYwc4dBZBVx4/uXbvNrQQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1d31ea4a-4e6b-4116-959c-9b66867b16d3", "AQAAAAIAAYagAAAAEGGTkUcCZSl7ojkZ3JXAIDk9/H5O3ix39fm21R74d4Mhow5qVqjCR/J0k0Ova41iGw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "39227be0-662c-410f-bc96-dd37be5fdcdf", "AQAAAAIAAYagAAAAEBd72CjutuoY2EWThCBP83alHgQVG0xeG7eJG8x1WESoHBc4mZZk2WZPtyRxPyeseQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b0b2b9f5-32f4-4e7a-baf2-1f2191f4ed1c", "AQAAAAIAAYagAAAAEA9LAQgmVXY7pyj/QqmbjZmPaDkvsBS3E1uvMTV9ffhzaZEsRvBnMQvUHAd/djH6VQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ba595501-a4f3-4163-b57a-afbb3968812f", "AQAAAAIAAYagAAAAECPHSWwP4Ww/IxdQSjLugprpzBRzluZXLgg5JHuCzQZEiPeM7dqX1HyM2OQt7juXWA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dd0e1edc-7c81-45f9-94d5-5a2dd89dcc00", "AQAAAAIAAYagAAAAELXuMiyp7vTvgQCO7gWhmMDb/AaoM0iRvTkOy+uROpSPD6IKxy5zNxF1J2CsB9AgbQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "721ea3ae-2570-41f3-84fc-150d4e300156", "AQAAAAIAAYagAAAAEFslNBOkyVKUpr5z32z/Q3wo6ANKP0HYgDYUeH8xQXqt+iASPa0nVGuYcu43CDdqhA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f51f9d10-e0bf-43a9-a4b6-ae8a7690dbc6", "AQAAAAIAAYagAAAAEBQAMbOjHKBb0nnKOdq10nLQB2CmoRpAI1sOZkJKZasOHkj5DGVQ0AeqlA/hZmuxXQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f930ac33-9524-4c8d-8356-a74b2950d93f", "AQAAAAIAAYagAAAAEJ3U8CaBAyR3ABlM807CygyNfbZw+6Xcv0U6hgsWQtHGnXIbSJb08EVTvwevOJqahg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b644beb9-0916-413e-98b5-071738ea00bf", "AQAAAAIAAYagAAAAECwhYGnl72X9A6pb3Glw7DZkbAGtJJ9L4dAeLv29vf23OIGJMmHKvZAMJYTmLVrkig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3ba7197d-4a61-4ee0-b7f4-a131d11db042", "AQAAAAIAAYagAAAAEEsFUTLAq8XTHzviT6SZCjE+oXMgVbYqW8wDCbmtis+Q09WQCU+DV2DUOFWzg0GQXQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6be25221-23ba-48d5-8264-41ec1c065f48", "AQAAAAIAAYagAAAAEKi8T9oRmJv0qw2918sY+Nczykke970YaUcpKgxbY9IHiuQnXWjuJSZsW9LwvDDmhg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "43da7adf-4d2e-4398-a252-408be5f3b096", "AQAAAAIAAYagAAAAEINovxQbbfTBIn0yagXf+FL919qj8wqScKnGrnjHLTdb6tVWGFfZq7WVwu8TCwnE1w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "93606076-2f69-49b2-9686-9469eaf76d47", "AQAAAAIAAYagAAAAEORddTwcrieNTOAs7JuBeeV61VqsxDtS1GaM3BriWdu0YSgN53SoAf5Zht7ZLYX2ow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e5891ee0-b4b8-4a66-9eb4-1c73a010f55e", "AQAAAAIAAYagAAAAEI2+ETbpcPS8SxyVC7LDGZsCC/h5RNEPy3vWt5ifz8BaxM4NITO5+wzIhq+GW68MFg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b21a307c-630e-4a5c-849a-2120c9472b53", "AQAAAAIAAYagAAAAEItpCBuJXNI3ZMGPRM5gbXwPqekEPrkW/cVFXJEP0U2iHF3rb0P06q7ix/+eDRLFZQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "72f6e6ec-5dd5-426b-b631-9bfd381c3fbf", "AQAAAAIAAYagAAAAEEWB/fd9cZryaDSIvAga+ZpcQYOdDXop9lRpmL5JsfV8VYLKqgyH2+DmUjuM+9t+xQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "162a15ac-5cdd-4058-8c48-a29c7165d579", "AQAAAAIAAYagAAAAENLSGAxb4wTDn5O3q1XfVNI42F9hc3atEuuY9Y403A/FGhxb09UzmRDiYm68HEfB1Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9145f1e7-a11b-4819-8a8b-2cbd199a494e", "AQAAAAIAAYagAAAAEOh6965MRbNQMzFxMlYZmDrKUJN5BX/RUE6bnZZ3h+hDpdgAw4uMpP3o/OjCP614ng==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e411c3bc-e908-463a-8554-d3c428e0e569", "AQAAAAIAAYagAAAAEGOhZ8OviwaTXF8kELhavgYFCqkA0S6H1CEyndxV43HgUgMb2J8VYjeoWxFD+7ig7Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a3d9da27-ca87-4f90-97c1-51871c9e902b", "AQAAAAIAAYagAAAAEDL6lOG6LqSbesDuROrkJgif6L/8HvkdiMH+x1LnvZMI3AYi5xB6358N/+woV8EZbA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9fd2c937-e455-4a57-b66a-312bfb8d0416", "AQAAAAIAAYagAAAAEJAMXnLKvkBABKHsLJ//fRAg8UsxIUJ3cyxisYPRIwnYbaYZPKHXs8LmpUo+fW3Hbw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "55449be1-28e9-4b9a-a17f-f462c6fad82a", "AQAAAAIAAYagAAAAEJ3hJSciPwrmeCJfvJ/rX1KcDOp+L12FZKfLsgqLHVRCJ2MWi++UieYvwravOzvrLw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ec29539e-785a-435b-bf42-cfb99fd89b66", "AQAAAAIAAYagAAAAELzZHLUPjY9OTt31gnujmc6hDFmUZNvEv1XkHcRb0idkpx/X8I0h9N+uab2RcjtDpw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac0c45ea-0987-4e5c-9989-7e99ac1cf421", "AQAAAAIAAYagAAAAENojtWPi+LwNadF8jdLFbPslIv/nEToff6QoQYUB4fH7Asgbs5rSINohHxv+POTw7g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cdc4f5ff-d508-406a-9e60-9232e4c064be", "AQAAAAIAAYagAAAAEBYaIOc/nUO699aF58wnPwL1eebk3VCqvtbuZ8q/GptpK39REsyVb9mVsacOAREZ3w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "feba11eb-5ea7-4416-8f5f-3c1d3af832d6", "AQAAAAIAAYagAAAAEC3f8ljfYSrXiH9n++z8p5IaGhUVSeizs1H4Zg5udQ88qJfatUS3Oc6QxtsR0YNTYg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9bbace95-ab4c-4cf3-a7a0-9013fbea9fdc", "AQAAAAIAAYagAAAAEHZNy97aQdFwIxvDqBaECw5R/iTZOi93HiwNGQ9X0XzeIjpGsjCe8okJ4qAL4/d9Qw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "671c0ad7-de89-487d-8bd2-97a665806658", "AQAAAAIAAYagAAAAEGyGZhno8VL6ocM52wHmKuuG7lWq7fzWQFHFXqzx7iQapP5i7Tp+tGq9+OLaFBZzFQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2706f135-d69c-4d7b-9ec3-39a8a7515250", "AQAAAAIAAYagAAAAEDz0CI61OH906paZ8Wx2oAAR8dqv255FJ7gZtAOyM06esnqH+wsi0UbAuYll8gVOKA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ea97154-765a-42fe-9aa5-9de129ef9186", "AQAAAAIAAYagAAAAEB2PyhVVxvMOT/lQ2SvwOCGWVvEy2gHOk9jhrtvdXBdvYDgdeBuMj0Ch/K0arrJdCg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fa0857d8-6c25-4340-8625-9c6a2b55343e", "AQAAAAIAAYagAAAAECNpaRhATYIjwLyMqeEFu8IWrtfmMQ+IReoAEowxxb/60hKbAoLoUdBDKzVKXT8SVg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0eb348b7-849d-4380-ae0b-4f7b8c40f4db", "AQAAAAIAAYagAAAAEMmBQHHm8NnpHRTb+h5k4ixu3O+0ETd52shQPV/pB9ItysqUAeocxcRAGxwNX0jncQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8fd8afea-5782-4179-87ec-b6a51c3a5323", "AQAAAAIAAYagAAAAEO1JHsRFos9lksRij1ro4XLw8XfYCs56iHNnC/o46pNSiP2bYhe9jngHe4lwVxa1Gw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac0f48f0-11d2-4e6c-904e-3bc066927075", "AQAAAAIAAYagAAAAEBNFgUgxdcEctdIXIZUAM5v6ZrvDyDpWCkt0LZ2zwc3z4pCTWQGtaZFUWkjT2k4ORA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ba3ac6c6-eb2e-4208-aa4b-e10f99912f57", "AQAAAAIAAYagAAAAEAaPsgm9O0yBQGZZoHSQvI5l/ubPqaQgKNilu+h88l4SryXk4Y3W3r4VD7aQo4pdgQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3d20f3db-19e9-4c5d-acef-2bb32f9eae35", "AQAAAAIAAYagAAAAEOlJ1+YMDHTagCyjRAkeOMSSbeVFowOcSnwgKd6HOrDCc3YatPnmyjm7usQ9lBA+tA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dc18b900-cfcf-4ed8-9279-dc15a2575b9d", "AQAAAAIAAYagAAAAEMTqMGIgZe1YmBwu4RZKYjDHyGbV9Q2HEVImljoNqulFUYJ4P8iYn4AXszO0dUOdcw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c2ada76d-d396-42bc-978a-338b0e872662", "AQAAAAIAAYagAAAAEGN36e3RrbJhZ/BHtaht5qpvVzAHeM3XzzOPRh8SXz45GzSfTz06ZLtbDJfDJAxKyw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2e0e7cc3-939e-426a-b813-d415c79adb18", "AQAAAAIAAYagAAAAEMF2Gn4LUaNPmXtF1h9Slpp8cDrkM4ATWIQyDiPsJtZw+5CSxd9WFXaZPxu4QpRtDQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "af12dbfc-3365-4378-92a2-40bd6e5cd016", "AQAAAAIAAYagAAAAELgkZC3OqWXvXVvLn+moxDkvTYChQrhyT1lXDdf9rS6D9t9kEqTRRJ7E6kCPQm3pyQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3c3839d4-23e5-4f87-81f1-f3a882cfc055", "AQAAAAIAAYagAAAAEAzTaJkzgoeiXVZ1nPKsNXsjN7lZOUHVm8X96POrSwaRTHq3yhOaZAj3PgjC8xrgOA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "598e8c78-6026-4e3a-b0f8-51b7abb68f65", "AQAAAAIAAYagAAAAEDqAn6lpsSZoalSoOvjQIAu1FxX81J7IOczVEWdyRqXjdkBGJG4kyQFWWqKHyfwA/g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "49f786bc-6bcd-46a0-b208-e2d4cd9f03b6", "AQAAAAIAAYagAAAAEGIGyp2q1FZLE4TZ5b+nOjAeYBEwdE1+6/mRrej+R4pMp1FX6Ph1l4B1Q2B576+Plg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3276a26d-983d-48d2-af59-263f69eed662", "AQAAAAIAAYagAAAAEDl7eLELBdlaWmwrvxg3Wib7Kv+fPWArS7wtjnxxlrU6ped7qD3QBW0w3Oo411UCJg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a17a10e2-832c-4f69-b6de-fe98734dab3f", "AQAAAAIAAYagAAAAEF/Ph0pE1o35VQ4xItpLB+5p8oXI1ELjhXKMr80CWA7IBiSh0pM+gICK7AYrnENrBg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "53932221-4c7f-44a3-8278-054a8a183c46", "AQAAAAIAAYagAAAAEJdw7cKBsZ+jrPmWOnUPhAlk1xzurErFLbayvKpwcLhBrroGJGt3CMUMI29JpvhP+w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "28be75d1-3bae-4fbd-a3bd-811e62011247", "AQAAAAIAAYagAAAAEKtYjfGW8EQgD2K3T6kwdi0XdbaF/TUU1fH1+f7sqUHb8/2Z7OGG1RL+zGb1WUviDA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "41141ea8-b97a-4f0e-b304-4ee1bf162989", "AQAAAAIAAYagAAAAEMduMmgDBKPrcaZBrezioOK7TEVdRU0yeKExt9r3R14qUPFG/KOo3vMOcsaKaH5YRg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "23d95bc1-670d-4623-b134-b8328162cd07", "AQAAAAIAAYagAAAAEE97psEdP2E1UepBbb1YKo7vjT6g/A1WEqsoDBhkctP4eIA8ttNnoADSdDGYHcgfWw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e2616a81-7088-4ef3-a2df-42ce2a74d0a8", "AQAAAAIAAYagAAAAEKSLknQWIOR7TSf6zEz45ZWlZXQAQFuMK5i5Gna/3zUnE/7EaTY9AWFvchFWQhP7IA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f8a58b71-1d4f-4e09-9e98-6022e40d0a57", "AQAAAAIAAYagAAAAEI0DI4SaJZYxQsXxOLZM7QQvuUdc6SiH1t+pMgO+AYuRC5RNLXQpwTaaCT1ZTZFthg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "74588530-49f2-4dd0-9a78-54db9df61e0c", "AQAAAAIAAYagAAAAEKc1xqAU3Av6StibcEQn17tlhQM7V1HFICKr9aRfUU/o7unNZTYfpWYTpN8cgxDw4g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f2e0159b-3e7b-4f85-ab47-ada18893dc0e", "AQAAAAIAAYagAAAAEPy/uLq7pKMRmqBkI9fAb+/pVmUNks0deuAe2TBnWXj6sq4Vj8oNt+JTuIt7MleldQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "396487b1-8ae7-49d5-95d2-aab268c49e88", "AQAAAAIAAYagAAAAEG8pGr8ag+RldQmV+UOaTw2KVSKOPm7OoLFiCSQgvlebXZWZLzMVVpPsXCfyEKYQYQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d871d271-0861-4388-aba7-ec5a0c2114ec", "AQAAAAIAAYagAAAAEOX7U/ohylwBqkhdjVnnFXNGNgFepmC1IBi+ZFKAkt/rf90LR7R/qMNhlTNLG6hWyA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "87ebe3ee-1de2-418b-814f-434684aab9a9", "AQAAAAIAAYagAAAAELCD4ikdNEMioPkEAD+zDqX5oEZHVVAHIDqmoUlistadl5YXk0jUNF5i9ob98DxQSg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6cf1add7-faf1-431c-84d8-7adf675e951f", "AQAAAAIAAYagAAAAEDw9K1MTjMn0GvuMDFXkZ84Gcicp0w0kAD3IvhTeoNySteAVVkggJXMjxp3S63mB8g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bff4c899-99ba-41d1-9821-bd01e752a8aa", "AQAAAAIAAYagAAAAEBWgfO5itGI9DVmbmuRFYnFL0Qp/CmkDeRdUc4g+Av1OSa9ew0Q9WcVYsHyhKl8ZxA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7798af8d-55d0-4be2-b0ce-53da2551047c", "AQAAAAIAAYagAAAAEIfnydg2lsJlgn6pCxPJ322VdXU4u14cOEIQ+4O9tGPWCmWJeTcqukMnpcUAN85Z6g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4cec517f-2da8-4531-9294-4f57775e9e08", "AQAAAAIAAYagAAAAENida0v9dlPhnRG9JWcZMJYGofINrMTINtSkw7ZpOJXfRSkD4RI2yd4vs2/WYrP7Nw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "036502e1-9567-46b2-aa3c-8c3df22b83ff", "AQAAAAIAAYagAAAAEI2E25QZqJ9tqWvD3rR3NaObOnZxqpTg9GvL01yd8axT4zI3LxjudIaXSm4NloGkCw==" });

            migrationBuilder.InsertData(
                table: "FreelancerCategories",
                columns: new[] { "CategoryId", "FreelancerProfileId" },
                values: new object[,]
                {
                    { 8, 37 },
                    { 5, 38 },
                    { 8, 39 },
                    { 6, 40 },
                    { 8, 41 },
                    { 2, 44 },
                    { 4, 45 },
                    { 7, 46 },
                    { 5, 47 },
                    { 5, 48 },
                    { 1, 49 },
                    { 5, 50 },
                    { 6, 51 },
                    { 6, 52 },
                    { 7, 53 },
                    { 6, 54 },
                    { 8, 55 },
                    { 6, 56 },
                    { 4, 57 },
                    { 5, 58 },
                    { 6, 59 },
                    { 8, 60 },
                    { 3, 61 },
                    { 5, 62 },
                    { 7, 63 },
                    { 8, 64 },
                    { 8, 65 }
                });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 13, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 28, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 19, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(7896) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 28, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(7903) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 28, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 16, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(7918) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 33, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 30, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 30, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(7954) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 25, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 23, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 7, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(7975) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 7, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(7989) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 23, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 30, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 34, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 29, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8026) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 10, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 21, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 13, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 12, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8054) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 32, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8061) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 17, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 18, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 20, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 25, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8097) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 6, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8178) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 29, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 27, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 7, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8215) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 12, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8223) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 6, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8231) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 9, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 18, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8252) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 6, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8259) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 34, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8266) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 33, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 28, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 27, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 16, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8294) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 12, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8301) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 19, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 16, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8321) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 15, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 7, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 27, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 29, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 13, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 17, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 31, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8371) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 30, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8378) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 11, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 19, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 13, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 26, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8413) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 23, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 17, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 6, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8434) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 24, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8441) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 16, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 11, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8455) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 20, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8462) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 22, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8476) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 30, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8483) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 29, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 24, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8497) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 16, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 12, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8511) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 14, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 10, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8525) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 23, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8538) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 19, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 13, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8553) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 27, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 6, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8566) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 13, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8573) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 13, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 7, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8587) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 28, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8594) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 12, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8601) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 23, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 33, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8625) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 8, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8632) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 30, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8639) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 20, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8646) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 17, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 14, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 6, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8668) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 13, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8675) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 26, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8682) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 6, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 10, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 24, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 21, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 27, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 34, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BusinessProfileId", "CreatedDate" },
                values: new object[] { 18, new DateTime(2023, 6, 11, 17, 57, 10, 210, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.InsertData(
                table: "JobCategories",
                columns: new[] { "CategoryId", "JobId" },
                values: new object[,]
                {
                    { 3, 2 },
                    { 1, 3 },
                    { 4, 4 },
                    { 7, 5 },
                    { 5, 6 },
                    { 7, 7 },
                    { 3, 8 },
                    { 7, 9 },
                    { 3, 10 },
                    { 5, 11 },
                    { 2, 12 },
                    { 2, 13 },
                    { 4, 14 },
                    { 3, 15 },
                    { 5, 16 },
                    { 3, 17 },
                    { 7, 18 },
                    { 1, 19 },
                    { 5, 20 },
                    { 3, 22 },
                    { 7, 23 },
                    { 7, 24 },
                    { 3, 26 },
                    { 1, 27 },
                    { 2, 29 },
                    { 1, 30 },
                    { 7, 33 },
                    { 3, 34 },
                    { 3, 35 },
                    { 5, 36 },
                    { 1, 37 },
                    { 4, 38 },
                    { 6, 39 },
                    { 4, 40 },
                    { 1, 41 },
                    { 5, 42 },
                    { 5, 44 },
                    { 2, 45 },
                    { 1, 46 },
                    { 7, 47 },
                    { 1, 48 },
                    { 4, 49 },
                    { 6, 51 },
                    { 3, 52 },
                    { 5, 53 },
                    { 5, 54 },
                    { 2, 55 },
                    { 6, 58 },
                    { 6, 59 },
                    { 3, 61 },
                    { 5, 62 },
                    { 3, 63 },
                    { 5, 64 },
                    { 3, 65 },
                    { 3, 66 },
                    { 1, 67 },
                    { 5, 68 },
                    { 2, 70 },
                    { 6, 71 },
                    { 4, 72 },
                    { 6, 73 },
                    { 6, 74 },
                    { 1, 75 },
                    { 5, 76 },
                    { 7, 77 },
                    { 1, 78 },
                    { 3, 79 },
                    { 7, 80 },
                    { 2, 81 },
                    { 1, 82 },
                    { 7, 83 },
                    { 7, 84 },
                    { 4, 85 },
                    { 5, 86 },
                    { 2, 87 },
                    { 6, 88 },
                    { 1, 90 },
                    { 6, 91 },
                    { 1, 93 },
                    { 7, 94 },
                    { 3, 95 },
                    { 3, 96 },
                    { 7, 98 },
                    { 5, 100 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 8, 37 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 5, 38 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 8, 39 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 6, 40 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 8, 41 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 2, 44 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 4, 45 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 7, 46 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 5, 47 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 5, 48 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 1, 49 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 5, 50 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 6, 51 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 6, 52 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 7, 53 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 6, 54 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 8, 55 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 6, 56 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 4, 57 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 5, 58 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 6, 59 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 8, 60 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 3, 61 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 5, 62 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 7, 63 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 8, 64 });

            migrationBuilder.DeleteData(
                table: "FreelancerCategories",
                keyColumns: new[] { "CategoryId", "FreelancerProfileId" },
                keyValues: new object[] { 8, 65 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 4, 14 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 16 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 7, 18 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 20 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 22 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 7, 23 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 7, 24 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 26 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 1, 27 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 29 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 1, 30 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 7, 33 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 34 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 35 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 36 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 1, 37 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 4, 38 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 6, 39 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 4, 40 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 1, 41 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 42 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 44 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 45 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 1, 46 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 7, 47 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 1, 48 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 4, 49 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 6, 51 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 52 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 53 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 54 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 55 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 6, 58 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 6, 59 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 61 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 62 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 63 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 64 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 65 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 66 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 1, 67 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 68 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 70 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 6, 71 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 4, 72 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 6, 73 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 6, 74 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 1, 75 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 76 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 7, 77 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 1, 78 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 79 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 7, 80 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 81 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 1, 82 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 7, 83 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 7, 84 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 4, 85 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 86 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 87 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 6, 88 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 1, 90 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 6, 91 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 1, 93 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 7, 94 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 95 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 96 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 7, 98 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 100 });

            migrationBuilder.AddColumn<DateTime>(
                name: "JobExpiredDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "007a3ecf-e7de-4903-8d6f-6f2e8390b597", "AQAAAAIAAYagAAAAEJcRdt1govuakbcO4WXJ3eNWK17qWdlxO3WcYDuO/lYMgOqsDol5P71brqBof3FGtg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "694fd7db-a9d5-479e-a188-3549384f9436", "AQAAAAIAAYagAAAAENJUiAQUtn5p2ENYKpbXLy4t3zcxGGvYu6P0Vg2OeW8Lu+w6uSvOgo9+HB/51X70ow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ddb0b98a-a187-4181-ab1b-07a2a8e261e9", "AQAAAAIAAYagAAAAEKSW7AULj+i3xOmrAtOvY/HYpvhpfPqcKKY5u7fz/qKsA75btxJYe5MPWrQMlXoxag==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7d23f3f5-4616-4e08-a7a5-6d3e3fc878ff", "AQAAAAIAAYagAAAAEG3ZQ0XjExHVgIk+LZVlGs2Nv68TY/apT+MhIobW8qwLdQJdaLxwL2F2khh1Sw7iOg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f3211b78-af2c-4a00-aa8c-a5198671fec3", "AQAAAAIAAYagAAAAEM60seeXoDKABfOIQ4vg0ggIwJu4eCrqA+dySSR8lVfuLxfC9PlJB73cqVvkFN4+9w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "588d05e5-0bf0-412d-8022-742be04aa30c", "AQAAAAIAAYagAAAAENrZRX83TdbyrWYLlPcwzYt9uHjCpTOBaSnP5y/F9LN8whAZhUv3IF3VdtHObpLd/A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2be99ed8-dd5e-434f-a0ba-698a163feae4", "AQAAAAIAAYagAAAAEDe1MVVlr69ouxS1M57AMbKMLFbrza1PVvDHCPa7Ywgctt2mP4+FnRv2BKwzCujyiQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f793ea3a-e292-4e23-bc38-50e44d62f30c", "AQAAAAIAAYagAAAAENfoYKQ3Lj3Cvyyi6V589Tro7Y5n3heHeXMZAsPXyIldagHZzu4eZz3tYeF4vhufLA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5c5a23b7-c1c0-4754-b690-161eddfc16ea", "AQAAAAIAAYagAAAAENe1npRxZKqOPtNshEMzXwJtQWYYQA3ipFAVDtCbUzgwMbJX1qzXEVGEFwHZ4XQ/Rg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "affd7bb8-3773-4e48-8eef-d0655404f122", "AQAAAAIAAYagAAAAEPiKYr0NtYWGCfup8KPHyqTz4TK3XqOU7rDfElIdtR7fKMBH9GE/zJ6ftzXf69Ccqg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a1fb4aa5-de98-4f4a-8cac-9d02296e0cc0", "AQAAAAIAAYagAAAAEPWrqGdWFz7rX4wk1vKbA8jY2QRw9ldvm3sWbrQclYErXOi/Z1JZb1wwEjXHWJObug==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f3edb06b-2ecb-4505-87cf-5cb4b6f5d024", "AQAAAAIAAYagAAAAEKIBRDAhYmtPssTPFpPhcvnihMlO/JixxAPVQxd1/DnWKjoUpq/oI/6N0SB0VYZPiQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3de2f605-aec1-46cf-82ea-2bf307ce406d", "AQAAAAIAAYagAAAAEAKflepJiosws0B3pFvh0eI/bwPE2Gfkq6nHrb45QhgeqBwK0JPPGO7yojG5KWWEUQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a58b7f5a-7884-4a4b-a9c9-19174bada9b3", "AQAAAAIAAYagAAAAEO9hkDXYgXusmYMy1r2HXkhGHbp80LMCdORElqoRm2l1elft6I7lpFeV8LiTSA/Jjg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "846d346c-0921-493a-8474-feb9ac667b50", "AQAAAAIAAYagAAAAECDwTHxJcPf9qdCydQwE6SoQvDo3lfTJs0rImr2NjSVc151RNvWvGHrUDV2dB9nCAg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a68643d8-5ca0-458a-951d-8ea79c1b6d71", "AQAAAAIAAYagAAAAEAAymPkEPf8VXosjBFC5Em3E21WLVP9OeV05GLziL9NcdifMSd9DuaYa4MgPIXQXzQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ab62d8b1-e684-4cee-a7d3-c47297c274cd", "AQAAAAIAAYagAAAAEASSPdYzxxg7PNoGxd+wDGGOMx138qXoltG0yTrcZ9Ox8fyIYKxqfACcoyeTkKWlkQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4ce22b6d-596d-428b-941b-4a0278717397", "AQAAAAIAAYagAAAAEFTDrhgyfEsRc8fLCeSCUSp0S6NLS4yAvSkk2zZER2ygaSZ2McdXXdoLCFOrOKu1dg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "29c94cfa-bb28-4f4e-966b-b9627da4a7cc", "AQAAAAIAAYagAAAAEHtagFTc6CmtP5WIbJVKdVCX3XZq5NutS1mci+2zVz/hKFbv7nPm+ohdXUA8WshO8g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c9681f8f-3d2e-4776-8181-d3e425aa15ea", "AQAAAAIAAYagAAAAEG7WkgvTtWIHstK2HVrouA4PCf0RUKO0uOZMRydStziEd/nxB2jULdnK4DOWbBQO1A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ca1420f1-0af0-4eff-b431-c9c52856d70b", "AQAAAAIAAYagAAAAENtfy6QXdEjiEZe6AI4wr1FWUv8Mebl4SZrNMZupJ1lGd/ohxOC8DFUq5i0S9hwiag==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "30c922a6-5929-4f18-895d-d1af40122519", "AQAAAAIAAYagAAAAEEdDN4/DEb9WeNKifeDwKTpM3Drike9BZyCVQYmNma/Nb4XkUf2PdeWIgPtZlX2NFw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7e9350f5-426b-4805-b327-816db1176ad3", "AQAAAAIAAYagAAAAEI9WQxN6LdXfciEDBJqv2Xk8PSq/mwYXAjrLINunPa9yOQhHeLgpKouWHxIbRX820g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4e02b496-e25b-4947-9447-33b0396bdc69", "AQAAAAIAAYagAAAAEC7tCFCR2BO45dxZxF4otmy7tstjEV/0DY5w/hHpjEaY1pQwiLt+gi1uhxfrylc+QA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "81ba1d74-70b1-4071-86d5-d13e74d9c161", "AQAAAAIAAYagAAAAEEs+msn6PshUu53EzSfY2Cit1aKqkaQuCS1QKUW4p2G4qJ+iYtyH3i1w/1RgHFFHXg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "685f3dfa-561b-4c8d-bb02-474cc3e16858", "AQAAAAIAAYagAAAAEDUY4luwzQvk0pC+maD388x4CHbvVHsyGvr+U7zEFcQSh/7aZ57moDOdGwdHA8Oj/Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8cc544cd-ed25-4848-9d2f-e459d8b75aeb", "AQAAAAIAAYagAAAAEJuYrLTmycBruMBf4hW1vkpSQbXPZMjdwwPEUTeIrKCREyJj9kS9QW5on31BybYmUQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "454567c8-72b3-4b24-84c3-9d9b49fe389b", "AQAAAAIAAYagAAAAEE8HCFduznRa2EZPSQ4bdQxkvsr1/n/VAk3xw94JemNOLooixXiHPua3ew8mBBoOFw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e2d23f8a-9d70-4b9e-a001-de3f4aacd7cc", "AQAAAAIAAYagAAAAEEouSkkPjwu5l7eFH6C53sdWbTs1lsQkRZ4vBj0TuvvvJ6sfM2V862FzP3xMvMCTIA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "feeda0f7-b376-432b-845b-3d038ce26eef", "AQAAAAIAAYagAAAAEPyvzU7UUHnIcxwppX2nBLlOrkPGR5zgnWKNAzSJRlV0EMXbsdibbxBSqI/B6Vdy3A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6f6285f4-79b1-48a5-87a7-610e97852d0e", "AQAAAAIAAYagAAAAEEStEWzU3iSB3s/l6DSQEzY4alWijVgywwFFU7mBjCTkjJK1HhWGBcHmZbcXJYuhQw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d8ff13ad-0aba-426b-9265-eb91452d028e", "AQAAAAIAAYagAAAAECfQT7bQfEqsc/DL7OiOMb2gz1Ijzs49ySq077ChKtztks3ztrE3DCLFxcHdaWWDbg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e6d52145-14d4-46c5-93c8-d00cfbc54d01", "AQAAAAIAAYagAAAAELtvZ8KxMJfU/BgqQr11Sb3lfWjRknQVgYVT4I8CzYrYgTaj5TFkravVfNywB2kZ5A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f5df3e16-7d24-46de-8595-36362cd8bacb", "AQAAAAIAAYagAAAAECCd4AyhFRhGgwpzTeT67gJSumsk0xBJGGKrlncyUNCgwTfMIdtmhkNGpnt/RJ5EIg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cbc98693-cb35-4fc6-a1c9-5b014ade86d0", "AQAAAAIAAYagAAAAEEtVgSc79PIXYWXNVuFEX63FtvKM3jHFqU8GCu7s6LunLI3RxrWVjf/acMVjJduJzA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9b945258-8e33-4a99-8567-5bd94aa76ad8", "AQAAAAIAAYagAAAAEKXNFJ0k7kL1hNiz2U40/lq3Kv6lTd4P/iIpi2L89xWy6C8xK6fNR2NvLhTAIWYNsA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d14f4a6e-9f85-4bcf-a830-cdccede9a68a", "AQAAAAIAAYagAAAAEHNpdFL4SSLXZB/mQ4SiGH5LWBJzNWe1r3S4rCLiSioH3Y/92viYMKjfI9OPhKHHQA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aa63bfa0-154d-4e1a-bd74-98a97a34849c", "AQAAAAIAAYagAAAAEDZSwL8ThZ2KQ3UiLn48L4wf4yvBW6lkKsf/CrbRzUZqL5NVqpw9u6hO7URBj1wrDA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0151d45c-2c8d-45b0-9498-70c43faf4702", "AQAAAAIAAYagAAAAEMgGhZil6iS6/Mw3wdx/0BRcQoDoAdLuRbl/UDHVkPCV5xp7OWkhQWsSbdYDLljhDw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4775cc49-9888-4edc-8240-9638816b135b", "AQAAAAIAAYagAAAAED6XuY5I5oq8oHjcg0iCMs3rldjOuZRoXCs81WFetj4gZugvnATpVkd1BHRDHwHeqw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "863091ae-2c44-48fc-af77-7fa27d5dfd6d", "AQAAAAIAAYagAAAAECExRfceZiN/U6PW1lLkn+nwez3nyWPMRk9oHEQ30TXzxN6u6gmZqQq1+vffJU7rLw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fb875f9b-fd12-4cc3-aa5f-afcf9a0fd591", "AQAAAAIAAYagAAAAEKcCO/m+bzVfTB9zIoAWM74rj6IuvcLJc7ZJjW+ws1IE9aOPIcZHIIE3Pc1YN//xSw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8e85cd0d-f599-4cce-96dd-57dc341cbfcd", "AQAAAAIAAYagAAAAEMmqI/tANDZgUqxe45cGOagyNm4EUDkqhuWDHRqN+i9EcUDVoSVDBnb3+Uc8q2QRHQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bfb2593a-85ae-45d5-89a4-a5dd1aaf5146", "AQAAAAIAAYagAAAAEF+ZSQigwzJLy6bA38qIHgFv1wOUNX7MVyHzJdiypFqryPEUTk6ONLEe1qJUd2Ksjg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4bb74423-fbc5-4892-80c1-5a8420abe571", "AQAAAAIAAYagAAAAEK9/TZmyPfcX4nGOkcc33DQ85J+RKVK+W8lQpULFSP4upNiOjaCjCpNzlyRk+EL5DQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "860a1891-d4bb-4d40-8d18-daa73476265e", "AQAAAAIAAYagAAAAEBCqPiRRTCVFwGxZMDNgHOpZzGnmwN28WwrCN1Dcp4JmaTzVAxxvI0qAZWphugB6DQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "abcf4e29-be26-4f4f-91e4-2f5ee71ac993", "AQAAAAIAAYagAAAAEAxWce1tkU3F9li5ZoeSSAjLnmy/wy0zZk2WqtKsEZC6YrcqqIfETt61wGqJmWSrfA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3f8d681a-2576-42f9-a037-23bf22f478f6", "AQAAAAIAAYagAAAAEOUq0VCagWSlQz3nw+AvR/FwViH9A3QmO1NGo82cLSsXLKwyg5FPBwxiBmGh/LHgPQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b792aab0-f829-4206-85dc-9e2018bd501b", "AQAAAAIAAYagAAAAEIj4LqurSg98VBVS6St9oH4aQK3Ij9/1mjxPp02WZGiB2qUv1JnCZSx1KsL5ZAHRpg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9690a29a-804e-4ad8-bed3-51e4476d200d", "AQAAAAIAAYagAAAAEGuX3iXZQBAsniihneduhq8Mm9xU7+LO4KMuM4VlP+gFVGkJoIlkndtfG5uSisHFHw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0137ef68-f090-4f7a-a34c-def3b6cdbda4", "AQAAAAIAAYagAAAAEGeUjMrt5Q+P8ElC00bKwX0zMXnHsd33Da9iqNEmd29HbrUd1Uf0wrDnlyMtavTUTw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d195ed0d-5f3e-4fd6-ad85-05f93797fdb2", "AQAAAAIAAYagAAAAECldSH9XrulEGbin1thXxsj96R0k+PRHnn5RccCKJJeUT9Nujxyd/i1G+pViCTJsoA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5a207898-6f39-4c46-9397-d4b3d239176c", "AQAAAAIAAYagAAAAEEktApTBOgs8p+SLo/WMcgCeUtZTs0sEJ2f8cjGo3pfTysaSdlTTkf9ik0y9rOruuw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2d7f113f-7aca-4e61-91f3-6f8e2afbb455", "AQAAAAIAAYagAAAAEHNJ83oBZ3LHyaHV4hPFl035j++K29xUxIUWUKN0gVy/oqTix4oKaxyqTGeSW4sFSw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f7e8e983-2525-43ec-b03d-df60f609173e", "AQAAAAIAAYagAAAAEEqq2Nr7hlxqwpdMAJ/XYyHZfvENPqXcczRS5chlTUzwkfzP8acQMA/TLZ882AmiOQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f4b61743-e3f2-40af-81a7-c8e768333f7a", "AQAAAAIAAYagAAAAEEPt7N5ARDRYrEYXgLvxWrMXQ6+9Ak3EQTpB1ETBUhwFbFq3YYKgGqCGwlSM6IzYkA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f1bda631-7e16-4686-b597-2308632764c6", "AQAAAAIAAYagAAAAEADbbYVxlJhTKVzCjhU3t8SjliQaQNvJtC9bZOD5ahXt0QjKve059L9dg+O5ZYPYBQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bf7fe650-5250-482c-99dd-67972732f468", "AQAAAAIAAYagAAAAEBO82V9dDFaAQyT4586U6mEtiANYeVX87s6bJBMFBe+bfe51ub4qEd4D0gZPquslLg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac14090d-d90a-4473-ab08-271988fe0ad7", "AQAAAAIAAYagAAAAEKlfu8cI4Y1iUUHsxuzRCg/yf9Z5aojq6i3kIc3FTTDiAZhhuvVt0chrMox7+Y8aWQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "97ea6792-05e3-42b0-90fd-4a569f2c7d9f", "AQAAAAIAAYagAAAAECSVhfpr1FMVAssaOjQZGzCd4UptJFo6OO1Z3UvPPVA7F5f1mcyqiqwuxCdXHq1Mfg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5b1b0b74-34c8-465b-9a45-c8ccccdf7383", "AQAAAAIAAYagAAAAEKFb6IztHnWhIp/t0n+73ImZvY6tXhBFMngXrus3FlIk3aL8BUMe6svI3HIpVfXmCA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a26f884b-c58b-4a2f-80a3-cba79e39d5e0", "AQAAAAIAAYagAAAAELPDezsFMdhrD4RssjRVdo/mIObrn+XkjPsaAEXiuKYlEDI9cn+nanPr/0oe8cG9xA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b9dccef6-df47-44d4-a4b3-91d37748aa05", "AQAAAAIAAYagAAAAEJqnep9XgFgLZkgzMHGj4bfSbxmiU4HHtOaMEN3ahCE6xqI9iQdS0VDstv7vaxI/1Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0cd340d0-a360-4f67-b541-6aae28f4329a", "AQAAAAIAAYagAAAAEBSlnyDPNTqIHlV8GnksBzwwYJ2R91J+bzWlFBbKMEbPLljPCX4FLu7nNQu9R3lHiw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7c66930c-3ab1-4ad1-b03d-e10fdaf407a7", "AQAAAAIAAYagAAAAEOOgsfpe8TWJ++l9FIkoM1ALuaRECkusDWIrB328m0SvtcJvmcxbrL90p0ML7ve/mg==" });

            migrationBuilder.InsertData(
                table: "FreelancerCategories",
                columns: new[] { "CategoryId", "FreelancerProfileId" },
                values: new object[,]
                {
                    { 2, 37 },
                    { 8, 38 },
                    { 4, 39 },
                    { 5, 40 },
                    { 6, 41 },
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

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 12, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9637), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 16, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9676), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "JobExpiredDate" },
                values: new object[] { new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9683), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 12, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9689), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 18, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9730), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 29, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9739), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 23, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9745), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 34, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9752), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 14, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9758), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "JobExpiredDate" },
                values: new object[] { new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9766), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 34, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9772), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 6, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9779), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 14, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9785), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 27, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9792), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "JobExpiredDate" },
                values: new object[] { new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9828), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 8, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9836), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 21, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9842), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 12, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9850), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 23, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9857), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 20, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9863), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 21, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9870), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 7, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9876), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 10, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9883), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 6, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9920), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 18, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9927), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 21, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9934), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 14, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9940), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 12, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9947), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 26, new DateTime(2023, 6, 11, 14, 57, 45, 811, DateTimeKind.Local).AddTicks(9953), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 18, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(532), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 22, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(569), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 14, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(576), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 18, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(582), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 16, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(631), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 32, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(638), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 10, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(644), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 12, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(651), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 20, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(657), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 11, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(663), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 9, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(670), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 15, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(676), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 21, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(683), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 15, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(721), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 10, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(728), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 34, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(734), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 29, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(741), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 23, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(747), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 8, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(754), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 13, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(760), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 22, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(766), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 22, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(774), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 23, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(780), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 13, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(816), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 12, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(824), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 8, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(830), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 23, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(837), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 22, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(843), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 12, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(849), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 32, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(856), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 31, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(862), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 34, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(869), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 21, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(875), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 19, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(912), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 25, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(920), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 15, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(926), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 31, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(934), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 19, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(940), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 17, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(946), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 8, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(953), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 20, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(959), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 20, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1024), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 6, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1030), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 27, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1037), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 24, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1043), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 22, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1049), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 18, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1056), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 18, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1062), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 32, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1068), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 6, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1075), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 28, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1081), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 29, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1123), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 34, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1129), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 22, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1136), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 25, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1142), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 6, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1149), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 25, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1155), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 11, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1161), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 13, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1168), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 13, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1174), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 13, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1181), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 30, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1219), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 31, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1226), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 34, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1232), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 13, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1238), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 9, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1244), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 31, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1251), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 17, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1257), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 17, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1264), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 11, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1270), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BusinessProfileId", "CreatedDate", "JobExpiredDate" },
                values: new object[] { 10, new DateTime(2023, 6, 11, 14, 57, 45, 812, DateTimeKind.Local).AddTicks(1277), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.InsertData(
                table: "JobCategories",
                columns: new[] { "CategoryId", "JobId" },
                values: new object[,]
                {
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
                    { 6, 22 },
                    { 6, 23 },
                    { 4, 24 },
                    { 2, 26 },
                    { 4, 27 },
                    { 3, 29 },
                    { 2, 30 },
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
                    { 2, 44 },
                    { 5, 45 },
                    { 4, 46 },
                    { 1, 47 },
                    { 2, 48 },
                    { 2, 49 },
                    { 5, 51 },
                    { 6, 52 },
                    { 2, 53 },
                    { 1, 54 },
                    { 7, 55 },
                    { 7, 58 },
                    { 5, 59 },
                    { 2, 61 },
                    { 1, 62 },
                    { 5, 63 },
                    { 3, 64 },
                    { 2, 65 },
                    { 6, 66 },
                    { 3, 67 },
                    { 4, 68 },
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
                    { 4, 90 },
                    { 5, 91 },
                    { 3, 93 },
                    { 6, 94 },
                    { 5, 95 },
                    { 7, 96 },
                    { 5, 98 },
                    { 2, 100 }
                });
        }
    }
}
