using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Webshopbanhang.data.Migrations
{
    public partial class db5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 1, 14, 14, 49, 44, 985, DateTimeKind.Local).AddTicks(9905));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 1, 14, 14, 46, 43, 298, DateTimeKind.Local).AddTicks(6801));
        }
    }
}
