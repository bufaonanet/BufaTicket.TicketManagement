using BufaTicket.TicketManagement.Application.Models.Mail;
using System.Threading.Tasks;

namespace BufaTicket.TicketManagement.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
