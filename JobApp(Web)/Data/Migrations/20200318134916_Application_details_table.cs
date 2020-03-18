using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobApp_Web_.Data.Migrations
{
    public partial class Application_details_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Campany_contact_number",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Company_Email",
                table: "AspNetUsers",
                nullable: true);

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

            migrationBuilder.CreateTable(
                name: "Resumes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Education_level = table.Column<int>(nullable: false),
                    Qualifications = table.Column<string>(nullable: true),
                    PriorWork_Experiences = table.Column<string>(nullable: true),
                    Hobbies = table.Column<string>(nullable: true),
                    Contact_number = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Jobseeker_Id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resumes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resumes_AspNetUsers_Jobseeker_Id",
                        column: x => x.Jobseeker_Id,
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
                    Employer_Id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacancies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vacancies_AspNetUsers_Employer_Id",
                        column: x => x.Employer_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vacancy_Applications",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    resume_id = table.Column<int>(nullable: false),
                    Jobseeker_Id = table.Column<string>(nullable: true),
                    Jobseeker_id = table.Column<string>(nullable: true),
                    vacancy_id = table.Column<int>(nullable: false),
                    Application_status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacancy_Applications", x => x.id);
                    table.ForeignKey(
                        name: "FK_Vacancy_Applications_AspNetUsers_Jobseeker_Id",
                        column: x => x.Jobseeker_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vacancy_Applications_Resumes_resume_id",
                        column: x => x.resume_id,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vacancy_Applications_Vacancies_vacancy_id",
                        column: x => x.vacancy_id,
                        principalTable: "Vacancies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_Jobseeker_Id",
                table: "Resumes",
                column: "Jobseeker_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_Employer_Id",
                table: "Vacancies",
                column: "Employer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancy_Applications_Jobseeker_Id",
                table: "Vacancy_Applications",
                column: "Jobseeker_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancy_Applications_resume_id",
                table: "Vacancy_Applications",
                column: "resume_id");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancy_Applications_vacancy_id",
                table: "Vacancy_Applications",
                column: "vacancy_id");
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
                name: "Campany_contact_number",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Company_Email",
                table: "AspNetUsers");

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
        }
    }
}
