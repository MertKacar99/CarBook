using CarBook.Application.Features.CQRS.Queries.AboutQueries;
using CarBook.Application.Features.CQRS.Results.AboutResults;
using CarBook.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entitites;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAboutByIdQueryHandler
    {
        private readonly IRepository<About> _repostiroy;

        public GetAboutByIdQueryHandler(IRepository<About> repostiroy)
        {
            _repostiroy = repostiroy;
        }

        public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIDQuery query)
        {
            var values = await _repostiroy.GetByIdAsync(query.Id);

            return new GetAboutByIdQueryResult
            {
                AboutID = values.AboutID,
                Description = values.Description,
                ImageUrl = values.ImageUrl,
                Title = values.Title
            };

        }
    }
}
