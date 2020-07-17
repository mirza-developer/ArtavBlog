using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtavBlog.Migrations
{
    public partial class RemoveMainPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "UserRole",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "484c8c0c-4351-41ee-871b-30147a7bc881", "d1c7cb9e-2168-4ecb-8216-a1c92f9b5e7a" });

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "UserRole",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f0e3e93d-53d1-467f-b6b0-867d6f84cdf1", "979e925a-af4d-4fee-b12c-90d99d7648eb" });

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "UserRole",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f0e3e93d-53d1-467f-b6b0-867d6f84cdf1", "d1c7cb9e-2168-4ecb-8216-a1c92f9b5e7a" });

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "Role",
                keyColumn: "Id",
                keyValue: "979e925a-af4d-4fee-b12c-90d99d7648eb");

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "Role",
                keyColumn: "Id",
                keyValue: "d1c7cb9e-2168-4ecb-8216-a1c92f9b5e7a");

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "User",
                keyColumn: "Id",
                keyValue: "484c8c0c-4351-41ee-871b-30147a7bc881");

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "User",
                keyColumn: "Id",
                keyValue: "f0e3e93d-53d1-467f-b6b0-867d6f84cdf1");

            migrationBuilder.DropColumn(
                name: "MainPost",
                schema: "Blog",
                table: "Post");

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ff3094a-c744-41d9-b658-57237f5ae989", "ac77678c-b17d-47bd-b0a9-b6fbd9f51ae9", "Admin", null },
                    { "55e4c4c8-09bb-4484-a5bd-236e35ca26d4", "7cc548bf-2505-40ec-888f-2d43558489a2", "User", null }
                });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateDateAndTime", "CreatorIdentityID", "Description", "Email", "EmailConfirmed", "IsDeleted", "LastModifiedDateAndTime", "LastModifierIdentityID", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d44eebd9-89da-4d7c-b988-75cd73ec7735", 0, "9bc3993f-48de-4a31-8ca6-7f85cea71b62", new DateTime(2020, 4, 23, 16, 19, 4, 164, DateTimeKind.Local).AddTicks(2765), "NOONE!", null, "ali.qader3@gmail.com", true, false, new DateTime(2020, 4, 23, 16, 19, 4, 160, DateTimeKind.Local).AddTicks(7014), "NOONE!", false, null, null, null, "AHxrrVWtGX/2aljyFW0ETinBLNHYzYr2wtJt6UyYCFKa7msld9hohWoJ7D+LWgb+NQ==", null, false, "583cc444-8646-4a5f-95b5-3e31487c8679", false, "admin" },
                    { "7b2a688e-bd8d-48fa-aeab-c51c513da2e1", 0, "90cd9c64-9c7a-47ae-9092-3f2ffc9431d2", new DateTime(2020, 4, 23, 16, 19, 4, 172, DateTimeKind.Local).AddTicks(7777), "NOONE!", null, "ali.qader3@gmail.com", true, false, new DateTime(2020, 4, 23, 16, 19, 4, 172, DateTimeKind.Local).AddTicks(7735), "NOONE!", false, null, null, null, "AIAU+gCyZUkqG3dKxpGByxoiP9EHi/Axp4r/WL6ltLreJi9wf61oaGE5SJnhvlFWVw==", null, false, "e0c75bc5-b8f3-4fc2-811f-2f12b2b3fd61", false, "user" }
                });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "d44eebd9-89da-4d7c-b988-75cd73ec7735", "0ff3094a-c744-41d9-b658-57237f5ae989" });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "d44eebd9-89da-4d7c-b988-75cd73ec7735", "55e4c4c8-09bb-4484-a5bd-236e35ca26d4" });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "7b2a688e-bd8d-48fa-aeab-c51c513da2e1", "55e4c4c8-09bb-4484-a5bd-236e35ca26d4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "UserRole",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7b2a688e-bd8d-48fa-aeab-c51c513da2e1", "55e4c4c8-09bb-4484-a5bd-236e35ca26d4" });

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "UserRole",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d44eebd9-89da-4d7c-b988-75cd73ec7735", "0ff3094a-c744-41d9-b658-57237f5ae989" });

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "UserRole",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d44eebd9-89da-4d7c-b988-75cd73ec7735", "55e4c4c8-09bb-4484-a5bd-236e35ca26d4" });

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "Role",
                keyColumn: "Id",
                keyValue: "0ff3094a-c744-41d9-b658-57237f5ae989");

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "Role",
                keyColumn: "Id",
                keyValue: "55e4c4c8-09bb-4484-a5bd-236e35ca26d4");

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "User",
                keyColumn: "Id",
                keyValue: "7b2a688e-bd8d-48fa-aeab-c51c513da2e1");

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "User",
                keyColumn: "Id",
                keyValue: "d44eebd9-89da-4d7c-b988-75cd73ec7735");

            migrationBuilder.AddColumn<bool>(
                name: "MainPost",
                schema: "Blog",
                table: "Post",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "979e925a-af4d-4fee-b12c-90d99d7648eb", "4de714d1-f2b5-4abf-bc94-2a9fd4b4b412", "Admin", null },
                    { "d1c7cb9e-2168-4ecb-8216-a1c92f9b5e7a", "5f149af1-3d73-4909-ac63-882a2d9bad4b", "User", null }
                });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateDateAndTime", "CreatorIdentityID", "Description", "Email", "EmailConfirmed", "IsDeleted", "LastModifiedDateAndTime", "LastModifierIdentityID", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "f0e3e93d-53d1-467f-b6b0-867d6f84cdf1", 0, "c1902a76-42e2-4ca3-beb7-965d86f988fc", new DateTime(2020, 4, 23, 14, 58, 16, 882, DateTimeKind.Local).AddTicks(7280), "NOONE!", null, "ali.qader3@gmail.com", true, false, new DateTime(2020, 4, 23, 14, 58, 16, 878, DateTimeKind.Local).AddTicks(6110), "NOONE!", false, null, null, null, "ALacpdVLroXrj05VFhPo55LENpRnuX9VXoP/Cp0jBVSYQTHEhkzkeCRfuYG1Q71tNA==", null, false, "9f05172c-a7f2-4e04-a859-b9b39f38f637", false, "admin" },
                    { "484c8c0c-4351-41ee-871b-30147a7bc881", 0, "87d1aae1-bb0c-4e6e-bb99-b6bb5b309043", new DateTime(2020, 4, 23, 14, 58, 16, 893, DateTimeKind.Local).AddTicks(997), "NOONE!", null, "ali.qader3@gmail.com", true, false, new DateTime(2020, 4, 23, 14, 58, 16, 893, DateTimeKind.Local).AddTicks(926), "NOONE!", false, null, null, null, "ALqK5rgE36q4pvdHv5wN3Sg75dMmOQdrxeQSc5p6QwKGlV90bQ6vue0MO07mvf8nXg==", null, false, "b293a27c-c8f5-4bba-808d-e6d653b9657d", false, "user" }
                });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "f0e3e93d-53d1-467f-b6b0-867d6f84cdf1", "979e925a-af4d-4fee-b12c-90d99d7648eb" });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "f0e3e93d-53d1-467f-b6b0-867d6f84cdf1", "d1c7cb9e-2168-4ecb-8216-a1c92f9b5e7a" });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "484c8c0c-4351-41ee-871b-30147a7bc881", "d1c7cb9e-2168-4ecb-8216-a1c92f9b5e7a" });
        }
    }
}
