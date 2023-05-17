using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ActionFiller.Migrations
{
    /// <inheritdoc />
    public partial class int2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "T_Book");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "T_Book",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
