using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt_Zarzadzanie_Rezerwacjami.Migrations
{
    /// <inheritdoc />
    public partial class newfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("DELETE FROM dbo.Rezerwacja");


            migrationBuilder.AddColumn<int>(
                name: "DurationTemp",
                table: "Rezerwacja",
                nullable: true);


            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Rezerwacja");


            migrationBuilder.RenameColumn(
                name: "DurationTemp",
                table: "Rezerwacja",
                newName: "Duration");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<DateTime>(
                name: "DurationTemp",
                table: "Rezerwacja",
                type: "datetime2",
                nullable: false,
                defaultValue: DateTime.Now);

            migrationBuilder.DropColumn("Duration", "Rezerwacja");

            migrationBuilder.RenameColumn("DurationTemp", "Rezerwacja", "Duration");
        }
    }
}
