using JobApp_Web_.Contracts;
using JobApp_Web_.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApp_Web_.Repository
{
    public class JobseekerRepository : IJobseekerRepository
    {

        private readonly ApplicationDbContext _db;
        public JobseekerRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(Jobseeker Entity)
        {
            _db.Jobseeker.Add(Entity);
            return Save();
        }


        public bool Delete(Jobseeker Entity)
        {
            _db.Jobseeker.Remove(Entity);
            return Save();
        }

        public ICollection<Jobseeker> FindAll()
        {
            var Jobseeker = _db.Jobseeker.ToList();
            return Jobseeker;
        }

        public Jobseeker FindById(int id)
        {
            var Jobseeker = _db.Jobseeker.Find(id);

            return Jobseeker;
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

        public bool Update(Jobseeker Entity)
        {
            _db.Jobseeker.Update(Entity);
            return Save();
        }
    }
}
