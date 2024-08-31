using CarBook.Application.Features.CQRS.Commands.BrandCommands;
using CarBook.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entitites;

namespace CarBook.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class CreateBrandCommandHandler
    {
        private readonly IRepository<Brand> _repository;

        public CreateBrandCommandHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        //create

        public async Task Handle(CreateBrandCommand query)
        {
            await _repository.CreateAsync(new Brand
            {
                Name = query.Name
            });





            //var addedValue =    new Brand() { 
            //    Name = query.Name,

            //};
            //await _repository.CreateAsync(addedValue);



        }




    }
}
