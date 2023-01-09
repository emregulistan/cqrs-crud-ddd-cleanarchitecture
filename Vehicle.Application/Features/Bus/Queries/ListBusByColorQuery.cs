using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Application.Features.Bus.Queries
{
    public class ListBusByColorQuery : IRequest<List<BusVM>>
    {
        public string Color { get; set; }
        public ListBusByColorQuery(string colorBus)
        {
            Color = colorBus;
        }
    }
}
