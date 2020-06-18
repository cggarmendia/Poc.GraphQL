using GraphQL;
using GraphQL.Types;

namespace Poc.GraphQL.Api.GraphQL
{
    public class IAGSchema : Schema
    {
        public IAGSchema(IDependencyResolver resolver) :
            base(resolver)
        {
            Query = resolver.Resolve<IAGQuery>();
            Mutation = resolver.Resolve<IAGMutation>();
            Subscription = resolver.Resolve<IAGSubscription>();
        }
    }
}
