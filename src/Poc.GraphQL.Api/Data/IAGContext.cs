using Microsoft.EntityFrameworkCore;
using Poc.GraphQL.Api.Data.Entities;

namespace Poc.GraphQL.Api.Data
{
    public class IAGContext : DbContext
    {
        public IAGContext(DbContextOptions<IAGContext> options) : base(options)
        {

        }

        public DbSet<Airline> Airlines { get; set; }
        public DbSet<AirlineReview> AirlineReviews { get; set; }
    }
}
