using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LabiryntBackend.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mazes",
                columns: table => new
                {
                    id_maze = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seed = table.Column<int>(type: "int", nullable: true),
                    cols = table.Column<long>(type: "bigint", nullable: true),
                    rows = table.Column<long>(type: "bigint", nullable: true),
                    startXY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    exitCoords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_user = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mazes", x => x.id_maze);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id_user = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id_user);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mazes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
