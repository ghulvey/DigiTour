using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DigiTours.Migrations
{
    public partial class TourUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TourBids_Tour_TourID",
                table: "TourBids");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tour",
                table: "Tour");

            migrationBuilder.RenameTable(
                name: "Tour",
                newName: "Tours");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tours",
                table: "Tours",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TourBids_Tours_TourID",
                table: "TourBids",
                column: "TourID",
                principalTable: "Tours",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TourBids_Tours_TourID",
                table: "TourBids");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tours",
                table: "Tours");

            migrationBuilder.RenameTable(
                name: "Tours",
                newName: "Tour");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tour",
                table: "Tour",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TourBids_Tour_TourID",
                table: "TourBids",
                column: "TourID",
                principalTable: "Tour",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
