using JobApp_Web_.Contracts;
using JobApp_Web_.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApp_Web_.Repository
{
    public class ResumeRepository : IResumeRepository
    {
        private readonly ApplicationDbContext _db;
        public ResumeRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(Resume Entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Resume Entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<Resume> FindAll()
        {
            throw new NotImplementedException();
        }

        public Resume FindById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(Resume Entity)
        {
            throw new NotImplementedException();
        }
    }
}
