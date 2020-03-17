using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApp_Web_.Data
{
    public class Jobseeker: IdentityUser 
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
