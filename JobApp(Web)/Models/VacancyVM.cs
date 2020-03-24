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
       [Key]

        public int Id { get; set; }
        [Required]
        public string Job_title { get; set; }
        public string Job_Discription { get; set; }
        public string Job_Requirements { get; set; }
        public int Job_level { get; set; }
        public string Employment_type { get; set; }
        public DateTime Submit_deadline { get; set; }
        public string Job_category { get; set; }

        [Required]
        [ForeignKey("Employer_Id")]
        public EmployerVM Employer { get; set; }
        public string Employer_Id { get; set; }

       // [Key]
      //  public IEnumerable<SelectListItem> Employers { get; set; }
    }



}
