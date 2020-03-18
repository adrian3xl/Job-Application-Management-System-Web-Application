using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace JobApp_Web_.Data
{
    public class Employer : IdentityUser
    {

        [Required]
        public string Company_name { get; set; }
        public string Company_background { get; set; }
        public string Company_locatiion { get; set; }
        public string Campany_contact_number { get; set; }
        public int Workforce_number { get; set; }
        public string Company_Email { get; set; }
        public string Industry_type { get; set; }


    }
}
