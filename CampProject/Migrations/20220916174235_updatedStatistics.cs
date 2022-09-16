using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CampProject.Migrations
{
    public partial class updatedStatistics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quiz_id",
                table: "Statistics");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quiz_id",
                table: "Statistics",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
