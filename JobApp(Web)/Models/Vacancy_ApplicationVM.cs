using Microsoft.AspNetCore.Mvc.Rendering;
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
        
        public ResumeVM Resume_request { get; set; }
        public int Resume_requestId { get; set; }
      
        public VacancyVM Vacancy_request { get; set; }
        
        public int vacancy_requestId { get; set; }

        public string Application_status { get; set; }

    //    [Key]
      //  public IEnumerable<SelectListItem> Vacancy_requests { get; set; }
     //  [Key]
      // public IEnumerable<SelectListItem> Resume_requests { get; set; }
    }

    public class VacancyApplicationAdminViewVM
    {
     public   List<Vacancy_ApplicationVM> Vacancy_Applications { get; set; }
    }

    public class VacancySearchVM
    {
        //    [Key]
        public int Vacancy_requestId { get; set; }
        public IEnumerable<SelectListItem> Vacancy_requests { get; set; }
        //  [Key]
        public int Resume_requestId { get; set; }
        public IEnumerable<SelectListItem> Resume_requests { get; set; }

    }

}
