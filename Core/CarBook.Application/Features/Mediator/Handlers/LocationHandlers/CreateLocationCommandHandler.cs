using CarBook.Application.Features.Mediator.Commands.LocationCommands;
using CarBook.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entitites;

namespace CarBook.Application.Features.Mediator.Handlers.LocationHandlers
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateLocationCommand>
    {
        private readonly IRepository<Location> _repository;

        public CreateBlogCommandHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateLocationCommand request, CancellationToken cancellationToken)
        {
            await   _repository.CreateAsync(new Location()
            {
                Name = request.Name,
            });
        }
    }
}
