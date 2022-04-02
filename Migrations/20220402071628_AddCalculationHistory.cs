using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalculationAppNew.Migrations
{
    public partial class AddCalculationHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IncomeName",
                table: "Incomes",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "ExpenseName",
                table: "Expenses",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.CreateTable(
                name: "CalculationHistories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DailyExpense = table.Column<double>(type: "REAL", nullable: false),
                    Splurge = table.Column<double>(type: "REAL", nullable: false),
                    FireExtinguisher = table.Column<double>(type: "REAL", nullable: false),
                    Smile = table.Column<double>(type: "REAL", nullable: false),
                    Mojo = table.Column<string>(type: "TEXT", nullable: true),
                    Grow = table.Column<double>(type: "REAL", nullable: false),
                    WhenAdded = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculationHistories", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalculationHistories");

            migrationBuilder.AlterColumn<string>(
                name: "IncomeName",
                table: "Incomes",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExpenseName",
                table: "Expenses",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
