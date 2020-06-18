using System.Threading.Tasks;
using GraphQL;
using GraphQL.Client.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Poc.GraphQL.Web.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Poc.GraphQL.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirlineReviewController : ControllerBase
    {
        private readonly IGraphQLClient _client;

        public AirlineReviewController(IGraphQLClient client)
        {
            _client = client;
        }

        // POST api/<AirlineReviewController>
        [HttpPost]
        public async Task<GraphQLResponse<dynamic>> Post(GraphQLRequestModel request)
        {
            return await _client.SendQueryAsync<dynamic>(new GraphQLRequest
            {
                OperationName = request.OperationName,
                Query = request.Query,
                Variables = request.Variables
            }).ConfigureAwait(false);
        }
    }
}
