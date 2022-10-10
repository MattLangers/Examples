using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class Product_Price_Description_Ranking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductDescription",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDescription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDescription_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductPrice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "smallmoney", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPrice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductPrice_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductRanking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rank = table.Column<short>(type: "smallint", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductRanking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductRanking_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("36e3555a-4d12-455b-9915-17260e798840"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 9, 30, 33, 453, DateTimeKind.Utc).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("611622e1-5c10-4e7e-a7d5-43d1457179d7"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 9, 30, 33, 453, DateTimeKind.Utc).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("822bea15-489a-49ac-bc05-32cc6a05e2ec"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 9, 30, 33, 453, DateTimeKind.Utc).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ae942935-a413-4c83-8d0f-5c87ed468f79"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 9, 30, 33, 453, DateTimeKind.Utc).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c67a4aff-699f-4ba2-8513-7731864c6efe"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 9, 30, 33, 453, DateTimeKind.Utc).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f284aa7d-f280-4f81-9435-4b43b24e7bc7"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 9, 30, 33, 453, DateTimeKind.Utc).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("faea9f16-a461-463d-a70e-051fb130fbd0"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 9, 30, 33, 453, DateTimeKind.Utc).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 9, 30, 33, 453, DateTimeKind.Utc).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 9, 30, 33, 453, DateTimeKind.Utc).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 9, 30, 33, 453, DateTimeKind.Utc).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 9, 30, 33, 453, DateTimeKind.Utc).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 9, 30, 33, 453, DateTimeKind.Utc).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 9, 30, 33, 453, DateTimeKind.Utc).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 9, 30, 33, 453, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 9, 30, 33, 453, DateTimeKind.Utc).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 9, 30, 33, 453, DateTimeKind.Utc).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 9, 30, 33, 453, DateTimeKind.Utc).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2022, 10, 10, 9, 30, 33, 453, DateTimeKind.Utc).AddTicks(6965));

            migrationBuilder.CreateIndex(
                name: "IX_ProductDescription_ProductId",
                table: "ProductDescription",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_ProductId",
                table: "ProductPrice",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductRanking_ProductId",
                table: "ProductRanking",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductDescription");

            migrationBuilder.DropTable(
                name: "ProductPrice");

            migrationBuilder.DropTable(
                name: "ProductRanking");

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
    }
}
