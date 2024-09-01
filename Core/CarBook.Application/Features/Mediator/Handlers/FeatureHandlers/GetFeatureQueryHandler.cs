using CarBook.Application.Features.CQRS.Results.AboutResults;
using CarBook.Application.Features.Mediator.Queries.FeatureQueries;
using CarBook.Application.Features.Mediator.Results.FeatureResults;
using CarBook.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entitites;

namespace CarBook.Application.Features.Mediator.Handlers.FeatureHandlers
{
    public class GetFeatureQueryHandler : IRequestHandler<GetFeatureQuery, List<GetFeatureQueryResult>>
    {
        private readonly IRepository<Feature> _featureRepository;

        public GetFeatureQueryHandler(IRepository<Feature> featureRepository)
        {
            _featureRepository = featureRepository;
        }

        public async Task<List<GetFeatureQueryResult>> Handle(GetFeatureQuery request, CancellationToken cancellationToken)
        {
            var values = await _featureRepository.GetAllAsync();
            return
                   values.Select(x => new GetFeatureQueryResult
                   {
                     FeatureID = x.FeatureID,
                     Name = x.Name

                   }).ToList();
        }
    }
   
}
