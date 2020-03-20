using JobApp_Web_.Data;
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
        public int Education_level { get; set; }
        [Required]
        public string Qualifications { get; set; }
        [Required]
        public string PriorWork_Experiences { get; set; }
        [Required]
        public string Hobbies { get; set; }
        [Required]
        public string Contact_number { get; set; }
        [Required]
        public string Email { get; set; }
       
        [Required]
        [ForeignKey("Jobseeker_Id")]
        public Jobseeker Jobseeker { get; set; }

        public string Jobseeker_Id { get; set; }
    }
    public class CreateResumeVM
    {

        [Required]
        public int Education_level { get; set; }
        [Required]
        public string Qualifications { get; set; }
        [Required]
        public string PriorWork_Experiences { get; set; }
        [Required]
        public string Hobbies { get; set; }
        [Required]
        public string Contact_number { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
       
        public JobseekerVM Jobseeker { get; set; }

        public string Jobseeker_Id { get; set; }
    }
}
