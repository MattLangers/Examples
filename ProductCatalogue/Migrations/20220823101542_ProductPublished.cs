using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductCatalogue.Migrations
{
    public partial class ProductPublished : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductPublished",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPublished", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 10, 15, 42, 210, DateTimeKind.Utc).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 10, 15, 42, 210, DateTimeKind.Utc).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 10, 15, 42, 210, DateTimeKind.Utc).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 10, 15, 42, 210, DateTimeKind.Utc).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 10, 15, 42, 210, DateTimeKind.Utc).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 10, 15, 42, 210, DateTimeKind.Utc).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 10, 15, 42, 210, DateTimeKind.Utc).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 10, 15, 42, 210, DateTimeKind.Utc).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 10, 15, 42, 210, DateTimeKind.Utc).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 10, 15, 42, 210, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 10, 15, 42, 210, DateTimeKind.Utc).AddTicks(7843));

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductPublished_Id",
                table: "Product",
                column: "Id",
                principalTable: "ProductPublished",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductPublished_Id",
                table: "Product");

            migrationBuilder.DropTable(
                name: "ProductPublished");

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 9, 31, 33, 73, DateTimeKind.Utc).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 9, 31, 33, 73, DateTimeKind.Utc).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 9, 31, 33, 73, DateTimeKind.Utc).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 9, 31, 33, 73, DateTimeKind.Utc).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 9, 31, 33, 73, DateTimeKind.Utc).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 9, 31, 33, 73, DateTimeKind.Utc).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 9, 31, 33, 73, DateTimeKind.Utc).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 9, 31, 33, 73, DateTimeKind.Utc).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 9, 31, 33, 73, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 9, 31, 33, 73, DateTimeKind.Utc).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2022, 8, 23, 9, 31, 33, 73, DateTimeKind.Utc).AddTicks(4684));
        }
    }
}
