using JobApp_Web_.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApp_Web_.Contracts
{
    public interface IEmployerRepository : IRepositoryBase<Employer>
    {
       // ICollection<Employer> Employers
    }
}
