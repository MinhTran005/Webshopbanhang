﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Webshopbanhang.data.Migrations
{
    public partial class db6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 1, 14, 14, 46, 43, 298, DateTimeKind.Local).AddTicks(6801));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 1, 14, 14, 33, 20, 972, DateTimeKind.Local).AddTicks(5794));
        }
    }
}
