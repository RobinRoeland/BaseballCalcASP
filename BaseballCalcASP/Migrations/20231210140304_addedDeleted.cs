using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseballCalcASP.Migrations
{
    public partial class addedDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f50c8c6f-dcf5-46cb-9aba-107228c881e5", "d0c205d6-e3ff-4ebe-99d9-f8f707b7a3d6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "860f5f7d-9aeb-46ed-ac22-0dacca773827", "e1163262-2cf8-42bc-bf52-08f5b8d0c4f9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "860f5f7d-9aeb-46ed-ac22-0dacca773827");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f50c8c6f-dcf5-46cb-9aba-107228c881e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0c205d6-e3ff-4ebe-99d9-f8f707b7a3d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e1163262-2cf8-42bc-bf52-08f5b8d0c4f9");

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Teams",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Seasons",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Players",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Seasons");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Players");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "860f5f7d-9aeb-46ed-ac22-0dacca773827", "0796fcb2-a2cb-4ed6-a33c-ceea2c8f306c", "user", "user" },
                    { "f50c8c6f-dcf5-46cb-9aba-107228c881e5", "a7ffa28e-7250-4b01-90d7-7f19882821a7", "admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d0c205d6-e3ff-4ebe-99d9-f8f707b7a3d6", 0, "f29be239-cdc7-4efe-bcfc-4d645cf892a1", "admin@testemail.com", true, false, null, "admin@testemail.com", "admin", "AQAAAAEAACcQAAAAEMTSuOvi3QmFwsMUWBMa+6GPXIfhrBepVPzRpQcR+qFhtw8i1Faf95Vc0qG87Hs8tA==", null, true, "c3d575c6-4f0e-4e22-a624-62ac45ecb94e", false, "admin" },
                    { "e1163262-2cf8-42bc-bf52-08f5b8d0c4f9", 0, "4effcce1-40c3-4556-9cb3-4dd8c0b27b8a", "user1@testemail.com", true, false, null, "user1@testemail.com", "user1", "AQAAAAEAACcQAAAAEFB/KrsMSujD0mJRtYNFg7vgoXOi6x2ufkC+e5ySviERnLKctWOYU4Whr02iO2NbqA==", null, false, "7bad6b30-9ffa-4c77-ab2d-370c3403e94c", false, "user1" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f50c8c6f-dcf5-46cb-9aba-107228c881e5", "d0c205d6-e3ff-4ebe-99d9-f8f707b7a3d6" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "860f5f7d-9aeb-46ed-ac22-0dacca773827", "e1163262-2cf8-42bc-bf52-08f5b8d0c4f9" });
        }
    }
}
