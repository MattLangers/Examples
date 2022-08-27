using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
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
                    table.ForeignKey(
                        name: "FK_ProductPublished_Product_Id",
                        column: x => x.Id,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
