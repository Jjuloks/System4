using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt_Zarzadzanie_Rezerwacjami.Migrations
{
    /// <inheritdoc />
    public partial class fixingproblemwithfield : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "Rezerwacja",
                type: "int",
                nullable: true, 
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Duration",
                table: "Rezerwacja",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
