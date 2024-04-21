using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGoals.API.Migrations
{
    /// <inheritdoc />
    public partial class ChangedCommentGoalForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Goals_GoalCode",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "Code",
                table: "Goals",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Goals_Code",
                table: "Goals",
                column: "Code");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Goals_GoalCode",
                table: "Comments",
                column: "GoalCode",
                principalTable: "Goals",
                principalColumn: "Code");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Goals_GoalCode",
                table: "Comments");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Goals_Code",
                table: "Goals");

            migrationBuilder.AlterColumn<int>(
                name: "Code",
                table: "Goals",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Goals_GoalCode",
                table: "Comments",
                column: "GoalCode",
                principalTable: "Goals",
                principalColumn: "Id");
        }
    }
}
