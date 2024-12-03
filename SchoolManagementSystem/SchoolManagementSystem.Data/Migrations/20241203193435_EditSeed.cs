using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class EditSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("086dd6c8-c2e9-4244-99ae-d6df7df958cc"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2df3e869-856b-4945-9964-e33546101209"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("d95f2a13-b0fa-48db-b651-3a29a44c5ef5"));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "LogoUrl",
                value: "https://scontent.fsof1-2.fna.fbcdn.net/v/t39.30808-6/327026697_887516432673344_8690934784557383737_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=6ee11a&_nc_ohc=Rr0iH229ZRwQ7kNvgFeKEcF&_nc_zt=23&_nc_ht=scontent.fsof1-2.fna&_nc_gid=AizPmB3yiG6QTT84Mh5cpaJ&oh=00_AYDekshXGVy2Xa02RxZHINhma0rvygf0uH2D2_cO5om7Dg&oe=675539CD");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "LogoUrl",
                value: "https://img.freepik.com/premium-vector/school-logo-design_706452-12.jpg?w=360");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("086dd6c8-c2e9-4244-99ae-d6df7df958cc"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("b1b39fd1-20e3-426c-a6c2-5ea388c7af83") },
                    { new Guid("2df3e869-856b-4945-9964-e33546101209"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("f59fac71-5b7b-4d7b-aeda-6fe5e083ae26") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[] { new Guid("d95f2a13-b0fa-48db-b651-3a29a44c5ef5"), "Mariya", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("b51092bc-c677-4f2b-a821-e44ce500a2dd") });
        }
    }
}
