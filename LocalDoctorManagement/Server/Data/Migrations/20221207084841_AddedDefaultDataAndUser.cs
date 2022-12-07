using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalDoctorManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "FoodRestrictions", "Name", "PillTime", "UpdatedBy", "WaterTime" },
                values: new object[] { 1, "System", new DateTime(2022, 12, 7, 16, 48, 41, 311, DateTimeKind.Local).AddTicks(8147), new DateTime(2022, 12, 7, 16, 48, 41, 312, DateTimeKind.Local).AddTicks(6073), "Chicken, Broccoli", "Test Subject", "16:48", "System", "16:48" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
