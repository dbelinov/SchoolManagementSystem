using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("571cb247-15c6-493f-b262-073dc53dd35e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("7cc127b6-ebb8-44fb-9298-366538c4b67c"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("a16b0aa3-aedf-4288-9b9c-84fc19e65a06"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("571cb247-15c6-493f-b262-073dc53dd35e"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("405ba503-5302-482c-b52e-f0fa3993f64f") },
                    { new Guid("7cc127b6-ebb8-44fb-9298-366538c4b67c"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("0d0e2820-80ec-4a5b-9efd-3e83996f19a3") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[] { new Guid("a16b0aa3-aedf-4288-9b9c-84fc19e65a06"), "Mariya", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("7f3651c6-074b-4b43-b29a-eb7411e4dc04") });
        }
    }
}
