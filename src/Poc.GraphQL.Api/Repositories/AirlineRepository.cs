using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Poc.GraphQL.Api.Data;
using Poc.GraphQL.Api.Data.Entities;

namespace Poc.GraphQL.Api.Repositories
{
    public class AirlineRepository : IDisposable
    {
        private readonly IAGContext _context;

        public AirlineRepository(IAGContext context)
        {
            _context = context;
        }

        public async Task<List<Airline>> GetAll()
        {
            return await _context.Airlines.ToListAsync();
        }

        public async Task<Airline> GetById(int id)
        {
            return await _context.Airlines.SingleOrDefaultAsync(airline => airline.Id == id);
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
