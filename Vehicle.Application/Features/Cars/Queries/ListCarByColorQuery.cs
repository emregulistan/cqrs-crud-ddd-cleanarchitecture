using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Application.Features.Cars.Queries
{
    public class ListCarByColorQuery : IRequest<List<CarVM>>
    {
        public string Color { get; set; }
        public ListCarByColorQuery(string colorCar)
        {
            Color = colorCar;
        }
    }
}
