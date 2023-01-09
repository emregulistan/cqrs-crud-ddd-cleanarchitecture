using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Vehicle.Application.Features.Bus.Queries;
using Vehicle.Application.Features.Cars.Commands;
using Vehicle.Application.Features.Cars.Queries;

namespace Vehicle.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BusController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{busColor}", Name = "ListBusByColor")]
        [ProducesResponseType(typeof(IEnumerable<CarVM>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<BusVM>>> ListBusByColor(string busColor)
        {
            var query = new ListBusByColorQuery(busColor);
            var buses = await _mediator.Send(query);
            return Ok(buses);
        }
    }
}
