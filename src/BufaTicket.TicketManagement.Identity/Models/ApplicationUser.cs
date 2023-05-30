﻿using Microsoft.AspNetCore.Identity;

namespace BufaTicket.TicketManagement.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}