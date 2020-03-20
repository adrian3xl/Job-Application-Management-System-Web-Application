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
            throw new NotImplementedException();
        }

        public bool Delete(Jobseeker Entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<Jobseeker> FindAll()
        {
            throw new NotImplementedException();
        }

        public Jobseeker FindById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(Jobseeker Entity)
        {
            throw new NotImplementedException();
        }
    }
}
