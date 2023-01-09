using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Application.Features.Boat.Queries
{
    public class ListBoatByColorQuery : IRequest<List<BoatVM>>
    {
        public string Color { get; set; }
        public ListBoatByColorQuery(string colorBoat)
        {
            Color = colorBoat;
        }
    }
}
