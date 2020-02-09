using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtavBlog.Migrations
{
    public partial class UpdatePhoneNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "UserRole",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7082a435-b897-4e9c-ac66-dda84ed8858f", "c49e3368-deee-4fd6-9411-d882a0f7cf72" });

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "UserRole",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7082a435-b897-4e9c-ac66-dda84ed8858f", "c5e0824e-d859-4a31-8520-5eeadf030208" });

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "Role",
                keyColumn: "Id",
                keyValue: "c49e3368-deee-4fd6-9411-d882a0f7cf72");

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "Role",
                keyColumn: "Id",
                keyValue: "c5e0824e-d859-4a31-8520-5eeadf030208");

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "User",
                keyColumn: "Id",
                keyValue: "7082a435-b897-4e9c-ac66-dda84ed8858f");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDateAndTime",
                schema: "Sms",
                table: "PhoneNumber",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatorIdentityID",
                schema: "Sms",
                table: "PhoneNumber",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "Sms",
                table: "PhoneNumber",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Sms",
                table: "PhoneNumber",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDateAndTime",
                schema: "Sms",
                table: "PhoneNumber",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifierIdentityID",
                schema: "Sms",
                table: "PhoneNumber",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CreateDateAndTime",
                schema: "Sms",
                table: "PhoneNumber");

            migrationBuilder.DropColumn(
                name: "CreatorIdentityID",
                schema: "Sms",
                table: "PhoneNumber");

            migrationBuilder.DropColumn(
                name: "Description",
                schema: "Sms",
                table: "PhoneNumber");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Sms",
                table: "PhoneNumber");

            migrationBuilder.DropColumn(
                name: "LastModifiedDateAndTime",
                schema: "Sms",
                table: "PhoneNumber");

            migrationBuilder.DropColumn(
                name: "LastModifierIdentityID",
                schema: "Sms",
                table: "PhoneNumber");

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c49e3368-deee-4fd6-9411-d882a0f7cf72", "20bd7373-c310-4177-97c6-b3f06e29ba8e", "Admin", null });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5e0824e-d859-4a31-8520-5eeadf030208", "81a8654d-e466-4f18-81a7-f00bc8cc0413", "User", null });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateDateAndTime", "CreatorIdentityID", "Description", "Email", "EmailConfirmed", "IsDeleted", "LastModifiedDateAndTime", "LastModifierIdentityID", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7082a435-b897-4e9c-ac66-dda84ed8858f", 0, "d15e911b-a15b-4ac5-abf4-24e747c9a01b", new DateTime(2020, 2, 8, 12, 6, 54, 584, DateTimeKind.Local).AddTicks(8711), "NOONE!", null, "ali.qader3@gmail.com", true, false, new DateTime(2020, 2, 8, 12, 6, 54, 580, DateTimeKind.Local).AddTicks(5367), "NOONE!", false, null, null, null, "AAaqNx+NCSi22lUi3JM2NKv/OvC9XN1pUPQqQA9A/5p1NJMmG1JsKYGsxZgfEAzX2A==", null, false, "d51340b9-b491-4602-b384-68f35759d262", false, "admin" });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "7082a435-b897-4e9c-ac66-dda84ed8858f", "c49e3368-deee-4fd6-9411-d882a0f7cf72" });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "7082a435-b897-4e9c-ac66-dda84ed8858f", "c5e0824e-d859-4a31-8520-5eeadf030208" });
        }
    }
}
