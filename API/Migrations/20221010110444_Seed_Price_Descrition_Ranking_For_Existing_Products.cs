using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class Seed_Price_Descrition_Ranking_For_Existing_Products : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "ProductDescription",
                columns: new[] { "Id", "CreationDate", "Description" },
                values: new object[,]
                {
                    { new Guid("36e3555a-4d12-455b-9915-17260e798840"), new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3381), "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Odio eligendi similique exercitationem optio libero vitae accusamus cupiditate laborum eos." },
                    { new Guid("611622e1-5c10-4e7e-a7d5-43d1457179d7"), new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3384), "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Odio eligendi similique exercitationem optio libero vitae accusamus cupiditate laborum eos." },
                    { new Guid("822bea15-489a-49ac-bc05-32cc6a05e2ec"), new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3392), "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Odio eligendi similique exercitationem optio libero vitae accusamus cupiditate laborum eos." },
                    { new Guid("ae942935-a413-4c83-8d0f-5c87ed468f79"), new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3386), "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Odio eligendi similique exercitationem optio libero vitae accusamus cupiditate laborum eos." },
                    { new Guid("c67a4aff-699f-4ba2-8513-7731864c6efe"), new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3389), "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Odio eligendi similique exercitationem optio libero vitae accusamus cupiditate laborum eos." },
                    { new Guid("f284aa7d-f280-4f81-9435-4b43b24e7bc7"), new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3370), "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Odio eligendi similique exercitationem optio libero vitae accusamus cupiditate laborum eos." },
                    { new Guid("faea9f16-a461-463d-a70e-051fb130fbd0"), new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3395), "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Odio eligendi similique exercitationem optio libero vitae accusamus cupiditate laborum eos." }
                });

            migrationBuilder.InsertData(
                table: "ProductPrice",
                columns: new[] { "Id", "CreationDate", "Price" },
                values: new object[,]
                {
                    { new Guid("36e3555a-4d12-455b-9915-17260e798840"), new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3472), 0.99m },
                    { new Guid("611622e1-5c10-4e7e-a7d5-43d1457179d7"), new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3474), 0.99m },
                    { new Guid("822bea15-489a-49ac-bc05-32cc6a05e2ec"), new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3479), 0.99m },
                    { new Guid("ae942935-a413-4c83-8d0f-5c87ed468f79"), new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3475), 0.99m },
                    { new Guid("c67a4aff-699f-4ba2-8513-7731864c6efe"), new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3477), 0.99m },
                    { new Guid("f284aa7d-f280-4f81-9435-4b43b24e7bc7"), new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3441), 0.99m },
                    { new Guid("faea9f16-a461-463d-a70e-051fb130fbd0"), new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3480), 0.99m }
                });

            migrationBuilder.InsertData(
                table: "ProductRanking",
                columns: new[] { "Id", "CreationDate", "Rank" },
                values: new object[,]
                {
                    { new Guid("36e3555a-4d12-455b-9915-17260e798840"), new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3516), (short)3 },
                    { new Guid("611622e1-5c10-4e7e-a7d5-43d1457179d7"), new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3518), (short)3 },
                    { new Guid("822bea15-489a-49ac-bc05-32cc6a05e2ec"), new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3521), (short)3 },
                    { new Guid("ae942935-a413-4c83-8d0f-5c87ed468f79"), new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3519), (short)3 },
                    { new Guid("c67a4aff-699f-4ba2-8513-7731864c6efe"), new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3520), (short)3 },
                    { new Guid("f284aa7d-f280-4f81-9435-4b43b24e7bc7"), new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3513), (short)3 },
                    { new Guid("faea9f16-a461-463d-a70e-051fb130fbd0"), new DateTime(2022, 10, 10, 11, 4, 44, 483, DateTimeKind.Utc).AddTicks(3522), (short)3 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductDescription",
                keyColumn: "Id",
                keyValue: new Guid("36e3555a-4d12-455b-9915-17260e798840"));

            migrationBuilder.DeleteData(
                table: "ProductDescription",
                keyColumn: "Id",
                keyValue: new Guid("611622e1-5c10-4e7e-a7d5-43d1457179d7"));

            migrationBuilder.DeleteData(
                table: "ProductDescription",
                keyColumn: "Id",
                keyValue: new Guid("822bea15-489a-49ac-bc05-32cc6a05e2ec"));

            migrationBuilder.DeleteData(
                table: "ProductDescription",
                keyColumn: "Id",
                keyValue: new Guid("ae942935-a413-4c83-8d0f-5c87ed468f79"));

            migrationBuilder.DeleteData(
                table: "ProductDescription",
                keyColumn: "Id",
                keyValue: new Guid("c67a4aff-699f-4ba2-8513-7731864c6efe"));

            migrationBuilder.DeleteData(
                table: "ProductDescription",
                keyColumn: "Id",
                keyValue: new Guid("f284aa7d-f280-4f81-9435-4b43b24e7bc7"));

            migrationBuilder.DeleteData(
                table: "ProductDescription",
                keyColumn: "Id",
                keyValue: new Guid("faea9f16-a461-463d-a70e-051fb130fbd0"));

            migrationBuilder.DeleteData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: new Guid("36e3555a-4d12-455b-9915-17260e798840"));

            migrationBuilder.DeleteData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: new Guid("611622e1-5c10-4e7e-a7d5-43d1457179d7"));

            migrationBuilder.DeleteData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: new Guid("822bea15-489a-49ac-bc05-32cc6a05e2ec"));

            migrationBuilder.DeleteData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: new Guid("ae942935-a413-4c83-8d0f-5c87ed468f79"));

            migrationBuilder.DeleteData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: new Guid("c67a4aff-699f-4ba2-8513-7731864c6efe"));

            migrationBuilder.DeleteData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: new Guid("f284aa7d-f280-4f81-9435-4b43b24e7bc7"));

            migrationBuilder.DeleteData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: new Guid("faea9f16-a461-463d-a70e-051fb130fbd0"));

            migrationBuilder.DeleteData(
                table: "ProductRanking",
                keyColumn: "Id",
                keyValue: new Guid("36e3555a-4d12-455b-9915-17260e798840"));

            migrationBuilder.DeleteData(
                table: "ProductRanking",
                keyColumn: "Id",
                keyValue: new Guid("611622e1-5c10-4e7e-a7d5-43d1457179d7"));

            migrationBuilder.DeleteData(
                table: "ProductRanking",
                keyColumn: "Id",
                keyValue: new Guid("822bea15-489a-49ac-bc05-32cc6a05e2ec"));

            migrationBuilder.DeleteData(
                table: "ProductRanking",
                keyColumn: "Id",
                keyValue: new Guid("ae942935-a413-4c83-8d0f-5c87ed468f79"));

            migrationBuilder.DeleteData(
                table: "ProductRanking",
                keyColumn: "Id",
                keyValue: new Guid("c67a4aff-699f-4ba2-8513-7731864c6efe"));

            migrationBuilder.DeleteData(
                table: "ProductRanking",
                keyColumn: "Id",
                keyValue: new Guid("f284aa7d-f280-4f81-9435-4b43b24e7bc7"));

            migrationBuilder.DeleteData(
                table: "ProductRanking",
                keyColumn: "Id",
                keyValue: new Guid("faea9f16-a461-463d-a70e-051fb130fbd0"));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("36e3555a-4d12-455b-9915-17260e798840"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("611622e1-5c10-4e7e-a7d5-43d1457179d7"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("822bea15-489a-49ac-bc05-32cc6a05e2ec"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ae942935-a413-4c83-8d0f-5c87ed468f79"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c67a4aff-699f-4ba2-8513-7731864c6efe"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f284aa7d-f280-4f81-9435-4b43b24e7bc7"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("faea9f16-a461-463d-a70e-051fb130fbd0"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1512));
        }
    }
}
