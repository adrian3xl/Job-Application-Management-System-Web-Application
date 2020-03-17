using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobApp_Web_.Data
{
    public class Vacancy_Application
    {
        public int resume_id { get; set; }
        public string Jobseeker_id { get; set; }
        public int vacancy_id { get; set; }
        public string Application_status { get; set; }
    }
}
