using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using Poc.GraphQL.Api.Data.Entities;

namespace Poc.GraphQL.Api.GraphQL.Messaging
{
    public class ReviewMessageService
    {
        private readonly ISubject<ReviewAddedMessage> _messageStream = new ReplaySubject<ReviewAddedMessage>(1);

        public ReviewAddedMessage AddReviewAddedMessage(AirlineReview review)
        {
            var message = new ReviewAddedMessage
            {
                AirlineId = review.AirlineId,
                Title = review.Title
            };
            _messageStream.OnNext(message);
            return message;
        }

        public IObservable<ReviewAddedMessage> GetMessages()
        {
            return _messageStream.AsObservable();
        }
    }
}
