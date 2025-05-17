﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsurancePolicies.Migrations
{
    /// <inheritdoc />
    public partial class RenameInsurancePolicyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Policies",
                table: "Policies");

            migrationBuilder.RenameTable(
                name: "Policies",
                newName: "Policy");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Policy",
                table: "Policy",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Policy",
                table: "Policy");

            migrationBuilder.RenameTable(
                name: "Policy",
                newName: "Policies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Policies",
                table: "Policies",
                column: "Id");
        }
    }
}
