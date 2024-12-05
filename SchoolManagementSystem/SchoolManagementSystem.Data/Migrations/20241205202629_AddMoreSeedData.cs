using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f40c2724-a6a7-4ef4-a503-687c4d0c784a"), new Guid("1931fbcb-f316-40f2-87ea-7e7ed3f57796") });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("7baf4c90-1331-4787-8a8b-a8087dc73a63"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("bccdafa3-ac2a-453a-b436-da329de6d074"));

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("dbc51148-c101-418e-8187-dc8c1e130b88") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f40c2724-a6a7-4ef4-a503-687c4d0c784a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1931fbcb-f316-40f2-87ea-7e7ed3f57796"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("dbc51148-c101-418e-8187-dc8c1e130b88"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("a3708a62-b708-4172-bc0e-461e15a91609"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AppId", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IdNumber", "IsAuthenticated", "IsGuest", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VerificationKey" },
                values: new object[] { new Guid("cd535470-db25-4e99-a92f-de3a1b571304"), 0, new Guid("cd535470-db25-4e99-a92f-de3a1b571304"), new DateTime(2024, 12, 5, 22, 26, 29, 407, DateTimeKind.Local).AddTicks(1870), "b98f6ecd-31aa-4068-9a02-1b29da8d7ca8", "admin@scholario.com", true, "Admin", "2452064114", true, false, "Adminov", false, null, "Adminov", "ADMIN@SCHOLARIO.COM", "ADMIN@SCHOLARIO.COM", "AQAAAAIAAYagAAAAEA5xhQ89MFFRiG+Lxlxu3Z0pZeqkE+v5xI9f5CWEqwuh37+V3iwXbhypu9D3Xol7MQ==", null, false, "d43827cf-911d-45a2-946b-9a75091e29be", false, "admin@scholario.com", new Guid("cd535470-db25-4e99-a92f-de3a1b571304") });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Name", "SchoolId", "Speciality", "TimetableId" },
                values: new object[] { 2, "10b", 1, 1, null });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("078b507c-e903-47e1-b22a-2e3d32b5ada2"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("5f58e6b7-73ee-4e71-959a-7f5a953f59a5") },
                    { new Guid("0cedf809-6444-4b18-b993-e1dd12d070a0"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("9d5a8b5a-5b40-46b6-b784-f2b9f05cc66f") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("0ef98b31-a666-4975-b815-ff82c69c91e9"), "Maria", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("135d5451-7349-4634-82cd-d35545529872") },
                    { new Guid("acd49e64-f8e4-4f22-9cf6-f5056695bab9"), "Stefka", "9003021331", "Gineva", "Petkova", null, 4, new Guid("31f9ffd7-9c57-480d-a7d7-0eb700446b38") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("a3708a62-b708-4172-bc0e-461e15a91609"), new Guid("cd535470-db25-4e99-a92f-de3a1b571304") });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[] { new Guid("bc4b2fd7-941f-4f9c-9753-13310d4af3fc"), 2, "Martin", "0741124324", "Georgiev", "Ivanov", new Guid("1b3c6210-a34f-43f0-b052-1f6ca4a81384") });

            migrationBuilder.InsertData(
                table: "TeachersClasses",
                columns: new[] { "ClassId", "TeacherId" },
                values: new object[,]
                {
                    { 1, new Guid("0ef98b31-a666-4975-b815-ff82c69c91e9") },
                    { 2, new Guid("acd49e64-f8e4-4f22-9cf6-f5056695bab9") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a3708a62-b708-4172-bc0e-461e15a91609"), new Guid("cd535470-db25-4e99-a92f-de3a1b571304") });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("078b507c-e903-47e1-b22a-2e3d32b5ada2"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("0cedf809-6444-4b18-b993-e1dd12d070a0"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("bc4b2fd7-941f-4f9c-9753-13310d4af3fc"));

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("0ef98b31-a666-4975-b815-ff82c69c91e9") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("acd49e64-f8e4-4f22-9cf6-f5056695bab9") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a3708a62-b708-4172-bc0e-461e15a91609"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cd535470-db25-4e99-a92f-de3a1b571304"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("0ef98b31-a666-4975-b815-ff82c69c91e9"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("acd49e64-f8e4-4f22-9cf6-f5056695bab9"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("f40c2724-a6a7-4ef4-a503-687c4d0c784a"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AppId", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IdNumber", "IsAuthenticated", "IsGuest", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VerificationKey" },
                values: new object[] { new Guid("1931fbcb-f316-40f2-87ea-7e7ed3f57796"), 0, new Guid("1931fbcb-f316-40f2-87ea-7e7ed3f57796"), new DateTime(2024, 12, 5, 22, 15, 43, 76, DateTimeKind.Local).AddTicks(3730), "b8990c20-d393-4966-9985-2ceacfe3d260", "admin@scholario.com", true, "Admin", "2452064114", true, false, "Adminov", false, null, "Adminov", "ADMIN@SCHOLARIO.COM", "ADMIN@SCHOLARIO.COM", "AQAAAAIAAYagAAAAEHqQoMcwRaVpLsbbn5Rpf1rbV17F09nTW6HkGIw/jBpeSCl4hpYU2SgbulZ8IHHKiw==", null, false, "e1f47953-3f2c-4dfa-8be0-d2b9ea4f364c", false, "admin@scholario.com", new Guid("1931fbcb-f316-40f2-87ea-7e7ed3f57796") });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("7baf4c90-1331-4787-8a8b-a8087dc73a63"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("f364e179-f108-48ff-8503-942f4ba57d3e") },
                    { new Guid("bccdafa3-ac2a-453a-b436-da329de6d074"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("5d368742-7809-4965-bb76-ece2aa69dd01") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[] { new Guid("dbc51148-c101-418e-8187-dc8c1e130b88"), "Maria", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("27a71213-474f-47cb-ad21-fc64b22df675") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("f40c2724-a6a7-4ef4-a503-687c4d0c784a"), new Guid("1931fbcb-f316-40f2-87ea-7e7ed3f57796") });

            migrationBuilder.InsertData(
                table: "TeachersClasses",
                columns: new[] { "ClassId", "TeacherId" },
                values: new object[] { 1, new Guid("dbc51148-c101-418e-8187-dc8c1e130b88") });
        }
    }
}
