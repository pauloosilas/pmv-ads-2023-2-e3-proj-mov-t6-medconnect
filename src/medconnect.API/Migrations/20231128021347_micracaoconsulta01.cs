using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace medconnect.API.Migrations
{
    /// <inheritdoc />
    public partial class micracaoconsulta01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isAtiva",
                table: "Consultas",
                type: "tinyint(1)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isAtiva",
                table: "Consultas");
        }
    }
}
