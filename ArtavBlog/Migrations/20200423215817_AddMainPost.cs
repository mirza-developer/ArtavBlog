using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtavBlog.Migrations
{
    public partial class AddMainPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "UserRole",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "871585ca-d271-42f5-be36-6d2615288a20", "7f3bef38-1e16-4ba9-806c-0f5ae7e50d33" });

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "UserRole",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "871585ca-d271-42f5-be36-6d2615288a20", "c51ade30-98c9-4456-9871-03fcc996efb3" });

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "UserRole",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a8319d5b-df57-47f2-85f4-d98ba5fc2db6", "c51ade30-98c9-4456-9871-03fcc996efb3" });

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "Role",
                keyColumn: "Id",
                keyValue: "7f3bef38-1e16-4ba9-806c-0f5ae7e50d33");

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "Role",
                keyColumn: "Id",
                keyValue: "c51ade30-98c9-4456-9871-03fcc996efb3");

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "User",
                keyColumn: "Id",
                keyValue: "871585ca-d271-42f5-be36-6d2615288a20");

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "User",
                keyColumn: "Id",
                keyValue: "a8319d5b-df57-47f2-85f4-d98ba5fc2db6");

            migrationBuilder.AddColumn<bool>(
                name: "MainPost",
                schema: "Blog",
                table: "Post",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "7f3bef38-1e16-4ba9-806c-0f5ae7e50d33", "62d6db97-939c-4141-a64f-5995f09ead5e", "Admin", null },
                    { "c51ade30-98c9-4456-9871-03fcc996efb3", "3034682b-0e67-4688-bf67-9a5828021ae8", "User", null }
                });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateDateAndTime", "CreatorIdentityID", "Description", "Email", "EmailConfirmed", "IsDeleted", "LastModifiedDateAndTime", "LastModifierIdentityID", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "871585ca-d271-42f5-be36-6d2615288a20", 0, "3b505c1e-b57d-4280-80a5-1fe081ff2189", new DateTime(2020, 2, 22, 16, 39, 24, 940, DateTimeKind.Local).AddTicks(7880), "NOONE!", null, "ali.qader3@gmail.com", true, false, new DateTime(2020, 2, 22, 16, 39, 24, 936, DateTimeKind.Local).AddTicks(4670), "NOONE!", false, null, null, null, "AIDxfu5MI0g0BMHF1KfYyXjunVGDLv7+OPYo3Fiuw8B+OAs5KqPpgT6PtMFCKFwPNA==", null, false, "5e6dbb47-8a86-42b7-b507-ca38eb424e45", false, "admin" },
                    { "a8319d5b-df57-47f2-85f4-d98ba5fc2db6", 0, "978bcb4c-90b3-420e-8bcf-97c29174945f", new DateTime(2020, 2, 22, 16, 39, 24, 949, DateTimeKind.Local).AddTicks(5092), "NOONE!", null, "ali.qader3@gmail.com", true, false, new DateTime(2020, 2, 22, 16, 39, 24, 949, DateTimeKind.Local).AddTicks(5040), "NOONE!", false, null, null, null, "AOqdEo7ldRBl1mpumNjdo/6oQnft2g7txPqtFN19fBwijAPyOVCQARq6Ode67qxm/Q==", null, false, "b2ecaec5-b0d5-45d9-a2b3-4bc6114086e9", false, "user" }
                });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "871585ca-d271-42f5-be36-6d2615288a20", "7f3bef38-1e16-4ba9-806c-0f5ae7e50d33" });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "871585ca-d271-42f5-be36-6d2615288a20", "c51ade30-98c9-4456-9871-03fcc996efb3" });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a8319d5b-df57-47f2-85f4-d98ba5fc2db6", "c51ade30-98c9-4456-9871-03fcc996efb3" });
        }
    }
}
