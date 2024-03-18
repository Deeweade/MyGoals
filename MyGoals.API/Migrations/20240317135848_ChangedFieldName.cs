using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGoals.API.Migrations
{
    /// <inheritdoc />
    public partial class ChangedFieldName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestStatuses_BusinessProcessStages_GoalStatusId",
                table: "RequestStatuses");

            migrationBuilder.RenameColumn(
                name: "GoalStatusId",
                table: "RequestStatuses",
                newName: "BusinessProcessStageId");

            migrationBuilder.RenameIndex(
                name: "IX_RequestStatuses_GoalStatusId",
                table: "RequestStatuses",
                newName: "IX_RequestStatuses_BusinessProcessStageId");

            migrationBuilder.AlterColumn<int>(
                name: "Code",
                table: "Goals",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "Code",
                table: "EmployeeRequests",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestStatuses_BusinessProcessStages_BusinessProcessStageId",
                table: "RequestStatuses",
                column: "BusinessProcessStageId",
                principalTable: "BusinessProcessStages",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestStatuses_BusinessProcessStages_BusinessProcessStageId",
                table: "RequestStatuses");

            migrationBuilder.RenameColumn(
                name: "BusinessProcessStageId",
                table: "RequestStatuses",
                newName: "GoalStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_RequestStatuses_BusinessProcessStageId",
                table: "RequestStatuses",
                newName: "IX_RequestStatuses_GoalStatusId");

            migrationBuilder.AlterColumn<int>(
                name: "Code",
                table: "Goals",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Code",
                table: "EmployeeRequests",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestStatuses_BusinessProcessStages_GoalStatusId",
                table: "RequestStatuses",
                column: "GoalStatusId",
                principalTable: "BusinessProcessStages",
                principalColumn: "Id");
        }
    }
}
