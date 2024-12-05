using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTeacherClassToSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d35316ee-60a4-4ddc-a8c8-33147d60c60e"), new Guid("05d60328-71f5-484b-b328-b96c02067d9f") });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("9942fe04-746d-42c7-aa01-ae93171dc24d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ed139db0-65f6-4e1a-8029-b07f672111b9"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("72d33ad0-eee3-4ade-8e03-64a102e12e5b"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d35316ee-60a4-4ddc-a8c8-33147d60c60e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("05d60328-71f5-484b-b328-b96c02067d9f"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("d35316ee-60a4-4ddc-a8c8-33147d60c60e"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AppId", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IdNumber", "IsAuthenticated", "IsGuest", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VerificationKey" },
                values: new object[] { new Guid("05d60328-71f5-484b-b328-b96c02067d9f"), 0, new Guid("05d60328-71f5-484b-b328-b96c02067d9f"), new DateTime(2024, 12, 5, 21, 27, 0, 596, DateTimeKind.Local).AddTicks(3940), "cda38b13-f1a9-4a8b-842f-4976b3e8d05c", "admin@scholario.com", true, "Admin", "2452064114", true, false, "Adminov", false, null, "Adminov", "ADMIN@SCHOLARIO.COM", "ADMIN@SCHOLARIO.COM", "AQAAAAIAAYagAAAAEIeqx7vVBn1TdB+iMgNZ9aZIi5UPxFGtDKOcEG209DMgOH9yU4jJ16F3gyUMArqAcg==", null, false, "c7a69bf1-2ce2-4e09-923f-9b09c646e484", false, "admin@scholario.com", new Guid("05d60328-71f5-484b-b328-b96c02067d9f") });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("9942fe04-746d-42c7-aa01-ae93171dc24d"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("edbe059f-fb21-4ced-81eb-6afcf527166f") },
                    { new Guid("ed139db0-65f6-4e1a-8029-b07f672111b9"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("94208c41-56eb-4370-9fc2-71edf5cfb826") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[] { new Guid("72d33ad0-eee3-4ade-8e03-64a102e12e5b"), "Maria", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("fbb6a0ad-5377-4165-a10c-8414c9c62a26") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("d35316ee-60a4-4ddc-a8c8-33147d60c60e"), new Guid("05d60328-71f5-484b-b328-b96c02067d9f") });
        }
    }
}
