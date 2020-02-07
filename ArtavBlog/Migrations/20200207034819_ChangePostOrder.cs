using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtavBlog.Migrations
{
    public partial class ChangePostOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "UserRole",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a9a8b903-97d0-46bc-ba8a-ea4df6b6c227", "670defe2-46d6-418f-8f00-ca84a2da4d4d" });

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "UserRole",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a9a8b903-97d0-46bc-ba8a-ea4df6b6c227", "cc6ecfe5-065c-4e3a-beca-27cbf7e8c849" });

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "Role",
                keyColumn: "Id",
                keyValue: "670defe2-46d6-418f-8f00-ca84a2da4d4d");

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "Role",
                keyColumn: "Id",
                keyValue: "cc6ecfe5-065c-4e3a-beca-27cbf7e8c849");

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "User",
                keyColumn: "Id",
                keyValue: "a9a8b903-97d0-46bc-ba8a-ea4df6b6c227");

            migrationBuilder.DropColumn(
                name: "IsMainPost",
                table: "Blog.Post");

            migrationBuilder.AddColumn<int>(
                name: "PostOrder",
                table: "Blog.Post",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e534dc5-8b35-4848-9279-6a9caca787f6", "ea08252c-3a83-46ff-8c4f-346f9c87eaaa", "Admin", null });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bb7b3435-d032-4a19-a212-c538b9e021f3", "cc889c96-c1da-48fd-8139-a20e84eb784f", "User", null });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateDateAndTime", "CreatorIdentityID", "Description", "Email", "EmailConfirmed", "IsDeleted", "LastModifiedDateAndTime", "LastModifierIdentityID", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "544230da-02dc-4e0a-ad4a-9c0936082fe8", 0, "d94fb9ed-0a45-44ae-9272-43d11d5286fc", new DateTime(2020, 2, 6, 19, 48, 18, 531, DateTimeKind.Local).AddTicks(1690), "NOONE!", null, "ali.qader3@gmail.com", true, false, new DateTime(2020, 2, 6, 19, 48, 18, 526, DateTimeKind.Local).AddTicks(787), "NOONE!", false, null, null, null, "ALoK5pPNITQvSHmY0dEFzBjeTJ8QCalVz87TAvxcIUu8o8r5cwIlrWVTudOZxzW36g==", null, false, "1e6b8541-dae6-47f4-9649-9950f4469d1e", false, "admin" });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "544230da-02dc-4e0a-ad4a-9c0936082fe8", "2e534dc5-8b35-4848-9279-6a9caca787f6" });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "544230da-02dc-4e0a-ad4a-9c0936082fe8", "bb7b3435-d032-4a19-a212-c538b9e021f3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "UserRole",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "544230da-02dc-4e0a-ad4a-9c0936082fe8", "2e534dc5-8b35-4848-9279-6a9caca787f6" });

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "UserRole",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "544230da-02dc-4e0a-ad4a-9c0936082fe8", "bb7b3435-d032-4a19-a212-c538b9e021f3" });

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "Role",
                keyColumn: "Id",
                keyValue: "2e534dc5-8b35-4848-9279-6a9caca787f6");

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "Role",
                keyColumn: "Id",
                keyValue: "bb7b3435-d032-4a19-a212-c538b9e021f3");

            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "User",
                keyColumn: "Id",
                keyValue: "544230da-02dc-4e0a-ad4a-9c0936082fe8");

            migrationBuilder.DropColumn(
                name: "PostOrder",
                table: "Blog.Post");

            migrationBuilder.AddColumn<bool>(
                name: "IsMainPost",
                table: "Blog.Post",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cc6ecfe5-065c-4e3a-beca-27cbf7e8c849", "45b0e87c-2e71-4ceb-b8ff-288311c9536d", "Admin", null });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "670defe2-46d6-418f-8f00-ca84a2da4d4d", "d302fae2-78b0-473a-8170-eb909df1b526", "User", null });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateDateAndTime", "CreatorIdentityID", "Description", "Email", "EmailConfirmed", "IsDeleted", "LastModifiedDateAndTime", "LastModifierIdentityID", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a9a8b903-97d0-46bc-ba8a-ea4df6b6c227", 0, "a3ed13a5-9599-4349-994a-46b6d76e48a5", new DateTime(2020, 1, 5, 12, 6, 25, 195, DateTimeKind.Local).AddTicks(8264), "NOONE!", null, "ali.qader3@gmail.com", true, false, new DateTime(2020, 1, 5, 12, 6, 25, 190, DateTimeKind.Local).AddTicks(9735), "NOONE!", false, null, null, null, "ADt3dRO0ybZ5aL6rr7h7hY56ZymTIlCZv5S6CcnvvQYyiv4Rqgz+nsb9dYukzbeDVA==", null, false, "16f2d2b0-4d92-4a44-a2b9-de3460954a23", false, "admin" });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a9a8b903-97d0-46bc-ba8a-ea4df6b6c227", "cc6ecfe5-065c-4e3a-beca-27cbf7e8c849" });

            migrationBuilder.InsertData(
                schema: "Ident",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a9a8b903-97d0-46bc-ba8a-ea4df6b6c227", "670defe2-46d6-418f-8f00-ca84a2da4d4d" });
        }
    }
}
