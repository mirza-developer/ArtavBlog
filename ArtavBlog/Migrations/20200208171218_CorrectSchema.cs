using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtavBlog.Migrations
{
    public partial class CorrectSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blog.Comment_Blog.Post_PostId",
                table: "Blog.Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Blog.TagPost_Blog.Post_PostId",
                table: "Blog.TagPost");

            migrationBuilder.DropForeignKey(
                name: "FK_Blog.TagPost_Blog.Tag_TagId",
                table: "Blog.TagPost");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blog.TagPost",
                table: "Blog.TagPost");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blog.Tag",
                table: "Blog.Tag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blog.Post",
                table: "Blog.Post");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blog.Comment",
                table: "Blog.Comment");

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

            migrationBuilder.EnsureSchema(
                name: "Blog");

            migrationBuilder.RenameTable(
                name: "Blog.TagPost",
                newName: "TagPost",
                newSchema: "Blog");

            migrationBuilder.RenameTable(
                name: "Blog.Tag",
                newName: "Tag",
                newSchema: "Blog");

            migrationBuilder.RenameTable(
                name: "Blog.Post",
                newName: "Post",
                newSchema: "Blog");

            migrationBuilder.RenameTable(
                name: "Blog.Comment",
                newName: "Comment",
                newSchema: "Blog");

            migrationBuilder.RenameIndex(
                name: "IX_Blog.TagPost_TagId",
                schema: "Blog",
                table: "TagPost",
                newName: "IX_TagPost_TagId");

            migrationBuilder.RenameIndex(
                name: "IX_Blog.TagPost_PostId",
                schema: "Blog",
                table: "TagPost",
                newName: "IX_TagPost_PostId");

            migrationBuilder.RenameIndex(
                name: "IX_Blog.Comment_PostId",
                schema: "Blog",
                table: "Comment",
                newName: "IX_Comment_PostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TagPost",
                schema: "Blog",
                table: "TagPost",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tag",
                schema: "Blog",
                table: "Tag",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Post",
                schema: "Blog",
                table: "Post",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                schema: "Blog",
                table: "Comment",
                column: "ID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Post_PostId",
                schema: "Blog",
                table: "Comment",
                column: "PostId",
                principalSchema: "Blog",
                principalTable: "Post",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TagPost_Post_PostId",
                schema: "Blog",
                table: "TagPost",
                column: "PostId",
                principalSchema: "Blog",
                principalTable: "Post",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TagPost_Tag_TagId",
                schema: "Blog",
                table: "TagPost",
                column: "TagId",
                principalSchema: "Blog",
                principalTable: "Tag",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Post_PostId",
                schema: "Blog",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_TagPost_Post_PostId",
                schema: "Blog",
                table: "TagPost");

            migrationBuilder.DropForeignKey(
                name: "FK_TagPost_Tag_TagId",
                schema: "Blog",
                table: "TagPost");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TagPost",
                schema: "Blog",
                table: "TagPost");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tag",
                schema: "Blog",
                table: "Tag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Post",
                schema: "Blog",
                table: "Post");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                schema: "Blog",
                table: "Comment");

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

            migrationBuilder.RenameTable(
                name: "TagPost",
                schema: "Blog",
                newName: "Blog.TagPost");

            migrationBuilder.RenameTable(
                name: "Tag",
                schema: "Blog",
                newName: "Blog.Tag");

            migrationBuilder.RenameTable(
                name: "Post",
                schema: "Blog",
                newName: "Blog.Post");

            migrationBuilder.RenameTable(
                name: "Comment",
                schema: "Blog",
                newName: "Blog.Comment");

            migrationBuilder.RenameIndex(
                name: "IX_TagPost_TagId",
                table: "Blog.TagPost",
                newName: "IX_Blog.TagPost_TagId");

            migrationBuilder.RenameIndex(
                name: "IX_TagPost_PostId",
                table: "Blog.TagPost",
                newName: "IX_Blog.TagPost_PostId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_PostId",
                table: "Blog.Comment",
                newName: "IX_Blog.Comment_PostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blog.TagPost",
                table: "Blog.TagPost",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blog.Tag",
                table: "Blog.Tag",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blog.Post",
                table: "Blog.Post",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blog.Comment",
                table: "Blog.Comment",
                column: "ID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Blog.Comment_Blog.Post_PostId",
                table: "Blog.Comment",
                column: "PostId",
                principalTable: "Blog.Post",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Blog.TagPost_Blog.Post_PostId",
                table: "Blog.TagPost",
                column: "PostId",
                principalTable: "Blog.Post",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Blog.TagPost_Blog.Tag_TagId",
                table: "Blog.TagPost",
                column: "TagId",
                principalTable: "Blog.Tag",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
