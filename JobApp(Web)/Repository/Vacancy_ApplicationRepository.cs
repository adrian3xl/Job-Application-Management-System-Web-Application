using JobApp_Web_.Contracts;
using JobApp_Web_.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApp_Web_.Repository
{
    public class Vacancy_ApplicationRepository : IVacancyApplicationRepository
    {
        private readonly ApplicationDbContext _db;
        public Vacancy_ApplicationRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(Vacancy_Application Entity)
        {
            _db.Vacancy_Applications.Add(Entity);
            return Save();
        }

        public bool Delete(Vacancy_Application Entity)
        {
            _db.Vacancy_Applications.Remove(Entity);
            return Save();
        }

        public ICollection<Vacancy_Application> FindAll()
        {
         var Vacancy_Applications = _db.Vacancy_Applications.
                Include(q=> q.Resume_request).
                Include(q=>q.Resume_request.Jobseeker).
                Include(q=> q.Vacancy_request)
                .ToList();
            return Vacancy_Applications;
        }

        public Vacancy_Application FindById(int id)
        {
            var Vacancy_Application = _db.Vacancy_Applications.Include(q => q.Resume_request)
                .Include(q => q.Resume_request.Jobseeker).
                Include(q => q.Vacancy_request)
                .FirstOrDefault(q=> q.Id==id);

            return Vacancy_Application;
        }

        public bool IsExist(int id)
        {
            var exists = _db.Vacancy_Applications.Any(q => q.Id == id);
            return exists;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Vacancy_Application Entity)
        {
            _db.Vacancy_Applications.Update(Entity);
            return Save();
        }
    }
}
