using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PushYourLimits.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddDailyGoal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DailyGoal",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DailyGoal",
                table: "Users");
        }
    }
}
