using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Application.Features.Boat.Queries;
using Vehicle.Application.Features.Bus.Queries;
using Vehicle.Application.Features.Cars.Commands;
using Vehicle.Application.Features.Cars.Queries;
using Vehicle.Domain.Entities.Concrete;

namespace Vehicle.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Car, CarVM>().ReverseMap();
            CreateMap<Car, HeadlightsCommand>().ReverseMap();
            CreateMap<Boat, BoatVM>().ReverseMap();
            CreateMap<Bus, BusVM>().ReverseMap();
        }
    }
}
