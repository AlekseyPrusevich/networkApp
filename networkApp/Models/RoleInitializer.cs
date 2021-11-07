using networkApp.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace networkApp
{
    public class RoleInitializer
    {
        public static async Task InitializeAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            string adminEmail = "admin@gmail.com";
            string password = "_Aa111";
            
         

           

            if (await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("admin"));
            }
            if (await roleManager.FindByNameAsync("teacher") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("teacher"));
            }
            if (await roleManager.FindByNameAsync("student") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("student"));
            }
           
            if (await userManager.FindByNameAsync("admin") == null)
            {              


                User admin = new User { Email = adminEmail, UserName = "admin"};
                IdentityResult result = await userManager.CreateAsync(admin, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "admin");
                }
            }
        }
    }
}
