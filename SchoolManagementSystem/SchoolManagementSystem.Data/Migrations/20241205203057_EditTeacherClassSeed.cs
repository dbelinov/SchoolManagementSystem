using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class EditTeacherClassSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("459e725e-7ed2-4360-8f26-6d5f69ef5e96"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AppId", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IdNumber", "IsAuthenticated", "IsGuest", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VerificationKey" },
                values: new object[] { new Guid("26db12ae-b423-410e-8f39-8a3aee4a31f7"), 0, new Guid("26db12ae-b423-410e-8f39-8a3aee4a31f7"), new DateTime(2024, 12, 5, 22, 30, 56, 990, DateTimeKind.Local).AddTicks(9400), "a357da63-c086-4e92-a318-aa7352f6b75c", "admin@scholario.com", true, "Admin", "2452064114", true, false, "Adminov", false, null, "Adminov", "ADMIN@SCHOLARIO.COM", "ADMIN@SCHOLARIO.COM", "AQAAAAIAAYagAAAAEDulC4tj5aO3phHkROw09+cZtI6XXkkvluW1T7lypPgcVsd6gQ89jhKQyST63HQuxA==", null, false, "a34c5be4-bfc8-464f-839d-9ed5680d620e", false, "admin@scholario.com", new Guid("26db12ae-b423-410e-8f39-8a3aee4a31f7") });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("02aa85db-e0d9-4b43-ab9c-8e3340c3a4f5"), 2, "Martin", "0741124324", "Georgiev", "Ivanov", new Guid("8bbfeb65-31cd-4a3a-a553-9b4c8be4748b") },
                    { new Guid("2e97bd0e-e3b3-439c-b603-6548aaa4a02b"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("0795633d-2215-4a1c-9418-059535adf74e") },
                    { new Guid("7f694e18-3881-403b-93b1-80189f0c5ea1"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("e06b3766-e589-4191-9bfa-9776948f816c") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("73011ad8-0c95-4078-ab13-600206234716"), "Stefka", "9003021331", "Gineva", "Petkova", null, 4, new Guid("0d58c16a-bc32-4c27-bb0e-a2f0f5373ce7") },
                    { new Guid("ea3ad780-d97f-407a-8e71-75f7eb7cdca0"), "Maria", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("8757e486-d02e-4e8a-8c9f-397540fa5efd") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("459e725e-7ed2-4360-8f26-6d5f69ef5e96"), new Guid("26db12ae-b423-410e-8f39-8a3aee4a31f7") });

            migrationBuilder.InsertData(
                table: "TeachersClasses",
                columns: new[] { "ClassId", "TeacherId" },
                values: new object[,]
                {
                    { 1, new Guid("73011ad8-0c95-4078-ab13-600206234716") },
                    { 2, new Guid("73011ad8-0c95-4078-ab13-600206234716") },
                    { 1, new Guid("ea3ad780-d97f-407a-8e71-75f7eb7cdca0") },
                    { 2, new Guid("ea3ad780-d97f-407a-8e71-75f7eb7cdca0") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("459e725e-7ed2-4360-8f26-6d5f69ef5e96"), new Guid("26db12ae-b423-410e-8f39-8a3aee4a31f7") });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("02aa85db-e0d9-4b43-ab9c-8e3340c3a4f5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2e97bd0e-e3b3-439c-b603-6548aaa4a02b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("7f694e18-3881-403b-93b1-80189f0c5ea1"));

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("73011ad8-0c95-4078-ab13-600206234716") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("73011ad8-0c95-4078-ab13-600206234716") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("ea3ad780-d97f-407a-8e71-75f7eb7cdca0") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("ea3ad780-d97f-407a-8e71-75f7eb7cdca0") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("459e725e-7ed2-4360-8f26-6d5f69ef5e96"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("26db12ae-b423-410e-8f39-8a3aee4a31f7"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("73011ad8-0c95-4078-ab13-600206234716"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("ea3ad780-d97f-407a-8e71-75f7eb7cdca0"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("a3708a62-b708-4172-bc0e-461e15a91609"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AppId", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IdNumber", "IsAuthenticated", "IsGuest", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VerificationKey" },
                values: new object[] { new Guid("cd535470-db25-4e99-a92f-de3a1b571304"), 0, new Guid("cd535470-db25-4e99-a92f-de3a1b571304"), new DateTime(2024, 12, 5, 22, 26, 29, 407, DateTimeKind.Local).AddTicks(1870), "b98f6ecd-31aa-4068-9a02-1b29da8d7ca8", "admin@scholario.com", true, "Admin", "2452064114", true, false, "Adminov", false, null, "Adminov", "ADMIN@SCHOLARIO.COM", "ADMIN@SCHOLARIO.COM", "AQAAAAIAAYagAAAAEA5xhQ89MFFRiG+Lxlxu3Z0pZeqkE+v5xI9f5CWEqwuh37+V3iwXbhypu9D3Xol7MQ==", null, false, "d43827cf-911d-45a2-946b-9a75091e29be", false, "admin@scholario.com", new Guid("cd535470-db25-4e99-a92f-de3a1b571304") });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("078b507c-e903-47e1-b22a-2e3d32b5ada2"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("5f58e6b7-73ee-4e71-959a-7f5a953f59a5") },
                    { new Guid("0cedf809-6444-4b18-b993-e1dd12d070a0"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("9d5a8b5a-5b40-46b6-b784-f2b9f05cc66f") },
                    { new Guid("bc4b2fd7-941f-4f9c-9753-13310d4af3fc"), 2, "Martin", "0741124324", "Georgiev", "Ivanov", new Guid("1b3c6210-a34f-43f0-b052-1f6ca4a81384") }
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
                table: "TeachersClasses",
                columns: new[] { "ClassId", "TeacherId" },
                values: new object[,]
                {
                    { 1, new Guid("0ef98b31-a666-4975-b815-ff82c69c91e9") },
                    { 2, new Guid("acd49e64-f8e4-4f22-9cf6-f5056695bab9") }
                });
        }
    }
}
