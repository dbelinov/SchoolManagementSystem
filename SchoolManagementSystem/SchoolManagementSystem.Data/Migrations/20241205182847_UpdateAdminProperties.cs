using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAdminProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3a03dafa-6303-4171-8fad-633a1afc1c73"), new Guid("716b6413-ad40-4341-863d-fc9cef165f9b") });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("8b85681d-b298-4c0f-bcbf-dee98317535f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("9fb86826-a1ec-4434-8f72-84d49d605213"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("bc525f8a-5bef-4173-b14a-3224dee74385"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3a03dafa-6303-4171-8fad-633a1afc1c73"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("716b6413-ad40-4341-863d-fc9cef165f9b"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("3a03dafa-6303-4171-8fad-633a1afc1c73"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AppId", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IdNumber", "IsAuthenticated", "IsGuest", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VerificationKey" },
                values: new object[] { new Guid("716b6413-ad40-4341-863d-fc9cef165f9b"), 0, new Guid("716b6413-ad40-4341-863d-fc9cef165f9b"), new DateTime(2024, 12, 5, 20, 27, 21, 300, DateTimeKind.Local).AddTicks(7230), "8cafc4c7-09c0-4144-9817-5ba9c0f93398", "admin@scholario.com", true, "Admin", "2452064114", false, true, "Adminov", false, null, "Adminov", "ADMIN@SCHOLARIO.COM", "ADMIN@SCHOLARIO.COM", "AQAAAAIAAYagAAAAEHWqKwlN7RnFbpEI0fR97mvGaVAUJ3pHKb8f6aTBrT4WY/NT2L97XQr/UMK4gbjhQw==", null, false, "6636c8ec-5546-4e48-9ca3-6362a6bb1b9c", false, "admin@scholario.com", new Guid("716b6413-ad40-4341-863d-fc9cef165f9b") });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("8b85681d-b298-4c0f-bcbf-dee98317535f"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("54107200-1ac3-4fd4-b16f-e9d5994785bb") },
                    { new Guid("9fb86826-a1ec-4434-8f72-84d49d605213"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("3f586fbe-7425-46da-b844-43d245dedb63") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[] { new Guid("bc525f8a-5bef-4173-b14a-3224dee74385"), "Mariya", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("cb661852-8704-4993-b359-a05dd4ba4775") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("3a03dafa-6303-4171-8fad-633a1afc1c73"), new Guid("716b6413-ad40-4341-863d-fc9cef165f9b") });
        }
    }
}
