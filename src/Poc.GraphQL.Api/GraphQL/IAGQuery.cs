using GraphQL.Types;
using Poc.GraphQL.Api.GraphQL.Types;
using Poc.GraphQL.Api.Repositories;

namespace Poc.GraphQL.Api.GraphQL
{
    public class IAGQuery : ObjectGraphType
    {
        public IAGQuery(AirlineRepository airlineRepository, AirlineReviewRepository airlineReviewRepository)
        {
            Field<ListGraphType<AirlineType>>(
                "airlines",
                resolve: context => airlineRepository.GetAll());

            Field<AirlineType>(
                "airline",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return airlineRepository.GetById(id);
                }
            );

            Field<ListGraphType<AirlineReviewType>>(
                "reviews",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "airlineId" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("airlineId");
                    return airlineReviewRepository.GetByAirline(id);
                }
            );
        }
    }
}
