using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DigiTours.Migrations
{
    public partial class TourBidTourField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TourID",
                table: "TourBids",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TourBids_TourID",
                table: "TourBids",
                column: "TourID");

            migrationBuilder.AddForeignKey(
                name: "FK_TourBids_Tour_TourID",
                table: "TourBids",
                column: "TourID",
                principalTable: "Tour",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TourBids_Tour_TourID",
                table: "TourBids");

            migrationBuilder.DropIndex(
                name: "IX_TourBids_TourID",
                table: "TourBids");

            migrationBuilder.DropColumn(
                name: "TourID",
                table: "TourBids");
        }
    }
}
