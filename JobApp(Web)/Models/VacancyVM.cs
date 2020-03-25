using JobApp_Web_.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JobApp_Web_.Models
{
    public class VacancyVM
    {

        public int Id { get; set; }
        [Required]
        public string Job_title { get; set; }
        public string Job_Discription { get; set; }
        public string Job_Requirements { get; set; }
        public int Job_level { get; set; }
        public string Employment_type { get; set; }
        public DateTime? Submit_deadline { get; set; }
        public string Job_category { get; set; }

       
      //  [ForeignKey("Employer_Id")]
        public EmployerVM Employer { get; set; }
        public string EmployerId { get; set; }

      // [Key]
      // public IEnumerable<SelectListItem> Employers { get; set; }
    }



}
