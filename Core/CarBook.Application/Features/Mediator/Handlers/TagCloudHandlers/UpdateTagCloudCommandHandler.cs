﻿using CarBook.Application.Features.Mediator.Commands.LocationCommands;
using CarBook.Application.Features.Mediator.Commands.TagCloudCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entitites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entitites;

namespace CarBook.Application.Features.Mediator.Handlers.LocationHandlers
{
    public class UpdateTagCloudCommandHandler : IRequestHandler<UpdateTagCloudCommand>
    {
        private readonly IRepository<TagCloud> _repository;

        public UpdateTagCloudCommandHandler(IRepository<TagCloud> repository
            )
        {
            _repository = repository;
        }

        public async Task Handle(UpdateTagCloudCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.TagCloudID);
            value.Title = request.Title;
            value.blogID = request.blogID;
            await  _repository.UpdateAsync(value);
                    
        }
    }
}
