using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class inittia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerProfiles_JobSeeker_JobSeekerId",
                table: "JobSeekerProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_SavedJob_JobSeeker_SavedBy",
                table: "SavedJob");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobSeeker",
                table: "JobSeeker");

            migrationBuilder.RenameTable(
                name: "JobSeeker",
                newName: "JobSeekers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobSeekers",
                table: "JobSeekers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekerProfiles_JobSeekers_JobSeekerId",
                table: "JobSeekerProfiles",
                column: "JobSeekerId",
                principalTable: "JobSeekers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SavedJob_JobSeekers_SavedBy",
                table: "SavedJob",
                column: "SavedBy",
                principalTable: "JobSeekers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerProfiles_JobSeekers_JobSeekerId",
                table: "JobSeekerProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_SavedJob_JobSeekers_SavedBy",
                table: "SavedJob");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobSeekers",
                table: "JobSeekers");

            migrationBuilder.RenameTable(
                name: "JobSeekers",
                newName: "JobSeeker");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobSeeker",
                table: "JobSeeker",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekerProfiles_JobSeeker_JobSeekerId",
                table: "JobSeekerProfiles",
                column: "JobSeekerId",
                principalTable: "JobSeeker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SavedJob_JobSeeker_SavedBy",
                table: "SavedJob",
                column: "SavedBy",
                principalTable: "JobSeeker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
