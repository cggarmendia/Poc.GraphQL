using GraphQL.Types;
using Poc.GraphQL.Api.Data.Entities;

namespace Poc.GraphQL.Api.GraphQL.Types
{
    public class AirlineReviewType : ObjectGraphType<AirlineReview>
    {
        public AirlineReviewType()
        {
            Field(t => t.Id);
            Field(t => t.AirlineId);
            Field(t => t.Title);
            Field(t => t.Review);
        }
    }
}
