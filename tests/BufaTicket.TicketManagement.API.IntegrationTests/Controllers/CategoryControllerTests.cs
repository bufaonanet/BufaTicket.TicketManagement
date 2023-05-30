using BufaTicket.TicketManagement.Api;
using BufaTicket.TicketManagement.API.IntegrationTests.Base;
using BufaTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace BufaTicket.TicketManagement.API.IntegrationTests.Controllers
{
    public class CategoryControllerTests : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _httpClient;

        public CategoryControllerTests(CustomWebApplicationFactory<Startup> factory)
        {
            factory.ClientOptions.BaseAddress = new Uri("http://localhost/api/Category");
            _httpClient = factory.Client;
        }

        [Fact]
        public async Task ReturnsSuccessResult()
        {

            var response = await _httpClient.GetAsync("/api/category/all");            

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<List<CategoryListVm>>(responseString);

            Assert.IsType<List<CategoryListVm>>(result);
            Assert.NotEmpty(result);
        }


    }
}
