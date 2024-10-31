using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace inventory_backend.Migrations
{
    /// <inheritdoc />
    public partial class itemupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BuyingPrice",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateOnly>(
                name: "ItemExpiryDate",
                table: "Items",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<DateOnly>(
                name: "ItemManufactureDate",
                table: "Items",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<int>(
                name: "SellingPrice",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BuyingPrice",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemExpiryDate",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemManufactureDate",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "SellingPrice",
                table: "Items");
        }
    }
}
