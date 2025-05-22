using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
using Carbook.Application.Features.Mediator.Results.StatisticsResults;

namespace CarBook.Application.Features.Mediator.Queries.StatisticsQueries
{
    public class GetCarBrandAndModelByRentPriceDailyMinQuery:IRequest<GetCarBrandAndModelByRentPriceDailyMinQueryResult>
    {
    }
}
