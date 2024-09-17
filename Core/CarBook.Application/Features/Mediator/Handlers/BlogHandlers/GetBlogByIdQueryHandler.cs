using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Results.BlogResults;
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
    public class GetAuthorByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, GetBlogByIdQueryResult>
    {
        private readonly IRepository<Blog> _repository;

        public GetAuthorByIdQueryHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<GetBlogByIdQueryResult> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
             var value = await _repository.GetByIdAsync(request.id);

            return new GetBlogByIdQueryResult()
            {
                BlogID = value.BlogID,
                AuthorID = value.AuthorID,
                Title = value.Title,
                CreatedDate = value.CreatedDate,
                CoverImageUrl = value.CoverImageUrl,
                CategoryID = value.CategoryID
             };
        
        }
    }
}
