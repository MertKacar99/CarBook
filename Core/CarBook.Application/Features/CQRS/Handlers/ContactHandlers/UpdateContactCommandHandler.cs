using CarBook.Application.Features.CQRS.Commands.ContactCommands;
using CarBook.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entitites;

namespace CarBook.Application.Features.CQRS.Handlers.ContactHandlers
{
    public  class UpdateContactCommandHandler
    {
        private readonly IRepository<Contact> repository;

        public UpdateContactCommandHandler(IRepository<Contact> repository)
        {
            this.repository = repository;
        }

        public async Task Handle(UpdateContactCommand command)
        {
            var values = await repository.GetByIdAsync(command.ContactID);
            values.Message = command.Message;
            values.Subject = command.Subject;
            values.Email = command.Email;
            values.SendDate = command.SendDate;
            values.Name = command.Name;
            await repository.UpdateAsync(values);
        }
    }
}
