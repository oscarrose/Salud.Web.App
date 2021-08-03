using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;

namespace Salud.Web.App.Services
{
    public class DbInitialize
    {
        public static async Task CreateRoles(IServiceProvider serviceProvider)
        {
            //var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            //var UserManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

            //var roles = new List<string>() { "Doctor", "Secretary" };

            //foreach (var item in roles)
            //{
            //    if (!await RoleManager.RoleExistsAsync(item)) {  
            //        await RoleManager.CreateAsync(new IdentityRole(item));
              
            //    }

            //    IdentityUser user = await UserManager.FindByIdAsync("brookvivir@gmail.com");

            //    await UserManager.AddToRoleAsync(user,"Doctor");

            //}
        }


    }
}
