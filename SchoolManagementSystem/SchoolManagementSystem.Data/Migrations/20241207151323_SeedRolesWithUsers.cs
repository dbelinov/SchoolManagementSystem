using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedRolesWithUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("991ea3d6-ee90-4551-9c93-46112de0eedd"), new Guid("dd5d50aa-1b98-4870-9cfd-df75aa95eb3c") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("071a13e3-1ebc-4e2b-82b7-8209f1a3c1e5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0abe70ea-37e9-4ec2-8a41-4ab229f34891"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1a1ce766-d88b-414c-b54d-514a4bd54c78"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1c5b5cec-2f76-4acc-9e48-eb19f6f9c694"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4056e5c3-3b39-4022-aa73-c54368b058a2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("501b44fd-28e0-445e-81f8-eae5b476cb0a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6d4d93f9-a711-413c-ba1c-d1deda288f67"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9112dc7d-822b-4154-90dd-faca2a02b9cd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9ab5b134-9165-4ffe-b670-94bd5852c570"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f63525e-87f8-423f-bb02-a06417707df5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d2e2c0bb-89bf-4c9f-af48-6d7268e51053"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d2fe3c6c-1189-4d0a-bd47-afbaea522d6c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("188f88ee-12d9-43d0-b2bc-f422a49cde1a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("434e89a7-dcda-4ef6-896e-0372fca7835d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("8a91c5a8-309b-478e-a370-4608c366cb2c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a338de6d-37c9-4b40-b13c-fedca04462cf"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c7ec06ed-89f9-4191-9590-24a2a68e5ebc"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c8ed5d20-3847-478b-ab06-1f28269d514f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e4e6a4e1-444d-4790-8479-343f3b14ca4c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ffc119f1-a425-48de-9bcd-f3b60464c62a"));

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 5, new Guid("123016d0-68a8-423d-ab21-7e4a409e09e4") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("1d34ba44-d040-4858-8ffa-810adb9f9216") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("1d34ba44-d040-4858-8ffa-810adb9f9216") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 4, new Guid("29ea9ef6-96e8-400b-9692-c7c4de338948") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("71c2c9c9-8697-4f23-a60d-ad9acc13d164") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("71c2c9c9-8697-4f23-a60d-ad9acc13d164") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 3, new Guid("71c2c9c9-8697-4f23-a60d-ad9acc13d164") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("73a7619e-ea92-4819-bf14-8a22aaed0922") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("73a7619e-ea92-4819-bf14-8a22aaed0922") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 4, new Guid("8ac1788d-87dd-4973-9fb5-e31b1d5a445c") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("991ea3d6-ee90-4551-9c93-46112de0eedd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dd5d50aa-1b98-4870-9cfd-df75aa95eb3c"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("123016d0-68a8-423d-ab21-7e4a409e09e4"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("1d34ba44-d040-4858-8ffa-810adb9f9216"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("29ea9ef6-96e8-400b-9692-c7c4de338948"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("71c2c9c9-8697-4f23-a60d-ad9acc13d164"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("73a7619e-ea92-4819-bf14-8a22aaed0922"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("8ac1788d-87dd-4973-9fb5-e31b1d5a445c"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("991ea3d6-ee90-4551-9c93-46112de0eedd"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AppId", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IdNumber", "IsAuthenticated", "IsGuest", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("071a13e3-1ebc-4e2b-82b7-8209f1a3c1e5"), 0, new Guid("ffc119f1-a425-48de-9bcd-f3b60464c62a"), new DateTime(2024, 12, 7, 16, 58, 26, 356, DateTimeKind.Local).AddTicks(9050), "bbff6119-1f75-4551-949f-828439f578b5", "pencho@gmail.com", false, "Pencho", "0945161226", true, false, "Mihov", false, null, "Angelov", "PENCHO@GMAIL.COM", "PENCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEKfgPBi2KmlHHqJnOzBuRMwF3Y3lORqWaymYz2FTIsb32sxw4K5LFjwASHDuQJh08Q==", null, false, "46a60cf4-a1c1-4c9d-be40-8e81a6743b56", false, "pencho@gmail.com", new Guid("5f8a4f7d-0352-4af5-9bc8-264ed181be8e") },
                    { new Guid("0abe70ea-37e9-4ec2-8a41-4ab229f34891"), 0, new Guid("71c2c9c9-8697-4f23-a60d-ad9acc13d164"), new DateTime(2024, 12, 7, 16, 58, 26, 466, DateTimeKind.Local).AddTicks(8280), "dd546014-4a5f-4064-a95c-2ce812c1e151", "stamen@gmail.com", false, "Stamen", "7211053143", true, false, "Peev", false, null, "Georgiev", "STAMEN@GMAIL.COM", "STAMEN@GMAIL.COM", "AQAAAAIAAYagAAAAELME7+2MfJlB722dmNrjyjwk0bE2U1miqFRiPTNkUEeEsEO9E2+kKAgjuKTGvClyuA==", null, false, "fbdc8fe6-86b2-468f-b3fa-5a3d2841aebc", false, "stamen@gmail.com", new Guid("ad312d48-b905-4803-9aa8-cd3472a32358") },
                    { new Guid("1a1ce766-d88b-414c-b54d-514a4bd54c78"), 0, new Guid("188f88ee-12d9-43d0-b2bc-f422a49cde1a"), new DateTime(2024, 12, 7, 16, 58, 26, 176, DateTimeKind.Local).AddTicks(320), "dfb12add-abc5-4683-9611-46ca4e0899cd", "ivan@gmail.com", false, "Ivan", "0141012442", true, false, "Ivanov", false, null, "Ivanov", "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAIAAYagAAAAEBZs8+uhAtTc04PITpJFsGr7zjpRyFTCF0qUyBjPFccETEkin2hYgqxzCfk7lrze0g==", null, false, "032399c6-9960-4ad0-87ad-22ba7a636af2", false, "ivan@gmail.com", new Guid("932ab840-4834-4905-827b-52ad3d1ec39c") },
                    { new Guid("1c5b5cec-2f76-4acc-9e48-eb19f6f9c694"), 0, new Guid("1d34ba44-d040-4858-8ffa-810adb9f9216"), new DateTime(2024, 12, 7, 16, 58, 26, 393, DateTimeKind.Local).AddTicks(3930), "d7dcb21e-d32c-49b2-b6ce-c5e301e6ee04", "maria@gmail.com", false, "Maria", "8008089119", true, false, "Petrova", false, null, "Ivanova", "MARIA@GMAIL.COM", "MARIA@GMAIL.COM", "AQAAAAIAAYagAAAAEKr8wjUq0mXDTLKVaghB7pxf5p/JUi4RxlfdI6RKNanMO1ax+X2py3PCGHToadXOhQ==", null, false, "8d24815a-f0e5-481f-b30a-8328bcc40706", false, "maria@gmail.com", new Guid("9521f9a2-0083-4cd0-9521-dfb3afb53ff5") },
                    { new Guid("4056e5c3-3b39-4022-aa73-c54368b058a2"), 0, new Guid("8ac1788d-87dd-4973-9fb5-e31b1d5a445c"), new DateTime(2024, 12, 7, 16, 58, 26, 539, DateTimeKind.Local).AddTicks(1130), "b8d14841-ce68-4cb4-a32d-90537182e75f", "petar@gmail.com", false, "Petar", "8210045421", true, false, "Chonev", false, null, "Mladenov", "PETAR@GMAIL.COM", "PETAR@GMAIL.COM", "AQAAAAIAAYagAAAAEI9g9uIdqIzcQfOkZUE8yJ90Ec7XpAWUUGiviYZ1bbBNS3mtFEhUP/SxBnMTR5l0vA==", null, false, "1e434692-a245-44dd-8dfc-6b12eeff31e5", false, "petar@gmail.com", new Guid("699db466-82ed-4509-bb76-bb8d90205af7") },
                    { new Guid("501b44fd-28e0-445e-81f8-eae5b476cb0a"), 0, new Guid("29ea9ef6-96e8-400b-9692-c7c4de338948"), new DateTime(2024, 12, 7, 16, 58, 26, 575, DateTimeKind.Local).AddTicks(2260), "9bcaf09b-c414-4f99-b53d-cafc69a47b2d", "boncho@gmail.com", false, "Boncho", "8006210887", true, false, "Dimitrov", false, null, "Dimitrov", "BONCHO@GMAIL.COM", "BONCHO@GMAIL.COM", "AQAAAAIAAYagAAAAECkMEEjYrMzAtrH/SXsWiXWrJsMhapnWhNef5qtyX/fhK3CGgT5qIoIuVfHvcqkQ2w==", null, false, "fae0b8b1-b4ec-4395-96df-9b16af716458", false, "boncho@gmail.com", new Guid("963e05ac-65cc-440f-b618-e88e0cf49003") },
                    { new Guid("6d4d93f9-a711-413c-ba1c-d1deda288f67"), 0, new Guid("a338de6d-37c9-4b40-b13c-fedca04462cf"), new DateTime(2024, 12, 7, 16, 58, 26, 211, DateTimeKind.Local).AddTicks(6580), "dee33d66-e0ed-41ed-ba69-8c501e3b3e15", "gencho@gmail.com", false, "Gencho", "0543121244", true, false, "Ginev", false, null, "Petkov", "GENCHO@GMAIL.COM", "GENCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEDN7tCjlpVOLLPaDhFU8AxtAvSl1gsd7WsT4pkBvQiCdfo9V1uPIoCbUhpmIhqIzmw==", null, false, "0602d0a7-7694-4ec1-b28d-22d951220033", false, "gencho@gmail.com", new Guid("9955b4b9-464f-4c79-a65c-0613e5ee2282") },
                    { new Guid("9112dc7d-822b-4154-90dd-faca2a02b9cd"), 0, new Guid("e4e6a4e1-444d-4790-8479-343f3b14ca4c"), new DateTime(2024, 12, 7, 16, 58, 26, 284, DateTimeKind.Local).AddTicks(2570), "090f68df-4edf-45b5-8d64-868b0bea34ff", "ginka@gmail.com", false, "Ginka", "0944174331", true, false, "Stoyanova", false, null, "Petrova", "GINKA@GMAIL.COM", "GINKA@GMAIL.COM", "AQAAAAIAAYagAAAAEO61JNrjz31blxVoSmOfhrtsB51qy7qNkFn11RPUBEbjGYTa3lahqzwNRVGgqJmixg==", null, false, "66604c5b-dc18-4c0e-9caf-4f6c58923506", false, "ginka@gmail.com", new Guid("e832794b-6459-4e45-aebe-269d71a63476") },
                    { new Guid("9ab5b134-9165-4ffe-b670-94bd5852c570"), 0, new Guid("8a91c5a8-309b-478e-a370-4608c366cb2c"), new DateTime(2024, 12, 7, 16, 58, 26, 247, DateTimeKind.Local).AddTicks(7940), "5599428d-7732-4ce5-b671-8a61d5ec477b", "martin@gmail.com", false, "Martin", "0741124324", true, false, "Georgiev", false, null, "Ivanov", "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAIAAYagAAAAEPKhtUoZmgDFIKHNEvEs7Abik9Rw3WkT3tRXj4BJpbzNr8XF4tt+htee3BZY8gxegQ==", null, false, "f1d7f1e6-14bf-4357-99e2-4be2495db395", false, "martin@gmail.com", new Guid("8e276b30-bc8f-4660-a8ce-5a5f2980b6a1") },
                    { new Guid("9f63525e-87f8-423f-bb02-a06417707df5"), 0, new Guid("73a7619e-ea92-4819-bf14-8a22aaed0922"), new DateTime(2024, 12, 7, 16, 58, 26, 429, DateTimeKind.Local).AddTicks(9930), "363c92af-43da-4346-ab93-3ec384e21eaf", "stefka@gmail.com", false, "Stefka", "9003021331", true, false, "Gineva", false, null, "Petkova", "STEFKA@GMAIL.COM", "STEFKA@GMAIL.COM", "AQAAAAIAAYagAAAAEJe/ihCbXGpPyBi0R3D5mwOUSqk3UivIaBGhjbNlXVS5uveI5jyOHfxOllc8iJ+2Ew==", null, false, "6c07821e-6c03-4b2d-a078-b4ef2e69d18b", false, "stefka@gmail.com", new Guid("cb417fd2-3d90-4e15-acd5-9a01ab65a127") },
                    { new Guid("d2e2c0bb-89bf-4c9f-af48-6d7268e51053"), 0, new Guid("123016d0-68a8-423d-ab21-7e4a409e09e4"), new DateTime(2024, 12, 7, 16, 58, 26, 503, DateTimeKind.Local).AddTicks(1320), "860538c2-3ec4-491f-a58f-1a5543743bd5", "stoyanka@gmail.com", false, "Stoyanka", "7105053113", true, false, "Peneva", false, null, "Doneva", "STOYANKA@GMAIL.COM", "STOYANKA@GMAIL.COM", "AQAAAAIAAYagAAAAEGupXYfXGWO6/d2a4/OT3XovKrvRejIse3rElI0Y2NFQR3dUhZ5mvR9jFNFtsSd75A==", null, false, "a4b7ce39-0558-41c5-bb98-58034f56bd87", false, "stoyanka@gmail.com", new Guid("3298766c-258a-4033-85fb-3ff8beb77922") },
                    { new Guid("d2fe3c6c-1189-4d0a-bd47-afbaea522d6c"), 0, new Guid("c8ed5d20-3847-478b-ab06-1f28269d514f"), new DateTime(2024, 12, 7, 16, 58, 26, 320, DateTimeKind.Local).AddTicks(7630), "0c801cb8-5a11-443f-9832-e9f6a42cebfb", "jivko@gmail.com", false, "Jivko", "1041124324", true, false, "Donev", false, null, "Vasilev", "JIVKO@GMAIL.COM", "JIVKO@GMAIL.COM", "AQAAAAIAAYagAAAAENOthru5M1rMrrNqXJC00FxVMhsgtTJtsPT9G/zOugSW+zl7y3DBZHDk1hH6adnH/g==", null, false, "150f592a-e24e-457f-bd87-6434d600ba82", false, "jivko@gmail.com", new Guid("e76b76fb-9068-47f8-bf94-508e25b99467") },
                    { new Guid("dd5d50aa-1b98-4870-9cfd-df75aa95eb3c"), 0, new Guid("dd5d50aa-1b98-4870-9cfd-df75aa95eb3c"), new DateTime(2024, 12, 7, 16, 58, 26, 611, DateTimeKind.Local).AddTicks(8070), "dc2ba61b-7852-4b49-a9d8-40460c69a313", "admin@scholario.com", true, "Admin", "2452064114", true, false, "Adminov", false, null, "Adminov", "ADMIN@SCHOLARIO.COM", "ADMIN@SCHOLARIO.COM", "AQAAAAIAAYagAAAAEKGXccq6wG8wSVpvVXhT7ic665+n8FybJl1DGc3GYW5drzOYLecfJtWKE8aXUNb8Ag==", null, false, "a230b2c1-3b49-431a-9a0e-1f3e45e780fa", false, "admin@scholario.com", new Guid("dd5d50aa-1b98-4870-9cfd-df75aa95eb3c") }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("188f88ee-12d9-43d0-b2bc-f422a49cde1a"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("dca5ebe0-634a-47cc-8944-8e22dd14e0ca") },
                    { new Guid("434e89a7-dcda-4ef6-896e-0372fca7835d"), 4, "Diana", "1148061932", "Kostova", "Nedeva", new Guid("824bf988-99be-45ac-beea-538ac2552782") },
                    { new Guid("8a91c5a8-309b-478e-a370-4608c366cb2c"), 2, "Martin", "0741124324", "Georgiev", "Ivanov", new Guid("b2a40267-3dee-4f05-8158-5a5797123acd") },
                    { new Guid("a338de6d-37c9-4b40-b13c-fedca04462cf"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("d240ac81-fa64-4ba5-bc94-5e04bb14078c") },
                    { new Guid("c7ec06ed-89f9-4191-9590-24a2a68e5ebc"), 5, "Ruzha", "0852131993", "Veleva", "Todorova", new Guid("9a9fc085-7b7a-4c79-b8d5-83057200e655") },
                    { new Guid("c8ed5d20-3847-478b-ab06-1f28269d514f"), 4, "Jivko", "1041124324", "Donev", "Vasilev", new Guid("a446a70b-1846-480c-8f76-14179a361a14") },
                    { new Guid("e4e6a4e1-444d-4790-8479-343f3b14ca4c"), 3, "Ginka", "0944174331", "Stoyanova", "Petrova", new Guid("07ffb7bb-8736-44bb-b497-3b1d542f32d7") },
                    { new Guid("ffc119f1-a425-48de-9bcd-f3b60464c62a"), 5, "Pencho", "0945161226", "Mihov", "Angelov", new Guid("8cf9a3fd-eeee-45a2-9925-6337f43296c0") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("123016d0-68a8-423d-ab21-7e4a409e09e4"), "Stoyanka", "7105053113", "Peneva", "Doneva", null, 15, new Guid("d82a634c-bd48-4e62-9736-7623a782f3cc") },
                    { new Guid("1d34ba44-d040-4858-8ffa-810adb9f9216"), "Maria", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("e8583398-d058-448d-ba06-8f1b55bf5579") },
                    { new Guid("29ea9ef6-96e8-400b-9692-c7c4de338948"), "Boncho", "8006210887", "Dimitrov", "Dimitrov", null, 9, new Guid("bee5240d-340a-406a-9311-f82c00f35b4b") },
                    { new Guid("71c2c9c9-8697-4f23-a60d-ad9acc13d164"), "Stamen", "7211053143", "Peev", "Georgiev", null, 14, new Guid("6e28a796-c052-4816-878d-08964f3f731d") },
                    { new Guid("73a7619e-ea92-4819-bf14-8a22aaed0922"), "Stefka", "9003021331", "Gineva", "Petkova", null, 4, new Guid("e818b5ca-1cef-4901-92c6-8acfa6b4afaf") },
                    { new Guid("8ac1788d-87dd-4973-9fb5-e31b1d5a445c"), "Petar", "8210045421", "Chonev", "Mladenov", null, 5, new Guid("b3427656-e849-4cd1-a555-62a45e03af16") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("991ea3d6-ee90-4551-9c93-46112de0eedd"), new Guid("dd5d50aa-1b98-4870-9cfd-df75aa95eb3c") });

            migrationBuilder.InsertData(
                table: "TeachersClasses",
                columns: new[] { "ClassId", "TeacherId" },
                values: new object[,]
                {
                    { 5, new Guid("123016d0-68a8-423d-ab21-7e4a409e09e4") },
                    { 1, new Guid("1d34ba44-d040-4858-8ffa-810adb9f9216") },
                    { 2, new Guid("1d34ba44-d040-4858-8ffa-810adb9f9216") },
                    { 4, new Guid("29ea9ef6-96e8-400b-9692-c7c4de338948") },
                    { 1, new Guid("71c2c9c9-8697-4f23-a60d-ad9acc13d164") },
                    { 2, new Guid("71c2c9c9-8697-4f23-a60d-ad9acc13d164") },
                    { 3, new Guid("71c2c9c9-8697-4f23-a60d-ad9acc13d164") },
                    { 1, new Guid("73a7619e-ea92-4819-bf14-8a22aaed0922") },
                    { 2, new Guid("73a7619e-ea92-4819-bf14-8a22aaed0922") },
                    { 4, new Guid("8ac1788d-87dd-4973-9fb5-e31b1d5a445c") }
                });
        }
    }
}
