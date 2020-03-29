using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using JobApp_Web_.Models;

namespace JobApp_Web_.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Jobseeker> Jobseeker { get; set;}
        public DbSet<Employer>Employers { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<vacancy> Vacancies { get; set; }
        public DbSet<Vacancy_Application> Vacancy_Applications { get; set; }
        public DbSet<JobApp_Web_.Models.Vacancy_ApplicationVM> Vacancy_ApplicationVM { get; set; }
       

    }
}
