using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Results.ServiceResults
{
    public class GetServiceGetByIdQueryResult
    {
        public int ServiceID { get; set; }
        public string Title { get; set; }
        public string IconUrl { get; set; }
    }
}
