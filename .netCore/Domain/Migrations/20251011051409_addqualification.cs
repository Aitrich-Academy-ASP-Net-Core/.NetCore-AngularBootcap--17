using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class addqualification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Qualification_JobPosts_JobPostId",
                table: "Qualification");

            migrationBuilder.DropForeignKey(
                name: "FK_Qualification_JobSeekerProfiles_JobseekerProfileId",
                table: "Qualification");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Qualification",
                table: "Qualification");

            migrationBuilder.RenameTable(
                name: "Qualification",
                newName: "Qualifications");

            migrationBuilder.RenameIndex(
                name: "IX_Qualification_JobseekerProfileId",
                table: "Qualifications",
                newName: "IX_Qualifications_JobseekerProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_Qualification_JobPostId",
                table: "Qualifications",
                newName: "IX_Qualifications_JobPostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Qualifications",
                table: "Qualifications",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "WorkExperiences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JobSeekerProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ServiceEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkExperiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkExperiences_JobSeekerProfiles_JobSeekerProfileId",
                        column: x => x.JobSeekerProfileId,
                        principalTable: "JobSeekerProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperiences_JobSeekerProfileId",
                table: "WorkExperiences",
                column: "JobSeekerProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Qualifications_JobPosts_JobPostId",
                table: "Qualifications",
                column: "JobPostId",
                principalTable: "JobPosts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Qualifications_JobSeekerProfiles_JobseekerProfileId",
                table: "Qualifications",
                column: "JobseekerProfileId",
                principalTable: "JobSeekerProfiles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Qualifications_JobPosts_JobPostId",
                table: "Qualifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Qualifications_JobSeekerProfiles_JobseekerProfileId",
                table: "Qualifications");

            migrationBuilder.DropTable(
                name: "WorkExperiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Qualifications",
                table: "Qualifications");

            migrationBuilder.RenameTable(
                name: "Qualifications",
                newName: "Qualification");

            migrationBuilder.RenameIndex(
                name: "IX_Qualifications_JobseekerProfileId",
                table: "Qualification",
                newName: "IX_Qualification_JobseekerProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_Qualifications_JobPostId",
                table: "Qualification",
                newName: "IX_Qualification_JobPostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Qualification",
                table: "Qualification",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Qualification_JobPosts_JobPostId",
                table: "Qualification",
                column: "JobPostId",
                principalTable: "JobPosts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Qualification_JobSeekerProfiles_JobseekerProfileId",
                table: "Qualification",
                column: "JobseekerProfileId",
                principalTable: "JobSeekerProfiles",
                principalColumn: "Id");
        }
    }
}
