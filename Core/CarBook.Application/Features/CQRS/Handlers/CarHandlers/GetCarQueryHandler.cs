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
    public class GetCarQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();

            return
                values.Select(x => new GetCarQueryResult
                {
                 BrandID = x.BrandID,
                 BigImageUrl = x.BigImageUrl,
                 CarID  = x.CarID,
                 CoverImageUrl = x.CoverImageUrl,
                 Fuel = x.Fuel,
                 Km = x.Km,
                 Luggage = x.Luggage,
                 Model = x.Model,
                 Seat = x.Seat,
                 Transmission = x.Transmission
 
                }).ToList();
        }
    }
}
