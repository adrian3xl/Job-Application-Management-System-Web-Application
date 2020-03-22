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
            _db.Vacancies.Add(Entity);
            return Save();
        }

        public bool Delete(vacancy Entity)
        {
            _db.Vacancies.Remove(Entity);
            return Save();
        }

        public ICollection<vacancy> FindAll()
        {
           var Vacancies= _db.Vacancies.ToList();
            return Vacancies;
        }

        public vacancy FindById(int id)
        {
            var Vacancies = _db.Vacancies.Find(id);
         
            return Vacancies;
        }

        public bool IsExist(int id)
        {
            var exists = _db.Resumes.Any(q => q.Id == id);
            return exists;
        }

        public bool Save()
        {
          var changes=  _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(vacancy Entity)
        {
            _db.Vacancies.Update(Entity);
            return Save();
        }
    }
}
