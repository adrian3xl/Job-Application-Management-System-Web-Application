using Microsoft.EntityFrameworkCore.Migrations;

namespace JobApp_Web_.Data.Migrations
{
    public partial class addapplicationdetailstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacancy_Applications_AspNetUsers_Jobseeker_Id",
                table: "Vacancy_Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancy_Applications_Resumes_resume_id",
                table: "Vacancy_Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancy_Applications_Vacancies_vacancy_id",
                table: "Vacancy_Applications");

            migrationBuilder.DropIndex(
                name: "IX_Vacancy_Applications_Jobseeker_Id",
                table: "Vacancy_Applications");

            migrationBuilder.DropIndex(
                name: "IX_Vacancy_Applications_resume_id",
                table: "Vacancy_Applications");

            migrationBuilder.DropIndex(
                name: "IX_Vacancy_Applications_vacancy_id",
                table: "Vacancy_Applications");

            migrationBuilder.DropColumn(
                name: "Jobseeker_Id",
                table: "Vacancy_Applications");

            migrationBuilder.DropColumn(
                name: "Jobseeker_id",
                table: "Vacancy_Applications");

            migrationBuilder.DropColumn(
                name: "resume_id",
                table: "Vacancy_Applications");

            migrationBuilder.DropColumn(
                name: "vacancy_id",
                table: "Vacancy_Applications");

            migrationBuilder.AddColumn<string>(
                name: "Jobseeker_requestId",
                table: "Vacancy_Applications",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Jobseeker_request_id",
                table: "Vacancy_Applications",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Resume_requestId",
                table: "Vacancy_Applications",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "resume_request_id",
                table: "Vacancy_Applications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "vacancy_requestId",
                table: "Vacancy_Applications",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "vacancy_request_id",
                table: "Vacancy_Applications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vacancy_Applications_Jobseeker_requestId",
                table: "Vacancy_Applications",
                column: "Jobseeker_requestId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancy_Applications_Resume_requestId",
                table: "Vacancy_Applications",
                column: "Resume_requestId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancy_Applications_vacancy_requestId",
                table: "Vacancy_Applications",
                column: "vacancy_requestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancy_Applications_AspNetUsers_Jobseeker_requestId",
                table: "Vacancy_Applications",
                column: "Jobseeker_requestId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancy_Applications_Resumes_Resume_requestId",
                table: "Vacancy_Applications",
                column: "Resume_requestId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancy_Applications_Vacancies_vacancy_requestId",
                table: "Vacancy_Applications",
                column: "vacancy_requestId",
                principalTable: "Vacancies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacancy_Applications_AspNetUsers_Jobseeker_requestId",
                table: "Vacancy_Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancy_Applications_Resumes_Resume_requestId",
                table: "Vacancy_Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancy_Applications_Vacancies_vacancy_requestId",
                table: "Vacancy_Applications");

            migrationBuilder.DropIndex(
                name: "IX_Vacancy_Applications_Jobseeker_requestId",
                table: "Vacancy_Applications");

            migrationBuilder.DropIndex(
                name: "IX_Vacancy_Applications_Resume_requestId",
                table: "Vacancy_Applications");

            migrationBuilder.DropIndex(
                name: "IX_Vacancy_Applications_vacancy_requestId",
                table: "Vacancy_Applications");

            migrationBuilder.DropColumn(
                name: "Jobseeker_requestId",
                table: "Vacancy_Applications");

            migrationBuilder.DropColumn(
                name: "Jobseeker_request_id",
                table: "Vacancy_Applications");

            migrationBuilder.DropColumn(
                name: "Resume_requestId",
                table: "Vacancy_Applications");

            migrationBuilder.DropColumn(
                name: "resume_request_id",
                table: "Vacancy_Applications");

            migrationBuilder.DropColumn(
                name: "vacancy_requestId",
                table: "Vacancy_Applications");

            migrationBuilder.DropColumn(
                name: "vacancy_request_id",
                table: "Vacancy_Applications");

            migrationBuilder.AddColumn<string>(
                name: "Jobseeker_Id",
                table: "Vacancy_Applications",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Jobseeker_id",
                table: "Vacancy_Applications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "resume_id",
                table: "Vacancy_Applications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "vacancy_id",
                table: "Vacancy_Applications",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancy_Applications_AspNetUsers_Jobseeker_Id",
                table: "Vacancy_Applications",
                column: "Jobseeker_Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancy_Applications_Resumes_resume_id",
                table: "Vacancy_Applications",
                column: "resume_id",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancy_Applications_Vacancies_vacancy_id",
                table: "Vacancy_Applications",
                column: "vacancy_id",
                principalTable: "Vacancies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
