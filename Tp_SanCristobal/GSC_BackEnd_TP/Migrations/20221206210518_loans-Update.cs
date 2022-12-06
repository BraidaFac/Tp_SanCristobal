using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GSC_BackEnd_TP.Migrations
{
    public partial class loansUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Loans");

            migrationBuilder.AddColumn<DateTime>(
                name: "AgreeDate",
                table: "Loans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateReturnedLoan",
                table: "Loans",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgreeDate",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "DateReturnedLoan",
                table: "Loans");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Loans",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
