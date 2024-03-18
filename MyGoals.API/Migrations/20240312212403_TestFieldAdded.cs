using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGoals.API.Migrations
{
    /// <inheritdoc />
    public partial class TestFieldAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeRequests_Employees_EmployeeId1",
                table: "EmployeeRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeRequests_GroupRequests_GroupRequestId1",
                table: "EmployeeRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeRequests_Periods_PeriodId1",
                table: "EmployeeRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeRequests_RequestStatuses_RequestStatusId1",
                table: "EmployeeRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_Goals_Employees_EmployeeId1",
                table: "Goals");

            migrationBuilder.DropForeignKey(
                name: "FK_Goals_GoalTypes_GoalTypeId1",
                table: "Goals");

            migrationBuilder.DropForeignKey(
                name: "FK_Goals_KeyResultTypes_KeyResultTypeId1",
                table: "Goals");

            migrationBuilder.DropForeignKey(
                name: "FK_Goals_Periods_PeriodId1",
                table: "Goals");

            migrationBuilder.DropForeignKey(
                name: "FK_Goals_TypicalGoals_TypicalGoalId1",
                table: "Goals");

            migrationBuilder.DropIndex(
                name: "IX_Goals_EmployeeId1",
                table: "Goals");

            migrationBuilder.DropIndex(
                name: "IX_Goals_GoalTypeId1",
                table: "Goals");

            migrationBuilder.DropIndex(
                name: "IX_Goals_KeyResultTypeId1",
                table: "Goals");

            migrationBuilder.DropIndex(
                name: "IX_Goals_PeriodId1",
                table: "Goals");

            migrationBuilder.DropIndex(
                name: "IX_Goals_TypicalGoalId1",
                table: "Goals");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeRequests_EmployeeId1",
                table: "EmployeeRequests");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeRequests_GroupRequestId1",
                table: "EmployeeRequests");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeRequests_PeriodId1",
                table: "EmployeeRequests");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeRequests_RequestStatusId1",
                table: "EmployeeRequests");

            migrationBuilder.DropColumn(
                name: "EmployeeId1",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "GoalTypeId1",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "KeyResultTypeId1",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "PeriodId1",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "TypicalGoalId1",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "EmployeeId1",
                table: "EmployeeRequests");

            migrationBuilder.DropColumn(
                name: "GroupRequestId1",
                table: "EmployeeRequests");

            migrationBuilder.DropColumn(
                name: "PeriodId1",
                table: "EmployeeRequests");

            migrationBuilder.DropColumn(
                name: "RequestStatusId1",
                table: "EmployeeRequests");

            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "BusinessProcessStages",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "BusinessProcessStages");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId1",
                table: "Goals",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GoalTypeId1",
                table: "Goals",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KeyResultTypeId1",
                table: "Goals",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PeriodId1",
                table: "Goals",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypicalGoalId1",
                table: "Goals",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId1",
                table: "EmployeeRequests",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GroupRequestId1",
                table: "EmployeeRequests",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PeriodId1",
                table: "EmployeeRequests",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RequestStatusId1",
                table: "EmployeeRequests",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Goals_EmployeeId1",
                table: "Goals",
                column: "EmployeeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Goals_GoalTypeId1",
                table: "Goals",
                column: "GoalTypeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Goals_KeyResultTypeId1",
                table: "Goals",
                column: "KeyResultTypeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Goals_PeriodId1",
                table: "Goals",
                column: "PeriodId1");

            migrationBuilder.CreateIndex(
                name: "IX_Goals_TypicalGoalId1",
                table: "Goals",
                column: "TypicalGoalId1");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRequests_EmployeeId1",
                table: "EmployeeRequests",
                column: "EmployeeId1");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRequests_GroupRequestId1",
                table: "EmployeeRequests",
                column: "GroupRequestId1");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRequests_PeriodId1",
                table: "EmployeeRequests",
                column: "PeriodId1");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRequests_RequestStatusId1",
                table: "EmployeeRequests",
                column: "RequestStatusId1");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeRequests_Employees_EmployeeId1",
                table: "EmployeeRequests",
                column: "EmployeeId1",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeRequests_GroupRequests_GroupRequestId1",
                table: "EmployeeRequests",
                column: "GroupRequestId1",
                principalTable: "GroupRequests",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeRequests_Periods_PeriodId1",
                table: "EmployeeRequests",
                column: "PeriodId1",
                principalTable: "Periods",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeRequests_RequestStatuses_RequestStatusId1",
                table: "EmployeeRequests",
                column: "RequestStatusId1",
                principalTable: "RequestStatuses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Goals_Employees_EmployeeId1",
                table: "Goals",
                column: "EmployeeId1",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Goals_GoalTypes_GoalTypeId1",
                table: "Goals",
                column: "GoalTypeId1",
                principalTable: "GoalTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Goals_KeyResultTypes_KeyResultTypeId1",
                table: "Goals",
                column: "KeyResultTypeId1",
                principalTable: "KeyResultTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Goals_Periods_PeriodId1",
                table: "Goals",
                column: "PeriodId1",
                principalTable: "Periods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Goals_TypicalGoals_TypicalGoalId1",
                table: "Goals",
                column: "TypicalGoalId1",
                principalTable: "TypicalGoals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
