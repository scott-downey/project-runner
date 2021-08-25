using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectRunner.Infra.Data.Migrations
{
    public partial class AddProccessIdColumnToProjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Executables_ExecutableId",
                table: "Projects");

            migrationBuilder.AddColumn<long>(
                name: "ProcessId",
                table: "Projects",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Executables",
                type: "Varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "Varchar(255)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "Executables",
                type: "Varchar(255)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "Varchar(255)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Executables_ExecutableId",
                table: "Projects",
                column: "ExecutableId",
                principalTable: "Executables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Executables_ExecutableId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProcessId",
                table: "Projects");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Executables",
                type: "Varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Path",
                table: "Executables",
                type: "Varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(255)");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Executables_ExecutableId",
                table: "Projects",
                column: "ExecutableId",
                principalTable: "Executables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
