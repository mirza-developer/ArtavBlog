using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtavBlog.Migrations
{
    public partial class AddUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "UserRole",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f3856f7a-90a0-4b0b-a2ca-5de567bdb48c", "a7f7642b-af6a-4874-ae59-28e06a435208" });

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "UserRole",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f3856f7a-90a0-4b0b-a2ca-5de567bdb48c", "db3465e7-5817-4b2c-9552-b654d99a987b" });

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "Role",
                keyColumn: "Id",
                keyValue: "a7f7642b-af6a-4874-ae59-28e06a435208");

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "Role",
                keyColumn: "Id",
                keyValue: "db3465e7-5817-4b2c-9552-b654d99a987b");

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "User",
                keyColumn: "Id",
                keyValue: "f3856f7a-90a0-4b0b-a2ca-5de567bdb48c");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "db3465e7-5817-4b2c-9552-b654d99a987b", "7177198a-2a7e-471f-a6a8-cb822d62692f", "Admin", null });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a7f7642b-af6a-4874-ae59-28e06a435208", "6f8cec70-29b4-4235-b004-93398c1e01ad", "User", null });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateDateAndTime", "CreatorIdentityID", "Description", "Email", "EmailConfirmed", "IsDeleted", "LastModifiedDateAndTime", "LastModifierIdentityID", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f3856f7a-90a0-4b0b-a2ca-5de567bdb48c", 0, "56435fc2-2657-4b16-8042-7f679809bba6", new DateTime(2020, 2, 20, 10, 33, 23, 774, DateTimeKind.Local).AddTicks(583), "NOONE!", null, "ali.qader3@gmail.com", true, false, new DateTime(2020, 2, 20, 10, 33, 23, 769, DateTimeKind.Local).AddTicks(2854), "NOONE!", false, null, null, null, "AP8BpiKtftKec194Fr1RQ8Q/ewRFPgs4KA29kReAWucQtfZS8UzRqsLWlBZfPXn9qA==", null, false, "550c8b51-571d-44d6-a4c7-cc9a7482fa9b", false, "admin" });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "f3856f7a-90a0-4b0b-a2ca-5de567bdb48c", "db3465e7-5817-4b2c-9552-b654d99a987b" });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "f3856f7a-90a0-4b0b-a2ca-5de567bdb48c", "a7f7642b-af6a-4874-ae59-28e06a435208" });
        }
    }
}
