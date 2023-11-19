using CleanArchitecture.Application.Features.Cars.Commands.CreateCar;
using CleanArchitecture.WebApi.Common;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : BaseApiController
    {
        public CarController(IMediator meditor) : base(meditor)
        {
        }

        [HttpPost]
        public async Task<IActionResult> CrateCar(CreateCarCommand command,CancellationToken cancellationToken)
        {
            
            var addedCarId = await _meditor.Send(command,cancellationToken);
            return Ok(addedCarId);
        }
    }
}
