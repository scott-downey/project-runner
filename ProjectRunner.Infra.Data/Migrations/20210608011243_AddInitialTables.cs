using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectRunner.Infra.Data.Migrations
{
    public partial class AddInitialTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Executables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "Varchar(100)", nullable: true),
                    FileName = table.Column<string>(type: "Varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Executables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "Varchar(100)", nullable: false),
                    Path = table.Column<string>(type: "Varchar(255)", nullable: false),
                    ExecutableId = table.Column<int>(type: "Int(10)", nullable: false),
                    ExecutableArguments = table.Column<string>(type: "Varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Executables_ExecutableId",
                        column: x => x.ExecutableId,
                        principalTable: "Executables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ExecutableId",
                table: "Projects",
                column: "ExecutableId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Executables");
        }
    }
}
