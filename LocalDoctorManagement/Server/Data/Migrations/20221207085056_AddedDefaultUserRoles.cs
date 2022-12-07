using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalDoctorManagement.Server.Data.Migrations
{
    public partial class AddedDefaultUserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "9db4a212-417d-4dfc-9677-796c53bbe85e", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "a411ecd6-1e7b-4469-91a7-4228f2799862", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "name" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "78aff25e-fed2-4e1b-bdf2-d049223c3b72", "admin@localhost.com", false, false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAELJO+ipVdvQ9DdvjI5dBEgWvro7X2R36BVTmjwOr+uQIE9FHD5lykYg7I3cFZsDqdg==", null, false, "9cad0de7-cba4-4fba-b649-ed19bb26837e", false, "Admin", "Admin" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "PillTime", "WaterTime" },
                values: new object[] { new DateTime(2022, 12, 7, 16, 50, 56, 88, DateTimeKind.Local).AddTicks(7590), new DateTime(2022, 12, 7, 16, 50, 56, 89, DateTimeKind.Local).AddTicks(7216), "16:50", "16:50" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "PillTime", "WaterTime" },
                values: new object[] { new DateTime(2022, 12, 7, 16, 48, 41, 311, DateTimeKind.Local).AddTicks(8147), new DateTime(2022, 12, 7, 16, 48, 41, 312, DateTimeKind.Local).AddTicks(6073), "16:48", "16:48" });
        }
    }
}
