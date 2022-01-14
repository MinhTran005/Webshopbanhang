using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Webshopbanhang.data.Migrations
{
    public partial class db99 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 1, 14, 14, 58, 41, 807, DateTimeKind.Local).AddTicks(614));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 1, 14, 14, 58, 10, 479, DateTimeKind.Local).AddTicks(5290));
        }
    }
}
