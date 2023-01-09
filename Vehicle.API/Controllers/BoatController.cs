using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Vehicle.Application.Features.Boat.Queries;
using Vehicle.Application.Features.Cars.Commands;
using Vehicle.Application.Features.Cars.Queries;

namespace Vehicle.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BoatController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BoatController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{boatColor}", Name = "ListBoatByColor")]
        [ProducesResponseType(typeof(IEnumerable<BoatVM>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<BoatVM>>> ListCarByColor(string boatColor)
        {
            var query = new ListBoatByColorQuery(boatColor);
            var boats = await _mediator.Send(query);
            return Ok(boats);
        }
    }
}
