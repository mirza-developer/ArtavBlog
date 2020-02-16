using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtavBlog.Migrations
{
    public partial class AddCareMessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "UserRole",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "18d841f7-86ec-461a-bbbf-051eead307ba", "3f0190a8-4548-403a-9ac1-70c68bd51e9e" });

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "UserRole",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "18d841f7-86ec-461a-bbbf-051eead307ba", "9e2275d5-5266-447b-a5d6-239da841ca12" });

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "Role",
                keyColumn: "Id",
                keyValue: "3f0190a8-4548-403a-9ac1-70c68bd51e9e");

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "Role",
                keyColumn: "Id",
                keyValue: "9e2275d5-5266-447b-a5d6-239da841ca12");

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "User",
                keyColumn: "Id",
                keyValue: "18d841f7-86ec-461a-bbbf-051eead307ba");

            migrationBuilder.EnsureSchema(
                name: "SignalR");

            migrationBuilder.CreateTable(
                name: "CareMessage",
                schema: "SignalR",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 128, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(maxLength: 256, nullable: true),
                    CreateDateAndTime = table.Column<DateTime>(nullable: false),
                    CreatorIdentityID = table.Column<string>(maxLength: 128, nullable: false),
                    LastModifiedDateAndTime = table.Column<DateTime>(nullable: false),
                    LastModifierIdentityID = table.Column<string>(maxLength: 128, nullable: false),
                    MessageText = table.Column<string>(maxLength: 300, nullable: false),
                    ConnectionId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareMessage", x => x.ID);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CareMessage",
                schema: "SignalR");

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

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3f0190a8-4548-403a-9ac1-70c68bd51e9e", "35c8209c-7471-4c1b-b32a-7fe69c784361", "Admin", null });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9e2275d5-5266-447b-a5d6-239da841ca12", "f6343988-7bb1-4d46-88fb-4610011008ad", "User", null });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateDateAndTime", "CreatorIdentityID", "Description", "Email", "EmailConfirmed", "IsDeleted", "LastModifiedDateAndTime", "LastModifierIdentityID", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "18d841f7-86ec-461a-bbbf-051eead307ba", 0, "189e5a99-d049-46f3-84da-9d29413511e9", new DateTime(2020, 2, 8, 12, 27, 1, 304, DateTimeKind.Local).AddTicks(378), "NOONE!", null, "ali.qader3@gmail.com", true, false, new DateTime(2020, 2, 8, 12, 27, 1, 299, DateTimeKind.Local).AddTicks(5331), "NOONE!", false, null, null, null, "AMBVz7/e4nO6LJYZAI7ty8y3rzagZh4Lovs912gAN/kLScoYmaO4mkkryEImRz5JtQ==", null, false, "82e7c7d1-db1d-4769-90fd-5359fb652fe6", false, "admin" });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "18d841f7-86ec-461a-bbbf-051eead307ba", "3f0190a8-4548-403a-9ac1-70c68bd51e9e" });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "18d841f7-86ec-461a-bbbf-051eead307ba", "9e2275d5-5266-447b-a5d6-239da841ca12" });
        }
    }
}
