using System.Threading.Tasks;
using GraphQL;
using Microsoft.AspNetCore.Mvc;
using Poc.GraphQL.Web.Clients;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Poc.GraphQL.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirlineController : ControllerBase
    {
        private readonly AirlineHttpClient _httpClient;

        public AirlineController(AirlineHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet("{by-query}")]
        public async Task<GraphQLResponse<dynamic>> Get(string query)
        {
            return await _httpClient.GetAirlinesByReadAsStream(query);
        }
    }
}
