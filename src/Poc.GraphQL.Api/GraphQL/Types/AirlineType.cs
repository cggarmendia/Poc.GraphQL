using System.Security.Claims;
using GraphQL.DataLoader;
using GraphQL.Types;
using Poc.GraphQL.Api.Data.Entities;
using Poc.GraphQL.Api.Repositories;

namespace Poc.GraphQL.Api.GraphQL.Types
{
    public class AirlineType : ObjectGraphType<Airline>
    {
        public AirlineType(AirlineReviewRepository reviewRepository, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(field => field.Id);
            Field(field => field.Name).Description("The name of the Airline");
            Field(field => field.Description);
            Field(field => field.LogoFileName).Description("The logo of the Airline");
            Field(field => field.Rating).Description("The rating of the Airline");
            Field(field => field.CreatedAt).Description("when the airline was part of IAG");
            Field(field => field.NumberOfPlanes);

            Field<ListGraphType<AirlineReviewType>>(
                "reviews",
                resolve: context =>
                {
                    var user = (ClaimsPrincipal)context.UserContext;
                    var loader =
                        dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<int, AirlineReview>(
                            "GetReviewsByProductId", reviewRepository.GetByAirlines);
                    return loader.LoadAsync(context.Source.Id);
                });
        }
    }
}
