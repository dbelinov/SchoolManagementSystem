using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ba3245d7-4104-48d9-a4a0-baab39f74965"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d47efe83-c6ad-4ddd-843e-9eccbaa5a48e"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("a00a8abb-6d12-42e0-88a2-e2ebe969a427"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("ba3245d7-4104-48d9-a4a0-baab39f74965"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("a74b0fe2-b9c1-4fa8-ba6c-3d1eced12518") },
                    { new Guid("d47efe83-c6ad-4ddd-843e-9eccbaa5a48e"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("e17de654-a5fe-4ff0-ad61-92d0c609af02") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[] { new Guid("a00a8abb-6d12-42e0-88a2-e2ebe969a427"), "Mariya", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("7c1ea373-e64c-465f-a2ab-0cc44b57c4a2") });
        }
    }
}
