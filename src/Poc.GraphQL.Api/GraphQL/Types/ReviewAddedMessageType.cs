using GraphQL.Types;
using Poc.GraphQL.Api.GraphQL.Messaging;

namespace Poc.GraphQL.Api.GraphQL.Types
{
    public class ReviewAddedMessageType : ObjectGraphType<ReviewAddedMessage>
    {
        public ReviewAddedMessageType()
        {
            Field(t => t.AirlineId);
            Field(t => t.Title);
        }
    }
}
