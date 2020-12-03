using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DigiTours.Migrations
{
    public partial class TourAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Tour",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "Tour",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZipCode",
                table: "Tour",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Tour");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Tour");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Tour");
        }
    }
}
