using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RookieShop.Data.Migrations
{
    public partial class Add_Data_DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 24, 16, 2, 18, 898, DateTimeKind.Local).AddTicks(464),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 24, 15, 43, 35, 344, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsShowOnHome", "Name", "ParentId", "SortOrder", "Status" },
                values: new object[,]
                {
                    { 1, true, "Áo thun nam", null, 1, 1 },
                    { 2, true, "Áo Nữ", null, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateCreated", "Description", "Detail", "IsFeatured", "Name", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 24, 16, 2, 18, 899, DateTimeKind.Local).AddTicks(4685), "Áo hoodie dành cho nam", "Áo hoodie nam", null, "Áo Hoodie", 100000m, 200000m },
                    { 2, new DateTime(2022, 2, 24, 16, 2, 18, 899, DateTimeKind.Local).AddTicks(4691), "Áo jacket dành cho nam", "Áo jacket nam", null, "Áo jacket", 100000m, 200000m }
                });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[] { 1, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 24, 15, 43, 35, 344, DateTimeKind.Local).AddTicks(2185),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 24, 16, 2, 18, 898, DateTimeKind.Local).AddTicks(464));
        }
    }
}
