using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddProjectSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("656c1bf0-56a0-4aa0-a872-dc653b4bf5ad"), new Guid("00ade01c-106b-48be-b5c3-6ada25def050") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("25438e76-3288-4c35-b19f-f212234f960f"), new Guid("180d29be-0739-4909-a0ef-ed0a2b04c89d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("45c6fa5c-4dcf-411c-8f90-0602c14d9631"), new Guid("210c1a6b-0a43-41e2-9a7f-8be6666a98dd") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("656c1bf0-56a0-4aa0-a872-dc653b4bf5ad"), new Guid("234f7c1c-661c-46be-b920-fdff7e0a2c7e") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("656c1bf0-56a0-4aa0-a872-dc653b4bf5ad"), new Guid("2fbc5ece-e33d-4ad1-87d8-8d364b0b0e6c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("45c6fa5c-4dcf-411c-8f90-0602c14d9631"), new Guid("456bdb06-ab4d-4918-9a79-3fd81962e6f1") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("656c1bf0-56a0-4aa0-a872-dc653b4bf5ad"), new Guid("7579c39d-e2b7-4818-bde0-e8fbdb576b70") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("656c1bf0-56a0-4aa0-a872-dc653b4bf5ad"), new Guid("84a262e1-3070-4e5b-9bbb-b6fbbae41d61") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("45c6fa5c-4dcf-411c-8f90-0602c14d9631"), new Guid("bd2026ba-353c-48ca-9e47-677a9cd4fd66") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("656c1bf0-56a0-4aa0-a872-dc653b4bf5ad"), new Guid("c037b780-5a0c-44f0-b623-b54dccbac55b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("45c6fa5c-4dcf-411c-8f90-0602c14d9631"), new Guid("d8f64b0c-a77e-4cc4-a412-165064f308d2") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("45c6fa5c-4dcf-411c-8f90-0602c14d9631"), new Guid("e9dc8aa9-7bc2-4a60-9772-05d35e6fc908") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("45c6fa5c-4dcf-411c-8f90-0602c14d9631"), new Guid("fec22ed3-ccaf-4a0e-b315-a52ab6fb74cb") });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3e65698a-3f51-4490-b485-2f1a6d7b70ed"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3f964b45-cb68-4b68-9e28-63d4dbe607e9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("4ed8d27b-0d97-4518-8580-a0dc963d34e0"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("6b03fa77-56a5-40e4-ac6e-82b590d66af3"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a5eb78c4-3a0a-4272-9121-213012c18630"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dce6e916-1c04-46c6-aa05-d289a12b8b90"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ec7d47f2-17ad-4a80-974b-eabaa017bdab"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fb530c5d-85bc-4d53-8ede-2188717f4f31"));

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 4, new Guid("7440f78e-9d69-4083-89b9-3b728551083c") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("7684d2b7-f307-4c4d-8fb6-c25cc81cc85d") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("7684d2b7-f307-4c4d-8fb6-c25cc81cc85d") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 3, new Guid("7684d2b7-f307-4c4d-8fb6-c25cc81cc85d") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("af7b042a-cc0e-491d-95de-56e127b35767") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("af7b042a-cc0e-491d-95de-56e127b35767") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 5, new Guid("bdc84d05-74ef-4dcd-8463-25ed3034a2f7") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("e184a8b4-9b1e-4501-b461-9cfe3a44e220") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("e184a8b4-9b1e-4501-b461-9cfe3a44e220") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 4, new Guid("e62978a1-86d7-4ff3-b293-e9864ba42671") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("25438e76-3288-4c35-b19f-f212234f960f"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("45c6fa5c-4dcf-411c-8f90-0602c14d9631"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("656c1bf0-56a0-4aa0-a872-dc653b4bf5ad"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00ade01c-106b-48be-b5c3-6ada25def050"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("180d29be-0739-4909-a0ef-ed0a2b04c89d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("210c1a6b-0a43-41e2-9a7f-8be6666a98dd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("234f7c1c-661c-46be-b920-fdff7e0a2c7e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fbc5ece-e33d-4ad1-87d8-8d364b0b0e6c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("456bdb06-ab4d-4918-9a79-3fd81962e6f1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7579c39d-e2b7-4818-bde0-e8fbdb576b70"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("84a262e1-3070-4e5b-9bbb-b6fbbae41d61"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bd2026ba-353c-48ca-9e47-677a9cd4fd66"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c037b780-5a0c-44f0-b623-b54dccbac55b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d8f64b0c-a77e-4cc4-a412-165064f308d2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e9dc8aa9-7bc2-4a60-9772-05d35e6fc908"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec22ed3-ccaf-4a0e-b315-a52ab6fb74cb"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("7440f78e-9d69-4083-89b9-3b728551083c"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("7684d2b7-f307-4c4d-8fb6-c25cc81cc85d"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("af7b042a-cc0e-491d-95de-56e127b35767"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("bdc84d05-74ef-4dcd-8463-25ed3034a2f7"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("e184a8b4-9b1e-4501-b461-9cfe3a44e220"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("e62978a1-86d7-4ff3-b293-e9864ba42671"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("315a7adf-a26a-4f88-9e54-d7ffc9e73c40"), null, "Admin", "ADMIN" },
                    { new Guid("5278e7cc-b2f8-4418-9956-ea94edfa5e11"), null, "Teacher", "TEACHER" },
                    { new Guid("e14915b6-5db8-4efc-bbdd-9dd0155b1b5c"), null, "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AppId", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IdNumber", "IsAuthenticated", "IsGuest", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("02e6027c-af79-4d89-ad82-51fd24c666cb"), 0, new Guid("3532e3da-36e8-44c8-b0ba-6812a2399668"), new DateTime(2024, 12, 11, 14, 56, 30, 821, DateTimeKind.Local).AddTicks(90), "a927bbb6-fc02-4127-b471-428cac8e07dd", "boncho@gmail.com", false, "Boncho", "8006210887", true, false, "Dimitrov", false, null, "Dimitrov", "BONCHO@GMAIL.COM", "BONCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEI5K8OiTZWojDUs3jNTcqE1kvX7ITExeA5FL2mI3KmGmPd9OqNPxiZ4aiMM4OrJA8A==", null, false, "e6ff5c5e-1b3e-4b70-a483-62351dd74c73", false, "boncho@gmail.com", new Guid("04c4a115-c519-4d5f-bf1d-0d05edaad1fa") },
                    { new Guid("09f1c2b8-20cf-4a65-b28f-088aaa54acdd"), 0, new Guid("3c5b10c9-f2ea-4fe4-8a00-c496c902127b"), new DateTime(2024, 12, 11, 14, 56, 30, 748, DateTimeKind.Local).AddTicks(750), "1d2b4c24-57bd-47d8-b576-b67590c4ce86", "stoyanka@gmail.com", false, "Stoyanka", "7105053113", true, false, "Peneva", false, null, "Doneva", "STOYANKA@GMAIL.COM", "STOYANKA@GMAIL.COM", "AQAAAAIAAYagAAAAEHx7KNPutNvdUDt4Er5yqssdEWPMpQOAkZtYtfyZxAvdPxikRqHIlxwo1dnMlz1Y9w==", null, false, "21cde320-e6ec-4182-83bc-182a5e152128", false, "stoyanka@gmail.com", new Guid("9ee18f2d-773d-4b04-a971-35737a7834d2") },
                    { new Guid("3ec9308c-a947-4e12-b917-1eb212021dbf"), 0, new Guid("bed45ca4-b953-407a-8a30-af305af19b47"), new DateTime(2024, 12, 11, 14, 56, 30, 563, DateTimeKind.Local).AddTicks(3780), "087f35a3-e355-4bfe-8663-4a69e5940f71", "jivko@gmail.com", false, "Jivko", "1041124324", true, false, "Donev", false, null, "Vasilev", "JIVKO@GMAIL.COM", "JIVKO@GMAIL.COM", "AQAAAAIAAYagAAAAEFbNPT1zDg4SlE49WYwBwfnhC6VcUbY3Rm8seLlfYSlIw5ZovdUc0GTcnemghe8GEA==", null, false, "b03b6b78-c149-4831-b3d1-44e7ec65c8c1", false, "jivko@gmail.com", new Guid("a39d469d-40e4-4a90-bb77-5db4112c830e") },
                    { new Guid("5caf9d09-3309-4901-b509-a8f8c9d7c2c8"), 0, new Guid("d190e2a3-b0bf-4d36-b668-226f6d8db1ac"), new DateTime(2024, 12, 11, 14, 56, 30, 488, DateTimeKind.Local).AddTicks(7910), "7c9e6302-3ad1-4683-a173-3414c5e5b247", "martin@gmail.com", false, "Martin", "0741124324", true, false, "Georgiev", false, null, "Ivanov", "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAIAAYagAAAAEA4p33z/b2GkHfhg0uO8wO/qNhDuQSZ8H4Ga38rg/28es3v9ZnnBSIDq2avdysMoNw==", null, false, "57a4e088-f880-46bc-8b3d-0e647ad9df53", false, "martin@gmail.com", new Guid("8afd795d-7070-4207-91b5-d7a380731182") },
                    { new Guid("65af7c3c-17f3-4a98-8700-756ea1094974"), 0, new Guid("d09aa447-0f1b-4474-b503-252af834f91c"), new DateTime(2024, 12, 11, 14, 56, 30, 415, DateTimeKind.Local).AddTicks(8620), "7f95b1d8-c60e-460e-b8f9-873e695e8942", "ivan@gmail.com", false, "Ivan", "0141012442", true, false, "Ivanov", false, null, "Ivanov", "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAIAAYagAAAAEMpXLjsu5Nr8kcj/biiK5Hc3r7z2d3fOYtNkQtEzab21+jgHnTChyRfcEHLIf7QomQ==", null, false, "ad83f695-f1c4-42fe-913a-7166258f54fa", false, "ivan@gmail.com", new Guid("0afc693d-f519-47e1-9019-8cbc9c2f99e4") },
                    { new Guid("79434be7-ca25-46e5-91fd-ccc52bb88a5b"), 0, new Guid("4c559833-ccc1-4a1d-93f3-cbb5130de84c"), new DateTime(2024, 12, 11, 14, 56, 30, 637, DateTimeKind.Local).AddTicks(6480), "eaec447c-3cc4-4d99-8fd3-fb6b4d34ae01", "maria@gmail.com", false, "Maria", "8008089119", true, false, "Petrova", false, null, "Ivanova", "MARIA@GMAIL.COM", "MARIA@GMAIL.COM", "AQAAAAIAAYagAAAAEM7usErYMbUk9LAtCDyMVlV6xbKjwC4ZuxhoI1MSdpjRZ604cm2JWQh00gj7MoXpBQ==", null, false, "fb043a07-33db-4e34-b420-ecf82f76b828", false, "maria@gmail.com", new Guid("cfe94024-8d22-4cc2-a245-8c70651a837f") },
                    { new Guid("96ac60a9-78d1-4713-a9ec-b86ddbb36447"), 0, new Guid("e6f8df2b-8bd6-4036-8beb-d0a2bb0e45f2"), new DateTime(2024, 12, 11, 14, 56, 30, 452, DateTimeKind.Local).AddTicks(3070), "b18d0901-24ff-4614-af83-a39a476b70fd", "gencho@gmail.com", false, "Gencho", "0543121244", true, false, "Ginev", false, null, "Petkov", "GENCHO@GMAIL.COM", "GENCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEDlEaZuNb1zMbL99iRIxA6Xqqo1dzVcVomRcCuboz+m1Omr9rnFHMIexwnwMkLq56A==", null, false, "3ed772ee-ec44-4ebd-9d48-bd62f7604d21", false, "gencho@gmail.com", new Guid("258e084a-3f9e-450a-bae8-68de4a874efe") },
                    { new Guid("afd51e85-d30a-47df-a125-535887f7acab"), 0, new Guid("717c4441-5248-46ae-b2db-a85f907f4304"), new DateTime(2024, 12, 11, 14, 56, 30, 784, DateTimeKind.Local).AddTicks(4280), "12bbe7ef-0e57-4ea1-8651-dc25f485be3e", "petar@gmail.com", false, "Petar", "8210045421", true, false, "Chonev", false, null, "Mladenov", "PETAR@GMAIL.COM", "PETAR@GMAIL.COM", "AQAAAAIAAYagAAAAEGOUWa2T0/H1zOeF9aOXfn9omCDy4an0L56tFFfdYvnmg1dkvIPpraZs8g5XOhQDCw==", null, false, "36325c5d-a710-49ba-b7b7-521e4e372745", false, "petar@gmail.com", new Guid("3065f136-74b1-4878-bc2d-f58f4ced3fdd") },
                    { new Guid("bccc53a4-ce1b-46cb-a86b-cc558f07f699"), 0, new Guid("2953b280-618c-491b-9b5a-247ede5b9205"), new DateTime(2024, 12, 11, 14, 56, 30, 711, DateTimeKind.Local).AddTicks(6940), "af9aa9e7-bd17-4f6e-b112-c64b2af42c17", "stamen@gmail.com", false, "Stamen", "7211053143", true, false, "Peev", false, null, "Georgiev", "STAMEN@GMAIL.COM", "STAMEN@GMAIL.COM", "AQAAAAIAAYagAAAAEAq6eAe3ImpM38QBD6J7TMbJG7vLrYcgV6xdSqkD3Cwl+vINDt7yhgWjqSqVFCgq0Q==", null, false, "1175cbd7-1cce-41bf-984d-6bbf097f24a7", false, "stamen@gmail.com", new Guid("53b8ebf7-0cff-4b13-81de-5929d717b7f7") },
                    { new Guid("cf5cee16-e33b-4af9-a79c-0c5b20cf9696"), 0, new Guid("570037d8-39e9-4b51-83fe-0483253d9945"), new DateTime(2024, 12, 11, 14, 56, 30, 600, DateTimeKind.Local).AddTicks(7110), "487c50d0-1e0a-4955-84ab-b034eca0aa61", "pencho@gmail.com", false, "Pencho", "0945161226", true, false, "Mihov", false, null, "Angelov", "PENCHO@GMAIL.COM", "PENCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEBkFixRSE0ZdNTetUDjvW1oehi/pDy+g7VfYdHNuKScp3fl2DpA25wqUjbLHDuJggw==", null, false, "e88dd725-537f-47bf-81d3-4d5e92d5f407", false, "pencho@gmail.com", new Guid("d1c05375-ec8a-447f-be48-2b1dbc24517e") },
                    { new Guid("d1c0e933-691b-4764-aa77-d51f471422cf"), 0, new Guid("8935b5f9-de8c-40d8-b1b1-e4a18dd8ce66"), new DateTime(2024, 12, 11, 14, 56, 30, 674, DateTimeKind.Local).AddTicks(5480), "0ea25c49-028d-4d21-a9f4-a7c5a768b00f", "stefka@gmail.com", false, "Stefka", "9003021331", true, false, "Gineva", false, null, "Petkova", "STEFKA@GMAIL.COM", "STEFKA@GMAIL.COM", "AQAAAAIAAYagAAAAEI1LTWV3j0SYpF+5Oml8pN/KO/A9LaSI33A1fkQYgnxcQrqOW/KqgFzcgX99Dy0EgA==", null, false, "793bb18c-5d59-439c-9743-6e3d6ed6397f", false, "stefka@gmail.com", new Guid("ea9279fe-6923-406c-bc5e-4bcc33e3585d") },
                    { new Guid("d7fa9658-914f-49fa-aa7a-180cf7fd4469"), 0, new Guid("48378a02-2792-444f-877c-082a1c29a7ab"), new DateTime(2024, 12, 11, 14, 56, 30, 525, DateTimeKind.Local).AddTicks(9980), "763440ef-778c-4742-9f2c-1fe86221acf5", "ginka@gmail.com", false, "Ginka", "0944174331", true, false, "Stoyanova", false, null, "Petrova", "GINKA@GMAIL.COM", "GINKA@GMAIL.COM", "AQAAAAIAAYagAAAAEAoQu4x60R9GVzUv5YBA9wwEnU2Q3aBQhwjr47/vyYubt3+4XuiGntjBMmhe7nRQtg==", null, false, "d2aa1c11-6c08-420b-9134-55040c86ac5d", false, "ginka@gmail.com", new Guid("e5c91ab8-d265-4ac9-8d3e-85a7f0accf08") },
                    { new Guid("e2e853ce-28be-472a-9bb3-e134387475ed"), 0, new Guid("e2e853ce-28be-472a-9bb3-e134387475ed"), new DateTime(2024, 12, 11, 14, 56, 30, 857, DateTimeKind.Local).AddTicks(9340), "ce645da7-f05a-442c-ae2e-72b921f744d4", "admin@scholario.com", true, "Admin", "2452064114", true, false, "Adminov", false, null, "Adminov", "ADMIN@SCHOLARIO.COM", "ADMIN@SCHOLARIO.COM", "AQAAAAIAAYagAAAAEIrYpHmKaXCGrbAOW4lgzF+fuVLobI+5Awc/xyAlWx5mRJqEs5iywyEtzmzj/GxgBg==", null, false, "cdef186e-d319-4936-ac1e-9ed6400200a8", false, "admin@scholario.com", new Guid("e2e853ce-28be-472a-9bb3-e134387475ed") }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Capacity", "EndDate", "Name", "StartDate" },
                values: new object[] { 1, 40, new DateTime(2024, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), "IT Kariera", new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("48378a02-2792-444f-877c-082a1c29a7ab"), 3, "Ginka", "0944174331", "Stoyanova", "Petrova", new Guid("e5c91ab8-d265-4ac9-8d3e-85a7f0accf08") },
                    { new Guid("570037d8-39e9-4b51-83fe-0483253d9945"), 5, "Pencho", "0945161226", "Mihov", "Angelov", new Guid("d1c05375-ec8a-447f-be48-2b1dbc24517e") },
                    { new Guid("800c936a-c61d-4908-b983-9653a7e1b474"), 5, "Ruzha", "0852131993", "Veleva", "Todorova", new Guid("d77fe4d0-1e78-4fec-bf84-435f20e49fdf") },
                    { new Guid("bcd5e300-1df5-431c-b36b-b276fe8c59fb"), 4, "Diana", "1148061932", "Kostova", "Nedeva", new Guid("c8da2b42-1599-40b4-ac58-c5d0795ba964") },
                    { new Guid("bed45ca4-b953-407a-8a30-af305af19b47"), 4, "Jivko", "1041124324", "Donev", "Vasilev", new Guid("a39d469d-40e4-4a90-bb77-5db4112c830e") },
                    { new Guid("d09aa447-0f1b-4474-b503-252af834f91c"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("0afc693d-f519-47e1-9019-8cbc9c2f99e4") },
                    { new Guid("d190e2a3-b0bf-4d36-b668-226f6d8db1ac"), 2, "Martin", "0741124324", "Georgiev", "Ivanov", new Guid("8afd795d-7070-4207-91b5-d7a380731182") },
                    { new Guid("e6f8df2b-8bd6-4036-8beb-d0a2bb0e45f2"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("258e084a-3f9e-450a-bae8-68de4a874efe") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("2953b280-618c-491b-9b5a-247ede5b9205"), "Stamen", "7211053143", "Peev", "Georgiev", null, 14, new Guid("53b8ebf7-0cff-4b13-81de-5929d717b7f7") },
                    { new Guid("3532e3da-36e8-44c8-b0ba-6812a2399668"), "Boncho", "8006210887", "Dimitrov", "Dimitrov", null, 9, new Guid("04c4a115-c519-4d5f-bf1d-0d05edaad1fa") },
                    { new Guid("3c5b10c9-f2ea-4fe4-8a00-c496c902127b"), "Stoyanka", "7105053113", "Peneva", "Doneva", null, 15, new Guid("9ee18f2d-773d-4b04-a971-35737a7834d2") },
                    { new Guid("4c559833-ccc1-4a1d-93f3-cbb5130de84c"), "Maria", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("cfe94024-8d22-4cc2-a245-8c70651a837f") },
                    { new Guid("717c4441-5248-46ae-b2db-a85f907f4304"), "Petar", "8210045421", "Chonev", "Mladenov", null, 5, new Guid("3065f136-74b1-4878-bc2d-f58f4ced3fdd") },
                    { new Guid("8935b5f9-de8c-40d8-b1b1-e4a18dd8ce66"), "Stefka", "9003021331", "Gineva", "Petkova", null, 4, new Guid("ea9279fe-6923-406c-bc5e-4bcc33e3585d") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("5278e7cc-b2f8-4418-9956-ea94edfa5e11"), new Guid("02e6027c-af79-4d89-ad82-51fd24c666cb") },
                    { new Guid("5278e7cc-b2f8-4418-9956-ea94edfa5e11"), new Guid("09f1c2b8-20cf-4a65-b28f-088aaa54acdd") },
                    { new Guid("e14915b6-5db8-4efc-bbdd-9dd0155b1b5c"), new Guid("3ec9308c-a947-4e12-b917-1eb212021dbf") },
                    { new Guid("e14915b6-5db8-4efc-bbdd-9dd0155b1b5c"), new Guid("5caf9d09-3309-4901-b509-a8f8c9d7c2c8") },
                    { new Guid("e14915b6-5db8-4efc-bbdd-9dd0155b1b5c"), new Guid("65af7c3c-17f3-4a98-8700-756ea1094974") },
                    { new Guid("5278e7cc-b2f8-4418-9956-ea94edfa5e11"), new Guid("79434be7-ca25-46e5-91fd-ccc52bb88a5b") },
                    { new Guid("e14915b6-5db8-4efc-bbdd-9dd0155b1b5c"), new Guid("96ac60a9-78d1-4713-a9ec-b86ddbb36447") },
                    { new Guid("5278e7cc-b2f8-4418-9956-ea94edfa5e11"), new Guid("afd51e85-d30a-47df-a125-535887f7acab") },
                    { new Guid("5278e7cc-b2f8-4418-9956-ea94edfa5e11"), new Guid("bccc53a4-ce1b-46cb-a86b-cc558f07f699") },
                    { new Guid("e14915b6-5db8-4efc-bbdd-9dd0155b1b5c"), new Guid("cf5cee16-e33b-4af9-a79c-0c5b20cf9696") },
                    { new Guid("5278e7cc-b2f8-4418-9956-ea94edfa5e11"), new Guid("d1c0e933-691b-4764-aa77-d51f471422cf") },
                    { new Guid("e14915b6-5db8-4efc-bbdd-9dd0155b1b5c"), new Guid("d7fa9658-914f-49fa-aa7a-180cf7fd4469") },
                    { new Guid("315a7adf-a26a-4f88-9e54-d7ffc9e73c40"), new Guid("e2e853ce-28be-472a-9bb3-e134387475ed") }
                });

            migrationBuilder.InsertData(
                table: "SchoolsProjects",
                columns: new[] { "ProjectId", "SchoolId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "TeachersClasses",
                columns: new[] { "ClassId", "TeacherId" },
                values: new object[,]
                {
                    { 1, new Guid("2953b280-618c-491b-9b5a-247ede5b9205") },
                    { 2, new Guid("2953b280-618c-491b-9b5a-247ede5b9205") },
                    { 3, new Guid("2953b280-618c-491b-9b5a-247ede5b9205") },
                    { 4, new Guid("3532e3da-36e8-44c8-b0ba-6812a2399668") },
                    { 5, new Guid("3c5b10c9-f2ea-4fe4-8a00-c496c902127b") },
                    { 1, new Guid("4c559833-ccc1-4a1d-93f3-cbb5130de84c") },
                    { 2, new Guid("4c559833-ccc1-4a1d-93f3-cbb5130de84c") },
                    { 4, new Guid("717c4441-5248-46ae-b2db-a85f907f4304") },
                    { 1, new Guid("8935b5f9-de8c-40d8-b1b1-e4a18dd8ce66") },
                    { 2, new Guid("8935b5f9-de8c-40d8-b1b1-e4a18dd8ce66") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5278e7cc-b2f8-4418-9956-ea94edfa5e11"), new Guid("02e6027c-af79-4d89-ad82-51fd24c666cb") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5278e7cc-b2f8-4418-9956-ea94edfa5e11"), new Guid("09f1c2b8-20cf-4a65-b28f-088aaa54acdd") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e14915b6-5db8-4efc-bbdd-9dd0155b1b5c"), new Guid("3ec9308c-a947-4e12-b917-1eb212021dbf") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e14915b6-5db8-4efc-bbdd-9dd0155b1b5c"), new Guid("5caf9d09-3309-4901-b509-a8f8c9d7c2c8") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e14915b6-5db8-4efc-bbdd-9dd0155b1b5c"), new Guid("65af7c3c-17f3-4a98-8700-756ea1094974") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5278e7cc-b2f8-4418-9956-ea94edfa5e11"), new Guid("79434be7-ca25-46e5-91fd-ccc52bb88a5b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e14915b6-5db8-4efc-bbdd-9dd0155b1b5c"), new Guid("96ac60a9-78d1-4713-a9ec-b86ddbb36447") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5278e7cc-b2f8-4418-9956-ea94edfa5e11"), new Guid("afd51e85-d30a-47df-a125-535887f7acab") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5278e7cc-b2f8-4418-9956-ea94edfa5e11"), new Guid("bccc53a4-ce1b-46cb-a86b-cc558f07f699") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e14915b6-5db8-4efc-bbdd-9dd0155b1b5c"), new Guid("cf5cee16-e33b-4af9-a79c-0c5b20cf9696") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5278e7cc-b2f8-4418-9956-ea94edfa5e11"), new Guid("d1c0e933-691b-4764-aa77-d51f471422cf") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e14915b6-5db8-4efc-bbdd-9dd0155b1b5c"), new Guid("d7fa9658-914f-49fa-aa7a-180cf7fd4469") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("315a7adf-a26a-4f88-9e54-d7ffc9e73c40"), new Guid("e2e853ce-28be-472a-9bb3-e134387475ed") });

            migrationBuilder.DeleteData(
                table: "SchoolsProjects",
                keyColumns: new[] { "ProjectId", "SchoolId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("48378a02-2792-444f-877c-082a1c29a7ab"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("570037d8-39e9-4b51-83fe-0483253d9945"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("800c936a-c61d-4908-b983-9653a7e1b474"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("bcd5e300-1df5-431c-b36b-b276fe8c59fb"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("bed45ca4-b953-407a-8a30-af305af19b47"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d09aa447-0f1b-4474-b503-252af834f91c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d190e2a3-b0bf-4d36-b668-226f6d8db1ac"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e6f8df2b-8bd6-4036-8beb-d0a2bb0e45f2"));

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("2953b280-618c-491b-9b5a-247ede5b9205") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("2953b280-618c-491b-9b5a-247ede5b9205") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 3, new Guid("2953b280-618c-491b-9b5a-247ede5b9205") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 4, new Guid("3532e3da-36e8-44c8-b0ba-6812a2399668") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 5, new Guid("3c5b10c9-f2ea-4fe4-8a00-c496c902127b") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("4c559833-ccc1-4a1d-93f3-cbb5130de84c") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("4c559833-ccc1-4a1d-93f3-cbb5130de84c") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 4, new Guid("717c4441-5248-46ae-b2db-a85f907f4304") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("8935b5f9-de8c-40d8-b1b1-e4a18dd8ce66") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("8935b5f9-de8c-40d8-b1b1-e4a18dd8ce66") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("315a7adf-a26a-4f88-9e54-d7ffc9e73c40"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5278e7cc-b2f8-4418-9956-ea94edfa5e11"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e14915b6-5db8-4efc-bbdd-9dd0155b1b5c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("02e6027c-af79-4d89-ad82-51fd24c666cb"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("09f1c2b8-20cf-4a65-b28f-088aaa54acdd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3ec9308c-a947-4e12-b917-1eb212021dbf"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5caf9d09-3309-4901-b509-a8f8c9d7c2c8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("65af7c3c-17f3-4a98-8700-756ea1094974"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("79434be7-ca25-46e5-91fd-ccc52bb88a5b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("96ac60a9-78d1-4713-a9ec-b86ddbb36447"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("afd51e85-d30a-47df-a125-535887f7acab"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bccc53a4-ce1b-46cb-a86b-cc558f07f699"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf5cee16-e33b-4af9-a79c-0c5b20cf9696"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1c0e933-691b-4764-aa77-d51f471422cf"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d7fa9658-914f-49fa-aa7a-180cf7fd4469"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e2e853ce-28be-472a-9bb3-e134387475ed"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("2953b280-618c-491b-9b5a-247ede5b9205"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("3532e3da-36e8-44c8-b0ba-6812a2399668"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("3c5b10c9-f2ea-4fe4-8a00-c496c902127b"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("4c559833-ccc1-4a1d-93f3-cbb5130de84c"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("717c4441-5248-46ae-b2db-a85f907f4304"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("8935b5f9-de8c-40d8-b1b1-e4a18dd8ce66"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("25438e76-3288-4c35-b19f-f212234f960f"), null, "Admin", "ADMIN" },
                    { new Guid("45c6fa5c-4dcf-411c-8f90-0602c14d9631"), null, "Teacher", "TEACHER" },
                    { new Guid("656c1bf0-56a0-4aa0-a872-dc653b4bf5ad"), null, "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AppId", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IdNumber", "IsAuthenticated", "IsGuest", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("00ade01c-106b-48be-b5c3-6ada25def050"), 0, new Guid("6b03fa77-56a5-40e4-ac6e-82b590d66af3"), new DateTime(2024, 12, 11, 9, 59, 57, 63, DateTimeKind.Local).AddTicks(2920), "42ec8e16-757d-4c62-a7e4-3f250e120219", "gencho@gmail.com", false, "Gencho", "0543121244", true, false, "Ginev", false, null, "Petkov", "GENCHO@GMAIL.COM", "GENCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEIjTY2HKEVPxMoaGSlia/ne3f9jd6J8f2P2VRv1DmgE/ZdCXarXlmvq9rXfJNhMKJA==", null, false, "f2ded37b-0730-4370-8629-a8c1f884e4c8", false, "gencho@gmail.com", new Guid("ae4a8a4f-42b4-49e6-8e82-d933e3199e6c") },
                    { new Guid("180d29be-0739-4909-a0ef-ed0a2b04c89d"), 0, new Guid("180d29be-0739-4909-a0ef-ed0a2b04c89d"), new DateTime(2024, 12, 11, 9, 59, 57, 475, DateTimeKind.Local).AddTicks(910), "1486cb81-3f00-4896-9292-c55469077027", "admin@scholario.com", true, "Admin", "2452064114", true, false, "Adminov", false, null, "Adminov", "ADMIN@SCHOLARIO.COM", "ADMIN@SCHOLARIO.COM", "AQAAAAIAAYagAAAAEEWWH7my/CMzY9tMQLxoAQ9BhzDJezSB+XRqm4J6I2CjXZWTXkaOuUYeG2ni539KIg==", null, false, "14013f28-01b5-42d3-9b4a-fa4e0c913a35", false, "admin@scholario.com", new Guid("180d29be-0739-4909-a0ef-ed0a2b04c89d") },
                    { new Guid("210c1a6b-0a43-41e2-9a7f-8be6666a98dd"), 0, new Guid("7440f78e-9d69-4083-89b9-3b728551083c"), new DateTime(2024, 12, 11, 9, 59, 57, 437, DateTimeKind.Local).AddTicks(200), "fcc3a8a8-9f45-437b-bbdb-a76d3cc51c15", "boncho@gmail.com", false, "Boncho", "8006210887", true, false, "Dimitrov", false, null, "Dimitrov", "BONCHO@GMAIL.COM", "BONCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEDnuv83Rc7hQBMS+6DOqlswh5KPAQgqkuz7vmya8EIyh8osoKZWZ4ZuavtdwoFua5Q==", null, false, "08014328-c674-4121-a423-dab5113bcf23", false, "boncho@gmail.com", new Guid("1939f8a4-7dda-41e0-8dbf-6b82c9d6a342") },
                    { new Guid("234f7c1c-661c-46be-b920-fdff7e0a2c7e"), 0, new Guid("dce6e916-1c04-46c6-aa05-d289a12b8b90"), new DateTime(2024, 12, 11, 9, 59, 57, 136, DateTimeKind.Local).AddTicks(8810), "622157be-882c-4ac9-8952-8fab702d2741", "ginka@gmail.com", false, "Ginka", "0944174331", true, false, "Stoyanova", false, null, "Petrova", "GINKA@GMAIL.COM", "GINKA@GMAIL.COM", "AQAAAAIAAYagAAAAEHflYNJQK65cHlh/Vgi5K+/AHnHR+CBAhFncQfWEnjgrWeVjVrNvLjR6gHlgZVdsEw==", null, false, "643531fb-9368-48f0-85a5-9cf0a10c14db", false, "ginka@gmail.com", new Guid("4d6b8b03-1859-4bd5-bdd9-beed0389e904") },
                    { new Guid("2fbc5ece-e33d-4ad1-87d8-8d364b0b0e6c"), 0, new Guid("fb530c5d-85bc-4d53-8ede-2188717f4f31"), new DateTime(2024, 12, 11, 9, 59, 57, 99, DateTimeKind.Local).AddTicks(4450), "20394574-6918-4d3c-b1ad-c83e519d1a4d", "martin@gmail.com", false, "Martin", "0741124324", true, false, "Georgiev", false, null, "Ivanov", "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAIAAYagAAAAEKoHoA16SIyvLLaKTM1XM6wKJgckL0sc2bcVDE1WTPY2YJQL56dRWI1EECFmdRuGjQ==", null, false, "198db139-5d0c-400f-80a8-d978d97dcaa3", false, "martin@gmail.com", new Guid("95f29e08-0759-4ccd-aa40-5c9d41f30e24") },
                    { new Guid("456bdb06-ab4d-4918-9a79-3fd81962e6f1"), 0, new Guid("e184a8b4-9b1e-4501-b461-9cfe3a44e220"), new DateTime(2024, 12, 11, 9, 59, 57, 248, DateTimeKind.Local).AddTicks(3550), "e79d64c0-87a5-40ae-b491-f0c39e1826b9", "maria@gmail.com", false, "Maria", "8008089119", true, false, "Petrova", false, null, "Ivanova", "MARIA@GMAIL.COM", "MARIA@GMAIL.COM", "AQAAAAIAAYagAAAAEC6TXUDkjsnyszTR7i2kohvp57h5fKjipKXySEF3tpmc+6A89s+0cyut15gjTlV3Sw==", null, false, "6bbb4036-b0ac-40b5-96a0-1041d4345463", false, "maria@gmail.com", new Guid("7f9ef5ba-60ff-4270-98f7-c7ed4bbf9ad2") },
                    { new Guid("7579c39d-e2b7-4818-bde0-e8fbdb576b70"), 0, new Guid("4ed8d27b-0d97-4518-8580-a0dc963d34e0"), new DateTime(2024, 12, 11, 9, 59, 57, 26, DateTimeKind.Local).AddTicks(4990), "9c4aa8b8-4c0c-4027-bf67-d57eab09a2fe", "ivan@gmail.com", false, "Ivan", "0141012442", true, false, "Ivanov", false, null, "Ivanov", "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAIAAYagAAAAEJLrdygYlPGn6Le8iMFlmw78Uh6SovGqLr78bZNiI/yiPZBycAF79U4kRZXHbKYAww==", null, false, "6d47f969-3cb9-4dcf-a20b-eadeccf0a58e", false, "ivan@gmail.com", new Guid("679132e0-4871-4277-ad8b-6db85c0e6b55") },
                    { new Guid("84a262e1-3070-4e5b-9bbb-b6fbbae41d61"), 0, new Guid("3f964b45-cb68-4b68-9e28-63d4dbe607e9"), new DateTime(2024, 12, 11, 9, 59, 57, 211, DateTimeKind.Local).AddTicks(2280), "21394041-335e-458d-bc3f-b04cbc591803", "pencho@gmail.com", false, "Pencho", "0945161226", true, false, "Mihov", false, null, "Angelov", "PENCHO@GMAIL.COM", "PENCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEHes17aQDJJlucxqJQj4WP0x108M5dIqOSNw9InODGhDrLuzR2uOFPKa75EupY2vJQ==", null, false, "d125cbcc-bb23-48dd-b2f8-f5841c897709", false, "pencho@gmail.com", new Guid("3441bd08-8514-4929-875b-7e6a135bf2ad") },
                    { new Guid("bd2026ba-353c-48ca-9e47-677a9cd4fd66"), 0, new Guid("bdc84d05-74ef-4dcd-8463-25ed3034a2f7"), new DateTime(2024, 12, 11, 9, 59, 57, 361, DateTimeKind.Local).AddTicks(2810), "3a25c7c4-debc-4254-be00-3a3b53626a4f", "stoyanka@gmail.com", false, "Stoyanka", "7105053113", true, false, "Peneva", false, null, "Doneva", "STOYANKA@GMAIL.COM", "STOYANKA@GMAIL.COM", "AQAAAAIAAYagAAAAENCGgKt3spoWgNTdkh4uc0WGYdVlOcIHeTXc8Ko3yuW61Gwt9dOt+gCXD2qT+mlBpQ==", null, false, "7348ca2d-4822-46ba-9340-472ddf0ce420", false, "stoyanka@gmail.com", new Guid("37a0d9fa-d033-44ea-a1c6-93fe59cb8f89") },
                    { new Guid("c037b780-5a0c-44f0-b623-b54dccbac55b"), 0, new Guid("a5eb78c4-3a0a-4272-9121-213012c18630"), new DateTime(2024, 12, 11, 9, 59, 57, 174, DateTimeKind.Local).AddTicks(3840), "ec18d609-bbc7-4dab-850d-bd3ba5e1ac64", "jivko@gmail.com", false, "Jivko", "1041124324", true, false, "Donev", false, null, "Vasilev", "JIVKO@GMAIL.COM", "JIVKO@GMAIL.COM", "AQAAAAIAAYagAAAAEDtOhg3OdkkowOfNy19C9PDTLv0CBz9R7TLFO6XWZPZJu3DNafS/XAb7pQARmQUCQw==", null, false, "0015ce39-440d-44e1-a24e-602a89088584", false, "jivko@gmail.com", new Guid("4b529d7a-8379-4049-bbef-9e2baf46a5bc") },
                    { new Guid("d8f64b0c-a77e-4cc4-a412-165064f308d2"), 0, new Guid("e62978a1-86d7-4ff3-b293-e9864ba42671"), new DateTime(2024, 12, 11, 9, 59, 57, 398, DateTimeKind.Local).AddTicks(8550), "746a184e-dc19-400b-a657-e575202ee2c1", "petar@gmail.com", false, "Petar", "8210045421", true, false, "Chonev", false, null, "Mladenov", "PETAR@GMAIL.COM", "PETAR@GMAIL.COM", "AQAAAAIAAYagAAAAEH5DJdZI+1L8a97VZqkOEhWqA83v3xqvNYclAt86vVhWk2GJyW+bUqFNK6IxBuEvyA==", null, false, "703e92e2-b058-4740-a932-4f15cc3d114a", false, "petar@gmail.com", new Guid("b7133904-8f92-4365-bf40-7414fce40419") },
                    { new Guid("e9dc8aa9-7bc2-4a60-9772-05d35e6fc908"), 0, new Guid("7684d2b7-f307-4c4d-8fb6-c25cc81cc85d"), new DateTime(2024, 12, 11, 9, 59, 57, 324, DateTimeKind.Local).AddTicks(3680), "f81345df-80a2-4a48-805f-c3aed7f70757", "stamen@gmail.com", false, "Stamen", "7211053143", true, false, "Peev", false, null, "Georgiev", "STAMEN@GMAIL.COM", "STAMEN@GMAIL.COM", "AQAAAAIAAYagAAAAEBLpbH3rNOfpeHzfBN3B8CEKroOeWjA7hyhsK1+tpGiqH4icAbbv5VKVAzSiQBLhhg==", null, false, "00d29be7-957e-48bb-87e5-f01488b964f3", false, "stamen@gmail.com", new Guid("19dbce97-dc6e-4012-8dd0-3995f1310041") },
                    { new Guid("fec22ed3-ccaf-4a0e-b315-a52ab6fb74cb"), 0, new Guid("af7b042a-cc0e-491d-95de-56e127b35767"), new DateTime(2024, 12, 11, 9, 59, 57, 286, DateTimeKind.Local).AddTicks(2410), "d7e08b9a-90a8-4d77-a433-e0a9e3add0d1", "stefka@gmail.com", false, "Stefka", "9003021331", true, false, "Gineva", false, null, "Petkova", "STEFKA@GMAIL.COM", "STEFKA@GMAIL.COM", "AQAAAAIAAYagAAAAEFUN7TSnpywgoh6sQ0jyM6Gzj7jv5wdygEGsdXLqox+C86xK8iYBCq0mPPItS9ezzg==", null, false, "7969267d-e2ca-423f-a128-492d155c934d", false, "stefka@gmail.com", new Guid("f2359895-0c63-4c2c-80cb-d95accb196b6") }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("3e65698a-3f51-4490-b485-2f1a6d7b70ed"), 5, "Ruzha", "0852131993", "Veleva", "Todorova", new Guid("50b5d4a3-a470-4095-8cb2-b91a0696c509") },
                    { new Guid("3f964b45-cb68-4b68-9e28-63d4dbe607e9"), 5, "Pencho", "0945161226", "Mihov", "Angelov", new Guid("3441bd08-8514-4929-875b-7e6a135bf2ad") },
                    { new Guid("4ed8d27b-0d97-4518-8580-a0dc963d34e0"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("679132e0-4871-4277-ad8b-6db85c0e6b55") },
                    { new Guid("6b03fa77-56a5-40e4-ac6e-82b590d66af3"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("ae4a8a4f-42b4-49e6-8e82-d933e3199e6c") },
                    { new Guid("a5eb78c4-3a0a-4272-9121-213012c18630"), 4, "Jivko", "1041124324", "Donev", "Vasilev", new Guid("4b529d7a-8379-4049-bbef-9e2baf46a5bc") },
                    { new Guid("dce6e916-1c04-46c6-aa05-d289a12b8b90"), 3, "Ginka", "0944174331", "Stoyanova", "Petrova", new Guid("4d6b8b03-1859-4bd5-bdd9-beed0389e904") },
                    { new Guid("ec7d47f2-17ad-4a80-974b-eabaa017bdab"), 4, "Diana", "1148061932", "Kostova", "Nedeva", new Guid("89a0beed-dde7-4158-83ef-10c989a878db") },
                    { new Guid("fb530c5d-85bc-4d53-8ede-2188717f4f31"), 2, "Martin", "0741124324", "Georgiev", "Ivanov", new Guid("95f29e08-0759-4ccd-aa40-5c9d41f30e24") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("7440f78e-9d69-4083-89b9-3b728551083c"), "Boncho", "8006210887", "Dimitrov", "Dimitrov", null, 9, new Guid("1939f8a4-7dda-41e0-8dbf-6b82c9d6a342") },
                    { new Guid("7684d2b7-f307-4c4d-8fb6-c25cc81cc85d"), "Stamen", "7211053143", "Peev", "Georgiev", null, 14, new Guid("19dbce97-dc6e-4012-8dd0-3995f1310041") },
                    { new Guid("af7b042a-cc0e-491d-95de-56e127b35767"), "Stefka", "9003021331", "Gineva", "Petkova", null, 4, new Guid("f2359895-0c63-4c2c-80cb-d95accb196b6") },
                    { new Guid("bdc84d05-74ef-4dcd-8463-25ed3034a2f7"), "Stoyanka", "7105053113", "Peneva", "Doneva", null, 15, new Guid("37a0d9fa-d033-44ea-a1c6-93fe59cb8f89") },
                    { new Guid("e184a8b4-9b1e-4501-b461-9cfe3a44e220"), "Maria", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("7f9ef5ba-60ff-4270-98f7-c7ed4bbf9ad2") },
                    { new Guid("e62978a1-86d7-4ff3-b293-e9864ba42671"), "Petar", "8210045421", "Chonev", "Mladenov", null, 5, new Guid("b7133904-8f92-4365-bf40-7414fce40419") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("656c1bf0-56a0-4aa0-a872-dc653b4bf5ad"), new Guid("00ade01c-106b-48be-b5c3-6ada25def050") },
                    { new Guid("25438e76-3288-4c35-b19f-f212234f960f"), new Guid("180d29be-0739-4909-a0ef-ed0a2b04c89d") },
                    { new Guid("45c6fa5c-4dcf-411c-8f90-0602c14d9631"), new Guid("210c1a6b-0a43-41e2-9a7f-8be6666a98dd") },
                    { new Guid("656c1bf0-56a0-4aa0-a872-dc653b4bf5ad"), new Guid("234f7c1c-661c-46be-b920-fdff7e0a2c7e") },
                    { new Guid("656c1bf0-56a0-4aa0-a872-dc653b4bf5ad"), new Guid("2fbc5ece-e33d-4ad1-87d8-8d364b0b0e6c") },
                    { new Guid("45c6fa5c-4dcf-411c-8f90-0602c14d9631"), new Guid("456bdb06-ab4d-4918-9a79-3fd81962e6f1") },
                    { new Guid("656c1bf0-56a0-4aa0-a872-dc653b4bf5ad"), new Guid("7579c39d-e2b7-4818-bde0-e8fbdb576b70") },
                    { new Guid("656c1bf0-56a0-4aa0-a872-dc653b4bf5ad"), new Guid("84a262e1-3070-4e5b-9bbb-b6fbbae41d61") },
                    { new Guid("45c6fa5c-4dcf-411c-8f90-0602c14d9631"), new Guid("bd2026ba-353c-48ca-9e47-677a9cd4fd66") },
                    { new Guid("656c1bf0-56a0-4aa0-a872-dc653b4bf5ad"), new Guid("c037b780-5a0c-44f0-b623-b54dccbac55b") },
                    { new Guid("45c6fa5c-4dcf-411c-8f90-0602c14d9631"), new Guid("d8f64b0c-a77e-4cc4-a412-165064f308d2") },
                    { new Guid("45c6fa5c-4dcf-411c-8f90-0602c14d9631"), new Guid("e9dc8aa9-7bc2-4a60-9772-05d35e6fc908") },
                    { new Guid("45c6fa5c-4dcf-411c-8f90-0602c14d9631"), new Guid("fec22ed3-ccaf-4a0e-b315-a52ab6fb74cb") }
                });

            migrationBuilder.InsertData(
                table: "TeachersClasses",
                columns: new[] { "ClassId", "TeacherId" },
                values: new object[,]
                {
                    { 4, new Guid("7440f78e-9d69-4083-89b9-3b728551083c") },
                    { 1, new Guid("7684d2b7-f307-4c4d-8fb6-c25cc81cc85d") },
                    { 2, new Guid("7684d2b7-f307-4c4d-8fb6-c25cc81cc85d") },
                    { 3, new Guid("7684d2b7-f307-4c4d-8fb6-c25cc81cc85d") },
                    { 1, new Guid("af7b042a-cc0e-491d-95de-56e127b35767") },
                    { 2, new Guid("af7b042a-cc0e-491d-95de-56e127b35767") },
                    { 5, new Guid("bdc84d05-74ef-4dcd-8463-25ed3034a2f7") },
                    { 1, new Guid("e184a8b4-9b1e-4501-b461-9cfe3a44e220") },
                    { 2, new Guid("e184a8b4-9b1e-4501-b461-9cfe3a44e220") },
                    { 4, new Guid("e62978a1-86d7-4ff3-b293-e9864ba42671") }
                });
        }
    }
}
