using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobApp_Web_.Models
{
    public class Vacancy_ApplicationVM
    {
        public int Id { get; set; }
        [Required]
        public ResumeVM Resume_request { get; set; }
        public int Resume_request_id { get; set; }
        [Required]
        public VacancyVM Vacancy_request { get; set; }
        [Required]
        public int Vacancy_request_id { get; set; }

        public string Application_status { get; set; }
    }
}
