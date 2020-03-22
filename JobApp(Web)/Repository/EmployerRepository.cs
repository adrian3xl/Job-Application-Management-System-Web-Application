using JobApp_Web_.Contracts;
using JobApp_Web_.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApp_Web_.Repository
{
    public class EmployerRepository : IEmployerRepository
    {
        private readonly ApplicationDbContext _db;
        public EmployerRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(Employer Entity)
        {
            throw new NotImplementedException();
        }


        public bool Delete(Employer Entity)
        {
            _db.Employers.Remove(Entity);
            return Save();
        }

        public ICollection<Employer> FindAll()
        {
            var Employers = _db.Employers.ToList();
            return Employers;
        }

        public Employer FindById(int id)
        {
            var Employers = _db.Employers.Find(id);

            return Employers;
        }

        public bool IsExist(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Employer Entity)
        {
            _db.Employers.Update(Entity);
            return Save();
        }
    }
}
