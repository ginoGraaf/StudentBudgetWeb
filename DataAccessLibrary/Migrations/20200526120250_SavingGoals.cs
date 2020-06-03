using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLibrary.Migrations
{
    public partial class SavingGoals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SavingGoals",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(nullable: false),
                    GoalName = table.Column<string>(nullable: true),
                    savingAmount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavingGoals", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SavingGoals");
        }
    }
}
