using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixVerificationKeysInSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("3f3edb75-d559-46ca-928f-9f3f87f5c13e"), null, "Teacher", "TEACHER" },
                    { new Guid("4be99e1c-24c4-4dca-a247-26317c7313ce"), null, "Admin", "ADMIN" },
                    { new Guid("b4fe28f6-9778-4a94-bffc-dc6588ff646e"), null, "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AppId", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IdNumber", "IsAuthenticated", "IsGuest", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("18fe4605-776f-4e3b-a6ea-7de059667c60"), 0, new Guid("b7c9bcae-011b-4df9-851f-955a975f2dfe"), new DateTime(2024, 12, 10, 22, 39, 27, 337, DateTimeKind.Local).AddTicks(1080), "0a5baec9-cacb-4876-b104-97ce10e33bbc", "boncho@gmail.com", false, "Boncho", "8006210887", true, false, "Dimitrov", false, null, "Dimitrov", "BONCHO@GMAIL.COM", "BONCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEGtMnXblTFhvEOTcHuZDKW0TgFoJKiDP5CyFXeIZ4h5kqUMHH74fbaU693wCRXLkCg==", null, false, "5988b19b-e2fd-4ae5-8094-5a3f89cd21a6", false, "boncho@gmail.com", new Guid("97d2c953-f60a-450b-a54d-633a5c1da52a") },
                    { new Guid("37a2e56c-5e73-426c-b64c-67f3e1276a02"), 0, new Guid("cf46d531-b1cd-48a3-8b5a-164b407c63de"), new DateTime(2024, 12, 10, 22, 39, 27, 152, DateTimeKind.Local).AddTicks(500), "99af372a-561b-413b-9494-be42337633f4", "maria@gmail.com", false, "Maria", "8008089119", true, false, "Petrova", false, null, "Ivanova", "MARIA@GMAIL.COM", "MARIA@GMAIL.COM", "AQAAAAIAAYagAAAAENdTSuhn6+cwQF58OJOGrShKfTIfWouRh8J07pgGKuPloNW40V6JOzXvBaZ1Paccow==", null, false, "06f8b8fa-874d-469d-88b1-5ccfbc069ac6", false, "maria@gmail.com", new Guid("c1afe46f-52a8-4f81-9d58-9f5f559899f9") },
                    { new Guid("3d357581-f0af-43cf-b07d-10e633e47ae9"), 0, new Guid("3fd6b3d4-6bcf-4932-9e5a-4a607b3bfd0e"), new DateTime(2024, 12, 10, 22, 39, 27, 264, DateTimeKind.Local).AddTicks(2200), "2ca3da5f-3b03-4716-b6df-7cd2918dc237", "stoyanka@gmail.com", false, "Stoyanka", "7105053113", true, false, "Peneva", false, null, "Doneva", "STOYANKA@GMAIL.COM", "STOYANKA@GMAIL.COM", "AQAAAAIAAYagAAAAEI2jSoQyM0j/yQiPRdatf4gjp3XvMKCZ1Xh+oOaqzl/fCzhGW/RqgbMrDkni2qfkiA==", null, false, "96daf992-b632-422d-a2cd-54315c0106cc", false, "stoyanka@gmail.com", new Guid("7018ad18-f5d9-4f3e-a651-61a737b3871b") },
                    { new Guid("4841dee8-5528-4641-a29a-6639d65d70d8"), 0, new Guid("6c4e91aa-5027-4227-b186-5b8ffc1380e6"), new DateTime(2024, 12, 10, 22, 39, 27, 189, DateTimeKind.Local).AddTicks(6610), "e8982a14-850a-4ce5-ac44-183717434d1e", "stefka@gmail.com", false, "Stefka", "9003021331", true, false, "Gineva", false, null, "Petkova", "STEFKA@GMAIL.COM", "STEFKA@GMAIL.COM", "AQAAAAIAAYagAAAAEHaeruGyGkeZMZf7kxFkOgodsC3ir66lVpztm55RS76XZbOex/b4NiEWHmqjk9yAlA==", null, false, "7ad32f40-c1b3-47b2-b90f-230c15b24c4d", false, "stefka@gmail.com", new Guid("f56328bf-13ce-420e-a3e0-8265d184b03a") },
                    { new Guid("61344aa0-73cc-474e-b417-f0eb155d4e05"), 0, new Guid("22722b03-0902-40ac-8022-da0b3cd6d024"), new DateTime(2024, 12, 10, 22, 39, 27, 1, DateTimeKind.Local).AddTicks(6030), "4cf41f18-f73e-43e7-b5ca-6ef28588da08", "martin@gmail.com", false, "Martin", "0741124324", true, false, "Georgiev", false, null, "Ivanov", "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAIAAYagAAAAEDYoiV+25L4cJrU6AXJyE36B0BHu+bgp9WTGRj0QfogMK9PlN1afCEobp2TZ511UBw==", null, false, "ad158b58-e2e2-4fad-a8de-497074ffd701", false, "martin@gmail.com", new Guid("1834dbd2-af82-4cf7-a603-d29882311f37") },
                    { new Guid("66f892b6-6a11-4df1-bc4b-ff0014c62fb8"), 0, new Guid("34ce67ff-c98d-4a43-9eb6-345905242e97"), new DateTime(2024, 12, 10, 22, 39, 27, 227, DateTimeKind.Local).AddTicks(2120), "3ffaca7c-2642-4853-b97f-82f9e5fd2e93", "stamen@gmail.com", false, "Stamen", "7211053143", true, false, "Peev", false, null, "Georgiev", "STAMEN@GMAIL.COM", "STAMEN@GMAIL.COM", "AQAAAAIAAYagAAAAECAh+eJO5/+Dsp5fyqynVIFBQreMAZ4DKN7JOa/kLSMncd4NzumE/WYN+gK4v1mtsA==", null, false, "2d8ed79b-bda2-4d9f-8b29-14640b5d3dfa", false, "stamen@gmail.com", new Guid("ed893222-9a7a-4ee9-817b-875e52e6cfaf") },
                    { new Guid("6d8fb148-72df-484b-998d-68ea58112359"), 0, new Guid("6d8fb148-72df-484b-998d-68ea58112359"), new DateTime(2024, 12, 10, 22, 39, 27, 373, DateTimeKind.Local).AddTicks(9220), "78404a79-b181-4826-bebc-8889a33805e3", "admin@scholario.com", true, "Admin", "2452064114", true, false, "Adminov", false, null, "Adminov", "ADMIN@SCHOLARIO.COM", "ADMIN@SCHOLARIO.COM", "AQAAAAIAAYagAAAAEL3NNgRdDMA5jBL+Or0/Sp8MF3DTT6D49x3rvDULxanZPbrU43TgNMCYf5C/YCmA/g==", null, false, "de4c229d-78c3-4866-90c7-d7fe3494e38c", false, "admin@scholario.com", new Guid("6d8fb148-72df-484b-998d-68ea58112359") },
                    { new Guid("743896c4-dde4-4d4a-ae08-201448a0538a"), 0, new Guid("b4dd7b6a-53b8-4110-97b2-ee4af5bd9274"), new DateTime(2024, 12, 10, 22, 39, 27, 300, DateTimeKind.Local).AddTicks(2250), "63b40961-95ff-4ff5-9f82-621fbcfdc171", "petar@gmail.com", false, "Petar", "8210045421", true, false, "Chonev", false, null, "Mladenov", "PETAR@GMAIL.COM", "PETAR@GMAIL.COM", "AQAAAAIAAYagAAAAEOIKOSH+ZWbkQSdXAs0Xonk//EgtXoV+XvYBAzD97AHZ9wd3rLREEFv7nLi3CqVYcQ==", null, false, "3fab9b73-751c-4064-827a-1606bb4168e0", false, "petar@gmail.com", new Guid("2034c4b3-970a-4e84-b081-12f385d6d360") },
                    { new Guid("7457b466-60c2-4b9a-8422-b2b889bfea94"), 0, new Guid("af460353-e289-4f19-8bd8-78db1354131d"), new DateTime(2024, 12, 10, 22, 39, 27, 39, DateTimeKind.Local).AddTicks(730), "499211b1-0c5f-4526-a461-350d566f1f2e", "ginka@gmail.com", false, "Ginka", "0944174331", true, false, "Stoyanova", false, null, "Petrova", "GINKA@GMAIL.COM", "GINKA@GMAIL.COM", "AQAAAAIAAYagAAAAEKTCErAUqPw74JXrmFGklY/9SG5lmsmekZ3Yzq3oLS92J/Ulu6Q9wEpkXMm1PKMuCw==", null, false, "4ef0e5de-b862-496d-84b8-b332b5ac7135", false, "ginka@gmail.com", new Guid("c9b74718-3bda-413a-a9ab-2bb257856dac") },
                    { new Guid("7ca00505-f103-48e4-9d61-fb3263ba977a"), 0, new Guid("5100ccc0-51c3-41a4-9982-302564d8fa62"), new DateTime(2024, 12, 10, 22, 39, 27, 114, DateTimeKind.Local).AddTicks(4620), "f2a282a0-ad36-4bb4-9a5e-db79f39c25e0", "pencho@gmail.com", false, "Pencho", "0945161226", true, false, "Mihov", false, null, "Angelov", "PENCHO@GMAIL.COM", "PENCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEB2VPi09tJJ6ZXMQDYVleZiTnBJ64WtNe/rJLRXTXkaODvkJGtTT6uSl0Fb6wnlgUQ==", null, false, "6a4eacd6-4fb9-40fd-b2f5-10c0de0af5fa", false, "pencho@gmail.com", new Guid("91916cb7-92a1-4add-855c-b5c774da99a6") },
                    { new Guid("c76f8236-2060-4b87-898e-27d6b2da6d78"), 0, new Guid("7803d9e9-216f-49bd-806b-6bffd7a85488"), new DateTime(2024, 12, 10, 22, 39, 27, 76, DateTimeKind.Local).AddTicks(7840), "d073bb9a-ad3c-4dbf-94ec-c6d671828f48", "jivko@gmail.com", false, "Jivko", "1041124324", true, false, "Donev", false, null, "Vasilev", "JIVKO@GMAIL.COM", "JIVKO@GMAIL.COM", "AQAAAAIAAYagAAAAEKwUCOL6sJuutmoGkPSInKnH9MG0cNL5oHIw65zmSMnGTIH0QAtxkKPdtl7Rh4COxA==", null, false, "2ace4980-02c1-428e-87f5-ec84ba85eaa5", false, "jivko@gmail.com", new Guid("60d82043-eb9b-4664-bfc2-c130139f31b8") },
                    { new Guid("d4577c75-77f6-498e-8bf3-5e40fe7c0bce"), 0, new Guid("d753c019-419d-4fc9-bcd1-e81084d677c5"), new DateTime(2024, 12, 10, 22, 39, 26, 964, DateTimeKind.Local).AddTicks(5830), "083befcb-3db4-46f2-af4a-1a1abf14a600", "gencho@gmail.com", false, "Gencho", "0543121244", true, false, "Ginev", false, null, "Petkov", "GENCHO@GMAIL.COM", "GENCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEDn9Mw0A9IPBKcqUSgf14fShqUqZhN5SfMhxNcgjipzRTJg6HEzd0KUXraPViHKFcQ==", null, false, "3d33cfb3-82a8-4c54-a0bb-fda244fd57a9", false, "gencho@gmail.com", new Guid("f157ab19-869b-4031-b22d-b883edee4cd2") },
                    { new Guid("e25ed50c-f621-482b-8087-4e8ffefdc8bc"), 0, new Guid("45a0fc66-8c37-4b97-bd66-eed20cca76a9"), new DateTime(2024, 12, 10, 22, 39, 26, 927, DateTimeKind.Local).AddTicks(6740), "88b49e6b-b266-477b-81b7-a2ea82d5b70c", "ivan@gmail.com", false, "Ivan", "0141012442", true, false, "Ivanov", false, null, "Ivanov", "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAIAAYagAAAAEMX1z+p2FXngi6WiWlkOHSplB1gvAQqsqxsSunNnW62pzZCsIt+c+2xawa9ruLeFsA==", null, false, "48b08606-64cf-4200-9ebb-475d8ea0daf1", false, "ivan@gmail.com", new Guid("b6662178-53af-4450-8e6c-594d313bcae1") }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("22722b03-0902-40ac-8022-da0b3cd6d024"), 2, "Martin", "0741124324", "Georgiev", "Ivanov", new Guid("1834dbd2-af82-4cf7-a603-d29882311f37") },
                    { new Guid("39dad089-66b2-46c2-8369-9aa2226182d2"), 5, "Ruzha", "0852131993", "Veleva", "Todorova", new Guid("ea417ed3-1785-4ce7-ac09-dafd1e6f844e") },
                    { new Guid("45a0fc66-8c37-4b97-bd66-eed20cca76a9"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("b6662178-53af-4450-8e6c-594d313bcae1") },
                    { new Guid("5100ccc0-51c3-41a4-9982-302564d8fa62"), 5, "Pencho", "0945161226", "Mihov", "Angelov", new Guid("91916cb7-92a1-4add-855c-b5c774da99a6") },
                    { new Guid("7803d9e9-216f-49bd-806b-6bffd7a85488"), 4, "Jivko", "1041124324", "Donev", "Vasilev", new Guid("60d82043-eb9b-4664-bfc2-c130139f31b8") },
                    { new Guid("787d1a06-dbaf-4b5a-a8eb-773736c18d97"), 4, "Diana", "1148061932", "Kostova", "Nedeva", new Guid("7027c313-0dab-4ca8-b95f-aa795a1c8081") },
                    { new Guid("af460353-e289-4f19-8bd8-78db1354131d"), 3, "Ginka", "0944174331", "Stoyanova", "Petrova", new Guid("c9b74718-3bda-413a-a9ab-2bb257856dac") },
                    { new Guid("d753c019-419d-4fc9-bcd1-e81084d677c5"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("f157ab19-869b-4031-b22d-b883edee4cd2") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("34ce67ff-c98d-4a43-9eb6-345905242e97"), "Stamen", "7211053143", "Peev", "Georgiev", null, 14, new Guid("ed893222-9a7a-4ee9-817b-875e52e6cfaf") },
                    { new Guid("3fd6b3d4-6bcf-4932-9e5a-4a607b3bfd0e"), "Stoyanka", "7105053113", "Peneva", "Doneva", null, 15, new Guid("7018ad18-f5d9-4f3e-a651-61a737b3871b") },
                    { new Guid("6c4e91aa-5027-4227-b186-5b8ffc1380e6"), "Stefka", "9003021331", "Gineva", "Petkova", null, 4, new Guid("f56328bf-13ce-420e-a3e0-8265d184b03a") },
                    { new Guid("b4dd7b6a-53b8-4110-97b2-ee4af5bd9274"), "Petar", "8210045421", "Chonev", "Mladenov", null, 5, new Guid("2034c4b3-970a-4e84-b081-12f385d6d360") },
                    { new Guid("b7c9bcae-011b-4df9-851f-955a975f2dfe"), "Boncho", "8006210887", "Dimitrov", "Dimitrov", null, 9, new Guid("97d2c953-f60a-450b-a54d-633a5c1da52a") },
                    { new Guid("cf46d531-b1cd-48a3-8b5a-164b407c63de"), "Maria", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("c1afe46f-52a8-4f81-9d58-9f5f559899f9") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("3f3edb75-d559-46ca-928f-9f3f87f5c13e"), new Guid("18fe4605-776f-4e3b-a6ea-7de059667c60") },
                    { new Guid("3f3edb75-d559-46ca-928f-9f3f87f5c13e"), new Guid("37a2e56c-5e73-426c-b64c-67f3e1276a02") },
                    { new Guid("3f3edb75-d559-46ca-928f-9f3f87f5c13e"), new Guid("3d357581-f0af-43cf-b07d-10e633e47ae9") },
                    { new Guid("3f3edb75-d559-46ca-928f-9f3f87f5c13e"), new Guid("4841dee8-5528-4641-a29a-6639d65d70d8") },
                    { new Guid("b4fe28f6-9778-4a94-bffc-dc6588ff646e"), new Guid("61344aa0-73cc-474e-b417-f0eb155d4e05") },
                    { new Guid("3f3edb75-d559-46ca-928f-9f3f87f5c13e"), new Guid("66f892b6-6a11-4df1-bc4b-ff0014c62fb8") },
                    { new Guid("4be99e1c-24c4-4dca-a247-26317c7313ce"), new Guid("6d8fb148-72df-484b-998d-68ea58112359") },
                    { new Guid("3f3edb75-d559-46ca-928f-9f3f87f5c13e"), new Guid("743896c4-dde4-4d4a-ae08-201448a0538a") },
                    { new Guid("b4fe28f6-9778-4a94-bffc-dc6588ff646e"), new Guid("7457b466-60c2-4b9a-8422-b2b889bfea94") },
                    { new Guid("b4fe28f6-9778-4a94-bffc-dc6588ff646e"), new Guid("7ca00505-f103-48e4-9d61-fb3263ba977a") },
                    { new Guid("b4fe28f6-9778-4a94-bffc-dc6588ff646e"), new Guid("c76f8236-2060-4b87-898e-27d6b2da6d78") },
                    { new Guid("b4fe28f6-9778-4a94-bffc-dc6588ff646e"), new Guid("d4577c75-77f6-498e-8bf3-5e40fe7c0bce") },
                    { new Guid("b4fe28f6-9778-4a94-bffc-dc6588ff646e"), new Guid("e25ed50c-f621-482b-8087-4e8ffefdc8bc") }
                });

            migrationBuilder.InsertData(
                table: "TeachersClasses",
                columns: new[] { "ClassId", "TeacherId" },
                values: new object[,]
                {
                    { 1, new Guid("34ce67ff-c98d-4a43-9eb6-345905242e97") },
                    { 2, new Guid("34ce67ff-c98d-4a43-9eb6-345905242e97") },
                    { 3, new Guid("34ce67ff-c98d-4a43-9eb6-345905242e97") },
                    { 5, new Guid("3fd6b3d4-6bcf-4932-9e5a-4a607b3bfd0e") },
                    { 1, new Guid("6c4e91aa-5027-4227-b186-5b8ffc1380e6") },
                    { 2, new Guid("6c4e91aa-5027-4227-b186-5b8ffc1380e6") },
                    { 4, new Guid("b4dd7b6a-53b8-4110-97b2-ee4af5bd9274") },
                    { 4, new Guid("b7c9bcae-011b-4df9-851f-955a975f2dfe") },
                    { 1, new Guid("cf46d531-b1cd-48a3-8b5a-164b407c63de") },
                    { 2, new Guid("cf46d531-b1cd-48a3-8b5a-164b407c63de") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3f3edb75-d559-46ca-928f-9f3f87f5c13e"), new Guid("18fe4605-776f-4e3b-a6ea-7de059667c60") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3f3edb75-d559-46ca-928f-9f3f87f5c13e"), new Guid("37a2e56c-5e73-426c-b64c-67f3e1276a02") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3f3edb75-d559-46ca-928f-9f3f87f5c13e"), new Guid("3d357581-f0af-43cf-b07d-10e633e47ae9") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3f3edb75-d559-46ca-928f-9f3f87f5c13e"), new Guid("4841dee8-5528-4641-a29a-6639d65d70d8") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4fe28f6-9778-4a94-bffc-dc6588ff646e"), new Guid("61344aa0-73cc-474e-b417-f0eb155d4e05") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3f3edb75-d559-46ca-928f-9f3f87f5c13e"), new Guid("66f892b6-6a11-4df1-bc4b-ff0014c62fb8") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("4be99e1c-24c4-4dca-a247-26317c7313ce"), new Guid("6d8fb148-72df-484b-998d-68ea58112359") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3f3edb75-d559-46ca-928f-9f3f87f5c13e"), new Guid("743896c4-dde4-4d4a-ae08-201448a0538a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4fe28f6-9778-4a94-bffc-dc6588ff646e"), new Guid("7457b466-60c2-4b9a-8422-b2b889bfea94") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4fe28f6-9778-4a94-bffc-dc6588ff646e"), new Guid("7ca00505-f103-48e4-9d61-fb3263ba977a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4fe28f6-9778-4a94-bffc-dc6588ff646e"), new Guid("c76f8236-2060-4b87-898e-27d6b2da6d78") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4fe28f6-9778-4a94-bffc-dc6588ff646e"), new Guid("d4577c75-77f6-498e-8bf3-5e40fe7c0bce") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b4fe28f6-9778-4a94-bffc-dc6588ff646e"), new Guid("e25ed50c-f621-482b-8087-4e8ffefdc8bc") });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("22722b03-0902-40ac-8022-da0b3cd6d024"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("39dad089-66b2-46c2-8369-9aa2226182d2"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("45a0fc66-8c37-4b97-bd66-eed20cca76a9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("5100ccc0-51c3-41a4-9982-302564d8fa62"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("7803d9e9-216f-49bd-806b-6bffd7a85488"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("787d1a06-dbaf-4b5a-a8eb-773736c18d97"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("af460353-e289-4f19-8bd8-78db1354131d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d753c019-419d-4fc9-bcd1-e81084d677c5"));

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("34ce67ff-c98d-4a43-9eb6-345905242e97") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("34ce67ff-c98d-4a43-9eb6-345905242e97") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 3, new Guid("34ce67ff-c98d-4a43-9eb6-345905242e97") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 5, new Guid("3fd6b3d4-6bcf-4932-9e5a-4a607b3bfd0e") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("6c4e91aa-5027-4227-b186-5b8ffc1380e6") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("6c4e91aa-5027-4227-b186-5b8ffc1380e6") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 4, new Guid("b4dd7b6a-53b8-4110-97b2-ee4af5bd9274") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 4, new Guid("b7c9bcae-011b-4df9-851f-955a975f2dfe") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("cf46d531-b1cd-48a3-8b5a-164b407c63de") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("cf46d531-b1cd-48a3-8b5a-164b407c63de") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3f3edb75-d559-46ca-928f-9f3f87f5c13e"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4be99e1c-24c4-4dca-a247-26317c7313ce"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b4fe28f6-9778-4a94-bffc-dc6588ff646e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("18fe4605-776f-4e3b-a6ea-7de059667c60"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("37a2e56c-5e73-426c-b64c-67f3e1276a02"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3d357581-f0af-43cf-b07d-10e633e47ae9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4841dee8-5528-4641-a29a-6639d65d70d8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("61344aa0-73cc-474e-b417-f0eb155d4e05"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("66f892b6-6a11-4df1-bc4b-ff0014c62fb8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6d8fb148-72df-484b-998d-68ea58112359"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("743896c4-dde4-4d4a-ae08-201448a0538a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7457b466-60c2-4b9a-8422-b2b889bfea94"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7ca00505-f103-48e4-9d61-fb3263ba977a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c76f8236-2060-4b87-898e-27d6b2da6d78"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d4577c75-77f6-498e-8bf3-5e40fe7c0bce"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e25ed50c-f621-482b-8087-4e8ffefdc8bc"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("34ce67ff-c98d-4a43-9eb6-345905242e97"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("3fd6b3d4-6bcf-4932-9e5a-4a607b3bfd0e"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("6c4e91aa-5027-4227-b186-5b8ffc1380e6"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("b4dd7b6a-53b8-4110-97b2-ee4af5bd9274"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("b7c9bcae-011b-4df9-851f-955a975f2dfe"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("cf46d531-b1cd-48a3-8b5a-164b407c63de"));

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
    }
}
