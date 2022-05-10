using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreRelatorioFA.Migrations
{
    public partial class Range_Sprint2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sprint",
                columns: table => new
                {
                    SprintID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sprint", x => x.SprintID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Sprint",
                table: "Sprint");

            migrationBuilder.RenameTable(
                name: "Sprint",
                newName: "Range");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Range",
                table: "Range",
                column: "SprintID");
        }
    }
}
