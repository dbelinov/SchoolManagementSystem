using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGrade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentsGrades");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3cdc62e2-fe1f-45c1-9df3-c6d0c17de0aa"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a246285e-a371-4994-b494-8a5918684f95"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("6d81c05c-f8ae-487e-ab0a-92ddc1cfb424"));

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Subject = table.Column<int>(type: "int", nullable: false),
                    GradeValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grades_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Grades_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentId",
                table: "Grades",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_TeacherId",
                table: "Grades",
                column: "TeacherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grades");

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

            migrationBuilder.CreateTable(
                name: "StudentsGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Subject = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsGrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentsGrades_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("3cdc62e2-fe1f-45c1-9df3-c6d0c17de0aa"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("802b1b56-942d-44ce-84de-0c499e1539b7") },
                    { new Guid("a246285e-a371-4994-b494-8a5918684f95"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("e950c7f2-b2ca-4992-b6eb-28eaeaa86a35") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[] { new Guid("6d81c05c-f8ae-487e-ab0a-92ddc1cfb424"), "Mariya", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("9f5026e5-cd80-4e6d-b647-e478c2cd17ca") });

            migrationBuilder.CreateIndex(
                name: "IX_StudentsGrades_StudentId",
                table: "StudentsGrades",
                column: "StudentId");
        }
    }
}
