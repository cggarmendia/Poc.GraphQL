using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Poc.GraphQL.Api.Data.Entities
{
    public class Airline
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        public string LogoFileName { get; set; }
        public int NumberOfPlanes { get; set; }
        public int Rating { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public List<AirlineReview> AirlineReviews { get; set; }
    }
}
