using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "8dcd8885-edc2-4153-9e6e-549921361460", "cc8fbed0-3346-4029-a02d-4039e94b187f", "Authenticated", "AUTHENTICATED" },
                    { "363f07c0-4c10-4621-b5de-23d21e34717b", "5dc3caeb-fd33-46e5-8bfc-a236c9f8e2aa", "Staff", "STAFF" },
                    { "9ee347fd-0157-43e8-a961-032ab98a60ac", "0505546a-a5e9-4ef2-81f7-75631d5d83a8", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "CourseId", "Email", "EmailConfirmed", "FirstName", "UserId", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "OrganizationId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9ff9edbd-3b4f-406b-bcd3-126f72452bb7", 0, 0, "57948f71-9c6d-4126-8f1b-b154d4731796", null, null, false, null, new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), null, false, null, "kwilliams", null, null, new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), null, null, false, "ec5fa6f8-084a-42cb-ba12-3044f6b90fea", false, null },
                    { "66a3a599-1aff-4678-9c89-531e02016bec", 0, 0, "ff326384-d1e6-4fa3-b6fa-9321fcce921f", null, null, false, null, new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), null, false, null, "ka393939", null, null, new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), null, null, false, "f4f0b9f9-fc10-40cc-a11f-48066383e445", false, null },
                    { "b7dcb72b-50db-4e56-a6f5-0f3cc4084bf4", 0, 0, "dc0c5245-c81f-44a2-92df-c62f1bb4f9ca", null, null, false, null, new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), null, false, null, "kaw3939", null, null, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), null, null, false, "cc91971e-bd4d-498d-98a0-3a47957170b8", false, null },
                    { "2e20fdb8-5abf-4e9f-9627-2c4ae84a6793", 0, 21, "8abc61d0-1d19-4794-a8b3-f1833f42f76a", null, null, false, null, new Guid("021ca3c1-0deb-4afd-ae94-2159a8479812"), null, false, null, "Tomas", null, null, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), null, null, false, "440db601-0bbc-4509-ad6b-b6d272180d6a", false, null },
                    { "e83ddad2-978a-4892-af1e-c0f18e427e5e", 0, 25, "be14e551-5e95-4906-95a0-d026782028e0", null, null, false, null, new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"), null, false, null, "Natalie", null, null, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), null, null, false, "e032d2ff-659e-465f-a481-747f0422c25b", false, null },
                    { "791a1f07-bc93-4372-8292-840a8d9c58cf", 0, 31, "db0cf38e-0a62-4cf8-8eea-c9c391ae6dff", null, null, false, null, new Guid("021ca3c1-0deb-4afd-ae94-2159a8479814"), null, false, null, "Ethan", null, null, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), null, null, false, "ffc0be28-03a0-46dd-a0f1-50672d99dc19", false, null },
                    { "799e32d9-85bf-4853-98ec-d4907f0c5119", 0, 28, "dcf33756-6aaf-4977-bc17-27fd56a6a68f", null, null, false, null, new Guid("021ca3c1-0deb-4afd-ae94-2159a8479815"), null, false, null, "Dan", null, null, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), null, null, false, "0119dfee-c74e-44d1-9898-1f4a051acb8f", false, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "363f07c0-4c10-4621-b5de-23d21e34717b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8dcd8885-edc2-4153-9e6e-549921361460");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ee347fd-0157-43e8-a961-032ab98a60ac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e20fdb8-5abf-4e9f-9627-2c4ae84a6793");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66a3a599-1aff-4678-9c89-531e02016bec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "791a1f07-bc93-4372-8292-840a8d9c58cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "799e32d9-85bf-4853-98ec-d4907f0c5119");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ff9edbd-3b4f-406b-bcd3-126f72452bb7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7dcb72b-50db-4e56-a6f5-0f3cc4084bf4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e83ddad2-978a-4892-af1e-c0f18e427e5e");

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
    }
}
