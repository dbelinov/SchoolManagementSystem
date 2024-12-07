﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGradeProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("530a6548-2cbb-4fea-a129-d6963d870f1b"), new Guid("2c3bf96d-8520-488a-acc5-49247d999d35") });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("77c36d3b-0272-461a-b922-48921204c167"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c066bca0-bb05-4277-bcad-0424b57fb4cd"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("6c81cf63-38a6-4dda-9673-386378ca462d"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("530a6548-2cbb-4fea-a129-d6963d870f1b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2c3bf96d-8520-488a-acc5-49247d999d35"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("d35316ee-60a4-4ddc-a8c8-33147d60c60e"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AppId", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IdNumber", "IsAuthenticated", "IsGuest", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VerificationKey" },
                values: new object[] { new Guid("05d60328-71f5-484b-b328-b96c02067d9f"), 0, new Guid("05d60328-71f5-484b-b328-b96c02067d9f"), new DateTime(2024, 12, 5, 21, 27, 0, 596, DateTimeKind.Local).AddTicks(3940), "cda38b13-f1a9-4a8b-842f-4976b3e8d05c", "admin@scholario.com", true, "Admin", "2452064114", true, false, "Adminov", false, null, "Adminov", "ADMIN@SCHOLARIO.COM", "ADMIN@SCHOLARIO.COM", "AQAAAAIAAYagAAAAEIeqx7vVBn1TdB+iMgNZ9aZIi5UPxFGtDKOcEG209DMgOH9yU4jJ16F3gyUMArqAcg==", null, false, "c7a69bf1-2ce2-4e09-923f-9b09c646e484", false, "admin@scholario.com", new Guid("05d60328-71f5-484b-b328-b96c02067d9f") });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("9942fe04-746d-42c7-aa01-ae93171dc24d"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("edbe059f-fb21-4ced-81eb-6afcf527166f") },
                    { new Guid("ed139db0-65f6-4e1a-8029-b07f672111b9"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("94208c41-56eb-4370-9fc2-71edf5cfb826") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[] { new Guid("72d33ad0-eee3-4ade-8e03-64a102e12e5b"), "Maria", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("fbb6a0ad-5377-4165-a10c-8414c9c62a26") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("d35316ee-60a4-4ddc-a8c8-33147d60c60e"), new Guid("05d60328-71f5-484b-b328-b96c02067d9f") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d35316ee-60a4-4ddc-a8c8-33147d60c60e"), new Guid("05d60328-71f5-484b-b328-b96c02067d9f") });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("9942fe04-746d-42c7-aa01-ae93171dc24d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ed139db0-65f6-4e1a-8029-b07f672111b9"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("72d33ad0-eee3-4ade-8e03-64a102e12e5b"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d35316ee-60a4-4ddc-a8c8-33147d60c60e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("05d60328-71f5-484b-b328-b96c02067d9f"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("530a6548-2cbb-4fea-a129-d6963d870f1b"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AppId", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IdNumber", "IsAuthenticated", "IsGuest", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VerificationKey" },
                values: new object[] { new Guid("2c3bf96d-8520-488a-acc5-49247d999d35"), 0, new Guid("2c3bf96d-8520-488a-acc5-49247d999d35"), new DateTime(2024, 12, 5, 20, 40, 46, 405, DateTimeKind.Local).AddTicks(1820), "81be4c09-b377-4acd-ba1f-a7a7e254932c", "admin@scholario.com", true, "Admin", "2452064114", true, false, "Adminov", false, null, "Adminov", "ADMIN@SCHOLARIO.COM", "ADMIN@SCHOLARIO.COM", "AQAAAAIAAYagAAAAEKoFkogIonnrj49f6v+CzqrNoUbicm1ECtM7adQ+f+lLqe65rK6w67Qo56gNl5IidQ==", null, false, "d542c6c1-c8a5-4793-9c30-64e8782ff256", false, "admin@scholario.com", new Guid("2c3bf96d-8520-488a-acc5-49247d999d35") });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "FirstName", "IdNumber", "LastName", "MiddleName", "VerificationKey" },
                values: new object[,]
                {
                    { new Guid("77c36d3b-0272-461a-b922-48921204c167"), 1, "Gencho", "0543121244", "Ginev", "Petkov", new Guid("cc67a73a-3665-4606-8270-841affe14ca7") },
                    { new Guid("c066bca0-bb05-4277-bcad-0424b57fb4cd"), 1, "Ivan", "0141012442", "Ivanov", "Ivanov", new Guid("50cb4c81-981e-44f0-b502-1d0fc266a7a1") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "IdNumber", "LastName", "MiddleName", "SchoolId", "Subject", "VerificationKey" },
                values: new object[] { new Guid("6c81cf63-38a6-4dda-9673-386378ca462d"), "Maria", "8008089119", "Petrova", "Ivanova", null, 1, new Guid("1a1b44bb-2dd2-4071-9f7a-82bfd6e13962") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("530a6548-2cbb-4fea-a129-d6963d870f1b"), new Guid("2c3bf96d-8520-488a-acc5-49247d999d35") });
        }
    }
}