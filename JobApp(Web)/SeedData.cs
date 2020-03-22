using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApp_Web_
{
    public static class SeedData
    {
        public static void Seed(UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {

        }

        public static void SeedUser(UserManager<IdentityUser> userManager)
        {
            if (userManager.FindByNameAsync("Employer").Result == null)
            {
                var user = new IdentityUser
                {
                    UserName = "Employer",
                    Email = "employerlocalhost"
                };
                var result = userManager.CreateAsync(user, "P@ssword1").Result;
            }
        }

        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Employer").Result)
            {
                var role = new IdentityRole
                {
                    Name="Employer"
                };
                roleManager.CreateAsync(role);
            }

           if (!roleManager.RoleExistsAsync("Jobseeker").Result){

                var role = new IdentityRole
                {
                    Name = "Jobseeker"
                };
                roleManager.CreateAsync(role);

            }
            
                
            
        }
    }
}
