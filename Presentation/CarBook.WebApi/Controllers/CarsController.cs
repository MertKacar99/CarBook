using CarBook.Application.Features.CQRS.Commands.BrandCommands;
using CarBook.Application.Features.CQRS.Commands.CarCommands;
using CarBook.Application.Features.CQRS.Handlers.BrandHandlers;
using CarBook.Application.Features.CQRS.Handlers.CarHandlers;
using CarBook.Application.Features.CQRS.Queries.BrandQueries;
using CarBook.Application.Features.CQRS.Queries.CarQueries;
using CarBook.Application.Features.CQRS.Results.CarResults;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly CreateCarCommandHandler _CreateCarCommandHandler;
        private readonly GetCarQueryHandler _GetCarQueryHandler;
        private readonly GetCarByIdQueryHandler _CarByIdQueryHandler;
        private readonly UpdateCarCommandHandler _UpdateCarCommandHandler;
        private readonly RemoveCarCommandHandler _RemoveCarCommandHandler;
        private readonly GetCarWithBrandQueryHandler _GetCarWithBrandCommandHandler;
        private readonly GetLast5CarsWithBrandQueryHandler _getLast5CarsWithBrandQueryHandler;
        public CarsController(CreateCarCommandHandler commandHandler, GetCarQueryHandler queryHandler, GetCarByIdQueryHandler CarByIdQueryHandler, UpdateCarCommandHandler UpdateCarCommandHandler, RemoveCarCommandHandler RemoveCarCommandHandler, GetCarWithBrandQueryHandler getCarWithBrandCommandHandler, GetLast5CarsWithBrandQueryHandler getLast5CarsWithBrandQueryHandler)
        {
            _CreateCarCommandHandler = commandHandler;
            _GetCarQueryHandler = queryHandler;
            _CarByIdQueryHandler = CarByIdQueryHandler;
            _UpdateCarCommandHandler = UpdateCarCommandHandler;
            _RemoveCarCommandHandler = RemoveCarCommandHandler;
            _GetCarWithBrandCommandHandler = getCarWithBrandCommandHandler;
            _getLast5CarsWithBrandQueryHandler = getLast5CarsWithBrandQueryHandler;
    
        }

        [HttpGet]
        public async Task<IActionResult> CarList()
        {
            var values = await _GetCarQueryHandler.Handle();
            return Ok(values);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCar(int id)
        {
            var value = await _CarByIdQueryHandler.Handle(new GetCarByIdQuery(id));
            return Ok(value);

        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateCarCommand command)
        {
            await _CreateCarCommandHandler.Handle(command);
            return Ok("Araba Eklendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveCar(int id)
        {
            await _RemoveCarCommandHandler.Handle(new RemoveCarCommand(id));
            return Ok("Araba silme işlemi başarılı");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCar(UpdateCarCommand command)
        {
            await _UpdateCarCommandHandler.Handle(command);
            return Ok("Araba güncellendi");
        }
        [HttpGet("GetCarWithBrand")]
        public IActionResult GetCarWithCar()
        {
            var value = _GetCarWithBrandCommandHandler.Handle();
            return Ok(value);

        }
        [HttpGet("GetLast5CarsWithBrandQueryHandler")]
        public IActionResult GetLast5CarsWithBrandQueryHandler()
        {
            var value = _getLast5CarsWithBrandQueryHandler.Handle();
            return Ok(value);

        }

      
    }
}
