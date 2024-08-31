using CarBook.Application.Features.CQRS.Commands.BrandCommands;
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
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        // update

        public async Task Handle(UpdateCarCommand command)
        {
            var value = await _repository.GetByIdAsync(command.CarID);
            value.Fuel=command.Fuel;
            value.Transmission=command.Transmission;
            value.BigImageUrl=command.BigImageUrl;
            value.BrandID =command.BrandID; 
            value.CoverImageUrl =command.CoverImageUrl;
            value.Km =command.Km;
            value.Luggage =command.Luggage;
            value.Model =command.Model;
            value.Seat = command.Seat;
            await _repository.UpdateAsync(value);
        }
    }
}
