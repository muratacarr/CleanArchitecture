using AutoMapper;
using CleanArchitecture.Application.Common.Interfaces.Repositories;
using CleanArchitecture.Domain.Entity;
using MediatR;

namespace CleanArchitecture.Application.Features.Cars.Commands.CreateCar;

public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, string>
{
    private readonly ICarRepository _carRepository;
    private readonly IMapper _mapper;

    public CreateCarCommandHandler(ICarRepository carRepository, IMapper mapper)
    {
        _carRepository = carRepository;
        _mapper = mapper;
    }

    public async Task<string> Handle(CreateCarCommand request, CancellationToken cancellationToken)
    {
        var result = _mapper.Map<Car>(request);
        var car = await _carRepository.AddAsync(result, cancellationToken);
        return car.Id;
    }
}
