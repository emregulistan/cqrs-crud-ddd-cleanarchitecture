using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Vehicle.Application.Features.Cars.Commands;
using Vehicle.Application.Features.Cars.Queries;

namespace Vehicle.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{carColor}", Name = "ListCarByColor")]
        [ProducesResponseType(typeof(IEnumerable<CarVM>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<CarVM>>> ListCarByColor(string carColor)
        {
            var query = new ListCarByColorQuery(carColor);
            var cars = await _mediator.Send(query);
            return Ok(cars);
        }

        [HttpDelete("{id}", Name = "DeleteCar")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> DeleteCar(int id)
        {
            var command = new DeleteCarCommand() { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpPut(Name = "UpdateOrder")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> UpdateHeadlights([FromBody] HeadlightsCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
