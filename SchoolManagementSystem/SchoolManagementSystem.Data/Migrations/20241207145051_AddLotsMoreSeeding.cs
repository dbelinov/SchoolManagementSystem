using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddLotsMoreSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2239599d-510a-4431-916a-59eca9c6ba3d"), new Guid("681bbdd1-e0c8-4617-8888-bee21f3c629f") });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("1272875c-7ab2-40cf-88d8-6a2a7c018e46"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("804fd719-b585-40e1-9974-07c781c06c7b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ae1ed6a9-2326-4c40-8a56-e62bd3ac0ec4"));

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("01ebebc4-ff31-49d3-b0b5-4c1404d8a018") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("01ebebc4-ff31-49d3-b0b5-4c1404d8a018") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("a2384309-062b-466b-b267-6b7488197d7e") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("a2384309-062b-466b-b267-6b7488197d7e") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2239599d-510a-4431-916a-59eca9c6ba3d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("681bbdd1-e0c8-4617-8888-bee21f3c629f"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("01ebebc4-ff31-49d3-b0b5-4c1404d8a018"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("a2384309-062b-466b-b267-6b7488197d7e"));

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
                table: "Classes",
                columns: new[] { "Id", "Name", "SchoolId", "Speciality", "TimetableId" },
                values: new object[] { 3, "8g", 1, 2, null });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "Address",
                value: "Avgusta Trayana 44, Stara Zagora, Bulgaria");

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "Description", "LogoUrl", "Name", "Specialities" },
                values: new object[] { 2, "Tsar Ivan Shishman 62, Stara Zagora, Bulgaria", "Stara Zagora's School for Languages like German, French and English", "https://scontent.fsof1-2.fna.fbcdn.net/v/t1.6435-9/119450239_3343706645698457_6833144760730823616_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=6ee11a&_nc_ohc=ydzqvT5knjIQ7kNvgHdpGNw&_nc_zt=23&_nc_ht=scontent.fsof1-2.fna&_nc_gid=AFu1voqShMlHBNalgqkJBc1&oh=00_AYCyzp4BZ7gcXj6ZSnpr1Oop6AQoeJAI-BKPdIUJsGXD5Q&oe=677BAAFA", "SSFL \"Romain Rolland\"", "[5,6,7]" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("60a32be9-80db-43d6-86d8-fba9026c5b97"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("0dd55aba-6dc2-46c3-96b1-5e80c46fae47") },
                    { new Guid("cfb7c730-7cb9-4747-9002-5340b87f86ea"), 2, "Martin", "0741124324", "Georgiev", "Ivanov", new Guid("79603cee-bd7f-4bf4-aad8-a00426474eb3") },
                    { new Guid("d6e415c2-db6f-4180-b46d-8a18619206d5"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("58c5293f-0c14-4e96-91ac-c8c496e6b7d1") }
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
                table: "Classes",
                columns: new[] { "Id", "Name", "SchoolId", "Speciality", "TimetableId" },
                values: new object[,]
                {
                    { 4, "10a", 2, 5, null },
                    { 5, "11v", 2, 6, null }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[] { new Guid("2d6b128d-0749-48da-a276-9cccb5193031"), 3, "Ginka", "0944174331", "Stoyanova", "Petrova", new Guid("3735f7e5-8ea8-4959-94a9-dd8cc8e00a6f") });

            migrationBuilder.InsertData(
                table: "TeachersClasses",
                columns: new[] { "ClassId", "TeacherId" },
                values: new object[,]
                {
                    { 1, new Guid("3546d44c-5140-420a-81f3-3cd83efa94b8") },
                    { 2, new Guid("3546d44c-5140-420a-81f3-3cd83efa94b8") },
                    { 3, new Guid("3546d44c-5140-420a-81f3-3cd83efa94b8") },
                    { 1, new Guid("bc996b87-8b2e-488f-ac8c-dcd5426c6bcb") },
                    { 2, new Guid("bc996b87-8b2e-488f-ac8c-dcd5426c6bcb") },
                    { 1, new Guid("c4cf841d-7cc5-488e-981b-4f013609511d") },
                    { 2, new Guid("c4cf841d-7cc5-488e-981b-4f013609511d") }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("55d211c2-502d-46b9-a352-ca93fcde88f6"), 4, "Diana", "1148061932", "Kostova", "Nedeva", new Guid("24f9a994-a955-47b3-9f7a-46ef191f9b43") },
                    { new Guid("d369644f-eb36-42a4-b40d-520573b1b1c5"), 5, "Pencho", "0945161226", "Mihov", "Angelov", new Guid("73c8d5de-d99f-47c7-becc-4b1c5d5890dc") },
                    { new Guid("f25aba94-a3d8-4c9a-8b43-301aaa949623"), 5, "Ruzha", "0852131993", "Veleva", "Todorova", new Guid("8c6af0bc-58e0-465b-ba6e-69f247a57fe7") },
                    { new Guid("fe82a978-3e8d-4245-a359-cdec8d8fb34a"), 4, "Jivko", "1041124324", "Donev", "Vasilev", new Guid("52f149e4-6400-482c-8cd7-cd2abd5e4bb4") }
                });

            migrationBuilder.InsertData(
                table: "TeachersClasses",
                columns: new[] { "ClassId", "TeacherId" },
                values: new object[,]
                {
                    { 5, new Guid("4a4ff2b0-0979-4426-b2fe-f9d6416a205c") },
                    { 4, new Guid("cc3941c3-6583-407e-a187-dfa606a3cb54") },
                    { 4, new Guid("f7f20e9d-22a6-4da7-837b-55fcd3b041bb") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("2239599d-510a-4431-916a-59eca9c6ba3d"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AppId", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IdNumber", "IsAuthenticated", "IsGuest", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VerificationKey" },
                values: new object[] { new Guid("681bbdd1-e0c8-4617-8888-bee21f3c629f"), 0, new Guid("681bbdd1-e0c8-4617-8888-bee21f3c629f"), new DateTime(2024, 12, 7, 11, 16, 50, 513, DateTimeKind.Local).AddTicks(290), "8394d764-be65-41d7-bfe2-177a5255890b", "admin@scholario.com", true, "Admin", "2452064114", true, false, "Adminov", false, null, "Adminov", "ADMIN@SCHOLARIO.COM", "ADMIN@SCHOLARIO.COM", "AQAAAAIAAYagAAAAECdGJDMlcQm62cQthq4ECifB9OC9XB8p4Q2zt4KXLZk0vdTFb9tGgXzqalFERgwlmA==", null, false, "1fe00171-99e6-4c94-a807-8abefd2fdc4d", false, "admin@scholario.com", new Guid("681bbdd1-e0c8-4617-8888-bee21f3c629f") });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "Address",
                value: "44 Avgusta Trayana\nStara Zagora, Bulgaria");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("1272875c-7ab2-40cf-88d8-6a2a7c018e46"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("c1401b18-a9ef-47c0-ae88-cc24594032ad") },
                    { new Guid("804fd719-b585-40e1-9974-07c781c06c7b"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("747884f5-e8f5-47cd-88b1-7dcbe3240a95") },
                    { new Guid("ae1ed6a9-2326-4c40-8a56-e62bd3ac0ec4"), 2, "Martin", "0741124324", "Georgiev", "Ivanov", new Guid("e1528851-aed8-4e8c-a7a8-0588f0b263a1") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("01ebebc4-ff31-49d3-b0b5-4c1404d8a018"), "Stefka", "9003021331", "Gineva", "Petkova", null, 4, new Guid("1e7dbfc5-f7b7-40dd-acf2-0cf6c275e0a1") },
                    { new Guid("a2384309-062b-466b-b267-6b7488197d7e"), "Maria", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("47c8b8b7-9bfb-4875-b562-5a88c9b11736") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("2239599d-510a-4431-916a-59eca9c6ba3d"), new Guid("681bbdd1-e0c8-4617-8888-bee21f3c629f") });

            migrationBuilder.InsertData(
                table: "TeachersClasses",
                columns: new[] { "ClassId", "TeacherId" },
                values: new object[,]
                {
                    { 1, new Guid("01ebebc4-ff31-49d3-b0b5-4c1404d8a018") },
                    { 2, new Guid("01ebebc4-ff31-49d3-b0b5-4c1404d8a018") },
                    { 1, new Guid("a2384309-062b-466b-b267-6b7488197d7e") },
                    { 2, new Guid("a2384309-062b-466b-b267-6b7488197d7e") }
                });
        }
    }
}
