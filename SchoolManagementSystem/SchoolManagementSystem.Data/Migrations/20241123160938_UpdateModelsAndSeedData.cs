using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModelsAndSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Timetables_TimetableId",
                table: "Classes");

            migrationBuilder.AlterColumn<int>(
                name: "TimetableId",
                table: "Classes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Name", "SchoolId", "Speciality", "TimetableId" },
                values: new object[] { 1, "9b", null, 1, null });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[] { new Guid("54ba9ab6-6678-467b-aeea-c7a707eccb26"), "Mariya", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("e0e6f113-f1d7-4b47-b4db-4780c87e2a92") });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[] { new Guid("7914fdd8-8130-4813-8ba2-f2b1537cf3da"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("0caa1b3a-bf35-4baf-b7db-e9870a3e9ca1") });

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Timetables_TimetableId",
                table: "Classes",
                column: "TimetableId",
                principalTable: "Timetables",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Timetables_TimetableId",
                table: "Classes");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("7914fdd8-8130-4813-8ba2-f2b1537cf3da"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("54ba9ab6-6678-467b-aeea-c7a707eccb26"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "TimetableId",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Timetables_TimetableId",
                table: "Classes",
                column: "TimetableId",
                principalTable: "Timetables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
