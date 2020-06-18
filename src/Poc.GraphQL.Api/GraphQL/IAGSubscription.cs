using GraphQL.Resolvers;
using GraphQL.Types;
using Poc.GraphQL.Api.GraphQL.Messaging;
using Poc.GraphQL.Api.GraphQL.Types;

namespace Poc.GraphQL.Api.GraphQL
{
    public class IAGSubscription : ObjectGraphType
    {
        public IAGSubscription(ReviewMessageService messageService)
        {
            Name = "Subscription";
            AddField(new EventStreamFieldType
            {
                Name = "reviewAdded",
                Type = typeof(ReviewAddedMessageType),
                Resolver = new FuncFieldResolver<ReviewAddedMessage>(c => c.Source as ReviewAddedMessage),
                Subscriber = new EventStreamResolver<ReviewAddedMessage>(c => messageService.GetMessages())
            });
        }
    }
}
