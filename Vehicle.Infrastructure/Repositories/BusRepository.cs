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
    public class BusRepository : RepositoryBase<Bus>, IBusRepository
    {
        public BusRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<IEnumerable<Bus>> ListBusByColor(string colorBus)
        {
            var busList = await _dbContext.Bus
                                    .Where(o => o.Color == colorBus)
                                    .ToListAsync();
            return busList;
        }
    }
}
