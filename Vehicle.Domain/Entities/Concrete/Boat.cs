using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Domain.Common;

namespace Vehicle.Domain.Entities.Concrete
{
    public class Boat : EntityBase, IVehicle
    {
        [Key]
        public int Id { get; set; }
        public string Color { get; set; }
    }
}
