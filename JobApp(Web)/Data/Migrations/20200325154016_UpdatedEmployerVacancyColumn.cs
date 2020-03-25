using Microsoft.EntityFrameworkCore.Migrations;

namespace JobApp_Web_.Data.Migrations
{
    public partial class UpdatedEmployerVacancyColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_AspNetUsers_Employer_Id",
                table: "Vacancies");

            migrationBuilder.DropIndex(
                name: "IX_Vacancies_Employer_Id",
                table: "Vacancies");

            migrationBuilder.DropColumn(
                name: "Employer_Id",
                table: "Vacancies");

            migrationBuilder.AddColumn<string>(
                name: "EmployerId",
                table: "Vacancies",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_EmployerId",
                table: "Vacancies",
                column: "EmployerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_AspNetUsers_EmployerId",
                table: "Vacancies",
                column: "EmployerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_AspNetUsers_EmployerId",
                table: "Vacancies");

            migrationBuilder.DropIndex(
                name: "IX_Vacancies_EmployerId",
                table: "Vacancies");

            migrationBuilder.DropColumn(
                name: "EmployerId",
                table: "Vacancies");

            migrationBuilder.AddColumn<string>(
                name: "Employer_Id",
                table: "Vacancies",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_Employer_Id",
                table: "Vacancies",
                column: "Employer_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_AspNetUsers_Employer_Id",
                table: "Vacancies",
                column: "Employer_Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
