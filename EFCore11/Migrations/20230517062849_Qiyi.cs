using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore11.Migrations
{
    /// <inheritdoc />
    public partial class Qiyi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "T_Book",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "T_Book",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "T_Book",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "T_Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Person", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_Book_PersonId",
                table: "T_Book",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_Book_T_Person_PersonId",
                table: "T_Book",
                column: "PersonId",
                principalTable: "T_Person",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Book_T_Person_PersonId",
                table: "T_Book");

            migrationBuilder.DropTable(
                name: "T_Person");

            migrationBuilder.DropIndex(
                name: "IX_T_Book_PersonId",
                table: "T_Book");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "T_Book");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "T_Book",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "T_Book",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
