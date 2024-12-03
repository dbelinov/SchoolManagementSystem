using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateClassLogic : Migration
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
                value: 0);

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("a4c45f78-50d0-4d84-952c-cc34f79d5651"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("052f7bb0-b3cf-4152-995a-621d39f2c31a") },
                    { new Guid("df90b053-771b-4667-9de2-56860348626c"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("a5f3d2a5-c906-44a3-9736-862622590431") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[] { new Guid("84a07a96-37da-4551-81c7-36d2fc022024"), "Mariya", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("5a065926-3247-4ca9-bdf5-9d9736ceabfe") });

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
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a4c45f78-50d0-4d84-952c-cc34f79d5651"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("df90b053-771b-4667-9de2-56860348626c"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("84a07a96-37da-4551-81c7-36d2fc022024"));

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
