using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveSpecialities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Specialities",
                table: "Schools");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Specialities",
                table: "Schools",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "Specialities",
                value: "[1,2,4]");

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "Specialities",
                value: "[5,6,7]");

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3,
                column: "Specialities",
                value: "[2,1]");

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
    }
}
