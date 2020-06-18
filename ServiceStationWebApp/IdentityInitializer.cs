using DataLayer.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace ServiceStationWebApp
{
    public class IdentityInitializer
    {
        private const string _email = "mashaprotskaya@gmail.com";
        private const string _password = "12345password";
        private const string _surname = "Protskaya";
        private const string _firstName = "Masha";
        public static async Task InitializeAsync(UserManager<Employee> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (await roleManager.FindByNameAsync(Roles.Admin) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Roles.Admin));
            }
            if (await roleManager.FindByNameAsync(Roles.User) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Roles.User));
            }
            if (await userManager.FindByNameAsync(_email) == null)
            {
                var admin = new Employee { Surname = _surname, FirstName = _firstName, Email = _email, UserName = _email };
                IdentityResult result = await userManager.CreateAsync(admin, _password);
                
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, Roles.Admin);
                }
            }
        }
    }
}
