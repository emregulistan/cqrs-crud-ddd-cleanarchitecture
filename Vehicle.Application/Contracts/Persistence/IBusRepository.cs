using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Domain.Entities.Concrete;

namespace Vehicle.Application.Contracts.Persistence
{
    public interface IBusRepository : IAsyncRepository<Bus>
    {
        Task<IEnumerable<Bus>> ListBusByColor(string colorBus);
    }
}
