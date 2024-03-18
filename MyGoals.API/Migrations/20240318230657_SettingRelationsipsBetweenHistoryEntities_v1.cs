using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGoals.API.Migrations
{
    /// <inheritdoc />
    public partial class SettingRelationsipsBetweenHistoryEntities_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goals_EmployeeRequests_EmployeeRequestCode",
                table: "Goals");

            migrationBuilder.DropForeignKey(
                name: "FK_Goals_EmployeeRequests_EmployeeRequestId",
                table: "Goals");

            migrationBuilder.DropIndex(
                name: "IX_Goals_EmployeeRequestId",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "EmployeeRequestId",
                table: "Goals");

            migrationBuilder.AlterColumn<int>(
                name: "Code",
                table: "EmployeeRequests",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_EmployeeRequests_Code",
                table: "EmployeeRequests",
                column: "Code");

            migrationBuilder.AddForeignKey(
                name: "FK_Goals_EmployeeRequests_EmployeeRequestCode",
                table: "Goals",
                column: "EmployeeRequestCode",
                principalTable: "EmployeeRequests",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goals_EmployeeRequests_EmployeeRequestCode",
                table: "Goals");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_EmployeeRequests_Code",
                table: "EmployeeRequests");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeRequestId",
                table: "Goals",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Code",
                table: "EmployeeRequests",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateIndex(
                name: "IX_Goals_EmployeeRequestId",
                table: "Goals",
                column: "EmployeeRequestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Goals_EmployeeRequests_EmployeeRequestCode",
                table: "Goals",
                column: "EmployeeRequestCode",
                principalTable: "EmployeeRequests",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Goals_EmployeeRequests_EmployeeRequestId",
                table: "Goals",
                column: "EmployeeRequestId",
                principalTable: "EmployeeRequests",
                principalColumn: "Id");
        }
    }
}
