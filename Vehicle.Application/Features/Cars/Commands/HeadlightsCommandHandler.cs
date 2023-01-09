using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Application.Contracts.Persistence;
using Vehicle.Domain.Entities.Concrete;

namespace Vehicle.Application.Features.Cars.Commands
{
    public class HeadlightsCommandHandler : IRequestHandler<HeadlightsCommand>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<HeadlightsCommandHandler> _logger;

        public HeadlightsCommandHandler(ICarRepository carRepository, IMapper mapper, ILogger<HeadlightsCommandHandler> logger)
        {
            _carRepository = carRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Unit> Handle(HeadlightsCommand request, CancellationToken cancellationToken)
        {
            var headlightsToUpdate = await _carRepository.GetByIdAsync(request.Id);
            _mapper.Map(request, headlightsToUpdate, typeof(HeadlightsCommand), typeof(Car));
            await _carRepository.UpdateAsync(headlightsToUpdate);
            _logger.LogInformation($"{request.Id}");

            return Unit.Value;
        }
    }
}
