using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.CQRS.Handlers.AboutHandlers;
using CarBook.Application.Features.Mediator.Commands.FooterAddressCommands;
using CarBook.Application.Interfaces;
using MediatR;
using UdemyCarBook.Domain.Entitites;

namespace CarBook.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class UpdateFooterAddressCommandHandler : IRequestHandler<UpdateFooterAddressCommand>
    {
        private readonly  IRepository<FooterAddress> repository;

        public UpdateFooterAddressCommandHandler(IRepository<FooterAddress> repository) 
        {
            this.repository = repository;
        }

        public async Task Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            var values = await repository.GetByIdAsync(request.FooterAddressID);
            values.Adress = request.Adress;
            values.Description = request.Description;
            values.Email = request.Email;
            await repository.UpdateAsync(values);
        }
    }
}
