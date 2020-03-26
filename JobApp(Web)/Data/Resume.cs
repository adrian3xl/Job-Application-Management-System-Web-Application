using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobApp_Web_.Data
{
    public class Resume
    {
        [Key]
        public int Id { get; set; }
        public string Education_level { get; set; }
        public string Qualifications { get; set; }
        public string PriorWork_Experiences { get; set; }
        public string Hobbies { get; set; }
        public string Contact_number { get; set; }
        public string Email { get; set; }

        [ForeignKey("JobseekerId")]
        public Jobseeker Jobseeker { get; set; }

        public string JobseekerId { get; set; }
    }
}
