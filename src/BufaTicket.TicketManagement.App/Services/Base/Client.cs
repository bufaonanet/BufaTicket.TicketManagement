using System.Net.Http;

namespace BufaTicket.TicketManagement.App.Services
{
    public partial class Client : IClient
    {
        public HttpClient HttpClient
        {
            get
            {
                return _httpClient;
            }
        }
    }
}