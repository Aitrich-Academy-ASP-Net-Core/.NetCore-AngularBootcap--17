using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthUser_Role_RoleId",
                table: "AuthUser");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyUsers_Role_RoleId",
                table: "CompanyUsers");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropIndex(
                name: "IX_CompanyUsers_RoleId",
                table: "CompanyUsers");

            migrationBuilder.DropIndex(
                name: "IX_AuthUser_RoleId",
                table: "AuthUser");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "CompanyUsers");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "AuthUser");

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "CompanyUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AuthUser",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "AuthUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "AuthUser",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "AuthUser",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "CompanyUsers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "AuthUser");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AuthUser");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "AuthUser");

            migrationBuilder.AddColumn<Guid>(
                name: "RoleId",
                table: "CompanyUsers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AuthUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RoleId",
                table: "AuthUser",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyUsers_RoleId",
                table: "CompanyUsers",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthUser_RoleId",
                table: "AuthUser",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthUser_Role_RoleId",
                table: "AuthUser",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyUsers_Role_RoleId",
                table: "CompanyUsers",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
