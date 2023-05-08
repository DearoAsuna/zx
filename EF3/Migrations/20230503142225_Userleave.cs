using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF3.Migrations
{
    /// <inheritdoc />
    public partial class Userleave : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_Leave",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequseterId = table.Column<int>(type: "int", nullable: true),
                    ApproverId = table.Column<int>(type: "int", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Leave", x => x.id);
                    table.ForeignKey(
                        name: "FK_T_Leave_T_Users_ApproverId",
                        column: x => x.ApproverId,
                        principalTable: "T_Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_T_Leave_T_Users_RequseterId",
                        column: x => x.RequseterId,
                        principalTable: "T_Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_Leave_ApproverId",
                table: "T_Leave",
                column: "ApproverId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Leave_RequseterId",
                table: "T_Leave",
                column: "RequseterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_Leave");

            migrationBuilder.DropTable(
                name: "T_Users");
        }
    }
}
