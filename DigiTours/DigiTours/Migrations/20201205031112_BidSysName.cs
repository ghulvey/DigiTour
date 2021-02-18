using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DigiTours.Migrations
{
    public partial class BidSysName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TourBid",
                table: "TourBid");

            migrationBuilder.RenameTable(
                name: "TourBid",
                newName: "TourBids");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TourBids",
                table: "TourBids",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TourBids",
                table: "TourBids");

            migrationBuilder.RenameTable(
                name: "TourBids",
                newName: "TourBid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TourBid",
                table: "TourBid",
                column: "ID");
        }
    }
}
