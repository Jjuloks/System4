using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt_Zarzadzanie_Rezerwacjami.Migrations
{
    /// <inheritdoc />
    public partial class fixxx2 : Migration
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
