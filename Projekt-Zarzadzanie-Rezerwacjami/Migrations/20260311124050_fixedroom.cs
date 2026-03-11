using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt_Zarzadzanie_Rezerwacjami.Migrations
{
    /// <inheritdoc />
    public partial class fixedroom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezerwacja_Room_RoomId",
                table: "Rezerwacja");

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "Rezerwacja",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezerwacja_Room_RoomId",
                table: "Rezerwacja",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "SalaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezerwacja_Room_RoomId",
                table: "Rezerwacja");

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "Rezerwacja",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Rezerwacja_Room_RoomId",
                table: "Rezerwacja",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "SalaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
