using BufaTicket.TicketManagement.Identity.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace BufaTicket.TicketManagement.Identity.Seed
{
    public class UserCreator
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager)
        {
            var applicationUser = new ApplicationUser
            {
                FirstName = "Douglas",
                LastName = "Souto",
                UserName = "bufa",
                Email = "bufa@email.com",
                EmailConfirmed = true
            };

            var user = await userManager.FindByEmailAsync(applicationUser.Email);
            if (user == null)
            {
                await userManager.CreateAsync(applicationUser, "Senh@123");
            }
        }
    }
}
