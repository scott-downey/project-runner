using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectRunner.Infra.Data.Migrations
{
    public partial class AddExecutableAndChangeCommandToExecutableArgumentsProjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Executable",
                table: "Projects",
                type: "Varchar(255)",
                nullable: false);

            migrationBuilder.RenameColumn(
                name: "Command",
                newName: "ExecutableArguments",
                table: "Projects");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Executable",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "ExecutableArguments",
                newName: "Command",
                table: "Projects");
        }
    }
}
