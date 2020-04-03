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
        [Display(Name = "Job Title")]
        public string Job_title { get; set; }
        [Display(Name = "Job Discription")]
        public string Job_Discription { get; set; }
        [Display(Name = "Job Requirements")]
        public string Job_Requirements { get; set; }
        [Display(Name = "Job Level")]
        public int Job_level { get; set; }
        [Display(Name = "Employment Type")]
        public string Employment_type { get; set; }
      
        [DataType(DataType.Date)]
        [Display(Name = "Deadline Date (MM/DD/YYYY)")]
        public DateTime Submit_deadline { get; set; }
        [Display(Name = "Job Category")]
        public string Job_category { get; set; }

       
      //  [ForeignKey("Employer_Id")]
        public EmployerVM Employer { get; set; }
        [Display(Name = "Employer")]
        public string EmployerId { get; set; }

      // [Key]
      // public IEnumerable<SelectListItem> Employers { get; set; }
    }

    public class SearchVacancyVM
    {

        public int Id { get; set; }
        public string Job_title { get; set; }
        public string Job_Discription { get; set; }
        public string Job_Requirements { get; set; }
        public int Job_level { get; set; }
        public string Employment_type { get; set; }
       
        [DataType(DataType.Date)]
        public DateTime Submit_deadline { get; set; }
        public string Job_category { get; set; }


        //  [ForeignKey("Employer_Id")]
       
        public string EmployerId { get; set; }

    }

    }
