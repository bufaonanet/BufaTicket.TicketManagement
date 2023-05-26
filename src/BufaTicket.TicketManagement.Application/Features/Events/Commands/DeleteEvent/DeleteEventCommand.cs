using MediatR;
using System;

namespace BufaTicket.TicketManagement.Application.Features.Events.Commands.DeleteEvent
{
    public class DeleteEventCommand : IRequest<Unit>
    {
        public Guid EventId { get; set; }
    }
}
