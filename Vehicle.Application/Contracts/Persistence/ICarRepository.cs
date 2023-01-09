using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Application.Features.Cars.Queries;
using Vehicle.Domain.Entities.Concrete;

namespace Vehicle.Application.Contracts.Persistence
{
    public interface ICarRepository : IAsyncRepository<Car>
    {
        Task<IEnumerable<Car>> ListCarByColor(string colorCar);
    }
}
