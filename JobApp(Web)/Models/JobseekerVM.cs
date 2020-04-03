using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobApp_Web_.Models
{
    public class JobseekerVM
    {
        [Required]
        [Display(Name = "First Name")]
        public string Firstname { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string Lastname { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date Of Birth(MM/DD/YYYY)")]
        public DateTime? DateOfBirth { get; set; }
    }
}
