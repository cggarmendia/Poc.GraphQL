using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poc.GraphQL.Api.GraphQL.Messaging
{
    public class ReviewAddedMessage
    {
        public int AirlineId { get; set; }
        public string Title { get; set; }
    }
}
