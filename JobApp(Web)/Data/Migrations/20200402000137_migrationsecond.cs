using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobApp_Web_.Data.Migrations
{
    public partial class migrationsecond : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Company_background",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Company_locatiion",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Company_name",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Industry_type",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Workforce_number",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Firstname",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lastname",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Resumes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Education_level = table.Column<string>(nullable: true),
                    Qualifications = table.Column<string>(nullable: true),
                    PriorWork_Experiences = table.Column<string>(nullable: true),
                    Hobbies = table.Column<string>(nullable: true),
                    Contact_number = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    JobseekerId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resumes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resumes_AspNetUsers_JobseekerId",
                        column: x => x.JobseekerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vacancies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Job_title = table.Column<string>(nullable: true),
                    Job_Discription = table.Column<string>(nullable: true),
                    Job_Requirements = table.Column<string>(nullable: true),
                    Job_level = table.Column<int>(nullable: false),
                    Employment_type = table.Column<string>(nullable: true),
                    Submit_deadline = table.Column<DateTime>(nullable: false),
                    Job_category = table.Column<string>(nullable: true),
                    EmployerId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacancies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vacancies_AspNetUsers_EmployerId",
                        column: x => x.EmployerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vacancy_Applications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Resume_requestid = table.Column<int>(nullable: false),
                    Vacancy_requestid = table.Column<int>(nullable: false),
                    Application_status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacancy_Applications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vacancy_Applications_Resumes_Resume_requestid",
                        column: x => x.Resume_requestid,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vacancy_Applications_Vacancies_Vacancy_requestid",
                        column: x => x.Vacancy_requestid,
                        principalTable: "Vacancies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_JobseekerId",
                table: "Resumes",
                column: "JobseekerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_EmployerId",
                table: "Vacancies",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancy_Applications_Resume_requestid",
                table: "Vacancy_Applications",
                column: "Resume_requestid");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancy_Applications_Vacancy_requestid",
                table: "Vacancy_Applications",
                column: "Vacancy_requestid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vacancy_Applications");

            migrationBuilder.DropTable(
                name: "Resumes");

            migrationBuilder.DropTable(
                name: "Vacancies");

            migrationBuilder.DropColumn(
                name: "Company_background",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Company_locatiion",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Company_name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Industry_type",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Workforce_number",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Firstname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Lastname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
