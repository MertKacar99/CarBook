using CarBook.Application.Features.CQRS.Commands.CarCommands;
using CarBook.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entitites;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;
        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCarCommand createCarCommand)
        {
            await _repository.CreateAsync(new Car
            {
                BrandID = createCarCommand.BrandID,
                BigImageUrl = createCarCommand.BigImageUrl,
                Luggage = createCarCommand.Luggage,
                Km=createCarCommand.Km,
                Model = createCarCommand.Model,
                Seat = createCarCommand.Seat,
                Transmission = createCarCommand.Transmission,
                Fuel = createCarCommand.Fuel,
                CoverImageUrl = createCarCommand.CoverImageUrl

            });
        }
    }
}
