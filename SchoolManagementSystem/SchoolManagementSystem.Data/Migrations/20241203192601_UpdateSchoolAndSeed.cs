using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSchoolAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("4c5a4c87-8db8-4a07-aa02-59a8e143c5c5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("661ce878-0af0-459a-a012-b473bd1b6a0f"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("f5823d7b-127d-46f9-91a5-26d5cce15f88"));

            migrationBuilder.AddColumn<string>(
                name: "LogoUrl",
                table: "Schools",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "LogoUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQzhPBHtxHbOEFLNF4mRQzvcC79G6Y_FhNQJg&s");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("39373ceb-e82e-45c5-b603-096d194f015d"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("97f71aa7-2174-4f70-b525-d93801451ac0") },
                    { new Guid("92e0798e-1dc4-44f6-b6a1-1811e3249041"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("b0d5eeb7-2468-404f-a28b-6d602164f836") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[] { new Guid("ee5ca183-ea9d-4c4e-90ac-76ef97ea8035"), "Mariya", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("a3fe7a4c-b059-4fe7-b69a-6e2d008b7cda") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("39373ceb-e82e-45c5-b603-096d194f015d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("92e0798e-1dc4-44f6-b6a1-1811e3249041"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("ee5ca183-ea9d-4c4e-90ac-76ef97ea8035"));

            migrationBuilder.DropColumn(
                name: "LogoUrl",
                table: "Schools");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("4c5a4c87-8db8-4a07-aa02-59a8e143c5c5"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("ec34be2e-7436-4144-94ed-473aa8eea32e") },
                    { new Guid("661ce878-0af0-459a-a012-b473bd1b6a0f"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("e4394ca7-5120-4c98-ba53-c0d52d151cac") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[] { new Guid("f5823d7b-127d-46f9-91a5-26d5cce15f88"), "Mariya", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("f6e901df-0e6b-495f-bb29-6136a04d2a45") });
        }
    }
}
