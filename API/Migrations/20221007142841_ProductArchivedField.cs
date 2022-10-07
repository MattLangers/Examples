using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class ProductArchivedField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Archived",
                table: "Product",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("36e3555a-4d12-455b-9915-17260e798840"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 28, 41, 421, DateTimeKind.Utc).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("611622e1-5c10-4e7e-a7d5-43d1457179d7"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 28, 41, 421, DateTimeKind.Utc).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("822bea15-489a-49ac-bc05-32cc6a05e2ec"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 28, 41, 421, DateTimeKind.Utc).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ae942935-a413-4c83-8d0f-5c87ed468f79"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 28, 41, 421, DateTimeKind.Utc).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c67a4aff-699f-4ba2-8513-7731864c6efe"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 28, 41, 421, DateTimeKind.Utc).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f284aa7d-f280-4f81-9435-4b43b24e7bc7"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 28, 41, 421, DateTimeKind.Utc).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("faea9f16-a461-463d-a70e-051fb130fbd0"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 28, 41, 421, DateTimeKind.Utc).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 28, 41, 421, DateTimeKind.Utc).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 28, 41, 421, DateTimeKind.Utc).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 28, 41, 421, DateTimeKind.Utc).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 28, 41, 421, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 28, 41, 421, DateTimeKind.Utc).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 28, 41, 421, DateTimeKind.Utc).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 28, 41, 421, DateTimeKind.Utc).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 28, 41, 421, DateTimeKind.Utc).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 28, 41, 421, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 28, 41, 421, DateTimeKind.Utc).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2022, 10, 7, 14, 28, 41, 421, DateTimeKind.Utc).AddTicks(9173));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Archived",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("36e3555a-4d12-455b-9915-17260e798840"),
                column: "CreationDate",
                value: new DateTime(2022, 8, 27, 3, 34, 38, 512, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("611622e1-5c10-4e7e-a7d5-43d1457179d7"),
                column: "CreationDate",
                value: new DateTime(2022, 8, 27, 3, 34, 38, 512, DateTimeKind.Utc).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("822bea15-489a-49ac-bc05-32cc6a05e2ec"),
                column: "CreationDate",
                value: new DateTime(2022, 8, 27, 3, 34, 38, 512, DateTimeKind.Utc).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ae942935-a413-4c83-8d0f-5c87ed468f79"),
                column: "CreationDate",
                value: new DateTime(2022, 8, 27, 3, 34, 38, 512, DateTimeKind.Utc).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c67a4aff-699f-4ba2-8513-7731864c6efe"),
                column: "CreationDate",
                value: new DateTime(2022, 8, 27, 3, 34, 38, 512, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f284aa7d-f280-4f81-9435-4b43b24e7bc7"),
                column: "CreationDate",
                value: new DateTime(2022, 8, 27, 3, 34, 38, 512, DateTimeKind.Utc).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("faea9f16-a461-463d-a70e-051fb130fbd0"),
                column: "CreationDate",
                value: new DateTime(2022, 8, 27, 3, 34, 38, 512, DateTimeKind.Utc).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 8, 27, 3, 34, 38, 512, DateTimeKind.Utc).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 8, 27, 3, 34, 38, 512, DateTimeKind.Utc).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 8, 27, 3, 34, 38, 512, DateTimeKind.Utc).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 8, 27, 3, 34, 38, 512, DateTimeKind.Utc).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 8, 27, 3, 34, 38, 512, DateTimeKind.Utc).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 8, 27, 3, 34, 38, 512, DateTimeKind.Utc).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2022, 8, 27, 3, 34, 38, 512, DateTimeKind.Utc).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2022, 8, 27, 3, 34, 38, 512, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2022, 8, 27, 3, 34, 38, 512, DateTimeKind.Utc).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2022, 8, 27, 3, 34, 38, 512, DateTimeKind.Utc).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2022, 8, 27, 3, 34, 38, 512, DateTimeKind.Utc).AddTicks(6626));
        }
    }
}
