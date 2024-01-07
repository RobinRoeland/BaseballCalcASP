using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseballCalcASP.Migrations
{
    public partial class addedAppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f6326ae0-d212-4a46-87d0-abae83b2c4ad", "6520247f-384c-4b0b-94a7-260c5cc8304a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cd955ee2-869c-4b6d-a487-99ef087fe66c", "fa0c3432-795d-4316-abc3-ffbdcf849fc5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd955ee2-869c-4b6d-a487-99ef087fe66c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6326ae0-d212-4a46-87d0-abae83b2c4ad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6520247f-384c-4b0b-94a7-260c5cc8304a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa0c3432-795d-4316-abc3-ffbdcf849fc5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "47b522b9-d5b0-4111-9515-7d65eb7d858b", "d9ca6c57-ee74-44b2-a95d-1e6974aa00a9", "admin", "admin" },
                    { "5122fdd8-cf7a-4d09-80a9-4e2be18e67bf", "c3443045-e27e-46b9-9767-1a7ecf5c6406", "user", "user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "29cd4f83-6fea-478f-8afc-339577ef0415", 0, "7c0c406a-204d-462b-a574-c34d6be6303c", "admin@testemail.com", true, false, null, "ADMIN@TESTEMAIL.COM", "ADMIN@TESTEMAIL.COM", "AQAAAAEAACcQAAAAEAu/c32OXf+Pwrpkh9dKpxAd/1qWFdTWpvtgGE2qKH91GAbx4S9fIE6TPtjLCaLJJw==", null, true, "0918405d-23c0-4c2b-8194-a47609d2e9b1", false, "admin@testemail.com" },
                    { "6d0c9aea-68fb-458e-a2ad-d87badb642fa", 0, "a0e7b46f-e89c-4313-a5b7-2ab3a2ba298e", "user1@testemail.com", true, false, null, "USER1@TESTEMAIL.COM", "USER1@TESTEMAIL.COM", "AQAAAAEAACcQAAAAEKhV57kmILJ1Qn1I+4jZrx4hgPvkYweBDzgzYM3/i35s1G+d0p3hTRvYNGCy0bMQkQ==", null, true, "f51fd57c-f0e0-4845-8d9c-92007f82ec25", false, "user1@testemail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "47b522b9-d5b0-4111-9515-7d65eb7d858b", "29cd4f83-6fea-478f-8afc-339577ef0415" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5122fdd8-cf7a-4d09-80a9-4e2be18e67bf", "6d0c9aea-68fb-458e-a2ad-d87badb642fa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "47b522b9-d5b0-4111-9515-7d65eb7d858b", "29cd4f83-6fea-478f-8afc-339577ef0415" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5122fdd8-cf7a-4d09-80a9-4e2be18e67bf", "6d0c9aea-68fb-458e-a2ad-d87badb642fa" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47b522b9-d5b0-4111-9515-7d65eb7d858b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5122fdd8-cf7a-4d09-80a9-4e2be18e67bf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29cd4f83-6fea-478f-8afc-339577ef0415");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d0c9aea-68fb-458e-a2ad-d87badb642fa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cd955ee2-869c-4b6d-a487-99ef087fe66c", "ee82da03-32a8-440c-ba1b-26e30e3580ac", "admin", "admin" },
                    { "f6326ae0-d212-4a46-87d0-abae83b2c4ad", "aed1b6c5-84c1-4399-92b9-15df9bee4a7a", "user", "user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6520247f-384c-4b0b-94a7-260c5cc8304a", 0, "af58277f-952a-4ea2-a899-86eec607db0d", "user1@testemail.com", true, false, null, "USER1@TESTEMAIL.COM", "USER1@TESTEMAIL.COM", "AQAAAAEAACcQAAAAENwUUkHakgCOa3cuOoASiSk4nmxVU4PZNDL2ufgsw7HFi+LXgxSqfHNbpB8nVt6NOw==", null, true, "099c0084-d1c2-448e-ab2f-d71e815add91", false, "user1@testemail.com" },
                    { "fa0c3432-795d-4316-abc3-ffbdcf849fc5", 0, "8c492e82-7dd3-4885-9eef-430f6bb3a08c", "admin@testemail.com", true, false, null, "ADMIN@TESTEMAIL.COM", "ADMIN@TESTEMAIL.COM", "AQAAAAEAACcQAAAAEFtL6EYhrWgeWaKdy0GKtu+L+wJjKHB16R+BGRFVCjOgKjJ82PzlwchQ0UZ2CzVMaQ==", null, true, "fe3ed45b-faed-4d8b-9487-d304a5b319ad", false, "admin@testemail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f6326ae0-d212-4a46-87d0-abae83b2c4ad", "6520247f-384c-4b0b-94a7-260c5cc8304a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cd955ee2-869c-4b6d-a487-99ef087fe66c", "fa0c3432-795d-4316-abc3-ffbdcf849fc5" });
        }
    }
}
