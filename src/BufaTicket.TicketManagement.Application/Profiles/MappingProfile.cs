using AutoMapper;
using BufaTicket.TicketManagement.Application.Features.Categories.Commands.CreateCateogry;
using BufaTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using BufaTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using BufaTicket.TicketManagement.Application.Features.Events.Commands.CreateEvent;
using BufaTicket.TicketManagement.Application.Features.Events.Commands.UpdateEvent;
using BufaTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetail;
using BufaTicket.TicketManagement.Application.Features.Events.Queries.GetEventsExport;
using BufaTicket.TicketManagement.Application.Features.Events.Queries.GetEventsList;
using BufaTicket.TicketManagement.Application.Features.Orders.Queries.GetOrdersForMonth;
using BufaTicket.TicketManagement.Domain.Entities;

namespace BufaTicket.TicketManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();
            CreateMap<Event, EventExportDto>().ReverseMap();

            CreateMap<Order, OrdersForMonthDto>();
        }
    }
}
