using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobApp_Web_.Data
{
    public class Vacancy_Application
    {
        [Key]
        public int id { get; set; }


        [ForeignKey("resume_id")]
        public Resume Resume { get; set; }
        public int resume_id { get; set; }

        [ForeignKey("Jobseeker_Id")]
        public Jobseeker Jobseeker { get; set; }
        public string Jobseeker_id { get; set; }

        [ForeignKey("vacancy_id")]
        public vacancy vacancy { get; set; }
        public int vacancy_id { get; set; }

        public string Application_status { get; set; }
    }
}
