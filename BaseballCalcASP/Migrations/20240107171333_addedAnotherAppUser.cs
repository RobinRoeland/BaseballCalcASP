using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseballCalcASP.Migrations
{
    public partial class addedAnotherAppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "deleted",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "79437a70-e29b-4720-ac46-0afcac25e0cb", "1118a16d-28eb-4086-b978-547ab1f66daa", "user", "user" },
                    { "b6488eb3-495e-43e7-b447-9ff9afbccf56", "538d6168-fedd-43d5-a442-64d3ee9dc1dc", "admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "deleted" },
                values: new object[,]
                {
                    { "aa261f3c-fb84-4047-b7d2-4e92faa82fe5", 0, "510af556-925a-48c3-aad5-b46232abf223", "AppUser", "user2@testemail.com", true, "User2", "AppUser2", false, null, "USER2@TESTEMAIL.COM", "USER2@TESTEMAIL.COM", "AQAAAAEAACcQAAAAEHuqlOnMMunWEWQHkK/XzBYiJUtgjn7rLjBukSBCpA31k/gxEuohE3VTWCCej4AOAg==", null, true, "c73ea248-a680-4afc-b1e8-4f0a2923303d", false, "user2@testemail.com", false },
                    { "d6fbfb97-d5eb-4c22-9ff4-d99092a82f8a", 0, "d3b17707-d3c9-4855-a321-24f068563b3f", "AppUser", "user1@testemail.com", true, "User1", "AppUser1", false, null, "USER1@TESTEMAIL.COM", "USER1@TESTEMAIL.COM", "AQAAAAEAACcQAAAAEAL3GQUMxMG2gkoKft4OB0XeomRigxDjKz/6kDkJcFTqhucCM71h9gpAlHG/0FpEtw==", null, true, "1f0c1585-7cc0-43d9-b3cb-b4b5034e7875", false, "user1@testemail.com", false },
                    { "ede38fe2-8685-44e0-96c5-8aac6ea1a8d5", 0, "6a07d04f-1e3e-4769-bf7a-10e46d137b3e", "AppUser", "admin@testemail.com", true, "System", "Administrator", false, null, "ADMIN@TESTEMAIL.COM", "ADMIN@TESTEMAIL.COM", "AQAAAAEAACcQAAAAEE66EQGB1Tm3GeZ2cUwcJoK2AO/kAH0RBFbBFWCVfISIdEGCXSzQDGICkS5N2OlBbA==", null, true, "c007b2f4-34d9-42d9-a9a8-4d753e51a422", false, "admin@testemail.com", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "79437a70-e29b-4720-ac46-0afcac25e0cb", "aa261f3c-fb84-4047-b7d2-4e92faa82fe5" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "79437a70-e29b-4720-ac46-0afcac25e0cb", "d6fbfb97-d5eb-4c22-9ff4-d99092a82f8a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b6488eb3-495e-43e7-b447-9ff9afbccf56", "ede38fe2-8685-44e0-96c5-8aac6ea1a8d5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "79437a70-e29b-4720-ac46-0afcac25e0cb", "aa261f3c-fb84-4047-b7d2-4e92faa82fe5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "79437a70-e29b-4720-ac46-0afcac25e0cb", "d6fbfb97-d5eb-4c22-9ff4-d99092a82f8a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b6488eb3-495e-43e7-b447-9ff9afbccf56", "ede38fe2-8685-44e0-96c5-8aac6ea1a8d5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79437a70-e29b-4720-ac46-0afcac25e0cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6488eb3-495e-43e7-b447-9ff9afbccf56");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa261f3c-fb84-4047-b7d2-4e92faa82fe5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6fbfb97-d5eb-4c22-9ff4-d99092a82f8a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ede38fe2-8685-44e0-96c5-8aac6ea1a8d5");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "deleted",
                table: "AspNetUsers");

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
    }
}
