using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Application.Contracts.Persistence;
using Vehicle.Domain.Entities.Concrete;
using Vehicle.Infrastructure.Persistence;

namespace Vehicle.Infrastructure.Repositories
{
    public class BoatRepository : RepositoryBase<Boat>, IBoatRepository
    {
        public BoatRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<IEnumerable<Boat>> ListBoatByColor(string colorBoat)
        {
            var boatsList = await _dbContext.Boats
                                    .Where(o => o.Color == colorBoat)
                                    .ToListAsync();
            return boatsList;
        }
    }
}
