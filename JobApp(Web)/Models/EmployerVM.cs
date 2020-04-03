using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobApp_Web_.Models
{
    public class EmployerVM
    {
        [Required]
        public string Id { get; set; }
        [Display(Name = " Company Name")]
        public string Company_name { get; set; }
        [Required]
        [Display(Name = " Company Background")]
        public string Company_background { get; set; }
        [Required]
        [Display(Name = " Company Locatiion")]
        public string Company_locatiion { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Workforce Number")]
        public int Workforce_number { get; set; }
        [Display(Name = "Company Email")]
        public string Company_Email { get; set; }
        [Display(Name = "Industry Type")]
        public string Industry_type { get; set; }
    }
}
