using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LabiryntBackend.Migrations
{
    /// <inheritdoc />
    public partial class fk2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mazes_Users_userid_user",
                table: "Mazes");

            migrationBuilder.DropIndex(
                name: "IX_Mazes_userid_user",
                table: "Mazes");

            migrationBuilder.DropColumn(
                name: "userid_user",
                table: "Mazes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "userid_user",
                table: "Mazes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Mazes_userid_user",
                table: "Mazes",
                column: "userid_user");

            migrationBuilder.AddForeignKey(
                name: "FK_Mazes_Users_userid_user",
                table: "Mazes",
                column: "userid_user",
                principalTable: "Users",
                principalColumn: "id_user",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
