
namespace Poc.GraphQL.Web.Models
{
    public class AirlineReviewModel
    {
        public int Id { get; set; }
        public int AirlineId { get; set; }
        public string Title { get; set; }
        public string Review { get; set; }
    }
}
