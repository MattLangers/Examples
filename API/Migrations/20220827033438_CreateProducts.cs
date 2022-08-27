using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class CreateProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name", "ProductTypeId" },
                values: new object[,]
                {
                    { new Guid("36e3555a-4d12-455b-9915-17260e798840"), new DateTime(2022, 8, 27, 3, 34, 38, 512, DateTimeKind.Utc).AddTicks(6750), "Cadbury Creme Egg", 11 },
                    { new Guid("611622e1-5c10-4e7e-a7d5-43d1457179d7"), new DateTime(2022, 8, 27, 3, 34, 38, 512, DateTimeKind.Utc).AddTicks(6754), "Curly Wurly", 11 },
                    { new Guid("822bea15-489a-49ac-bc05-32cc6a05e2ec"), new DateTime(2022, 8, 27, 3, 34, 38, 512, DateTimeKind.Utc).AddTicks(6766), "Jelly Babies", 2 },
                    { new Guid("ae942935-a413-4c83-8d0f-5c87ed468f79"), new DateTime(2022, 8, 27, 3, 34, 38, 512, DateTimeKind.Utc).AddTicks(6757), "Liquorice Allsorts", 7 },
                    { new Guid("c67a4aff-699f-4ba2-8513-7731864c6efe"), new DateTime(2022, 8, 27, 3, 34, 38, 512, DateTimeKind.Utc).AddTicks(6760), "Coconut Mushrooms", 2 },
                    { new Guid("f284aa7d-f280-4f81-9435-4b43b24e7bc7"), new DateTime(2022, 8, 27, 3, 34, 38, 512, DateTimeKind.Utc).AddTicks(6704), "Sherbet Fountain", 10 },
                    { new Guid("faea9f16-a461-463d-a70e-051fb130fbd0"), new DateTime(2022, 8, 27, 3, 34, 38, 512, DateTimeKind.Utc).AddTicks(6769), "Dolly Mixtures", 2 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("36e3555a-4d12-455b-9915-17260e798840"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("611622e1-5c10-4e7e-a7d5-43d1457179d7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("822bea15-489a-49ac-bc05-32cc6a05e2ec"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ae942935-a413-4c83-8d0f-5c87ed468f79"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c67a4aff-699f-4ba2-8513-7731864c6efe"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f284aa7d-f280-4f81-9435-4b43b24e7bc7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("faea9f16-a461-463d-a70e-051fb130fbd0"));

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
    }
}
