using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TracersCafeLoyaltyScheme.Migrations
{
    public partial class updateCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Customer");

            migrationBuilder.AddColumn<string>(
                name: "Adress1",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Adress2",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Adress3",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Adress4",
                table: "Customer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress1",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Adress2",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Adress3",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Adress4",
                table: "Customer");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
