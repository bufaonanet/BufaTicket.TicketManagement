using BufaTicket.TicketManagement.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BufaTicket.TicketManagement.Identity
{
    public class BufaTicketIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public BufaTicketIdentityDbContext(DbContextOptions<BufaTicketIdentityDbContext> options)
            : base(options) { }


    }
}
