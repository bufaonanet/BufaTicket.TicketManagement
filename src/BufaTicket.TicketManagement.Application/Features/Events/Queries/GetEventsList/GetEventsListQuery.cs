using MediatR;
using System.Collections.Generic;

namespace BufaTicket.TicketManagement.Application.Features.Events.Queries.GetEventsList
{
    public class GetEventsListQuery : IRequest<List<EventListVm>>
    {

    }
}
