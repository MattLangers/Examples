using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_ProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductType",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 23, 9, 31, 33, 73, DateTimeKind.Utc).AddTicks(4646), "Boiled" },
                    { 2, new DateTime(2022, 8, 23, 9, 31, 33, 73, DateTimeKind.Utc).AddTicks(4667), "Chewy" },
                    { 3, new DateTime(2022, 8, 23, 9, 31, 33, 73, DateTimeKind.Utc).AddTicks(4672), "BubbleGum" },
                    { 4, new DateTime(2022, 8, 23, 9, 31, 33, 73, DateTimeKind.Utc).AddTicks(4673), "Fizzy" },
                    { 5, new DateTime(2022, 8, 23, 9, 31, 33, 73, DateTimeKind.Utc).AddTicks(4675), "Marshmallow" },
                    { 6, new DateTime(2022, 8, 23, 9, 31, 33, 73, DateTimeKind.Utc).AddTicks(4677), "Jellies" },
                    { 7, new DateTime(2022, 8, 23, 9, 31, 33, 73, DateTimeKind.Utc).AddTicks(4679), "Liquorice" },
                    { 8, new DateTime(2022, 8, 23, 9, 31, 33, 73, DateTimeKind.Utc).AddTicks(4680), "Lollipops" },
                    { 9, new DateTime(2022, 8, 23, 9, 31, 33, 73, DateTimeKind.Utc).AddTicks(4682), "Mints" },
                    { 10, new DateTime(2022, 8, 23, 9, 31, 33, 73, DateTimeKind.Utc).AddTicks(4683), "Sherbet" },
                    { 11, new DateTime(2022, 8, 23, 9, 31, 33, 73, DateTimeKind.Utc).AddTicks(4684), "Chocolate" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductTypeId",
                table: "Product",
                column: "ProductTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ProductType");
        }
    }
}
