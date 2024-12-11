using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("29145607-ee1c-4029-b9c8-acd74369af51"), new Guid("2af1622e-0207-40b2-86ae-1ba0c315b92d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("98991030-82f4-4140-81aa-184a3aefdf6b"), new Guid("450a7685-d2a9-44ed-83f3-9dea3e581001") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("29145607-ee1c-4029-b9c8-acd74369af51"), new Guid("4b93c160-f4a5-49c3-9515-1fe674f586b3") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("98991030-82f4-4140-81aa-184a3aefdf6b"), new Guid("5cc83783-7b01-4615-af5c-6d91aeaa6a4d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("29145607-ee1c-4029-b9c8-acd74369af51"), new Guid("72905393-6010-4fe8-aee0-30b7c86fb8a2") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("559177f3-06ab-457c-80ef-f10e6cbd9904"), new Guid("734fb776-18d9-4887-9c51-8c780a1c10c1") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("29145607-ee1c-4029-b9c8-acd74369af51"), new Guid("7e090d05-998c-4f78-bae2-6987dc8f2f2a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("98991030-82f4-4140-81aa-184a3aefdf6b"), new Guid("9ea54fb5-ac5d-4a7a-9c2a-fa613f73cb71") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("98991030-82f4-4140-81aa-184a3aefdf6b"), new Guid("a9e44e08-4db0-44e9-83fe-2830b4d35fc7") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("29145607-ee1c-4029-b9c8-acd74369af51"), new Guid("b7a12006-3c4b-491a-8919-61e5db054fe4") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("98991030-82f4-4140-81aa-184a3aefdf6b"), new Guid("d8665fb6-5acb-4038-855e-7057fa11f533") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("29145607-ee1c-4029-b9c8-acd74369af51"), new Guid("e4fb28aa-5b5e-43ff-8db8-40c440c04e43") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("98991030-82f4-4140-81aa-184a3aefdf6b"), new Guid("f0c4f887-1c30-406c-9139-aa335bd358fd") });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("0326e745-c79d-409f-bb77-9ae389374b99"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("16e87d2e-73a7-45ff-806a-a21a17fe1e9e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40ef009d-e144-40e2-bdcc-fc5a055d7626"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("4da28e25-3dbb-4b6c-be20-e3d5f57444aa"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("4fa85c92-fc73-42a6-bc26-ce00728c6724"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("7b128a92-4016-43e8-b4bc-5683107e0da7"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d93be197-4ad6-440d-b0eb-fae09d14637c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fc0acd70-bebb-47d1-bedf-d84599c2e7aa"));

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("108de0ae-1b01-4a4b-9b19-376b1dfad843") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("108de0ae-1b01-4a4b-9b19-376b1dfad843") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 3, new Guid("108de0ae-1b01-4a4b-9b19-376b1dfad843") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("2ae480a1-ecb8-45f6-84f8-478501a0eab3") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("2ae480a1-ecb8-45f6-84f8-478501a0eab3") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 4, new Guid("38e4e0a1-36c9-4b8f-8aec-4530238e68d3") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 5, new Guid("92dbab9c-7104-4082-8015-68aa45a3d099") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 4, new Guid("b148220f-f8ee-40ec-8a61-4f8d4e81722f") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 1, new Guid("c9c8a4f2-adba-47d4-af81-3956a574c1de") });

            migrationBuilder.DeleteData(
                table: "TeachersClasses",
                keyColumns: new[] { "ClassId", "TeacherId" },
                keyValues: new object[] { 2, new Guid("c9c8a4f2-adba-47d4-af81-3956a574c1de") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("29145607-ee1c-4029-b9c8-acd74369af51"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("559177f3-06ab-457c-80ef-f10e6cbd9904"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("98991030-82f4-4140-81aa-184a3aefdf6b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2af1622e-0207-40b2-86ae-1ba0c315b92d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("450a7685-d2a9-44ed-83f3-9dea3e581001"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4b93c160-f4a5-49c3-9515-1fe674f586b3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5cc83783-7b01-4615-af5c-6d91aeaa6a4d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72905393-6010-4fe8-aee0-30b7c86fb8a2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("734fb776-18d9-4887-9c51-8c780a1c10c1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7e090d05-998c-4f78-bae2-6987dc8f2f2a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9ea54fb5-ac5d-4a7a-9c2a-fa613f73cb71"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a9e44e08-4db0-44e9-83fe-2830b4d35fc7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b7a12006-3c4b-491a-8919-61e5db054fe4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d8665fb6-5acb-4038-855e-7057fa11f533"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e4fb28aa-5b5e-43ff-8db8-40c440c04e43"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f0c4f887-1c30-406c-9139-aa335bd358fd"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("108de0ae-1b01-4a4b-9b19-376b1dfad843"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("2ae480a1-ecb8-45f6-84f8-478501a0eab3"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("38e4e0a1-36c9-4b8f-8aec-4530238e68d3"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("92dbab9c-7104-4082-8015-68aa45a3d099"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("b148220f-f8ee-40ec-8a61-4f8d4e81722f"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("c9c8a4f2-adba-47d4-af81-3956a574c1de"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("29145607-ee1c-4029-b9c8-acd74369af51"), null, "Teacher", "TEACHER" },
                    { new Guid("559177f3-06ab-457c-80ef-f10e6cbd9904"), null, "Admin", "ADMIN" },
                    { new Guid("98991030-82f4-4140-81aa-184a3aefdf6b"), null, "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AppId", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IdNumber", "IsAuthenticated", "IsGuest", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("2af1622e-0207-40b2-86ae-1ba0c315b92d"), 0, new Guid("92dbab9c-7104-4082-8015-68aa45a3d099"), new DateTime(2024, 12, 11, 4, 25, 0, 281, DateTimeKind.Local).AddTicks(4400), "bc91398a-ce5e-4ce4-b08c-e1fc83422067", "stoyanka@gmail.com", false, "Stoyanka", "7105053113", true, false, "Peneva", false, null, "Doneva", "STOYANKA@GMAIL.COM", "STOYANKA@GMAIL.COM", "AQAAAAIAAYagAAAAEKvCihXBW6cczTHkq5jSXNWfhsNtqtAMRhFJlYzzusJiA6b5mmu5bLABtQl1C9b/HA==", null, false, "46a66bb4-60f2-49f4-b309-1c707738dacf", false, "stoyanka@gmail.com", new Guid("afecca87-4967-4e59-ae85-21828cfee9ef") },
                    { new Guid("450a7685-d2a9-44ed-83f3-9dea3e581001"), 0, new Guid("fc0acd70-bebb-47d1-bedf-d84599c2e7aa"), new DateTime(2024, 12, 11, 4, 25, 0, 24, DateTimeKind.Local).AddTicks(6510), "7168fa25-0da9-4f93-8244-310cc1d42710", "martin@gmail.com", false, "Martin", "0741124324", true, false, "Georgiev", false, null, "Ivanov", "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAIAAYagAAAAEM+kNKfr0QBSf+b0OoPzq3cv+8GSUVjV0iUtIIjONfK8r+sTpCcK2gHgw43HVNqdHQ==", null, false, "5a14a2d3-6c07-4519-b2b0-cf2ae68092b4", false, "martin@gmail.com", new Guid("4011caaa-1166-4a21-860e-a757bfee8664") },
                    { new Guid("4b93c160-f4a5-49c3-9515-1fe674f586b3"), 0, new Guid("c9c8a4f2-adba-47d4-af81-3956a574c1de"), new DateTime(2024, 12, 11, 4, 25, 0, 208, DateTimeKind.Local).AddTicks(3700), "7f992c54-d25a-4c02-a877-d9432e70a4de", "stefka@gmail.com", false, "Stefka", "9003021331", true, false, "Gineva", false, null, "Petkova", "STEFKA@GMAIL.COM", "STEFKA@GMAIL.COM", "AQAAAAIAAYagAAAAEML15ayWyjuIj2m4vLNkFy8o5n6d8H3lJ/n2iy9kx6SFRp7i+WDHT205I/EMyA4B+Q==", null, false, "0dea5f84-3811-4140-bbcf-0662de915ac2", false, "stefka@gmail.com", new Guid("3e5273f0-3f0a-43b9-957d-ac0841ff0bc0") },
                    { new Guid("5cc83783-7b01-4615-af5c-6d91aeaa6a4d"), 0, new Guid("40ef009d-e144-40e2-bdcc-fc5a055d7626"), new DateTime(2024, 12, 11, 4, 25, 0, 61, DateTimeKind.Local).AddTicks(9540), "1805b96f-6043-4ad3-983f-4829fa4ad2aa", "ginka@gmail.com", false, "Ginka", "0944174331", true, false, "Stoyanova", false, null, "Petrova", "GINKA@GMAIL.COM", "GINKA@GMAIL.COM", "AQAAAAIAAYagAAAAEKr1DoHQMGgSNOepwLwdTH0ioC/s6TXxGBxuim26iNZFCZLYePE80G2oF+uYI5obRg==", null, false, "539e353a-40bf-47b1-b116-546d54d043c7", false, "ginka@gmail.com", new Guid("45deb74a-c923-41cc-9b15-a707ed3bed9b") },
                    { new Guid("72905393-6010-4fe8-aee0-30b7c86fb8a2"), 0, new Guid("38e4e0a1-36c9-4b8f-8aec-4530238e68d3"), new DateTime(2024, 12, 11, 4, 25, 0, 317, DateTimeKind.Local).AddTicks(5430), "dda514f3-8b6d-42b3-9d43-53dd4da225d7", "petar@gmail.com", false, "Petar", "8210045421", true, false, "Chonev", false, null, "Mladenov", "PETAR@GMAIL.COM", "PETAR@GMAIL.COM", "AQAAAAIAAYagAAAAEBhVN6CYGs0bpzhXLZIBxGYfWR1q0S7iHeWEWBJTmJOmOrWrKD9w36Qi6WTlGRxWFQ==", null, false, "ff85146f-419b-4d28-952d-b343bf944ffd", false, "petar@gmail.com", new Guid("b29250a6-824a-4281-8410-1dd2e35e54a1") },
                    { new Guid("734fb776-18d9-4887-9c51-8c780a1c10c1"), 0, new Guid("734fb776-18d9-4887-9c51-8c780a1c10c1"), new DateTime(2024, 12, 11, 4, 25, 0, 389, DateTimeKind.Local).AddTicks(1460), "28af33a0-2a88-48c3-b8cc-4c69d28c7017", "admin@scholario.com", true, "Admin", "2452064114", true, false, "Adminov", false, null, "Adminov", "ADMIN@SCHOLARIO.COM", "ADMIN@SCHOLARIO.COM", "AQAAAAIAAYagAAAAEPNOoIZkgEwJheIKLsz14Xm2gXfJbgOVbU9AtPwzLTkhxLrf8RFrit8DspR7MwylwQ==", null, false, "c671f5b5-7686-4054-973a-1c0dc795e871", false, "admin@scholario.com", new Guid("734fb776-18d9-4887-9c51-8c780a1c10c1") },
                    { new Guid("7e090d05-998c-4f78-bae2-6987dc8f2f2a"), 0, new Guid("b148220f-f8ee-40ec-8a61-4f8d4e81722f"), new DateTime(2024, 12, 11, 4, 25, 0, 353, DateTimeKind.Local).AddTicks(5230), "3267e3e4-c2e8-4f00-b524-a950bc172682", "boncho@gmail.com", false, "Boncho", "8006210887", true, false, "Dimitrov", false, null, "Dimitrov", "BONCHO@GMAIL.COM", "BONCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEPmPX59/2153rqZtReX6QUlBWd5hvhJ/XIi6GYuhBwmglmLSc8x/x0Srsoa0AUTusg==", null, false, "0ecb29a9-9a86-42c7-82dd-75c3e1abe1ea", false, "boncho@gmail.com", new Guid("97b12d1e-9ab8-489d-9d0f-9b1eec82d358") },
                    { new Guid("9ea54fb5-ac5d-4a7a-9c2a-fa613f73cb71"), 0, new Guid("16e87d2e-73a7-45ff-806a-a21a17fe1e9e"), new DateTime(2024, 12, 11, 4, 24, 59, 988, DateTimeKind.Local).AddTicks(7250), "8b78919f-c070-49f0-a37e-f87fab66c80f", "gencho@gmail.com", false, "Gencho", "0543121244", true, false, "Ginev", false, null, "Petkov", "GENCHO@GMAIL.COM", "GENCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEHDvcv2BYP9RUO73FPEHuZtB6uf3yNUdioCkLXmXumNvLiaw/KYHeWJYinFVotbqjw==", null, false, "d08dbb0b-5422-4ebc-bb5e-30575e1dfd93", false, "gencho@gmail.com", new Guid("07309ca7-2a10-4597-bafb-fcbe93241f31") },
                    { new Guid("a9e44e08-4db0-44e9-83fe-2830b4d35fc7"), 0, new Guid("0326e745-c79d-409f-bb77-9ae389374b99"), new DateTime(2024, 12, 11, 4, 24, 59, 953, DateTimeKind.Local).AddTicks(4480), "0a175427-e301-44a6-9098-447d2322c33b", "ivan@gmail.com", false, "Ivan", "0141012442", true, false, "Ivanov", false, null, "Ivanov", "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAIAAYagAAAAEJzgbQJU0cm3WjNGR23k1n5lnFo526E4MGho6fL76sLisE0JyXpO6iLiUMvGE2z5xg==", null, false, "51b533c4-1626-49f3-8a72-29e2fd47fe6d", false, "ivan@gmail.com", new Guid("8fb1e105-5617-43fb-b5f5-6a16d4291442") },
                    { new Guid("b7a12006-3c4b-491a-8919-61e5db054fe4"), 0, new Guid("2ae480a1-ecb8-45f6-84f8-478501a0eab3"), new DateTime(2024, 12, 11, 4, 25, 0, 171, DateTimeKind.Local).AddTicks(7110), "3ade3dbb-fa24-43ce-bf75-4b47cff8501a", "maria@gmail.com", false, "Maria", "8008089119", true, false, "Petrova", false, null, "Ivanova", "MARIA@GMAIL.COM", "MARIA@GMAIL.COM", "AQAAAAIAAYagAAAAECv8Dl26UH+CX8CBQR7J7epkvNXj7YvLDSHIaKfouapl9S/FfSllqVOdQ4f9ocYsmA==", null, false, "7d824925-9bfb-46b1-92e2-41962c9de32f", false, "maria@gmail.com", new Guid("cd87c41a-5186-4b3a-b016-b5ae2318a673") },
                    { new Guid("d8665fb6-5acb-4038-855e-7057fa11f533"), 0, new Guid("d93be197-4ad6-440d-b0eb-fae09d14637c"), new DateTime(2024, 12, 11, 4, 25, 0, 98, DateTimeKind.Local).AddTicks(7890), "d78c00d8-aa56-4989-9959-dba720a5eefa", "jivko@gmail.com", false, "Jivko", "1041124324", true, false, "Donev", false, null, "Vasilev", "JIVKO@GMAIL.COM", "JIVKO@GMAIL.COM", "AQAAAAIAAYagAAAAEJqWI9K3U44Wuc4xdCJP8A0cNTVr+dNU1YpAlJzGt9BLk6o5ZS3FAnGXhieJX118XA==", null, false, "301252e9-61ca-4b0f-b86a-44a32686d108", false, "jivko@gmail.com", new Guid("7fa37445-2450-447b-8cab-15e7ab6ef72b") },
                    { new Guid("e4fb28aa-5b5e-43ff-8db8-40c440c04e43"), 0, new Guid("108de0ae-1b01-4a4b-9b19-376b1dfad843"), new DateTime(2024, 12, 11, 4, 25, 0, 245, DateTimeKind.Local).AddTicks(150), "cfc68818-5e52-441a-8a4d-c280501f1587", "stamen@gmail.com", false, "Stamen", "7211053143", true, false, "Peev", false, null, "Georgiev", "STAMEN@GMAIL.COM", "STAMEN@GMAIL.COM", "AQAAAAIAAYagAAAAEKUR/8+qjcZqir6KO+Z/Sdg4kDSXBaOWtZjfrhFVTjlvvIGgNf6XF/uCJsc1umHCvA==", null, false, "03edc2e9-468b-4958-8a0b-089016a72936", false, "stamen@gmail.com", new Guid("e1999a4a-54b4-4649-96ab-920e17b61804") },
                    { new Guid("f0c4f887-1c30-406c-9139-aa335bd358fd"), 0, new Guid("4da28e25-3dbb-4b6c-be20-e3d5f57444aa"), new DateTime(2024, 12, 11, 4, 25, 0, 135, DateTimeKind.Local).AddTicks(1410), "152320f1-ce83-4a64-83f8-b995a10c70d4", "pencho@gmail.com", false, "Pencho", "0945161226", true, false, "Mihov", false, null, "Angelov", "PENCHO@GMAIL.COM", "PENCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEMQ7XkIUflAFpmgVtMZEg1t3n6Ykkj9UXeFD9czvPsAA2wcXt3//pj4fKXcvcO/88A==", null, false, "ff675605-9cef-44cb-979e-d1260102947c", false, "pencho@gmail.com", new Guid("5bb0264d-018b-4517-84fc-837a40a1b1da") }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("0326e745-c79d-409f-bb77-9ae389374b99"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("8fb1e105-5617-43fb-b5f5-6a16d4291442") },
                    { new Guid("16e87d2e-73a7-45ff-806a-a21a17fe1e9e"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("07309ca7-2a10-4597-bafb-fcbe93241f31") },
                    { new Guid("40ef009d-e144-40e2-bdcc-fc5a055d7626"), 3, "Ginka", "0944174331", "Stoyanova", "Petrova", new Guid("45deb74a-c923-41cc-9b15-a707ed3bed9b") },
                    { new Guid("4da28e25-3dbb-4b6c-be20-e3d5f57444aa"), 5, "Pencho", "0945161226", "Mihov", "Angelov", new Guid("5bb0264d-018b-4517-84fc-837a40a1b1da") },
                    { new Guid("4fa85c92-fc73-42a6-bc26-ce00728c6724"), 5, "Ruzha", "0852131993", "Veleva", "Todorova", new Guid("56251a81-8190-4e96-bab3-b6edcce34e63") },
                    { new Guid("7b128a92-4016-43e8-b4bc-5683107e0da7"), 4, "Diana", "1148061932", "Kostova", "Nedeva", new Guid("f4797d43-36e3-467d-b8a3-2b503625e031") },
                    { new Guid("d93be197-4ad6-440d-b0eb-fae09d14637c"), 4, "Jivko", "1041124324", "Donev", "Vasilev", new Guid("7fa37445-2450-447b-8cab-15e7ab6ef72b") },
                    { new Guid("fc0acd70-bebb-47d1-bedf-d84599c2e7aa"), 2, "Martin", "0741124324", "Georgiev", "Ivanov", new Guid("4011caaa-1166-4a21-860e-a757bfee8664") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("108de0ae-1b01-4a4b-9b19-376b1dfad843"), "Stamen", "7211053143", "Peev", "Georgiev", null, 14, new Guid("e1999a4a-54b4-4649-96ab-920e17b61804") },
                    { new Guid("2ae480a1-ecb8-45f6-84f8-478501a0eab3"), "Maria", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("cd87c41a-5186-4b3a-b016-b5ae2318a673") },
                    { new Guid("38e4e0a1-36c9-4b8f-8aec-4530238e68d3"), "Petar", "8210045421", "Chonev", "Mladenov", null, 5, new Guid("b29250a6-824a-4281-8410-1dd2e35e54a1") },
                    { new Guid("92dbab9c-7104-4082-8015-68aa45a3d099"), "Stoyanka", "7105053113", "Peneva", "Doneva", null, 15, new Guid("afecca87-4967-4e59-ae85-21828cfee9ef") },
                    { new Guid("b148220f-f8ee-40ec-8a61-4f8d4e81722f"), "Boncho", "8006210887", "Dimitrov", "Dimitrov", null, 9, new Guid("97b12d1e-9ab8-489d-9d0f-9b1eec82d358") },
                    { new Guid("c9c8a4f2-adba-47d4-af81-3956a574c1de"), "Stefka", "9003021331", "Gineva", "Petkova", null, 4, new Guid("3e5273f0-3f0a-43b9-957d-ac0841ff0bc0") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("29145607-ee1c-4029-b9c8-acd74369af51"), new Guid("2af1622e-0207-40b2-86ae-1ba0c315b92d") },
                    { new Guid("98991030-82f4-4140-81aa-184a3aefdf6b"), new Guid("450a7685-d2a9-44ed-83f3-9dea3e581001") },
                    { new Guid("29145607-ee1c-4029-b9c8-acd74369af51"), new Guid("4b93c160-f4a5-49c3-9515-1fe674f586b3") },
                    { new Guid("98991030-82f4-4140-81aa-184a3aefdf6b"), new Guid("5cc83783-7b01-4615-af5c-6d91aeaa6a4d") },
                    { new Guid("29145607-ee1c-4029-b9c8-acd74369af51"), new Guid("72905393-6010-4fe8-aee0-30b7c86fb8a2") },
                    { new Guid("559177f3-06ab-457c-80ef-f10e6cbd9904"), new Guid("734fb776-18d9-4887-9c51-8c780a1c10c1") },
                    { new Guid("29145607-ee1c-4029-b9c8-acd74369af51"), new Guid("7e090d05-998c-4f78-bae2-6987dc8f2f2a") },
                    { new Guid("98991030-82f4-4140-81aa-184a3aefdf6b"), new Guid("9ea54fb5-ac5d-4a7a-9c2a-fa613f73cb71") },
                    { new Guid("98991030-82f4-4140-81aa-184a3aefdf6b"), new Guid("a9e44e08-4db0-44e9-83fe-2830b4d35fc7") },
                    { new Guid("29145607-ee1c-4029-b9c8-acd74369af51"), new Guid("b7a12006-3c4b-491a-8919-61e5db054fe4") },
                    { new Guid("98991030-82f4-4140-81aa-184a3aefdf6b"), new Guid("d8665fb6-5acb-4038-855e-7057fa11f533") },
                    { new Guid("29145607-ee1c-4029-b9c8-acd74369af51"), new Guid("e4fb28aa-5b5e-43ff-8db8-40c440c04e43") },
                    { new Guid("98991030-82f4-4140-81aa-184a3aefdf6b"), new Guid("f0c4f887-1c30-406c-9139-aa335bd358fd") }
                });

            migrationBuilder.InsertData(
                table: "TeachersClasses",
                columns: new[] { "ClassId", "TeacherId" },
                values: new object[,]
                {
                    { 1, new Guid("108de0ae-1b01-4a4b-9b19-376b1dfad843") },
                    { 2, new Guid("108de0ae-1b01-4a4b-9b19-376b1dfad843") },
                    { 3, new Guid("108de0ae-1b01-4a4b-9b19-376b1dfad843") },
                    { 1, new Guid("2ae480a1-ecb8-45f6-84f8-478501a0eab3") },
                    { 2, new Guid("2ae480a1-ecb8-45f6-84f8-478501a0eab3") },
                    { 4, new Guid("38e4e0a1-36c9-4b8f-8aec-4530238e68d3") },
                    { 5, new Guid("92dbab9c-7104-4082-8015-68aa45a3d099") },
                    { 4, new Guid("b148220f-f8ee-40ec-8a61-4f8d4e81722f") },
                    { 1, new Guid("c9c8a4f2-adba-47d4-af81-3956a574c1de") },
                    { 2, new Guid("c9c8a4f2-adba-47d4-af81-3956a574c1de") }
                });
        }
    }
}
