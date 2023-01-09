using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Application.Features.Cars.Queries
{
    public class CarVM
    {
        public int Id { get; set; }
        public string Wheels { get; set; }
        public bool Headlights { get; set; }
        public string Color { get; set; }
    }
}
