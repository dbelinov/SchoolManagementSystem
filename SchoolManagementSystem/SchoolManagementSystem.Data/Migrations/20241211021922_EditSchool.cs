using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class EditSchool : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("cc685e9d-f29e-415b-9620-aac09bafc3f9"), new Guid("2f25395d-8c7f-4737-9e4c-d163bb3ccfc8") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("cc685e9d-f29e-415b-9620-aac09bafc3f9"), new Guid("2fb904be-10b0-4c3b-a926-fb7ce5e1f81d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("953a2f8f-536a-42b4-a2fc-a75836d187d9"), new Guid("3dd3ef79-eaea-4aa0-a571-e47e87fd5029") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("953a2f8f-536a-42b4-a2fc-a75836d187d9"), new Guid("4a26d76f-81b7-4082-8f3e-178b7c3a3025") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("cc685e9d-f29e-415b-9620-aac09bafc3f9"), new Guid("719ecc8f-c52c-4cb3-bdbb-81a204c78844") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("cc685e9d-f29e-415b-9620-aac09bafc3f9"), new Guid("9f5ac8dd-e7ab-405b-9b9d-5d5c5fd9671c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("953a2f8f-536a-42b4-a2fc-a75836d187d9"), new Guid("a1103813-6533-4f6b-9226-20fba6c93318") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("953a2f8f-536a-42b4-a2fc-a75836d187d9"), new Guid("aa5c635d-2f0a-4840-9ba4-401e5e682d7d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("cc685e9d-f29e-415b-9620-aac09bafc3f9"), new Guid("b5e5fd1a-a3ff-487a-a3a6-a11b03a3cf5b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("953a2f8f-536a-42b4-a2fc-a75836d187d9"), new Guid("b871cd1b-c4e2-4725-8a21-abbc1d4c305d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("953a2f8f-536a-42b4-a2fc-a75836d187d9"), new Guid("c6303d6b-1b5d-47b8-ac36-b28c9363e2e4") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("77d96249-67ff-4667-9d54-75487978d2d4"), new Guid("c78a8c24-0225-45da-82ff-0462e92fe43d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("cc685e9d-f29e-415b-9620-aac09bafc3f9"), new Guid("e5f406ab-ad3d-450b-b6be-5c9e0a0c1f5c") });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("105285af-3bb3-4256-b615-99bcfec6a72b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("52fd6e39-4adf-4a6c-a236-6f686ae0a769"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("7d9c7f61-c5fe-4b6b-a193-9287e036572f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("983cb0fe-f890-4974-a93f-5b009a0490bc"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("aa51a218-c71e-41d5-9eed-08dc9c6b7cb5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("b5d9e4dd-8254-47ab-b422-62d79dc084e9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("b8db297b-d9f7-414b-9827-18b2fafdbbac"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c0168b38-bc23-49bc-983a-c3f2c746e22d"));

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 5, new Guid("556c352a-8ad8-4f8e-ad9a-028559a0e3bd") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("80a24610-0bae-400c-8225-d9d8636d7d12") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("80a24610-0bae-400c-8225-d9d8636d7d12") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 4, new Guid("84fd6466-94f3-4321-9cec-5b759bdf920b") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("89320008-9462-4220-9aa5-bff33d4fddf5") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("89320008-9462-4220-9aa5-bff33d4fddf5") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("8afc42f4-b9ee-429a-9275-e4abceea0977") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("8afc42f4-b9ee-429a-9275-e4abceea0977") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 3, new Guid("8afc42f4-b9ee-429a-9275-e4abceea0977") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 4, new Guid("a699d3e3-0538-4aa5-bbad-50f72bcc666e") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("77d96249-67ff-4667-9d54-75487978d2d4"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("953a2f8f-536a-42b4-a2fc-a75836d187d9"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cc685e9d-f29e-415b-9620-aac09bafc3f9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2f25395d-8c7f-4737-9e4c-d163bb3ccfc8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fb904be-10b0-4c3b-a926-fb7ce5e1f81d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3dd3ef79-eaea-4aa0-a571-e47e87fd5029"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4a26d76f-81b7-4082-8f3e-178b7c3a3025"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("719ecc8f-c52c-4cb3-bdbb-81a204c78844"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f5ac8dd-e7ab-405b-9b9d-5d5c5fd9671c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a1103813-6533-4f6b-9226-20fba6c93318"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("aa5c635d-2f0a-4840-9ba4-401e5e682d7d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e5fd1a-a3ff-487a-a3a6-a11b03a3cf5b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b871cd1b-c4e2-4725-8a21-abbc1d4c305d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c6303d6b-1b5d-47b8-ac36-b28c9363e2e4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c78a8c24-0225-45da-82ff-0462e92fe43d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5f406ab-ad3d-450b-b6be-5c9e0a0c1f5c"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("556c352a-8ad8-4f8e-ad9a-028559a0e3bd"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("80a24610-0bae-400c-8225-d9d8636d7d12"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("84fd6466-94f3-4321-9cec-5b759bdf920b"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("89320008-9462-4220-9aa5-bff33d4fddf5"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("8afc42f4-b9ee-429a-9275-e4abceea0977"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("a699d3e3-0538-4aa5-bbad-50f72bcc666e"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("25588845-b7a8-45c4-9138-c58f227ffe0c"), null, "Admin", "ADMIN" },
                    { new Guid("a4bfa4e1-50c8-434f-83a6-936bbf6d6e13"), null, "Teacher", "TEACHER" },
                    { new Guid("f3057980-ee1f-4ee2-8af4-21d173ce9750"), null, "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AppId", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IdNumber", "IsAuthenticated", "IsGuest", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("1a2f99ac-e8d4-4c36-8127-37c77a36a44b"), 0, new Guid("c07a087f-3096-42c8-82d0-baef54022734"), new DateTime(2024, 12, 11, 4, 19, 21, 247, DateTimeKind.Local).AddTicks(8840), "b8f34477-7fd6-44ea-ae5f-c45182fe04c1", "ginka@gmail.com", false, "Ginka", "0944174331", true, false, "Stoyanova", false, null, "Petrova", "GINKA@GMAIL.COM", "GINKA@GMAIL.COM", "AQAAAAIAAYagAAAAEGNMiNYd2EbWJ9yZTncasQm6HhXiitzTjCqNgEykvUExElv14bt1VpteLGLIdVb4Og==", null, false, "232aee69-078b-4297-bfda-b9b0f8743b3e", false, "ginka@gmail.com", new Guid("c09f2c07-5547-4c6a-a490-05316421c22e") },
                    { new Guid("640a5fd7-0f9c-434a-be35-32690a81b633"), 0, new Guid("640a5fd7-0f9c-434a-be35-32690a81b633"), new DateTime(2024, 12, 11, 4, 19, 21, 580, DateTimeKind.Local).AddTicks(6630), "f4a6f275-4e6d-4d44-97d0-426b2d120629", "admin@scholario.com", true, "Admin", "2452064114", true, false, "Adminov", false, null, "Adminov", "ADMIN@SCHOLARIO.COM", "ADMIN@SCHOLARIO.COM", "AQAAAAIAAYagAAAAEJAmlzmPh9+oR1jzLsBZAfdz6Byk5LxhfSiwi74DXbTFzk6W81di2JDEkaF6gP3EHA==", null, false, "d8da4052-2390-4f0d-aa01-688f38383614", false, "admin@scholario.com", new Guid("640a5fd7-0f9c-434a-be35-32690a81b633") },
                    { new Guid("65dc3fb2-67be-433b-9783-785f9c19e057"), 0, new Guid("0809b88d-ac5d-4670-8a0d-4051948b73d2"), new DateTime(2024, 12, 11, 4, 19, 21, 137, DateTimeKind.Local).AddTicks(7050), "bbde79b8-4abf-49ac-8d8f-ac1af692a6e5", "ivan@gmail.com", false, "Ivan", "0141012442", true, false, "Ivanov", false, null, "Ivanov", "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAIAAYagAAAAEHyGRjHwmdlYu35qaBBdb9mpiGus7fFaL8FyGEoPsSmbSa5XGITo+3n+aDiqlvqw+g==", null, false, "2e8df240-86ba-413c-9296-2efa18da78d0", false, "ivan@gmail.com", new Guid("41804caf-54c6-463c-8587-e0edffc016ff") },
                    { new Guid("713c7d6d-ecf1-419e-9fc5-4ca8900eb7fe"), 0, new Guid("2eca3b86-60f1-41b5-8be3-8e99d4066c2a"), new DateTime(2024, 12, 11, 4, 19, 21, 359, DateTimeKind.Local).AddTicks(2950), "21fe8fef-4793-4653-9a20-5df58ae29206", "maria@gmail.com", false, "Maria", "8008089119", true, false, "Petrova", false, null, "Ivanova", "MARIA@GMAIL.COM", "MARIA@GMAIL.COM", "AQAAAAIAAYagAAAAEGfdB9EOiewCfOFvrdoPd1+bttH8Wdy3/wHlVJ5tdt+16rJAT6RlfWYoxCiit+m9zA==", null, false, "754c9e65-ae79-4966-8a7c-ef8b2891baf4", false, "maria@gmail.com", new Guid("95acc98a-1171-430a-92e2-f86821946722") },
                    { new Guid("7ac7ab14-6b57-48ed-b797-0dbfc65341c9"), 0, new Guid("0d3bb376-6b33-4a10-a275-454123924ba1"), new DateTime(2024, 12, 11, 4, 19, 21, 470, DateTimeKind.Local).AddTicks(5840), "1031692d-63b4-4507-85fe-d9a95e03cac4", "stoyanka@gmail.com", false, "Stoyanka", "7105053113", true, false, "Peneva", false, null, "Doneva", "STOYANKA@GMAIL.COM", "STOYANKA@GMAIL.COM", "AQAAAAIAAYagAAAAED8G/YS1zGRyiRKLPuxRrJxVYUzX9C6U/KfAsWXw5TuBYMPavxJO8fddT06Qwip3PA==", null, false, "7c9e6cad-3661-48bc-917a-7eff3c67f1c1", false, "stoyanka@gmail.com", new Guid("55492d91-6039-4227-b0c5-c4a42a25756d") },
                    { new Guid("7ef4fa76-49d0-4afc-ba07-a4df87fac40c"), 0, new Guid("f6afb974-d1e3-4ccc-9c90-3bbd36e7b8c1"), new DateTime(2024, 12, 11, 4, 19, 21, 174, DateTimeKind.Local).AddTicks(6080), "c83199fc-51bd-438c-b70b-79a4d74d32ec", "gencho@gmail.com", false, "Gencho", "0543121244", true, false, "Ginev", false, null, "Petkov", "GENCHO@GMAIL.COM", "GENCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEFKaJm+Rt7TjOtY0V4o41YGI1HZ/VXTqT/SOzzFZ0pxVazroZbQN5bSjXUt3JUv9Qw==", null, false, "826137b2-872e-4758-b97c-c14ead2d3999", false, "gencho@gmail.com", new Guid("97eabedd-dc15-4422-99d2-84a57a5dd3b7") },
                    { new Guid("a00584c2-c7c3-48d1-b0d5-a95905655f67"), 0, new Guid("8c720aa4-7720-4273-9c9b-ecaaae3c2699"), new DateTime(2024, 12, 11, 4, 19, 21, 433, DateTimeKind.Local).AddTicks(7940), "8b7bb45e-6271-4196-be43-25b0164bda09", "stamen@gmail.com", false, "Stamen", "7211053143", true, false, "Peev", false, null, "Georgiev", "STAMEN@GMAIL.COM", "STAMEN@GMAIL.COM", "AQAAAAIAAYagAAAAEAMAtayPJu6ZstlvfBC5aKUoydYgLnKaL8V2spEtx8vqX9lM1CIHCdmnsucJNm0QvQ==", null, false, "d44233dd-93d1-4bb2-8de4-f6b615e2f27f", false, "stamen@gmail.com", new Guid("3ea97cd0-8d3c-4eae-8f03-7511e32d598f") },
                    { new Guid("a7a03a4b-6c2d-4741-9708-7b7821a26cde"), 0, new Guid("cffa85f4-6b49-4a6c-a1f1-b70efb99c9d4"), new DateTime(2024, 12, 11, 4, 19, 21, 284, DateTimeKind.Local).AddTicks(7780), "d1e8b41b-5eeb-4baf-8830-f629b0ce48ad", "jivko@gmail.com", false, "Jivko", "1041124324", true, false, "Donev", false, null, "Vasilev", "JIVKO@GMAIL.COM", "JIVKO@GMAIL.COM", "AQAAAAIAAYagAAAAEFT0zt9ZxCPJh2ZtZjpawRVHB8J7Led5zUtzZVBL5Fk1Ne4jA8ft9+hBnCSMKpxAfQ==", null, false, "68fd44ed-c47a-4029-bf32-73e8229b3b16", false, "jivko@gmail.com", new Guid("c36b17ff-1f8c-44d8-b57b-4ef92a605562") },
                    { new Guid("acd17095-d0eb-4946-80e8-6c8bf5afa66d"), 0, new Guid("c27a5973-2cad-4f29-8320-4bcaed969977"), new DateTime(2024, 12, 11, 4, 19, 21, 396, DateTimeKind.Local).AddTicks(5130), "72bf94ac-31c7-4dd8-b620-c249dd0ae902", "stefka@gmail.com", false, "Stefka", "9003021331", true, false, "Gineva", false, null, "Petkova", "STEFKA@GMAIL.COM", "STEFKA@GMAIL.COM", "AQAAAAIAAYagAAAAEAg6b8A+nQFLI3ZYN5763zcos46+X4rB1YiYNJluevd7ZL/XfwAttpuPL29KioSj2w==", null, false, "5662a555-ae81-46a5-9e39-011962b26db0", false, "stefka@gmail.com", new Guid("782c64bc-8a48-4f9f-b59d-4e2f9f525421") },
                    { new Guid("d5d2153b-50e1-4659-b827-29589bd6d13b"), 0, new Guid("6ed8249a-9b39-41c0-b974-538bb520ee54"), new DateTime(2024, 12, 11, 4, 19, 21, 321, DateTimeKind.Local).AddTicks(6830), "7ec14bca-ef7f-4152-ae52-6b43f15d1dc6", "pencho@gmail.com", false, "Pencho", "0945161226", true, false, "Mihov", false, null, "Angelov", "PENCHO@GMAIL.COM", "PENCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEAW7LMKOqWaOpr7aztdZDxvKFQtXh+IUy9cpXtu4IdHHAfQQu1w0r+Zvv1fPVV9+yg==", null, false, "6bfa1afe-7d16-44ee-8d08-5c0ed4bfaaf3", false, "pencho@gmail.com", new Guid("efbfac98-013e-42c0-bd51-87c3649fe232") },
                    { new Guid("e36fcee5-3a7c-4360-be50-5be9c6c4e3fa"), 0, new Guid("00a5f68b-28c8-48d9-a6a9-985967994b7a"), new DateTime(2024, 12, 11, 4, 19, 21, 506, DateTimeKind.Local).AddTicks(6630), "14bd30f0-229a-4c74-82fc-2ecee4bad342", "petar@gmail.com", false, "Petar", "8210045421", true, false, "Chonev", false, null, "Mladenov", "PETAR@GMAIL.COM", "PETAR@GMAIL.COM", "AQAAAAIAAYagAAAAEO8jYte1g2Lgq2ZkSD3+hBqBt8T58qoMwBnoL1kL8oOlxULd635PEKlsHJeToPls7Q==", null, false, "8febb2d8-13a9-41f8-8be0-a65e4a2087e5", false, "petar@gmail.com", new Guid("c6caff99-189e-45db-9886-6b365d050f4c") },
                    { new Guid("e64c76d8-54b6-4611-adfa-83113520151e"), 0, new Guid("65a0025e-7e5d-4ddd-b93b-8985a6b429f8"), new DateTime(2024, 12, 11, 4, 19, 21, 211, DateTimeKind.Local).AddTicks(830), "7d54047c-ad6a-48ea-8211-e09eb5229296", "martin@gmail.com", false, "Martin", "0741124324", true, false, "Georgiev", false, null, "Ivanov", "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAIAAYagAAAAEE890ciELrPtuepgOBc3bYwsIUOidAmR9fHNfHV0kn6Sw6/wiSY4MLJbXxhN/5gPkQ==", null, false, "559acc6e-fd5a-4026-9f5b-0243d8206a30", false, "martin@gmail.com", new Guid("9b6479d1-585e-4d95-856b-5dd9a64605bb") },
                    { new Guid("fb962c0e-bc33-45e1-a2ac-d455b3315b81"), 0, new Guid("17de384b-293a-428d-948b-b19b4a2fb48c"), new DateTime(2024, 12, 11, 4, 19, 21, 543, DateTimeKind.Local).AddTicks(7980), "082656f9-69d5-4a67-816f-9e1f32b9b1cf", "boncho@gmail.com", false, "Boncho", "8006210887", true, false, "Dimitrov", false, null, "Dimitrov", "BONCHO@GMAIL.COM", "BONCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEEVSM7hL3Q28fPogFNVCSab7yu7YnwyBJsZaBymP62Yfi1BLVPE9jqLIQ3GRTJM6DQ==", null, false, "4a237ad5-3e7d-464d-affe-7e1763954ad0", false, "boncho@gmail.com", new Guid("30827f3b-898f-4d95-858b-07bc41948eff") }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("0809b88d-ac5d-4670-8a0d-4051948b73d2"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("41804caf-54c6-463c-8587-e0edffc016ff") },
                    { new Guid("57545566-2482-4de7-a480-9004e931e444"), 4, "Diana", "1148061932", "Kostova", "Nedeva", new Guid("f215006d-b6ff-496a-a40c-57feda56a960") },
                    { new Guid("65a0025e-7e5d-4ddd-b93b-8985a6b429f8"), 2, "Martin", "0741124324", "Georgiev", "Ivanov", new Guid("9b6479d1-585e-4d95-856b-5dd9a64605bb") },
                    { new Guid("6ed8249a-9b39-41c0-b974-538bb520ee54"), 5, "Pencho", "0945161226", "Mihov", "Angelov", new Guid("efbfac98-013e-42c0-bd51-87c3649fe232") },
                    { new Guid("a1f5443e-e059-4a4a-b03c-8b2d77940bb5"), 5, "Ruzha", "0852131993", "Veleva", "Todorova", new Guid("323bdce5-53e5-44b5-a6bb-3a2a6fb7ea91") },
                    { new Guid("c07a087f-3096-42c8-82d0-baef54022734"), 3, "Ginka", "0944174331", "Stoyanova", "Petrova", new Guid("c09f2c07-5547-4c6a-a490-05316421c22e") },
                    { new Guid("cffa85f4-6b49-4a6c-a1f1-b70efb99c9d4"), 4, "Jivko", "1041124324", "Donev", "Vasilev", new Guid("c36b17ff-1f8c-44d8-b57b-4ef92a605562") },
                    { new Guid("f6afb974-d1e3-4ccc-9c90-3bbd36e7b8c1"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("97eabedd-dc15-4422-99d2-84a57a5dd3b7") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("00a5f68b-28c8-48d9-a6a9-985967994b7a"), "Petar", "8210045421", "Chonev", "Mladenov", null, 5, new Guid("c6caff99-189e-45db-9886-6b365d050f4c") },
                    { new Guid("0d3bb376-6b33-4a10-a275-454123924ba1"), "Stoyanka", "7105053113", "Peneva", "Doneva", null, 15, new Guid("55492d91-6039-4227-b0c5-c4a42a25756d") },
                    { new Guid("17de384b-293a-428d-948b-b19b4a2fb48c"), "Boncho", "8006210887", "Dimitrov", "Dimitrov", null, 9, new Guid("30827f3b-898f-4d95-858b-07bc41948eff") },
                    { new Guid("2eca3b86-60f1-41b5-8be3-8e99d4066c2a"), "Maria", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("95acc98a-1171-430a-92e2-f86821946722") },
                    { new Guid("8c720aa4-7720-4273-9c9b-ecaaae3c2699"), "Stamen", "7211053143", "Peev", "Georgiev", null, 14, new Guid("3ea97cd0-8d3c-4eae-8f03-7511e32d598f") },
                    { new Guid("c27a5973-2cad-4f29-8320-4bcaed969977"), "Stefka", "9003021331", "Gineva", "Petkova", null, 4, new Guid("782c64bc-8a48-4f9f-b59d-4e2f9f525421") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("f3057980-ee1f-4ee2-8af4-21d173ce9750"), new Guid("1a2f99ac-e8d4-4c36-8127-37c77a36a44b") },
                    { new Guid("25588845-b7a8-45c4-9138-c58f227ffe0c"), new Guid("640a5fd7-0f9c-434a-be35-32690a81b633") },
                    { new Guid("f3057980-ee1f-4ee2-8af4-21d173ce9750"), new Guid("65dc3fb2-67be-433b-9783-785f9c19e057") },
                    { new Guid("a4bfa4e1-50c8-434f-83a6-936bbf6d6e13"), new Guid("713c7d6d-ecf1-419e-9fc5-4ca8900eb7fe") },
                    { new Guid("a4bfa4e1-50c8-434f-83a6-936bbf6d6e13"), new Guid("7ac7ab14-6b57-48ed-b797-0dbfc65341c9") },
                    { new Guid("f3057980-ee1f-4ee2-8af4-21d173ce9750"), new Guid("7ef4fa76-49d0-4afc-ba07-a4df87fac40c") },
                    { new Guid("a4bfa4e1-50c8-434f-83a6-936bbf6d6e13"), new Guid("a00584c2-c7c3-48d1-b0d5-a95905655f67") },
                    { new Guid("f3057980-ee1f-4ee2-8af4-21d173ce9750"), new Guid("a7a03a4b-6c2d-4741-9708-7b7821a26cde") },
                    { new Guid("a4bfa4e1-50c8-434f-83a6-936bbf6d6e13"), new Guid("acd17095-d0eb-4946-80e8-6c8bf5afa66d") },
                    { new Guid("f3057980-ee1f-4ee2-8af4-21d173ce9750"), new Guid("d5d2153b-50e1-4659-b827-29589bd6d13b") },
                    { new Guid("a4bfa4e1-50c8-434f-83a6-936bbf6d6e13"), new Guid("e36fcee5-3a7c-4360-be50-5be9c6c4e3fa") },
                    { new Guid("f3057980-ee1f-4ee2-8af4-21d173ce9750"), new Guid("e64c76d8-54b6-4611-adfa-83113520151e") },
                    { new Guid("a4bfa4e1-50c8-434f-83a6-936bbf6d6e13"), new Guid("fb962c0e-bc33-45e1-a2ac-d455b3315b81") }
                });

            migrationBuilder.InsertData(
                table: "TeachersClasses",
                columns: new[] { "ClassId", "TeacherId" },
                values: new object[,]
                {
                    { 4, new Guid("00a5f68b-28c8-48d9-a6a9-985967994b7a") },
                    { 5, new Guid("0d3bb376-6b33-4a10-a275-454123924ba1") },
                    { 4, new Guid("17de384b-293a-428d-948b-b19b4a2fb48c") },
                    { 1, new Guid("2eca3b86-60f1-41b5-8be3-8e99d4066c2a") },
                    { 2, new Guid("2eca3b86-60f1-41b5-8be3-8e99d4066c2a") },
                    { 1, new Guid("8c720aa4-7720-4273-9c9b-ecaaae3c2699") },
                    { 2, new Guid("8c720aa4-7720-4273-9c9b-ecaaae3c2699") },
                    { 3, new Guid("8c720aa4-7720-4273-9c9b-ecaaae3c2699") },
                    { 1, new Guid("c27a5973-2cad-4f29-8320-4bcaed969977") },
                    { 2, new Guid("c27a5973-2cad-4f29-8320-4bcaed969977") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f3057980-ee1f-4ee2-8af4-21d173ce9750"), new Guid("1a2f99ac-e8d4-4c36-8127-37c77a36a44b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("25588845-b7a8-45c4-9138-c58f227ffe0c"), new Guid("640a5fd7-0f9c-434a-be35-32690a81b633") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f3057980-ee1f-4ee2-8af4-21d173ce9750"), new Guid("65dc3fb2-67be-433b-9783-785f9c19e057") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a4bfa4e1-50c8-434f-83a6-936bbf6d6e13"), new Guid("713c7d6d-ecf1-419e-9fc5-4ca8900eb7fe") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a4bfa4e1-50c8-434f-83a6-936bbf6d6e13"), new Guid("7ac7ab14-6b57-48ed-b797-0dbfc65341c9") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f3057980-ee1f-4ee2-8af4-21d173ce9750"), new Guid("7ef4fa76-49d0-4afc-ba07-a4df87fac40c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a4bfa4e1-50c8-434f-83a6-936bbf6d6e13"), new Guid("a00584c2-c7c3-48d1-b0d5-a95905655f67") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f3057980-ee1f-4ee2-8af4-21d173ce9750"), new Guid("a7a03a4b-6c2d-4741-9708-7b7821a26cde") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a4bfa4e1-50c8-434f-83a6-936bbf6d6e13"), new Guid("acd17095-d0eb-4946-80e8-6c8bf5afa66d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f3057980-ee1f-4ee2-8af4-21d173ce9750"), new Guid("d5d2153b-50e1-4659-b827-29589bd6d13b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a4bfa4e1-50c8-434f-83a6-936bbf6d6e13"), new Guid("e36fcee5-3a7c-4360-be50-5be9c6c4e3fa") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f3057980-ee1f-4ee2-8af4-21d173ce9750"), new Guid("e64c76d8-54b6-4611-adfa-83113520151e") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a4bfa4e1-50c8-434f-83a6-936bbf6d6e13"), new Guid("fb962c0e-bc33-45e1-a2ac-d455b3315b81") });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("0809b88d-ac5d-4670-8a0d-4051948b73d2"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("57545566-2482-4de7-a480-9004e931e444"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("65a0025e-7e5d-4ddd-b93b-8985a6b429f8"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("6ed8249a-9b39-41c0-b974-538bb520ee54"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a1f5443e-e059-4a4a-b03c-8b2d77940bb5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c07a087f-3096-42c8-82d0-baef54022734"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("cffa85f4-6b49-4a6c-a1f1-b70efb99c9d4"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("f6afb974-d1e3-4ccc-9c90-3bbd36e7b8c1"));

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 4, new Guid("00a5f68b-28c8-48d9-a6a9-985967994b7a") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 5, new Guid("0d3bb376-6b33-4a10-a275-454123924ba1") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 4, new Guid("17de384b-293a-428d-948b-b19b4a2fb48c") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("2eca3b86-60f1-41b5-8be3-8e99d4066c2a") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("2eca3b86-60f1-41b5-8be3-8e99d4066c2a") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("8c720aa4-7720-4273-9c9b-ecaaae3c2699") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("8c720aa4-7720-4273-9c9b-ecaaae3c2699") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 3, new Guid("8c720aa4-7720-4273-9c9b-ecaaae3c2699") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("c27a5973-2cad-4f29-8320-4bcaed969977") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("c27a5973-2cad-4f29-8320-4bcaed969977") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("25588845-b7a8-45c4-9138-c58f227ffe0c"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a4bfa4e1-50c8-434f-83a6-936bbf6d6e13"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f3057980-ee1f-4ee2-8af4-21d173ce9750"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1a2f99ac-e8d4-4c36-8127-37c77a36a44b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("640a5fd7-0f9c-434a-be35-32690a81b633"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("65dc3fb2-67be-433b-9783-785f9c19e057"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("713c7d6d-ecf1-419e-9fc5-4ca8900eb7fe"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7ac7ab14-6b57-48ed-b797-0dbfc65341c9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7ef4fa76-49d0-4afc-ba07-a4df87fac40c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a00584c2-c7c3-48d1-b0d5-a95905655f67"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a7a03a4b-6c2d-4741-9708-7b7821a26cde"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("acd17095-d0eb-4946-80e8-6c8bf5afa66d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d5d2153b-50e1-4659-b827-29589bd6d13b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e36fcee5-3a7c-4360-be50-5be9c6c4e3fa"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e64c76d8-54b6-4611-adfa-83113520151e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fb962c0e-bc33-45e1-a2ac-d455b3315b81"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("00a5f68b-28c8-48d9-a6a9-985967994b7a"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("0d3bb376-6b33-4a10-a275-454123924ba1"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("17de384b-293a-428d-948b-b19b4a2fb48c"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("2eca3b86-60f1-41b5-8be3-8e99d4066c2a"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("8c720aa4-7720-4273-9c9b-ecaaae3c2699"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("c27a5973-2cad-4f29-8320-4bcaed969977"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("77d96249-67ff-4667-9d54-75487978d2d4"), null, "Admin", "ADMIN" },
                    { new Guid("953a2f8f-536a-42b4-a2fc-a75836d187d9"), null, "Student", "STUDENT" },
                    { new Guid("cc685e9d-f29e-415b-9620-aac09bafc3f9"), null, "Teacher", "TEACHER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AppId", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IdNumber", "IsAuthenticated", "IsGuest", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("2f25395d-8c7f-4737-9e4c-d163bb3ccfc8"), 0, new Guid("556c352a-8ad8-4f8e-ad9a-028559a0e3bd"), new DateTime(2024, 12, 10, 23, 7, 12, 992, DateTimeKind.Local).AddTicks(6390), "2021fffa-136d-4fcc-88d5-8570672f3776", "stoyanka@gmail.com", false, "Stoyanka", "7105053113", true, false, "Peneva", false, null, "Doneva", "STOYANKA@GMAIL.COM", "STOYANKA@GMAIL.COM", "AQAAAAIAAYagAAAAEBVgiPIrAqbfrK0rJcuY0nkWlkZTxMKjxoZcV7CN2XYO+H9yvSMIElngAI+YWqp3rA==", null, false, "c786d93b-5cf9-4ff1-a3df-c9916aa39ce0", false, "stoyanka@gmail.com", new Guid("42801f83-12c6-4a5a-8796-33f06f291611") },
                    { new Guid("2fb904be-10b0-4c3b-a926-fb7ce5e1f81d"), 0, new Guid("89320008-9462-4220-9aa5-bff33d4fddf5"), new DateTime(2024, 12, 10, 23, 7, 12, 880, DateTimeKind.Local).AddTicks(1380), "526583ae-a231-42bb-abb9-33d42085dbd2", "maria@gmail.com", false, "Maria", "8008089119", true, false, "Petrova", false, null, "Ivanova", "MARIA@GMAIL.COM", "MARIA@GMAIL.COM", "AQAAAAIAAYagAAAAEBjNYBjxIRR3JKBvCgVkA+D+yxbmkGurdUD1b8P2mJGd2TTxzptyko/i9yX3/+ISZQ==", null, false, "8ba6b634-75fd-48ec-af95-a42d4de7ae03", false, "maria@gmail.com", new Guid("1b57975b-6361-4038-aeaf-08403b518b45") },
                    { new Guid("3dd3ef79-eaea-4aa0-a571-e47e87fd5029"), 0, new Guid("105285af-3bb3-4256-b615-99bcfec6a72b"), new DateTime(2024, 12, 10, 23, 7, 12, 767, DateTimeKind.Local).AddTicks(9650), "cd121cb2-fb50-4918-a8c5-806634417d0a", "ginka@gmail.com", false, "Ginka", "0944174331", true, false, "Stoyanova", false, null, "Petrova", "GINKA@GMAIL.COM", "GINKA@GMAIL.COM", "AQAAAAIAAYagAAAAEE9GTtdaKvrQRhcB15Yg5iP7bLdrH6VlaOJgJGjsM+bbjU8behyEpSpfcMF85NsZUA==", null, false, "8ec35820-431c-495d-89e9-ca3bf7c1e1f3", false, "ginka@gmail.com", new Guid("de8fc69b-4306-4900-8c89-0db327d1b65d") },
                    { new Guid("4a26d76f-81b7-4082-8f3e-178b7c3a3025"), 0, new Guid("7d9c7f61-c5fe-4b6b-a193-9287e036572f"), new DateTime(2024, 12, 10, 23, 7, 12, 729, DateTimeKind.Local).AddTicks(6940), "12e85c19-4a3c-4401-8740-0f8af487ec72", "martin@gmail.com", false, "Martin", "0741124324", true, false, "Georgiev", false, null, "Ivanov", "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAIAAYagAAAAEEpMaz6h8839LYKE9z1s5ZWyKOsliVhIKeh6uviSZpdS0OH0akjmueSvHt06fVS3xQ==", null, false, "62989f85-2939-4add-b1d4-cfd11d28d3bc", false, "martin@gmail.com", new Guid("10d4b716-30e7-40b9-aa01-44625365ce19") },
                    { new Guid("719ecc8f-c52c-4cb3-bdbb-81a204c78844"), 0, new Guid("8afc42f4-b9ee-429a-9275-e4abceea0977"), new DateTime(2024, 12, 10, 23, 7, 12, 955, DateTimeKind.Local).AddTicks(4230), "c390e8af-6650-4c8a-a786-330841088165", "stamen@gmail.com", false, "Stamen", "7211053143", true, false, "Peev", false, null, "Georgiev", "STAMEN@GMAIL.COM", "STAMEN@GMAIL.COM", "AQAAAAIAAYagAAAAELMyCav2w1yJr4fJ5JonYEFf97bPg3hy8kDGMfxjwCp00R678wSevZ58Tp0vfKo12w==", null, false, "d587a812-7c24-4fb0-a1bb-681d56c2a0e8", false, "stamen@gmail.com", new Guid("856454cd-eaf3-4764-8495-cc2d3c105230") },
                    { new Guid("9f5ac8dd-e7ab-405b-9b9d-5d5c5fd9671c"), 0, new Guid("80a24610-0bae-400c-8225-d9d8636d7d12"), new DateTime(2024, 12, 10, 23, 7, 12, 917, DateTimeKind.Local).AddTicks(8510), "dfa74809-09d4-4511-b818-13006d39be27", "stefka@gmail.com", false, "Stefka", "9003021331", true, false, "Gineva", false, null, "Petkova", "STEFKA@GMAIL.COM", "STEFKA@GMAIL.COM", "AQAAAAIAAYagAAAAEBZKsjgvyAuTXVqTg5LN/Vuue7iru+IFMDbgWjYYVT1oh1wMdESQAmU3+MWV6w9nOg==", null, false, "d35f104c-56d3-48f9-961f-87236164229e", false, "stefka@gmail.com", new Guid("6435862d-9168-4e91-846e-821f00a1628a") },
                    { new Guid("a1103813-6533-4f6b-9226-20fba6c93318"), 0, new Guid("983cb0fe-f890-4974-a93f-5b009a0490bc"), new DateTime(2024, 12, 10, 23, 7, 12, 655, DateTimeKind.Local).AddTicks(6230), "8edafb8a-6ce3-47db-827f-289fea7d8acc", "ivan@gmail.com", false, "Ivan", "0141012442", true, false, "Ivanov", false, null, "Ivanov", "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAIAAYagAAAAEKsYJJvRyZRefg4MwNZ3NxW1qAPkpV+SSg+bQ78bcJEFD2VFjfNkQi0PEx6uw+Hm/A==", null, false, "fda3bd35-e129-4b3e-9322-41f3a7abc2b0", false, "ivan@gmail.com", new Guid("52f4a5b6-a496-44b7-b584-bfbc22b45bdd") },
                    { new Guid("aa5c635d-2f0a-4840-9ba4-401e5e682d7d"), 0, new Guid("aa51a218-c71e-41d5-9eed-08dc9c6b7cb5"), new DateTime(2024, 12, 10, 23, 7, 12, 804, DateTimeKind.Local).AddTicks(9820), "1dc69b22-67f3-4067-aedd-04299735aedc", "jivko@gmail.com", false, "Jivko", "1041124324", true, false, "Donev", false, null, "Vasilev", "JIVKO@GMAIL.COM", "JIVKO@GMAIL.COM", "AQAAAAIAAYagAAAAEGAF8yQjZ17g9WDmFbRKd1uEsyu3a517Ju0eDyW0wJ4On5XxoL1OTOVPmoRE1W75vA==", null, false, "77e9b654-3787-42d0-9fbd-37c9042c9d7c", false, "jivko@gmail.com", new Guid("80bb9df5-afc3-47cf-88fd-78b4342b1b89") },
                    { new Guid("b5e5fd1a-a3ff-487a-a3a6-a11b03a3cf5b"), 0, new Guid("a699d3e3-0538-4aa5-bbad-50f72bcc666e"), new DateTime(2024, 12, 10, 23, 7, 13, 66, DateTimeKind.Local).AddTicks(1190), "2b11591c-8872-4f0c-8f4d-ea0a90fb8ace", "boncho@gmail.com", false, "Boncho", "8006210887", true, false, "Dimitrov", false, null, "Dimitrov", "BONCHO@GMAIL.COM", "BONCHO@GMAIL.COM", "AQAAAAIAAYagAAAAELGwLj5KOZP4oFy4nu5KXrsQ6oU6yFtcoEosk+1LMLbQAgCPdzKlgmF6lKpcd5adbQ==", null, false, "c96711e7-dc99-418d-a5db-b81cc2b04416", false, "boncho@gmail.com", new Guid("629dc3d7-be76-40f3-b151-11769fd8cd90") },
                    { new Guid("b871cd1b-c4e2-4725-8a21-abbc1d4c305d"), 0, new Guid("52fd6e39-4adf-4a6c-a236-6f686ae0a769"), new DateTime(2024, 12, 10, 23, 7, 12, 842, DateTimeKind.Local).AddTicks(9110), "17bb7666-8e05-43d7-ac60-571c1b28fe56", "pencho@gmail.com", false, "Pencho", "0945161226", true, false, "Mihov", false, null, "Angelov", "PENCHO@GMAIL.COM", "PENCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEGo64IS4D+SxtXjJFm6eChqTzyQ+V9r8lsp3SILm20RrZhGR8YO+1dQr3MAfKKGgUA==", null, false, "cd4bf850-910e-4222-b0da-19c8a660ae91", false, "pencho@gmail.com", new Guid("9f9e330a-81e1-4ef4-a238-ac369940c8c3") },
                    { new Guid("c6303d6b-1b5d-47b8-ac36-b28c9363e2e4"), 0, new Guid("b5d9e4dd-8254-47ab-b422-62d79dc084e9"), new DateTime(2024, 12, 10, 23, 7, 12, 692, DateTimeKind.Local).AddTicks(4530), "ef57a50f-d635-4e29-ace3-b4ecd6f315f2", "gencho@gmail.com", false, "Gencho", "0543121244", true, false, "Ginev", false, null, "Petkov", "GENCHO@GMAIL.COM", "GENCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEPvssRrSRndIFZV+kD0lRkQU/Y8GIjykdGg3+/pB+cJQ7jACN6TLounhFoAr6x02YQ==", null, false, "8f28b0a5-d1b1-4977-8294-ca55e7e8d146", false, "gencho@gmail.com", new Guid("ee83a516-0fc4-4bb6-a97e-84c9a0e033b1") },
                    { new Guid("c78a8c24-0225-45da-82ff-0462e92fe43d"), 0, new Guid("c78a8c24-0225-45da-82ff-0462e92fe43d"), new DateTime(2024, 12, 10, 23, 7, 13, 103, DateTimeKind.Local).AddTicks(3530), "c6e14c1e-fc35-4534-954c-3f9cf00a2341", "admin@scholario.com", true, "Admin", "2452064114", true, false, "Adminov", false, null, "Adminov", "ADMIN@SCHOLARIO.COM", "ADMIN@SCHOLARIO.COM", "AQAAAAIAAYagAAAAEN+l/askyiKbpUZIVcGQh0FQruNu2asObwlEy0OGfFY/e6fY70GPR/X7yBrBJIQm6A==", null, false, "a55e7a5e-983b-455d-bc04-aa98fb9183bc", false, "admin@scholario.com", new Guid("c78a8c24-0225-45da-82ff-0462e92fe43d") },
                    { new Guid("e5f406ab-ad3d-450b-b6be-5c9e0a0c1f5c"), 0, new Guid("84fd6466-94f3-4321-9cec-5b759bdf920b"), new DateTime(2024, 12, 10, 23, 7, 13, 29, DateTimeKind.Local).AddTicks(2840), "b5bd20e5-e4b1-45ff-9108-9ab44972252a", "petar@gmail.com", false, "Petar", "8210045421", true, false, "Chonev", false, null, "Mladenov", "PETAR@GMAIL.COM", "PETAR@GMAIL.COM", "AQAAAAIAAYagAAAAEDa7RqgxzVfA+Kwfebl8lQMaL8piG9cR5EPB99Tw8LzPiKEI/wf/BEV5K1aBCA6avA==", null, false, "0a2b4bb6-ad20-4e41-ab0f-c91075275205", false, "petar@gmail.com", new Guid("28f89cee-e83f-4341-bf6c-821152f1b524") }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("105285af-3bb3-4256-b615-99bcfec6a72b"), 3, "Ginka", "0944174331", "Stoyanova", "Petrova", new Guid("de8fc69b-4306-4900-8c89-0db327d1b65d") },
                    { new Guid("52fd6e39-4adf-4a6c-a236-6f686ae0a769"), 5, "Pencho", "0945161226", "Mihov", "Angelov", new Guid("9f9e330a-81e1-4ef4-a238-ac369940c8c3") },
                    { new Guid("7d9c7f61-c5fe-4b6b-a193-9287e036572f"), 2, "Martin", "0741124324", "Georgiev", "Ivanov", new Guid("10d4b716-30e7-40b9-aa01-44625365ce19") },
                    { new Guid("983cb0fe-f890-4974-a93f-5b009a0490bc"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("52f4a5b6-a496-44b7-b584-bfbc22b45bdd") },
                    { new Guid("aa51a218-c71e-41d5-9eed-08dc9c6b7cb5"), 4, "Jivko", "1041124324", "Donev", "Vasilev", new Guid("80bb9df5-afc3-47cf-88fd-78b4342b1b89") },
                    { new Guid("b5d9e4dd-8254-47ab-b422-62d79dc084e9"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("ee83a516-0fc4-4bb6-a97e-84c9a0e033b1") },
                    { new Guid("b8db297b-d9f7-414b-9827-18b2fafdbbac"), 5, "Ruzha", "0852131993", "Veleva", "Todorova", new Guid("83a7d1c6-ae60-4a64-a43d-b7cafe6b5722") },
                    { new Guid("c0168b38-bc23-49bc-983a-c3f2c746e22d"), 4, "Diana", "1148061932", "Kostova", "Nedeva", new Guid("b78c8a5d-1282-45d9-96d6-3a34a92da0bd") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("556c352a-8ad8-4f8e-ad9a-028559a0e3bd"), "Stoyanka", "7105053113", "Peneva", "Doneva", null, 15, new Guid("42801f83-12c6-4a5a-8796-33f06f291611") },
                    { new Guid("80a24610-0bae-400c-8225-d9d8636d7d12"), "Stefka", "9003021331", "Gineva", "Petkova", null, 4, new Guid("6435862d-9168-4e91-846e-821f00a1628a") },
                    { new Guid("84fd6466-94f3-4321-9cec-5b759bdf920b"), "Petar", "8210045421", "Chonev", "Mladenov", null, 5, new Guid("28f89cee-e83f-4341-bf6c-821152f1b524") },
                    { new Guid("89320008-9462-4220-9aa5-bff33d4fddf5"), "Maria", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("1b57975b-6361-4038-aeaf-08403b518b45") },
                    { new Guid("8afc42f4-b9ee-429a-9275-e4abceea0977"), "Stamen", "7211053143", "Peev", "Georgiev", null, 14, new Guid("856454cd-eaf3-4764-8495-cc2d3c105230") },
                    { new Guid("a699d3e3-0538-4aa5-bbad-50f72bcc666e"), "Boncho", "8006210887", "Dimitrov", "Dimitrov", null, 9, new Guid("629dc3d7-be76-40f3-b151-11769fd8cd90") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("cc685e9d-f29e-415b-9620-aac09bafc3f9"), new Guid("2f25395d-8c7f-4737-9e4c-d163bb3ccfc8") },
                    { new Guid("cc685e9d-f29e-415b-9620-aac09bafc3f9"), new Guid("2fb904be-10b0-4c3b-a926-fb7ce5e1f81d") },
                    { new Guid("953a2f8f-536a-42b4-a2fc-a75836d187d9"), new Guid("3dd3ef79-eaea-4aa0-a571-e47e87fd5029") },
                    { new Guid("953a2f8f-536a-42b4-a2fc-a75836d187d9"), new Guid("4a26d76f-81b7-4082-8f3e-178b7c3a3025") },
                    { new Guid("cc685e9d-f29e-415b-9620-aac09bafc3f9"), new Guid("719ecc8f-c52c-4cb3-bdbb-81a204c78844") },
                    { new Guid("cc685e9d-f29e-415b-9620-aac09bafc3f9"), new Guid("9f5ac8dd-e7ab-405b-9b9d-5d5c5fd9671c") },
                    { new Guid("953a2f8f-536a-42b4-a2fc-a75836d187d9"), new Guid("a1103813-6533-4f6b-9226-20fba6c93318") },
                    { new Guid("953a2f8f-536a-42b4-a2fc-a75836d187d9"), new Guid("aa5c635d-2f0a-4840-9ba4-401e5e682d7d") },
                    { new Guid("cc685e9d-f29e-415b-9620-aac09bafc3f9"), new Guid("b5e5fd1a-a3ff-487a-a3a6-a11b03a3cf5b") },
                    { new Guid("953a2f8f-536a-42b4-a2fc-a75836d187d9"), new Guid("b871cd1b-c4e2-4725-8a21-abbc1d4c305d") },
                    { new Guid("953a2f8f-536a-42b4-a2fc-a75836d187d9"), new Guid("c6303d6b-1b5d-47b8-ac36-b28c9363e2e4") },
                    { new Guid("77d96249-67ff-4667-9d54-75487978d2d4"), new Guid("c78a8c24-0225-45da-82ff-0462e92fe43d") },
                    { new Guid("cc685e9d-f29e-415b-9620-aac09bafc3f9"), new Guid("e5f406ab-ad3d-450b-b6be-5c9e0a0c1f5c") }
                });

            migrationBuilder.InsertData(
                table: "TeachersClasses",
                columns: new[] { "ClassId", "TeacherId" },
                values: new object[,]
                {
                    { 5, new Guid("556c352a-8ad8-4f8e-ad9a-028559a0e3bd") },
                    { 1, new Guid("80a24610-0bae-400c-8225-d9d8636d7d12") },
                    { 2, new Guid("80a24610-0bae-400c-8225-d9d8636d7d12") },
                    { 4, new Guid("84fd6466-94f3-4321-9cec-5b759bdf920b") },
                    { 1, new Guid("89320008-9462-4220-9aa5-bff33d4fddf5") },
                    { 2, new Guid("89320008-9462-4220-9aa5-bff33d4fddf5") },
                    { 1, new Guid("8afc42f4-b9ee-429a-9275-e4abceea0977") },
                    { 2, new Guid("8afc42f4-b9ee-429a-9275-e4abceea0977") },
                    { 3, new Guid("8afc42f4-b9ee-429a-9275-e4abceea0977") },
                    { 4, new Guid("a699d3e3-0538-4aa5-bbad-50f72bcc666e") }
                });
        }
    }
}
