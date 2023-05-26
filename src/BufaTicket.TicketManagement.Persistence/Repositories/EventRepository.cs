using BufaTicket.TicketManagement.Application.Contracts.Persistence;
using BufaTicket.TicketManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace BufaTicket.TicketManagement.Persistence.Repositories
{
    public class EventRepository : BaseRepository<Event>, IEventRepository
    {
        public EventRepository(BufaTicketDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate)
        {
            var matches = await _dbContext.Events.AnyAsync(e => e.Name.Equals(name) && e.Date.Date.Equals(eventDate.Date));
            return matches;
        }
    }
}
