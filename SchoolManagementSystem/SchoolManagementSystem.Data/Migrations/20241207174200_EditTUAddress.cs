using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class EditTUAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("01877c5c-958f-4588-9796-c5afbccd8543"), null, "Admin", "ADMIN" },
                    { new Guid("61a4d412-d278-4791-b18d-e45f551366dc"), null, "Student", "STUDENT" },
                    { new Guid("a68416ad-e044-4088-a03d-c2cf431a2e86"), null, "Teacher", "TEACHER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AppId", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IdNumber", "IsAuthenticated", "IsGuest", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("42b1fe04-7ce6-4256-83e8-f08dbacb3a4a"), 0, new Guid("42b1fe04-7ce6-4256-83e8-f08dbacb3a4a"), new DateTime(2024, 12, 7, 19, 41, 59, 816, DateTimeKind.Local).AddTicks(3360), "3a726662-aab1-4661-8038-aaef0680dfe8", "admin@scholario.com", true, "Admin", "2452064114", true, false, "Adminov", false, null, "Adminov", "ADMIN@SCHOLARIO.COM", "ADMIN@SCHOLARIO.COM", "AQAAAAIAAYagAAAAEDkziiiIVZpFqWekCWPCgooJ090SbNM4Phw9QDQ7GyaxwHKxNDmjjKnpPFNfAwbr7A==", null, false, "8bfbc3ed-1573-4d0a-b20a-8e22e7fce327", false, "admin@scholario.com", new Guid("42b1fe04-7ce6-4256-83e8-f08dbacb3a4a") },
                    { new Guid("4d50b8fa-fb33-4f08-8b48-1d961f446d83"), 0, new Guid("e6132c62-1faf-48c3-b637-54bb5efe5cce"), new DateTime(2024, 12, 7, 19, 41, 59, 600, DateTimeKind.Local).AddTicks(7890), "0cf57149-3630-43ca-9212-9ecf7787e40c", "maria@gmail.com", false, "Maria", "8008089119", true, false, "Petrova", false, null, "Ivanova", "MARIA@GMAIL.COM", "MARIA@GMAIL.COM", "AQAAAAIAAYagAAAAECKV385B0QrYQp/87QnV5o6W3mmLxQokJyIkVeahjyF47leTkrPFvb5xaYoNlVYuZg==", null, false, "7cfd57e2-7c21-46b3-acad-bf3ae9288baa", false, "maria@gmail.com", new Guid("1176dcb2-856f-4c1e-b302-2db04f27f261") },
                    { new Guid("5cad4018-0fe3-4d3d-9712-9072c8ade2b7"), 0, new Guid("1c68d182-bdd6-4f77-b014-123f2c3c6dba"), new DateTime(2024, 12, 7, 19, 41, 59, 419, DateTimeKind.Local).AddTicks(5170), "2748204e-4721-450e-8b1d-74b22521e483", "gencho@gmail.com", false, "Gencho", "0543121244", true, false, "Ginev", false, null, "Petkov", "GENCHO@GMAIL.COM", "GENCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEMG6puMIXFXruXhfON15EkdUUMU6+2v/xRQqoKx+bnjs6PRq/IhoaNUT7P3ozJA9tA==", null, false, "ffc70855-666c-4744-a981-70d8373ebf3a", false, "gencho@gmail.com", new Guid("6a739ecb-088b-434e-8322-a2a64b41152a") },
                    { new Guid("6726d3b5-e980-4203-9eb9-edc9c4252e7d"), 0, new Guid("53e5d108-80ce-4787-9918-05fa35e97718"), new DateTime(2024, 12, 7, 19, 41, 59, 744, DateTimeKind.Local).AddTicks(6600), "a383de59-26a5-4d99-a9af-9b1435a89589", "petar@gmail.com", false, "Petar", "8210045421", true, false, "Chonev", false, null, "Mladenov", "PETAR@GMAIL.COM", "PETAR@GMAIL.COM", "AQAAAAIAAYagAAAAECukGIgtBOoZghk4tW/rAWoFDQMmX18FaQMopFlp5y6GQ7f1Rqk/FRqmX6kZ05a3mg==", null, false, "bd8302d0-064a-47ef-a1d2-48d8bddc4cd4", false, "petar@gmail.com", new Guid("141b3343-0f41-48ef-9199-eb7f0d03ad61") },
                    { new Guid("6e469e61-f39b-4a1d-9952-84aa7edeedce"), 0, new Guid("c8815eee-bcba-413b-b495-915281f30c43"), new DateTime(2024, 12, 7, 19, 41, 59, 637, DateTimeKind.Local).AddTicks(2070), "3d650728-30a3-495e-b10f-c12063212b25", "stefka@gmail.com", false, "Stefka", "9003021331", true, false, "Gineva", false, null, "Petkova", "STEFKA@GMAIL.COM", "STEFKA@GMAIL.COM", "AQAAAAIAAYagAAAAEC0MLW/UQopjTVxz9zZ54dV409RbZsorjbIhXrA7LdOVDBc0v3f5gHnkHZkgsjNi/w==", null, false, "dbdda5fd-e8e1-4531-ae15-dd32199571a0", false, "stefka@gmail.com", new Guid("7a7dff15-8666-46d5-b055-06eea06f4b4f") },
                    { new Guid("7ae0afea-5799-46d3-8f25-14a80933d224"), 0, new Guid("4aa6b93b-2733-43ba-9bf7-9ed44699a0b6"), new DateTime(2024, 12, 7, 19, 41, 59, 564, DateTimeKind.Local).AddTicks(3610), "aed26156-40d2-4b02-9092-14f402fcf558", "pencho@gmail.com", false, "Pencho", "0945161226", true, false, "Mihov", false, null, "Angelov", "PENCHO@GMAIL.COM", "PENCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEAgORN4l0WcT2X3+YhTrrVVHiceu/poYmvBZJ16JZT6r85fo6X9AKlZOeGXElXGCVw==", null, false, "0c9d79bc-e418-4b0a-b907-99f878ba6b63", false, "pencho@gmail.com", new Guid("3150f857-5ddb-45c5-b0db-0855d5a3b5ec") },
                    { new Guid("89da9466-173b-416c-a2f1-f1d77ce02c09"), 0, new Guid("7ed094cc-7b9c-4066-b7b4-326c9d36fa43"), new DateTime(2024, 12, 7, 19, 41, 59, 455, DateTimeKind.Local).AddTicks(1110), "61157fd4-f3f6-458b-896c-3285a950f5c5", "martin@gmail.com", false, "Martin", "0741124324", true, false, "Georgiev", false, null, "Ivanov", "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAIAAYagAAAAEDxxdbqmCLGMVi8La96++Bnyj+ltU85otLW7D2gcuWZKrkObSzw4SmfVTMtSNHTfmg==", null, false, "c38f2897-0e1b-498b-90c5-f198af9836c2", false, "martin@gmail.com", new Guid("84aef1e9-5bc0-46cd-a960-80acdc7527d4") },
                    { new Guid("8d772f07-5e71-4de2-982c-fc58f2316840"), 0, new Guid("a08ef20c-fa01-4ddc-b66c-e2c0f27ca0a7"), new DateTime(2024, 12, 7, 19, 41, 59, 527, DateTimeKind.Local).AddTicks(7680), "aa268271-dc24-4644-a4ff-65acaedcb32b", "jivko@gmail.com", false, "Jivko", "1041124324", true, false, "Donev", false, null, "Vasilev", "JIVKO@GMAIL.COM", "JIVKO@GMAIL.COM", "AQAAAAIAAYagAAAAEJYsDsFwmwfk9KVUXFyMgqiRrn5yqQHm+OCE4Hx9MFq1mFcr/Hx9/A5AJ8ePsB+R/A==", null, false, "8a45c975-8b00-455f-ad1b-0f4c3002fa37", false, "jivko@gmail.com", new Guid("e82b9aa4-6c41-4e4e-8273-cf50129d571d") },
                    { new Guid("9eb1c4b5-95c8-4112-9f61-732fd34b43aa"), 0, new Guid("aa0ab228-f39a-4292-9f38-d4f5374ebf57"), new DateTime(2024, 12, 7, 19, 41, 59, 709, DateTimeKind.Local).AddTicks(730), "c11a61cc-c986-4000-8b9c-9440b9962180", "stoyanka@gmail.com", false, "Stoyanka", "7105053113", true, false, "Peneva", false, null, "Doneva", "STOYANKA@GMAIL.COM", "STOYANKA@GMAIL.COM", "AQAAAAIAAYagAAAAEGCjX147AHCDURJQgvNSZg9VNXiCFbgc2npAW6XXHcYY6vAMe6dV5R8B33HtKhRR9w==", null, false, "a45efe0f-a46d-4641-be66-fae84e691043", false, "stoyanka@gmail.com", new Guid("6ea7d4be-e413-4413-96cc-1a2de79f10fe") },
                    { new Guid("bb2caabd-0fa8-4fcf-920b-d83aefbab958"), 0, new Guid("339f87ba-c15d-40cc-929b-596d437b4f7f"), new DateTime(2024, 12, 7, 19, 41, 59, 491, DateTimeKind.Local).AddTicks(4490), "6ae75491-074d-415a-9214-fa067cb31a82", "ginka@gmail.com", false, "Ginka", "0944174331", true, false, "Stoyanova", false, null, "Petrova", "GINKA@GMAIL.COM", "GINKA@GMAIL.COM", "AQAAAAIAAYagAAAAED8j9Vi48Zs7AOYoKd5OA2ITAMLlNycXXmoWdjRsvBtajCoHMxWCOjwsIA0EqcgyCg==", null, false, "90de05e0-9fea-40a5-af9f-bf9beb277b9a", false, "ginka@gmail.com", new Guid("31d7b2c3-4136-4f6a-97eb-709e65422d84") },
                    { new Guid("c6ffa9cb-4c02-4fde-90e2-80bb539c597a"), 0, new Guid("4a852dba-f9da-4582-86c9-434cbbecdfdd"), new DateTime(2024, 12, 7, 19, 41, 59, 673, DateTimeKind.Local).AddTicks(1720), "a57453b2-bb01-4651-8fb0-801d81ff7250", "stamen@gmail.com", false, "Stamen", "7211053143", true, false, "Peev", false, null, "Georgiev", "STAMEN@GMAIL.COM", "STAMEN@GMAIL.COM", "AQAAAAIAAYagAAAAENio7G5eord9VB6GzYW9dYZYPLC52wiHeG640UhGR5P12fBSUUoEyw3y2nc9JI5Gqg==", null, false, "abc65c5b-c759-470b-98c7-47765165eeda", false, "stamen@gmail.com", new Guid("d3993dd9-6f63-48d3-bf77-589e67635340") },
                    { new Guid("f304fb99-f3f3-44bf-ad0e-27305ed91e5e"), 0, new Guid("6d826163-288d-4b57-89b9-396587228288"), new DateTime(2024, 12, 7, 19, 41, 59, 384, DateTimeKind.Local).AddTicks(20), "d89965cb-ee3e-4045-916a-63850660b88b", "ivan@gmail.com", false, "Ivan", "0141012442", true, false, "Ivanov", false, null, "Ivanov", "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAIAAYagAAAAENFvgrE+4O+k6xi8L+WIoxiUC/qIn/0+W36psfCiTWS5f7l8Dtx8iIxEuXDcnRSSxQ==", null, false, "e531909c-4398-438d-80dd-1d5aca2e9c7f", false, "ivan@gmail.com", new Guid("b020e5e2-2653-4b38-a9c6-3efd62072f1f") },
                    { new Guid("fcc7587f-8d7c-44f6-ace6-4f9ccb23d363"), 0, new Guid("7385dadb-87ab-4b8f-8a21-cf05d8c03824"), new DateTime(2024, 12, 7, 19, 41, 59, 780, DateTimeKind.Local).AddTicks(7510), "2e945653-72dc-4f44-82a3-31b82a6f65df", "boncho@gmail.com", false, "Boncho", "8006210887", true, false, "Dimitrov", false, null, "Dimitrov", "BONCHO@GMAIL.COM", "BONCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEBua4mtTI9v2QRJ9azTEFEJRAhrqSPftkqarqZdRDZeFZ+ZFCpYNb0K7DqK8Lce0Fg==", null, false, "fd02b0d2-801c-4775-b7c3-3cb74359b510", false, "boncho@gmail.com", new Guid("0611b0e9-c60e-4216-a652-e9bce97ab26c") }
                });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3,
                column: "Address",
                value: "Sveti Kliment Ohridski 8, Sofia, Bulgaria");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("1c68d182-bdd6-4f77-b014-123f2c3c6dba"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("54f2404f-5250-4f69-a781-680301583d6d") },
                    { new Guid("339f87ba-c15d-40cc-929b-596d437b4f7f"), 3, "Ginka", "0944174331", "Stoyanova", "Petrova", new Guid("bf9fe6d6-60b7-4995-a9d2-141e3384d539") },
                    { new Guid("4aa6b93b-2733-43ba-9bf7-9ed44699a0b6"), 5, "Pencho", "0945161226", "Mihov", "Angelov", new Guid("39f6e5d2-762d-4b1b-8792-8dab01da6d2d") },
                    { new Guid("5a950535-fb80-4f84-a18b-c41137ffb459"), 4, "Diana", "1148061932", "Kostova", "Nedeva", new Guid("c3fb7a8d-968b-4697-81eb-0d8da10947ae") },
                    { new Guid("6d826163-288d-4b57-89b9-396587228288"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("e68e8071-def2-4659-8a2b-54b79210c9f1") },
                    { new Guid("7ed094cc-7b9c-4066-b7b4-326c9d36fa43"), 2, "Martin", "0741124324", "Georgiev", "Ivanov", new Guid("c276be95-401c-4b46-8021-b39f77591713") },
                    { new Guid("a08ef20c-fa01-4ddc-b66c-e2c0f27ca0a7"), 4, "Jivko", "1041124324", "Donev", "Vasilev", new Guid("37c23ecc-f2f2-48ce-bd37-3c80ac007712") },
                    { new Guid("d4e61fb0-9264-4528-81ff-757b8d1473f5"), 5, "Ruzha", "0852131993", "Veleva", "Todorova", new Guid("13e3fce3-c6f2-4f5e-8565-2a9a69a26b0c") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("4a852dba-f9da-4582-86c9-434cbbecdfdd"), "Stamen", "7211053143", "Peev", "Georgiev", null, 14, new Guid("d22878fb-eb2f-45b2-b46e-5f8ec5dec97e") },
                    { new Guid("53e5d108-80ce-4787-9918-05fa35e97718"), "Petar", "8210045421", "Chonev", "Mladenov", null, 5, new Guid("ff528a4a-0538-4fa0-b3ac-3c73f2e6f96c") },
                    { new Guid("7385dadb-87ab-4b8f-8a21-cf05d8c03824"), "Boncho", "8006210887", "Dimitrov", "Dimitrov", null, 9, new Guid("87bf4c23-062c-4c2a-8ad1-48f765c4e761") },
                    { new Guid("aa0ab228-f39a-4292-9f38-d4f5374ebf57"), "Stoyanka", "7105053113", "Peneva", "Doneva", null, 15, new Guid("f31e6ee2-4ea7-4a15-97b2-e50bcd612964") },
                    { new Guid("c8815eee-bcba-413b-b495-915281f30c43"), "Stefka", "9003021331", "Gineva", "Petkova", null, 4, new Guid("accec307-983c-488d-8a5d-2c66dbb356d8") },
                    { new Guid("e6132c62-1faf-48c3-b637-54bb5efe5cce"), "Maria", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("cbc2b206-561c-40eb-b2c7-295d2beea296") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("01877c5c-958f-4588-9796-c5afbccd8543"), new Guid("42b1fe04-7ce6-4256-83e8-f08dbacb3a4a") },
                    { new Guid("a68416ad-e044-4088-a03d-c2cf431a2e86"), new Guid("4d50b8fa-fb33-4f08-8b48-1d961f446d83") },
                    { new Guid("61a4d412-d278-4791-b18d-e45f551366dc"), new Guid("5cad4018-0fe3-4d3d-9712-9072c8ade2b7") },
                    { new Guid("a68416ad-e044-4088-a03d-c2cf431a2e86"), new Guid("6726d3b5-e980-4203-9eb9-edc9c4252e7d") },
                    { new Guid("a68416ad-e044-4088-a03d-c2cf431a2e86"), new Guid("6e469e61-f39b-4a1d-9952-84aa7edeedce") },
                    { new Guid("61a4d412-d278-4791-b18d-e45f551366dc"), new Guid("7ae0afea-5799-46d3-8f25-14a80933d224") },
                    { new Guid("61a4d412-d278-4791-b18d-e45f551366dc"), new Guid("89da9466-173b-416c-a2f1-f1d77ce02c09") },
                    { new Guid("61a4d412-d278-4791-b18d-e45f551366dc"), new Guid("8d772f07-5e71-4de2-982c-fc58f2316840") },
                    { new Guid("a68416ad-e044-4088-a03d-c2cf431a2e86"), new Guid("9eb1c4b5-95c8-4112-9f61-732fd34b43aa") },
                    { new Guid("61a4d412-d278-4791-b18d-e45f551366dc"), new Guid("bb2caabd-0fa8-4fcf-920b-d83aefbab958") },
                    { new Guid("a68416ad-e044-4088-a03d-c2cf431a2e86"), new Guid("c6ffa9cb-4c02-4fde-90e2-80bb539c597a") },
                    { new Guid("61a4d412-d278-4791-b18d-e45f551366dc"), new Guid("f304fb99-f3f3-44bf-ad0e-27305ed91e5e") },
                    { new Guid("a68416ad-e044-4088-a03d-c2cf431a2e86"), new Guid("fcc7587f-8d7c-44f6-ace6-4f9ccb23d363") }
                });

            migrationBuilder.InsertData(
                table: "TeachersClasses",
                columns: new[] { "ClassId", "TeacherId" },
                values: new object[,]
                {
                    { 1, new Guid("4a852dba-f9da-4582-86c9-434cbbecdfdd") },
                    { 2, new Guid("4a852dba-f9da-4582-86c9-434cbbecdfdd") },
                    { 3, new Guid("4a852dba-f9da-4582-86c9-434cbbecdfdd") },
                    { 4, new Guid("53e5d108-80ce-4787-9918-05fa35e97718") },
                    { 4, new Guid("7385dadb-87ab-4b8f-8a21-cf05d8c03824") },
                    { 5, new Guid("aa0ab228-f39a-4292-9f38-d4f5374ebf57") },
                    { 1, new Guid("c8815eee-bcba-413b-b495-915281f30c43") },
                    { 2, new Guid("c8815eee-bcba-413b-b495-915281f30c43") },
                    { 1, new Guid("e6132c62-1faf-48c3-b637-54bb5efe5cce") },
                    { 2, new Guid("e6132c62-1faf-48c3-b637-54bb5efe5cce") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("01877c5c-958f-4588-9796-c5afbccd8543"), new Guid("42b1fe04-7ce6-4256-83e8-f08dbacb3a4a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a68416ad-e044-4088-a03d-c2cf431a2e86"), new Guid("4d50b8fa-fb33-4f08-8b48-1d961f446d83") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("61a4d412-d278-4791-b18d-e45f551366dc"), new Guid("5cad4018-0fe3-4d3d-9712-9072c8ade2b7") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a68416ad-e044-4088-a03d-c2cf431a2e86"), new Guid("6726d3b5-e980-4203-9eb9-edc9c4252e7d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a68416ad-e044-4088-a03d-c2cf431a2e86"), new Guid("6e469e61-f39b-4a1d-9952-84aa7edeedce") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("61a4d412-d278-4791-b18d-e45f551366dc"), new Guid("7ae0afea-5799-46d3-8f25-14a80933d224") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("61a4d412-d278-4791-b18d-e45f551366dc"), new Guid("89da9466-173b-416c-a2f1-f1d77ce02c09") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("61a4d412-d278-4791-b18d-e45f551366dc"), new Guid("8d772f07-5e71-4de2-982c-fc58f2316840") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a68416ad-e044-4088-a03d-c2cf431a2e86"), new Guid("9eb1c4b5-95c8-4112-9f61-732fd34b43aa") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("61a4d412-d278-4791-b18d-e45f551366dc"), new Guid("bb2caabd-0fa8-4fcf-920b-d83aefbab958") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a68416ad-e044-4088-a03d-c2cf431a2e86"), new Guid("c6ffa9cb-4c02-4fde-90e2-80bb539c597a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("61a4d412-d278-4791-b18d-e45f551366dc"), new Guid("f304fb99-f3f3-44bf-ad0e-27305ed91e5e") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a68416ad-e044-4088-a03d-c2cf431a2e86"), new Guid("fcc7587f-8d7c-44f6-ace6-4f9ccb23d363") });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("1c68d182-bdd6-4f77-b014-123f2c3c6dba"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("339f87ba-c15d-40cc-929b-596d437b4f7f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("4aa6b93b-2733-43ba-9bf7-9ed44699a0b6"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("5a950535-fb80-4f84-a18b-c41137ffb459"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("6d826163-288d-4b57-89b9-396587228288"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("7ed094cc-7b9c-4066-b7b4-326c9d36fa43"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a08ef20c-fa01-4ddc-b66c-e2c0f27ca0a7"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d4e61fb0-9264-4528-81ff-757b8d1473f5"));

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("4a852dba-f9da-4582-86c9-434cbbecdfdd") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("4a852dba-f9da-4582-86c9-434cbbecdfdd") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 3, new Guid("4a852dba-f9da-4582-86c9-434cbbecdfdd") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 4, new Guid("53e5d108-80ce-4787-9918-05fa35e97718") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 4, new Guid("7385dadb-87ab-4b8f-8a21-cf05d8c03824") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 5, new Guid("aa0ab228-f39a-4292-9f38-d4f5374ebf57") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("c8815eee-bcba-413b-b495-915281f30c43") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("c8815eee-bcba-413b-b495-915281f30c43") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("e6132c62-1faf-48c3-b637-54bb5efe5cce") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("e6132c62-1faf-48c3-b637-54bb5efe5cce") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("01877c5c-958f-4588-9796-c5afbccd8543"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("61a4d412-d278-4791-b18d-e45f551366dc"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a68416ad-e044-4088-a03d-c2cf431a2e86"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("42b1fe04-7ce6-4256-83e8-f08dbacb3a4a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4d50b8fa-fb33-4f08-8b48-1d961f446d83"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5cad4018-0fe3-4d3d-9712-9072c8ade2b7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6726d3b5-e980-4203-9eb9-edc9c4252e7d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6e469e61-f39b-4a1d-9952-84aa7edeedce"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7ae0afea-5799-46d3-8f25-14a80933d224"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("89da9466-173b-416c-a2f1-f1d77ce02c09"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d772f07-5e71-4de2-982c-fc58f2316840"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9eb1c4b5-95c8-4112-9f61-732fd34b43aa"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bb2caabd-0fa8-4fcf-920b-d83aefbab958"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c6ffa9cb-4c02-4fde-90e2-80bb539c597a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f304fb99-f3f3-44bf-ad0e-27305ed91e5e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fcc7587f-8d7c-44f6-ace6-4f9ccb23d363"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("4a852dba-f9da-4582-86c9-434cbbecdfdd"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("53e5d108-80ce-4787-9918-05fa35e97718"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("7385dadb-87ab-4b8f-8a21-cf05d8c03824"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("aa0ab228-f39a-4292-9f38-d4f5374ebf57"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("c8815eee-bcba-413b-b495-915281f30c43"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("e6132c62-1faf-48c3-b637-54bb5efe5cce"));

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

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3,
                column: "Address",
                value: "Profesor Georgi Bradistilov 11, Sofia, Bulgaria");

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
    }
}
