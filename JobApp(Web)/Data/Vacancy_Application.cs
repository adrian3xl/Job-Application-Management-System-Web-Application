using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobApp_Web_.Data
{
    public class Vacancy_Application
    {
        [Key]
        public int id { get; set; }


      //  [ForeignKey("resume_id")]
        public Resume Resume_request { get; set; }
        public int resume_request_id { get; set; }


       // [ForeignKey("vacancy_id")]
        public vacancy vacancy_request { get; set; }
        public int vacancy_request_id { get; set; }

        public string Application_status { get; set; }
    }
}
