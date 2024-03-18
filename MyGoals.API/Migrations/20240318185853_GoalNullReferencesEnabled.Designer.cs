﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyGoals.Infrastructure.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MyGoals.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240318185853_GoalNullReferencesEnabled")]
    partial class GoalNullReferencesEnabled
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MyGoals.Domain.Entities.BusinessProcess", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("BusinessProcesses");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.BusinessProcessStage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("BusinessProcessId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("BusinessProcessId");

                    b.ToTable("BusinessProcessStages");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<int?>("GoalCode")
                        .HasColumnType("integer");

                    b.Property<int?>("GoalId")
                        .HasColumnType("integer");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("GoalCode");

                    b.HasIndex("GoalId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AdmManager")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("AmountSubordinate")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("BlockNum")
                        .HasColumnType("integer");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Fio")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FuncManager")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Gender")
                        .HasColumnType("boolean");

                    b.Property<int?>("HeadOffice")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("HireDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsManager")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsStaffMember")
                        .HasColumnType("boolean");

                    b.Property<int>("Levels")
                        .HasColumnType("integer");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("Parent")
                        .HasColumnType("integer");

                    b.Property<string>("Parents")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhotoUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PositionNum")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("State")
                        .HasColumnType("integer");

                    b.Property<string>("TabNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UnitManager")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UnitNum")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UnitParentNum")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.EmployeeRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("Code")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateStart")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<int>("EntityStateId")
                        .HasColumnType("integer");

                    b.Property<int?>("GroupRequestId")
                        .HasColumnType("integer");

                    b.Property<int?>("PeriodId")
                        .HasColumnType("integer");

                    b.Property<int?>("RequestStatusId")
                        .HasColumnType("integer");

                    b.Property<int?>("ResponsibleEmployeeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("GroupRequestId");

                    b.HasIndex("PeriodId");

                    b.HasIndex("RequestStatusId");

                    b.ToTable("EmployeeRequests");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.EmployeeRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EmployeeRoles");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.EntityState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EntityStates");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.Goal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("Code")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateStart")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<int?>("EmployeeRequestCode")
                        .HasColumnType("integer");

                    b.Property<int?>("EmployeeRequestId")
                        .HasColumnType("integer");

                    b.Property<int>("EntityStateId")
                        .HasColumnType("integer");

                    b.Property<decimal?>("FactValue")
                        .HasColumnType("numeric");

                    b.Property<int?>("GoalTypeId")
                        .HasColumnType("integer");

                    b.Property<bool?>("IsHidden")
                        .HasColumnType("boolean");

                    b.Property<string>("JiraEpicLink")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("JiraGantLink")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("KeyResultTypeId")
                        .HasColumnType("integer");

                    b.Property<int?>("ParentGoalCode")
                        .HasColumnType("integer");

                    b.Property<int?>("PeriodId")
                        .HasColumnType("integer");

                    b.Property<decimal?>("PlanValue")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("SelfFactValue")
                        .HasColumnType("numeric");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("TypicalGoalId")
                        .HasColumnType("integer");

                    b.Property<decimal?>("Weight")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("EmployeeRequestCode");

                    b.HasIndex("EmployeeRequestId");

                    b.HasIndex("GoalTypeId");

                    b.HasIndex("KeyResultTypeId");

                    b.HasIndex("PeriodId");

                    b.HasIndex("TypicalGoalId");

                    b.ToTable("Goals");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.GoalOwnershipType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("GoalOwnershipTypes");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.GoalType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("GoalTypes");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.GroupRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("BonusSchemeId")
                        .HasColumnType("integer");

                    b.Property<int?>("BusinessProcessId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("PeriodId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BusinessProcessId");

                    b.HasIndex("PeriodId");

                    b.ToTable("GroupRequests");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.KeyResultType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("KeyResultTypes");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.Period", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("QuarterNumber")
                        .HasColumnType("integer");

                    b.Property<int>("YearNumber")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Periods");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.RequestStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("BusinessProcessStageId")
                        .HasColumnType("integer");

                    b.Property<int?>("GoalOwnershipTypeId")
                        .HasColumnType("integer");

                    b.Property<int?>("ResponsibleRoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BusinessProcessStageId");

                    b.HasIndex("GoalOwnershipTypeId");

                    b.HasIndex("ResponsibleRoleId");

                    b.ToTable("RequestStatuses");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.RequestStatusTransition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("GroupRequestId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("NextStatusId")
                        .HasColumnType("integer");

                    b.Property<int?>("SourceStatusId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GroupRequestId");

                    b.HasIndex("SourceStatusId");

                    b.ToTable("RequestStatusTransitions");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.RequestStatusesOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("GroupRequestId")
                        .HasColumnType("integer");

                    b.Property<int?>("RequestStatusId")
                        .HasColumnType("integer");

                    b.Property<int?>("StatusOrder")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GroupRequestId");

                    b.HasIndex("RequestStatusId");

                    b.ToTable("RequestStatusesOrders");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.TypicalGoal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("BonusScheme")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("GoalTypeId")
                        .HasColumnType("integer");

                    b.Property<int?>("KeyResultTypeId")
                        .HasColumnType("integer");

                    b.Property<int?>("ParentTypicalGoalId")
                        .HasColumnType("integer");

                    b.Property<decimal?>("PlanValue")
                        .HasColumnType("numeric");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal?>("Weight")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("GoalTypeId");

                    b.HasIndex("KeyResultTypeId");

                    b.ToTable("TypicalGoals");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.BusinessProcessStage", b =>
                {
                    b.HasOne("MyGoals.Domain.Entities.BusinessProcess", "BusinessProcess")
                        .WithMany("BusinessProcessStages")
                        .HasForeignKey("BusinessProcessId");

                    b.Navigation("BusinessProcess");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.Comment", b =>
                {
                    b.HasOne("MyGoals.Domain.Entities.Employee", "Employee")
                        .WithMany("Comments")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("MyGoals.Domain.Entities.Goal", "Goal")
                        .WithMany()
                        .HasForeignKey("GoalCode");

                    b.HasOne("MyGoals.Domain.Entities.Goal", null)
                        .WithMany("Comments")
                        .HasForeignKey("GoalId");

                    b.Navigation("Employee");

                    b.Navigation("Goal");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.EmployeeRequest", b =>
                {
                    b.HasOne("MyGoals.Domain.Entities.Employee", "Employee")
                        .WithMany("EmployeeRequests")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("MyGoals.Domain.Entities.GroupRequest", "GroupRequest")
                        .WithMany("EmployeeRequests")
                        .HasForeignKey("GroupRequestId");

                    b.HasOne("MyGoals.Domain.Entities.Period", "Period")
                        .WithMany("EmployeeRequests")
                        .HasForeignKey("PeriodId");

                    b.HasOne("MyGoals.Domain.Entities.RequestStatus", "RequestStatus")
                        .WithMany("EmployeeRequests")
                        .HasForeignKey("RequestStatusId");

                    b.Navigation("Employee");

                    b.Navigation("GroupRequest");

                    b.Navigation("Period");

                    b.Navigation("RequestStatus");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.Goal", b =>
                {
                    b.HasOne("MyGoals.Domain.Entities.Employee", "Employee")
                        .WithMany("Goals")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("MyGoals.Domain.Entities.EmployeeRequest", "EmployeeRequest")
                        .WithMany()
                        .HasForeignKey("EmployeeRequestCode");

                    b.HasOne("MyGoals.Domain.Entities.EmployeeRequest", null)
                        .WithMany("Goals")
                        .HasForeignKey("EmployeeRequestId");

                    b.HasOne("MyGoals.Domain.Entities.GoalType", "GoalType")
                        .WithMany("Goals")
                        .HasForeignKey("GoalTypeId");

                    b.HasOne("MyGoals.Domain.Entities.KeyResultType", "KeyResultType")
                        .WithMany("Goals")
                        .HasForeignKey("KeyResultTypeId");

                    b.HasOne("MyGoals.Domain.Entities.Period", "Period")
                        .WithMany("Goals")
                        .HasForeignKey("PeriodId");

                    b.HasOne("MyGoals.Domain.Entities.TypicalGoal", "TypicalGoal")
                        .WithMany("Goals")
                        .HasForeignKey("TypicalGoalId");

                    b.Navigation("Employee");

                    b.Navigation("EmployeeRequest");

                    b.Navigation("GoalType");

                    b.Navigation("KeyResultType");

                    b.Navigation("Period");

                    b.Navigation("TypicalGoal");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.GroupRequest", b =>
                {
                    b.HasOne("MyGoals.Domain.Entities.BusinessProcess", "BusinessProcess")
                        .WithMany("GroupRequests")
                        .HasForeignKey("BusinessProcessId");

                    b.HasOne("MyGoals.Domain.Entities.Period", "Period")
                        .WithMany()
                        .HasForeignKey("PeriodId");

                    b.Navigation("BusinessProcess");

                    b.Navigation("Period");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.RequestStatus", b =>
                {
                    b.HasOne("MyGoals.Domain.Entities.BusinessProcessStage", "BusinessProcessStage")
                        .WithMany("RequestStatuses")
                        .HasForeignKey("BusinessProcessStageId");

                    b.HasOne("MyGoals.Domain.Entities.GoalOwnershipType", "GoalOwnershipType")
                        .WithMany("RequestStatuses")
                        .HasForeignKey("GoalOwnershipTypeId");

                    b.HasOne("MyGoals.Domain.Entities.EmployeeRole", "ResponsibleRole")
                        .WithMany("RequestStatuses")
                        .HasForeignKey("ResponsibleRoleId");

                    b.Navigation("BusinessProcessStage");

                    b.Navigation("GoalOwnershipType");

                    b.Navigation("ResponsibleRole");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.RequestStatusTransition", b =>
                {
                    b.HasOne("MyGoals.Domain.Entities.GroupRequest", "GroupRequest")
                        .WithMany("RequestStatusTransitions")
                        .HasForeignKey("GroupRequestId");

                    b.HasOne("MyGoals.Domain.Entities.RequestStatus", "SourceStatus")
                        .WithMany("RequestStatusTransitions")
                        .HasForeignKey("SourceStatusId");

                    b.Navigation("GroupRequest");

                    b.Navigation("SourceStatus");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.RequestStatusesOrder", b =>
                {
                    b.HasOne("MyGoals.Domain.Entities.GroupRequest", "GroupRequest")
                        .WithMany("RequestStatusOrders")
                        .HasForeignKey("GroupRequestId");

                    b.HasOne("MyGoals.Domain.Entities.RequestStatus", "RequestStatus")
                        .WithMany("RequestStatusOrders")
                        .HasForeignKey("RequestStatusId");

                    b.Navigation("GroupRequest");

                    b.Navigation("RequestStatus");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.TypicalGoal", b =>
                {
                    b.HasOne("MyGoals.Domain.Entities.GoalType", "GoalType")
                        .WithMany("TypicalGoals")
                        .HasForeignKey("GoalTypeId");

                    b.HasOne("MyGoals.Domain.Entities.KeyResultType", "KeyResultType")
                        .WithMany("TypicalGoals")
                        .HasForeignKey("KeyResultTypeId");

                    b.Navigation("GoalType");

                    b.Navigation("KeyResultType");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.BusinessProcess", b =>
                {
                    b.Navigation("BusinessProcessStages");

                    b.Navigation("GroupRequests");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.BusinessProcessStage", b =>
                {
                    b.Navigation("RequestStatuses");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.Employee", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("EmployeeRequests");

                    b.Navigation("Goals");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.EmployeeRequest", b =>
                {
                    b.Navigation("Goals");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.EmployeeRole", b =>
                {
                    b.Navigation("RequestStatuses");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.Goal", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.GoalOwnershipType", b =>
                {
                    b.Navigation("RequestStatuses");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.GoalType", b =>
                {
                    b.Navigation("Goals");

                    b.Navigation("TypicalGoals");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.GroupRequest", b =>
                {
                    b.Navigation("EmployeeRequests");

                    b.Navigation("RequestStatusOrders");

                    b.Navigation("RequestStatusTransitions");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.KeyResultType", b =>
                {
                    b.Navigation("Goals");

                    b.Navigation("TypicalGoals");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.Period", b =>
                {
                    b.Navigation("EmployeeRequests");

                    b.Navigation("Goals");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.RequestStatus", b =>
                {
                    b.Navigation("EmployeeRequests");

                    b.Navigation("RequestStatusOrders");

                    b.Navigation("RequestStatusTransitions");
                });

            modelBuilder.Entity("MyGoals.Domain.Entities.TypicalGoal", b =>
                {
                    b.Navigation("Goals");
                });
#pragma warning restore 612, 618
        }
    }
}
