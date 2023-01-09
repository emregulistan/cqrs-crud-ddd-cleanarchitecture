using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Application.Contracts.Persistence;

namespace Vehicle.Application.Features.Bus.Queries
{
    public class ListBusByColorQueryHandler : IRequestHandler<ListBusByColorQuery, List<BusVM>>
    {
        private readonly IBusRepository _busRepository;
        private readonly IMapper _mapper;

        public ListBusByColorQueryHandler(IBusRepository busRepository, IMapper mapper)
        {
            _busRepository = busRepository;
            _mapper = mapper;
        }

        public async Task<List<BusVM>> Handle(ListBusByColorQuery request, CancellationToken cancellationToken)
        {
            var busList = await _busRepository.ListBusByColor(request.Color);
            return _mapper.Map<List<BusVM>>(busList);
        }
    }
}
