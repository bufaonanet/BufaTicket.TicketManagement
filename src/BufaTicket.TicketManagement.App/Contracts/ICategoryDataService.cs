using BufaTicket.TicketManagement.App.Services;
using BufaTicket.TicketManagement.App.Services.Base;
using BufaTicket.TicketManagement.App.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BufaTicket.TicketManagement.App.Contracts
{
    public interface ICategoryDataService
    {
        Task<List<CategoryViewModel>> GetAllCategories();
        Task<List<CategoryEventsViewModel>> GetAllCategoriesWithEvents(bool includeHistory);
        Task<ApiResponse<CategoryDto>> CreateCategory(CategoryViewModel categoryViewModel);
    }
}