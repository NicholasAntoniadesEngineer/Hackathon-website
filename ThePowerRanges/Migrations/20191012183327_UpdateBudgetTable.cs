using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThePowerRanges.Migrations
{
    public partial class UpdateBudgetTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Month",
                table: "Budget",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Month",
                table: "Budget",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
