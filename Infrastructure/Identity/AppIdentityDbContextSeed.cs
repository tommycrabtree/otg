using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Tommy",
                    Email = "tommycrabtree@outlook.com",
                    UserName = "tommycrabtree",
                    Address = new Address
                    {
                        FirstName = "Tommy",
                        LastName = "Crabtree",
                        Street = "2099 N Mt Juliet Rd",
                        City = "Mt Juliet",
                        State = "TN",
                        ZipCode = "37122"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}