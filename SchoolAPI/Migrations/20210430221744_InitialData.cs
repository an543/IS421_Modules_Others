using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    AssignmentId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 60, nullable: false),
                    Score = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.AssignmentId);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    OrganizationId = table.Column<Guid>(nullable: false),
                    OrgName = table.Column<string>(maxLength: 60, nullable: false),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.OrganizationId);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    SectionId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.SectionId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 60, nullable: false),
                    AssignmentId = table.Column<Guid>(nullable: true),
                    SectionId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Courses_Assignments_AssignmentId",
                        column: x => x.AssignmentId,
                        principalTable: "Assignments",
                        principalColumn: "AssignmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Courses_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "SectionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Age = table.Column<int>(nullable: false),
                    OrganizationId = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    CourseId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "OrganizationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                table: "Assignments",
                columns: new[] { "AssignmentId", "Name", "Score" },
                values: new object[,]
                {
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991873"), "Assignment 1", 78 },
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Assignment 2", 93 },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991874"), "Assignment 3", 64 },
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce5"), "Assignment 4", 88 }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "AssignmentId", "Name", "SectionId" },
                values: new object[,]
                {
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991871"), null, "Advanced Web Applications", null },
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce1"), null, "Web Mining", null }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "OrganizationId", "City", "Country", "OrgName" },
                values: new object[,]
                {
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Bloomfield", "USA", "xyz org" },
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Lusaka", "ZM", "lmnop org" }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "SectionId", "Name" },
                values: new object[,]
                {
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991872"), "Section 1" },
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce2"), "Section 2" }
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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CourseId",
                table: "AspNetUsers",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_OrganizationId",
                table: "AspNetUsers",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_AssignmentId",
                table: "Courses",
                column: "AssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_SectionId",
                table: "Courses",
                column: "SectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "Sections");
        }
    }
}
