using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThePowerRanges.Migrations
{
    public partial class YY_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseCollection_Amounts_Amounts_Id",
                table: "ExpenseCollection");

            migrationBuilder.DropTable(
                name: "Amounts");

            migrationBuilder.DropIndex(
                name: "IX_ExpenseCollection_Amounts_Id",
                table: "ExpenseCollection");

            migrationBuilder.DropColumn(
                name: "Amounts_Id",
                table: "ExpenseCollection");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Amounts_Id",
                table: "ExpenseCollection",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Amounts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amounts", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseCollection_Amounts_Id",
                table: "ExpenseCollection",
                column: "Amounts_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseCollection_Amounts_Amounts_Id",
                table: "ExpenseCollection",
                column: "Amounts_Id",
                principalTable: "Amounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
