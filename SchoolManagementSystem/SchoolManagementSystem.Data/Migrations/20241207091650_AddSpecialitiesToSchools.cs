using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSpecialitiesToSchools : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Specialities",
                table: "Schools",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("2239599d-510a-4431-916a-59eca9c6ba3d"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AppId", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IdNumber", "IsAuthenticated", "IsGuest", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VerificationKey" },
                values: new object[] { new Guid("681bbdd1-e0c8-4617-8888-bee21f3c629f"), 0, new Guid("681bbdd1-e0c8-4617-8888-bee21f3c629f"), new DateTime(2024, 12, 7, 11, 16, 50, 513, DateTimeKind.Local).AddTicks(290), "8394d764-be65-41d7-bfe2-177a5255890b", "admin@scholario.com", true, "Admin", "2452064114", true, false, "Adminov", false, null, "Adminov", "ADMIN@SCHOLARIO.COM", "ADMIN@SCHOLARIO.COM", "AQAAAAIAAYagAAAAECdGJDMlcQm62cQthq4ECifB9OC9XB8p4Q2zt4KXLZk0vdTFb9tGgXzqalFERgwlmA==", null, false, "1fe00171-99e6-4c94-a807-8abefd2fdc4d", false, "admin@scholario.com", new Guid("681bbdd1-e0c8-4617-8888-bee21f3c629f") });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "Specialities",
                value: "[1,2,4]");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("1272875c-7ab2-40cf-88d8-6a2a7c018e46"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("c1401b18-a9ef-47c0-ae88-cc24594032ad") },
                    { new Guid("804fd719-b585-40e1-9974-07c781c06c7b"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("747884f5-e8f5-47cd-88b1-7dcbe3240a95") },
                    { new Guid("ae1ed6a9-2326-4c40-8a56-e62bd3ac0ec4"), 2, "Martin", "0741124324", "Georgiev", "Ivanov", new Guid("e1528851-aed8-4e8c-a7a8-0588f0b263a1") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("01ebebc4-ff31-49d3-b0b5-4c1404d8a018"), "Stefka", "9003021331", "Gineva", "Petkova", null, 4, new Guid("1e7dbfc5-f7b7-40dd-acf2-0cf6c275e0a1") },
                    { new Guid("a2384309-062b-466b-b267-6b7488197d7e"), "Maria", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("47c8b8b7-9bfb-4875-b562-5a88c9b11736") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("2239599d-510a-4431-916a-59eca9c6ba3d"), new Guid("681bbdd1-e0c8-4617-8888-bee21f3c629f") });

            migrationBuilder.InsertData(
                table: "TeachersClasses",
                columns: new[] { "ClassId", "TeacherId" },
                values: new object[,]
                {
                    { 1, new Guid("01ebebc4-ff31-49d3-b0b5-4c1404d8a018") },
                    { 2, new Guid("01ebebc4-ff31-49d3-b0b5-4c1404d8a018") },
                    { 1, new Guid("a2384309-062b-466b-b267-6b7488197d7e") },
                    { 2, new Guid("a2384309-062b-466b-b267-6b7488197d7e") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2239599d-510a-4431-916a-59eca9c6ba3d"), new Guid("681bbdd1-e0c8-4617-8888-bee21f3c629f") });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("1272875c-7ab2-40cf-88d8-6a2a7c018e46"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("804fd719-b585-40e1-9974-07c781c06c7b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ae1ed6a9-2326-4c40-8a56-e62bd3ac0ec4"));

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("01ebebc4-ff31-49d3-b0b5-4c1404d8a018") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("01ebebc4-ff31-49d3-b0b5-4c1404d8a018") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("a2384309-062b-466b-b267-6b7488197d7e") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("a2384309-062b-466b-b267-6b7488197d7e") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2239599d-510a-4431-916a-59eca9c6ba3d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("681bbdd1-e0c8-4617-8888-bee21f3c629f"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("01ebebc4-ff31-49d3-b0b5-4c1404d8a018"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("a2384309-062b-466b-b267-6b7488197d7e"));

            migrationBuilder.DropColumn(
                name: "Specialities",
                table: "Schools");

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
    }
}
