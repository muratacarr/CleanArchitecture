using AutoMapper;
using CleanArchitecture.Application.Features.Cars.Commands.CreateCar;
using CleanArchitecture.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Common.Mapping
{
    public class CarMapping : Profile
    {
        public CarMapping() 
        {
            CreateMap<Car, CreateCarCommand>().ReverseMap();
        }
    }
}
