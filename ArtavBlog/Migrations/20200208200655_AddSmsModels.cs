using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtavBlog.Migrations
{
    public partial class AddSmsModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "UserRole",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "faea0071-b9e5-40d1-a32a-c99bb798b942", "c2e3094c-8be5-4f87-8dd8-364ba6914e42" });

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "UserRole",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "faea0071-b9e5-40d1-a32a-c99bb798b942", "cd55bbea-8837-49b3-8b8f-d0357920bf68" });

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "Role",
                keyColumn: "Id",
                keyValue: "c2e3094c-8be5-4f87-8dd8-364ba6914e42");

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "Role",
                keyColumn: "Id",
                keyValue: "cd55bbea-8837-49b3-8b8f-d0357920bf68");

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "User",
                keyColumn: "Id",
                keyValue: "faea0071-b9e5-40d1-a32a-c99bb798b942");

            migrationBuilder.EnsureSchema(
                name: "Sms");

            migrationBuilder.CreateTable(
                name: "PhoneNumber",
                schema: "Sms",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 128, nullable: false),
                    Number = table.Column<string>(maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumber", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                schema: "Sms",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 128, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(maxLength: 256, nullable: true),
                    CreateDateAndTime = table.Column<DateTime>(nullable: false),
                    CreatorIdentityID = table.Column<string>(maxLength: 128, nullable: false),
                    LastModifiedDateAndTime = table.Column<DateTime>(nullable: false),
                    LastModifierIdentityID = table.Column<string>(maxLength: 128, nullable: false),
                    MessageText = table.Column<string>(maxLength: 256, nullable: false),
                    PhoneNumberId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Message_PhoneNumber_PhoneNumberId",
                        column: x => x.PhoneNumberId,
                        principalSchema: "Sms",
                        principalTable: "PhoneNumber",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Message_PhoneNumberId",
                schema: "Sms",
                table: "Message",
                column: "PhoneNumberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Message",
                schema: "Sms");

            migrationBuilder.DropTable(
                name: "PhoneNumber",
                schema: "Sms");

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

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd55bbea-8837-49b3-8b8f-d0357920bf68", "c6c961fe-8614-4bda-86d2-381deae6ad5a", "Admin", null });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c2e3094c-8be5-4f87-8dd8-364ba6914e42", "0c83e081-0756-4491-bdd9-7fffb305e7f4", "User", null });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateDateAndTime", "CreatorIdentityID", "Description", "Email", "EmailConfirmed", "IsDeleted", "LastModifiedDateAndTime", "LastModifierIdentityID", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "faea0071-b9e5-40d1-a32a-c99bb798b942", 0, "c3b36cc1-c867-4b8b-90d8-ccd5f26bd140", new DateTime(2020, 2, 8, 9, 12, 17, 590, DateTimeKind.Local).AddTicks(9627), "NOONE!", null, "ali.qader3@gmail.com", true, false, new DateTime(2020, 2, 8, 9, 12, 17, 586, DateTimeKind.Local).AddTicks(2545), "NOONE!", false, null, null, null, "AOHzoDt7xqT7K6eQekPfAwlDmrciEvUBOS78qirfC+2GzILyq9QN1jBmzmlzCKB9Xg==", null, false, "f9b983c4-e386-4812-8982-f099c64dc2b0", false, "admin" });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "faea0071-b9e5-40d1-a32a-c99bb798b942", "cd55bbea-8837-49b3-8b8f-d0357920bf68" });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "faea0071-b9e5-40d1-a32a-c99bb798b942", "c2e3094c-8be5-4f87-8dd8-364ba6914e42" });
        }
    }
}
