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
            _db.Resumes.Add(Entity);
            return Save();
        }

        public bool Delete(Resume Entity)
        {
            _db.Resumes.Remove(Entity);
            return Save();
        }

        public ICollection<Resume> FindAll()
        {
            var Resumes = _db.Resumes.ToList();
            return Resumes;
        }

        public Resume FindById(int id)
        {
            var Resume = _db.Resumes.Find(id);

            return Resume;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Resume Entity)
        {
            _db.Resumes.Update(Entity);
            return Save();
        }
    }
}
