using System;
using System.Collections.Generic;

namespace Poc.GraphQL.Web.Models
{
    public class AirlineModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LogoFileName { get; set; }
        public int NumberOfPlanes { get; set; }
        public int Rating { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public List<AirlineReviewModel> Reviews { get; set; }
    }
}
