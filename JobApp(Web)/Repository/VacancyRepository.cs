using JobApp_Web_.Contracts;
using JobApp_Web_.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApp_Web_.Repository
{
    public class VacancyRepository : IVacancyRepository
    {
        private readonly ApplicationDbContext _db;
        public VacancyRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(vacancy Entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(vacancy Entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<vacancy> FindAll()
        {
            throw new NotImplementedException();
        }

        public vacancy FindById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(vacancy Entity)
        {
            throw new NotImplementedException();
        }
    }
}
