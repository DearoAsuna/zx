using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFcore1.Migrations
{
    /// <inheritdoc />
    public partial class Addhight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "hight",
                table: "T_Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "hight",
                table: "T_Persons");
        }
    }
}
