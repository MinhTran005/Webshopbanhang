using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Webshopbanhang.data.Migrations
{
    public partial class db90 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 1, 14, 14, 58, 10, 479, DateTimeKind.Local).AddTicks(5290));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 1, 14, 14, 56, 21, 265, DateTimeKind.Local).AddTicks(8484));
        }
    }
}
