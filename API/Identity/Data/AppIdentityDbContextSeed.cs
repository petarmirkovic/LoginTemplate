using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.AspNetCore.Identity;

namespace API.Identity.Data
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager){
            if(!userManager.Users.Any())
            {
                var user = new AppUser{DisplayName = "pera", Email = "pera@test.com", UserName="pera@test.com"};
                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }

    }
}