using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace People_Manager.Migrations
{
    /// <inheritdoc />
    public partial class second_database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Person",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TipoSanguineo",
                table: "Person",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "TipoSanguineo",
                table: "Person");
        }
    }
}
