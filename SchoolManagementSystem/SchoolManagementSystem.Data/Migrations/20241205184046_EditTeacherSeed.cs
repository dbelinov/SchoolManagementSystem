using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class EditTeacherSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b0cfa1e0-878e-437d-a9f7-0b738fa52cdf"), new Guid("89a4d9c6-ab11-46d9-9ac5-cdfd10fada31") });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("276ebe13-abce-40fc-a8e3-c598ebd1d18a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e7e91f21-3e6b-43cf-8eb4-3f45fa1ceed5"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("19f3d58e-15ee-487b-ba45-ccca8c75dec3"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b0cfa1e0-878e-437d-a9f7-0b738fa52cdf"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("89a4d9c6-ab11-46d9-9ac5-cdfd10fada31"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("530a6548-2cbb-4fea-a129-d6963d870f1b"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AppId", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IdNumber", "IsAuthenticated", "IsGuest", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VerificationKey" },
                values: new object[] { new Guid("2c3bf96d-8520-488a-acc5-49247d999d35"), 0, new Guid("2c3bf96d-8520-488a-acc5-49247d999d35"), new DateTime(2024, 12, 5, 20, 40, 46, 405, DateTimeKind.Local).AddTicks(1820), "81be4c09-b377-4acd-ba1f-a7a7e254932c", "admin@scholario.com", true, "Admin", "2452064114", true, false, "Adminov", false, null, "Adminov", "ADMIN@SCHOLARIO.COM", "ADMIN@SCHOLARIO.COM", "AQAAAAIAAYagAAAAEKoFkogIonnrj49f6v+CzqrNoUbicm1ECtM7adQ+f+lLqe65rK6w67Qo56gNl5IidQ==", null, false, "d542c6c1-c8a5-4793-9c30-64e8782ff256", false, "admin@scholario.com", new Guid("2c3bf96d-8520-488a-acc5-49247d999d35") });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("77c36d3b-0272-461a-b922-48921204c167"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("cc67a73a-3665-4606-8270-841affe14ca7") },
                    { new Guid("c066bca0-bb05-4277-bcad-0424b57fb4cd"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("50cb4c81-981e-44f0-b502-1d0fc266a7a1") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[] { new Guid("6c81cf63-38a6-4dda-9673-386378ca462d"), "Maria", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("1a1b44bb-2dd2-4071-9f7a-82bfd6e13962") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("530a6548-2cbb-4fea-a129-d6963d870f1b"), new Guid("2c3bf96d-8520-488a-acc5-49247d999d35") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("530a6548-2cbb-4fea-a129-d6963d870f1b"), new Guid("2c3bf96d-8520-488a-acc5-49247d999d35") });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("77c36d3b-0272-461a-b922-48921204c167"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c066bca0-bb05-4277-bcad-0424b57fb4cd"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("6c81cf63-38a6-4dda-9673-386378ca462d"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("530a6548-2cbb-4fea-a129-d6963d870f1b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2c3bf96d-8520-488a-acc5-49247d999d35"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("b0cfa1e0-878e-437d-a9f7-0b738fa52cdf"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AppId", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IdNumber", "IsAuthenticated", "IsGuest", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VerificationKey" },
                values: new object[] { new Guid("89a4d9c6-ab11-46d9-9ac5-cdfd10fada31"), 0, new Guid("89a4d9c6-ab11-46d9-9ac5-cdfd10fada31"), new DateTime(2024, 12, 5, 20, 28, 46, 869, DateTimeKind.Local).AddTicks(2230), "9a5e30d8-d427-4a14-b210-57f2a79b8577", "admin@scholario.com", true, "Admin", "2452064114", true, false, "Adminov", false, null, "Adminov", "ADMIN@SCHOLARIO.COM", "ADMIN@SCHOLARIO.COM", "AQAAAAIAAYagAAAAENJpXGth1Xxths6Jtcw6gX6abiTNoVvc5li9wYteyo2BrHthQc61vh9X0Q3jk+qjnw==", null, false, "561148fc-5cc5-40f2-8162-eb1b8e57d535", false, "admin@scholario.com", new Guid("89a4d9c6-ab11-46d9-9ac5-cdfd10fada31") });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("276ebe13-abce-40fc-a8e3-c598ebd1d18a"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("b170e642-fbf6-4f8c-8e3e-e6289a76e73d") },
                    { new Guid("e7e91f21-3e6b-43cf-8eb4-3f45fa1ceed5"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("aea4e328-3c3c-45bb-9723-944e2e6f10c6") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[] { new Guid("19f3d58e-15ee-487b-ba45-ccca8c75dec3"), "Mariya", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("2a0e18e2-866f-475e-8002-74f95287c7cc") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("b0cfa1e0-878e-437d-a9f7-0b738fa52cdf"), new Guid("89a4d9c6-ab11-46d9-9ac5-cdfd10fada31") });
        }
    }
}
