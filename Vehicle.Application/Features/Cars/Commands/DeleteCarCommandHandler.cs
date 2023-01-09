using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Application.Contracts.Persistence;
using Vehicle.Domain.Entities;

namespace Vehicle.Application.Features.Cars.Commands
{
    public class DeleteCarCommandHandler : IRequestHandler<DeleteCarCommand>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<DeleteCarCommandHandler> _logger;

        public DeleteCarCommandHandler(ICarRepository carRepository, IMapper mapper, ILogger<DeleteCarCommandHandler> logger)
        {
            _carRepository = carRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Unit> Handle(DeleteCarCommand request, CancellationToken cancellationToken)
        {
            var carToDelete = await _carRepository.GetByIdAsync(request.Id);

            await _carRepository.DeleteAsync(carToDelete);
            _logger.LogInformation($"Order {carToDelete.Id} is successfully deleted.");

            return Unit.Value;
        }
    }
}
