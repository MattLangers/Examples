using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class Product_PriceHIstory_DescriptionHistory_RankHistory_Schema_Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ToDescription",
                table: "ProductDescriptionHistory",
                newName: "To");

            migrationBuilder.RenameColumn(
                name: "FromDescription",
                table: "ProductDescriptionHistory",
                newName: "From");

            migrationBuilder.AlterColumn<byte>(
                name: "To",
                table: "ProductRankingHistory",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("36e3555a-4d12-455b-9915-17260e798840"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("611622e1-5c10-4e7e-a7d5-43d1457179d7"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("822bea15-489a-49ac-bc05-32cc6a05e2ec"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ae942935-a413-4c83-8d0f-5c87ed468f79"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c67a4aff-699f-4ba2-8513-7731864c6efe"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f284aa7d-f280-4f81-9435-4b43b24e7bc7"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("faea9f16-a461-463d-a70e-051fb130fbd0"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "ProductDescription",
                keyColumn: "Id",
                keyValue: new Guid("36e3555a-4d12-455b-9915-17260e798840"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "ProductDescription",
                keyColumn: "Id",
                keyValue: new Guid("611622e1-5c10-4e7e-a7d5-43d1457179d7"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "ProductDescription",
                keyColumn: "Id",
                keyValue: new Guid("822bea15-489a-49ac-bc05-32cc6a05e2ec"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "ProductDescription",
                keyColumn: "Id",
                keyValue: new Guid("ae942935-a413-4c83-8d0f-5c87ed468f79"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "ProductDescription",
                keyColumn: "Id",
                keyValue: new Guid("c67a4aff-699f-4ba2-8513-7731864c6efe"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "ProductDescription",
                keyColumn: "Id",
                keyValue: new Guid("f284aa7d-f280-4f81-9435-4b43b24e7bc7"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "ProductDescription",
                keyColumn: "Id",
                keyValue: new Guid("faea9f16-a461-463d-a70e-051fb130fbd0"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: new Guid("36e3555a-4d12-455b-9915-17260e798840"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: new Guid("611622e1-5c10-4e7e-a7d5-43d1457179d7"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: new Guid("822bea15-489a-49ac-bc05-32cc6a05e2ec"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: new Guid("ae942935-a413-4c83-8d0f-5c87ed468f79"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: new Guid("c67a4aff-699f-4ba2-8513-7731864c6efe"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: new Guid("f284aa7d-f280-4f81-9435-4b43b24e7bc7"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: new Guid("faea9f16-a461-463d-a70e-051fb130fbd0"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "ProductRanking",
                keyColumn: "Id",
                keyValue: new Guid("36e3555a-4d12-455b-9915-17260e798840"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "ProductRanking",
                keyColumn: "Id",
                keyValue: new Guid("611622e1-5c10-4e7e-a7d5-43d1457179d7"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "ProductRanking",
                keyColumn: "Id",
                keyValue: new Guid("822bea15-489a-49ac-bc05-32cc6a05e2ec"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "ProductRanking",
                keyColumn: "Id",
                keyValue: new Guid("ae942935-a413-4c83-8d0f-5c87ed468f79"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "ProductRanking",
                keyColumn: "Id",
                keyValue: new Guid("c67a4aff-699f-4ba2-8513-7731864c6efe"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "ProductRanking",
                keyColumn: "Id",
                keyValue: new Guid("f284aa7d-f280-4f81-9435-4b43b24e7bc7"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "ProductRanking",
                keyColumn: "Id",
                keyValue: new Guid("faea9f16-a461-463d-a70e-051fb130fbd0"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 13, 24, 5, 527, DateTimeKind.Utc).AddTicks(3622));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "To",
                table: "ProductDescriptionHistory",
                newName: "ToDescription");

            migrationBuilder.RenameColumn(
                name: "From",
                table: "ProductDescriptionHistory",
                newName: "FromDescription");

            migrationBuilder.AlterColumn<int>(
                name: "To",
                table: "ProductRankingHistory",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("36e3555a-4d12-455b-9915-17260e798840"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("611622e1-5c10-4e7e-a7d5-43d1457179d7"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("822bea15-489a-49ac-bc05-32cc6a05e2ec"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ae942935-a413-4c83-8d0f-5c87ed468f79"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c67a4aff-699f-4ba2-8513-7731864c6efe"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f284aa7d-f280-4f81-9435-4b43b24e7bc7"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("faea9f16-a461-463d-a70e-051fb130fbd0"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "ProductDescription",
                keyColumn: "Id",
                keyValue: new Guid("36e3555a-4d12-455b-9915-17260e798840"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "ProductDescription",
                keyColumn: "Id",
                keyValue: new Guid("611622e1-5c10-4e7e-a7d5-43d1457179d7"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "ProductDescription",
                keyColumn: "Id",
                keyValue: new Guid("822bea15-489a-49ac-bc05-32cc6a05e2ec"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "ProductDescription",
                keyColumn: "Id",
                keyValue: new Guid("ae942935-a413-4c83-8d0f-5c87ed468f79"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "ProductDescription",
                keyColumn: "Id",
                keyValue: new Guid("c67a4aff-699f-4ba2-8513-7731864c6efe"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "ProductDescription",
                keyColumn: "Id",
                keyValue: new Guid("f284aa7d-f280-4f81-9435-4b43b24e7bc7"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "ProductDescription",
                keyColumn: "Id",
                keyValue: new Guid("faea9f16-a461-463d-a70e-051fb130fbd0"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: new Guid("36e3555a-4d12-455b-9915-17260e798840"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: new Guid("611622e1-5c10-4e7e-a7d5-43d1457179d7"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: new Guid("822bea15-489a-49ac-bc05-32cc6a05e2ec"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: new Guid("ae942935-a413-4c83-8d0f-5c87ed468f79"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: new Guid("c67a4aff-699f-4ba2-8513-7731864c6efe"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: new Guid("f284aa7d-f280-4f81-9435-4b43b24e7bc7"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: new Guid("faea9f16-a461-463d-a70e-051fb130fbd0"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "ProductRanking",
                keyColumn: "Id",
                keyValue: new Guid("36e3555a-4d12-455b-9915-17260e798840"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "ProductRanking",
                keyColumn: "Id",
                keyValue: new Guid("611622e1-5c10-4e7e-a7d5-43d1457179d7"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "ProductRanking",
                keyColumn: "Id",
                keyValue: new Guid("822bea15-489a-49ac-bc05-32cc6a05e2ec"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "ProductRanking",
                keyColumn: "Id",
                keyValue: new Guid("ae942935-a413-4c83-8d0f-5c87ed468f79"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "ProductRanking",
                keyColumn: "Id",
                keyValue: new Guid("c67a4aff-699f-4ba2-8513-7731864c6efe"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "ProductRanking",
                keyColumn: "Id",
                keyValue: new Guid("f284aa7d-f280-4f81-9435-4b43b24e7bc7"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "ProductRanking",
                keyColumn: "Id",
                keyValue: new Guid("faea9f16-a461-463d-a70e-051fb130fbd0"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(1269));
        }
    }
}
