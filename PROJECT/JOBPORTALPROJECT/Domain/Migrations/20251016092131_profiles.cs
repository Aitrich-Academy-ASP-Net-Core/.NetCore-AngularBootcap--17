using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class profiles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_JobSeekerProfiles_JobSeekerProfileId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_JobSeekerProfileId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "JobSeekerProfileId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Resumes");

            migrationBuilder.RenameColumn(
                name: "Summary",
                table: "JobSeekerProfiles",
                newName: "ProfileSummary");

            migrationBuilder.AddColumn<string>(
                name: "ProfileName",
                table: "JobSeekerProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "ResumeId",
                table: "JobSeekerProfiles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProfileId",
                table: "AuthUsers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "ProfileSkills",
                columns: table => new
                {
                    ProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SkillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileSkills", x => new { x.ProfileId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_ProfileSkills_JobSeekerProfiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "JobSeekerProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfileSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerProfiles_ResumeId",
                table: "JobSeekerProfiles",
                column: "ResumeId",
                unique: true,
                filter: "[ResumeId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileSkills_SkillId",
                table: "ProfileSkills",
                column: "SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekerProfiles_Resumes_ResumeId",
                table: "JobSeekerProfiles",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerProfiles_Resumes_ResumeId",
                table: "JobSeekerProfiles");

            migrationBuilder.DropTable(
                name: "ProfileSkills");

            migrationBuilder.DropIndex(
                name: "IX_JobSeekerProfiles_ResumeId",
                table: "JobSeekerProfiles");

            migrationBuilder.DropColumn(
                name: "ProfileName",
                table: "JobSeekerProfiles");

            migrationBuilder.DropColumn(
                name: "ResumeId",
                table: "JobSeekerProfiles");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "AuthUsers");

            migrationBuilder.RenameColumn(
                name: "ProfileSummary",
                table: "JobSeekerProfiles",
                newName: "Summary");

            migrationBuilder.AddColumn<Guid>(
                name: "JobSeekerProfileId",
                table: "Skills",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProfileId",
                table: "Resumes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Skills_JobSeekerProfileId",
                table: "Skills",
                column: "JobSeekerProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_JobSeekerProfiles_JobSeekerProfileId",
                table: "Skills",
                column: "JobSeekerProfileId",
                principalTable: "JobSeekerProfiles",
                principalColumn: "Id");
        }
    }
}
