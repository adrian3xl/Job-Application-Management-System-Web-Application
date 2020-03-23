using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace JobApp_Web_.Data
{
    public class Jobseeker : IdentityUser
    {
        [Required]
        public string Firstname { get; set; }
        public string Lastname { get; set; }

       
        public DateTime DateOfBirth { get; set; }
    }
}
