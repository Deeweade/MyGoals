using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MyGoals.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusinessProcesses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessProcesses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TabNumber = table.Column<string>(type: "text", nullable: false),
                    Fio = table.Column<string>(type: "text", nullable: false),
                    PositionNum = table.Column<string>(type: "text", nullable: false),
                    Position = table.Column<string>(type: "text", nullable: false),
                    UnitNum = table.Column<string>(type: "text", nullable: false),
                    UnitParentNum = table.Column<string>(type: "text", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: false),
                    Gender = table.Column<bool>(type: "boolean", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    FuncManager = table.Column<string>(type: "text", nullable: false),
                    AdmManager = table.Column<string>(type: "text", nullable: false),
                    UnitManager = table.Column<string>(type: "text", nullable: false),
                    IsManager = table.Column<bool>(type: "boolean", nullable: false),
                    State = table.Column<int>(type: "integer", nullable: true),
                    IsStaffMember = table.Column<bool>(type: "boolean", nullable: false),
                    HeadOffice = table.Column<int>(type: "integer", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Birthday = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    HireDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    AmountSubordinate = table.Column<int>(type: "integer", nullable: true),
                    Login = table.Column<string>(type: "text", nullable: false),
                    Parent = table.Column<int>(type: "integer", nullable: true),
                    Parents = table.Column<string>(type: "text", nullable: false),
                    Levels = table.Column<int>(type: "integer", nullable: false),
                    BlockNum = table.Column<int>(type: "integer", nullable: true),
                    PhotoUrl = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntityStates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityStates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoalOwnershipTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoalOwnershipTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoalTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoalTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KeyResultTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyResultTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Periods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DateStart = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateEnd = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    YearNumber = table.Column<int>(type: "integer", nullable: false),
                    QuarterNumber = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessProcessStages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    BusinessProcessId = table.Column<int>(type: "integer", nullable: true),
                    Test = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessProcessStages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessProcessStages_BusinessProcesses_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalTable: "BusinessProcesses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TypicalGoals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BonusScheme = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Weight = table.Column<decimal>(type: "numeric", nullable: true),
                    PlanValue = table.Column<decimal>(type: "numeric", nullable: true),
                    GoalTypeId = table.Column<int>(type: "integer", nullable: true),
                    KeyResultTypeId = table.Column<int>(type: "integer", nullable: true),
                    ParentTypicalGoalId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypicalGoals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TypicalGoals_GoalTypes_GoalTypeId",
                        column: x => x.GoalTypeId,
                        principalTable: "GoalTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TypicalGoals_KeyResultTypes_KeyResultTypeId",
                        column: x => x.KeyResultTypeId,
                        principalTable: "KeyResultTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GroupRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    BonusSchemeId = table.Column<int>(type: "integer", nullable: true),
                    BusinessProcessId = table.Column<int>(type: "integer", nullable: true),
                    PeriodId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupRequests_BusinessProcesses_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalTable: "BusinessProcesses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GroupRequests_Periods_PeriodId",
                        column: x => x.PeriodId,
                        principalTable: "Periods",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GoalOwnershipTypeId = table.Column<int>(type: "integer", nullable: true),
                    GoalStatusId = table.Column<int>(type: "integer", nullable: true),
                    ResponsibleRoleId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestStatuses_BusinessProcessStages_GoalStatusId",
                        column: x => x.GoalStatusId,
                        principalTable: "BusinessProcessStages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestStatuses_EmployeeRoles_ResponsibleRoleId",
                        column: x => x.ResponsibleRoleId,
                        principalTable: "EmployeeRoles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestStatuses_GoalOwnershipTypes_GoalOwnershipTypeId",
                        column: x => x.GoalOwnershipTypeId,
                        principalTable: "GoalOwnershipTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GroupRequestId = table.Column<int>(type: "integer", nullable: true),
                    EmployeeId = table.Column<int>(type: "integer", nullable: true),
                    RequestStatusId = table.Column<int>(type: "integer", nullable: true),
                    ResponsibleEmployeeId = table.Column<int>(type: "integer", nullable: true),
                    PeriodId = table.Column<int>(type: "integer", nullable: true),
                    GroupRequestId1 = table.Column<int>(type: "integer", nullable: true),
                    EmployeeId1 = table.Column<int>(type: "integer", nullable: true),
                    RequestStatusId1 = table.Column<int>(type: "integer", nullable: true),
                    PeriodId1 = table.Column<int>(type: "integer", nullable: true),
                    Code = table.Column<int>(type: "integer", nullable: false),
                    DateStart = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DateEnd = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EntityStateId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeRequests_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeRequests_Employees_EmployeeId1",
                        column: x => x.EmployeeId1,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeRequests_GroupRequests_GroupRequestId",
                        column: x => x.GroupRequestId,
                        principalTable: "GroupRequests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeRequests_GroupRequests_GroupRequestId1",
                        column: x => x.GroupRequestId1,
                        principalTable: "GroupRequests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeRequests_Periods_PeriodId",
                        column: x => x.PeriodId,
                        principalTable: "Periods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeRequests_Periods_PeriodId1",
                        column: x => x.PeriodId1,
                        principalTable: "Periods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeRequests_RequestStatuses_RequestStatusId",
                        column: x => x.RequestStatusId,
                        principalTable: "RequestStatuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeRequests_RequestStatuses_RequestStatusId1",
                        column: x => x.RequestStatusId1,
                        principalTable: "RequestStatuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestStatusesOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GroupRequestId = table.Column<int>(type: "integer", nullable: true),
                    RequestStatusId = table.Column<int>(type: "integer", nullable: true),
                    StatusOrder = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestStatusesOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestStatusesOrders_GroupRequests_GroupRequestId",
                        column: x => x.GroupRequestId,
                        principalTable: "GroupRequests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestStatusesOrders_RequestStatuses_RequestStatusId",
                        column: x => x.RequestStatusId,
                        principalTable: "RequestStatuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestStatusTransitions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GroupRequestId = table.Column<int>(type: "integer", nullable: true),
                    SourceStatusId = table.Column<int>(type: "integer", nullable: true),
                    NextStatusId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestStatusTransitions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestStatusTransitions_GroupRequests_GroupRequestId",
                        column: x => x.GroupRequestId,
                        principalTable: "GroupRequests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestStatusTransitions_RequestStatuses_SourceStatusId",
                        column: x => x.SourceStatusId,
                        principalTable: "RequestStatuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Goals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Weight = table.Column<decimal>(type: "numeric", nullable: true),
                    PlanValue = table.Column<decimal>(type: "numeric", nullable: true),
                    FactValue = table.Column<decimal>(type: "numeric", nullable: true),
                    SelfFactValue = table.Column<decimal>(type: "numeric", nullable: true),
                    ParentGoalCode = table.Column<int>(type: "integer", nullable: true),
                    JiraEpicLink = table.Column<string>(type: "text", nullable: false),
                    JiraGantLink = table.Column<string>(type: "text", nullable: false),
                    IsHidden = table.Column<bool>(type: "boolean", nullable: true),
                    GoalTypeId = table.Column<int>(type: "integer", nullable: true),
                    KeyResultTypeId = table.Column<int>(type: "integer", nullable: true),
                    EmployeeId = table.Column<int>(type: "integer", nullable: true),
                    PeriodId = table.Column<int>(type: "integer", nullable: true),
                    TypicalGoalId = table.Column<int>(type: "integer", nullable: true),
                    EmployeeRequestCode = table.Column<int>(type: "integer", nullable: false),
                    EmployeeId1 = table.Column<int>(type: "integer", nullable: false),
                    GoalTypeId1 = table.Column<int>(type: "integer", nullable: false),
                    PeriodId1 = table.Column<int>(type: "integer", nullable: false),
                    KeyResultTypeId1 = table.Column<int>(type: "integer", nullable: false),
                    TypicalGoalId1 = table.Column<int>(type: "integer", nullable: false),
                    EmployeeRequestId = table.Column<int>(type: "integer", nullable: true),
                    Code = table.Column<int>(type: "integer", nullable: false),
                    DateStart = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DateEnd = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EntityStateId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Goals_EmployeeRequests_EmployeeRequestCode",
                        column: x => x.EmployeeRequestCode,
                        principalTable: "EmployeeRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Goals_EmployeeRequests_EmployeeRequestId",
                        column: x => x.EmployeeRequestId,
                        principalTable: "EmployeeRequests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Goals_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Goals_Employees_EmployeeId1",
                        column: x => x.EmployeeId1,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Goals_GoalTypes_GoalTypeId",
                        column: x => x.GoalTypeId,
                        principalTable: "GoalTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Goals_GoalTypes_GoalTypeId1",
                        column: x => x.GoalTypeId1,
                        principalTable: "GoalTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Goals_KeyResultTypes_KeyResultTypeId",
                        column: x => x.KeyResultTypeId,
                        principalTable: "KeyResultTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Goals_KeyResultTypes_KeyResultTypeId1",
                        column: x => x.KeyResultTypeId1,
                        principalTable: "KeyResultTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Goals_Periods_PeriodId",
                        column: x => x.PeriodId,
                        principalTable: "Periods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Goals_Periods_PeriodId1",
                        column: x => x.PeriodId1,
                        principalTable: "Periods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Goals_TypicalGoals_TypicalGoalId",
                        column: x => x.TypicalGoalId,
                        principalTable: "TypicalGoals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Goals_TypicalGoals_TypicalGoalId1",
                        column: x => x.TypicalGoalId1,
                        principalTable: "TypicalGoals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Text = table.Column<string>(type: "text", nullable: false),
                    EmployeeId = table.Column<int>(type: "integer", nullable: true),
                    GoalCode = table.Column<int>(type: "integer", nullable: true),
                    GoalId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Goals_GoalCode",
                        column: x => x.GoalCode,
                        principalTable: "Goals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Goals_GoalId",
                        column: x => x.GoalId,
                        principalTable: "Goals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProcessStages_BusinessProcessId",
                table: "BusinessProcessStages",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_EmployeeId",
                table: "Comments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_GoalCode",
                table: "Comments",
                column: "GoalCode");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_GoalId",
                table: "Comments",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRequests_EmployeeId",
                table: "EmployeeRequests",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRequests_EmployeeId1",
                table: "EmployeeRequests",
                column: "EmployeeId1");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRequests_GroupRequestId",
                table: "EmployeeRequests",
                column: "GroupRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRequests_GroupRequestId1",
                table: "EmployeeRequests",
                column: "GroupRequestId1");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRequests_PeriodId",
                table: "EmployeeRequests",
                column: "PeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRequests_PeriodId1",
                table: "EmployeeRequests",
                column: "PeriodId1");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRequests_RequestStatusId",
                table: "EmployeeRequests",
                column: "RequestStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRequests_RequestStatusId1",
                table: "EmployeeRequests",
                column: "RequestStatusId1");

            migrationBuilder.CreateIndex(
                name: "IX_Goals_EmployeeId",
                table: "Goals",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Goals_EmployeeId1",
                table: "Goals",
                column: "EmployeeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Goals_EmployeeRequestCode",
                table: "Goals",
                column: "EmployeeRequestCode");

            migrationBuilder.CreateIndex(
                name: "IX_Goals_EmployeeRequestId",
                table: "Goals",
                column: "EmployeeRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Goals_GoalTypeId",
                table: "Goals",
                column: "GoalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Goals_GoalTypeId1",
                table: "Goals",
                column: "GoalTypeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Goals_KeyResultTypeId",
                table: "Goals",
                column: "KeyResultTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Goals_KeyResultTypeId1",
                table: "Goals",
                column: "KeyResultTypeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Goals_PeriodId",
                table: "Goals",
                column: "PeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_Goals_PeriodId1",
                table: "Goals",
                column: "PeriodId1");

            migrationBuilder.CreateIndex(
                name: "IX_Goals_TypicalGoalId",
                table: "Goals",
                column: "TypicalGoalId");

            migrationBuilder.CreateIndex(
                name: "IX_Goals_TypicalGoalId1",
                table: "Goals",
                column: "TypicalGoalId1");

            migrationBuilder.CreateIndex(
                name: "IX_GroupRequests_BusinessProcessId",
                table: "GroupRequests",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupRequests_PeriodId",
                table: "GroupRequests",
                column: "PeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestStatuses_GoalOwnershipTypeId",
                table: "RequestStatuses",
                column: "GoalOwnershipTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestStatuses_GoalStatusId",
                table: "RequestStatuses",
                column: "GoalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestStatuses_ResponsibleRoleId",
                table: "RequestStatuses",
                column: "ResponsibleRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestStatusesOrders_GroupRequestId",
                table: "RequestStatusesOrders",
                column: "GroupRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestStatusesOrders_RequestStatusId",
                table: "RequestStatusesOrders",
                column: "RequestStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestStatusTransitions_GroupRequestId",
                table: "RequestStatusTransitions",
                column: "GroupRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestStatusTransitions_SourceStatusId",
                table: "RequestStatusTransitions",
                column: "SourceStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TypicalGoals_GoalTypeId",
                table: "TypicalGoals",
                column: "GoalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TypicalGoals_KeyResultTypeId",
                table: "TypicalGoals",
                column: "KeyResultTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "EntityStates");

            migrationBuilder.DropTable(
                name: "RequestStatusesOrders");

            migrationBuilder.DropTable(
                name: "RequestStatusTransitions");

            migrationBuilder.DropTable(
                name: "Goals");

            migrationBuilder.DropTable(
                name: "EmployeeRequests");

            migrationBuilder.DropTable(
                name: "TypicalGoals");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "GroupRequests");

            migrationBuilder.DropTable(
                name: "RequestStatuses");

            migrationBuilder.DropTable(
                name: "GoalTypes");

            migrationBuilder.DropTable(
                name: "KeyResultTypes");

            migrationBuilder.DropTable(
                name: "Periods");

            migrationBuilder.DropTable(
                name: "BusinessProcessStages");

            migrationBuilder.DropTable(
                name: "EmployeeRoles");

            migrationBuilder.DropTable(
                name: "GoalOwnershipTypes");

            migrationBuilder.DropTable(
                name: "BusinessProcesses");
        }
    }
}
