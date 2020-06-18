using System.ComponentModel.DataAnnotations;

namespace Poc.GraphQL.Api.Data.Entities
{
    public class AirlineReview
    {
        public int Id { get; set; }
        public int AirlineId { get; set; }
        public Airline Airline { get; set; }

        [StringLength(200), Required]
        public string Title { get; set; }
        public string Review { get; set; }
    }
}
