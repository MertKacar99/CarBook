﻿using CarBook.Application.Features.Mediator.Commands.BlogCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entitites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entitites;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class UpdateAuthorCommandHandler : IRequestHandler<UpdateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public UpdateAuthorCommandHandler(IRepository<Blog> repository
            )
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.BlogID);
            value.AuthorID = request.AuthorID;
            value.CreatedDate = request.CreatedDate;
            value.CategoryID = request.CategoryID;
            value.CoverImageUrl = request.CoverImageUrl;
            value.Title = request.Title;
            await  _repository.UpdateAsync(value);
                    
        }
    }
}
