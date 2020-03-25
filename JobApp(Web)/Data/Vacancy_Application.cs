using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobApp_Web_.Data
{
    public class Vacancy_Application
    {
        [Key]
        public int Id { get; set; }


     //  [ForeignKey("resume_id")]
        public Resume Resume_request { get; set; }
        public int Resume_request_id { get; set; }


    //   [ForeignKey("vacancy_id")]
        public vacancy Vacancy_request { get; set; }
        public int Vacancy_request_id { get; set; }

        public string Application_status { get; set; }
    }
}
