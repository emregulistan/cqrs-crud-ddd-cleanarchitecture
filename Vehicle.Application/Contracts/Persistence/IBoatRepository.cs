using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Domain.Entities.Concrete;

namespace Vehicle.Application.Contracts.Persistence
{
    public interface IBoatRepository : IAsyncRepository<Boat>
    {
        Task<IEnumerable<Boat>> ListBoatByColor(string colorBoat);
    }
}
