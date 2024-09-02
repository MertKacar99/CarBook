using CarBook.Application.Features.Mediator.Results.SocialMediaResuts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaByIdQuery : IRequest<GetSocialMediaGetByIdQueryResult>
    {
        public GetSocialMediaByIdQuery(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
