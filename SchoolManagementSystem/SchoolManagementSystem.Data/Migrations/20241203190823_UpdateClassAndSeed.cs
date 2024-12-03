using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateClassAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Schools_SchoolId",
                table: "Classes");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("02c4c685-e28b-4423-a713-9b4dffc21563"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c3abc9b4-8813-497a-a0c4-3552df45f783"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("e8389876-04bc-42fc-9447-4f76eea1855c"));

            migrationBuilder.AlterColumn<int>(
                name: "SchoolId",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1,
                column: "SchoolId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "Description", "Name" },
                values: new object[] { 1, "44 Avgusta Trayana, Stara Zagora, Bulgaria", "The School of Informatics and Mathematics in Stara Zagora", "PPMG \"Geo Milev\"" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Schools_SchoolId",
                table: "Classes",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Schools_SchoolId",
                table: "Classes");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1);

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

            migrationBuilder.AlterColumn<int>(
                name: "SchoolId",
                table: "Classes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1,
                column: "SchoolId",
                value: null);

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("02c4c685-e28b-4423-a713-9b4dffc21563"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("f39d1aa5-88fd-45eb-a22d-72a8fba75b96") },
                    { new Guid("c3abc9b4-8813-497a-a0c4-3552df45f783"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("42cec904-9b85-4540-97db-aa1d00fb1c46") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[] { new Guid("e8389876-04bc-42fc-9447-4f76eea1855c"), "Mariya", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("ecc63368-e0ff-486b-b263-45a9c53e642a") });

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Schools_SchoolId",
                table: "Classes",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id");
        }
    }
}
