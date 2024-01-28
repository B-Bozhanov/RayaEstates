namespace RayaEstates.Data.Seeding
{
    using System;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;

    using RayaEstates.Common;
    using RayaEstates.Data.Models;

    public class UserSeeder : ISeeder
    {
        public async Task SeedAsync(EstateDbContext dbContext, IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            var administrators = GlobalConstants.GetAdministrators();

            foreach (var administrator in administrators)
            {
                if (!dbContext.Users.Any(u => u.UserName == administrator.UserName))
                {
                    ApplicationUser user = new()
                    {
                        FirstName = administrator.FirstName,
                        LastName = administrator.LastName,
                        UserName = administrator.UserName,
                        Email = administrator.Email,
                    };

                    await userManager.CreateAsync(user, administrator.Password);

                    await userManager.AddToRoleAsync(user, GlobalConstants.AdministratorRoleName);
                }
            }
        }
    }
}
