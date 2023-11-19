using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Cars.Commands.CreateCar
{
    public record CreateCarCommand : IRequest<string>
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int EnginePower { get; set; }
    }
}
