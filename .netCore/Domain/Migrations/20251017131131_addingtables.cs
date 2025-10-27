using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class addingtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SavedJob_JobPosts_Job",
                table: "SavedJob");

            migrationBuilder.DropForeignKey(
                name: "FK_SavedJob_JobSeekers_SavedBy",
                table: "SavedJob");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SavedJob",
                table: "SavedJob");

            migrationBuilder.RenameTable(
                name: "SavedJob",
                newName: "SavedJobs");

            migrationBuilder.RenameIndex(
                name: "IX_SavedJob_SavedBy",
                table: "SavedJobs",
                newName: "IX_SavedJobs_SavedBy");

            migrationBuilder.RenameIndex(
                name: "IX_SavedJob_Job",
                table: "SavedJobs",
                newName: "IX_SavedJobs_Job");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SavedJobs",
                table: "SavedJobs",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "JobApplications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JobPost_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Applicant = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Resume_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoverLetter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Datesubmitted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobApplications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobApplications_JobPosts_JobPost_id",
                        column: x => x.JobPost_id,
                        principalTable: "JobPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobApplications_JobSeekers_Applicant",
                        column: x => x.Applicant,
                        principalTable: "JobSeekers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobApplications_Resumes_Resume_id",
                        column: x => x.Resume_id,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobApplications_Applicant",
                table: "JobApplications",
                column: "Applicant");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplications_JobPost_id",
                table: "JobApplications",
                column: "JobPost_id");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplications_Resume_id",
                table: "JobApplications",
                column: "Resume_id");

            migrationBuilder.AddForeignKey(
                name: "FK_SavedJobs_JobPosts_Job",
                table: "SavedJobs",
                column: "Job",
                principalTable: "JobPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SavedJobs_JobSeekers_SavedBy",
                table: "SavedJobs",
                column: "SavedBy",
                principalTable: "JobSeekers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SavedJobs_JobPosts_Job",
                table: "SavedJobs");

            migrationBuilder.DropForeignKey(
                name: "FK_SavedJobs_JobSeekers_SavedBy",
                table: "SavedJobs");

            migrationBuilder.DropTable(
                name: "JobApplications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SavedJobs",
                table: "SavedJobs");

            migrationBuilder.RenameTable(
                name: "SavedJobs",
                newName: "SavedJob");

            migrationBuilder.RenameIndex(
                name: "IX_SavedJobs_SavedBy",
                table: "SavedJob",
                newName: "IX_SavedJob_SavedBy");

            migrationBuilder.RenameIndex(
                name: "IX_SavedJobs_Job",
                table: "SavedJob",
                newName: "IX_SavedJob_Job");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SavedJob",
                table: "SavedJob",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SavedJob_JobPosts_Job",
                table: "SavedJob",
                column: "Job",
                principalTable: "JobPosts",
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
    }
}
