using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF3.Migrations
{
    /// <inheritdoc />
    public partial class bool1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeletede",
                table: "T_Article",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeletede",
                table: "T_Article");
        }
    }
}
