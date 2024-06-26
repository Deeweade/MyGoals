﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGoals.API.Migrations
{
    /// <inheritdoc />
    public partial class BusinessProcessStagesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "BusinessProcessStages");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "BusinessProcessStages",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
