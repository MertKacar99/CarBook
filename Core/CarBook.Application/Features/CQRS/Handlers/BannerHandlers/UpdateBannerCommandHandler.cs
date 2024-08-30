using CarBook.Application.Features.CQRS.Commands.BannerCommands;
using CarBook.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Core;

namespace CarBook.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class UpdateBannerCommandHandler
    {
        private readonly IRepository<Banner> _bannerRepository;

        public UpdateBannerCommandHandler(IRepository<Banner> bannerRepository)
        {
            _bannerRepository = bannerRepository;
        }

        public async Task Handle(UpdateBannerCommand query)
        {
          var values =  await _bannerRepository.GetByIdAsync(query.BannerId);
          values.VideoDescription = query.VideoDescription;
          values.Title = query.Title;
          values.Description = query.Description;
          await _bannerRepository.UpdateAsync(values);
          
        }
    }
}
