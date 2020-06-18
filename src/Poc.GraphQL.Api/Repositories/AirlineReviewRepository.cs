using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Poc.GraphQL.Api.Data;
using Poc.GraphQL.Api.Data.Entities;

namespace Poc.GraphQL.Api.Repositories
{
    public class AirlineReviewRepository : IDisposable
    {
        private readonly IAGContext _context;

        public AirlineReviewRepository(IAGContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AirlineReview>> GetByAirline(int airlineId)
        {
            return await _context.AirlineReviews.Where(airlineReview => airlineReview.AirlineId == airlineId).ToListAsync();
        }

        public async Task<ILookup<int, AirlineReview>> GetByAirlines(IEnumerable<int> airlineIds)
        {
            var reviews = await _context.AirlineReviews.Where(airlineReview => airlineIds.Contains(airlineReview.AirlineId)).ToListAsync();
            return reviews.ToLookup(review => review.AirlineId);
        }

        public async Task<AirlineReview> AddReview(AirlineReview review)
        {
            _context.AirlineReviews.Add(review);
            await _context.SaveChangesAsync();
            return review;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
