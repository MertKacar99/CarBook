using CarBook.Application.Features.CQRS.Results.BannerResults;

namespace CarBook.WebApi.Controllers
{
    internal class GetBannerByIdQuery : GetBannerByIdQueryResult
    {
        private int id;

        public GetBannerByIdQuery(int id)
        {
            this.id = id;
        }
    }
}