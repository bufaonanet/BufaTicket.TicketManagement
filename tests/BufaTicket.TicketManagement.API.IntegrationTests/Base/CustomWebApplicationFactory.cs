using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;

namespace BufaTicket.TicketManagement.API.IntegrationTests.Base
{
    public class CustomWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup> where TStartup : class
    {
        public HttpClient Client { get; }

        public CustomWebApplicationFactory()
        {
            Client = GetAnonymousClient();
        }

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {

        }

        private HttpClient GetAnonymousClient()
        {
            return CreateClient();
        }
    }
}
