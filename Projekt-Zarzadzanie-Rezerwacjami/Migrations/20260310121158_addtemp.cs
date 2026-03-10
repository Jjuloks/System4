using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt_Zarzadzanie_Rezerwacjami.Migrations
{
    /// <inheritdoc />
    public partial class addtemp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("Duration", "Rezerwacja");

            migrationBuilder.AddColumn<int>(
    name: "DurationTemp",
    table: "Rezerwacja",
    nullable: true);
        }





        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
