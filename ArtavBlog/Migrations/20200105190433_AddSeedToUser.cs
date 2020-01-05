using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtavBlog.Migrations
{
    public partial class AddSeedToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Ident",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateDateAndTime", "CreatorIdentityID", "Description", "Email", "EmailConfirmed", "IsDeleted", "LastModifiedDateAndTime", "LastModifierIdentityID", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f86ee5ab-4b90-46b9-a3d2-d7a1b787919b", 0, "b2eeda30-78ab-4e4e-86af-d7818efe9cb5", new DateTime(2020, 1, 5, 11, 4, 32, 759, DateTimeKind.Local).AddTicks(8453), "NOONE!", null, "ali.qader3@gmail.com", true, false, new DateTime(2020, 1, 5, 11, 4, 32, 755, DateTimeKind.Local).AddTicks(4123), "NOONE!", false, null, null, null, "AHCjhXFKzozMlVjhl8zyfq6VPM8ah9bhiBniFPhI870z0nyQcQj3MnDWRKMF1G+5KA==", null, false, "eb9044ec-e407-42fd-b76c-c3189cf2e69c", false, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Ident",
                table: "User",
                keyColumn: "Id",
                keyValue: "f86ee5ab-4b90-46b9-a3d2-d7a1b787919b");
        }
    }
}
