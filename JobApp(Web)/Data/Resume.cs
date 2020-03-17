using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApp_Web_.Data
{
    public class Resume
    {
        public int Id { get; set; }
        public int Education_level { get; set; }
        public string Qualifications { get; set; }
        public string PriorWork_Experiences { get; set; }
        public string Hobbies { get; set; }
        public string Contact_number { get; set; }
        public string Email { get; set; }
        public Jobseeker Jobseeker { get; set; }
        public string JobseekerId { get; set; }
    }
}
