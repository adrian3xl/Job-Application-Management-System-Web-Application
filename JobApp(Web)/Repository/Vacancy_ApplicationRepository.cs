using JobApp_Web_.Contracts;
using JobApp_Web_.Data;
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
            throw new NotImplementedException();
        }

        public bool Delete(Vacancy_Application Entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<Vacancy_Application> FindAll()
        {
            throw new NotImplementedException();
        }

        public Vacancy_Application FindById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(Vacancy_Application Entity)
        {
            throw new NotImplementedException();
        }
    }
}
