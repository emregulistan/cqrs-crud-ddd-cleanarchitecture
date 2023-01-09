using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Application.Contracts.Persistence;
using Vehicle.Domain.Entities.Concrete;

namespace Vehicle.Application.Features.Boat.Queries
{
    public class ListBoatByColorQueryHandler : IRequestHandler<ListBoatByColorQuery, List<BoatVM>>
    {
        private readonly IBoatRepository _boatRepository;
        private readonly IMapper _mapper;

        public ListBoatByColorQueryHandler(IBoatRepository boatRepository, IMapper mapper)
        {
            _boatRepository = boatRepository;
            _mapper = mapper;
        }

        public async Task<List<BoatVM>> Handle(ListBoatByColorQuery request, CancellationToken cancellationToken)
        {
            var boatList = await _boatRepository.ListBoatByColor(request.Color);
            return _mapper.Map<List<BoatVM>>(boatList);
        }
    }
}
