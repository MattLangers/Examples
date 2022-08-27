using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class CreateProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 8, 25, 12, 42, 36, 661, DateTimeKind.Utc).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 8, 25, 12, 42, 36, 661, DateTimeKind.Utc).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 8, 25, 12, 42, 36, 661, DateTimeKind.Utc).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 8, 25, 12, 42, 36, 661, DateTimeKind.Utc).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 8, 25, 12, 42, 36, 661, DateTimeKind.Utc).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 8, 25, 12, 42, 36, 661, DateTimeKind.Utc).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2022, 8, 25, 12, 42, 36, 661, DateTimeKind.Utc).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2022, 8, 25, 12, 42, 36, 661, DateTimeKind.Utc).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2022, 8, 25, 12, 42, 36, 661, DateTimeKind.Utc).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2022, 8, 25, 12, 42, 36, 661, DateTimeKind.Utc).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2022, 8, 25, 12, 42, 36, 661, DateTimeKind.Utc).AddTicks(4806));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 11, 27, 3, 132, DateTimeKind.Utc).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 11, 27, 3, 132, DateTimeKind.Utc).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 11, 27, 3, 132, DateTimeKind.Utc).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 11, 27, 3, 132, DateTimeKind.Utc).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 11, 27, 3, 132, DateTimeKind.Utc).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 11, 27, 3, 132, DateTimeKind.Utc).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 11, 27, 3, 132, DateTimeKind.Utc).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 11, 27, 3, 132, DateTimeKind.Utc).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 11, 27, 3, 132, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 11, 27, 3, 132, DateTimeKind.Utc).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 11, 27, 3, 132, DateTimeKind.Utc).AddTicks(5039));
        }
    }
}
