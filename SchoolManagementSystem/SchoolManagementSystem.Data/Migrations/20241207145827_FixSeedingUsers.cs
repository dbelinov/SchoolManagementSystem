using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedingUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5d9e6766-1f6b-48f1-b848-3569328d80ee"), new Guid("27d93207-c6d6-4bb2-aca1-ac064ea06f2c") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("072d2743-57c8-410e-bbf3-edbf5d9ecbe9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("08fae2a9-57c6-447a-a04f-d961c138061e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2f7967ad-d1a5-4768-ac07-f2d04b7861bf"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30783f80-4041-4984-bd45-a8dd80cf1476"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aba1af4-fbf7-41a5-9391-668237458048"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4fe2a962-c824-4e7e-9461-f21e898f5725"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("50b39f98-2752-4089-b256-1fd1281b956d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("63d4f8d6-a89d-43fd-bc42-2a88f7e6501f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6854ffa6-4097-47bc-b39e-be7eb91a6193"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("71f4a881-83f8-4215-adb6-98452c16cb2f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a8fb444c-47f8-487a-b8fd-e3b31405059c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("aa4ffa41-7f19-43ca-b81c-50c8c517ced3"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2d6b128d-0749-48da-a276-9cccb5193031"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("55d211c2-502d-46b9-a352-ca93fcde88f6"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("60a32be9-80db-43d6-86d8-fba9026c5b97"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("cfb7c730-7cb9-4747-9002-5340b87f86ea"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d369644f-eb36-42a4-b40d-520573b1b1c5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d6e415c2-db6f-4180-b46d-8a18619206d5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("f25aba94-a3d8-4c9a-8b43-301aaa949623"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fe82a978-3e8d-4245-a359-cdec8d8fb34a"));

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("3546d44c-5140-420a-81f3-3cd83efa94b8") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("3546d44c-5140-420a-81f3-3cd83efa94b8") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 3, new Guid("3546d44c-5140-420a-81f3-3cd83efa94b8") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 5, new Guid("4a4ff2b0-0979-4426-b2fe-f9d6416a205c") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("bc996b87-8b2e-488f-ac8c-dcd5426c6bcb") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("bc996b87-8b2e-488f-ac8c-dcd5426c6bcb") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("c4cf841d-7cc5-488e-981b-4f013609511d") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("c4cf841d-7cc5-488e-981b-4f013609511d") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 4, new Guid("cc3941c3-6583-407e-a187-dfa606a3cb54") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 4, new Guid("f7f20e9d-22a6-4da7-837b-55fcd3b041bb") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d9e6766-1f6b-48f1-b848-3569328d80ee"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("27d93207-c6d6-4bb2-aca1-ac064ea06f2c"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("3546d44c-5140-420a-81f3-3cd83efa94b8"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("4a4ff2b0-0979-4426-b2fe-f9d6416a205c"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("bc996b87-8b2e-488f-ac8c-dcd5426c6bcb"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("c4cf841d-7cc5-488e-981b-4f013609511d"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("cc3941c3-6583-407e-a187-dfa606a3cb54"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("f7f20e9d-22a6-4da7-837b-55fcd3b041bb"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("5d9e6766-1f6b-48f1-b848-3569328d80ee"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AppId", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IdNumber", "IsAuthenticated", "IsGuest", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("072d2743-57c8-410e-bbf3-edbf5d9ecbe9"), 0, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2024, 12, 7, 16, 50, 51, 142, DateTimeKind.Local).AddTicks(7220), "3c5b80d7-805a-4339-a5db-b2b5fbbcfa4f", "boncho@gmail.com", false, "Boncho", "8006210887", true, false, "Dimitrov", false, null, "Dimitrov", "BONCHO@GMAIL.COM", "BONCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEGeSMsCiGBDwj1y+A+bXxNtIUPeSe3AIo8mIes3g6g894d8r+0SH/Xhm+xZV08tL3Q==", null, false, "7124d01c-cc35-4baf-af88-2eb2e5b35786", false, "boncho@gmail.com", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("08fae2a9-57c6-447a-a04f-d961c138061e"), 0, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2024, 12, 7, 16, 50, 50, 924, DateTimeKind.Local).AddTicks(7690), "2a99e63b-6299-4d9c-99fe-d05b288a374e", "pencho@gmail.com", false, "Pencho", "0945161226", true, false, "Mihov", false, null, "Angelov", "PENCHO@GMAIL.COM", "PENCHO@GMAIL.COM", "AQAAAAIAAYagAAAAENDfMRJ2fMZZA6k5JKnHJt4bXBW1gpCFlj3xJBbgpz8Ufyvk5/bxZHWrlLzyXQwk/w==", null, false, "932a5260-9317-41bb-8d12-78eec9c105d4", false, "pencho@gmail.com", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("27d93207-c6d6-4bb2-aca1-ac064ea06f2c"), 0, new Guid("27d93207-c6d6-4bb2-aca1-ac064ea06f2c"), new DateTime(2024, 12, 7, 16, 50, 51, 179, DateTimeKind.Local).AddTicks(8730), "cac8c44c-a2dd-45fe-a667-5d9bbd8ade67", "admin@scholario.com", true, "Admin", "2452064114", true, false, "Adminov", false, null, "Adminov", "ADMIN@SCHOLARIO.COM", "ADMIN@SCHOLARIO.COM", "AQAAAAIAAYagAAAAEELPbLoUPG6y3jTdMhhGN9zrJjw0UfgllyFMDQOhM3MPgAszsZjZssvI2W87kVoUug==", null, false, "f4c40ccc-e397-4aa4-810a-9ace78482295", false, "admin@scholario.com", new Guid("27d93207-c6d6-4bb2-aca1-ac064ea06f2c") },
                    { new Guid("2f7967ad-d1a5-4768-ac07-f2d04b7861bf"), 0, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2024, 12, 7, 16, 50, 50, 743, DateTimeKind.Local).AddTicks(8470), "9c9ec759-b53f-4afe-8952-0d52bef1b603", "ivan@gmail.com", false, "Ivan", "0141012442", true, false, "Ivanov", false, null, "Ivanov", "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAIAAYagAAAAEIWqfM/kY/ZvKLydR+Z6IcOKABV60iqrE+JS/fgr8KAvrFD+6ogqVOYPAYEU0KINYg==", null, false, "81bc6f26-4235-470c-a8fa-11d45c377c3d", false, "ivan@gmail.com", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("30783f80-4041-4984-bd45-a8dd80cf1476"), 0, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2024, 12, 7, 16, 50, 50, 815, DateTimeKind.Local).AddTicks(3140), "eae6fbc6-fdc1-4fee-a118-cff033017707", "martin@gmail.com", false, "Martin", "0741124324", true, false, "Georgiev", false, null, "Ivanov", "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAIAAYagAAAAECc8+EcdQ+tsbkxx3zkGkWZ5Y5rMfv3FGiXpcOWz5O8ZHOY6Q7FFMyDo3hEJ37blhg==", null, false, "0b604fac-2156-4dde-ae99-5f9c334d8079", false, "martin@gmail.com", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4aba1af4-fbf7-41a5-9391-668237458048"), 0, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2024, 12, 7, 16, 50, 50, 887, DateTimeKind.Local).AddTicks(6460), "d2461630-8673-495b-b4d0-6371008707e2", "jivko@gmail.com", false, "Jivko", "1041124324", true, false, "Donev", false, null, "Vasilev", "JIVKO@GMAIL.COM", "JIVKO@GMAIL.COM", "AQAAAAIAAYagAAAAEBlQxqmJUfjJhUkVtFOo8EjG7XAEdBu3W2+KaZrLtat+PGym+4S0H1CYlJKiEPenaw==", null, false, "066c40cf-f968-4102-86bd-5b8633268f74", false, "jivko@gmail.com", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4fe2a962-c824-4e7e-9461-f21e898f5725"), 0, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2024, 12, 7, 16, 50, 51, 69, DateTimeKind.Local).AddTicks(9430), "6e0fb6b8-dd42-41ec-a8a4-14a0394938ce", "stoyanka@gmail.com", false, "Stoyanka", "7105053113", true, false, "Peneva", false, null, "Doneva", "STOYANKA@GMAIL.COM", "STOYANKA@GMAIL.COM", "AQAAAAIAAYagAAAAEDyUk/NVq9DuNvXsmyfkq/zr2nIzk7LTrZAHK8QCfo136Fw5NDXiKFkoSs8OZxSjUw==", null, false, "478f9e1f-8502-4d54-b612-56dd9ad92c77", false, "stoyanka@gmail.com", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("50b39f98-2752-4089-b256-1fd1281b956d"), 0, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2024, 12, 7, 16, 50, 51, 33, DateTimeKind.Local).AddTicks(2660), "0db118ce-7a9f-4e16-bc1b-68bd1653df50", "stamen@gmail.com", false, "Stamen", "7211053143", true, false, "Peev", false, null, "Georgiev", "STAMEN@GMAIL.COM", "STAMEN@GMAIL.COM", "AQAAAAIAAYagAAAAEKJYeRXRgE4RRH1VqsvFfpk1ZMOKClGLfHgoFDesa+Y/1+ExrheclseiqjJ1EHIsmw==", null, false, "2fd93e9e-1606-42ab-92dd-9764a492388d", false, "stamen@gmail.com", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("63d4f8d6-a89d-43fd-bc42-2a88f7e6501f"), 0, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2024, 12, 7, 16, 50, 50, 960, DateTimeKind.Local).AddTicks(8710), "e750a8ca-a332-48ad-b6e7-7db4a079a279", "maria@gmail.com", false, "Maria", "8008089119", true, false, "Petrova", false, null, "Ivanova", "MARIA@GMAIL.COM", "MARIA@GMAIL.COM", "AQAAAAIAAYagAAAAEE8SYttZtSOclX0CLYH/Lq9IScmLVvvHRdU7vSlJq44TsrWhTgM1eeh7YaVL9yhNFQ==", null, false, "3c580b80-65f1-4c96-83b6-06baf1199e73", false, "maria@gmail.com", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6854ffa6-4097-47bc-b39e-be7eb91a6193"), 0, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2024, 12, 7, 16, 50, 50, 779, DateTimeKind.Local).AddTicks(8450), "37f427ff-6750-48f1-8473-91b87cd10c14", "gencho@gmail.com", false, "Gencho", "0543121244", true, false, "Ginev", false, null, "Petkov", "GENCHO@GMAIL.COM", "GENCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEITm6X3c9qyl290mlx/spupgzwQ0bRjstYax6sKA6BbOlpTi21t1XJjS67I0by5TaQ==", null, false, "e7953e6a-2feb-43a8-9513-11cad738b3a4", false, "gencho@gmail.com", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("71f4a881-83f8-4215-adb6-98452c16cb2f"), 0, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2024, 12, 7, 16, 50, 50, 851, DateTimeKind.Local).AddTicks(1330), "200997ec-d0f0-42af-8068-59c78ba563bd", "ginka@gmail.com", false, "Ginka", "0944174331", true, false, "Stoyanova", false, null, "Petrova", "GINKA@GMAIL.COM", "GINKA@GMAIL.COM", "AQAAAAIAAYagAAAAEDIgKj7ejAx0devH/3qSbvIGTDsZoC8naJQfSdP3CIT1o14B8iyYjGIn7xjuztM9EQ==", null, false, "3be6788b-823b-4c80-ba3d-b96d41a4179f", false, "ginka@gmail.com", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a8fb444c-47f8-487a-b8fd-e3b31405059c"), 0, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2024, 12, 7, 16, 50, 51, 106, DateTimeKind.Local).AddTicks(2670), "511c2076-241a-40dc-9041-8bbed14fdc87", "petar@gmail.com", false, "Petar", "8210045421", true, false, "Chonev", false, null, "Mladenov", "PETAR@GMAIL.COM", "PETAR@GMAIL.COM", "AQAAAAIAAYagAAAAENUrbeAO4DFSKxMQI8O+gy5mbBUezwI7Wh53hPTOOxBmNrNBafjr6Qax9Ah4vOXbGQ==", null, false, "8e8b4303-c01c-48bf-a11e-df643c33b735", false, "petar@gmail.com", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("aa4ffa41-7f19-43ca-b81c-50c8c517ced3"), 0, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2024, 12, 7, 16, 50, 50, 996, DateTimeKind.Local).AddTicks(9550), "7ed8f542-3a57-4769-b56c-b48321a74603", "stefka@gmail.com", false, "Stefka", "9003021331", true, false, "Gineva", false, null, "Petkova", "STEFKA@GMAIL.COM", "STEFKA@GMAIL.COM", "AQAAAAIAAYagAAAAECx3KAB6I0YiMa/hh4pEm647UmJ3kCDuWVV/Q1ESxHEDtWH+PU2HcfRUVhYH3Yxuqw==", null, false, "cafb0065-0f8c-4a98-9e02-4df2d8cbb182", false, "stefka@gmail.com", new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("2d6b128d-0749-48da-a276-9cccb5193031"), 3, "Ginka", "0944174331", "Stoyanova", "Petrova", new Guid("3735f7e5-8ea8-4959-94a9-dd8cc8e00a6f") },
                    { new Guid("55d211c2-502d-46b9-a352-ca93fcde88f6"), 4, "Diana", "1148061932", "Kostova", "Nedeva", new Guid("24f9a994-a955-47b3-9f7a-46ef191f9b43") },
                    { new Guid("60a32be9-80db-43d6-86d8-fba9026c5b97"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("0dd55aba-6dc2-46c3-96b1-5e80c46fae47") },
                    { new Guid("cfb7c730-7cb9-4747-9002-5340b87f86ea"), 2, "Martin", "0741124324", "Georgiev", "Ivanov", new Guid("79603cee-bd7f-4bf4-aad8-a00426474eb3") },
                    { new Guid("d369644f-eb36-42a4-b40d-520573b1b1c5"), 5, "Pencho", "0945161226", "Mihov", "Angelov", new Guid("73c8d5de-d99f-47c7-becc-4b1c5d5890dc") },
                    { new Guid("d6e415c2-db6f-4180-b46d-8a18619206d5"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("58c5293f-0c14-4e96-91ac-c8c496e6b7d1") },
                    { new Guid("f25aba94-a3d8-4c9a-8b43-301aaa949623"), 5, "Ruzha", "0852131993", "Veleva", "Todorova", new Guid("8c6af0bc-58e0-465b-ba6e-69f247a57fe7") },
                    { new Guid("fe82a978-3e8d-4245-a359-cdec8d8fb34a"), 4, "Jivko", "1041124324", "Donev", "Vasilev", new Guid("52f149e4-6400-482c-8cd7-cd2abd5e4bb4") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("3546d44c-5140-420a-81f3-3cd83efa94b8"), "Stamen", "7211053143", "Peev", "Georgiev", null, 14, new Guid("0e85e906-a7e0-4089-9360-956409668869") },
                    { new Guid("4a4ff2b0-0979-4426-b2fe-f9d6416a205c"), "Stoyanka", "7105053113", "Peneva", "Doneva", null, 15, new Guid("5295d003-906b-41ba-af78-0f5aa101919f") },
                    { new Guid("bc996b87-8b2e-488f-ac8c-dcd5426c6bcb"), "Stefka", "9003021331", "Gineva", "Petkova", null, 4, new Guid("9514a277-1b6f-4f76-8971-87085aca49cc") },
                    { new Guid("c4cf841d-7cc5-488e-981b-4f013609511d"), "Maria", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("f9ef2ebf-1790-4f08-a43d-bb48674b4f0e") },
                    { new Guid("cc3941c3-6583-407e-a187-dfa606a3cb54"), "Petar", "8210045421", "Chonev", "Mladenov", null, 5, new Guid("b19ff647-c4ac-461e-9f9c-37e8cd37e69c") },
                    { new Guid("f7f20e9d-22a6-4da7-837b-55fcd3b041bb"), "Boncho", "8006210887", "Dimitrov", "Dimitrov", null, 9, new Guid("068f0c3f-bb69-4607-8f45-14b1b6357c51") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("5d9e6766-1f6b-48f1-b848-3569328d80ee"), new Guid("27d93207-c6d6-4bb2-aca1-ac064ea06f2c") });

            migrationBuilder.InsertData(
                table: "TeachersClasses",
                columns: new[] { "ClassId", "TeacherId" },
                values: new object[,]
                {
                    { 1, new Guid("3546d44c-5140-420a-81f3-3cd83efa94b8") },
                    { 2, new Guid("3546d44c-5140-420a-81f3-3cd83efa94b8") },
                    { 3, new Guid("3546d44c-5140-420a-81f3-3cd83efa94b8") },
                    { 5, new Guid("4a4ff2b0-0979-4426-b2fe-f9d6416a205c") },
                    { 1, new Guid("bc996b87-8b2e-488f-ac8c-dcd5426c6bcb") },
                    { 2, new Guid("bc996b87-8b2e-488f-ac8c-dcd5426c6bcb") },
                    { 1, new Guid("c4cf841d-7cc5-488e-981b-4f013609511d") },
                    { 2, new Guid("c4cf841d-7cc5-488e-981b-4f013609511d") },
                    { 4, new Guid("cc3941c3-6583-407e-a187-dfa606a3cb54") },
                    { 4, new Guid("f7f20e9d-22a6-4da7-837b-55fcd3b041bb") }
                });
        }
    }
}
