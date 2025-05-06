using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddIsRegisteredPropertyToUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3);

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
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 5);

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

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddColumn<bool>(
                name: "IsRegistered",
                table: "Teachers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsRegistered",
                table: "Students",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRegistered",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "IsRegistered",
                table: "Students");

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
                table: "Schools",
                columns: new[] { "Id", "Address", "Description", "LogoUrl", "Name" },
                values: new object[,]
                {
                    { 1, "Avgusta Trayana 44, Stara Zagora, Bulgaria", "The School of Informatics and Mathematics in Stara Zagora", "https://scontent.fsof1-2.fna.fbcdn.net/v/t39.30808-6/327026697_887516432673344_8690934784557383737_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=6ee11a&_nc_ohc=Rr0iH229ZRwQ7kNvgFeKEcF&_nc_zt=23&_nc_ht=scontent.fsof1-2.fna&_nc_gid=AizPmB3yiG6QTT84Mh5cpaJ&oh=00_AYDekshXGVy2Xa02RxZHINhma0rvygf0uH2D2_cO5om7Dg&oe=675539CD", "PPMG \"Geo Milev\"" },
                    { 2, "Tsar Ivan Shishman 62, Stara Zagora, Bulgaria", "Stara Zagora's School for Languages like German, French and English", "https://scontent.fsof1-2.fna.fbcdn.net/v/t1.6435-9/119450239_3343706645698457_6833144760730823616_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=6ee11a&_nc_ohc=ydzqvT5knjIQ7kNvgHdpGNw&_nc_zt=23&_nc_ht=scontent.fsof1-2.fna&_nc_gid=AFu1voqShMlHBNalgqkJBc1&oh=00_AYCyzp4BZ7gcXj6ZSnpr1Oop6AQoeJAI-BKPdIUJsGXD5Q&oe=677BAAFA", "SSFL \"Romain Rolland\"" },
                    { 3, "Sveti Kliment Ohridski 8, Sofia, Bulgaria", "The Technical University of Sofia is Bulgaria's largest and foremost academic establishment for higher engineering education.", "https://scontent.fsof1-1.fna.fbcdn.net/v/t39.30808-6/453179855_1108969364009343_5412650960044976974_n.jpg?_nc_cat=101&ccb=1-7&_nc_sid=6ee11a&_nc_ohc=qPhfwrpLKZUQ7kNvgGHjtnI&_nc_zt=23&_nc_ht=scontent.fsof1-1.fna&_nc_gid=A1xPbdI_kb_P2-V2ZeYF9Ij&oh=00_AYCD4-wxXkM0nUjRh1A3Z58xa9vtxRdQAf4fh6OnOsLa_g&oe=675A5DED", "Technical University of Sofia" }
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
                table: "Classes",
                columns: new[] { "Id", "Name", "SchoolId", "Speciality", "TimetableId" },
                values: new object[,]
                {
                    { 1, "9b", 1, 1, null },
                    { 2, "10b", 1, 1, null },
                    { 3, "8g", 1, 2, null },
                    { 4, "10a", 2, 5, null },
                    { 5, "11v", 2, 6, null }
                });

            migrationBuilder.InsertData(
                table: "SchoolsProjects",
                columns: new[] { "ProjectId", "SchoolId" },
                values: new object[] { 1, 1 });

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
    }
}
