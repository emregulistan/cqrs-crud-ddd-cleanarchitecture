using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Application.Features.Cars.Commands
{
    public class DeleteCarCommand : IRequest
    {
        public int Id { get; set; }

    }
}
