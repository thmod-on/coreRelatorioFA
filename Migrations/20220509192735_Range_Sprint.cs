using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreRelatorioFA.Migrations
{
    public partial class Range_Sprint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Range",
                newName: "SprintID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SprintID",
                table: "Range",
                newName: "ID");
        }
    }
}
