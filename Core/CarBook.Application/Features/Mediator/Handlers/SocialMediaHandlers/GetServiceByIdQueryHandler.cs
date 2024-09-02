using CarBook.Application.Features.Mediator.Queries.SocialMediaQueries;
using CarBook.Application.Features.Mediator.Results.SocialMediaResuts;
using CarBook.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entitites;

namespace CarBook.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class GetServiceByIdQueryHandler : IRequestHandler<GetSocialMediaByIdQuery, GetSocialMediaGetByIdQueryResult>
    {
        private readonly IRepository<SocialMedia> repository;
        public GetServiceByIdQueryHandler(IRepository<SocialMedia> repository)
        {
            this.repository = repository;
        }

        public async Task<GetSocialMediaGetByIdQueryResult> Handle(GetSocialMediaByIdQuery request, CancellationToken cancellationToken)
        {
                 var value  =    await  this.repository.GetByIdAsync(request.id);
                return   new GetSocialMediaGetByIdQueryResult()
                {
                    Icon = value.Icon,
                    Name = value.Name,
                    Url = value.Url,
                };

        }
    }
}
