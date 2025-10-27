using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class addingtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobProviderCompanies_Locations_LocationNavigationId",
                table: "JobProviderCompanies");

            migrationBuilder.DropIndex(
                name: "IX_JobProviderCompanies_LocationNavigationId",
                table: "JobProviderCompanies");

            migrationBuilder.DropColumn(
                name: "LocationNavigationId",
                table: "JobProviderCompanies");

            migrationBuilder.CreateIndex(
                name: "IX_JobProviderCompanies_Location",
                table: "JobProviderCompanies",
                column: "Location");

            migrationBuilder.AddForeignKey(
                name: "FK_JobProviderCompanies_Locations_Location",
                table: "JobProviderCompanies",
                column: "Location",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobProviderCompanies_Locations_Location",
                table: "JobProviderCompanies");

            migrationBuilder.DropIndex(
                name: "IX_JobProviderCompanies_Location",
                table: "JobProviderCompanies");

            migrationBuilder.AddColumn<Guid>(
                name: "LocationNavigationId",
                table: "JobProviderCompanies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_JobProviderCompanies_LocationNavigationId",
                table: "JobProviderCompanies",
                column: "LocationNavigationId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobProviderCompanies_Locations_LocationNavigationId",
                table: "JobProviderCompanies",
                column: "LocationNavigationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
