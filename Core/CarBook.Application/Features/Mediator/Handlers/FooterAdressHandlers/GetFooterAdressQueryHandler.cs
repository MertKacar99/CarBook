using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Core.Resolving.Pipeline;
using CarBook.Application.Features.Mediator.Queries.FooterAddressQueries;
using CarBook.Application.Features.Mediator.Results.FooterAddressResults;
using CarBook.Application.Interfaces;
using MediatR;
using UdemyCarBook.Domain.Entitites;

namespace CarBook.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class GetFooterAddressQueryHandler : IRequestHandler<GetFooterAddressQuery, List<GetFooterAddressQueryResult>>
    {
        private IRepository<FooterAddress> _repository;

        //? Constructor
        public GetFooterAddressQueryHandler(IRepository<FooterAddress> repository){
            _repository = repository;
        }

        public async Task<List<GetFooterAddressQueryResult>> Handle(GetFooterAddressQuery request, CancellationToken cancellationToken)
        {
             var value =  await _repository.GetAllAsync();
             return 
                value.Select(x => new GetFooterAddressQueryResult{
                    FooterAddressID = x.FooterAddressID,
                    Adress = x.Adress,
                    Description = x.Description,
                    Email = x.Email,
                    Phone = x.Phone
                }).ToList();
        }
    }
}
