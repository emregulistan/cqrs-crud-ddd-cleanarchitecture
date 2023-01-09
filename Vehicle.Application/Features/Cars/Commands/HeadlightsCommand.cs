using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Application.Features.Cars.Queries;
using Vehicle.Domain.Entities.Concrete;

namespace Vehicle.Application.Features.Cars.Commands
{
    public class HeadlightsCommand : IRequest
    {
        public int Id { get; set; }
        public string Wheels { get; set; }
        public bool Headlights { get; set; }
        public string Color { get; set; }

    }
}
