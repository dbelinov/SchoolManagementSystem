using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTechnicalUniversitySeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("503f4f0c-1732-4a07-bf1e-cc2037af5b4e"), new Guid("21c65c7a-e9c6-45b3-97c8-bb51fcbda27f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("503f4f0c-1732-4a07-bf1e-cc2037af5b4e"), new Guid("28ee76ba-3314-4928-81e7-3d3b2345b8e7") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("503f4f0c-1732-4a07-bf1e-cc2037af5b4e"), new Guid("3b3144f8-6feb-419f-87c7-2c85c704017e") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("25e96fcf-1f21-4b22-b66a-56361895341f"), new Guid("4f76cd66-0a3c-4c78-ba0f-c59e4c75d119") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("503f4f0c-1732-4a07-bf1e-cc2037af5b4e"), new Guid("50d6ed37-9db1-4f57-9b41-a5014cb9ba74") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("25e96fcf-1f21-4b22-b66a-56361895341f"), new Guid("55b6f89c-acea-4f7c-a40d-fc6b37a78fd0") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("25e96fcf-1f21-4b22-b66a-56361895341f"), new Guid("56335e1a-7d1e-4b4d-8372-880cc45e2f72") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("503f4f0c-1732-4a07-bf1e-cc2037af5b4e"), new Guid("792c7ad3-cb5b-4a8f-b7d9-fab455046c69") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("25e96fcf-1f21-4b22-b66a-56361895341f"), new Guid("941bbd30-d016-4051-a604-6b3172dcc16d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("25e96fcf-1f21-4b22-b66a-56361895341f"), new Guid("a194e2be-8179-4881-b26b-7e885c570d01") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a598250c-5da3-4a3a-90b6-c1ac01b5aa54"), new Guid("d2afa49d-797c-46b5-a824-68e9f4910f81") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("25e96fcf-1f21-4b22-b66a-56361895341f"), new Guid("e6c8f860-8421-4858-ae5e-540f2dca8e9d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("503f4f0c-1732-4a07-bf1e-cc2037af5b4e"), new Guid("ed2d28b7-83dd-46d9-a1e9-7e20df5312f7") });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2d4fcb19-5a83-4547-a671-4b9983059a74"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("4c78381b-2408-493f-a64d-5a6213a8b482"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("67c81e73-eb31-49b3-9df4-3c0ba5923c21"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("7730ac6b-21dc-45d3-a25e-d3e45ad4e5e9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("99a915aa-d458-41f5-8a48-7a8b875c3f3b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d9660b3c-27f8-42b4-aff9-bd0b044d6556"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d9db5438-b7c4-49d0-be4e-7cb2b11d64d1"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fffaee3e-fdaa-4b66-99f1-dfe3a4d3739e"));

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("6140f4c8-1d4a-4d4f-a844-bdc3bdede992") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("6140f4c8-1d4a-4d4f-a844-bdc3bdede992") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 5, new Guid("8e1767cd-0408-4202-a599-36caa55696e7") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 4, new Guid("c254d038-d15b-48aa-a313-36a00b59f961") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 4, new Guid("e04e2d7c-8d12-4b0a-9e05-26c9b6237ab3") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("e6d98fff-a613-48a5-bddb-25047c1a99fd") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("e6d98fff-a613-48a5-bddb-25047c1a99fd") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("e9ca673a-dd6c-4454-a6cd-19f0d2b670d4") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("e9ca673a-dd6c-4454-a6cd-19f0d2b670d4") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 3, new Guid("e9ca673a-dd6c-4454-a6cd-19f0d2b670d4") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("25e96fcf-1f21-4b22-b66a-56361895341f"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("503f4f0c-1732-4a07-bf1e-cc2037af5b4e"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a598250c-5da3-4a3a-90b6-c1ac01b5aa54"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("21c65c7a-e9c6-45b3-97c8-bb51fcbda27f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("28ee76ba-3314-4928-81e7-3d3b2345b8e7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b3144f8-6feb-419f-87c7-2c85c704017e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4f76cd66-0a3c-4c78-ba0f-c59e4c75d119"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("50d6ed37-9db1-4f57-9b41-a5014cb9ba74"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55b6f89c-acea-4f7c-a40d-fc6b37a78fd0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56335e1a-7d1e-4b4d-8372-880cc45e2f72"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("792c7ad3-cb5b-4a8f-b7d9-fab455046c69"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("941bbd30-d016-4051-a604-6b3172dcc16d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a194e2be-8179-4881-b26b-7e885c570d01"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d2afa49d-797c-46b5-a824-68e9f4910f81"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e6c8f860-8421-4858-ae5e-540f2dca8e9d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ed2d28b7-83dd-46d9-a1e9-7e20df5312f7"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("6140f4c8-1d4a-4d4f-a844-bdc3bdede992"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("8e1767cd-0408-4202-a599-36caa55696e7"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("c254d038-d15b-48aa-a313-36a00b59f961"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("e04e2d7c-8d12-4b0a-9e05-26c9b6237ab3"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("e6d98fff-a613-48a5-bddb-25047c1a99fd"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("e9ca673a-dd6c-4454-a6cd-19f0d2b670d4"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1a1c795a-7a0b-4404-894e-7579ca6d2fa9"), null, "Teacher", "TEACHER" },
                    { new Guid("1a434ecf-c98a-4106-b878-b581d67c0072"), null, "Student", "STUDENT" },
                    { new Guid("213218b9-821e-46c4-a797-c965607bf07f"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AppId", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IdNumber", "IsAuthenticated", "IsGuest", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("05b4fec4-3398-4821-a3cd-aa5e94aaca5b"), 0, new Guid("39b02cb1-3070-465d-a2f8-141c4f8b706a"), new DateTime(2024, 12, 7, 19, 36, 47, 440, DateTimeKind.Local).AddTicks(4600), "d5b391df-f7bc-4ef0-9bac-449a46bc01af", "martin@gmail.com", false, "Martin", "0741124324", true, false, "Georgiev", false, null, "Ivanov", "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAIAAYagAAAAEMkVyvXvoptnUBjhiWxMKyscHVAwy6i3XJ/ytMcYt9KtnU1Bn8B2H3XjjTOyMlv9mA==", null, false, "aca537b9-378e-43fd-8efc-ecbcb8839c24", false, "martin@gmail.com", new Guid("e2ded3df-d8bb-4254-90c6-e34087ad8667") },
                    { new Guid("077a6834-dbae-4cd1-af8e-ae6bb871d2b5"), 0, new Guid("6d9d1776-1eff-4e90-863c-5e84fc5bb731"), new DateTime(2024, 12, 7, 19, 36, 47, 627, DateTimeKind.Local).AddTicks(3560), "428b1ba1-65f9-4462-a5ce-ae741123d453", "stefka@gmail.com", false, "Stefka", "9003021331", true, false, "Gineva", false, null, "Petkova", "STEFKA@GMAIL.COM", "STEFKA@GMAIL.COM", "AQAAAAIAAYagAAAAEBqBVbRSfGTPb9rx5wFAJptz40x6D2LECh1yQVuNbp8lFh3oYLOWDkzzX32W6EaXsQ==", null, false, "1bb254c6-8895-472f-95fe-d57ab34bf82e", false, "stefka@gmail.com", new Guid("2adfaa2f-edd3-4353-b047-b3715ba87dbc") },
                    { new Guid("0ef31af0-0864-4574-8a23-6328b6332fd4"), 0, new Guid("19d20ebe-74de-4888-9a3b-07217cd79912"), new DateTime(2024, 12, 7, 19, 36, 47, 774, DateTimeKind.Local).AddTicks(8740), "8a1a34d1-2d6e-4b4d-a4ee-055302cb9c60", "boncho@gmail.com", false, "Boncho", "8006210887", true, false, "Dimitrov", false, null, "Dimitrov", "BONCHO@GMAIL.COM", "BONCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEJP67dRlDiQnbDC5aswM80axpRu1e8X/YMAdwoLEh6VHuMWCeXvOwM0yZbPTsI67Cg==", null, false, "05358068-1008-4672-9670-0d9337cd292d", false, "boncho@gmail.com", new Guid("b142ecc2-0e4d-4d7b-b239-0f507b1c081e") },
                    { new Guid("4dc3f13b-69bd-4707-b2af-2c0239c91bc3"), 0, new Guid("a100d404-587f-4f59-9fea-d6eb3a2f9e58"), new DateTime(2024, 12, 7, 19, 36, 47, 701, DateTimeKind.Local).AddTicks(3730), "d6fdbd5e-c961-4182-9744-f5c992fda152", "stoyanka@gmail.com", false, "Stoyanka", "7105053113", true, false, "Peneva", false, null, "Doneva", "STOYANKA@GMAIL.COM", "STOYANKA@GMAIL.COM", "AQAAAAIAAYagAAAAEGQvsMarEJFaY80FP0TzB6otv9eMNyRgrqm9cT1/7rIIqU0hEktcHABaYt2FPE8jew==", null, false, "19ea778c-6fab-4b68-812b-dd2d69eaae64", false, "stoyanka@gmail.com", new Guid("c92bdade-5922-469d-b9ea-eb4b58b7d206") },
                    { new Guid("543fc513-de34-490a-a945-8e73ebe00972"), 0, new Guid("e241f069-b391-4781-a616-fd0abb624e0c"), new DateTime(2024, 12, 7, 19, 36, 47, 738, DateTimeKind.Local).AddTicks(1390), "f49b3e56-1add-44e7-9eef-66804e408a21", "petar@gmail.com", false, "Petar", "8210045421", true, false, "Chonev", false, null, "Mladenov", "PETAR@GMAIL.COM", "PETAR@GMAIL.COM", "AQAAAAIAAYagAAAAEPhXU9aa7SLcTbtu/g9HsABazuqoIBjaIrG9FZ4qvOLhYJ5taQ12hA9X6RRXV56Cmg==", null, false, "83e0f2dd-3fb3-4b45-8f0e-75d9537dd4e4", false, "petar@gmail.com", new Guid("2b646c19-0f42-452b-a109-4234fdde3580") },
                    { new Guid("755a44eb-fb4b-4664-8dba-912779245ce0"), 0, new Guid("32f27c54-142f-42c4-8026-b1b5b0e0d90b"), new DateTime(2024, 12, 7, 19, 36, 47, 589, DateTimeKind.Local).AddTicks(6270), "95364ead-1688-4ddc-a07d-ac80e14acd9b", "maria@gmail.com", false, "Maria", "8008089119", true, false, "Petrova", false, null, "Ivanova", "MARIA@GMAIL.COM", "MARIA@GMAIL.COM", "AQAAAAIAAYagAAAAECLd3DJT7D0+jTXunsZrRFZrwBtVLb35PM0PBMLJdXLlYcFr7C22N2YyQqTZWzEsbQ==", null, false, "ac3fc06b-bb97-4660-a302-d9b5f67ce686", false, "maria@gmail.com", new Guid("b658f89c-13c1-46fe-8dc9-29c309188a8f") },
                    { new Guid("7dc36dfd-8b4a-47a0-973d-292a4fc9aac8"), 0, new Guid("3068517e-7cfb-4317-84a7-59028bb9f151"), new DateTime(2024, 12, 7, 19, 36, 47, 552, DateTimeKind.Local).AddTicks(620), "85031b2b-56a5-49ee-820d-e22c8a14b4ec", "pencho@gmail.com", false, "Pencho", "0945161226", true, false, "Mihov", false, null, "Angelov", "PENCHO@GMAIL.COM", "PENCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEByDkK9MSq9YQqjF7deo9z+U4cLqG0Z2Mq0jDJHMI0QVTUIVjlE4AEwUOV/tkvBm1w==", null, false, "06c8c508-6487-4713-9a24-e6ad30b6301d", false, "pencho@gmail.com", new Guid("0e63e4c5-4669-4f59-bde9-62eeed38338b") },
                    { new Guid("81b66efa-4764-4632-94f1-15cfb12a8b56"), 0, new Guid("54a54f58-c7b6-4047-b818-f71e83c27430"), new DateTime(2024, 12, 7, 19, 36, 47, 514, DateTimeKind.Local).AddTicks(8160), "5cca4c4e-ce76-467e-a45a-6cf8248cc27a", "jivko@gmail.com", false, "Jivko", "1041124324", true, false, "Donev", false, null, "Vasilev", "JIVKO@GMAIL.COM", "JIVKO@GMAIL.COM", "AQAAAAIAAYagAAAAEMxNpW0RsTJ8Bdv+Vfku3XlUDr6lQSwIzOa5kHmZNodexh+cRJsaLpqltaYGnLpqOA==", null, false, "a07afbaa-e001-4829-bca5-5f55cd8aa95a", false, "jivko@gmail.com", new Guid("3355c4e6-40a4-4a96-99e1-9e359fabb7f5") },
                    { new Guid("878550c2-6dd0-4c95-8ca2-dbb29192bc30"), 0, new Guid("cf0306ed-559a-405d-b49a-dbc26a8f545d"), new DateTime(2024, 12, 7, 19, 36, 47, 367, DateTimeKind.Local).AddTicks(3100), "c6a9e84e-d201-4402-a6da-261f6640342c", "ivan@gmail.com", false, "Ivan", "0141012442", true, false, "Ivanov", false, null, "Ivanov", "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAIAAYagAAAAEMV2UalTGPKh9Jn68GmfXARmt5CzRHHDj71yEX4kQUmE4DveYWozHhTvhZuM2Ax+aQ==", null, false, "bb886d0e-8cb6-415b-a46a-18b62fad99ca", false, "ivan@gmail.com", new Guid("1955984a-2c1d-40ca-a0ab-0362ff4aeba3") },
                    { new Guid("b8ba0176-f17e-4663-9993-19926df07f9a"), 0, new Guid("e6a65c3f-7b3f-4371-9e04-f0002bb6d6ee"), new DateTime(2024, 12, 7, 19, 36, 47, 664, DateTimeKind.Local).AddTicks(4490), "00b7da65-5796-4a6c-b40e-42f69fde5df6", "stamen@gmail.com", false, "Stamen", "7211053143", true, false, "Peev", false, null, "Georgiev", "STAMEN@GMAIL.COM", "STAMEN@GMAIL.COM", "AQAAAAIAAYagAAAAEBAThzqHZ9anDSm+d2T9hD2WrdXYnFNTDU9/0pNAymaY/HIRH6dvCt2D7N+jIJaIzA==", null, false, "bd685cc4-6a6d-4733-a2bd-048e02696b6e", false, "stamen@gmail.com", new Guid("45785608-1b9b-4603-b248-d5a36a6e1476") },
                    { new Guid("d93b5d88-6955-4c93-aa17-6ce0f9f2ab6e"), 0, new Guid("308d1732-31bc-4a1d-9437-b9721a6747fe"), new DateTime(2024, 12, 7, 19, 36, 47, 403, DateTimeKind.Local).AddTicks(8870), "73a1f8c0-20c3-4a4c-8806-7e6285beb49b", "gencho@gmail.com", false, "Gencho", "0543121244", true, false, "Ginev", false, null, "Petkov", "GENCHO@GMAIL.COM", "GENCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEATYbwbhkrGOgJHHCxU1cky80q2jmO1gPDSCHzpiVomuuNzeNpcB9iQ0i0fFqfNe7w==", null, false, "7934c90f-bae3-44ab-98bf-ade1a7488e5a", false, "gencho@gmail.com", new Guid("733ec8a8-bbce-43d7-8e55-78e69aefa12d") },
                    { new Guid("dc5e39de-ca83-4e68-966d-d2bcf2e32396"), 0, new Guid("dc5e39de-ca83-4e68-966d-d2bcf2e32396"), new DateTime(2024, 12, 7, 19, 36, 47, 811, DateTimeKind.Local).AddTicks(7160), "19237b16-8962-46a3-84cf-3043b1019c69", "admin@scholario.com", true, "Admin", "2452064114", true, false, "Adminov", false, null, "Adminov", "ADMIN@SCHOLARIO.COM", "ADMIN@SCHOLARIO.COM", "AQAAAAIAAYagAAAAEOT8rSZIRUew970D+Tnh0w36LYhES7mizUM/1wPvXHM2kyuZfS1El7yR1MrobJ1pEA==", null, false, "39350d03-2713-49a3-bff5-7380e2c8728c", false, "admin@scholario.com", new Guid("dc5e39de-ca83-4e68-966d-d2bcf2e32396") },
                    { new Guid("f9e9a6df-2eed-4300-8c04-89c3b8250b37"), 0, new Guid("ed6b0138-ef8a-46d4-b9a9-397e54c4979b"), new DateTime(2024, 12, 7, 19, 36, 47, 477, DateTimeKind.Local).AddTicks(9310), "6b10b83f-5d6d-4e52-8736-a0ae96751afe", "ginka@gmail.com", false, "Ginka", "0944174331", true, false, "Stoyanova", false, null, "Petrova", "GINKA@GMAIL.COM", "GINKA@GMAIL.COM", "AQAAAAIAAYagAAAAEHE0F2kTV9pyRXMPvPjaXFfh3g0nPo2aBEvENEI5CWiE3uLJ6/T41SOb7RYBzTd4Rg==", null, false, "24de12d1-4679-4ef7-95ab-bae085e7b5b7", false, "ginka@gmail.com", new Guid("760a3509-c637-44eb-9e77-94a3e650e327") }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "Description", "LogoUrl", "Name", "Specialities" },
                values: new object[] { 3, "Profesor Georgi Bradistilov 11, Sofia, Bulgaria", "The Technical University of Sofia is Bulgaria's largest and foremost academic establishment for higher engineering education.", "https://scontent.fsof1-1.fna.fbcdn.net/v/t39.30808-6/453179855_1108969364009343_5412650960044976974_n.jpg?_nc_cat=101&ccb=1-7&_nc_sid=6ee11a&_nc_ohc=qPhfwrpLKZUQ7kNvgGHjtnI&_nc_zt=23&_nc_ht=scontent.fsof1-1.fna&_nc_gid=A1xPbdI_kb_P2-V2ZeYF9Ij&oh=00_AYCD4-wxXkM0nUjRh1A3Z58xa9vtxRdQAf4fh6OnOsLa_g&oe=675A5DED", "Technical University of Sofia", "[2,1]" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("1bf9d576-d586-4838-814a-d17b71603d19"), 4, "Diana", "1148061932", "Kostova", "Nedeva", new Guid("db0b0625-f94d-4a9e-9b6b-1480bded8ad0") },
                    { new Guid("3068517e-7cfb-4317-84a7-59028bb9f151"), 5, "Pencho", "0945161226", "Mihov", "Angelov", new Guid("3ae16754-0805-4754-b57d-41a55d4330eb") },
                    { new Guid("308d1732-31bc-4a1d-9437-b9721a6747fe"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("11462c1e-acd4-4cc5-9fd8-dc7fb68bdae5") },
                    { new Guid("39b02cb1-3070-465d-a2f8-141c4f8b706a"), 2, "Martin", "0741124324", "Georgiev", "Ivanov", new Guid("c9af8275-d9cc-4cdf-a5eb-64e90b927b05") },
                    { new Guid("54a54f58-c7b6-4047-b818-f71e83c27430"), 4, "Jivko", "1041124324", "Donev", "Vasilev", new Guid("4cbf3802-5c87-4e97-9665-b4ba4d7f2f59") },
                    { new Guid("982bcdad-216b-4e6d-86b9-a46ef52d8d41"), 5, "Ruzha", "0852131993", "Veleva", "Todorova", new Guid("6db9e0b3-5332-446e-bd11-0d542fd6a149") },
                    { new Guid("cf0306ed-559a-405d-b49a-dbc26a8f545d"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("76730023-c930-4f3e-aa62-e82f9c47893a") },
                    { new Guid("ed6b0138-ef8a-46d4-b9a9-397e54c4979b"), 3, "Ginka", "0944174331", "Stoyanova", "Petrova", new Guid("41e5205f-458f-4dd1-85f8-665a453949d2") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("19d20ebe-74de-4888-9a3b-07217cd79912"), "Boncho", "8006210887", "Dimitrov", "Dimitrov", null, 9, new Guid("84d76407-d98a-4540-8407-a250cda63be4") },
                    { new Guid("32f27c54-142f-42c4-8026-b1b5b0e0d90b"), "Maria", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("2856969c-386b-4ffc-8246-ce823cddb2d0") },
                    { new Guid("6d9d1776-1eff-4e90-863c-5e84fc5bb731"), "Stefka", "9003021331", "Gineva", "Petkova", null, 4, new Guid("2fb52b49-3247-4677-bb03-357bebdd70fb") },
                    { new Guid("a100d404-587f-4f59-9fea-d6eb3a2f9e58"), "Stoyanka", "7105053113", "Peneva", "Doneva", null, 15, new Guid("ceb3fcbd-c14a-4476-9bd5-653f36ef9927") },
                    { new Guid("e241f069-b391-4781-a616-fd0abb624e0c"), "Petar", "8210045421", "Chonev", "Mladenov", null, 5, new Guid("51edafa2-b82e-48eb-adac-f135722c3f08") },
                    { new Guid("e6a65c3f-7b3f-4371-9e04-f0002bb6d6ee"), "Stamen", "7211053143", "Peev", "Georgiev", null, 14, new Guid("a9684df7-061a-460a-a288-d1797d7a2a0b") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("1a434ecf-c98a-4106-b878-b581d67c0072"), new Guid("05b4fec4-3398-4821-a3cd-aa5e94aaca5b") },
                    { new Guid("1a1c795a-7a0b-4404-894e-7579ca6d2fa9"), new Guid("077a6834-dbae-4cd1-af8e-ae6bb871d2b5") },
                    { new Guid("1a1c795a-7a0b-4404-894e-7579ca6d2fa9"), new Guid("0ef31af0-0864-4574-8a23-6328b6332fd4") },
                    { new Guid("1a1c795a-7a0b-4404-894e-7579ca6d2fa9"), new Guid("4dc3f13b-69bd-4707-b2af-2c0239c91bc3") },
                    { new Guid("1a1c795a-7a0b-4404-894e-7579ca6d2fa9"), new Guid("543fc513-de34-490a-a945-8e73ebe00972") },
                    { new Guid("1a1c795a-7a0b-4404-894e-7579ca6d2fa9"), new Guid("755a44eb-fb4b-4664-8dba-912779245ce0") },
                    { new Guid("1a434ecf-c98a-4106-b878-b581d67c0072"), new Guid("7dc36dfd-8b4a-47a0-973d-292a4fc9aac8") },
                    { new Guid("1a434ecf-c98a-4106-b878-b581d67c0072"), new Guid("81b66efa-4764-4632-94f1-15cfb12a8b56") },
                    { new Guid("1a434ecf-c98a-4106-b878-b581d67c0072"), new Guid("878550c2-6dd0-4c95-8ca2-dbb29192bc30") },
                    { new Guid("1a1c795a-7a0b-4404-894e-7579ca6d2fa9"), new Guid("b8ba0176-f17e-4663-9993-19926df07f9a") },
                    { new Guid("1a434ecf-c98a-4106-b878-b581d67c0072"), new Guid("d93b5d88-6955-4c93-aa17-6ce0f9f2ab6e") },
                    { new Guid("213218b9-821e-46c4-a797-c965607bf07f"), new Guid("dc5e39de-ca83-4e68-966d-d2bcf2e32396") },
                    { new Guid("1a434ecf-c98a-4106-b878-b581d67c0072"), new Guid("f9e9a6df-2eed-4300-8c04-89c3b8250b37") }
                });

            migrationBuilder.InsertData(
                table: "TeachersClasses",
                columns: new[] { "ClassId", "TeacherId" },
                values: new object[,]
                {
                    { 4, new Guid("19d20ebe-74de-4888-9a3b-07217cd79912") },
                    { 1, new Guid("32f27c54-142f-42c4-8026-b1b5b0e0d90b") },
                    { 2, new Guid("32f27c54-142f-42c4-8026-b1b5b0e0d90b") },
                    { 1, new Guid("6d9d1776-1eff-4e90-863c-5e84fc5bb731") },
                    { 2, new Guid("6d9d1776-1eff-4e90-863c-5e84fc5bb731") },
                    { 5, new Guid("a100d404-587f-4f59-9fea-d6eb3a2f9e58") },
                    { 4, new Guid("e241f069-b391-4781-a616-fd0abb624e0c") },
                    { 1, new Guid("e6a65c3f-7b3f-4371-9e04-f0002bb6d6ee") },
                    { 2, new Guid("e6a65c3f-7b3f-4371-9e04-f0002bb6d6ee") },
                    { 3, new Guid("e6a65c3f-7b3f-4371-9e04-f0002bb6d6ee") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1a434ecf-c98a-4106-b878-b581d67c0072"), new Guid("05b4fec4-3398-4821-a3cd-aa5e94aaca5b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1a1c795a-7a0b-4404-894e-7579ca6d2fa9"), new Guid("077a6834-dbae-4cd1-af8e-ae6bb871d2b5") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1a1c795a-7a0b-4404-894e-7579ca6d2fa9"), new Guid("0ef31af0-0864-4574-8a23-6328b6332fd4") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1a1c795a-7a0b-4404-894e-7579ca6d2fa9"), new Guid("4dc3f13b-69bd-4707-b2af-2c0239c91bc3") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1a1c795a-7a0b-4404-894e-7579ca6d2fa9"), new Guid("543fc513-de34-490a-a945-8e73ebe00972") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1a1c795a-7a0b-4404-894e-7579ca6d2fa9"), new Guid("755a44eb-fb4b-4664-8dba-912779245ce0") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1a434ecf-c98a-4106-b878-b581d67c0072"), new Guid("7dc36dfd-8b4a-47a0-973d-292a4fc9aac8") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1a434ecf-c98a-4106-b878-b581d67c0072"), new Guid("81b66efa-4764-4632-94f1-15cfb12a8b56") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1a434ecf-c98a-4106-b878-b581d67c0072"), new Guid("878550c2-6dd0-4c95-8ca2-dbb29192bc30") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1a1c795a-7a0b-4404-894e-7579ca6d2fa9"), new Guid("b8ba0176-f17e-4663-9993-19926df07f9a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1a434ecf-c98a-4106-b878-b581d67c0072"), new Guid("d93b5d88-6955-4c93-aa17-6ce0f9f2ab6e") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("213218b9-821e-46c4-a797-c965607bf07f"), new Guid("dc5e39de-ca83-4e68-966d-d2bcf2e32396") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1a434ecf-c98a-4106-b878-b581d67c0072"), new Guid("f9e9a6df-2eed-4300-8c04-89c3b8250b37") });

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("1bf9d576-d586-4838-814a-d17b71603d19"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3068517e-7cfb-4317-84a7-59028bb9f151"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("308d1732-31bc-4a1d-9437-b9721a6747fe"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("39b02cb1-3070-465d-a2f8-141c4f8b706a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("54a54f58-c7b6-4047-b818-f71e83c27430"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("982bcdad-216b-4e6d-86b9-a46ef52d8d41"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("cf0306ed-559a-405d-b49a-dbc26a8f545d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ed6b0138-ef8a-46d4-b9a9-397e54c4979b"));

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 4, new Guid("19d20ebe-74de-4888-9a3b-07217cd79912") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("32f27c54-142f-42c4-8026-b1b5b0e0d90b") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("32f27c54-142f-42c4-8026-b1b5b0e0d90b") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("6d9d1776-1eff-4e90-863c-5e84fc5bb731") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("6d9d1776-1eff-4e90-863c-5e84fc5bb731") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 5, new Guid("a100d404-587f-4f59-9fea-d6eb3a2f9e58") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 4, new Guid("e241f069-b391-4781-a616-fd0abb624e0c") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("e6a65c3f-7b3f-4371-9e04-f0002bb6d6ee") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("e6a65c3f-7b3f-4371-9e04-f0002bb6d6ee") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 3, new Guid("e6a65c3f-7b3f-4371-9e04-f0002bb6d6ee") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1a1c795a-7a0b-4404-894e-7579ca6d2fa9"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1a434ecf-c98a-4106-b878-b581d67c0072"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("213218b9-821e-46c4-a797-c965607bf07f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("05b4fec4-3398-4821-a3cd-aa5e94aaca5b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("077a6834-dbae-4cd1-af8e-ae6bb871d2b5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0ef31af0-0864-4574-8a23-6328b6332fd4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4dc3f13b-69bd-4707-b2af-2c0239c91bc3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("543fc513-de34-490a-a945-8e73ebe00972"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("755a44eb-fb4b-4664-8dba-912779245ce0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7dc36dfd-8b4a-47a0-973d-292a4fc9aac8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("81b66efa-4764-4632-94f1-15cfb12a8b56"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("878550c2-6dd0-4c95-8ca2-dbb29192bc30"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b8ba0176-f17e-4663-9993-19926df07f9a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d93b5d88-6955-4c93-aa17-6ce0f9f2ab6e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dc5e39de-ca83-4e68-966d-d2bcf2e32396"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f9e9a6df-2eed-4300-8c04-89c3b8250b37"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("19d20ebe-74de-4888-9a3b-07217cd79912"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("32f27c54-142f-42c4-8026-b1b5b0e0d90b"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("6d9d1776-1eff-4e90-863c-5e84fc5bb731"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("a100d404-587f-4f59-9fea-d6eb3a2f9e58"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("e241f069-b391-4781-a616-fd0abb624e0c"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("e6a65c3f-7b3f-4371-9e04-f0002bb6d6ee"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("25e96fcf-1f21-4b22-b66a-56361895341f"), null, "Teacher", "TEACHER" },
                    { new Guid("503f4f0c-1732-4a07-bf1e-cc2037af5b4e"), null, "Student", "STUDENT" },
                    { new Guid("a598250c-5da3-4a3a-90b6-c1ac01b5aa54"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AppId", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IdNumber", "IsAuthenticated", "IsGuest", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("21c65c7a-e9c6-45b3-97c8-bb51fcbda27f"), 0, new Guid("4c78381b-2408-493f-a64d-5a6213a8b482"), new DateTime(2024, 12, 7, 17, 13, 22, 967, DateTimeKind.Local).AddTicks(450), "dee12b86-3dcd-48df-9ee2-29365f1dd43e", "ginka@gmail.com", false, "Ginka", "0944174331", true, false, "Stoyanova", false, null, "Petrova", "GINKA@GMAIL.COM", "GINKA@GMAIL.COM", "AQAAAAIAAYagAAAAEFM9uYcvglTwHIDmB5OwV/rCcSu6MwpMxylMcjMrmV6NHZRI55275hmHP7Rie7D9cg==", null, false, "f8d7c5dd-9a5a-4bdf-93e0-dee1be95247b", false, "ginka@gmail.com", new Guid("1a98f223-bd55-4860-a1bd-79b52f9de8e0") },
                    { new Guid("28ee76ba-3314-4928-81e7-3d3b2345b8e7"), 0, new Guid("67c81e73-eb31-49b3-9df4-3c0ba5923c21"), new DateTime(2024, 12, 7, 17, 13, 22, 856, DateTimeKind.Local).AddTicks(7920), "d5e2b7d8-721a-4418-b6a0-abf1ddefde76", "ivan@gmail.com", false, "Ivan", "0141012442", true, false, "Ivanov", false, null, "Ivanov", "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAIAAYagAAAAECEDg8otpcoteHpw0X0IFHC++A1KP12C0selJDZucjd0vJeinY/f+IVJoHXmpqRDKQ==", null, false, "6eef33d1-2817-48a7-af07-ccd2a4efa536", false, "ivan@gmail.com", new Guid("e745a18a-621d-4975-8c8e-dc24808eb54b") },
                    { new Guid("3b3144f8-6feb-419f-87c7-2c85c704017e"), 0, new Guid("2d4fcb19-5a83-4547-a671-4b9983059a74"), new DateTime(2024, 12, 7, 17, 13, 22, 893, DateTimeKind.Local).AddTicks(2760), "2c4dddbc-fcd9-4e88-a91b-2120ac313741", "gencho@gmail.com", false, "Gencho", "0543121244", true, false, "Ginev", false, null, "Petkov", "GENCHO@GMAIL.COM", "GENCHO@GMAIL.COM", "AQAAAAIAAYagAAAAECy114/huQZ26O0EjAv1JqlCjhcpMYRjOB079FZEMkZlx7j/44Ob/HF3BaPyD7LINA==", null, false, "99c89017-a058-46d9-bd46-beef51d1023a", false, "gencho@gmail.com", new Guid("dd81e036-a12f-4401-9a7f-9a8757bbf4ca") },
                    { new Guid("4f76cd66-0a3c-4c78-ba0f-c59e4c75d119"), 0, new Guid("e04e2d7c-8d12-4b0a-9e05-26c9b6237ab3"), new DateTime(2024, 12, 7, 17, 13, 23, 259, DateTimeKind.Local).AddTicks(7940), "317664db-5eb3-4c41-96eb-08d624939a93", "boncho@gmail.com", false, "Boncho", "8006210887", true, false, "Dimitrov", false, null, "Dimitrov", "BONCHO@GMAIL.COM", "BONCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEGNyu3CLDxz4mmovz5BccQmA6c8jTkJWXraBLzgVD+iVUq2q59DXPCh5KgNXT5IrYw==", null, false, "35319b0f-d490-4f4a-bef9-a0b980181649", false, "boncho@gmail.com", new Guid("190ed2c5-5a25-42ed-aa39-57944c128510") },
                    { new Guid("50d6ed37-9db1-4f57-9b41-a5014cb9ba74"), 0, new Guid("99a915aa-d458-41f5-8a48-7a8b875c3f3b"), new DateTime(2024, 12, 7, 17, 13, 22, 929, DateTimeKind.Local).AddTicks(8310), "d35318e5-4167-4208-a9f2-1060c5256174", "martin@gmail.com", false, "Martin", "0741124324", true, false, "Georgiev", false, null, "Ivanov", "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAIAAYagAAAAEPArM3LwSbIAhB6g0BK84Y8ic2p1KwKzHtmWoS5hcJcHvkc9s4XWppiNjx+3yGekfQ==", null, false, "b569b6a5-a881-462f-b062-6f3981f745cd", false, "martin@gmail.com", new Guid("cc51f19b-e079-4107-85b5-8339c9815bd7") },
                    { new Guid("55b6f89c-acea-4f7c-a40d-fc6b37a78fd0"), 0, new Guid("e6d98fff-a613-48a5-bddb-25047c1a99fd"), new DateTime(2024, 12, 7, 17, 13, 23, 113, DateTimeKind.Local).AddTicks(3100), "3425527e-02f9-49af-9b65-1a4bb172e046", "stefka@gmail.com", false, "Stefka", "9003021331", true, false, "Gineva", false, null, "Petkova", "STEFKA@GMAIL.COM", "STEFKA@GMAIL.COM", "AQAAAAIAAYagAAAAEDkgGjIHgPWphgN/WOcVuEFREnNZOeh0zyd9oF6IAd0520wiS6tcfG9wslBdRRK8IA==", null, false, "85376a80-1944-4c64-8771-768baa045124", false, "stefka@gmail.com", new Guid("d00e7508-7806-45d0-ab78-28561ec31d9a") },
                    { new Guid("56335e1a-7d1e-4b4d-8372-880cc45e2f72"), 0, new Guid("e9ca673a-dd6c-4454-a6cd-19f0d2b670d4"), new DateTime(2024, 12, 7, 17, 13, 23, 150, DateTimeKind.Local).AddTicks(6780), "eb48ec40-009c-47f8-939c-24d85a32c363", "stamen@gmail.com", false, "Stamen", "7211053143", true, false, "Peev", false, null, "Georgiev", "STAMEN@GMAIL.COM", "STAMEN@GMAIL.COM", "AQAAAAIAAYagAAAAEHDg7NYKEdUIiZL+Dn5tkx2whIzOAZ7VDiaCBDzORI42Xm3I7W8aMpygWO4AUI2ZtQ==", null, false, "67eafb7d-20e0-4bfa-9429-77cbfad0673c", false, "stamen@gmail.com", new Guid("52451dab-497f-4528-a193-ad6b4de09263") },
                    { new Guid("792c7ad3-cb5b-4a8f-b7d9-fab455046c69"), 0, new Guid("7730ac6b-21dc-45d3-a25e-d3e45ad4e5e9"), new DateTime(2024, 12, 7, 17, 13, 23, 3, DateTimeKind.Local).AddTicks(4630), "940894f7-6bd4-40c5-a766-df780820422a", "jivko@gmail.com", false, "Jivko", "1041124324", true, false, "Donev", false, null, "Vasilev", "JIVKO@GMAIL.COM", "JIVKO@GMAIL.COM", "AQAAAAIAAYagAAAAEIXeQmHWAPTgMN2xFUdMLN3BcoIqtMWFAZ0ntlwygS3kqLhQDAjEABKmr/OKXDYTTQ==", null, false, "2fb370e8-b036-43bc-a5f7-736b6084599a", false, "jivko@gmail.com", new Guid("ddafac86-8447-470b-9f10-b14caf89cbff") },
                    { new Guid("941bbd30-d016-4051-a604-6b3172dcc16d"), 0, new Guid("6140f4c8-1d4a-4d4f-a844-bdc3bdede992"), new DateTime(2024, 12, 7, 17, 13, 23, 75, DateTimeKind.Local).AddTicks(8310), "e476b31f-2f21-4d43-b63a-5fffe2b92af6", "maria@gmail.com", false, "Maria", "8008089119", true, false, "Petrova", false, null, "Ivanova", "MARIA@GMAIL.COM", "MARIA@GMAIL.COM", "AQAAAAIAAYagAAAAEOizxjXIJPDZ+ozXrmIJGpF2BH09lWsxVUIzlGKVqPBLTsyJCJjuDbgCs+E7CGy4mA==", null, false, "e8dfbece-a8db-4877-9ef0-c08d9095f237", false, "maria@gmail.com", new Guid("b7e7357f-54d9-4103-aad4-8dc107ad20ed") },
                    { new Guid("a194e2be-8179-4881-b26b-7e885c570d01"), 0, new Guid("8e1767cd-0408-4202-a599-36caa55696e7"), new DateTime(2024, 12, 7, 17, 13, 23, 187, DateTimeKind.Local).AddTicks(2260), "45fcf9a7-0c29-4474-ab3d-078c1d2bcbd8", "stoyanka@gmail.com", false, "Stoyanka", "7105053113", true, false, "Peneva", false, null, "Doneva", "STOYANKA@GMAIL.COM", "STOYANKA@GMAIL.COM", "AQAAAAIAAYagAAAAEDVF/HCL7iM8UQ5aiJUJlEbFXX0fLgg248r5KnaoZHPJhLXvrstj56BWGfOVFwdtaQ==", null, false, "48330758-2bae-416b-b65d-7d83a20a90e6", false, "stoyanka@gmail.com", new Guid("3f871ccf-99dd-4a8c-b2a3-e22297717754") },
                    { new Guid("d2afa49d-797c-46b5-a824-68e9f4910f81"), 0, new Guid("d2afa49d-797c-46b5-a824-68e9f4910f81"), new DateTime(2024, 12, 7, 17, 13, 23, 296, DateTimeKind.Local).AddTicks(6450), "304444e3-2b02-4871-9f84-9da5399f6178", "admin@scholario.com", true, "Admin", "2452064114", true, false, "Adminov", false, null, "Adminov", "ADMIN@SCHOLARIO.COM", "ADMIN@SCHOLARIO.COM", "AQAAAAIAAYagAAAAEN3Jf1A/cG1bdp0kAemrQj2M0aM2nNQXQxBdTrtor+HmSFIVRxcCeDtZhY7QJHqryw==", null, false, "9fee458e-4beb-455f-a184-7cdc2888ec10", false, "admin@scholario.com", new Guid("d2afa49d-797c-46b5-a824-68e9f4910f81") },
                    { new Guid("e6c8f860-8421-4858-ae5e-540f2dca8e9d"), 0, new Guid("c254d038-d15b-48aa-a313-36a00b59f961"), new DateTime(2024, 12, 7, 17, 13, 23, 223, DateTimeKind.Local).AddTicks(8720), "1e93cdb2-f698-4e9a-a71e-b418ade74cc7", "petar@gmail.com", false, "Petar", "8210045421", true, false, "Chonev", false, null, "Mladenov", "PETAR@GMAIL.COM", "PETAR@GMAIL.COM", "AQAAAAIAAYagAAAAEDqM6bBdIKm48OBVZfPBwb9tzt1JVg+vG5vUo7CjgU6CgDs+Je4HSmoNOWGfmE5Nrw==", null, false, "23bccef5-dcf6-42cc-bc56-1b428cc9ae31", false, "petar@gmail.com", new Guid("77a09f47-5dee-4b65-b61f-36a18316c9ad") },
                    { new Guid("ed2d28b7-83dd-46d9-a1e9-7e20df5312f7"), 0, new Guid("d9db5438-b7c4-49d0-be4e-7cb2b11d64d1"), new DateTime(2024, 12, 7, 17, 13, 23, 39, DateTimeKind.Local).AddTicks(8050), "c0cd6139-b3e9-4110-9c71-3818e7ce71f3", "pencho@gmail.com", false, "Pencho", "0945161226", true, false, "Mihov", false, null, "Angelov", "PENCHO@GMAIL.COM", "PENCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEJnSNeEiJ3qCdFyhl8xMTPvQRYS+yKBSlAqm+FxfPs5F+ib4ZARVLMJV1GDx8KpIKQ==", null, false, "92d17014-bc23-4967-a6c0-2df6ef228dc3", false, "pencho@gmail.com", new Guid("0cb9e7d7-e905-41fe-bc49-114ccc1487ec") }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("2d4fcb19-5a83-4547-a671-4b9983059a74"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("e84bde3e-fea8-4224-85b8-74859d28dee2") },
                    { new Guid("4c78381b-2408-493f-a64d-5a6213a8b482"), 3, "Ginka", "0944174331", "Stoyanova", "Petrova", new Guid("f7753be0-beee-45a6-8194-b8f640e6fb80") },
                    { new Guid("67c81e73-eb31-49b3-9df4-3c0ba5923c21"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("34d5f532-b179-4494-a179-a281bb7f9023") },
                    { new Guid("7730ac6b-21dc-45d3-a25e-d3e45ad4e5e9"), 4, "Jivko", "1041124324", "Donev", "Vasilev", new Guid("7125442d-50db-49e3-b0eb-5fc96afcfa00") },
                    { new Guid("99a915aa-d458-41f5-8a48-7a8b875c3f3b"), 2, "Martin", "0741124324", "Georgiev", "Ivanov", new Guid("9d1349f8-97c2-4044-bdc5-24625f244a9d") },
                    { new Guid("d9660b3c-27f8-42b4-aff9-bd0b044d6556"), 4, "Diana", "1148061932", "Kostova", "Nedeva", new Guid("f8d60357-26d7-4e24-8827-dcf3f31b4232") },
                    { new Guid("d9db5438-b7c4-49d0-be4e-7cb2b11d64d1"), 5, "Pencho", "0945161226", "Mihov", "Angelov", new Guid("eb13c2fd-47f7-4042-98af-f5d387315bc3") },
                    { new Guid("fffaee3e-fdaa-4b66-99f1-dfe3a4d3739e"), 5, "Ruzha", "0852131993", "Veleva", "Todorova", new Guid("40f5e855-1fcf-4955-a767-657ea8e74f9e") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("6140f4c8-1d4a-4d4f-a844-bdc3bdede992"), "Maria", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("241a53e5-e84f-4244-9c83-b0b0ae9e2028") },
                    { new Guid("8e1767cd-0408-4202-a599-36caa55696e7"), "Stoyanka", "7105053113", "Peneva", "Doneva", null, 15, new Guid("c7eb7ddb-82af-4bdf-91e8-b2ae78e35f5b") },
                    { new Guid("c254d038-d15b-48aa-a313-36a00b59f961"), "Petar", "8210045421", "Chonev", "Mladenov", null, 5, new Guid("396d5e18-35f2-4b0f-b862-43d6c2d0d6b4") },
                    { new Guid("e04e2d7c-8d12-4b0a-9e05-26c9b6237ab3"), "Boncho", "8006210887", "Dimitrov", "Dimitrov", null, 9, new Guid("edda37a2-8943-46cb-ac0b-396f75978d64") },
                    { new Guid("e6d98fff-a613-48a5-bddb-25047c1a99fd"), "Stefka", "9003021331", "Gineva", "Petkova", null, 4, new Guid("448862ca-50a8-4072-9ab5-e7cbab23daf6") },
                    { new Guid("e9ca673a-dd6c-4454-a6cd-19f0d2b670d4"), "Stamen", "7211053143", "Peev", "Georgiev", null, 14, new Guid("0d85afc5-63b8-4dde-afc2-ca9a79d410de") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("503f4f0c-1732-4a07-bf1e-cc2037af5b4e"), new Guid("21c65c7a-e9c6-45b3-97c8-bb51fcbda27f") },
                    { new Guid("503f4f0c-1732-4a07-bf1e-cc2037af5b4e"), new Guid("28ee76ba-3314-4928-81e7-3d3b2345b8e7") },
                    { new Guid("503f4f0c-1732-4a07-bf1e-cc2037af5b4e"), new Guid("3b3144f8-6feb-419f-87c7-2c85c704017e") },
                    { new Guid("25e96fcf-1f21-4b22-b66a-56361895341f"), new Guid("4f76cd66-0a3c-4c78-ba0f-c59e4c75d119") },
                    { new Guid("503f4f0c-1732-4a07-bf1e-cc2037af5b4e"), new Guid("50d6ed37-9db1-4f57-9b41-a5014cb9ba74") },
                    { new Guid("25e96fcf-1f21-4b22-b66a-56361895341f"), new Guid("55b6f89c-acea-4f7c-a40d-fc6b37a78fd0") },
                    { new Guid("25e96fcf-1f21-4b22-b66a-56361895341f"), new Guid("56335e1a-7d1e-4b4d-8372-880cc45e2f72") },
                    { new Guid("503f4f0c-1732-4a07-bf1e-cc2037af5b4e"), new Guid("792c7ad3-cb5b-4a8f-b7d9-fab455046c69") },
                    { new Guid("25e96fcf-1f21-4b22-b66a-56361895341f"), new Guid("941bbd30-d016-4051-a604-6b3172dcc16d") },
                    { new Guid("25e96fcf-1f21-4b22-b66a-56361895341f"), new Guid("a194e2be-8179-4881-b26b-7e885c570d01") },
                    { new Guid("a598250c-5da3-4a3a-90b6-c1ac01b5aa54"), new Guid("d2afa49d-797c-46b5-a824-68e9f4910f81") },
                    { new Guid("25e96fcf-1f21-4b22-b66a-56361895341f"), new Guid("e6c8f860-8421-4858-ae5e-540f2dca8e9d") },
                    { new Guid("503f4f0c-1732-4a07-bf1e-cc2037af5b4e"), new Guid("ed2d28b7-83dd-46d9-a1e9-7e20df5312f7") }
                });

            migrationBuilder.InsertData(
                table: "TeachersClasses",
                columns: new[] { "ClassId", "TeacherId" },
                values: new object[,]
                {
                    { 1, new Guid("6140f4c8-1d4a-4d4f-a844-bdc3bdede992") },
                    { 2, new Guid("6140f4c8-1d4a-4d4f-a844-bdc3bdede992") },
                    { 5, new Guid("8e1767cd-0408-4202-a599-36caa55696e7") },
                    { 4, new Guid("c254d038-d15b-48aa-a313-36a00b59f961") },
                    { 4, new Guid("e04e2d7c-8d12-4b0a-9e05-26c9b6237ab3") },
                    { 1, new Guid("e6d98fff-a613-48a5-bddb-25047c1a99fd") },
                    { 2, new Guid("e6d98fff-a613-48a5-bddb-25047c1a99fd") },
                    { 1, new Guid("e9ca673a-dd6c-4454-a6cd-19f0d2b670d4") },
                    { 2, new Guid("e9ca673a-dd6c-4454-a6cd-19f0d2b670d4") },
                    { 3, new Guid("e9ca673a-dd6c-4454-a6cd-19f0d2b670d4") }
                });
        }
    }
}
