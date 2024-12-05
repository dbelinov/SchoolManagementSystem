using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExportSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("65f2ad5b-c05d-47bd-b1f0-1b71fa3d31fb"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("914036eb-a628-480e-9832-05ad69072882"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("8ad5696e-0465-4b26-82e6-39c1ad4565c6"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("65f2ad5b-c05d-47bd-b1f0-1b71fa3d31fb"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("ef9212b3-4d9d-4ffc-be32-bf1085878090") },
                    { new Guid("914036eb-a628-480e-9832-05ad69072882"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("026ea863-df25-4d76-a10f-86bd59ab4d8b") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[] { new Guid("8ad5696e-0465-4b26-82e6-39c1ad4565c6"), "Mariya", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("0c2f2158-c4c7-4c9c-bbae-2857ffb94700") });
        }
    }
}
