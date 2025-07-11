using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mini_project.Migrations
{
    /// <inheritdoc />
    public partial class Enter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MemEmail",
                table: "CompanyMembers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MemEmail",
                table: "CompanyMembers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
