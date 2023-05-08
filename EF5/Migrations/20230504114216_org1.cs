using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF5.Migrations
{
    /// <inheritdoc />
    public partial class org1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrgUnit",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrgUnit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrgUnit_OrgUnit_ParentId",
                        column: x => x.ParentId,
                        principalTable: "OrgUnit",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrgUnit_ParentId",
                table: "OrgUnit",
                column: "ParentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrgUnit");
        }
    }
}
