using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGoals.API.Migrations
{
    /// <inheritdoc />
    public partial class GoalNullReferencesEnabled : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goals_EmployeeRequests_EmployeeRequestCode",
                table: "Goals");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeRequestCode",
                table: "Goals",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Goals_EmployeeRequests_EmployeeRequestCode",
                table: "Goals",
                column: "EmployeeRequestCode",
                principalTable: "EmployeeRequests",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goals_EmployeeRequests_EmployeeRequestCode",
                table: "Goals");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeRequestCode",
                table: "Goals",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Goals_EmployeeRequests_EmployeeRequestCode",
                table: "Goals",
                column: "EmployeeRequestCode",
                principalTable: "EmployeeRequests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
