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
        public string Company_name { get; set; }
        [Required]
        public string Company_background { get; set; }
        [Required]
        public string Company_locatiion { get; set; }
        [Required]
        public string Campany_contact_number { get; set; }
        public int Workforce_number { get; set; }
        public string Company_Email { get; set; }
        public string Industry_type { get; set; }
    }
}
