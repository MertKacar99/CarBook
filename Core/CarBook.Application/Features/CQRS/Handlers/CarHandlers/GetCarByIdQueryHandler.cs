using CarBook.Application.Features.CQRS.Queries.BrandQueries;
using CarBook.Application.Features.CQRS.Queries.CarQueries;
using CarBook.Application.Features.CQRS.Results.BrandResults;
using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entitites;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarByIdQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.id);
            return new GetCarByIdQueryResult()
            {
               BrandID=values.BrandID,
               BigImageUrl= values.BigImageUrl,
               CarID=values.CarID,
               CoverImageUrl= values.CoverImageUrl,
               Fuel = values.Fuel,
               Km = values.Km,
               Luggage = values.Luggage,
               Model = values.Model,
               Seat = values.Seat,
               Transmission = values.Transmission
            };

        }
    }
}
