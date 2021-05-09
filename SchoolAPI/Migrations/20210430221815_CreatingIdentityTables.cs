using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class CreatingIdentityTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b53c5611-8876-4296-8301-b4760854e639");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1882766-1f47-4577-a989-3d148aa00218");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef92f24c-c9bf-444f-9079-9b1ebae6c902");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d8d07b4-4167-419d-93bc-8bb700c65fc8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "178d1cab-b975-4957-9b86-af575808e8c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c67bc75-fc83-435a-9a4a-c95ca7aab524");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ec1ad53-e678-4d2e-bf33-906aeb7287c8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a1d0c38-11b5-44b9-8a8d-3ec23474f7bc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a07ea024-d030-4022-9eea-b8dd22af3ac0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f59eee08-3806-47ec-8b8a-723ec2d2d057");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ef361fcb-b15c-43b1-97c7-73ea9979a4b1", "d8707d7f-c31b-4427-b79e-a98d12684738", "Authenticated", "AUTHENTICATED" },
                    { "4860a6b8-9b6d-4de8-82fe-282e770329e0", "7946a3a0-8b91-4bd0-bd53-3d6c4dad8b79", "Staff", "STAFF" },
                    { "e1a40b99-c337-4800-9644-5afb90a47104", "81d9c0a5-b53f-41d5-93ea-e5b5193bb00f", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "CourseId", "Email", "EmailConfirmed", "FirstName", "UserId", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "OrganizationId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "57201551-17ad-43b2-80d9-80fed4068bbc", 0, 0, "bd3537a5-ea88-4584-a415-602fcae637b5", null, null, false, null, new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), null, false, null, "kwilliams", null, null, new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), null, null, false, "410ef9e2-073b-4711-93be-c67ac225a047", false, null },
                    { "8fca41e8-fef7-42d6-b1be-aeff90042194", 0, 0, "c754a277-877a-41fe-b362-7beb8cd55f7d", null, null, false, null, new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), null, false, null, "ka393939", null, null, new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), null, null, false, "2bb99c09-1b63-42be-aa84-8efe3c46fa3f", false, null },
                    { "4bbbbfd2-5f0c-4120-a18b-64bd9bad3cde", 0, 0, "16872906-c1a2-4503-ae67-3d9644c8774c", null, null, false, null, new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), null, false, null, "kaw3939", null, null, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), null, null, false, "65a445a5-8522-442e-a345-68cc81df129f", false, null },
                    { "3864366d-ede1-4884-8b3b-cd18812a0226", 0, 21, "16461521-0131-46e9-ace6-76117e7aaeec", null, null, false, null, new Guid("021ca3c1-0deb-4afd-ae94-2159a8479812"), null, false, null, "Tomas", null, null, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), null, null, false, "00544b6e-843f-4b05-9ae5-0ef344ad6522", false, null },
                    { "ca4354c0-ea77-4088-9148-7e1e5781b083", 0, 25, "7d24533d-ac4d-4fdb-a897-5c7a28024b66", null, null, false, null, new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"), null, false, null, "Natalie", null, null, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), null, null, false, "93fec8a8-d2b3-4d19-bc2c-d4313f5aa4dc", false, null },
                    { "0d803e8e-a6f4-44b1-b3b6-e9153d8e72f7", 0, 31, "71246a36-ba9d-4818-9906-612a5c808968", null, null, false, null, new Guid("021ca3c1-0deb-4afd-ae94-2159a8479814"), null, false, null, "Ethan", null, null, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), null, null, false, "80d48252-9ffa-4c47-84aa-d7ae47a5ae9e", false, null },
                    { "dae8007b-a041-47ab-860c-3f8fb9e01e81", 0, 28, "65d3c001-c808-41a1-acc4-424d1b940223", null, null, false, null, new Guid("021ca3c1-0deb-4afd-ae94-2159a8479815"), null, false, null, "Dan", null, null, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), null, null, false, "11d2b984-b362-4a51-b0a3-69eb7835a91d", false, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4860a6b8-9b6d-4de8-82fe-282e770329e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1a40b99-c337-4800-9644-5afb90a47104");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef361fcb-b15c-43b1-97c7-73ea9979a4b1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d803e8e-a6f4-44b1-b3b6-e9153d8e72f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3864366d-ede1-4884-8b3b-cd18812a0226");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4bbbbfd2-5f0c-4120-a18b-64bd9bad3cde");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57201551-17ad-43b2-80d9-80fed4068bbc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8fca41e8-fef7-42d6-b1be-aeff90042194");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca4354c0-ea77-4088-9148-7e1e5781b083");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dae8007b-a041-47ab-860c-3f8fb9e01e81");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b53c5611-8876-4296-8301-b4760854e639", "515445cd-bd71-49ca-9123-c67f45c51708", "Authenticated", "AUTHENTICATED" },
                    { "ef92f24c-c9bf-444f-9079-9b1ebae6c902", "4b29fa15-805c-44fb-9cb5-8103d93b3e5f", "Staff", "STAFF" },
                    { "e1882766-1f47-4577-a989-3d148aa00218", "ea042622-282b-43a7-8b25-281a30285ba6", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "CourseId", "Email", "EmailConfirmed", "FirstName", "UserId", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "OrganizationId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0d8d07b4-4167-419d-93bc-8bb700c65fc8", 0, 0, "f89c7a8f-c0fd-4fbf-9347-b779eca2818a", null, null, false, null, new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), null, false, null, "kwilliams", null, null, new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), null, null, false, "adef8142-1799-46f7-8138-eb49150c3231", false, null },
                    { "178d1cab-b975-4957-9b86-af575808e8c3", 0, 0, "68503c5b-8cc3-490f-873b-86841385bd1c", null, null, false, null, new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), null, false, null, "ka393939", null, null, new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), null, null, false, "ba4eb253-c8fb-4e90-9468-e054127eeb91", false, null },
                    { "f59eee08-3806-47ec-8b8a-723ec2d2d057", 0, 0, "7c073015-b544-47c6-946a-bee9188b9743", null, null, false, null, new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), null, false, null, "kaw3939", null, null, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), null, null, false, "75831785-4e93-4030-8e4b-de1a0aebcb65", false, null },
                    { "9a1d0c38-11b5-44b9-8a8d-3ec23474f7bc", 0, 21, "16e5bc9c-0e09-41ff-a099-771d23288b2f", null, null, false, null, new Guid("021ca3c1-0deb-4afd-ae94-2159a8479812"), null, false, null, "Tomas", null, null, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), null, null, false, "85f84fb3-4e7b-45b4-a6e7-fd8ee2383cdc", false, null },
                    { "4c67bc75-fc83-435a-9a4a-c95ca7aab524", 0, 25, "7fdecb41-4521-462e-902a-fcb632b5ea17", null, null, false, null, new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"), null, false, null, "Natalie", null, null, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), null, null, false, "e42b3f2c-1b9b-4097-b824-acb1306a6daf", false, null },
                    { "6ec1ad53-e678-4d2e-bf33-906aeb7287c8", 0, 31, "55ef08a9-b713-447c-ab55-db2a7cf8effb", null, null, false, null, new Guid("021ca3c1-0deb-4afd-ae94-2159a8479814"), null, false, null, "Ethan", null, null, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), null, null, false, "ce798976-c046-4c83-9fc6-77167fc08f28", false, null },
                    { "a07ea024-d030-4022-9eea-b8dd22af3ac0", 0, 28, "f9e98d85-7cf7-4757-8ad8-c212e66ff9d8", null, null, false, null, new Guid("021ca3c1-0deb-4afd-ae94-2159a8479815"), null, false, null, "Dan", null, null, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), null, null, false, "3b89fcfb-25b8-441a-81f3-69c8b7d5ea43", false, null }
                });
        }
    }
}
