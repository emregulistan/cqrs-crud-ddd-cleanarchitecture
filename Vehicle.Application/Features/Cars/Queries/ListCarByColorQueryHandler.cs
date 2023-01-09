using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Application.Contracts.Persistence;

namespace Vehicle.Application.Features.Cars.Queries
{
    public class ListCarByColorQueryHandler : IRequestHandler<ListCarByColorQuery, List<CarVM>>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public ListCarByColorQueryHandler(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<List<CarVM>> Handle(ListCarByColorQuery request, CancellationToken cancellationToken)
        {
            var carList = await _carRepository.ListCarByColor(request.Color);
            return _mapper.Map<List<CarVM>>(carList);
        }
    }
}
