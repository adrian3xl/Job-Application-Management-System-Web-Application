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
    public class ResumeVM
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = " Education Level")]
        public string Education_level { get; set; }
        [Required]
        public string Qualifications { get; set; }
        [Required]
        [Display(Name = "Prior Work Experiences") ]
        public string PriorWork_Experiences { get; set; }
        [Required]
        public string Hobbies { get; set; }
        [Required]
        [Display(Name = "Contact Number")]
        public string Contact_number { get; set; }
        [Required]
        public string Email { get; set; }
       
      
      //  [ForeignKey("Jobseeker_Id")]
        public Jobseeker Jobseeker { get; set; }

        public string JobseekerId { get; set; }
    }
   
}
