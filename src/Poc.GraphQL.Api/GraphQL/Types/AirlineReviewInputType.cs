using GraphQL.Types;

namespace Poc.GraphQL.Api.GraphQL.Types
{
    public class AirlineReviewInputType : InputObjectGraphType
    {
        public AirlineReviewInputType()
        {
            Name = "reviewInput";
            Field<IdGraphType>("id");
            Field<NonNullGraphType<StringGraphType>>("title");
            Field<StringGraphType>("review");
            Field<IntGraphType>("airlineId");
        }
    }
}
