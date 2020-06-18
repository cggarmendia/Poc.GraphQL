using GraphQL;
using GraphQL.Types;
using Poc.GraphQL.Api.Data.Entities;
using Poc.GraphQL.Api.GraphQL.Messaging;
using Poc.GraphQL.Api.GraphQL.Types;
using Poc.GraphQL.Api.Repositories;

namespace Poc.GraphQL.Api.GraphQL
{
    public class IAGMutation : ObjectGraphType
    {
        public IAGMutation(AirlineReviewRepository reviewRepository, ReviewMessageService messageService)
        {
            FieldAsync<AirlineReviewType>(
                "createReview",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<AirlineReviewInputType>> { Name = "review" }),

                resolve: async context =>
                {
                    //ToDo Example: context.Errors.Add(new ExecutionError("error message here ..."));
                    var review = context.GetArgument<AirlineReview>("review");
                    await reviewRepository.AddReview(review);
                    messageService.AddReviewAddedMessage(review);
                    return review;
                });
        }
    }
}
