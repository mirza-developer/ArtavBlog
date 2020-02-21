using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtavBlog.Migrations
{
    public partial class AddLockToCare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "UserRole",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0d7488ae-2461-47c0-8d08-f192ed53b0d8", "86438b6f-1aac-4f77-a73b-9f527ec1a751" });

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "UserRole",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0d7488ae-2461-47c0-8d08-f192ed53b0d8", "fbaebde3-5640-481f-86e2-f83bd1dedc7e" });

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "Role",
                keyColumn: "Id",
                keyValue: "86438b6f-1aac-4f77-a73b-9f527ec1a751");

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "Role",
                keyColumn: "Id",
                keyValue: "fbaebde3-5640-481f-86e2-f83bd1dedc7e");

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "User",
                keyColumn: "Id",
                keyValue: "0d7488ae-2461-47c0-8d08-f192ed53b0d8");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastLockerDate",
                schema: "SignalR",
                table: "CareMessage",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastLockerUser",
                schema: "SignalR",
                table: "CareMessage",
                maxLength: 128,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Lock",
                schema: "SignalR",
                table: "CareMessage",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "LastLockerDate",
                schema: "SignalR",
                table: "CareMessage");

            migrationBuilder.DropColumn(
                name: "LastLockerUser",
                schema: "SignalR",
                table: "CareMessage");

            migrationBuilder.DropColumn(
                name: "Lock",
                schema: "SignalR",
                table: "CareMessage");

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "86438b6f-1aac-4f77-a73b-9f527ec1a751", "eca3f045-69db-4ff9-b5f0-5343cbd231fe", "Admin", null });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fbaebde3-5640-481f-86e2-f83bd1dedc7e", "e34c1065-876c-4d7a-bb6c-7b623305e090", "User", null });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateDateAndTime", "CreatorIdentityID", "Description", "Email", "EmailConfirmed", "IsDeleted", "LastModifiedDateAndTime", "LastModifierIdentityID", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0d7488ae-2461-47c0-8d08-f192ed53b0d8", 0, "5d8cebff-5ba5-4611-9ef2-6fb693d2b9d0", new DateTime(2020, 2, 13, 12, 25, 37, 0, DateTimeKind.Local).AddTicks(8663), "NOONE!", null, "ali.qader3@gmail.com", true, false, new DateTime(2020, 2, 13, 12, 25, 36, 996, DateTimeKind.Local).AddTicks(123), "NOONE!", false, null, null, null, "AAs4lX1G8skCGoO8ZnJffteoCiNlU8NICY7YKo0VK444BiBetebfXskrCdjIMyVezw==", null, false, "4e99cb89-fdc6-45a5-9daa-f7c942132e43", false, "admin" });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "0d7488ae-2461-47c0-8d08-f192ed53b0d8", "86438b6f-1aac-4f77-a73b-9f527ec1a751" });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "0d7488ae-2461-47c0-8d08-f192ed53b0d8", "fbaebde3-5640-481f-86e2-f83bd1dedc7e" });
        }
    }
}
