using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLibrary.Migrations
{
    public partial class AddFloat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "savingAmount",
                table: "SavingGoals",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "savingAmount",
                table: "SavingGoals",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
