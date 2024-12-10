using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class ReseedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
