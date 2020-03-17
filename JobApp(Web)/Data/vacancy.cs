using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobApp_Web_.Data
{
    public class vacancy
    {
        [Key]
        public int Id { get; set; }
        public string Job_title { get; set; }
        public string Job_Discription { get; set; }
        public string Job_Requirements { get; set; }
        public int Job_level { get; set; }
        public string Employment_type { get; set; }
        public DateTime Submit_deadline { get; set; }
        public string Job_category { get; set; }

        public Employer Employer { get; set; }
        public int EmployerId { get; set; }
    }
}
