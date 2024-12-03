using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "LogoUrl" },
                values: new object[] { "44 Avgusta Trayana\nStara Zagora, Bulgaria", "https://scontent.fsof1-2.fna.fbcdn.net/v/t39.30808-6/327026697_887516432673344_8690934784557383737_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=6ee11a&_nc_ohc=Rr0iH229ZRwQ7kNvgFeKEcF&_nc_zt=23&_nc_ht=scontent.fsof1-2.fna&_nc_gid=AizPmB3yiG6QTT84Mh5cpaJ&oh=00_AYDekshXGVy2Xa02RxZHINhma0rvygf0uH2D2_cO5om7Dg&oe=675539CD" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Address", "LogoUrl" },
                values: new object[] { "44 Avgusta Trayana, Stara Zagora, Bulgaria", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQzhPBHtxHbOEFLNF4mRQzvcC79G6Y_FhNQJg&s" });

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
    }
}
