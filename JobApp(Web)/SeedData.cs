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
            SeedRoles(roleManager);
            SeedUser(userManager);
        }

        private static void SeedUser(UserManager<IdentityUser> userManager)
        {
            if (userManager.FindByNameAsync("Employer").Result == null)
            {
                var user = new IdentityUser
                {
                    UserName = "Employer",
                    Email = "employerlocalhost"
                };
                var result = userManager.CreateAsync(user, "P@ssword1").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Employer").Wait();
                }
            }
        }

       private static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Employer").Result)
            {
                var role = new IdentityRole
                {
                    Name="Employer"
                };
               var result= roleManager.CreateAsync(role).Result;
            }

           if (!roleManager.RoleExistsAsync("Jobseeker").Result){

                var role = new IdentityRole
                {
                    Name = "Jobseeker"
                };
                var result = roleManager.CreateAsync(role).Result;

            }
            
                
            
        }
    }
}
