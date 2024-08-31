using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.CarInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entitites;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarWithBrandQueryHandler
    {
        private readonly ICarRepository  _repository;

        public GetCarWithBrandQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public List<GetCarWithBrandQueryResult> Handle()
        {
            var values =   _repository.GetCarsListWithBrands();

            return
                values.Select(x => new GetCarWithBrandQueryResult
                {
                    BrandName =x.Brand.Name,
                    BrandID = x.BrandID,
                    BigImageUrl = x.BigImageUrl,
                    CarID = x.CarID,
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
