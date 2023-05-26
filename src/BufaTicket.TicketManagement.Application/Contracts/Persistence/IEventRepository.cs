using BufaTicket.TicketManagement.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace BufaTicket.TicketManagement.Application.Contracts.Persistence
{
    public interface IEventRepository : IAsyncRepository<Event>
    {
        Task<bool> IsEventNameAndDateUnique(string name, DateTime date);
    }
}
