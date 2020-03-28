using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobApp_Web_.Data.Migrations
{
    public partial class UpdateDatabaseAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResumeVM");

            migrationBuilder.DropTable(
                name: "VacancyVM");

            migrationBuilder.DropTable(
                name: "EmployerVM");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployerVM",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Campany_contact_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company_background = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company_locatiion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Industry_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Workforce_number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployerVM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResumeVM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contact_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Education_level = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hobbies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobseekerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PriorWork_Experiences = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qualifications = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeVM", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResumeVM_AspNetUsers_JobseekerId",
                        column: x => x.JobseekerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VacancyVM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Employment_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Job_Discription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Job_Requirements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Job_category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Job_level = table.Column<int>(type: "int", nullable: false),
                    Job_title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Submit_deadline = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacancyVM", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VacancyVM_EmployerVM_EmployerId",
                        column: x => x.EmployerId,
                        principalTable: "EmployerVM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResumeVM_JobseekerId",
                table: "ResumeVM",
                column: "JobseekerId");

            migrationBuilder.CreateIndex(
                name: "IX_VacancyVM_EmployerId",
                table: "VacancyVM",
                column: "EmployerId");
        }
    }
}
