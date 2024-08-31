using CarBook.Application.Features.CQRS.Commands.CategoryCommands;
using CarBook.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Core;
using UdemyCarBook.Domain.Entitites;

namespace CarBook.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly IRepository<Category> _CategoryRepository;

        public UpdateCategoryCommandHandler(IRepository<Category> CategoryRepository)
        {
            _CategoryRepository = CategoryRepository;
        }

        public async Task Handle(UpdateCategoryCommand query)
        {
            var values = await _CategoryRepository.GetByIdAsync(query.CategoryID);
            values.Name = query.Name;
            await _CategoryRepository.UpdateAsync(values);

        }
    }
}
