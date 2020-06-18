using System;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Client.Abstractions;
using Newtonsoft.Json;
using Poc.GraphQL.Web.Models;

namespace Poc.GraphQL.Web.Clients
{
    public class AirlineGraphClient
    {
        private readonly IGraphQLClient _client;

        public AirlineGraphClient(IGraphQLClient client)
        {
            _client = client;
        }

        public async Task<AirlineModel> GetAirline(int id)
        {
            var request = new GraphQLRequest
            {
                OperationName = "airlineQuery",
                Query = @" 
                query airlineQuery($airlineId: ID!)
                { data:airline(id: $airlineId) 
                    { id name description rating numberOfPlanes createdAt logoFileName
                      reviews { title review }
                    }
                }",
                Variables = new { airlineId = id }
            };

            await GetAirlineModelByDynamicObject(request);

            return await GetAirlineModelByGraphQLResponseObject(request);
        }

        public async Task AddReview(AirlineReviewModel review)
        {
            var query = new GraphQLRequest
            {
                Query = @" 
                mutation($review: reviewInput!)
                {
                    data:createReview(review: $review)
                    {
                        id
                        airlineId
                        title
                        review
                    }
                }",
                Variables = new { review }
            };
            var response = await _client.SendQueryAsync<GraphQLResponse<AirlineReviewModel>> (query);
            
        }

        public async Task SubscribeToUpdates()
        {
            IObservable<GraphQLResponse<GraphQLResponse<ReviewAddedMessageModel>>> subscriptionStream
                = _client.CreateSubscriptionStream<GraphQLResponse<ReviewAddedMessageModel>>(new GraphQLRequest("subscription { data:reviewAdded { title airlineId } }"));

            subscriptionStream.Subscribe(response =>
            {
                //ToDo: DoSomethings ... SignalR ???
                Console.WriteLine($"airline '{response.Data?.Data?.AirlineId}' - '{response.Data?.Data?.Title}'.");
            });
        }

        private async Task<AirlineModel> GetAirlineModelByDynamicObject(GraphQLRequest request)
        {
            var response = await _client.SendQueryAsync<dynamic>(request).ConfigureAwait(false);
            Response<AirlineModel> responseDeserialize = JsonConvert.DeserializeObject<Response<AirlineModel>>(response.Data.ToString());
            return responseDeserialize.Data;
        }

        private async Task<AirlineModel> GetAirlineModelByGraphQLResponseObject(GraphQLRequest request)
        {
            var response = await _client.SendQueryAsync<GraphQLResponse<AirlineModel>>(request).ConfigureAwait(false);
            return response.Data.Data;
        }
    }
}
